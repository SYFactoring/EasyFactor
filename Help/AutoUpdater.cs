/*
 * AutoUpdater.cs
 * This class is the main component of the AutoUpdater
 *  
 * Copyright 2004 Conversive, Inc.
 * 
 */

/*
 * Conversive's C# AutoUpdater Component
 * Copyright 2004 Conversive, Inc.
 * 
 * This is a component which allows automatic software updates.
 * It is written in C# and was developed by Conversive, Inc. on April 14th 2004.
 * 
 * The C# AutoUpdater Component is licensed under the LGPL:
 * ------------------------------------------------------------------------
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 * 
 * ------------------------------------------------------------------------
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;
using ICSharpCode.SharpZipLib.Zip;

namespace CMBC.EasyFactor.Help
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class AutoUpdater : Component
    {

        private AutoUpdateConfig _autoUpdateConfig;



        //Added 11/16/2004 For Proxy Clients, Thanks George for submitting these changes
        //If true, the app will automatically download the latest version, if false the app will use the DownloadForm to prompt the user, if AutoDownload is false and DownloadForm is null, it doesn't download
        [DefaultValue(true)]
        [Description(
            "Set to True if you want the app to restart automatically, set to False if you want to use the DownloadForm to prompt the user, if AutoDownload is false and DownloadForm is null, the app will not download the latest version."
            ), Category("AutoUpdater Configuration")]
        public bool AutoDownload { get; set; }

        //If true, the app will restart automatically, if false the app will use the RestartForm to prompt the user, if AutoRestart is false and RestartForm is null, it doesn't restart
        [DefaultValue(false)]
        [Description(
            "Set to True if you want the app to restart automatically, set to False if you want to use the RestartForm to prompt the user, if AutoRestart is false and RestartForm is null, the app will not restart."
            ), Category("AutoUpdater Configuration")]
        public bool AutoRestart { get; set; }

        [BrowsableAttribute(false)]
        public AutoUpdateConfig AutoUpdateConfig
        {
            get { return _autoUpdateConfig; }
        }

        [DefaultValue(@"http://localhost/UpdateConfig.xml")]
        [Description("The URL Path to the configuration file."), Category("AutoUpdater Configuration")]
        public Uri ConfigURL { get; set; }

        [BrowsableAttribute(false)]
        public static Version CurrentAppVersion
        {
            get { return Assembly.GetEntryAssembly().GetName().Version; }
        }

        [BrowsableAttribute(false)]
        public bool IsNewVersionAvailable
        {
            get { return LatestConfigVersion > CurrentAppVersion; }
        }

        [BrowsableAttribute(false)]
        public string LatestConfigChanges
        {
            get
            {
                string stRet = null;
                //Protect against NPE's
                if (_autoUpdateConfig != null)
                    stRet = _autoUpdateConfig.LatestChanges;
                return stRet;
            }
        }

        [BrowsableAttribute(false)]
        public Version LatestConfigVersion
        {
            get
            {
                Version versionRet = null;
                //Protect against NPE's
                if (_autoUpdateConfig != null)
                    versionRet = new Version(_autoUpdateConfig.AvailableVersion);
                return versionRet;
            }
        }

        [DefaultValue(@"")]
        [Description("The UserName to authenticate with."), Category("AutoUpdater Configuration")]
        public string LogOnUserName { get; set; }

        [DefaultValue(@"")]
        [Description("The Password to authenticate with."), Category("AutoUpdater Configuration")]
        public string LogOnUserPass { get; set; }

        [DefaultValue(false)]
        [Description("Set to True if you want to use http proxy."), Category("AutoUpdater Configuration")]
        public bool ProxyEnabled { get; set; }

        [DefaultValue(@"http://myproxy.com:8080/")]
        [Description("The Proxy server URL.(For example:http://myproxy.com:port)"),
         Category("AutoUpdater Configuration")]
        public Uri ProxyURL { get; set; }

        public Form RestartForm { get; set; }




        delegate void AutoUpdateCompleteEventHandler();
        delegate void AutoUpdateErrorEventHandler(string stMessage, Exception autoUpdateError);
        delegate void ConfigFileDownloadedEventHandler(bool isNewVersionAvailable);

        //?Delegates?(3)?
        //?Events?(3)?
        event AutoUpdateCompleteEventHandler OnAutoUpdateComplete;

        event AutoUpdateErrorEventHandler OnAutoUpdateError;

        event ConfigFileDownloadedEventHandler OnConfigFileDownloaded;




        //?Public?Methods?(3)?
        /// <summary>
        /// TryUpdate: Invoke this method if you just want to load the config without autoupdating
        /// </summary>
        public void LoadConfig()
        {
            var backgroundLoadConfigThread = new Thread(LoadConfigThread) { IsBackground = true };
            backgroundLoadConfigThread.Start();
        }

        /// <summary>
        /// TryUpdate: Invoke this method when you are ready to run the update checking thread
        /// </summary>
        public void TryUpdate()
        {
            var backgroundThread = new Thread(UpdateThread);
            backgroundThread.SetApartmentState(ApartmentState.STA);
            backgroundThread.IsBackground = true;
            backgroundThread.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        public void TryUpdateBackground()
        {
            var backgroundThread = new Thread(UpdateThreadBackground);
            backgroundThread.SetApartmentState(ApartmentState.STA);
            backgroundThread.IsBackground = true;
            backgroundThread.Start();
        }

        //?Private?Methods?(8)?
        //restart()
        private void ConfigOnLoadConfigError(string stMessage, Exception e)
        {
            SendAutoUpdateError(stMessage, e);
        }

        /// <summary>
        /// 
        /// </summary>
        private static void DeletePastUpdateDir()
        {
            string currentUpdate = String.Format("update{0:yyyyMMdd}", DateTime.Today);
            var tempRoot = new DirectoryInfo(Path.GetTempPath());
            try
            {
                foreach (DirectoryInfo dir in
                    tempRoot.GetDirectories().Where(dir => dir.Name.StartsWith("update") && dir.Name != currentUpdate))
                {
                    dir.Delete(true);
                }
            }
            catch (Exception)
            {
                MessageBoxEx.Show("清除过去更新程序失败");
            }
        }

        //updateThread()
        /// <summary>
        /// downloadFile: Download a file from the specified url and copy it to the specified path
        /// </summary>
        private bool DownloadFile(Uri url, string path)
        {
            try
            {
                //create web request/response

                var request = (HttpWebRequest)WebRequest.Create(url);
                //Request.Headers.Add("Translate: f"); //Commented out 11/16/2004 Matt Palmerlee, this Header is more for DAV and causes a known security issue
                request.Credentials = !String.IsNullOrEmpty(LogOnUserName) ? new NetworkCredential(LogOnUserName, LogOnUserPass) : CredentialCache.DefaultCredentials;

                //Added 11/16/2004 For Proxy Clients, Thanks George for submitting these changes
                if (ProxyEnabled)
                    request.Proxy = new WebProxy(ProxyURL);

                var response = (HttpWebResponse)request.GetResponse();

                Stream respStream = response.GetResponseStream();

                //Do the Download
                var buffer = new byte[4096];

                FileStream fs = File.Open(path, FileMode.Create, FileAccess.Write);

                int length = respStream.Read(buffer, 0, 4096);
                while (length > 0)
                {
                    fs.Write(buffer, 0, length);
                    length = respStream.Read(buffer, 0, 4096);
                }
                fs.Close();
            }
            catch (Exception e)
            {
                string stMessage = "Problem downloading and copying file from: " + url + " to: " + path + " with: " +
                                   e.Message;
                MessageBoxEx.Show(stMessage, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (File.Exists(path))
                    File.Delete(path);
                SendAutoUpdateError(stMessage, e);
                return false;
            }
            return true;
        }

        //TryUpdate()
        /// <summary>
        /// loadConfig: This method just loads the config file so the app can check the versions manually
        /// </summary>
        private void LoadConfigThread()
        {
            var config = new AutoUpdateConfig();
            config.OnLoadConfigError += ConfigOnLoadConfigError;

            //Do the load of the config file
            if (config.LoadConfig(ConfigURL, LogOnUserName, LogOnUserPass, ProxyURL, ProxyEnabled))
            {
                _autoUpdateConfig = config;
                if (OnConfigFileDownloaded != null)
                {
                    OnConfigFileDownloaded(IsNewVersionAvailable);
                }
            }
            //else
            //	MessageBox.Show("Problem loading config file, from: " + this.ConfigURL);
        }

        //unzip(string stZipPath, string stDestPath)
        /// <summary>
        /// restart: Restart the app, the AppStarter will be responsible for actually restarting the main application.
        /// </summary>
        private static void Restart()
        {
            string stUpdateName = String.Format("update{0:yyyyMMdd}", DateTime.Now);
            // DirectoryInfo diDest = new DirectoryInfo(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
            string stDest = Path.GetTempPath() + stUpdateName + Path.DirectorySeparatorChar;
            string[] exeFileList = Directory.GetFiles(stDest, "*.msi");
            if (exeFileList.Length > 0)
            {
                Environment.ExitCode = 2; //the surrounding AppStarter must look for this to restart the app.
                Application.Exit();
                var ps = new Process { StartInfo = { FileName = exeFileList[0] } };
                ps.Start();
            }
        }

        private void SendAutoUpdateError(string stMessage, Exception e)
        {
            if (OnAutoUpdateError != null)
                OnAutoUpdateError(stMessage, e);
        }

        //downloadFile(string url, string path)
        /// <summary>
        /// unzip: Open the zip file specified by stZipPath, into the stDestPath Directory
        /// </summary>
        private static void Unzip(string stZipPath, string stDestPath)
        {
            var s = new ZipInputStream(File.OpenRead(stZipPath));

            ZipEntry theEntry;
            while ((theEntry = s.GetNextEntry()) != null)
            {
                string fileName = stDestPath + Path.GetDirectoryName(theEntry.Name) + Path.DirectorySeparatorChar +
                                  Path.GetFileName(theEntry.Name);

                //create directory for file (if necessary)
                Directory.CreateDirectory(Path.GetDirectoryName(fileName));

                if (!theEntry.IsDirectory)
                {
                    FileStream streamWriter = File.Create(fileName);

                    var data = new byte[2048];
                    try
                    {
                        while (true)
                        {
                            int size = s.Read(data, 0, data.Length);
                            if (size > 0)
                            {
                                streamWriter.Write(data, 0, size);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                    }

                    streamWriter.Close();
                }
            }
            s.Close();
        }

        //TryUpdate()		
        /// <summary>
        /// updateThread: This is the Thread that runs for checking updates against the config file
        /// </summary>
        private void UpdateThread()
        {
            string stUpdateName = String.Format("update{0:yyyyMMdd}", DateTime.Now);
            if (_autoUpdateConfig == null) //if we haven't already downloaded the config file, do so now
                LoadConfigThread();
            if (_autoUpdateConfig != null) //make sure we were able to download it
            {
                //Check the file for an update
                if (LatestConfigVersion > CurrentAppVersion)
                {
                    DialogResult dr = MessageBoxEx.Show(String.Format("存在新版本：{0}，是否下载？", LatestConfigVersion),
                                                        MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);
                    //Download file if the user requests or AutoDownload is True
                    if (dr == DialogResult.Yes)
                    {
                        //DirectoryInfo diDest = new DirectoryInfo(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));

                        string stPath = Path.GetTempPath() + stUpdateName + ".zip";
                        int count = 1;
                        while (File.Exists(stPath))
                        {
                            stPath = Path.GetTempPath() + stUpdateName + "_" + (count++) + ".zip";
                        }
                        //There is a new version available
                        if (DownloadFile(_autoUpdateConfig.AppFileURL, stPath))
                        {
                            //MessageBox.Show("Downloaded New File");
                            string stDest = stPath.Substring(0, stPath.Length - 4) + Path.DirectorySeparatorChar;
                            //Extract Zip File
                            Unzip(stPath, stDest);
                            //Delete Zip File
                            File.Delete(stPath);
                            if (OnAutoUpdateComplete != null)
                            {
                                OnAutoUpdateComplete();
                            }

                            DeletePastUpdateDir();
                            //Restart App if Necessary
                            //If true, the app will restart automatically, if false the app will use the RestartForm to prompt the user, if RestartForm is null, it doesn't restart
                            if (AutoRestart || (RestartForm != null && RestartForm.ShowDialog() == DialogResult.Yes))
                                Restart();
                            //else don't restart
                        }
                        //else
                        //	MessageBox.Show("Didn't Download File");
                    }
                }
                else
                {
                    MessageBoxEx.Show("当前系统已经是最新版本：" + CurrentAppVersion);
                }
            }
            else
            {
                MessageBoxEx.Show("检查更新失败，无法访问更新服务器");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateThreadBackground()
        {
            string stUpdateName = String.Format("update{0:yyyyMMdd}", DateTime.Now);
            if (_autoUpdateConfig == null) //if we haven't already downloaded the config file, do so now
                LoadConfigThread();
            if (_autoUpdateConfig != null) //make sure we were able to download it
            {
                //Check the file for an update
                if (LatestConfigVersion > CurrentAppVersion)
                {
                    string stPath = Path.GetTempPath() + stUpdateName + ".zip";
                    int count = 1;
                    while (File.Exists(stPath))
                    {
                        stPath = Path.GetTempPath() + stUpdateName + "_" + (count++) + ".zip";
                    }
                    //There is a new version available
                    if (DownloadFile(_autoUpdateConfig.AppFileURL, stPath))
                    {
                        //MessageBox.Show("Downloaded New File");
                        string stDest = stPath.Substring(0, stPath.Length - 4) + Path.DirectorySeparatorChar;
                        //Extract Zip File
                        Unzip(stPath, stDest);
                        //Delete Zip File
                        File.Delete(stPath);
                        if (OnAutoUpdateComplete != null)
                        {
                            OnAutoUpdateComplete();
                        }

                        DeletePastUpdateDir();
                        //Restart App if Necessary
                        //If true, the app will restart automatically, if false the app will use the RestartForm to prompt the user, if RestartForm is null, it doesn't restart
                        if (RestartForm != null && RestartForm.ShowDialog() == DialogResult.Yes)
                            Restart();
                        //else don't restart
                    }
                    //else
                    //	MessageBox.Show("Didn't Download File")
                }
            }
        }
    }

    //class AutoUpdater
}

//namespace Conversive.AutoUpdater
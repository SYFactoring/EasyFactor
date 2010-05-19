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
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using System.Diagnostics;
using DevComponents.DotNetBar;
using CMBC.EasyFactor.Utils;
using CMBC.EasyFactor.Utils.ConstStr;

namespace CMBC.EasyFactor.Help
{
    /// <summary>
    /// Summary description for Class1.
    /// </summary>
    public class AutoUpdater : Component
    {
		#region?Fields?(9)?

        private bool _AutoDownload;
        private bool _AutoRestart;
        private AutoUpdateConfig _AutoUpdateConfig;
        private Uri _ConfigURL;
        private string _LogOnUserName;
        private string _LogOnUserPass;
        //Added 11/16/2004 For Proxy Clients, Thanks George for submitting these changes
        private bool _ProxyEnabled;
        //Added 11/16/2004 For Proxy Clients, Thanks George for submitting these changes
        private Uri _ProxyURL;
        private Form _RestartForm;

		#endregion?Fields?

		#region?Constructors?(1)?

        public AutoUpdater()
        {

        }

		#endregion?Constructors?

		#region?Properties?(13)?

        //If true, the app will automatically download the latest version, if false the app will use the DownloadForm to prompt the user, if AutoDownload is false and DownloadForm is null, it doesn't download
        [DefaultValue(true)]
        [Description("Set to True if you want the app to restart automatically, set to False if you want to use the DownloadForm to prompt the user, if AutoDownload is false and DownloadForm is null, the app will not download the latest version."),
        Category("AutoUpdater Configuration")]
        public bool AutoDownload
        { get { return _AutoDownload; } set { _AutoDownload = value; } }

        //If true, the app will restart automatically, if false the app will use the RestartForm to prompt the user, if AutoRestart is false and RestartForm is null, it doesn't restart
        [DefaultValue(false)]
        [Description("Set to True if you want the app to restart automatically, set to False if you want to use the RestartForm to prompt the user, if AutoRestart is false and RestartForm is null, the app will not restart."),
        Category("AutoUpdater Configuration")]
        public bool AutoRestart
        { get { return _AutoRestart; } set { _AutoRestart = value; } }

        [BrowsableAttribute(false)]
        public AutoUpdateConfig AutoUpdateConfig
        { get { return _AutoUpdateConfig; } }

        [DefaultValue(@"http://localhost/UpdateConfig.xml")]
        [Description("The URL Path to the configuration file."),
        Category("AutoUpdater Configuration")]
        public Uri ConfigURL
        { get { return _ConfigURL; } set { _ConfigURL = value; } }

        [BrowsableAttribute(false)]
        public static Version CurrentAppVersion
        { get { return System.Reflection.Assembly.GetEntryAssembly().GetName().Version; } }

        [BrowsableAttribute(false)]
        public string LatestConfigChanges
        {
            get
            {
                string stRet = null;
                //Protect against NPE's
                if (this._AutoUpdateConfig != null)
                    stRet = _AutoUpdateConfig.LatestChanges;
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
                if (this._AutoUpdateConfig != null)
                    versionRet = new Version(this._AutoUpdateConfig.AvailableVersion);
                return versionRet;
            }
        }

        [DefaultValue(@"")]
        [Description("The UserName to authenticate with."),
        Category("AutoUpdater Configuration")]
        public string LogOnUserName
        { get { return _LogOnUserName; } set { _LogOnUserName = value; } }

        [DefaultValue(@"")]
        [Description("The Password to authenticate with."),
        Category("AutoUpdater Configuration")]
        public string LogOnUserPass
        { get { return _LogOnUserPass; } set { _LogOnUserPass = value; } }

        [BrowsableAttribute(false)]
        public bool IsNewVersionAvailable
        { get { return this.LatestConfigVersion > AutoUpdater.CurrentAppVersion; } }

        [DefaultValue(false)]
        [Description("Set to True if you want to use http proxy."),
        Category("AutoUpdater Configuration")]
        public bool ProxyEnabled
        { get { return _ProxyEnabled; } set { _ProxyEnabled = value; } }

        [DefaultValue(@"http://myproxy.com:8080/")]
        [Description("The Proxy server URL.(For example:http://myproxy.com:port)"),
        Category("AutoUpdater Configuration")]
        public Uri ProxyURL
        { get { return _ProxyURL; } set { _ProxyURL = value; } }

        public Form RestartForm
        { get { return _RestartForm; } set { _RestartForm = value; } }

		#endregion?Properties?

		#region?Delegates?and?Events?(6)?

		//?Delegates?(3)?

        public delegate void AutoUpdateCompleteEventHandler();
        public delegate void AutoUpdateErrorEventHandler(string stMessage, Exception autoUpdateError);
        public delegate void ConfigFileDownloadedEventHandler(bool isNewVersionAvailable);
		//?Events?(3)?

        public event AutoUpdateCompleteEventHandler OnAutoUpdateComplete;

        public event AutoUpdateErrorEventHandler OnAutoUpdateError;

        public event ConfigFileDownloadedEventHandler OnConfigFileDownloaded;

		#endregion?Delegates?and?Events?

		#region?Methods?(11)?

		//?Public?Methods?(3)?

        /// <summary>
        /// TryUpdate: Invoke this method if you just want to load the config without autoupdating
        /// </summary>
        public void LoadConfig()
        {
            Thread backgroundLoadConfigThread = new Thread(new ThreadStart(this.loadConfigThread));
            backgroundLoadConfigThread.IsBackground = true;
            backgroundLoadConfigThread.Start();
        }

        /// <summary>
        /// TryUpdate: Invoke this method when you are ready to run the update checking thread
        /// </summary>
        public void TryUpdate()
        {
            Thread backgroundThread = new Thread(new ThreadStart(this.updateThread));
            backgroundThread.SetApartmentState(ApartmentState.STA);
            backgroundThread.IsBackground = true;
            backgroundThread.Start();
        }

        /// <summary>
        /// 
        /// </summary>
        public void TryUpdateBackground()
        {
            Thread backgroundThread = new Thread(new ThreadStart(this.updateThreadBackground));
            backgroundThread.SetApartmentState(ApartmentState.STA);
            backgroundThread.IsBackground = true;
            backgroundThread.Start();
        }
		//?Private?Methods?(8)?

        //restart()
        private void config_OnLoadConfigError(string stMessage, Exception e)
        {
            this.sendAutoUpdateError(stMessage, e);
        }

        //updateThread()
        /// <summary>
        /// downloadFile: Download a file from the specified url and copy it to the specified path
        /// </summary>
        private bool downloadFile(Uri url, string path)
        {
            try
            {
                //create web request/response
                HttpWebResponse Response;
                HttpWebRequest Request;

                Request = (HttpWebRequest)HttpWebRequest.Create(url);
                //Request.Headers.Add("Translate: f"); //Commented out 11/16/2004 Matt Palmerlee, this Header is more for DAV and causes a known security issue
                if (!String.IsNullOrEmpty(this.LogOnUserName))
                    Request.Credentials = new NetworkCredential(this.LogOnUserName, this.LogOnUserPass);
                else
                    Request.Credentials = CredentialCache.DefaultCredentials;

                //Added 11/16/2004 For Proxy Clients, Thanks George for submitting these changes
                if (this.ProxyEnabled == true)
                    Request.Proxy = new WebProxy(this.ProxyURL);

                Response = (HttpWebResponse)Request.GetResponse();

                Stream respStream = null;
                respStream = Response.GetResponseStream();

                //Do the Download
                byte[] buffer = new byte[4096];
                int length;

                FileStream fs = File.Open(path, FileMode.Create, FileAccess.Write);

                length = respStream.Read(buffer, 0, 4096);
                while (length > 0)
                {
                    fs.Write(buffer, 0, length);
                    length = respStream.Read(buffer, 0, 4096);
                }
                fs.Close();
            }
            catch (Exception e)
            {
                string stMessage = "Problem downloading and copying file from: " + url + " to: " + path;
                MessageBoxEx.Show(stMessage, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (File.Exists(path))
                    File.Delete(path);
                this.sendAutoUpdateError(stMessage, e);
                return false;
            }
            return true;
        }

        //TryUpdate()
        /// <summary>
        /// loadConfig: This method just loads the config file so the app can check the versions manually
        /// </summary>
        private void loadConfigThread()
        {
            AutoUpdateConfig config = new AutoUpdateConfig();
            config.OnLoadConfigError += new AutoUpdateConfig.LoadConfigErrorEventHandler(config_OnLoadConfigError);

            //Do the load of the config file
            if (config.LoadConfig(this.ConfigURL, this.LogOnUserName, this.LogOnUserPass, this.ProxyURL, this.ProxyEnabled))
            {
                this._AutoUpdateConfig = config;
                if (this.OnConfigFileDownloaded != null)
                {
                    this.OnConfigFileDownloaded(this.IsNewVersionAvailable);
                }
            }
            //else
            //	MessageBox.Show("Problem loading config file, from: " + this.ConfigURL);
        }

        //unzip(string stZipPath, string stDestPath)
        /// <summary>
        /// restart: Restart the app, the AppStarter will be responsible for actually restarting the main application.
        /// </summary>
        private void restart()
        {
            string stUpdateName = String.Format("update{0:yyyyMMdd}", DateTime.Now);
            // DirectoryInfo diDest = new DirectoryInfo(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));
            string stDest = Path.GetTempPath() + stUpdateName + System.IO.Path.DirectorySeparatorChar;
            string[] exeFileList = Directory.GetFiles(stDest, "*.msi");
            if (exeFileList.Length > 0)
            {
                Environment.ExitCode = 2; //the surrounding AppStarter must look for this to restart the app.
                Application.Exit();
                Process ps = new Process();
                ps.StartInfo.FileName = exeFileList[0];
                ps.Start();

            }
        }

        private void sendAutoUpdateError(string stMessage, Exception e)
        {
            if (this.OnAutoUpdateError != null)
                this.OnAutoUpdateError(stMessage, e);
        }

        //downloadFile(string url, string path)
        /// <summary>
        /// unzip: Open the zip file specified by stZipPath, into the stDestPath Directory
        /// </summary>
        private void unzip(string stZipPath, string stDestPath)
        {
            ZipInputStream s = new ZipInputStream(File.OpenRead(stZipPath));

            ZipEntry theEntry;
            while ((theEntry = s.GetNextEntry()) != null)
            {

                string fileName = stDestPath + Path.GetDirectoryName(theEntry.Name) + System.IO.Path.DirectorySeparatorChar + Path.GetFileName(theEntry.Name);

                //create directory for file (if necessary)
                Directory.CreateDirectory(Path.GetDirectoryName(fileName));

                if (!theEntry.IsDirectory)
                {
                    FileStream streamWriter = File.Create(fileName);

                    int size = 2048;
                    byte[] data = new byte[2048];
                    try
                    {
                        while (true)
                        {
                            size = s.Read(data, 0, data.Length);
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
                    catch (Exception) { }

                    streamWriter.Close();
                }
            }
            s.Close();
        }

        //TryUpdate()		
        /// <summary>
        /// updateThread: This is the Thread that runs for checking updates against the config file
        /// </summary>
        private void updateThread()
        {
            string stUpdateName = String.Format("update{0:yyyyMMdd}", DateTime.Now);
            if (this._AutoUpdateConfig == null)//if we haven't already downloaded the config file, do so now
                this.loadConfigThread();
            if (this._AutoUpdateConfig != null)//make sure we were able to download it
            {
                //Check the file for an update
                if (this.LatestConfigVersion > AutoUpdater.CurrentAppVersion)
                {
                    DialogResult dr = MessageBoxEx.Show(String.Format("存在新版本：{0}，是否下载？", LatestConfigVersion), MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Download file if the user requests or AutoDownload is True
                    if (dr == DialogResult.Yes)
                    {
                        //DirectoryInfo diDest = new DirectoryInfo(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location));

                        string stPath = Path.GetTempPath() + stUpdateName + ".zip";
                        //There is a new version available
                        if (this.downloadFile(this._AutoUpdateConfig.AppFileURL, stPath))
                        {
                            //MessageBox.Show("Downloaded New File");
                            string stDest = Path.GetTempPath() + stUpdateName + System.IO.Path.DirectorySeparatorChar;
                            //Extract Zip File
                            this.unzip(stPath, stDest);
                            //Delete Zip File
                            File.Delete(stPath);
                            if (this.OnAutoUpdateComplete != null)
                            {
                                this.OnAutoUpdateComplete();
                            }
                            //Restart App if Necessary
                            //If true, the app will restart automatically, if false the app will use the RestartForm to prompt the user, if RestartForm is null, it doesn't restart
                            if (this.AutoRestart || (this.RestartForm != null && this.RestartForm.ShowDialog() == DialogResult.Yes))
                                this.restart();
                            //else don't restart
                        }
                        //else
                        //	MessageBox.Show("Didn't Download File");
                    }

                }
                else
                {
                    MessageBoxEx.Show("当前系统已经是最新版本：" + CurrentAppVersion.ToString());
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
        private void updateThreadBackground()
        {
            string stUpdateName = String.Format("update{0:yyyyMMdd}", DateTime.Now);
            if (this._AutoUpdateConfig == null)//if we haven't already downloaded the config file, do so now
                this.loadConfigThread();
            if (this._AutoUpdateConfig != null)//make sure we were able to download it
            {
                //Check the file for an update
                if (this.LatestConfigVersion > AutoUpdater.CurrentAppVersion)
                {
                    string stPath = Path.GetTempPath() + stUpdateName + ".zip";
                    //There is a new version available
                    if (this.downloadFile(this._AutoUpdateConfig.AppFileURL, stPath))
                    {
                        //MessageBox.Show("Downloaded New File");
                        string stDest = Path.GetTempPath() + stUpdateName + System.IO.Path.DirectorySeparatorChar;
                        //Extract Zip File
                        this.unzip(stPath, stDest);
                        //Delete Zip File
                        File.Delete(stPath);
                        if (this.OnAutoUpdateComplete != null)
                        {
                            this.OnAutoUpdateComplete();
                        }
                        //Restart App if Necessary
                        //If true, the app will restart automatically, if false the app will use the RestartForm to prompt the user, if RestartForm is null, it doesn't restart
                        if (this.RestartForm != null && this.RestartForm.ShowDialog() == DialogResult.Yes)
                            this.restart();
                        //else don't restart
                    }
                    //else
                    //	MessageBox.Show("Didn't Download File")
                }
            }
        }

		#endregion?Methods?
    }//class AutoUpdater
}//namespace Conversive.AutoUpdater

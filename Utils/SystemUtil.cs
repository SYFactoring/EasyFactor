//-----------------------------------------------------------------------
// <copyright file="SystemUtil.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMBC.EasyFactor.Properties;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Checksums;

namespace CMBC.EasyFactor.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public static class SystemUtil
    {

        private static readonly Dictionary<string, string> DbDictionary = InitializeDbDictionary();

        /// <summary>
        /// 
        /// </summary>
        public static string ConnectionString
        {
            get { return Settings.Default.FOSConnectionString; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string DataBaseName
        {
            get { return DbDictionary["Initial Catalog"]; }
        }

        //?Public?Methods?(2)?
        /// <summary>
        /// 
        /// </summary>
        public static string DesktopPath
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.Desktop); }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string Password
        {
            get { return DbDictionary["Password"]; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string ServerName
        {
            get { return DbDictionary["Data Source"]; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string SystemInformationStr
        {
            get
            {
                var sb = new StringBuilder();

                //获取操作系统设置
                sb.AppendLine("获取操作系统设置");
                sb.AppendLine("计算机名 : " + SystemInformation.ComputerName);
                sb.AppendLine("是否已连接网络 : " + SystemInformation.Network);
                sb.AppendLine("用户域 : " + SystemInformation.UserDomainName);
                sb.AppendLine("当前线程用户名   : " + SystemInformation.UserName);
                sb.AppendLine("启动方式 : " + SystemInformation.BootMode);
                sb.AppendLine("菜单的字体 : " + SystemInformation.MenuFont);
                sb.AppendLine("显示器的数目 : " + SystemInformation.MonitorCount);
                sb.AppendLine("鼠标已安装 : " + SystemInformation.MousePresent);
                sb.AppendLine("鼠标按钮数    : " + SystemInformation.MouseButtons);
                sb.AppendLine("是否交互模式    : " + SystemInformation.UserInteractive);
                sb.AppendLine("屏幕界限: " + SystemInformation.VirtualScreen);
                sb.AppendLine();

                //获取程序运行的相关信息.
                sb.AppendLine("获取程序运行的相关信息");
                sb.AppendLine("命令行:" + Environment.CommandLine);
                sb.AppendLine("命令行参数:" + String.Join(", ", Environment.GetCommandLineArgs()));
                sb.AppendLine("当前目录:" + Environment.CurrentDirectory);
                sb.AppendLine("操作系统版本:" + Environment.OSVersion);
                sb.AppendLine("系统目录:" + Environment.SystemDirectory);
                sb.AppendLine("用户域:" + Environment.UserDomainName);
                sb.AppendLine("CLR版本:" + Environment.Version);
                sb.AppendLine("系统启动后经过的毫秒:" + Environment.TickCount);
                sb.AppendLine("进程上下文的物理内存量:" + Environment.WorkingSet);

                string[] drives = Environment.GetLogicalDrives();
                sb.AppendLine("本机磁盘驱动器: " + String.Join(", ", drives));

                // 获取本机所有环境变量
                sb.AppendLine();
                sb.AppendLine("获取本机所有环境变量");
                IDictionary environmentVariables = Environment.GetEnvironmentVariables();
                foreach (DictionaryEntry de in environmentVariables)
                {
                    sb.AppendLine(de.Key + "=" + de.Value);
                }

                return sb.ToString();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string UserName
        {
            get { return DbDictionary["User ID"]; }
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainDir"></param>
        /// <param name="extensions"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public static string GetAllDirFilesRecurse(FileSystemInfo mainDir, string[] extensions, int level)
        {
            if (mainDir == null)
            {
                return string.Empty;
            }

            if (level < mainDir.FullName.Split(new[] { '\\' }).Length - 1)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            if (mainDir is DirectoryInfo)
            {
                try
                {
                    FileSystemInfo[] items = ((DirectoryInfo)mainDir).GetFileSystemInfos();
                    foreach (FileSystemInfo item in items)
                    {
                        if ((item as DirectoryInfo) != null)
                        {
                            string result = GetAllDirFilesRecurse(item, extensions, level);
                            if (!String.IsNullOrEmpty(result))
                            {
                                sb.AppendLine(result);
                            }
                        }
                        else if ((item as FileInfo) != null && ((FileInfo)item).Length > 1024000 &&
                                 extensions.Contains(item.Extension.ToLower(CultureInfo.CurrentCulture)))
                        {
                            sb.AppendLine("FILE: " + item.FullName);
                        }
                    }
                }
                catch (Exception e1)
                {
                    sb.AppendLine(e1.Message);
                    return sb.ToString();
                }
            }
            else if (mainDir is FileInfo && ((FileInfo)mainDir).Length > 102400 &&
                     extensions.Contains(mainDir.Extension.ToLower(CultureInfo.CurrentCulture)))
            {
                sb.AppendLine("FILE: " + mainDir.FullName);
            }


            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="folderToZip"></param>
        /// <param name="zipedFile"></param>
        /// <returns></returns>
        public static bool ZipDirectory(string folderToZip, string zipedFile)
        {
            if (!Directory.Exists(folderToZip))
            {
                return false;
            }

            var s = new ZipOutputStream(File.Create(zipedFile));
            s.SetLevel(6);

            bool res = ZipFileDictory(folderToZip, s, "");

            s.Finish();
            s.Close();

            return res;
        }

        /// <summary>
        /// 
        /// </summary>
        private static Dictionary<string, string> InitializeDbDictionary()
        {
            string connectionString = Settings.Default.FOSConnectionString;
            var result = new Dictionary<string, string>();
            foreach (string pair in connectionString.Split(new[] { ';' }))
            {
                string key = pair.Split(new[] { '=' })[0].Trim();
                string value = pair.Split(new[] { '=' })[1].Trim();
                result.Add(key, value);
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="folderToZip"></param>
        /// <param name="s"></param>
        /// <param name="parentFolderName"></param>
        /// <returns></returns>
        private static bool ZipFileDictory(string folderToZip, ZipOutputStream s, string parentFolderName)
        {
            bool res = true;
            ZipEntry entry;
            FileStream fs = null;
            var crc = new Crc32();

            try
            {

                entry = new ZipEntry(Path.Combine(parentFolderName, Path.GetFileName(folderToZip) + "/"));
                s.PutNextEntry(entry);
                s.Flush();


                string[] filenames = Directory.GetFiles(folderToZip);
                foreach (string file in filenames)
                {
                    fs = File.OpenRead(file);

                    var buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    entry = new ZipEntry(Path.Combine(parentFolderName, Path.GetFileName(folderToZip) + "/" + Path.GetFileName(file)))
                                {
                                    DateTime = DateTime.Now,
                                    Size = fs.Length
                                };

                    fs.Close();

                    crc.Reset();
                    crc.Update(buffer);

                    entry.Crc = crc.Value;

                    s.PutNextEntry(entry);

                    s.Write(buffer, 0, buffer.Length);
                }
            }
            catch
            {
                res = false;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            string[] folders = Directory.GetDirectories(folderToZip);
            if (folders.Any(folder => !ZipFileDictory(folder, s, Path.Combine(parentFolderName, Path.GetFileName(folderToZip)))))
            {
                return false;
            }

            return res;
        }
    }
}
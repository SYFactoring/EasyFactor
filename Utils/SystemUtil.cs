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

                //��ȡ����ϵͳ����
                sb.AppendLine("��ȡ����ϵͳ����");
                sb.AppendLine("������� : " + SystemInformation.ComputerName);
                sb.AppendLine("�Ƿ����������� : " + SystemInformation.Network);
                sb.AppendLine("�û��� : " + SystemInformation.UserDomainName);
                sb.AppendLine("��ǰ�߳��û���   : " + SystemInformation.UserName);
                sb.AppendLine("������ʽ : " + SystemInformation.BootMode);
                sb.AppendLine("�˵������� : " + SystemInformation.MenuFont);
                sb.AppendLine("��ʾ������Ŀ : " + SystemInformation.MonitorCount);
                sb.AppendLine("����Ѱ�װ : " + SystemInformation.MousePresent);
                sb.AppendLine("��갴ť��    : " + SystemInformation.MouseButtons);
                sb.AppendLine("�Ƿ񽻻�ģʽ    : " + SystemInformation.UserInteractive);
                sb.AppendLine("��Ļ����: " + SystemInformation.VirtualScreen);
                sb.AppendLine();

                //��ȡ�������е������Ϣ.
                sb.AppendLine("��ȡ�������е������Ϣ");
                sb.AppendLine("������:" + Environment.CommandLine);
                sb.AppendLine("�����в���:" + String.Join(", ", Environment.GetCommandLineArgs()));
                sb.AppendLine("��ǰĿ¼:" + Environment.CurrentDirectory);
                sb.AppendLine("����ϵͳ�汾:" + Environment.OSVersion);
                sb.AppendLine("ϵͳĿ¼:" + Environment.SystemDirectory);
                sb.AppendLine("�û���:" + Environment.UserDomainName);
                sb.AppendLine("CLR�汾:" + Environment.Version);
                sb.AppendLine("ϵͳ�����󾭹��ĺ���:" + Environment.TickCount);
                sb.AppendLine("���������ĵ������ڴ���:" + Environment.WorkingSet);

                string[] drives = Environment.GetLogicalDrives();
                sb.AppendLine("��������������: " + String.Join(", ", drives));

                // ��ȡ�������л�������
                sb.AppendLine();
                sb.AppendLine("��ȡ�������л�������");
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
        /// Create a zip archive.
        /// </summary>
        /// <param name="directory">The directory to zip.</param> 
        /// <param name="filename">The filename.</param>
        public static bool PackFiles(string directory, string filename)
        {
            bool result = true;
            var fz = new FastZip();
            fz.CreateEmptyDirectories = true;
            try
            {
                fz.CreateZip(filename, directory, true, "");
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Unpacks the files.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="dir"></param>
        /// <returns>if succeed return true,otherwise false.</returns>
        public static bool UnpackFiles(string file, string dir)
        {
            bool result = true;
            try
            {
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                var s = new ZipInputStream(File.OpenRead(file));

                ZipEntry theEntry;
                while ((theEntry = s.GetNextEntry()) != null)
                {
                    string directoryName = Path.GetDirectoryName(theEntry.Name);
                    string fileName = Path.GetFileName(theEntry.Name);
                    if (directoryName != String.Empty)
                        Directory.CreateDirectory(dir + directoryName);
                    if (fileName != String.Empty)
                    {
                        FileStream streamWriter = File.Create(dir + theEntry.Name);

                        var data = new byte[2048];
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
                        streamWriter.Close();
                    }
                }
                s.Close();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        private static
        Dictionary<string, string> InitializeDbDictionary
        ()
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
    }
}
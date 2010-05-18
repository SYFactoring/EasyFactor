//-----------------------------------------------------------------------
// <copyright file="SystemUtil.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils
{
    using System;
    using System.Collections;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public sealed class SystemUtil
    {
        /// <summary>
        /// 
        /// </summary>
        private SystemUtil()
        {
        }

        #region?Methods?(2)?

        //?Public?Methods?(2)?

        public static string GetAllDirFilesRecurse(FileSystemInfo mainDir, string[] extensions, int level)
        {
            if (mainDir == null)
            {
                return string.Empty;
            }

            if (level < mainDir.FullName.Split(new char[] { '\\' }).Length - 1)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
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
                        else if ((item as FileInfo) != null && ((FileInfo)item).Length > 1024000 && extensions.Contains(item.Extension.ToLower(CultureInfo.CurrentCulture)))
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
            else if (mainDir is FileInfo && ((FileInfo)mainDir).Length > 102400 && extensions.Contains(mainDir.Extension.ToLower(CultureInfo.CurrentCulture)))
            {
                sb.AppendLine("FILE: " + mainDir.FullName);
            }


            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        public static string DesktopPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string SystemInformationStr
        {
            get
            {
                StringBuilder sb = new StringBuilder();

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

        #endregion?Methods?
    }
}

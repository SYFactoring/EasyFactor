using System;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Linq;

namespace CMBC.EasyFactor.Utils
{
    class SystemUtil
    {
        public static string GetAllDirFilesRecurse(FileSystemInfo mainDir, string[] extensions, int level)
        {
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
                        if (item is DirectoryInfo)
                        {
                            string result = GetAllDirFilesRecurse(item, extensions, level);
                            if (!String.IsNullOrEmpty(result))
                            {
                                sb.AppendLine(result);
                            }
                        }
                        else if (item is FileInfo && extensions.Contains(item.Extension))
                        {
                            sb.AppendLine("FILE: " + item.FullName);
                        }
                    }
                }
                catch (Exception)
                {
                    return sb.ToString();
                }
            }
            else if (mainDir is FileInfo && extensions.Contains(mainDir.Extension))
            {
                sb.AppendLine("FILE: " + mainDir.FullName);
            }


            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetSystemInformation()
        {
            StringBuilder sb = new StringBuilder();

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
}

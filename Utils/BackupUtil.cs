using System;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;

namespace CMBC.EasyFactor.Utils
{
    /// <summary>
    /// 
    /// </summary>
    class BackupUtil
    {
        /// <summary>
        /// 
        /// </summary>
        private BackupUtil()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="databaseName"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="serverName"></param>
        /// <param name="destinationPath"></param>
        public static void BackupDatabase(String connectionStr, String databaseName, String destinationPath)
        {
            //ServerConnection connection = new ServerConnection(serverName, userName, password);
            //Server sqlServer = new Server(connection);
            ServerConnection sqlConnection = new ServerConnection(new SqlConnection(connectionStr));
            Server server = new Server(sqlConnection);

            Backup sqlBackup = new Backup();
            sqlBackup.Devices.AddDevice(destinationPath, DeviceType.File);
            sqlBackup.Database = databaseName;
            sqlBackup.Action = BackupActionType.Database;
            sqlBackup.Initialize = true;
            sqlBackup.BackupSetDescription = databaseName + " : " +
                                             DateTime.Now.ToString();
            //sqlBackup.BackupSetName = databaseName;
            //Database db = sqlServer.Databases[databaseName];
            sqlBackup.Checksum = true;
            sqlBackup.ContinueAfterError = true;
            sqlBackup.Incremental = false;
            sqlBackup.LogTruncation = BackupTruncateLogType.Truncate;
            sqlBackup.FormatMedia = false;
            sqlBackup.SqlBackup(server);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="databaseName"></param>
        /// <param name="filePath"></param>
        /// <param name="serverName"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="dataFilePath"></param>
        /// <param name="logFilePath"></param>
        public static void RestoreDatabase(String databaseName, String filePath, String serverName, String userName, String password, String dataFilePath, String logFilePath)
        {
            Restore sqlRestore = new Restore();

            BackupDeviceItem deviceItem = new BackupDeviceItem(filePath, DeviceType.File);
            sqlRestore.Devices.Add(deviceItem);
            sqlRestore.Database = databaseName;

            ServerConnection connection = new ServerConnection(serverName, userName, password);
            Server sqlServer = new Server(connection);

            Database db = sqlServer.Databases[databaseName];
            sqlRestore.Action = RestoreActionType.Database;
            String dataFileLocation = dataFilePath + databaseName + ".mdf";
            String logFileLocation = logFilePath + databaseName + "_Log.ldf";
            db = sqlServer.Databases[databaseName];
            RelocateFile rf = new RelocateFile(databaseName, dataFileLocation);

            sqlRestore.RelocateFiles.Add(new RelocateFile(databaseName, dataFileLocation));
            sqlRestore.RelocateFiles.Add(new RelocateFile(databaseName + "_log", logFileLocation));
            sqlRestore.ReplaceDatabase = true;
            sqlRestore.PercentCompleteNotification = 10;

            sqlRestore.SqlRestore(sqlServer);
            db = sqlServer.Databases[databaseName];
            db.SetOnline();
            sqlServer.Refresh();
        }
    }
}

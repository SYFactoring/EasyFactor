//-----------------------------------------------------------------------
// <copyright file="DB.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Reflection;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DBDataContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="failureMode"></param>
        public override void SubmitChanges(ConflictMode failureMode)
        {
            ChangeSet changeSet = GetChangeSet();

            foreach (object insert in changeSet.Inserts.Where(insert => !insert.GetType().Equals(typeof(OperationLog)))
                )
            {
                NewOperationLog(this, insert, 'I');
            }

            foreach (object update in changeSet.Updates.Where(update => !update.GetType().Equals(typeof(OperationLog)))
                )
            {
                NewOperationLog(this, update, 'U');
            }

            foreach (object delete in changeSet.Deletes.Where(delete => !delete.GetType().Equals(typeof(OperationLog)))
                )
            {
                NewOperationLog(this, delete, 'D');
            }

            base.SubmitChanges(failureMode);
        }

        protected static bool AttrIsPrimaryKey(PropertyInfo pi)
        {
            IEnumerable<object> attrs =
                from attr in pi.GetCustomAttributes(typeof(ColumnAttribute), true)
                where ((ColumnAttribute)attr).IsPrimaryKey
                select attr;

            return attrs.Count() > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="obj"></param>
        /// <param name="actionType"></param>
        private static void NewOperationLog(DBDataContext context, object obj, char actionType)
        {
            Type type = obj.GetType();
            var log = new OperationLog { ActionType = actionType, TableName = type.Name };
            PropertyInfo key = type.GetProperties().FirstOrDefault(AttrIsPrimaryKey);
            if (key != null)
            {
                log.ActionKey = key.GetValue(obj, null).ToString();
            }

            User user = App.Current.CurUser;
            if (user != null)
            {
                log.ActionUserName = user.Name;
                log.ActionDateTime = DateTime.Now;
                context.OperationLogs.InsertOnSubmit(log);
            }
        }
    }
}
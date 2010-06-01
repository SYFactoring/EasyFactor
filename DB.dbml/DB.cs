//-----------------------------------------------------------------------
// <copyright file="DB.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System;
using System.Reflection;
using System.Collections.Generic;
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
        /// <param name="context"></param>
        /// <param name="obj"></param>
        /// <param name="actionType"></param>
        private static void NewOperationLog(DBDataContext context, object obj, char actionType)
        {
            Type type = obj.GetType();
            OperationLog log = new OperationLog();
            log.ActionType = actionType;
            log.TableName = type.Name;
            PropertyInfo key = type.GetProperties().FirstOrDefault(o => AttrIsPrimaryKey(o));
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

        protected static bool AttrIsPrimaryKey(PropertyInfo pi)
        {
            var attrs =
                from attr in pi.GetCustomAttributes(typeof(ColumnAttribute), true)
                where ((ColumnAttribute)attr).IsPrimaryKey
                select attr;

            if (attrs != null && attrs.Count() > 0)
                return true;
            else
                return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="failureMode"></param>
        public override void SubmitChanges(System.Data.Linq.ConflictMode failureMode)
        {
            ChangeSet changeSet = GetChangeSet();

            foreach (var insert in changeSet.Inserts)
            {
                if (insert.GetType().Equals(typeof(OperationLog)))
                    continue;
                NewOperationLog(this, insert, 'I');
            }

            foreach (var update in changeSet.Updates)
            {
                if (update.GetType().Equals(typeof(OperationLog)))
                    continue;
                NewOperationLog(this, update, 'U');
            }

            foreach (var delete in changeSet.Deletes)
            {
                if (delete.GetType().Equals(typeof(OperationLog)))
                    continue;
                NewOperationLog(this, delete, 'D');
            }

            base.SubmitChanges(failureMode);
        }
    }
}
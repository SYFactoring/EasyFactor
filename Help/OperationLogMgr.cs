//-----------------------------------------------------------------------
// <copyright file="OperationLogMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.Help
{
    /// <summary>
    /// Operation Log Management 
    /// </summary>
    public partial class OperationLogMgr : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// Initializes a new instance of the OperationLogMgr class
        /// </summary>
        public OperationLogMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            dgvLogs.AutoGenerateColumns = false;
            dgvLogs.DataSource = _bs;
            ControlUtil.SetDoubleBuffered(dgvLogs);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);
        }


        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvLogsCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column = dgvLogs.Columns[e.ColumnIndex];
            if (column == colActionType)
            {
                Object originalData = e.Value;
                if (originalData != null)
                {
                    var result = (char)originalData;
                    if (result == 'I')
                        e.Value = "新建";
                    else if (result == 'U')
                        e.Value = "更新";
                    else if (result == 'D')
                        e.Value = "删除";
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvLogsRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dgvLogs.RowHeadersWidth - 4,
                                          e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dgvLogs.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvLogs.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// Query operation log table according to keyword
        /// </summary>
        /// <param name="sender">Event Sender</param>
        /// <param name="e">Event Args</param>
        private void QueryLogs(object sender, EventArgs e)
        {
            Context = new DBDataContext { ObjectTrackingEnabled = false };

            DateTime beginDate = String.IsNullOrEmpty(diBegin.Text) ? diBegin.MinDate : diBegin.Value;
            DateTime endDate = String.IsNullOrEmpty(diEnd.Text) ? diEnd.MinDate : diEnd.Value;

            IQueryable<OperationLog> queryResult =
                Context.OperationLogs.Where(log => (tbUserID.Text != "" ? log.ActionUserName.Contains(tbUserID.Text) : true)
                                                   &&
                                                   (beginDate != diBegin.MinDate
                                                        ? log.ActionDateTime >= beginDate
                                                        : true)
                                                   &&
                                                   (endDate != diEnd.MinDate
                                                        ? log.ActionDateTime <= endDate.AddDays(1)
                                                        : true));

            DialogResult dr = DialogResult.Yes;
            if (queryResult.Count() > 5000)
            {
                dr = MessageBoxEx.Show("查询结果超过5000条，全部显示可能速度较慢，是否继续？", MESSAGE.TITLE_INFORMATION,
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

            _bs.DataSource = dr == DialogResult.Yes ? queryResult : queryResult.Take(5000);
            lblCount.Text = String.Format("获得{0}条记录", dr == DialogResult.Yes ? queryResult.Count() : 5000);
        }
    }
}
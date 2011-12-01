//-----------------------------------------------------------------------
// <copyright file="FactorCreditLineMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FactorCreditLineMgr : UserControl
    {
        #region OpFactorCreditMgrType enum

        /// <summary>
        /// 
        /// </summary>
        public enum OpFactorCreditMgrType
        {
            /// <summary>
            /// 
            /// </summary>
            QUERY,

            /// <summary>
            /// 
            /// </summary>
            DUE,
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;

        /// <summary>
        /// 
        /// </summary>
        private OpFactorCreditMgrType _opType;


        public FactorCreditLineMgr(OpFactorCreditMgrType opType)
            : this()
        {
            _opType = opType;
            if (opType == OpFactorCreditMgrType.DUE)
            {
                var context = new DBDataContext();

                DateTime overDueDate = DateTime.Now.Date;

                IQueryable<FactorCreditLine> queryResult =
                    context.FactorCreditLines.Where(
                        f => f.CreditLineStatus == FACTOR_CREDIT_LINE.AVAILABILITY && f.PeriodEnd < overDueDate);

                _bs.DataSource = queryResult;
                lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
            }
        }

        /// <summary>
        /// Initializes a new instance of the FactorCreditLineMgr class
        /// </summary>
        public FactorCreditLineMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            dgvFactorCreditLines.DataSource = _bs;
            dgvFactorCreditLines.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(dgvFactorCreditLines);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);
        }


        //?Private?Methods?(4)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvFactorCreditLinesCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFactorCreditLines.CurrentCell == null)
            {
                return;
            }

            var creditLine = (FactorCreditLine) _bs.List[dgvFactorCreditLines.CurrentCell.RowIndex];
            var detail = new FactorDetail(creditLine,
                                          FactorDetail.OpFactorCreditLineType.DETAIL_FACTOR_CREDIT_LINE);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvFactorCreditLinesDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < _bs.List.Count; i++)
            {
                var creditLine = (FactorCreditLine) _bs.List[i];
                if (creditLine.PeriodEnd < DateTime.Now.Date)
                {
                    dgvFactorCreditLines["colPeriodEnd", i].Style.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvFactorCreditLinesRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvFactorCreditLines.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                                  dgvFactorCreditLines.RowHeadersDefaultCellStyle.Font, rectangle,
                                  dgvFactorCreditLines.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Query(object sender, EventArgs e)
        {
            string factorCode = tbFactorCode.Text;
            string factorName = tbFactorName.Text;

            var context = new DBDataContext();

            IQueryable<FactorCreditLine> queryResult =
                context.FactorCreditLines.Where(
                f => 
                    ((cbFactorCreditStatus.Text==String.Empty||cbFactorCreditStatus.Text==@"全部")?true: f.CreditLineStatus == cbFactorCreditStatus.Text )&&
                    f.Factor.FactorCode.Contains(factorCode) &&
                    ((f.Factor.CompanyNameCN ?? string.Empty).Contains(factorName) || (f.Factor.CompanyNameEN??string.Empty).Contains(factorName)));
            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }
    }
}
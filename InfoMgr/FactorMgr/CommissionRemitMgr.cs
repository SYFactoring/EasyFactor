//-----------------------------------------------------------------------
// <copyright file="CommissionRemitMgr.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    public partial class CommissionRemitMgr : UserControl
    {

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;
        /// <summary>
        /// 
        /// </summary>
        private DBDataContext _context;
        /// <summary>
        /// 
        /// </summary>
        private readonly Factor _factor;



        /// <summary>
        /// 
        /// </summary>
        /// <param name="factor"></param>
        /// <param name="context"></param>
        public CommissionRemitMgr(Factor factor, DBDataContext context)
            : this()
        {
            _factor = factor;
            _bs.DataSource = factor.CommissionRemittances;
            lblCount.Text = String.Format("获得{0}条记录", factor.CommissionRemittances.Count());
            panelQuery.Visible = false;

            Context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        public CommissionRemitMgr()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _bs = new BindingSource();
            dgvCommissionRemit.DataSource = _bs;
            dgvCommissionRemit.AutoGenerateColumns = false;
            ControlUtil.SetDoubleBuffered(dgvCommissionRemit);
            ControlUtil.AddEnterListenersForQuery(panelQuery.Controls, btnQuery);
        }



        /// <summary>
        /// 
        /// </summary>
        private DBDataContext Context
        {
            get { return _context; }
            set { _context = value; }
        }

        /// <summary>
        /// Gets or sets owner form
        /// </summary>
        public Form OwnerForm { get; set; }

        /// <summary>
        /// Gets or sets selected CommissionRemittance
        /// </summary>
        public CommissionRemittance Selected { get; set; }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (dgvCommissionRemit.CurrentCell == null)
            {
                return;
            }

            var commissionRemit = (CommissionRemittance)_bs.List[dgvCommissionRemit.CurrentCell.RowIndex];
            if (
                MessageBoxEx.Show("是否打算删除此保理费收付", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                foreach (InvoiceAssignBatch batch in commissionRemit.InvoiceAssignBatches.ToList())
                {
                    batch.CommissionRemittance = null;
                }

                _context.CommissionRemittances.DeleteOnSubmit(commissionRemit);
                _context.SubmitChanges();
            }
            catch (Exception e1)
            {
                MessageBoxEx.Show("删除失败," + e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            dgvCommissionRemit.Rows.RemoveAt(dgvCommissionRemit.CurrentCell.RowIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCommissionRemit(object sender, EventArgs e)
        {
            if (dgvCommissionRemit.CurrentCell == null)
            {
                return;
            }

            var commissionRemit = (CommissionRemittance)_bs.List[dgvCommissionRemit.CurrentCell.RowIndex];
            var detail = new CommissionRemitDetail(commissionRemit);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCommissionRemitCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OwnerForm == null)
            {
                DetailCommissionRemit(sender, e);
            }
            else
            {
                SelectCommissionRemit(sender, e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvCommissionRemitRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                          dgvCommissionRemit.RowHeadersWidth - 4,
                                          e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                                  dgvCommissionRemit.RowHeadersDefaultCellStyle.Font,
                                  rectangle, dgvCommissionRemit.RowHeadersDefaultCellStyle.ForeColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCommissionRemit(object sender, EventArgs e)
        {
            DateTime beginBatchDate = String.IsNullOrEmpty(dateFrom.Text)
                                          ? dateFrom.MinDate
                                          : dateFrom.Value.Date;
            DateTime endBatchDate = String.IsNullOrEmpty(dateTo.Text)
                                        ? dateTo.MinDate
                                        : dateTo.Value.Date;

            Context = new DBDataContext();

            IEnumerable<CommissionRemittance> queryResult = from commissionRemit in Context.CommissionRemittances
                                                            let factor = commissionRemit.Factor
                                                            where factor.FactorCode.Contains(tbFactorCode.Text)
                                                                  &&
                                                                  (factor.CompanyNameCN.Contains(tbFactorName.Text) ||
                                                                   factor.CompanyNameEN.Contains(tbFactorName.Text))
                                                            where
                                                                (beginBatchDate != dateFrom.MinDate
                                                                     ? commissionRemit.MsgDate >= beginBatchDate
                                                                     : true)
                                                                &&
                                                                (endBatchDate != dateTo.MinDate
                                                                     ? commissionRemit.MsgDate <= endBatchDate
                                                                     : true)
                                                            select commissionRemit;

            _bs.DataSource = queryResult;
            lblCount.Text = String.Format("获得{0}条记录", queryResult.Count());
        }

        /// <summary>
        /// Select CommissionRemit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCommissionRemit(object sender, EventArgs e)
        {
            if (dgvCommissionRemit.CurrentCell == null)
            {
                return;
            }

            var commissionRemit = (CommissionRemittance)_bs.List[dgvCommissionRemit.CurrentCell.RowIndex];
            Selected = commissionRemit;

            if (OwnerForm != null)
            {
                OwnerForm.DialogResult = DialogResult.Yes;
                OwnerForm.Close();
            }
        }
    }
}
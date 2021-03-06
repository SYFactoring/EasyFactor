//-----------------------------------------------------------------------
// <copyright file="CommissionRemit.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Windows.Forms;
using System.Linq;
using System.Data.Linq;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using System.Collections;

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CommissionRemit : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private Factor _factor;

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private readonly BindingSource _bs;


        /// <summary>
        /// Initializes a new instance of the CommissionRemit class
        /// </summary>
        public CommissionRemit()
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            dgvBatches.ImeMode = ImeMode.OnHalf;
            dgvBatches.AutoGenerateColumns = false;
            commissionRemitValidator.Enabled = false;
            colCheckBox.ReadOnly = true;
            ControlUtil.SetDoubleBuffered(dgvBatches);
            _bs = new BindingSource();
            dgvBatches.DataSource = _bs;
            _context = new DBDataContext();

            cbMsgCurrency.DataSource = Currency.AllCurrencies;
            cbMsgCurrency.DisplayMember = "CurrencyFormat";
            cbMsgCurrency.ValueMember = "CurrencyCode";

            cbRemitCurrency.DataSource = Currency.AllCurrencies;
            cbRemitCurrency.DisplayMember = "CurrencyFormat";
            cbRemitCurrency.ValueMember = "CurrencyCode";

            foreach (Control comp in panelCommissionRemit.Controls)
            {
                ControlUtil.SetComponetEditable(comp, false);
            }
        }

        //?Private?Methods?(7)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailFactor(object sender, EventArgs e)
        {
            if (_factor != null)
            {
                var factorDetail = new FactorDetail(_factor, FactorDetail.OpFactorType.DETAIL_FACTOR);
                factorDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillFactor()
        {
            if (_factor != null)
            {
                tbFactorCode.Text = _factor.FactorCode;
                tbCompanyNameCN.Text = _factor.CompanyNameCN;
                tbCompanyNameEN.Text = _factor.CompanyNameEN;

                _bs.DataSource = _factor.GetInvoiceAssignBatches(false);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFactor(object sender, EventArgs e)
        {
            var factorMgr = new FactorMgr();
            var queryForm = new QueryForm(factorMgr, "选择保理商");
            factorMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);
            Factor curFactor = factorMgr.Selected;

            if (curFactor != null)
            {
                _factor = _context.Factors.SingleOrDefault(f => f.FactorCode == curFactor.FactorCode);
                FillFactor();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (_factor == null)
            {
                MessageBoxEx.Show("没有选定保理商", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            colCheckBox.ReadOnly = false;
            commissionRemitBindingSource.DataSource = typeof(CommissionRemittance);
            var commissionRemit = new CommissionRemittance { CreateUserName = App.Current.CurUser.Name };
            commissionRemitBindingSource.DataSource = commissionRemit;
            _bs.DataSource = _factor.GetInvoiceAssignBatches(false);

            foreach (Control comp in panelCommissionRemit.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
                ControlUtil.SetComponetEditable(comp, true);
            }

            tbTotalCommission.ReadOnly = true;
            tbIFCommission.ReadOnly = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCommissionRemit(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.INVOICE_UPDATE))
            {
                return;
            }

            if (_factor == null)
            {
                MessageBoxEx.Show("没有选定保理商", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!commissionRemitValidator.Validate())
            {
                return;
            }

            var commissionRemit = (CommissionRemittance)commissionRemitBindingSource.DataSource;

            for (int i = 0; i < _bs.List.Count; i++)
            {
                var batch = (InvoiceAssignBatch)_bs.List[i];
                if (Boolean.Parse(dgvBatches.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    batch.CommissionRemittance = commissionRemit;
                }
            }

            if (commissionRemit.MsgID == 0)
            {
                bool isAddOK = true;
                try
                {
                    commissionRemit.Factor = _factor;
                    _context.CommissionRemittances.InsertOnSubmit(commissionRemit);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    commissionRemit.Factor = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    NewCommissionRemit(null, null);
                }
            }
            else
            {
                bool isUpdateOK = true;
                try
                {
                    _context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in _context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    _context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCommissionRemit(object sender, EventArgs e)
        {
            if (_factor == null)
            {
                MessageBoxEx.Show("没有选定保理商", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var mgr = new CommissionRemitMgr(_factor, _context);
            var queryUI = new QueryForm(mgr, "选择手续费收付");
            mgr.OwnerForm = queryUI;
            queryUI.ShowDialog(this);
            CommissionRemittance selected = mgr.Selected;
            if (selected != null)
            {
                commissionRemitBindingSource.DataSource = selected;
                List<InvoiceAssignBatch> batches = selected.InvoiceAssignBatches.ToList();
                batches.AddRange(_factor.GetInvoiceAssignBatches(false));
                _bs.DataSource = batches;

                for (int i = 0; i < selected.InvoiceAssignBatches.Count; i++)
                {
                    var cell = (DataGridViewCheckBoxCell)dgvBatches.Rows[i].Cells[0];
                    cell.Value = 1;
                }

                colCheckBox.ReadOnly = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void StatCommissinRemit()
        {
            IList batchList = _bs.List;

            decimal totalCommission = 0;
            decimal totalIFCommission = 0;
            for (int i = 0; i < batchList.Count; i++)
            {
                if (Boolean.Parse(dgvBatches.Rows[i].Cells[0].EditedFormattedValue.ToString()))
                {
                    totalCommission += ((InvoiceAssignBatch)batchList[i]).CommissionAmount.GetValueOrDefault();
                    totalIFCommission += ((InvoiceAssignBatch)batchList[i]).FactorCommissionAmount.GetValueOrDefault();
                }
            }

            tbTotalCommission.Text = String.Format("{0:N2}", totalCommission);
            tbIFCommission.Text = String.Format("{0:N2}", totalIFCommission);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvBatchesCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (dgvBatches.Columns[e.ColumnIndex] == colCheckBox)
            {
                StatCommissinRemit();
            }
        }
    }
}
//-----------------------------------------------------------------------
// <copyright file="CDADetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class CDADetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (1)

        /// <summary>
        /// 
        /// </summary>
        private OpCDAType opCDAType;

        #endregion Fields

        #region Enums (1)

        /// <summary>
        /// Operation Type 
        /// </summary>
        public enum OpCDAType
        {
            /// <summary>
            /// New CDA
            /// </summary>
            NEW_CDA,

            /// <summary>
            /// Update CDA
            /// </summary>
            UPDATE_CDA,

            /// <summary>
            /// Detail CDA
            /// </summary>
            DETAIL_CDA
        }

        #endregion Enums

        #region Constructors (3)

        public CDADetail(Case selectedCase, OpCDAType opCDAType)
            : this((CDA)null, opCDAType)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            cda.Case = selectedCase;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <param name="opCDAType"></param>
        public CDADetail(CDA cda, OpCDAType opCDAType)
        {
            this.InitializeComponent();
            this.opCDAType = opCDAType;

            this.pUGProportionTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.pUGProportionTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            this.financeProportionTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.financeProportionTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            this.priceTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.priceTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);
            this.iFPriceTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.iFPriceTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);
            this.eFPriceTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.eFPriceTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);


            this.creditCoverCurrComboBox.DataSource = Currency.AllCurrencies().ToList();
            this.creditCoverCurrComboBox.DisplayMember = "CurrencyCode";
            this.creditCoverCurrComboBox.ValueMember = "CurrencyCode";
            this.creditCoverCurrComboBox.SelectedIndex = -1;

            this.financeLineCurrComboBox.DataSource = Currency.AllCurrencies().ToList();
            this.financeLineCurrComboBox.DisplayMember = "CurrencyCode";
            this.financeLineCurrComboBox.ValueMember = "CurrencyCode";
            this.financeLineCurrComboBox.SelectedIndex = -1;

            this.handFeeCurrComboBox.DataSource = Currency.AllCurrencies().ToList();
            this.handFeeCurrComboBox.DisplayMember = "CurrencyCode";
            this.handFeeCurrComboBox.ValueMember = "CurrencyCode";
            this.handFeeCurrComboBox.SelectedIndex = -1;

            this.assignTypeComboBox.Items.AddRange(new string[] { "全部", "部分" });
            this.commissionTypeComboBox.Items.AddRange(new string[] { "按转让金额", "按融资金额", "其他" });
            this.cDAStatusComboBox.Items.AddRange(new string[] { "未审核", "已审核未下发", "已下发未签回", "已签回", "已失效" });

            if (opCDAType == OpCDAType.NEW_CDA)
            {
                cda = GenerateDefaultCDA(null);
                this.CDABindingSource.DataSource = cda;
            }
            else
            {
                this.CDABindingSource.DataSource = cda;
                FillCase(cda.Case);
                if (cda.NoticeMethod != null)
                {
                    string[] methods = cda.NoticeMethod.Split(',');
                    foreach (string method in methods)
                    {
                        if ("Fax".Equals(method))
                        {
                            this.cbNoticeMethodFax.Checked = true;
                        }
                        else if ("Email".Equals(method))
                        {
                            this.cbNoticeMethodEmail.Checked = true;
                        }
                    }
                }
                cda.Backup();
            }
            cda.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(cda_PropertyChanged);
            this.UpdateCDAControlStatus();
        }

        public CDADetail(OpCDAType opCDAType)
            : this((CDA)null, opCDAType)
        {

        }

        #endregion Constructors

        #region Methods (10)

        // Private Methods (10) 

        void cda_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            CDA cda = sender as CDA;
            if ("Price".Equals(e.PropertyName) || "IFPrice".Equals(e.PropertyName))
            {
                double price = cda.Price.GetValueOrDefault();
                double ifprice = cda.IFPrice.GetValueOrDefault();
                cda.EFPrice = price - ifprice;
            }
            if ("IsRecoarse".Equals(e.PropertyName))
            {
                bool isRecoarse = cda.IsRecoarse.GetValueOrDefault();
                this.creditCoverCurrComboBox.Enabled = !isRecoarse;
                this.creditCoverPeriodBeginDateTimePicker.Enabled = !isRecoarse;
                this.creditCoverPeriodEndDateTimePicker.Enabled = !isRecoarse;
                this.creditCoverTextBox.Enabled = !isRecoarse;
                this.pUGPeriodTextBox.Enabled = !isRecoarse;
                this.pUGProportionTextBox.Enabled = !isRecoarse;
                this.cbIsCreditCoverRevolving.Enabled = !isRecoarse;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CDADetail_Leave(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (this.opCDAType == OpCDAType.UPDATE_CDA)
            {
                cda.Restore();
            }

            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseCDA(object sender, EventArgs e)
        {
            if (opCDAType == OpCDAType.UPDATE_CDA)
            {
                CDA cda = this.CDABindingSource.DataSource as CDA;
                cda.Restore();
            }
            else if (opCDAType == OpCDAType.NEW_CDA)
            {
                this.CDABindingSource.DataSource = new CDA();
            }
        }

        private void customValidator1_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if ("其他".Equals(cda.CommissionType))
            {
                if (e.ControlToValidate.Text.Equals(string.Empty))
                {
                    e.IsValid = false;
                }
                else
                {
                    e.IsValid = true;
                }
            }
            else
            {
                e.IsValid = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="curCase"></param>
        private void FillCase(Case curCase)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            Contract contract = cda.Case.SellerClient.Contract;
            if (contract != null)
            {
                this.contractCodeTextBox.Text = contract.ContractCode;
            }
            this.tbHighestFinance.Text = String.Format("{0:N2}", cda.Case.SellerClient.FinanceCreditLine.CreditLine);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="curCase"></param>
        /// <returns></returns>
        private CDA GenerateDefaultCDA(Case curCase)
        {
            CDA cda = new CDA();
            if (curCase != null)
            {
                cda.HandFeeCurr = curCase.InvoiceCurrency;
                ClientCreditLine buyerCreditLine = curCase.BuyerClient.AssignCreditLine;
                if (buyerCreditLine != null)
                {
                    cda.CreditCoverPeriodBegin = buyerCreditLine.PeriodBegin;
                    cda.CreditCoverPeriodEnd = buyerCreditLine.PeriodEnd;
                    cda.CreditCoverCurr = buyerCreditLine.CreditLineCurrency;
                    cda.CreditCover = buyerCreditLine.CreditLine;
                }
                ClientCreditLine sellerCreditLine = curCase.SellerClient.FinanceCreditLine;
                if (sellerCreditLine != null)
                {
                    cda.FinanceLinePeriodBegin = sellerCreditLine.PeriodBegin;
                    cda.FinanceLinePeriodEnd = sellerCreditLine.PeriodEnd;
                    cda.FinanceLineCurr = sellerCreditLine.CreditLineCurrency;
                    cda.FinanceLine = sellerCreditLine.CreditLine;
                }
            }
            cda.CDASignDate = DateTime.Now;
            cda.CommissionType = "按转让金额";
            cda.PUGProportion = 1;
            cda.PUGPeriod = 90;
            cda.ReassignGracePeriod = 60;
            cda.FinanceProportion = 0.8;
            cda.IsNotice = "明保理";
            cda.IsRecoarse = false;
            cda.CDAStatus = "未审核";
            cda.IsCreditCoverRevolving = true;
            cda.AssignType = "全部";
            return cda;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCDA(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (this.cbNoticeMethodEmail.Checked == true)
            {
                cda.NoticeMethod = "Email";
            }
            if (this.cbNoticeMethodFax.Checked == true)
            {
                if (cda.NoticeMethod == null)
                {
                    cda.NoticeMethod = "Fax";
                }
                else
                {
                    cda.NoticeMethod = "Email,Fax";
                }
            }

            if (cda.CDACode == null)
            {
                bool isAddOK = true;
                string cdaCode = CDA.GenerateCDACode(cda.Case);
                if (string.Empty.Equals(cdaCode))
                {
                    MessageBox.Show("CDA编号生成失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cda.CDACode = cdaCode;
                try
                {
                    App.Current.DbContext.CDAs.InsertOnSubmit(cda);
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    isAddOK = false;
                    MessageBox.Show(e1.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cda.Backup();
                    if (cda.Case.CaseMark == "申请案")
                    {
                        cda.Case.CaseMark = "启动案";
                        App.Current.DbContext.SubmitChanges();
                    }
                    if (cda.CDAStatus == "已签回")
                    {
                        foreach (CDA c in cda.Case.CDAs)
                        {
                            if (c != cda && c.CDAStatus == "已签回")
                            {
                                c.CDAStatus = "已失效";
                            }
                        }
                        App.Current.DbContext.SubmitChanges();
                    }
                    this.opCDAType = OpCDAType.UPDATE_CDA;
                }
            }
            else
            {
                bool isUpdateOK = true;
                if (cda.CDACode == null)
                {
                    return;
                }

                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBox.Show(e2.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cda.Backup();
                    if (cda.CDAStatus == "已签回")
                    {
                        foreach (CDA c in cda.Case.CDAs)
                        {
                            if (c != cda && c.CDAStatus == "已签回")
                            {
                                c.CDAStatus = "已失效";
                            }
                        }
                        App.Current.DbContext.SubmitChanges();
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCase(object sender, EventArgs e)
        {
            CaseMgr caseMgr = new CaseMgr(false);
            QueryForm queryForm = new QueryForm(caseMgr, "选择案件");
            caseMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);
            Case curCase = caseMgr.Selected;
            if (curCase != null)
            {
                CDA cda = GenerateDefaultCDA(curCase);
                cda.Case = curCase;
                this.CDABindingSource.DataSource = cda;
                FillCase(curCase);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCDA(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda == null || cda.CDACode == null)
            {
                MessageBox.Show("请首先选择一个额度通知书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.opCDAType = OpCDAType.UPDATE_CDA;
            this.UpdateCDAControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateCDAControlStatus()
        {
            if (this.opCDAType == OpCDAType.DETAIL_CDA)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelCreditCover.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelOther.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                this.btnCaseSelect.Visible = false;
            }
            else if (this.opCDAType == OpCDAType.NEW_CDA)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelCreditCover.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelOther.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (this.opCDAType == OpCDAType.UPDATE_CDA)
            {
                foreach (Control comp in this.groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }
                foreach (Control comp in this.groupPanelCreditCover.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
                foreach (Control comp in this.groupPanelOther.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            this.tbCDACode.ReadOnly = true;
        }

        #endregion Methods
    }
}

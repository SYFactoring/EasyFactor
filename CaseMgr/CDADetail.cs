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
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
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

        /// <summary>
        /// 通过Case新建CDA
        /// </summary>
        /// <param name="selectedCase"></param>
        /// <param name="opCDAType"></param>
        public CDADetail(Case selectedCase, OpCDAType opCDAType)
            : this((CDA)null, opCDAType)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            cda.Case = selectedCase;
            FillCase();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <param name="opCDAType"></param>
        public CDADetail(CDA cda, OpCDAType opCDAType)
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;
            this.opCDAType = opCDAType;

            this.pUGProportionTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.pUGProportionTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            this.financeProportionTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.financeProportionTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            this.priceTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.priceTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);
            this.iFPriceTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.iFPriceTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

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
            this.commissionTypeComboBox.Items.AddRange(new string[] { "按发票金额", "按融资金额", "其他" });
            this.cDAStatusComboBox.Items.AddRange(new string[] { ConstStr.CDA.NO_CHECK, ConstStr.CDA.CHECK_NO_DELIVER, ConstStr.CDA.DELIVER_NO_SIGN, ConstStr.CDA.SIGNED, ConstStr.CDA.INVALID });

            if (opCDAType == OpCDAType.NEW_CDA)
            {
                cda = GenerateDefaultCDA(null);
                this.CDABindingSource.DataSource = cda;
                FillCase();
            }
            else
            {
                this.CDABindingSource.DataSource = cda;
                FillCase();
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

        #region Methods (22)

        // Private Methods (22) 

        void cda_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            CDA cda = sender as CDA;
            if ("IsRecoarse".Equals(e.PropertyName))
            {
                bool isRecoarse = cda.IsRecoarse.GetValueOrDefault();
                if (isRecoarse)
                {
                    this.creditCoverCurrComboBox.Enabled = false;
                    this.creditCoverPeriodBeginDateTimePicker.Enabled = false;
                    this.creditCoverPeriodEndDateTimePicker.Enabled = false;
                    this.creditCoverTextBox.ReadOnly = true;
                    this.pUGPeriodTextBox.ReadOnly = true;
                    this.pUGProportionTextBox.ReadOnly = true;
                    this.cbIsCreditCoverRevolving.Enabled = false;
                    cda.CreditCoverCurr = string.Empty;
                    cda.CreditCover = null;
                    cda.CreditCoverPeriodBegin = null;
                    cda.CreditCoverPeriodEnd = null;
                    cda.PUGPeriod = null;
                    cda.PUGProportion = null;
                    cda.IsCreditCoverRevolving = null;
                }
                else
                {
                    this.creditCoverCurrComboBox.Enabled = true;
                    this.creditCoverPeriodBeginDateTimePicker.Enabled = true;
                    this.creditCoverPeriodEndDateTimePicker.Enabled = true;
                    this.creditCoverTextBox.ReadOnly = false;
                    this.pUGPeriodTextBox.ReadOnly = false;
                    this.pUGProportionTextBox.ReadOnly = false;
                    this.cbIsCreditCoverRevolving.Enabled = true;
                }
            }
            //else if ("CreditCoverCurr".Equals(e.PropertyName))
            //{
            //    FillCreditCover(cda.CreditCoverCurr);
            //}
            //else if ("FinanceLineCurr".Equals(e.PropertyName))
            //{
            //    FillFinanceLine(cda.FinanceLineCurr);
            //}
        }

        private void CDADetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (opCDAType == OpCDAType.UPDATE_CDA)
            {
                cda.Restore();
            }
            if (cda.CDACode == null)
            {
                cda.Case = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void customValidator2_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (cda.Case == null)
            {
                return;
            }
            ClientCreditLine creditLine = cda.Case.BuyerClient.AssignCreditLine;
            if (creditLine != null)
            {
                double buyerCreditLine = creditLine.CreditLine;
                if (cda.CreditCoverCurr != creditLine.CreditLineCurrency)
                {
                    double exchange = Exchange.GetExchangeRate(creditLine.CreditLineCurrency, cda.CreditCoverCurr);
                    buyerCreditLine *= exchange;
                }
                if (cda.CreditCover > buyerCreditLine)
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

        private void customValidator3_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (cda.Case == null)
            {
                return;
            }
            ClientCreditLine creditLine = cda.Case.BuyerClient.AssignCreditLine;
            if (creditLine != null && cda.CreditCoverPeriodEnd > creditLine.PeriodEnd)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }

        private void customValidator4_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (cda.Case == null)
            {
                return;
            }
            ClientCreditLine creditLine;
            if (cda.Case.TransactionType == "国内买方保理" || cda.Case.TransactionType == "进口保理")
            {
                creditLine = cda.Case.BuyerClient.FinanceCreditLine;
            }
            else
            {
                creditLine = cda.Case.SellerClient.FinanceCreditLine;
            }
            if (creditLine != null)
            {
                double theCreditLine = creditLine.CreditLine;
                if (cda.FinanceLineCurr != creditLine.CreditLineCurrency)
                {
                    double exchange = Exchange.GetExchangeRate(creditLine.CreditLineCurrency, cda.FinanceLineCurr);
                    theCreditLine *= exchange;
                }
                if (cda.FinanceLine > theCreditLine)
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

        private void customValidator5_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (cda.Case == null)
            {
                return;
            }
            if (cda.IsRecoarse.GetValueOrDefault() && cda.FinanceLine > cda.CreditCover)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }

        private void customValidator6_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (cda.Case == null)
            {
                return;
            }
            ClientCreditLine sellerCreditLine = cda.Case.SellerClient.FinanceCreditLine;
            if (sellerCreditLine != null && cda.FinanceLinePeriodEnd > sellerCreditLine.PeriodEnd)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBuyer(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda == null || cda.Case == null)
            {
                return;
            }
            ClientDetail clientDetail = new ClientDetail(cda.Case.BuyerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
            clientDetail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda == null || cda.Case == null)
            {
                return;
            }
            CaseDetail caseDetail = new CaseDetail(cda.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailContract(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda == null || cda.Case == null)
            {
                return;
            }
            if (cda.Case.SellerClient.Contract != null)
            {
                ClientDetail clientDetail = new ClientDetail(cda.Case.SellerClient.Contract, ClientDetail.OpContractType.DETAIL_CONTRACT);
                clientDetail.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailFactor(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda == null || cda.Case == null)
            {
                return;
            }
            Factor factor = null;
            switch (cda.Case.TransactionType)
            {
                case "国内卖方保理":
                case "出口保理":
                case "国内信保保理":
                case "国际信保保理":
                case "租赁保理":
                    factor = cda.Case.SellerFactor;
                    break;
                case "国内买方保理":
                case "进口保理":
                    factor = cda.Case.BuyerFactor;
                    break;
                default: break;
            }
            if (factor != null)
            {
                FactorDetail factorDetail = new FactorDetail(factor, FactorDetail.OpFactorType.DETAIL_FACTOR);
                factorDetail.Show();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailSeller(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda == null || cda.Case == null)
            {
                return;
            }
            ClientDetail clientDetail = new ClientDetail(cda.Case.SellerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
            clientDetail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="curCase"></param>
        private void FillCase()
        {

            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda.Case == null)
            {
                return;
            }

            Contract contract = cda.Case.SellerClient.Contract;
            if (contract != null)
            {
                this.contractCodeTextBox.Text = contract.ContractCode;
            }
            switch (cda.Case.TransactionType)
            {
                case "国内卖方保理":
                case "出口保理":
                case "国内信保保理":
                case "国际信保保理":
                case "租赁保理":
                    this.factorCodeTextBox.Text = cda.Case.SellerFactor.FactorCode;
                    this.companyNameCNTextBox.Text = cda.Case.SellerFactor.CompanyNameCN;
                    this.companyNameENTextBox.Text = cda.Case.SellerFactor.CompanyNameEN;
                    break;
                case "国内买方保理":
                case "进口保理":
                    this.factorCodeTextBox.Text = cda.Case.BuyerFactor.FactorCode;
                    this.companyNameCNTextBox.Text = cda.Case.BuyerFactor.CompanyNameCN;
                    this.companyNameENTextBox.Text = cda.Case.BuyerFactor.CompanyNameEN;

                    break;
                default: break;
            }
            FillCreditCover(cda.Case.InvoiceCurrency);
            FillFinanceLine(cda.Case.InvoiceCurrency);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        private void FillCreditCover(string currency)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda.Case == null)
            {
                return;
            }
            ClientCreditLine buyerCreditLine = cda.Case.BuyerClient.AssignCreditLine;
            if (buyerCreditLine != null)
            {
                cda.CreditCoverPeriodBegin = buyerCreditLine.PeriodBegin;
                cda.CreditCoverPeriodEnd = buyerCreditLine.PeriodEnd;
                cda.CreditCoverCurr = buyerCreditLine.CreditLineCurrency;
                cda.CreditCover = buyerCreditLine.CreditLine;
                if (TypeUtil.EqualsZero(buyerCreditLine.CreditLine))
                {
                    cda.PUGProportion = 0;
                }
            }
            else
            {
                this.creditCoverCurrComboBox.Enabled = false;
                this.creditCoverPeriodBeginDateTimePicker.Enabled = false;
                this.creditCoverPeriodEndDateTimePicker.Enabled = false;
                this.creditCoverTextBox.ReadOnly = true;
                cda.CreditCoverPeriodBegin = null;
                cda.CreditCoverPeriodEnd = null;
                cda.CreditCover = null;
                cda.CreditCoverCurr = null;
                cda.PUGProportion = 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        private void FillFinanceLine(string currency)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda.Case == null)
            {
                return;
            }

            ClientCreditLine creditLine = cda.FinanceCreditLine;
            if (creditLine != null)
            {
                cda.FinanceLinePeriodBegin = creditLine.PeriodBegin;
                cda.FinanceLinePeriodEnd = creditLine.PeriodEnd;
                cda.FinanceLineCurr = creditLine.CreditLineCurrency;
                cda.FinanceLine = creditLine.CreditLine;
                this.tbHighestFinance.Text = String.Format("{0:N2}", creditLine.CreditLine);
            }
            else
            {
                this.financeLineCurrComboBox.Enabled = false;
                this.financeLinePeriodBeginDateTimePicker.Enabled = false;
                this.financeLinePeriodEndDateTimePicker.Enabled = false;
                this.financeLineTextBox.ReadOnly = true;
                this.tbHighestFinance.Text = String.Empty;
                cda.FinanceLinePeriodBegin = null;
                cda.FinanceLinePeriodEnd = null;
                cda.FinanceLine = null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="curCase"></param>
        /// <returns></returns>
        private CDA GenerateDefaultCDA(Case curCase)
        {
            CDA cda = new CDA();
            cda.CDASignDate = DateTime.Now.Date;
            cda.CommissionType = "按发票金额";
            cda.PUGProportion = 1;
            cda.PUGPeriod = 90;
            cda.ReassignGracePeriod = 60;
            cda.FinanceProportion = 0.8;
            cda.IsNotice = "明保理";
            cda.IsRecoarse = false;
            cda.CDAStatus = "未审核";
            cda.IsCreditCoverRevolving = true;
            cda.AssignType = "全部";
            cda.Case = curCase;
            return cda;
        }

        private void ResetCDA(object sender, EventArgs e)
        {
            foreach (Control comp in this.groupPanelCreditCover.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
            foreach (Control comp in this.groupPanelOther.Controls)
            {
                ControlUtil.SetComponetDefault(comp);
            }
            CDA cda = this.CDABindingSource.DataSource as CDA;
            cda.CDASignDate = DateTime.Now.Date;
            cda.CommissionType = "按发票金额";
            cda.PUGProportion = 1;
            cda.PUGPeriod = 90;
            cda.ReassignGracePeriod = 60;
            cda.FinanceProportion = 0.8;
            cda.IsNotice = "明保理";
            cda.IsRecoarse = false;
            cda.CDAStatus = "未审核";
            cda.IsCreditCoverRevolving = true;
            cda.AssignType = "全部";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCDA(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;

            if (!superValidator.Validate())
            {
                return;
            }

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
            cda.EFPrice = cda.Price - cda.IFPrice;
            if (cda.CDACode == null)
            {
                bool isAddOK = true;
                string cdaCode = CDA.GenerateCDACode(cda.Case);
                if (string.Empty.Equals(cdaCode))
                {
                    MessageBox.Show("CDA编号生成失败", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                cda.CDACode = cdaCode;
                cda.CreateUserName = App.Current.CurUser.Name;
                cda.CheckStatus = "未复核";
                try
                {
                    App.Current.DbContext.SubmitChanges();
                }
                catch (Exception e1)
                {
                    cda.CDACode = null;
                    isAddOK = false;
                    MessageBox.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBox.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cda.Backup();
                    if (cda.Case.CaseMark == ConstStr.CASE.APPLICATION)
                    {
                        cda.Case.CaseMark = ConstStr.CASE.ENABLE;
                        App.Current.DbContext.SubmitChanges();
                    }
                    if (cda.CDAStatus == ConstStr.CDA.SIGNED)
                    {
                        foreach (CDA c in cda.Case.CDAs)
                        {
                            if (c != cda && c.CDAStatus == ConstStr.CDA.SIGNED)
                            {
                                c.CDAStatus = ConstStr.CDA.INVALID;
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
                    MessageBox.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBox.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cda.Backup();
                    if (cda.CDAStatus == ConstStr.CDA.SIGNED)
                    {
                        foreach (CDA c in cda.Case.CDAs)
                        {
                            if (c != cda && c.CDAStatus == ConstStr.CDA.SIGNED)
                            {
                                c.CDAStatus = ConstStr.CDA.INVALID;
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
                FillCase();
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
                MessageBox.Show("请首先选择一个额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.tbHighestFinance.ReadOnly = true;
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda.Case != null)
            {
                ClientCreditLine buyerCreditLine = cda.Case.BuyerClient.AssignCreditLine;
                if (buyerCreditLine == null)
                {
                    this.creditCoverCurrComboBox.Enabled = false;
                    this.creditCoverPeriodBeginDateTimePicker.Enabled = false;
                    this.creditCoverPeriodEndDateTimePicker.Enabled = false;
                    this.creditCoverTextBox.Enabled = false;
                }
                ClientCreditLine sellerFinanceLine = cda.Case.SellerClient.FinanceCreditLine;
                if (sellerFinanceLine == null)
                {
                    this.financeLineCurrComboBox.Enabled = false;
                    this.financeLinePeriodBeginDateTimePicker.Enabled = false;
                    this.financeLinePeriodEndDateTimePicker.Enabled = false;
                    this.financeLineTextBox.Enabled = false;
                }
            }
        }

        #endregion Methods
    }
}

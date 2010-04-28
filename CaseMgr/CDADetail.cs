//-----------------------------------------------------------------------
// <copyright file="CDADetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr
{
    using System;
    using System.Data.Linq;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class CDADetail : DevComponents.DotNetBar.Office2007Form
    {
        #region Fields (2)

        /// <summary>
        /// 
        /// </summary>
        private DBDataContext context;
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
            cda.Case = context.Cases.SingleOrDefault(c => c.CaseCode == selectedCase.CaseCode);
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
            this.context = new DBDataContext();

            this.pUGProportionTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.pUGProportionTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

            this.financeProportionTextBox.DataBindings[0].Format += new ConvertEventHandler(TypeUtil.FormatFloatToPercent);
            this.financeProportionTextBox.DataBindings[0].Parse += new ConvertEventHandler(TypeUtil.ParsePercentToFloat);

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
            this.commissionTypeComboBox.Items.AddRange(new string[] { "按转让金额", "按融资金额", "其他" });
            this.cDAStatusComboBox.Items.AddRange(new string[] { ConstStr.CDA.UNCHECK, ConstStr.CDA.CHECKED, ConstStr.CDA.REJECT, ConstStr.CDA.INVALID });

            if (opCDAType == OpCDAType.NEW_CDA)
            {
                cda = GenerateDefaultCDA(null);
                this.CDABindingSource.DataSource = cda;
                FillCase();
            }
            else
            {
                cda = context.CDAs.SingleOrDefault(c => c.CDACode == cda.CDACode);
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
            }

            this.UpdateCDAControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opCDAType"></param>
        public CDADetail(OpCDAType opCDAType)
            : this((CDA)null, opCDAType)
        {

        }

        #endregion Constructors

        #region Methods (25)

        // Private Methods (25) 

        private void cbIsCreditCoverRevolving_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbIsCreditCoverRevolving.Checked)
            {
                this.orderNumberTextBox.Enabled = false;
            }
            else
            {
                this.orderNumberTextBox.Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbIsRecoarse_CheckedChanged(object sender, EventArgs e)
        {
            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda.Case != null)
            {
                cda.IsRecoarse = this.cbIsRecoarse.Checked;
                if (cda.IsRecoarse.GetValueOrDefault())
                {
                    cda.CreditCoverPeriodBegin = null;
                    cda.CreditCoverPeriodEnd = null;
                    cda.CreditCover = null;
                    cda.CreditCoverCurr = null;
                    this.creditCoverCurrComboBox.Enabled = false;
                    this.creditCoverPeriodBeginDateTimePicker.Enabled = false;
                    this.creditCoverPeriodEndDateTimePicker.Enabled = false;
                    this.creditCoverTextBox.ReadOnly = true;
                    this.creditCoverPeriodBeginDateTimePicker.Value = default(DateTime);
                    this.creditCoverPeriodEndDateTimePicker.Value = default(DateTime);
                }
                else
                {
                    this.creditCoverCurrComboBox.Enabled = true;
                    this.creditCoverPeriodBeginDateTimePicker.Enabled = true;
                    this.creditCoverPeriodEndDateTimePicker.Enabled = true;
                    this.creditCoverTextBox.ReadOnly = false;
                }
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator10_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (cda.Case == null)
            {
                return;
            }

            if (cda.Case.TransactionType == "进口保理")
            {
                if (this.iFPriceTextBox.Text == string.Empty)
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator4_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (cda.Case == null)
            {
                return;
            }

            ClientCreditLine creditLine = cda.FinanceCreditLine;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator6_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (cda.Case == null)
            {
                return;
            }

            ClientCreditLine creditLine = cda.FinanceCreditLine;

            if (creditLine != null && cda.FinanceLinePeriodEnd > creditLine.PeriodEnd)
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
        private void customValidator7_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (cda.Case == null)
            {
                return;
            }

            if (cda.Deductibles.HasValue && cda.CreditCover.HasValue)
            {
                if (TypeUtil.GreaterZero(cda.Deductibles.Value - cda.CreditCover.Value))
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator8_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (cda.Case == null)
            {
                return;
            }

            if (cda.LossThreshold.HasValue && cda.CreditCover.HasValue)
            {
                if (TypeUtil.GreaterZero(cda.LossThreshold.Value - cda.CreditCover.Value))
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customValidator9_ValidateValue(object sender, DevComponents.DotNetBar.Validator.ValidateValueEventArgs e)
        {
            CDA cda = this.CDABindingSource.DataSource as CDA;
            if (cda.Case == null)
            {
                return;
            }

            if (cda.Case.TransactionType != "进口保理")
            {
                if (this.priceTextBox.Text == string.Empty)
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

            Factor factor = cda.Case.Factor;

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

            cda.HandFeeCurr = cda.Case.InvoiceCurrency;
            Contract contract = cda.Case.SellerClient.Contract;
            if (contract != null)
            {
                this.contractCodeTextBox.Text = contract.ContractCode;
            }

            Factor factor = cda.Case.Factor;
            this.factorCodeTextBox.Text = factor.FactorCode;
            this.companyNameCNTextBox.Text = factor.CompanyNameCN;
            this.companyNameENTextBox.Text = factor.CompanyNameEN;

            if (opCDAType == OpCDAType.NEW_CDA)
            {
                FillCreditCover(cda.Case.InvoiceCurrency);
                FillFinanceLine(cda.Case.InvoiceCurrency);
            }
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
                this.cbIsRecoarse.Enabled = false;
                this.creditCoverPeriodBeginDateTimePicker.Value = default(DateTime);
                this.creditCoverPeriodEndDateTimePicker.Value = default(DateTime);
                cda.CreditCoverPeriodBegin = null;
                cda.CreditCoverPeriodEnd = null;
                cda.CreditCover = null;
                cda.CreditCoverCurr = null;
                cda.PUGProportion = 0;
                cda.IsRecoarse = true;
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
                cda.HighestFinanceLine = creditLine.CreditLine;
            }
            else
            {
                this.financeLineCurrComboBox.Enabled = false;
                this.financeLinePeriodBeginDateTimePicker.Enabled = false;
                this.financeLinePeriodEndDateTimePicker.Enabled = false;
                this.financeLineTextBox.ReadOnly = true;
                this.financeLinePeriodBeginDateTimePicker.Value = default(DateTime);
                this.financeLinePeriodEndDateTimePicker.Value = default(DateTime);
                cda.FinanceLinePeriodBegin = null;
                cda.FinanceLinePeriodEnd = null;
                cda.FinanceLine = null;
                cda.FinanceLineCurr = string.Empty;
                cda.HighestFinanceLine = null;
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
            cda.CommissionType = "按转让金额";
            cda.PUGProportion = 1;
            cda.PUGPeriod = 90;
            cda.ReassignGracePeriod = 60;
            cda.FinanceProportion = 0.8;
            cda.IsNotice = "明保理";
            cda.IsRecoarse = false;
            cda.CDAStatus = ConstStr.CDA.UNCHECK;
            cda.IsCreditCoverRevolving = true;
            cda.AssignType = "全部";
            cda.Case = curCase;
            return cda;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCDA(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permission.CDA_UPDATE))
            {
                return;
            }

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

            if (cda.HandFee.HasValue == false)
            {
                cda.HandFeeCurr = null;
            }

            if (cda.IFPrice.HasValue == false)
            {
                cda.IFPrice = 0;
            }

            if (cda.Price.HasValue == false)
            {
                cda.Price = cda.IFPrice;
            }

            cda.EFPrice = cda.Price - cda.IFPrice;
            cda.CreateUserName = App.Current.CurUser.Name;

            if (cda.CDACode == null)
            {
                bool isAddOK = true;
                string cdaCode = CDA.GenerateCDACode(cda.Case);
                if (string.Empty.Equals(cdaCode))
                {
                    MessageBoxEx.Show("CDA编号生成失败", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                cda.CDACode = cdaCode;

                try
                {
                    cda.CDAStatus = ConstStr.CDA.UNCHECK;
                    context.CDAs.InsertOnSubmit(cda);
                    context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    cda.CDACode = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    context.SubmitChanges(ConflictMode.ContinueOnConflict);
                }
                catch (ChangeConflictException)
                {
                    foreach (ObjectChangeConflict cc in context.ChangeConflicts)
                    {
                        foreach (MemberChangeConflict mc in cc.MemberConflicts)
                        {
                            mc.Resolve(RefreshMode.KeepChanges);
                        }
                    }

                    context.SubmitChanges();
                }
                catch (Exception e2)
                {
                    isUpdateOK = false;
                    MessageBoxEx.Show(e2.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isUpdateOK)
                {
                    MessageBoxEx.Show("数据更新成功", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (cda.CDAStatus == ConstStr.CDA.CHECKED)
                    {
                        foreach (CDA c in cda.Case.CDAs)
                        {
                            if (c != cda && c.CDAStatus == ConstStr.CDA.CHECKED)
                            {
                                c.CDAStatus = ConstStr.CDA.INVALID;
                            }
                        }

                        try
                        {
                            context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, ConstStr.MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
            if (!PermUtil.CheckPermission(Permission.CDA_UPDATE))
            {
                return;
            }

            CaseMgr caseMgr = new CaseMgr(CaseMgr.OpCaseType.ENABLE_CASE);
            QueryForm queryForm = new QueryForm(caseMgr, "选择案件");
            caseMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);
            Case curCase = caseMgr.Selected;
            if (curCase != null)
            {
                CDA cda = GenerateDefaultCDA(curCase);
                cda.Case = context.Cases.SingleOrDefault(c => c.CaseCode == curCase.CaseCode);
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
            if (!PermUtil.CheckPermission(Permission.CDA_UPDATE))
            {
                return;
            }

            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (cda == null)
            {
                MessageBoxEx.Show("请首先选择一个额度通知书", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cda.CDAStatus == ConstStr.CDA.CHECKED)
            {
                MessageBoxEx.Show("额度通知书已审核，不能修改", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ControlUtil.SetComponetEditable(this.tbCDACode, false);
            ControlUtil.SetComponetEditable(this.tbHighestFinance, false);
            ControlUtil.SetComponetEditable(this.createUserNameTextBox, false);
            ControlUtil.SetComponetEditable(this.cDAStatusComboBox, false);

            CDA cda = (CDA)this.CDABindingSource.DataSource;
            if (this.opCDAType != OpCDAType.DETAIL_CDA && cda.Case != null)
            {
                ClientCreditLine creditLine = cda.Case.BuyerClient.AssignCreditLine;
                if (creditLine == null)
                {
                    this.creditCoverCurrComboBox.Enabled = false;
                    this.creditCoverPeriodBeginDateTimePicker.Enabled = false;
                    this.creditCoverPeriodEndDateTimePicker.Enabled = false;
                    this.creditCoverPeriodBeginDateTimePicker.Value = default(DateTime);
                    this.creditCoverPeriodEndDateTimePicker.Value = default(DateTime);
                    this.creditCoverTextBox.Enabled = false;
                }

                ClientCreditLine financeLine = cda.FinanceCreditLine;

                if (financeLine == null)
                {
                    this.financeLineCurrComboBox.Enabled = false;
                    this.financeLinePeriodBeginDateTimePicker.Enabled = false;
                    this.financeLinePeriodEndDateTimePicker.Enabled = false;
                    this.financeLinePeriodBeginDateTimePicker.Value = default(DateTime);
                    this.financeLinePeriodEndDateTimePicker.Value = default(DateTime);
                    this.financeLineTextBox.Enabled = false;
                }
            }
        }

        #endregion Methods
    }
}

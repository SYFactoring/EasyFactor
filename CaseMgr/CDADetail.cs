//-----------------------------------------------------------------------
// <copyright file="CDADetail.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.InfoMgr.ClientMgr;
using CMBC.EasyFactor.InfoMgr.FactorMgr;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Validator;

namespace CMBC.EasyFactor.CaseMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CDADetail : Office2007Form
    {
        #region OpCDAType enum

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

        #endregion

        /// <summary>
        /// 
        /// </summary>
        private readonly DBDataContext _context;

        /// <summary>
        /// 
        /// </summary>
        private OpCDAType _opCDAType;


        /// <summary>
        /// 通过Case新建CDA
        /// </summary>
        /// <param name="selectedCase"></param>
        /// <param name="opCDAType"></param>
        public CDADetail(Case selectedCase, OpCDAType opCDAType)
            : this((CDA)null, opCDAType)
        {
            var cda = (CDA)CDABindingSource.DataSource;
            cda.Case = _context.Cases.SingleOrDefault(c => c.CaseCode == selectedCase.CaseCode);
            FillCase();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cda"></param>
        /// <param name="opCDAType"></param>
        public CDADetail(CDA cda, OpCDAType opCDAType)
        {
            InitializeComponent();
            ImeMode = ImeMode.OnHalf;
            _opCDAType = opCDAType;
            _context = new DBDataContext();

            pUGProportionTextBox.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            pUGProportionTextBox.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;

            financeProportionTextBox.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            financeProportionTextBox.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;
            tbFinanceRatio.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            tbFinanceRatio.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;
            tbPenaltyInterestRate.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            tbPenaltyInterestRate.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;

            priceTextBox.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            priceTextBox.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;
            iFPriceTextBox.DataBindings[0].Format += TypeUtil.FormatFloatToPercent;
            iFPriceTextBox.DataBindings[0].Parse += TypeUtil.ParsePercentToFloat;

            creditCoverCurrComboBox.DataSource = Currency.AllCurrencies;
            creditCoverCurrComboBox.DisplayMember = "CurrencyCode";
            creditCoverCurrComboBox.ValueMember = "CurrencyCode";
            creditCoverCurrComboBox.SelectedIndex = -1;

            financeLineCurrComboBox.DataSource = Currency.AllCurrencies;
            financeLineCurrComboBox.DisplayMember = "CurrencyCode";
            financeLineCurrComboBox.ValueMember = "CurrencyCode";
            financeLineCurrComboBox.SelectedIndex = -1;

            handFeeCurrComboBox.DataSource = Currency.AllCurrencies;
            handFeeCurrComboBox.DisplayMember = "CurrencyCode";
            handFeeCurrComboBox.ValueMember = "CurrencyCode";
            handFeeCurrComboBox.SelectedIndex = -1;

            riskTypeComboBox.Items.AddRange(new[] { "高风险", "低风险" });
            commissionTypeComboBox.Items.AddRange(new[] { "按转让金额", "按融资金额", "其他" });
            cDAStatusComboBox.Items.AddRange(new[] { CDAStr.UNCHECK, CDAStr.CHECKED, CDAStr.REJECT, CDAStr.INVALID });

            if (opCDAType == OpCDAType.NEW_CDA)
            {
                cda = GenerateDefaultCDA(null);
                CDABindingSource.DataSource = cda;
                FillCase();
            }
            else
            {
                cda = _context.CDAs.SingleOrDefault(c => c.CDACode == cda.CDACode);
                CDABindingSource.DataSource = cda;
                FillCase();
                if (cda.NoticeMethod != null)
                {
                    string[] methods = cda.NoticeMethod.Split(',');
                    foreach (string method in methods)
                    {
                        if ("Fax".Equals(method))
                        {
                            cbNoticeMethodFax.Checked = true;
                        }
                        else if ("Email".Equals(method))
                        {
                            cbNoticeMethodEmail.Checked = true;
                        }
                    }
                }
            }

            UpdateCDAControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="opCDAType"></param>
        public CDADetail(OpCDAType opCDAType)
            : this((CDA)null, opCDAType)
        {
        }


        //?Private?Methods?(25)?
        private void CbIsCreditCoverRevolvingCheckedChanged(object sender, EventArgs e)
        {
            orderNumberTextBox.Enabled = !cbIsCreditCoverRevolving.Checked;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator1ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var cda = CDABindingSource.DataSource as CDA;
            if (cda != null)
                if ("其他".Equals(cda.CommissionType))
                {
                    e.IsValid = !String.IsNullOrEmpty(e.ControlToValidate.Text);
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
        private void CustomValidator10ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var cda = CDABindingSource.DataSource as CDA;
            if (cda != null)
            {
                if (cda.Case == null)
                {
                    return;
                }

                if (cda.Case.TransactionType == "进口保理")
                {
                    e.IsValid = !String.IsNullOrEmpty(iFPriceTextBox.Text);
                }
                else
                {
                    e.IsValid = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator2ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var cda = CDABindingSource.DataSource as CDA;
            if (cda != null)
            {
                if (cda.Case == null)
                {
                    return;
                }

                //if (cda.IsCreditCoverRevolving.GetValueOrDefault())
                //{
                //    e.IsValid = true;
                //    return;
                //}

                ClientCreditLine creditLine = cda.Case.BuyerClient.AssignCreditLine;
                if (creditLine != null)
                {
                    decimal buyerCreditLine = creditLine.CreditLine;
                    if (cda.CreditCoverCurr != creditLine.CreditLineCurrency)
                    {
                        decimal exchange = Exchange.GetExchangeRate(creditLine.CreditLineCurrency, cda.CreditCoverCurr);
                        buyerCreditLine *= exchange;
                    }
                    e.IsValid = cda.CreditCover <= buyerCreditLine;
                }
                else
                {
                    e.IsValid = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator3ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var cda = CDABindingSource.DataSource as CDA;
            if (cda != null)
            {
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
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator4ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var cda = CDABindingSource.DataSource as CDA;
            if (cda != null)
            {
                if (cda.Case == null)
                {
                    return;
                }

                ClientCreditLine creditLine = cda.Case.HighestFinanceLine;

                if (creditLine != null)
                {
                    decimal theCreditLine = creditLine.CreditLine;
                    if (cda.FinanceLineCurr != creditLine.CreditLineCurrency)
                    {
                        decimal exchange = Exchange.GetExchangeRate(creditLine.CreditLineCurrency, cda.FinanceLineCurr);
                        theCreditLine *= exchange;
                    }

                    e.IsValid = cda.FinanceLine <= theCreditLine;
                }
                else
                {
                    e.IsValid = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void CustomValidator5ValidateValue(object sender, ValidateValueEventArgs e)
        //{
        //    var cda = CDABindingSource.DataSource as CDA;
        //    if (cda != null)
        //    {
        //        if (cda.Case == null)
        //        {
        //            return;
        //        }

        //        //if (cda.IsRecoarse.GetValueOrDefault() && cda.FinanceLine > cda.CreditCover)
        //        //{
        //        //    e.IsValid = false;
        //        //}
        //        //else
        //        //{
        //        //    e.IsValid = true;
        //        //}
        //    }
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator6ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var cda = CDABindingSource.DataSource as CDA;
            if (cda != null)
            {
                if (cda.Case == null)
                {
                    return;
                }

                ClientCreditLine creditLine = cda.Case.HighestFinanceLine;

                if (creditLine != null && cda.FinanceLinePeriodEnd > creditLine.PeriodEnd)
                {
                    e.IsValid = false;
                }
                else
                {
                    e.IsValid = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator7ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var cda = CDABindingSource.DataSource as CDA;
            if (cda != null)
            {
                if (cda.Case == null)
                {
                    return;
                }

                if (cda.Deductibles.HasValue && cda.CreditCover.HasValue)
                {
                    e.IsValid = cda.Deductibles.Value <= cda.CreditCover.Value;
                }
                else
                {
                    e.IsValid = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator8ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var cda = CDABindingSource.DataSource as CDA;
            if (cda != null)
            {
                if (cda.Case == null)
                {
                    return;
                }

                if (cda.LossThreshold.HasValue && cda.CreditCover.HasValue)
                {
                    e.IsValid = cda.LossThreshold.Value <= cda.CreditCover.Value;
                }
                else
                {
                    e.IsValid = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator9ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var cda = CDABindingSource.DataSource as CDA;
            if (cda != null)
            {
                if (cda.Case == null)
                {
                    return;
                }

                if (cda.Case.TransactionType != "进口保理")
                {
                    e.IsValid = !String.IsNullOrEmpty(priceTextBox.Text);
                }
                else
                {
                    e.IsValid = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomValidator11ValidateValue(object sender, ValidateValueEventArgs e)
        {
            var cda = CDABindingSource.DataSource as CDA;
            if (cda != null)
            {
                if (cda.Case.IsPool)
                {
                    if (cda.PoolInvoiceGraceDays == null)
                        e.IsValid = false;
                    else
                        e.IsValid = true;
                }
                else
                {
                    e.IsValid = true;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailBuyer(object sender, EventArgs e)
        {
            var cda = (CDA)CDABindingSource.DataSource;
            if (cda == null || cda.Case == null)
            {
                return;
            }

            var clientDetail = new ClientDetail(cda.Case.BuyerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
            clientDetail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCase(object sender, EventArgs e)
        {
            var cda = (CDA)CDABindingSource.DataSource;
            if (cda == null || cda.Case == null)
            {
                return;
            }

            var caseDetail = new CaseDetail(cda.Case, CaseDetail.OpCaseType.DETAIL_CASE);
            caseDetail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailContract(object sender, EventArgs e)
        {
            var cda = (CDA)CDABindingSource.DataSource;
            if (cda == null || cda.Case == null)
            {
                return;
            }

            if (cda.Case.SellerClient.Contract != null)
            {
                var clientDetail = new ClientDetail(cda.Case.SellerClient.Contract,
                                                    ClientDetail.OpContractType.DETAIL_CONTRACT);
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
            var cda = (CDA)CDABindingSource.DataSource;
            if (cda == null || cda.Case == null)
            {
                return;
            }

            Factor factor = cda.Case.Factor;

            if (factor != null)
            {
                var factorDetail = new FactorDetail(factor, FactorDetail.OpFactorType.DETAIL_FACTOR);
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
            var cda = (CDA)CDABindingSource.DataSource;
            if (cda == null || cda.Case == null)
            {
                return;
            }

            var clientDetail = new ClientDetail(cda.Case.SellerClient, ClientDetail.OpClientType.DETAIL_CLIENT);
            clientDetail.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        private void FillCase()
        {
            var cda = (CDA)CDABindingSource.DataSource;
            if (cda.Case == null)
            {
                return;
            }

            cda.HandFeeCurr = cda.Case.InvoiceCurrency;
            Contract contract = cda.Case.SellerClient.Contract;
            if (contract != null)
            {
                contractCodeTextBox.Text = contract.ContractCode;
            }

            Factor factor = cda.Case.Factor;
            factorCodeTextBox.Text = factor.FactorCode;
            companyNameCNTextBox.Text = factor.CompanyNameCN;
            companyNameENTextBox.Text = factor.CompanyNameEN;

            if (_opCDAType == OpCDAType.NEW_CDA)
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
            var cda = (CDA)CDABindingSource.DataSource;
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
                if (buyerCreditLine.CreditLine==0)
                {
                    cda.PUGProportion = 0;
                }
                cda.IsRecoarse = false;
            }
            else
            {
                creditCoverCurrComboBox.Enabled = false;
                creditCoverPeriodBeginDateTimePicker.Enabled = false;
                creditCoverPeriodEndDateTimePicker.Enabled = false;
                creditCoverTextBox.Enabled = false;
                creditCoverPeriodBeginDateTimePicker.Value = default(DateTime);
                creditCoverPeriodEndDateTimePicker.Value = default(DateTime);
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
            var cda = (CDA)CDABindingSource.DataSource;
            if (cda.Case == null)
            {
                return;
            }

            ClientCreditLine creditLine = cda.Case.HighestFinanceLine;

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
                financeLineCurrComboBox.Enabled = false;
                financeLinePeriodBeginDateTimePicker.Enabled = false;
                financeLinePeriodEndDateTimePicker.Enabled = false;
                financeLineTextBox.ReadOnly = true;
                financeLinePeriodBeginDateTimePicker.Value = default(DateTime);
                financeLinePeriodEndDateTimePicker.Value = default(DateTime);
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
        private static CDA GenerateDefaultCDA(Case curCase)
        {
            var cda = new CDA
                          {
                              CDASignDate = DateTime.Now.Date,
                              CommissionType = "按转让金额",
                              PUGProportion = 1,
                              PUGPeriod = 90,
                              ReassignGracePeriod = 45,
                              FinanceProportion = 0.8,
                              IsNotice = "明保理",
                              RiskType = "高风险",
                              CDAStatus = CDAStr.UNCHECK,
                              IsCreditCoverRevolving = true,
                              AssignType = "全部",
                              CommissionPrePost = "先收",
                              AssignNotifyType = "买方书面确认",
                              FinanceRatioType = "单笔单议",
                              PenaltyInterestRate = 0.001,
                              Case = curCase
                          };
            return cda;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveCDA(object sender, EventArgs e)
        {
            if (!PermUtil.CheckPermission(Permissions.CDA_UPDATE))
            {
                return;
            }

            var cda = (CDA)CDABindingSource.DataSource;

            if (!superValidator.Validate())
            {
                return;
            }

            FactorCreditLine factorCreditLine = cda.Case.BuyerFactor.FactorCreditLines.FirstOrDefault();
            if (factorCreditLine != null && (cda.Case.TransactionType == "出口保理" || cda.Case.TransactionType == "国内卖方保理") && cda.CreditCoverPeriodEnd > factorCreditLine.PeriodEnd)
            {
                DialogResult dr = MessageBoxEx.Show("此业务的买方信用风险担保额度到期日大于买方保理商的保理商额度的到期日，是否继续保存", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }
            if (factorCreditLine != null && (cda.Case.TransactionType == "出口保理" || cda.Case.TransactionType == "国内卖方保理"))
            {
                decimal outstanding = factorCreditLine.CreditLineOutstanding;
                if(factorCreditLine.CreditLineCurrency!=cda.CreditCoverCurr)
                {
                    decimal rate = Exchange.GetExchangeRate(factorCreditLine.CreditLineCurrency, cda.CreditCoverCurr);
                    outstanding *= rate;
                }
                if (cda.CreditCover > outstanding)
                {
                    DialogResult dr = MessageBoxEx.Show("此业务的买方信用风险担保额度大于买方保理商的剩余保理商额度("+factorCreditLine.CreditLineCurrency+" "+factorCreditLine.CreditLineOutstanding+")，是否继续保存", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            if (cbNoticeMethodEmail.Checked)
            {
                cda.NoticeMethod = "Email";
            }
            if (cbNoticeMethodFax.Checked)
            {
                cda.NoticeMethod = cda.NoticeMethod == null ? "Fax" : "Email,Fax";
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

            if (cda.Price < cda.IFPrice)
            {
                MessageBoxEx.Show("IF手续费率不能大于总手续费率",MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cda.EFPrice = cda.Price - cda.IFPrice;
            cda.CreateUserName = App.Current.CurUser.Name;
            cda.CDAStatus = CDAStr.UNCHECK;

            if (cda.CDACode == null)
            {
                bool isAddOK = true;
                if (cda.Case.SellerClient.Contract == null)
                {
                    MessageBoxEx.Show("卖方没有有效合同，不能创建CDA", MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cdaCode = CDA.GenerateCDACode(cda.Case);
                if (String.IsNullOrEmpty(cdaCode))
                {
                    MessageBoxEx.Show("CDA编号生成失败", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    return;
                }

                cda.CDACode = cdaCode;

                try
                {
                    _context.CDAs.InsertOnSubmit(cda);
                    _context.SubmitChanges();
                }
                catch (Exception e1)
                {
                    cda.CDACode = null;
                    isAddOK = false;
                    MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (isAddOK)
                {
                    MessageBoxEx.Show("数据新建成功", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    _opCDAType = OpCDAType.UPDATE_CDA;
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
                    if (cda.CDAStatus == CDAStr.CHECKED)
                    {
                        foreach (CDA c in cda.Case.CDAs)
                        {
                            if (c != cda && c.CDAStatus == CDAStr.CHECKED)
                            {
                                c.CDAStatus = CDAStr.INVALID;
                            }
                        }

                        try
                        {
                            _context.SubmitChanges();
                        }
                        catch (Exception e1)
                        {
                            MessageBoxEx.Show(e1.Message, MESSAGE.TITLE_WARNING, MessageBoxButtons.OK,
                                              MessageBoxIcon.Warning);
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
            if (!PermUtil.CheckPermission(Permissions.CDA_UPDATE))
            {
                return;
            }

            var caseMgr = new CaseMgr(CaseMgr.OpCaseType.ENABLE_CASE);
            var queryForm = new QueryForm(caseMgr, "选择案件");
            caseMgr.OwnerForm = queryForm;
            queryForm.ShowDialog(this);
            Case curCase = caseMgr.Selected;
            if (curCase != null)
            {
                CDA cda = GenerateDefaultCDA(curCase);
                cda.Case = _context.Cases.SingleOrDefault(c => c.CaseCode == curCase.CaseCode);
                CDABindingSource.DataSource = cda;
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
            if (!PermUtil.CheckPermission(Permissions.CDA_UPDATE))
            {
                return;
            }

            var cda = (CDA)CDABindingSource.DataSource;
            if (cda == null)
            {
                MessageBoxEx.Show("请首先选择一个额度通知书", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            //if (cda.CDAStatus == CDAStr.CHECKED)
            //{
            //    MessageBoxEx.Show("额度通知书已审核，不能修改", MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            _opCDAType = OpCDAType.UPDATE_CDA;
            UpdateCDAControlStatus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateCDAControlStatus()
        {
            if (_opCDAType == OpCDAType.DETAIL_CDA)
            {
                foreach (Control comp in groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelCreditCover.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelOther.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                btnCaseSelect.Visible = false;
            }
            else if (_opCDAType == OpCDAType.NEW_CDA)
            {
                foreach (Control comp in groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelCreditCover.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelOther.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }
            else if (_opCDAType == OpCDAType.UPDATE_CDA)
            {
                foreach (Control comp in groupPanelCase.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, false);
                }

                foreach (Control comp in groupPanelCreditCover.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }

                foreach (Control comp in groupPanelOther.Controls)
                {
                    ControlUtil.SetComponetEditable(comp, true);
                }
            }

            ControlUtil.SetComponetEditable(tbCDACode, false);
            ControlUtil.SetComponetEditable(tbHighestFinance, false);
            ControlUtil.SetComponetEditable(createUserNameTextBox, false);
            ControlUtil.SetComponetEditable(cDAStatusComboBox, false);

            //var cda = (CDA)CDABindingSource.DataSource;
            //if (_opCDAType != OpCDAType.DETAIL_CDA && cda.Case != null)
            //{
            //    ClientCreditLine creditLine = cda.Case.BuyerClient.AssignCreditLine;
            //    if (creditLine == null)
            //    {
            //        creditCoverCurrComboBox.Enabled = false;
            //        creditCoverPeriodBeginDateTimePicker.Enabled = false;
            //        creditCoverPeriodEndDateTimePicker.Enabled = false;
            //        creditCoverPeriodBeginDateTimePicker.Value = default(DateTime);
            //        creditCoverPeriodEndDateTimePicker.Value = default(DateTime);
            //        creditCoverTextBox.Enabled = false;
            //    }

            //    ClientCreditLine financeLine = cda.Case.HighestFinanceLine;

            //    if (financeLine == null)
            //    {
            //        financeLineCurrComboBox.Enabled = false;
            //        financeLinePeriodBeginDateTimePicker.Enabled = false;
            //        financeLinePeriodEndDateTimePicker.Enabled = false;
            //        financeLinePeriodBeginDateTimePicker.Value = default(DateTime);
            //        financeLinePeriodEndDateTimePicker.Value = default(DateTime);
            //        financeLineTextBox.Enabled = false;
            //    }
            //}
        }

        private void cbIsRecoarse_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsRecoarse.Checked)
            {
                creditCoverCurrComboBox.Enabled = false;
                creditCoverPeriodBeginDateTimePicker.Enabled = false;
                creditCoverPeriodEndDateTimePicker.Enabled = false;
                creditCoverTextBox.ReadOnly = true;
            }
            else
            {
                creditCoverCurrComboBox.Enabled = true;
                creditCoverPeriodBeginDateTimePicker.Enabled = true;
                creditCoverPeriodEndDateTimePicker.Enabled = true;
                creditCoverPeriodBeginDateTimePicker.Value = default(DateTime);
                creditCoverPeriodEndDateTimePicker.Value = default(DateTime);
                creditCoverTextBox.ReadOnly = false;
            }
        }
    }
}
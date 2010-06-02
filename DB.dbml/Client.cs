//-----------------------------------------------------------------------
// <copyright file="Client.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.DB.dbml
{
    using System;
    using System.Collections.Generic;
    using System.Data.Linq;
    using System.Linq;
    using System.Text.RegularExpressions;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;

    /// <summary>
    /// 
    /// </summary>
    public partial class Client
    {
        #region?Fields?(1)?

        private static Regex ClientEDICodeRegex = new Regex(@"^[a-zA-Z0-9]{2}[a-zA-Z0-9\\-]{1}[a-zA-Z0-9]{4}\d{2}$");

        #endregion?Fields?

        #region?Properties?(13)?

        /// <summary>
        /// 
        /// </summary>
        public string EDICode
        {
            get
            {
                if (!String.IsNullOrEmpty(this.OldEDICode))
                {
                    return this.OldEDICode;
                }
                else
                {
                    return this.ClientEDICode;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            get
            {
                if (this.AddressCN != null)
                {
                    return this.AddressCN;
                }
                else if (this.AddressEN != null)
                {
                    return this.AddressEN;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Gets �����÷��յ������
        /// </summary>
        public ClientCreditLine AssignCreditLine
        {
            get
            {
                IList<ClientCreditLine> creditLines = this.ClientCreditLines.Where(c => c.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "�����÷��յ������").ToList();
                if (creditLines.Count > 1)
                {
                    MessageBoxEx.Show("���������Ч�������÷��յ�����ȣ��ͻ����: " + this.ClientEDICode, MESSAGE.TITLE_WARNING);
                    return null;
                }
                else if (creditLines.Count == 1)
                {
                    return creditLines[0];
                }
                else
                {
                    return null;
                }
            }
        }

        ///<summary>
        /// Gets �����÷��յ���������
        ///</summary>
        public System.Nullable<double> AssignCreditLineOutstanding
        {
            get
            {
                ClientCreditLine creditLine = this.AssignCreditLine;
                if (creditLine == null)
                {
                    return null;
                }

                return creditLine.CreditLine - this.GetAssignOutstandingAsBuyer(creditLine.CreditLineCurrency);
            }
        }

        /// <summary>
        /// Gets ����ͬ
        /// </summary>
        public Contract Contract
        {
            get
            {
                IList<Contract> contractList = this.Contracts.Where(c => c.ContractStatus == CONTRACT.AVAILABILITY).ToList();
                if (contractList.Count > 1)
                {
                    MessageBoxEx.Show("���������Ч������ͬ���ͻ����: " + this.ClientEDICode, MESSAGE.TITLE_WARNING);
                    return null;
                }
                else if (contractList.Count == 1)
                {
                    return contractList[0];
                }

                return null;
            }
        }

        /// <summary>
        /// Gets ����Ԥ�������ʶ��
        /// </summary>
        public ClientCreditLine FinanceCreditLine
        {
            get
            {
                IList<ClientCreditLine> creditLines = this.ClientCreditLines.Where(c => c.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "����Ԥ�������ʶ��").ToList();
                if (creditLines.Count > 1)
                {
                    MessageBoxEx.Show("���������Ч�ı���Ԥ�������ʶ�ȣ��ͻ����: " + this.ClientEDICode, MESSAGE.TITLE_WARNING);
                    return null;
                }
                else if (creditLines.Count == 1)
                {
                    return creditLines[0];
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Gets ��߱���Ԥ�������ʶ�����
        /// </summary>
        public System.Nullable<double> FinanceLineOutstanding
        {
            get
            {
                ClientCreditLine creditLine = this.FinanceCreditLine;
                if (creditLine == null)
                {
                    return null;
                }

                return creditLine.CreditLine - this.GetFinanceOutstanding(creditLine.CreditLineCurrency);
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public ClientCreditLine GroupAssignCreditLine
        {
            get
            {
                ClientCreditLine creditLine = this.AssignCreditLine;
                if (creditLine != null)
                {
                    return creditLine.GroupCreditLine;
                }

                return null;
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public ClientCreditLine GroupFinanceCreditLine
        {
            get
            {
                ClientCreditLine creditLine = FinanceCreditLine;
                if (creditLine != null)
                {
                    return creditLine.GroupCreditLine;
                }

                return null;
            }
        }

        /// <summary>
        /// �ֽ�����
        /// </summary>
        public double? PoolCashOutstanding
        {
            get
            {
                if (this.GuaranteeDeposits.Count > 0)
                {
                    double gd = this.GuaranteeDeposits[0].GuaranteeDepositAmount;
                    if (this.GuaranteeDeposits[0].GuaranteeDepositCurrency != "CNY")
                    {
                        double exchange = Exchange.GetExchangeRate(this.GuaranteeDeposits[0].GuaranteeDepositCurrency, "CNY");
                        gd *= exchange;
                    }

                    return gd;
                }

                return null;
            }
        }

        /// <summary>
        /// Gets �����ʶ��
        /// </summary>
        public ClientCreditLine PoolFinanceCreditLine
        {
            get
            {
                IList<ClientCreditLine> creditLines = this.ClientCreditLines.Where(c => c.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "�����ʶ��").ToList();
                if (creditLines.Count > 1)
                {
                    MessageBoxEx.Show("���������Ч�ĳ����ʶ�ȣ��ͻ����: " + this.ClientEDICode, MESSAGE.TITLE_WARNING);
                    return null;
                }
                else if (creditLines.Count == 1)
                {
                    return creditLines[0];
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// ���ʳ����
        /// </summary>
        public double? PoolFinanceOutstanding
        {
            get
            {
                double? total = null;
                foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == CASE.ENABLE && c.IsPool))
                {
                    double? financeOutstanding = curCase.FinanceOutstanding;
                    if (financeOutstanding.HasValue)
                    {
                        if (total == null)
                        {
                            total = 0;
                        }

                        if (curCase.InvoiceCurrency != "CNY")
                        {
                            double exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, "CNY");
                            financeOutstanding *= exchange;
                        }

                        total += financeOutstanding.Value;
                    }
                }

                return total;
            }
        }

        /// <summary>
        /// �����ʵ����˿����
        /// </summary>
        public double PoolTotalAssignOutstading
        {
            get
            {
                double result = 0;
                foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == CASE.ENABLE && c.IsPool))
                {
                    double assignOutstanding = curCase.AssignOutstanding;
                    if (curCase.InvoiceCurrency != "CNY")
                    {
                        double exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, "CNY");
                        assignOutstanding *= exchange;
                    }

                    result += assignOutstanding;
                }

                return result;
            }
        }

        /// <summary>
        /// ��������Ч���˿�����Ӧ���˿�����
        /// </summary>
        public double PoolValuedAssignOutstanding
        {
            get
            {
                double result = 0;
                foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == CASE.ENABLE && c.IsPool))
                {
                    double assignOutstanding = curCase.ValuedAssignOutstanding;
                    if (curCase.InvoiceCurrency != "CNY")
                    {
                        double exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, "CNY");
                        assignOutstanding *= exchange;
                    }

                    result += assignOutstanding;
                }

                return result;
            }
        }

        #endregion?Properties?

        #region?Methods?(6)?

        //?Public?Methods?(5)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="currency"></param>
        /// <returns></returns>
        public double CanBeFinanceAmount(string transactionType, string currency)
        {
            double result = 0;
            foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == CASE.ENABLE && c.TransactionType == transactionType))
            {
                double canbeFinanceAmount = curCase.CanBeFinanceAmount;
                if (curCase.InvoiceCurrency != currency)
                {
                    double exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                    canbeFinanceAmount *= exchange;
                }

                result += canbeFinanceAmount;
            }

            ClientCreditLine creditLine = this.FinanceCreditLine;
            double creditLineAmount = 0;
            if (creditLine != null)
            {
                creditLineAmount = creditLine.CreditLine;
                if (creditLine.CreditLineCurrency != currency)
                {
                    double exchange = Exchange.GetExchangeRate(creditLine.CreditLineCurrency, currency);
                    creditLineAmount *= exchange;
                }
            }

            return Math.Min(result, creditLineAmount - GetFinanceOutstanding(currency).GetValueOrDefault());
        }

        /// <summary>
        /// ת�����
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public double GetAssignOutstandingAsBuyer(string currency)
        {
            double result = 0;
            foreach (Case curCase in this.BuyerCases.Where(c => c.CaseMark == CASE.ENABLE))
            {
                double assignOutstanding = curCase.AssignOutstanding;
                if (curCase.InvoiceCurrency != currency)
                {
                    double exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                    assignOutstanding *= exchange;
                }

                result += assignOutstanding;
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="currency"></param>
        /// <returns></returns>
        public double GetAssignOutstandingAsSeller(string transactionType, string currency)
        {
            double result = 0;
            foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == CASE.ENABLE && c.TransactionType == transactionType))
            {
                double assignOutstanding = curCase.AssignOutstanding;
                if (curCase.InvoiceCurrency != currency)
                {
                    double exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                    assignOutstanding *= exchange;
                }

                result += assignOutstanding;
            }

            return result;
        }

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public System.Nullable<double> GetFinanceOutstanding(string currency)
        {
            double? total = null;
            foreach (Case curCase in this.SellerCases.Where(c => c.CaseMark == CASE.ENABLE))
            {
                double? financeOutstanding = curCase.FinanceOutstanding;
                if (financeOutstanding.HasValue)
                {
                    if (total == null)
                    {
                        total = 0;
                    }

                    if (curCase.InvoiceCurrency != currency)
                    {
                        double exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                        financeOutstanding *= exchange;
                    }

                    total += financeOutstanding.Value;
                }
            }

            return total;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!String.IsNullOrEmpty(_ClientNameCN))
            {
                return _ClientNameCN;
            }
            else
            {
                return _ClientNameEN;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public GuaranteeDeposit GetGuaranteeDeposit(string currency)
        {
            IList<GuaranteeDeposit> gdList = this.GuaranteeDeposits.Where(g => g.GuaranteeDepositCurrency == currency).OrderByDescending(d => d.DepositDate).ToList();
            if (gdList.Count > 0)
            {
                return gdList[0];
            }
            else
            {
                return null;
            }
        }

        //?Private?Methods?(1)?

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(System.Data.Linq.ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!ClientEDICodeRegex.IsMatch(this.ClientEDICode))
                {
                    throw new ArgumentException("�����ϱ���������: " + this.ClientEDICode);
                }
            }
        }

        #endregion?Methods?
    }
}

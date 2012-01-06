//-----------------------------------------------------------------------
// <copyright file="Client.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text.RegularExpressions;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.DB.dbml
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Client
    {
        private static readonly Regex ClientEDICodeRegex =
            new Regex(@"^[a-zA-Z0-9]{2}[a-zA-Z0-9\\-]{1}[a-zA-Z0-9]{4}\d{2}$");

        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            get
            {
                if (AddressCN != null)
                {
                    return AddressCN;
                }
                return AddressEN ?? string.Empty;
            }
        }

        /// <summary>
        /// Gets �����÷��յ������
        /// </summary>
        public ClientCreditLine AssignCreditLine
        {
            get
            {
                IList<ClientCreditLine> creditLines =
                    ClientCreditLines.Where(
                        c => c.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "�����÷��յ������").
                        ToList();
                if (creditLines.Count > 1)
                {
                    MessageBoxEx.Show("���������Ч�������÷��յ�����ȣ��ͻ����: " + ClientEDICode, MESSAGE.TITLE_WARNING);
                    return null;
                }
                return creditLines.Count == 1 ? creditLines[0] : null;
            }
        }

        ///<summary>
        /// Gets �����÷��յ���������
        ///</summary>
        public decimal? AssignCreditLineOutstanding
        {
            get
            {
                ClientCreditLine creditLine = AssignCreditLine;
                if (creditLine == null)
                {
                    return null;
                }

                return creditLine.CreditLine - GetAssignOutstandingAsBuyer(creditLine.CreditLineCurrency);
            }
        }

        /// <summary>
        /// Gets ����ͬ
        /// </summary>
        public Contract Contract
        {
            get
            {
                IList<Contract> contractList = Contracts.Where(c => c.ContractStatus == CONTRACT.AVAILABILITY).ToList();
                if (contractList.Count > 1)
                {
                    MessageBoxEx.Show("���������Ч������ͬ���ͻ����: " + ClientEDICode, MESSAGE.TITLE_WARNING);
                    return null;
                }
                if (contractList.Count == 1)
                {
                    return contractList[0];
                }

                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string EDICode
        {
            get { return !String.IsNullOrEmpty(OldEDICode) ? OldEDICode : ClientEDICode; }
        }

        /// <summary>
        /// Gets ����Ԥ�������ʶ��
        /// </summary>
        public ClientCreditLine FinanceCreditLine
        {
            get
            {
                IList<ClientCreditLine> creditLines =
                    ClientCreditLines.Where(
                        c => c.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "����Ԥ�������ʶ��").
                        ToList();
                if (creditLines.Count > 1)
                {
                    MessageBoxEx.Show("���������Ч�ı���Ԥ�������ʶ�ȣ��ͻ����: " + ClientEDICode, MESSAGE.TITLE_WARNING);
                    return null;
                }
                return creditLines.Count == 1 ? creditLines[0] : null;
            }
        }

        /// <summary>
        /// Gets ��߱���Ԥ�������ʶ�����
        /// </summary>
        public decimal? FinanceLineOutstanding
        {
            get
            {
                ClientCreditLine creditLine = FinanceCreditLine;
                if (creditLine == null)
                {
                    return null;
                }

                return creditLine.CreditLine - GetFinanceOutstanding(creditLine.CreditLineCurrency);
            }
        }

        /// <summary>
        /// Gets
        /// </summary>
        public ClientCreditLine GroupAssignCreditLine
        {
            get
            {
                ClientCreditLine creditLine = AssignCreditLine;
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
        public decimal GetPoolCashOutstanding(string currency)
        {
                decimal cashTotal = 0;
                decimal totalPayment = 0;
                foreach (Case curCase in SellerCases.Where(c => c.CaseMark == CASE.ENABLE && c.IsPool))
                {
                    decimal paymentAmount = curCase.PaymentAmountByDate;
                    if (curCase.InvoiceCurrency != currency)
                    {
                        decimal exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                        paymentAmount *= (decimal)exchange;
                    }

                    totalPayment += paymentAmount;
                }

                decimal totalRefund = 0;
                foreach (InvoiceFinanceBatch financeBatch in InvoiceFinanceBatches)
                {
                    decimal refundAmount = financeBatch.PoolRefundAmount.GetValueOrDefault();

                    if (financeBatch.BatchCurrency != currency)
                    {
                        decimal exchange = Exchange.GetExchangeRate(financeBatch.BatchCurrency, currency);
                        refundAmount *= (decimal)exchange;
                    }

                    totalRefund += refundAmount;
                }

                cashTotal = totalPayment - totalRefund;

                if (GuaranteeDeposits.Count > 0)
                {
                    decimal gd = GuaranteeDeposits[0].GuaranteeDepositAmount;
                    if (GuaranteeDeposits[0].GuaranteeDepositCurrency != currency)
                    {
                        decimal exchange = Exchange.GetExchangeRate(GuaranteeDeposits[0].GuaranteeDepositCurrency, currency);
                        gd *= (decimal)exchange;
                    }

                    cashTotal += gd;
                }

                return cashTotal;
        }

        /// <summary>
        /// Gets �����ʶ��
        /// </summary>
        public ClientCreditLine PoolFinanceCreditLine
        {
            get
            {
                IList<ClientCreditLine> creditLines =
                    ClientCreditLines.Where(
                        c => c.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY && c.CreditLineType == "�����ʶ��").
                        ToList();
                if (creditLines.Count > 1)
                {
                    MessageBoxEx.Show("���������Ч�ĳ����ʶ�ȣ��ͻ����: " + ClientEDICode, MESSAGE.TITLE_WARNING);
                    return null;
                }
                return creditLines.Count == 1 ? creditLines[0] : null;
            }
        }

        /// <summary>
        /// ���ʳ����
        /// </summary>
        public decimal GetPoolFinanceOutstanding(string currency)
        {
                decimal total = 0;
                foreach (InvoiceFinanceBatch financeBatch in InvoiceFinanceBatches)
                {
                    decimal financeOutstanding = financeBatch.PoolFinanceOutstanding;

                    if (financeBatch.BatchCurrency != currency)
                    {
                        decimal exchange = Exchange.GetExchangeRate(financeBatch.BatchCurrency, currency);
                        financeOutstanding *= exchange;
                    }

                    total += financeOutstanding;
                }

                return total;
        }

        /// <summary>
        /// �����ʵ����˿����
        /// </summary>
        public decimal GetPoolTotalAssignOutstading(string currency)
        {
            decimal result = 0;
                foreach (Case curCase in SellerCases.Where(c => c.CaseMark == CASE.ENABLE && c.IsPool))
                {
                    decimal assignOutstanding = curCase.AssignOutstanding;
                    if (curCase.InvoiceCurrency != currency)
                    {
                        decimal exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                        assignOutstanding *= exchange;
                    }

                    result += assignOutstanding;
                }

                return result;
        }

        /// <summary>
        /// ��������Ч���˿�����Ӧ���˿�����
        /// </summary>
        public decimal GetPoolCanBeFinance(string currency)
        {
            decimal result = 0;
            foreach (Case curCase in SellerCases.Where(c => c.CaseMark == CASE.ENABLE && c.IsPool))
            {
                decimal canBeFinance = curCase.CanBeFinanceAmount;
                if (curCase.InvoiceCurrency != currency)
                {
                    decimal exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                    canBeFinance *= exchange;
                }

                result += canBeFinance;
            }

            return result;
        }


        //?Public?Methods?(5)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="transactionType"></param>
        /// <param name="currency"></param>
        /// <returns></returns>
        public decimal CanBeFinanceAmount(string transactionType, string currency)
        {
            decimal result = 0;
            EntitySet<Case> cases = (transactionType == "������������" || transactionType == "���ڱ���")
                                        ? SellerCases
                                        : BuyerCases;
            foreach (
                Case curCase in
                    cases.Where(c => c.CaseMark == CASE.ENABLE && c.TransactionType == transactionType))
            {
                decimal canbeFinanceAmount = curCase.CanBeFinanceAmount;
                if (curCase.InvoiceCurrency != currency)
                {
                    decimal exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                    canbeFinanceAmount *= exchange;
                }

                result += canbeFinanceAmount;
            }

            ClientCreditLine creditLine = FinanceCreditLine;
            decimal creditLineAmount = 0;
            if (creditLine != null)
            {
                creditLineAmount = creditLine.CreditLine;
                if (creditLine.CreditLineCurrency != currency)
                {
                    decimal exchange = Exchange.GetExchangeRate(creditLine.CreditLineCurrency, currency);
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
        public decimal GetAssignOutstandingAsBuyer(string currency)
        {
            decimal result = 0;
            foreach (Case curCase in BuyerCases.Where(c => c.CaseMark == CASE.ENABLE))
            {
                decimal assignOutstanding = curCase.AssignOutstanding;
                if (curCase.InvoiceCurrency != currency)
                {
                    decimal exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
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
        public decimal GetAssignOutstandingAsSeller(string transactionType, string currency)
        {
            decimal result = 0;
            foreach (
                Case curCase in
                    SellerCases.Where(c => c.CaseMark == CASE.ENABLE && c.TransactionType == transactionType))
            {
                decimal assignOutstanding = curCase.AssignOutstanding;
                if (curCase.InvoiceCurrency != currency)
                {
                    decimal exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
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
        public decimal? GetFinanceOutstanding(string currency)
        {
            decimal? total = null;
            foreach (Case curCase in SellerCases.Where(c => c.CaseMark == CASE.ENABLE))
            {
                decimal? financeOutstanding = curCase.FinanceOutstanding;
                if (financeOutstanding.HasValue)
                {
                    if (total == null)
                    {
                        total = 0;
                    }

                    if (curCase.InvoiceCurrency != currency)
                    {
                        decimal exchange = Exchange.GetExchangeRate(curCase.InvoiceCurrency, currency);
                        financeOutstanding *= (decimal)exchange;
                    }

                    total += financeOutstanding.Value;
                }
            }

            return total;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public GuaranteeDeposit GetGuaranteeDeposit(string currency)
        {
            IList<GuaranteeDeposit> gdList =
                GuaranteeDeposits.Where(g => g.GuaranteeDepositCurrency == currency).OrderByDescending(
                    d => d.DepositDate).ToList();
            return gdList.Count > 0 ? gdList[0] : null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return !String.IsNullOrEmpty(_ClientNameCN) ? _ClientNameCN : _ClientNameEN;
        }

        //?Private?Methods?(1)?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        partial void OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                if (!ClientEDICodeRegex.IsMatch(ClientEDICode))
                {
                    throw new ArgumentException("�����ϱ���������: " + ClientEDICode);
                }
            }
        }
    }
}
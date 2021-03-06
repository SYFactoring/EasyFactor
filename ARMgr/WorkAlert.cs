//-----------------------------------------------------------------------
// <copyright file="WorkAlert.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using CMBC.EasyFactor.CaseMgr;
using CMBC.EasyFactor.DB.dbml;
using CMBC.EasyFactor.InfoMgr.ClientMgr;
using CMBC.EasyFactor.InfoMgr.FactorMgr;
using CMBC.EasyFactor.Utils;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class WorkAlert : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public WorkAlert()
        {
            InitializeComponent();
            AddSuperToolTip();
            CheckUpdates();
        }

        //?Private?Methods?(31)?
        /// <summary>
        /// 
        /// </summary>
        private void AddSuperToolTip()
        {
            const eTooltipColor color = eTooltipColor.Apple;
            superTooltip.SetSuperTooltip(btnNeedCheckCDA, new SuperTooltipInfo(@"需要放行的额度通知书", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnWaitCheckCDA, new SuperTooltipInfo(@"等待放行的额度通知书", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnRejectCheckCDA,
                                         new SuperTooltipInfo(@"拒绝放行的额度通知书", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnDueAssign7, new SuperTooltipInfo(@"7日内到期的应收账款", "", "", null, null, color));
            superTooltip.SetSuperTooltip(btnDueAssign0, new SuperTooltipInfo(@"今日到期的应收账款", "", "", null, null, color));
            superTooltip.SetSuperTooltip(btnDueAssign, new SuperTooltipInfo(@"已经逾期的应收账款", "", "", null, null, color));
            superTooltip.SetSuperTooltip(btnInvoiceDispute, new SuperTooltipInfo(@"商纠账款", "", "", null, null, color));
            superTooltip.SetSuperTooltip(btnDuplicateInvoice, new SuperTooltipInfo(@"重复发票", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnDueFinance7, new SuperTooltipInfo(@"7日内到期的应收账款", "", "", null, null, color));
            superTooltip.SetSuperTooltip(btnDueFinance0, new SuperTooltipInfo(@"今日到期的应收账款", "", "", null, null, color));
            superTooltip.SetSuperTooltip(btnDueFinance, new SuperTooltipInfo(@"已经逾期的应收账款", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnDueClientCreditLine,
                                         new SuperTooltipInfo(@"客户额度到期", "", "", null, null, color));
            superTooltip.SetSuperTooltip(btnDueFactorCreditLine,
                                         new SuperTooltipInfo(@"保理商额度到期", "", "", null, null, color));
            superTooltip.SetSuperTooltip(btnDueCDA, new SuperTooltipInfo(@"额度通知书到期", "", "", null, null, color));
            superTooltip.SetSuperTooltip(btnDueContract, new SuperTooltipInfo(@"保理合同到期", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnNeedCheckAssignBatch, new SuperTooltipInfo(@"需要放行的转让批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnWaitCheckAssignBatch, new SuperTooltipInfo(@"等待放行的转让批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnRejectCheckAssignBatch,
                                         new SuperTooltipInfo(@"拒绝放行的转让批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnNeedCheckFinanceBatch, new SuperTooltipInfo(@"需要放行的融资批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnWaitCheckFinanceBatch, new SuperTooltipInfo(@"等待放行的融资批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnRejectCheckFinanceBatch,
                                         new SuperTooltipInfo(@"拒绝放行的融资批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnNeedCheckPaymentBatch, new SuperTooltipInfo(@"需要放行的付款批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnWaitCheckPaymentBatch, new SuperTooltipInfo(@"等待放行的付款批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnRejectCheckPaymentBatch,
                                         new SuperTooltipInfo(@"拒绝放行的还款批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnNeedCheckRefundBatch, new SuperTooltipInfo(@"需要放行的还款批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnWaitCheckRefundBatch, new SuperTooltipInfo(@"等待放行的还款批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnRejectCheckRefundBatch,
                                         new SuperTooltipInfo(@"拒绝放行的还款批次", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnNeedFlawCheck, new SuperTooltipInfo(@"需要放行的瑕疵发票", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnWaitFlawCheck, new SuperTooltipInfo(@"等待放行的瑕疵发票", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnRejectFlawCheck,
                                         new SuperTooltipInfo(@"拒绝放行的瑕疵发票", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnNeedDisputeCheck, new SuperTooltipInfo(@"需要放行的商纠发票", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnWaitDisputeCheck, new SuperTooltipInfo(@"等待放行的商纠发票", "", "", null, null, color));

            superTooltip.SetSuperTooltip(btnRejectDisputeCheck,
                                         new SuperTooltipInfo(@"拒绝放行的商纠发票", "", "", null, null, color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            if (worker == null)
                return;

            var context = new DBDataContext();
            int result;

            //QueryNeedFlawCheck
            result = context.Invoices.Count(c => c.FlawCheckStatus == BATCH.UNCHECK);
            worker.ReportProgress(result, btnNeedFlawCheck);

            //QueryWaitFlawCheck
            result =
                context.Invoices.Count(c => c.FlawCheckStatus == BATCH.UNCHECK && c.FlawResolveUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnWaitFlawCheck);

            //QueryRejectFlawCheck
            result =
                context.Invoices.Count(c => c.FlawCheckStatus == BATCH.REJECT && c.FlawResolveUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnRejectFlawCheck);

            //QueryNeedDisputeCheck
            result = context.Invoices.Count(c => c.DisputeCheckStatus == BATCH.UNCHECK);
            worker.ReportProgress(result, btnNeedDisputeCheck);

            //QueryWaitDisputeCheck
            result =
                context.Invoices.Count(c => c.DisputeCheckStatus == BATCH.UNCHECK && c.DisputeResolveUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnWaitDisputeCheck);

            //QueryRejectDisputeCheck
            result =
                context.Invoices.Count(c => c.DisputeCheckStatus == BATCH.REJECT && c.DisputeResolveUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnRejectDisputeCheck);

            //QueryNeedCheckAssignBatch
            result = context.InvoiceAssignBatches.Count(c => c.CheckStatus == BATCH.UNCHECK);
            worker.ReportProgress(result, btnNeedCheckAssignBatch);

            //QueryWaitCheckAssignBatch
            result =
                context.InvoiceAssignBatches.Count(c => c.CheckStatus == BATCH.UNCHECK && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnWaitCheckAssignBatch);

            //QueryRejectCheckAssignBatch
            result =
                context.InvoiceAssignBatches.Count(c => c.CheckStatus == BATCH.REJECT && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnRejectCheckAssignBatch);

            //QueryNeedCheckFinanceBatch
            result = context.InvoiceFinanceBatches.Count(c => c.CheckStatus == BATCH.UNCHECK);
            worker.ReportProgress(result, btnNeedCheckFinanceBatch);

            //QueryWaitCheckFinanceBatch
            result =
                context.InvoiceFinanceBatches.Count(c => c.CheckStatus == BATCH.UNCHECK && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnWaitCheckFinanceBatch);

            //QueryRejectCheckFinanceBatch
            result =
                context.InvoiceFinanceBatches.Count(c => c.CheckStatus == BATCH.REJECT && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnRejectCheckFinanceBatch);

            //QueryNeedCheckPaymentBatch
            result = context.InvoicePaymentBatches.Count(c => c.CheckStatus == BATCH.UNCHECK);
            worker.ReportProgress(result, btnNeedCheckPaymentBatch);

            //QueryWaitCheckPaymentBatch
            result =
                context.InvoicePaymentBatches.Count(c => c.CheckStatus == BATCH.UNCHECK && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnWaitCheckPaymentBatch);

            //QueryRejectCheckPaymentBatch
            result =
                context.InvoicePaymentBatches.Count(c => c.CheckStatus == BATCH.REJECT && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnRejectCheckPaymentBatch);

            //QueryNeedCheckRefundBatch
            result = context.InvoiceRefundBatches.Count(c => c.CheckStatus == BATCH.UNCHECK);
            worker.ReportProgress(result, btnNeedCheckRefundBatch);

            //QueryWaitCheckRefundBatch
            result =
                context.InvoiceRefundBatches.Count(c => c.CheckStatus == BATCH.UNCHECK && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnWaitCheckRefundBatch);

            //QueryRejectCheckRefundBatch
            result =
                context.InvoiceRefundBatches.Count(c => c.CheckStatus == BATCH.REJECT && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnRejectCheckRefundBatch);

            //QueryNeedCheckCDA
            result = context.CDAs.Count(c => c.CDAStatus == CDAStr.UNCHECK);
            worker.ReportProgress(result, btnNeedCheckCDA);

           //QueryWaitCheckCDA
            result =
                context.CDAs.Count(c => c.CDAStatus == CDAStr.UNCHECK && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnWaitCheckCDA);

           //QueryRejectCheckCDA
            result =
                context.CDAs.Count(c => c.CDAStatus == CDAStr.REJECT && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, btnRejectCheckCDA);

            //DuplicateInvoice
            var invoiceGroup = from i in context.Invoices group i by i.InvoiceNo into g where g.Count() > 1 select g.Key;
            worker.ReportProgress(invoiceGroup.Count() * 2, btnDuplicateInvoice);

            //DueAssign7
            result =
                context.Invoices.Count(
                    invoice =>
                    invoice.PaymentAmount.GetValueOrDefault() < invoice.AssignAmount &&
                    invoice.DueDate <= DateTime.Today.AddDays(7) && invoice.DueDate >= DateTime.Today);
            worker.ReportProgress(result, btnDueAssign7);

            //DueAssign0
            result =
                context.Invoices.Count(
                    invoice =>
                    invoice.PaymentAmount.GetValueOrDefault() < invoice.AssignAmount  &&
                    invoice.DueDate == DateTime.Today);
            worker.ReportProgress(result, btnDueAssign0);

            //DueAssign
            result =
                context.Invoices.Count(
                    invoice =>
                    invoice.PaymentAmount.GetValueOrDefault() < invoice.AssignAmount  &&
                    invoice.DueDate < DateTime.Today);
            worker.ReportProgress(result, btnDueAssign);

            //InvoiceDispute
            result = context.Invoices.Count(invoice => invoice.IsDispute == true);
            worker.ReportProgress(result, btnInvoiceDispute);

            //DueFinance7
            result =
                context.Invoices.Count(
                    invoice =>
                    invoice.RefundAmount.GetValueOrDefault() < invoice.FinanceAmount.GetValueOrDefault() 
                     && invoice.ReassignDate <= DateTime.Today.AddDays(7) &&
                    invoice.ReassignDate >= DateTime.Today);
            worker.ReportProgress(result, btnDueFinance7);

            //DueFinance0
            result =
                context.Invoices.Count(
                    invoice =>
                    invoice.RefundAmount.GetValueOrDefault() < invoice.FinanceAmount.GetValueOrDefault()
                     && invoice.ReassignDate == DateTime.Today);
            worker.ReportProgress(result, btnDueFinance0);

            //DueFinance
            result =
                context.Invoices.Count(
                    invoice =>
                    invoice.RefundAmount.GetValueOrDefault() < invoice.FinanceAmount.GetValueOrDefault()
                    && invoice.ReassignDate < DateTime.Today);
            worker.ReportProgress(result, btnDueFinance);

            //DueClientCreditLine
            result =
                context.ClientCreditLines.Count(
                    c => c.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY && c.PeriodEnd < DateTime.Today);
            worker.ReportProgress(result, btnDueClientCreditLine);

            //DueFactorCreditLine
            result =
                context.FactorCreditLines.Count(
                    f => f.CreditLineStatus == FACTOR_CREDIT_LINE.AVAILABILITY && f.PeriodEnd < DateTime.Today);
            worker.ReportProgress(result, btnDueFactorCreditLine);

            //DueCDA
            result = context.CDAs.Count(cda => cda.CDAStatus == CDAStr.CHECKED
                                               &&
                                               (cda.CreditCoverPeriodEnd < DateTime.Today ||
                                                cda.FinanceLinePeriodEnd < DateTime.Today));
            worker.ReportProgress(result, btnDueCDA);

            //DueContract
            result =
                context.Contracts.Count(
                    c => c.ContractStatus == CONTRACT.AVAILABILITY && c.ContractDueDate < DateTime.Today);
            worker.ReportProgress(result, btnDueContract);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var button = (ButtonX) e.UserState;
            SuperTooltipInfo tipInfo = superTooltip.GetSuperTooltip(button);
            tipInfo.BodyText = String.Format("有{0}条记录需要处理", e.ProgressPercentage);
            button.Text = String.Format("{0} ({1})", button.Text, e.ProgressPercentage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckUpdates()
        {
            backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCDADue(object sender, EventArgs e)
        {
            var mgr = new CDAMgr(CDAMgr.OpCDAType.DUE);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientCreditLineDue(object sender, EventArgs e)
        {
            var mgr = new ClientCreditLineMgr(ClientCreditLineMgr.OpClientCreditMgrType.DUE);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryContractDue(object sender, EventArgs e)
        {
            var mgr = new ContractMgr(ContractMgr.OpContractType.DUE);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryFactorCreditLineDue(object sender, EventArgs e)
        {
            var mgr = new FactorCreditLineMgr(FactorCreditLineMgr.OpFactorCreditMgrType.DUE);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryDuplicateInvoice(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.DUPLICATE_INVOICE);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceAssignDue(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.ASSIGN_DUE);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceAssignDueBy0(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.ASSIGN_DUE_BYDAY, 0);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceAssignDueBy7(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.ASSIGN_DUE_BYDAY, -7);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceDispute(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.DISPUTE_RESOLVE);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceFinanceDue(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FINANCE_DUE);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceFinanceDueBy0(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FINANCE_DUE_BYDAY, 0);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceFinanceDueBy7(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FINANCE_DUE_BYDAY, -7);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedCheckCDAs(object sender, EventArgs e)
        {
            var mgr = new CDAMgr(CDAMgr.OpCDAType.CHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckCDAs(object sender, EventArgs e)
        {
            var mgr = new CDAMgr(App.Current.CurUser.Name, CDAStr.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckCDAs(object sender, EventArgs e)
        {
            var mgr = new CDAMgr(App.Current.CurUser.Name, CDAStr.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedCheckAssignBatch(object sender, EventArgs e)
        {
            var mgr = new AssignBatchMgr(null, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckAssignBatch(object sender, EventArgs e)
        {
            var mgr = new AssignBatchMgr(App.Current.CurUser.Name, BATCH.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckAssignBatch(object sender, EventArgs e)
        {
            var mgr = new AssignBatchMgr(App.Current.CurUser.Name, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedCheckFinanceBatch(object sender, EventArgs e)
        {
            var mgr = new FinanceBatchMgr(null, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckFinanceBatch(object sender, EventArgs e)
        {
            var mgr = new FinanceBatchMgr(App.Current.CurUser.Name, BATCH.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckFinanceBatch(object sender, EventArgs e)
        {
            var mgr = new FinanceBatchMgr(App.Current.CurUser.Name, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedCheckPaymentBatch(object sender, EventArgs e)
        {
            var mgr = new PaymentBatchMgr(null, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckPaymentBatch(object sender, EventArgs e)
        {
            var mgr = new PaymentBatchMgr(App.Current.CurUser.Name, BATCH.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckPaymentBatch(object sender, EventArgs e)
        {
            var mgr = new PaymentBatchMgr(App.Current.CurUser.Name, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedCheckRefundBatch(object sender, EventArgs e)
        {
            var mgr = new RefundBatchMgr(null, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckRefundBatch(object sender, EventArgs e)
        {
            var mgr = new RefundBatchMgr(App.Current.CurUser.Name, BATCH.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckRefundBatch(object sender, EventArgs e)
        {
            var mgr = new RefundBatchMgr(App.Current.CurUser.Name, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedFlawCheck(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FLAW_RESOLVE, null, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectFlawCheck(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FLAW_RESOLVE, App.Current.CurUser.Name, BATCH.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitFlawCheck(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FLAW_RESOLVE, App.Current.CurUser.Name, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedDisputeCheck(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.DISPUTE_RESOLVE, null, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectDisputeCheck(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.DISPUTE_RESOLVE, App.Current.CurUser.Name, BATCH.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitDisputeCheck(object sender, EventArgs e)
        {
            var mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.DISPUTE_RESOLVE, App.Current.CurUser.Name, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr, sender.ToString());
        }
    }
}
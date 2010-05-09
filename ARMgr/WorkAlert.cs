//-----------------------------------------------------------------------
// <copyright file="WorkAlert.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.Utils.ConstStr;
    using DevComponents.DotNetBar;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// 
    /// </summary>
    public partial class WorkAlert : UserControl
    {
        #region?Constructors?(1)?

        /// <summary>
        /// 
        /// </summary>
        public WorkAlert()
        {
            this.InitializeComponent();
            this.AddSuperToolTip();
            this.CheckUpdates();
        }

        #endregion?Constructors?

        #region?Methods?(31)?

        //?Private?Methods?(31)?

        /// <summary>
        /// 
        /// </summary>
        private void AddSuperToolTip()
        {
            eTooltipColor color = eTooltipColor.Apple;
            this.superTooltip.SetSuperTooltip(this.btnNeedCheckCDA, new SuperTooltipInfo("需要放行的额度通知书", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnNeedCheckAssign, new SuperTooltipInfo("需要放行的转让批次", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnNeedCheckFinance, new SuperTooltipInfo("需要放行的融资批次", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnNeedCheckPayment, new SuperTooltipInfo("需要放行的付款批次", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnNeedCheckRefund, new SuperTooltipInfo("需要放行的还款批次", "", "", null, null, color));

            this.superTooltip.SetSuperTooltip(this.btnWaitCheckCDA, new SuperTooltipInfo("等待放行的额度通知书", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnWaitCheckAssign, new SuperTooltipInfo("等待放行的转让批次", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnWaitCheckFinance, new SuperTooltipInfo("等待放行的融资批次", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnWaitCheckPayment, new SuperTooltipInfo("等待放行的付款批次", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnWaitCheckRefund, new SuperTooltipInfo("等待放行的还款批次", "", "", null, null, color));

            this.superTooltip.SetSuperTooltip(this.btnRejectCheckCDA, new SuperTooltipInfo("拒绝放行的额度通知书", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnRejectCheckAssign, new SuperTooltipInfo("拒绝放行的转让批次", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnRejectCheckFinance, new SuperTooltipInfo("拒绝放行的融资批次", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnRejectCheckPayment, new SuperTooltipInfo("拒绝放行的付款批次", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnRejectCheckRefund, new SuperTooltipInfo("拒绝放行的还款批次", "", "", null, null, color));

            this.superTooltip.SetSuperTooltip(this.btnDueAssign7, new SuperTooltipInfo("7日内到期的应收账款", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnDueAssign0, new SuperTooltipInfo("今日到期的应收账款", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnDueAssign, new SuperTooltipInfo("已经逾期的应收账款", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnInvoiceDispute, new SuperTooltipInfo("商纠账款", "", "", null, null, color));

            this.superTooltip.SetSuperTooltip(this.btnDueFinance7, new SuperTooltipInfo("7日内到期的应收账款", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnDueFinance0, new SuperTooltipInfo("今日到期的应收账款", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnDueFinance, new SuperTooltipInfo("已经逾期的应收账款", "", "", null, null, color));

            this.superTooltip.SetSuperTooltip(this.btnDueClientCreditLine, new SuperTooltipInfo("客户额度到期", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnDueFactorCreditLine, new SuperTooltipInfo("保理商额度到期", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnDueCDA, new SuperTooltipInfo("额度通知书到期", "", "", null, null, color));
            this.superTooltip.SetSuperTooltip(this.btnDueContract, new SuperTooltipInfo("保理合同到期", "", "", null, null, color));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            DBDataContext context = new DBDataContext();
            int result = 0;

            //QueryNeedCheckCDA
            result = context.CDAs.Count(c => c.CDAStatus == CDAStr.UNCHECK);
            worker.ReportProgress(result, this.btnNeedCheckCDA);

            //QueryNeedCheckAssign
            result = context.InvoiceAssignBatches.Count(i => i.CheckStatus == BATCH.UNCHECK);
            worker.ReportProgress(result, this.btnNeedCheckAssign);

            //QueryNeedCheckFinance
            result = context.InvoiceFinanceBatches.Count(i => i.CheckStatus == BATCH.UNCHECK);
            worker.ReportProgress(result, this.btnNeedCheckFinance);

            //QueryNeedCheckPayment
            result = context.InvoicePaymentBatches.Count(i => i.CheckStatus == BATCH.UNCHECK);
            worker.ReportProgress(result, this.btnNeedCheckPayment);

            //QueryNeedCheckRefund
            result = context.InvoiceRefundBatches.Count(i => i.CheckStatus == BATCH.UNCHECK);
            worker.ReportProgress(result, this.btnNeedCheckRefund);

            //QueryWaitCheckCDA
            result = context.CDAs.Count(c => c.CDAStatus == CDAStr.UNCHECK && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, this.btnWaitCheckCDA);

            //QueryWaitCheckAssign
            result = context.InvoiceAssignBatches.Count(i => i.CheckStatus == BATCH.UNCHECK && i.CheckUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, this.btnWaitCheckAssign);

            //QueryWaitCheckFinance
            result = context.InvoiceFinanceBatches.Count(i => i.CheckStatus == BATCH.UNCHECK && i.CheckUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, this.btnWaitCheckFinance);

            //QueryWaitCheckPayment
            result = context.InvoicePaymentBatches.Count(i => i.CheckStatus == BATCH.UNCHECK && i.CheckUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, this.btnWaitCheckPayment);

            //QueryWaitCheckRefund
            result = context.InvoiceRefundBatches.Count(i => i.CheckStatus == BATCH.UNCHECK && i.CheckUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, this.btnWaitCheckRefund);

            //QueryRejectCheckCDA
            result = context.CDAs.Count(c => c.CDAStatus == CDAStr.REJECT && c.CreateUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, this.btnRejectCheckCDA);

            //QueryRejectCheckAssign
            result = context.InvoiceAssignBatches.Count(i => i.CheckStatus == BATCH.REJECT && i.CheckUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, this.btnRejectCheckAssign);

            //QueryRejectCheckFinance
            result = context.InvoiceFinanceBatches.Count(i => i.CheckStatus == BATCH.REJECT && i.CheckUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, this.btnRejectCheckFinance);

            //QueryRejectCheckPayment
            result = context.InvoicePaymentBatches.Count(i => i.CheckStatus == BATCH.REJECT && i.CheckUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, this.btnRejectCheckPayment);

            //QueryRejectCheckRefund
            result = context.InvoiceRefundBatches.Count(i => i.CheckStatus == BATCH.REJECT && i.CheckUserName == App.Current.CurUser.Name);
            worker.ReportProgress(result, this.btnRejectCheckRefund);

            //DueAssign7
            result = context.Invoices.Count(invoice => invoice.PaymentAmount.GetValueOrDefault() - invoice.AssignAmount < -TypeUtil.PRECISION && invoice.DueDate <= DateTime.Now.Date.AddDays(7) && invoice.DueDate >= DateTime.Now.Date);
            worker.ReportProgress(result, this.btnDueAssign7);

            //DueAssign0
            result = context.Invoices.Count(invoice => invoice.PaymentAmount.GetValueOrDefault() - invoice.AssignAmount < -TypeUtil.PRECISION && invoice.DueDate == DateTime.Now.Date);
            worker.ReportProgress(result, this.btnDueAssign0);

            //DueAssign
            result = context.Invoices.Count(invoice => invoice.PaymentAmount.GetValueOrDefault() - invoice.AssignAmount < -TypeUtil.PRECISION && invoice.DueDate < DateTime.Now.Date);
            worker.ReportProgress(result, this.btnDueAssign);

            //InvoiceDispute
            result = context.Invoices.Count(invoice => invoice.IsDispute == true);
            worker.ReportProgress(result, this.btnInvoiceDispute);

            //DueFinance7
            result = context.Invoices.Count(invoice => invoice.RefundAmount.GetValueOrDefault() - invoice.FinanceAmount.GetValueOrDefault() < -TypeUtil.PRECISION && invoice.FinanceDueDate <= DateTime.Now.Date.AddDays(7) && invoice.FinanceDueDate >= DateTime.Now.Date);
            worker.ReportProgress(result, this.btnDueFinance7);

            //DueFinance0
            result = context.Invoices.Count(invoice => invoice.RefundAmount.GetValueOrDefault() - invoice.FinanceAmount.GetValueOrDefault() < -TypeUtil.PRECISION && invoice.FinanceDueDate == DateTime.Now.Date);
            worker.ReportProgress(result, this.btnDueFinance0);

            //DueFinance
            result = context.Invoices.Count(invoice => invoice.RefundAmount.GetValueOrDefault() - invoice.FinanceAmount.GetValueOrDefault() < -TypeUtil.PRECISION && invoice.FinanceDueDate < DateTime.Now.Date);
            worker.ReportProgress(result, this.btnDueFinance);

            //DueClientCreditLine
            result = context.ClientCreditLines.Count(c => c.CreditLineStatus == CLIENT_CREDIT_LINE.AVAILABILITY && c.PeriodEnd < DateTime.Now.Date);
            worker.ReportProgress(result, this.btnDueClientCreditLine);

            //DueFactorCreditLine
            result = context.FactorCreditLines.Count(f => f.CreditLineStatus == FACTOR_CREDIT_LINE.AVAILABILITY && f.PeriodEnd < DateTime.Now.Date);
            worker.ReportProgress(result, this.btnDueFactorCreditLine);

            //DueCDA
            result = context.CDAs.Count(cda => cda.CDAStatus == CDAStr.CHECKED
                                       && (cda.CreditCoverPeriodEnd < DateTime.Now.Date || cda.FinanceLinePeriodEnd < DateTime.Now.Date));
            worker.ReportProgress(result, this.btnDueCDA);

            //DueContract
            result = context.Contracts.Count(c => c.ContractStatus == CONTRACT.AVAILABILITY && c.ContractDueDate < DateTime.Now.Date);
            worker.ReportProgress(result, this.btnDueContract);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            ButtonX button = (ButtonX)e.UserState;
            SuperTooltipInfo tipInfo = this.superTooltip.GetSuperTooltip(button);
            tipInfo.BodyText = String.Format("有{0}条记录需要处理", e.ProgressPercentage);
            button.Text = String.Format("{0} ({1})", button.Text, e.ProgressPercentage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckUpdates()
        {
            this.backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCDADue(object sender, EventArgs e)
        {
            CDAMgr mgr = new CDAMgr(CDAMgr.OpCDAType.DUE);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientCreditLineDue(object sender, EventArgs e)
        {
            ClientCreditLineMgr mgr = new ClientCreditLineMgr(ClientCreditLineMgr.OpClientCreditMgrType.DUE);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryContractDue(object sender, EventArgs e)
        {
            ContractMgr mgr = new ContractMgr(ContractMgr.OpContractType.DUE);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryFactorCreditLineDue(object sender, EventArgs e)
        {
            FactorCreditLineMgr mgr = new FactorCreditLineMgr(FactorCreditLineMgr.OpFactorCreditMgrType.DUE);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceAssignDue(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.ASSIGN_DUE);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceAssignDueBy0(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.ASSIGN_DUE_BYDAY, 0);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceAssignDueBy7(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.ASSIGN_DUE_BYDAY, -7);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceDispute(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.DISPUTE_RESOLVE);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceFinanceDue(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FINANCE_DUE);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceFinanceDueBy0(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FINANCE_DUE_BYDAY, 0);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceFinanceDueBy7(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FINANCE_DUE_BYDAY, -7);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedCheckAssigns(object sender, EventArgs e)
        {
            AssignBatchMgr mgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.CHECK);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedCheckCDAs(object sender, EventArgs e)
        {
            CDAMgr mgr = new CDAMgr(CDAMgr.OpCDAType.CHECK);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedCheckFinances(object sender, EventArgs e)
        {
            FinanceBatchMgr mgr = new FinanceBatchMgr(FinanceBatchMgr.OpBatchType.CHECK);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedCheckPayments(object sender, EventArgs e)
        {
            PaymentBatchMgr mgr = new PaymentBatchMgr(PaymentBatchMgr.OpBatchType.CHECK);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryNeedCheckRefunds(object sender, EventArgs e)
        {
            RefundBatchMgr mgr = new RefundBatchMgr(RefundBatchMgr.OpBatchType.CHECK);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckAssigns(object sender, EventArgs e)
        {
            AssignBatchMgr mgr = new AssignBatchMgr(App.Current.CurUser.Name, BATCH.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckCDAs(object sender, EventArgs e)
        {
            CDAMgr mgr = new CDAMgr(App.Current.CurUser.Name, CDAStr.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckFinances(object sender, EventArgs e)
        {
            FinanceBatchMgr mgr = new FinanceBatchMgr(App.Current.CurUser.Name, BATCH.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckPayments(object sender, EventArgs e)
        {
            PaymentBatchMgr mgr = new PaymentBatchMgr(App.Current.CurUser.Name, BATCH.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckRefunds(object sender, EventArgs e)
        {
            RefundBatchMgr mgr = new RefundBatchMgr(App.Current.CurUser.Name, BATCH.REJECT);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckAssigns(object sender, EventArgs e)
        {
            AssignBatchMgr mgr = new AssignBatchMgr(App.Current.CurUser.Name, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckCDAs(object sender, EventArgs e)
        {
            CDAMgr mgr = new CDAMgr(App.Current.CurUser.Name, CDAStr.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckFinances(object sender, EventArgs e)
        {
            FinanceBatchMgr mgr = new FinanceBatchMgr(App.Current.CurUser.Name, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckPayments(object sender, EventArgs e)
        {
            PaymentBatchMgr mgr = new PaymentBatchMgr(App.Current.CurUser.Name, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckRefunds(object sender, EventArgs e)
        {
            RefundBatchMgr mgr = new RefundBatchMgr(App.Current.CurUser.Name, BATCH.UNCHECK);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        #endregion?Methods?
    }
}

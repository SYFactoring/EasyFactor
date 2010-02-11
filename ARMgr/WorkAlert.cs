
namespace CMBC.EasyFactor.ARMgr
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;

    /// <summary>
    /// 
    /// </summary>
    public partial class WorkAlert : UserControl
    {
        #region Constructors (1)

        public WorkAlert()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods (26)

        // Private Methods (26) 

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
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.OVER_DUE);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceAssignDueBy0(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.ASSIGN_DUE, 0);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceAssignDueBy7(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.ASSIGN_DUE, -7);
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
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.OVER_DUE);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceFinanceDueBy0(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FINANCE_DUE, 0);
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoiceFinanceDueBy7(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FINANCE_DUE, -7);
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
            AssignBatchMgr mgr = new AssignBatchMgr(App.Current.CurUser.Name, "复核未通过");
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckCDAs(object sender, EventArgs e)
        {
            CDAMgr mgr = new CDAMgr(App.Current.CurUser.Name, "审核未通过");
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckFinances(object sender, EventArgs e)
        {
            FinanceBatchMgr mgr = new FinanceBatchMgr(App.Current.CurUser.Name, "复核未通过");
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckPayments(object sender, EventArgs e)
        {
            PaymentBatchMgr mgr = new PaymentBatchMgr(App.Current.CurUser.Name, "复核未通过");
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRejectCheckRefunds(object sender, EventArgs e)
        {
            RefundBatchMgr mgr = new RefundBatchMgr(App.Current.CurUser.Name, "复核未通过");
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckAssigns(object sender, EventArgs e)
        {
            AssignBatchMgr mgr = new AssignBatchMgr(App.Current.CurUser.Name, "未复核");
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckCDAs(object sender, EventArgs e)
        {
            CDAMgr mgr = new CDAMgr(App.Current.CurUser.Name, "未审核");
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckFinances(object sender, EventArgs e)
        {
            FinanceBatchMgr mgr = new FinanceBatchMgr(App.Current.CurUser.Name, "未复核");
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckPayments(object sender, EventArgs e)
        {
            PaymentBatchMgr mgr = new PaymentBatchMgr(App.Current.CurUser.Name, "未复核");
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryWaitCheckRefunds(object sender, EventArgs e)
        {
            RefundBatchMgr mgr = new RefundBatchMgr(App.Current.CurUser.Name, "未复核");
            App.Current.MainWindow.SetDetailPanel(mgr);
        }

        #endregion Methods
    }
}

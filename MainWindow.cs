//-----------------------------------------------------------------------
// <copyright file="MainWindow.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using System;
    using System.Windows.Forms;
    using CMBC.EasyFactor.ARMgr;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.Help.About;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.DepartmentMgr;
    using CMBC.EasyFactor.InfoMgr.ExchangeMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.InfoMgr.UserMgr;
    using CMBC.EasyFactor.Report;
    using CMBC.EasyFactor.Utils;

    /// <summary>
    /// Main Window Form
    /// </summary>
    public partial class MainWindow : DevComponents.DotNetBar.Office2007RibbonForm
    {
        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the MainWindow class
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            this.ImeMode = ImeMode.OnHalf;

            this.ribbonControl.SelectedRibbonTabItem = this.itemInfoMgr;
            this.UserStatus = App.Current.CurUser.Name + "\t " + App.Current.CurUser.Role;
            this.CommandStatus = "欢迎使用中国民生银行保理运营系统";
        }

        #endregion Constructors

        #region Properties (2)

        /// <summary>
        /// Sets command status
        /// </summary>
        public string CommandStatus
        {
            set
            {
                this.lblCommandStatus.Text = value;
            }
        }

        /// <summary>
        /// Sets user status
        /// </summary>
        public string UserStatus
        {
            set
            {
                this.lblCurrentUser.Text = value;
            }
        }

        #endregion Properties

        #region Methods (57)

        // Private Methods (57) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void About(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ARPaymentReport(object sender, EventArgs e)
        {
            AssignReportMgr assignMgr = new AssignReportMgr(AssignReportMgr.OpReportType.REPORT_ASSIGN);
            this.SetDetailPanel(assignMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeStyle(object sender, EventArgs e)
        {
            string style = this.cbStyleManager.Text;
            if ("Office2007Blue".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            }
            else if ("Office2007Silver".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver;
            }
            else if ("Office2007Black".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black;
            }
            else if ("Office2007VistaGlass".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            }
            else if ("Office2010Silver".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver;
            }
            else if ("Windows7Blue".Equals(style))
            {
                this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Windows7Blue;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckAssignBatch(object sender, EventArgs e)
        {
            AssignBatchMgr batchMgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.CHECK);
            this.SetDetailPanel(batchMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckCDA(object sender, EventArgs e)
        {
            CDAMgr cdaMgr = new CDAMgr(CDAMgr.OpCDAType.CHECK);
            this.SetDetailPanel(cdaMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckFinanceBatch(object sender, EventArgs e)
        {
            FinanceBatchMgr batchMgr = new FinanceBatchMgr(FinanceBatchMgr.OpBatchType.CHECK);
            this.SetDetailPanel(batchMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckPaymentBatch(object sender, EventArgs e)
        {
            PaymentBatchMgr batchMgr = new PaymentBatchMgr(PaymentBatchMgr.OpBatchType.CHECK);
            this.SetDetailPanel(batchMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckRefundBatch(object sender, EventArgs e)
        {
            RefundBatchMgr batchMgr = new RefundBatchMgr(RefundBatchMgr.OpBatchType.CHECK);
            this.SetDetailPanel(batchMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        private void ClearDetailPanel()
        {
            this.ribbonDetailPanel.Controls.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreditNotePayment(object sender, EventArgs e)
        {
            ARCaseBasic creditNotePayment = new ARCaseBasic(ARCaseBasic.OpARType.CreditNotePayment);
            this.SetDetailPanel(creditNotePayment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisputeResolve(object sender, EventArgs e)
        {
            InvoiceMgr invoiceMgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.DISPUTE_RESOLVE);
            this.SetDetailPanel(invoiceMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FactorQuery(object sender, EventArgs e)
        {
            FactorMgr fatcorQuery = new FactorMgr(false);
            this.SetDetailPanel(fatcorQuery);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FeeReport(object sender, EventArgs e)
        {
            AssignReportMgr reportMgr = new AssignReportMgr(AssignReportMgr.OpReportType.REPORT_FEE);
            this.SetDetailPanel(reportMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinanceReport(object sender, EventArgs e)
        {
            AssignReportMgr assignMgr = new AssignReportMgr(AssignReportMgr.OpReportType.REPORT_FINANCE);
            this.SetDetailPanel(assignMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlawResolve(object sender, EventArgs e)
        {
            InvoiceMgr invoiceMgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FLAW_RESOLVE);
            this.SetDetailPanel(invoiceMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportCases(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CASES);
            importForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportClientCreditLine(object sender, EventArgs e)
        {
            if (this.ValidateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CLIENTS_CREDITLINE);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportClients(object sender, EventArgs e)
        {
            if (this.ValidateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CLIENTS);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportContractAndCDA(object sender, EventArgs e)
        {
            if (this.ValidateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CONTRACT_CDA);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportDepartments(object sender, EventArgs e)
        {
            if (this.ValidateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_DEPARTMENTS);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFactorCreditLine(object sender, EventArgs e)
        {
            if (this.ValidateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_FACTORS_CREDITLINE);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportFactors(object sender, EventArgs e)
        {
            if (this.ValidateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_FACTORS);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportInvoices(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_INVOICES);
            importForm.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportUsers(object sender, EventArgs e)
        {
            if (this.ValidateRole())
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_USERS);
                importForm.Show();
            }
        }

        /// <summary>
        /// Invoice Assign
        /// </summary>
        /// <param name="sender">event sender</param>
        /// <param name="e">event args</param>
        private void InvoiceAssign(object sender, EventArgs e)
        {
            ARCaseBasic invoiceAssign = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceAssign);
            this.SetDetailPanel(invoiceAssign);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceBuyerPayment(object sender, EventArgs e)
        {
            ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceBuyerPayment);
            this.SetDetailPanel(invoicePayment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceFinance(object sender, EventArgs e)
        {
            ARCaseBasic invoiceFinance = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceFinance);
            this.SetDetailPanel(invoiceFinance);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceGuaranteePayment(object sender, EventArgs e)
        {
            ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceGuaranteePayment);
            this.SetDetailPanel(invoicePayment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceIndirectPayment(object sender, EventArgs e)
        {
            ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceIndirectPayment);
            this.SetDetailPanel(invoicePayment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceSellerReassign(object sender, EventArgs e)
        {
            ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceSellerReassign);
            this.SetDetailPanel(invoicePayment);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceSellerRefund(object sender, EventArgs e)
        {
            ARCaseBasic invoiceRefund = new ARCaseBasic(ARCaseBasic.OpARType.InvoiceSellerRefund);
            this.SetDetailPanel(invoiceRefund);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPage(object sender, EventArgs e)
        {
            this.ClearDetailPanel();
            this.ribbonControl.SelectedRibbonTabItem = this.itemInfoMgr;
            this.ribbonDetailPanel.Controls.Add(this.logoLabel);
        }

        /// <summary>
        /// Client Management
        /// </summary>
        /// <param name="sender">event sender</param>
        /// <param name="e">event args</param>
        private void MgrClients(object sender, EventArgs e)
        {
            ClientMgr clientMgrUI = new ClientMgr(true);
            this.SetDetailPanel(clientMgrUI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MgrDepartments(object sender, EventArgs e)
        {
            DepartmentMgr departmentMgrUI = new DepartmentMgr(true);
            this.SetDetailPanel(departmentMgrUI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MgrFactors(object sender, EventArgs e)
        {
            FactorMgr factorMgrUI = new FactorMgr(true);
            this.SetDetailPanel(factorMgrUI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MgrUsers(object sender, EventArgs e)
        {
            if (this.ValidateRole())
            {
                UserMgr userMgrUI = new UserMgr(true);
                this.SetDetailPanel(userMgrUI);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCase(object sender, EventArgs e)
        {
            this.ClearDetailPanel();
            CaseDetail caseDetail = new CaseDetail(null, CaseDetail.OpCaseType.NEW_CASE);
            caseDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCDA(object sender, EventArgs e)
        {
            CDADetail cdaDetail = new CDADetail(CDADetail.OpCDAType.NEW_CDA);
            cdaDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClient(object sender, EventArgs e)
        {
            ClientDetail clientDetail = new ClientDetail(null, ClientDetail.OpClientType.NEW_CLIENT);
            clientDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFactor(object sender, EventArgs e)
        {
            FactorDetail factorDetail = new FactorDetail(null, FactorDetail.OpFactorType.NEW_FACTOR);
            factorDetail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCase(object sender, EventArgs e)
        {
            CaseMgr.CaseMgr caseQuery = new CaseMgr.CaseMgr(true);
            this.SetDetailPanel(caseQuery);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCDA(object sender, EventArgs e)
        {
            CDAMgr mgr = new CDAMgr(CDAMgr.OpCDAType.QUERY);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientCreditLine(object sender, EventArgs e)
        {
            ClientCreditLineMgr query = new ClientCreditLineMgr(ClientCreditLineMgr.OpClientCreditMgrType.QUERY_CLINET);
            this.SetDetailPanel(query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientDominate(object sender, EventArgs e)
        {
            ClientMgr query = new ClientMgr(ClientMgr.OpClientMgrType.DOMINATE_CLIENT);
            this.SetDetailPanel(query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientExport(object sender, EventArgs e)
        {
            ClientMgr query = new ClientMgr(ClientMgr.OpClientMgrType.EXPORT_CLIENT);
            this.SetDetailPanel(query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientGroupCreditLine(object sender, EventArgs e)
        {
            ClientCreditLineMgr query = new ClientCreditLineMgr(ClientCreditLineMgr.OpClientCreditMgrType.QUERY_GROUP);
            this.SetDetailPanel(query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClientImport(object sender, EventArgs e)
        {
            ClientMgr query = new ClientMgr(ClientMgr.OpClientMgrType.IMPORT_CLIENT);
            this.SetDetailPanel(query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClients(object sender, EventArgs e)
        {
            ClientMgr query = new ClientMgr(false);
            this.SetDetailPanel(query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryContract(object sender, EventArgs e)
        {
            ContractMgr contractMgr = new ContractMgr(true);
            this.SetDetailPanel(contractMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCreditCoverNegs(object sender, EventArgs e)
        {
            CreditCoverNegMgr creditCoverNegMgr = new CreditCoverNegMgr(true);
            this.SetDetailPanel(creditCoverNegMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryExchange(object sender, EventArgs e)
        {
            ExchangeMgr mgr = new ExchangeMgr();
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryFactorCreditLine(object sender, EventArgs e)
        {
            FactorCreditLineMgr query = new FactorCreditLineMgr();
            this.SetDetailPanel(query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryInvoice(object sender, EventArgs e)
        {
            InvoiceMgr invoiceMgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.INVOICE_QUERY);
            this.SetDetailPanel(invoiceMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryOverDue(object sender, EventArgs e)
        {
            InvoiceMgr mgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.OVER_DUE);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// Fill detail panel with user control
        /// </summary>
        /// <param name="uc">user control</param>
        private void SetDetailPanel(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            this.ribbonDetailPanel.Controls.Clear();
            this.ribbonDetailPanel.Controls.Add(uc);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool ValidateRole()
        {
            if (App.Current.CurUser.Role == "管理员")
            {
                return true;
            }
            else
            {
                MessageBox.Show("只有管理员可以执行此操作", ConstStr.MESSAGE.TITLE_INFORMATION, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        #endregion Methods
    }
}
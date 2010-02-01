﻿//-----------------------------------------------------------------------
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

            this.Text = ((AssemblyTitleAttribute)Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0]).Title + "  " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
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

        #region Methods (65)

        // Public Methods (2) 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="refundList"></param>
        public void InvoiceRefund(List<Invoice> refundList, string paymentType)
        {
            if (PermUtil.CheckPermission(Permission.INVOICE_UPDATE))
            {
                ARCaseBasic invoiceRefund = new ARCaseBasic(ARCaseBasic.OpARType.SELLER_REFUND);
                this.SetDetailPanel(invoiceRefund);
                InvoiceRefund uc = (InvoiceRefund)invoiceRefund.InvoiceControl;
                uc.NewBatch(refundList, paymentType);
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
        // Private Methods (63) 

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
            this.ribbonDetailPanel.Controls.Clear();
            this.ribbonControl.SelectedRibbonTabItem = this.itemInfoMgr;
            this.ribbonDetailPanel.Controls.Add(this.logoLabel);
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
            AssignReportMgr assignMgr = new AssignReportMgr(AssignReportMgr.OpReportType.REPORT_FINANCE);
            this.SetDetailPanel(assignMgr);
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
        private void ComputeCommission(object sender, EventArgs e)
        {
            if (PermUtil.CheckPermission(Permission.SYSTEM_UPDATE))
            {
                InvoiceUtil.ComputeCommission();
            }
        }
    }
}
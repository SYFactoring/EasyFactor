//-----------------------------------------------------------------------
// <copyright file="MainWindow.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor
{
    /// <summary>
    /// Main Window Designer
    /// </summary>
    public partial class MainWindow
    {
		#region?Fields?(174)?

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private DevComponents.DotNetBar.ButtonItem btnApplicationCaseQuery;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.ButtonItem btnARAssignReport;
        private DevComponents.DotNetBar.ButtonItem btnAssignBatchQuery;
        private DevComponents.DotNetBar.ButtonItem btnAssignCheck;
        private DevComponents.DotNetBar.ButtonItem btnAssignImport;
        private DevComponents.DotNetBar.ButtonItem btnBugReport;
        private DevComponents.DotNetBar.ButtonItem btnBuyerPayment;
        private DevComponents.DotNetBar.ButtonItem btnCaseImport;
        private DevComponents.DotNetBar.ButtonItem btnCaseNew;
        private DevComponents.DotNetBar.ButtonItem btnCaseQuery;
        private DevComponents.DotNetBar.ButtonItem btnCaseStat;
        private DevComponents.DotNetBar.ButtonItem btnCDACheck;
        private DevComponents.DotNetBar.ButtonItem btnCDAImport;
        private DevComponents.DotNetBar.ButtonItem btnCDANew;
        private DevComponents.DotNetBar.ButtonItem btnCDAQuery;
        private DevComponents.DotNetBar.ButtonItem btnCDAQuery1;
        private DevComponents.DotNetBar.ButtonItem btnCDAReport;
        private DevComponents.DotNetBar.ButtonItem btnCheckUpdate;
        private DevComponents.DotNetBar.ButtonItem btnClientCreditLineImport;
        private DevComponents.DotNetBar.ButtonItem btnClientImport;
        private DevComponents.DotNetBar.ButtonItem btnClientMgr;
        private DevComponents.DotNetBar.ButtonItem btnClientNew;
        private DevComponents.DotNetBar.ButtonItem btnClientOverwriteImport;
        private DevComponents.DotNetBar.ButtonItem btnClientQuery;
        private DevComponents.DotNetBar.ButtonItem btnClientReviewImport;
        private DevComponents.DotNetBar.ButtonItem btnClientReviewQuery;
        private DevComponents.DotNetBar.ButtonItem btnClinetCreditLineQuery;
        private DevComponents.DotNetBar.ButtonItem btnContractImport;
        private DevComponents.DotNetBar.ButtonItem btnContractQuery;
        private DevComponents.DotNetBar.ButtonItem btnCreditCoverNegImport;
        private DevComponents.DotNetBar.ButtonItem btnCreditCoverNegQuery;
        private DevComponents.DotNetBar.ButtonItem btnCreditCoverNegQuery2;
        private DevComponents.DotNetBar.ButtonItem btnCreditNoteImport;
        private DevComponents.DotNetBar.ButtonItem btnCreditNotePayment;
        private DevComponents.DotNetBar.ButtonItem btnDepartmentImport;
        private DevComponents.DotNetBar.ButtonItem btnDepartmentStat;
        private DevComponents.DotNetBar.ButtonItem btnDepartMgr;
        private DevComponents.DotNetBar.ButtonItem btnDeptQuery;
        private DevComponents.DotNetBar.ButtonItem btnDispute;
        private DevComponents.DotNetBar.ButtonItem btnExchangeQuery;
        private DevComponents.DotNetBar.ButtonItem btnExchangeRateImport;
        private DevComponents.DotNetBar.ButtonItem btnFactorCreditLine;
        private DevComponents.DotNetBar.ButtonItem btnFactorCreditLineImport;
        private DevComponents.DotNetBar.ButtonItem btnFactorImport;
        private DevComponents.DotNetBar.ButtonItem btnFactorImport2;
        private DevComponents.DotNetBar.ButtonItem btnFactorMgr;
        private DevComponents.DotNetBar.ButtonItem btnFactorNew;
        private DevComponents.DotNetBar.ButtonItem btnFactorsQuery;
        private DevComponents.DotNetBar.ButtonItem btnFeeReport;
        private DevComponents.DotNetBar.ButtonItem btnFinanceBatchQuery;
        private DevComponents.DotNetBar.ButtonItem btnFinanceCheck;
        private DevComponents.DotNetBar.ButtonItem btnFinanceImport;
        private DevComponents.DotNetBar.ButtonItem btnFinanceReport;
        private DevComponents.DotNetBar.ButtonItem btnFlawReport;
        private DevComponents.DotNetBar.ButtonItem btnGroupCreditLineQuery;
        private DevComponents.DotNetBar.ButtonItem btnGuaranteePayment;
        private DevComponents.DotNetBar.ButtonItem btnHelp;
        private DevComponents.DotNetBar.ButtonItem btnIndirectPayment;
        private DevComponents.DotNetBar.ButtonItem btnInvoiceAssign;
        private DevComponents.DotNetBar.ButtonItem btnInvoiceFinance;
        private DevComponents.DotNetBar.ButtonItem btnInvoiceQuery;
        private DevComponents.DotNetBar.ButtonItem btnInvoicesImport;
        private DevComponents.DotNetBar.ButtonItem btnLeger;
        private DevComponents.DotNetBar.ButtonItem btnLocationStat;
        private DevComponents.DotNetBar.ButtonItem btnMainPage;
        private DevComponents.DotNetBar.ButtonItem btnOverDueQuery;
        private DevComponents.DotNetBar.ButtonItem btnPaymentBatchQuery;
        private DevComponents.DotNetBar.ButtonItem btnPaymentCheck;
        private DevComponents.DotNetBar.ButtonItem btnPaymentImport;
        private DevComponents.DotNetBar.ButtonItem btnPoolFinance;
        private DevComponents.DotNetBar.ButtonItem btnPoolFinanceBatchQuery;
        private DevComponents.DotNetBar.ButtonItem btnPoolFinanceCheck;
        private DevComponents.DotNetBar.ButtonItem btnPoolFinanceImport;
        private DevComponents.DotNetBar.ButtonItem btnPoolRefund;
        private DevComponents.DotNetBar.ButtonItem btnPoolRefundCheck;
        private DevComponents.DotNetBar.ButtonItem btnPoolRefundImport;
        private DevComponents.DotNetBar.ButtonItem btnPoolRefundQuery;
        private DevComponents.DotNetBar.ButtonItem btnQueryClientDominate;
        private DevComponents.DotNetBar.ButtonItem btnQueryClientExport;
        private DevComponents.DotNetBar.ButtonItem btnQueryClientImport;
        private DevComponents.DotNetBar.ButtonItem btnReassignment;
        private DevComponents.DotNetBar.ButtonItem btnRefundBatchQuery;
        private DevComponents.DotNetBar.ButtonItem btnRefundCheck;
        private DevComponents.DotNetBar.ButtonItem btnRefundImport;
        private DevComponents.DotNetBar.ButtonItem btnUserImport;
        private DevComponents.DotNetBar.ButtonItem btnUserMgr;
        private DevComponents.DotNetBar.ButtonItem btnUserUpdate;
        private DevComponents.DotNetBar.ComboBoxItem cbStyleManager;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.RibbonTabItem itemAccountsReceivableMgr;
        private DevComponents.DotNetBar.ItemContainer itemContainerClientQuery;
        private DevComponents.DotNetBar.RibbonTabItem itemHelp;
        private DevComponents.DotNetBar.RibbonTabItem itemInfoMgr;
        private DevComponents.DotNetBar.RibbonTabItem itemQuery;
        private DevComponents.DotNetBar.RibbonTabItem itemReport;
        private DevComponents.DotNetBar.LabelItem lblCommandStatus;
        private DevComponents.DotNetBar.LabelItem lblCurrentUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemCheckAlert;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemHide;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem;
        private DevComponents.DotNetBar.RibbonBar ribbonBarAnalysisReport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarARImport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarAssign;
        private DevComponents.DotNetBar.RibbonBar ribbonBarBasicInfoImport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarBatchQuery;
        private DevComponents.DotNetBar.RibbonBar ribbonBarCase;
        private DevComponents.DotNetBar.RibbonBar ribbonBarCaseImport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarCaseQuery;
        private DevComponents.DotNetBar.RibbonBar ribbonBarCDA;
        private DevComponents.DotNetBar.RibbonBar ribbonBarClient;
        private DevComponents.DotNetBar.RibbonBar ribbonBarClientQuery;
        private DevComponents.DotNetBar.RibbonBar ribbonBarCreditLineImport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarCreditLineQuery;
        private DevComponents.DotNetBar.RibbonBar ribbonBarDepartment;
        private DevComponents.DotNetBar.RibbonBar ribbonBarDispute;
        private DevComponents.DotNetBar.RibbonBar ribbonBarExchange;
        private DevComponents.DotNetBar.RibbonBar ribbonBarFactor;
        private DevComponents.DotNetBar.RibbonBar ribbonBarFinance;
        private DevComponents.DotNetBar.RibbonBar ribbonBarHelp;
        private DevComponents.DotNetBar.RibbonBar ribbonBarInvoiceCheck;
        private DevComponents.DotNetBar.RibbonBar ribbonBarInvoiceImport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarPayment;
        private DevComponents.DotNetBar.RibbonBar ribbonBarPool;
        private DevComponents.DotNetBar.RibbonBar ribbonBarPoolCheck;
        private DevComponents.DotNetBar.RibbonBar ribbonBarPoolIMport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarPoolQuery;
        private DevComponents.DotNetBar.RibbonBar ribbonBarSystem;
        private DevComponents.DotNetBar.RibbonBar ribbonBarTransactionReport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarUserMgr;
        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonDetailPanel;
        private DevComponents.DotNetBar.RibbonTabItem ribbonItemARImport;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelARImport;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelHelp;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelInfoMgr;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelInvoiceMgr;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelMigration;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelQuery;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelReport;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItemCaseMgr;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItemCheck;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItemSystem;
        private DevComponents.DotNetBar.Bar statusbar;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.RibbonTabItem tabItemMigration;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		#endregion?Fields?

		#region?Methods?(1)?

		//?Protected?Methods?(1)?

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

		#endregion?Methods?



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarPoolCheck = new DevComponents.DotNetBar.RibbonBar();
            this.btnPoolFinanceCheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnPoolRefundCheck = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarInvoiceCheck = new DevComponents.DotNetBar.RibbonBar();
            this.btnCDACheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnAssignCheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnFinanceCheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnPaymentCheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefundCheck = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelARImport = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarPoolIMport = new DevComponents.DotNetBar.RibbonBar();
            this.btnPoolFinanceImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnPoolRefundImport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarARImport = new DevComponents.DotNetBar.RibbonBar();
            this.btnAssignImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnAssignImportNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnFinanceImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnPaymentImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreditNoteImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefundImport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarUserMgr = new DevComponents.DotNetBar.RibbonBar();
            this.btnUserMgr = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarSystem = new DevComponents.DotNetBar.RibbonBar();
            this.btnUserImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnDepartmentImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnExchangeRateImport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelMigration = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarInvoiceImport = new DevComponents.DotNetBar.RibbonBar();
            this.btnInvoicesImport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarCreditLineImport = new DevComponents.DotNetBar.RibbonBar();
            this.btnClientCreditLineImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorCreditLineImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnCDAImport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarCaseImport = new DevComponents.DotNetBar.RibbonBar();
            this.btnCaseImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreditCoverNegImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnContractImport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarBasicInfoImport = new DevComponents.DotNetBar.RibbonBar();
            this.btnClientImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnClientOverwriteImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnClientReviewImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorImport2 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelReport = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarAnalysisReport = new DevComponents.DotNetBar.RibbonBar();
            this.btnCaseStat = new DevComponents.DotNetBar.ButtonItem();
            this.btnDepartmentStat = new DevComponents.DotNetBar.ButtonItem();
            this.btnLocationStat = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorCommissionStat = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarTransactionReport = new DevComponents.DotNetBar.RibbonBar();
            this.btnARAssignReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFinanceReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFeeReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFlawReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnCDAReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnLeger = new DevComponents.DotNetBar.ButtonItem();
            this.btnSendLeger = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelQuery = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarPoolQuery = new DevComponents.DotNetBar.RibbonBar();
            this.btnPoolFinanceBatchQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnPoolRefundQuery = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarBatchQuery = new DevComponents.DotNetBar.RibbonBar();
            this.btnAssignBatchQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnFinanceBatchQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnPaymentBatchQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefundBatchQuery = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarCaseQuery = new DevComponents.DotNetBar.RibbonBar();
            this.btnContractQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnCaseQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreditCoverNegQuery2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnInvoiceQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnOverDueQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreditNoteQuery = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarCreditLineQuery = new DevComponents.DotNetBar.RibbonBar();
            this.btnClinetCreditLineQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnGroupCreditLineQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorCreditLine = new DevComponents.DotNetBar.ButtonItem();
            this.btnCDAQuery = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarClientQuery = new DevComponents.DotNetBar.RibbonBar();
            this.btnClientQuery = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainerClientQuery = new DevComponents.DotNetBar.ItemContainer();
            this.btnQueryClientExport = new DevComponents.DotNetBar.ButtonItem();
            this.btnQueryClientImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnQueryClientDominate = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorsQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnDeptQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnClientReviewQuery = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelInfoMgr = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarExchange = new DevComponents.DotNetBar.RibbonBar();
            this.btnExchangeQuery = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarDepartment = new DevComponents.DotNetBar.RibbonBar();
            this.btnDepartMgr = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarFactor = new DevComponents.DotNetBar.RibbonBar();
            this.btnFactorMgr = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorNew = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarClient = new DevComponents.DotNetBar.RibbonBar();
            this.btnClientMgr = new DevComponents.DotNetBar.ButtonItem();
            this.btnClientNew = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelInvoiceMgr = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarDispute = new DevComponents.DotNetBar.RibbonBar();
            this.btnFlawResolve = new DevComponents.DotNetBar.ButtonItem();
            this.btnDispute = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarPool = new DevComponents.DotNetBar.RibbonBar();
            this.btnPoolFinance = new DevComponents.DotNetBar.ButtonItem();
            this.btnPoolRefund = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarRefund = new DevComponents.DotNetBar.RibbonBar();
            this.btnBuyerRefund = new DevComponents.DotNetBar.ButtonItem();
            this.btnSellerRefund = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarPayment = new DevComponents.DotNetBar.RibbonBar();
            this.btnBuyerPayment = new DevComponents.DotNetBar.ButtonItem();
            this.btnIndirectPayment = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuaranteePayment = new DevComponents.DotNetBar.ButtonItem();
            this.btnReassignment = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreditNotePayment = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarFinance = new DevComponents.DotNetBar.RibbonBar();
            this.btnInvoiceFinance = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarAssign = new DevComponents.DotNetBar.RibbonBar();
            this.btnInvoiceAssign = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarCDA = new DevComponents.DotNetBar.RibbonBar();
            this.btnCDANew = new DevComponents.DotNetBar.ButtonItem();
            this.btnCDAQuery1 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarCase = new DevComponents.DotNetBar.RibbonBar();
            this.btnCaseNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnApplicationCaseQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreditCoverNegQuery = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelHelp = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarHelp = new DevComponents.DotNetBar.RibbonBar();
            this.btnUserUpdate = new DevComponents.DotNetBar.ButtonItem();
            this.btnCheckUpdate = new DevComponents.DotNetBar.ButtonItem();
            this.btnBugReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelp = new DevComponents.DotNetBar.ButtonItem();
            this.itemInfoMgr = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemCaseMgr = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemAccountsReceivableMgr = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonItemARImport = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemCheck = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemQuery = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemReport = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabItemMigration = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemSystem = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemHelp = new DevComponents.DotNetBar.RibbonTabItem();
            this.menuLogo = new DevComponents.DotNetBar.LabelItem();
            this.office2007StartButton = new DevComponents.DotNetBar.Office2007StartButton();
            this.cbStyleManager = new DevComponents.DotNetBar.ComboBoxItem();
            this.btnMainPage = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager = new DevComponents.DotNetBar.StyleManager();
            this.statusbar = new DevComponents.DotNetBar.Bar();
            this.lblCommandStatus = new DevComponents.DotNetBar.LabelItem();
            this.lblCurrentUser = new DevComponents.DotNetBar.LabelItem();
            this.ribbonDetailPanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCheckAlert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.ribbonControl.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanelARImport.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanelMigration.SuspendLayout();
            this.ribbonPanelReport.SuspendLayout();
            this.ribbonPanelQuery.SuspendLayout();
            this.ribbonPanelInfoMgr.SuspendLayout();
            this.ribbonPanelInvoiceMgr.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanelHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusbar)).BeginInit();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            // 
            // 
            // 
            this.ribbonControl.BackgroundStyle.Class = "";
            this.ribbonControl.CaptionVisible = true;
            this.ribbonControl.Controls.Add(this.ribbonPanelInfoMgr);
            this.ribbonControl.Controls.Add(this.ribbonPanel2);
            this.ribbonControl.Controls.Add(this.ribbonPanelARImport);
            this.ribbonControl.Controls.Add(this.ribbonPanel3);
            this.ribbonControl.Controls.Add(this.ribbonPanelMigration);
            this.ribbonControl.Controls.Add(this.ribbonPanelReport);
            this.ribbonControl.Controls.Add(this.ribbonPanelQuery);
            this.ribbonControl.Controls.Add(this.ribbonPanelInvoiceMgr);
            this.ribbonControl.Controls.Add(this.ribbonPanel1);
            this.ribbonControl.Controls.Add(this.ribbonPanelHelp);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemInfoMgr,
            this.ribbonTabItemCaseMgr,
            this.itemAccountsReceivableMgr,
            this.ribbonItemARImport,
            this.ribbonTabItemCheck,
            this.itemQuery,
            this.itemReport,
            this.tabItemMigration,
            this.ribbonTabItemSystem,
            this.itemHelp,
            this.menuLogo});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton,
            this.cbStyleManager,
            this.btnMainPage,
            this.qatCustomizeItem});
            this.ribbonControl.Size = new System.Drawing.Size(1082, 154);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl.SystemText.MaximizeRibbonText = "�˵����";
            this.ribbonControl.SystemText.MinimizeRibbonText = "�˵���С��";
            this.ribbonControl.SystemText.QatCustomizeMenuLabel = "���ÿ�ݹ�����";
            this.ribbonControl.SystemText.QatCustomizeText = "���ÿ�ݹ�����...";
            this.ribbonControl.SystemText.QatDialogCaption = "���ÿ�ݹ�����";
            this.ribbonControl.SystemText.QatDialogPlacementCheckbox = "����ݹ��������ڲ˵�֮��";
            this.ribbonControl.SystemText.QatPlaceAboveRibbonText = "����ݹ��������ڲ˵�֮��";
            this.ribbonControl.SystemText.QatPlaceBelowRibbonText = "����ݹ��������ڲ˵�֮��";
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabIndex = 0;
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBarPoolCheck);
            this.ribbonPanel2.Controls.Add(this.ribbonBarInvoiceCheck);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1082, 93);
            // 
            // 
            // 
            this.ribbonPanel2.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanel2.StyleMouseOver.Class = "";
            this.ribbonPanel2.TabIndex = 10;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBarPoolCheck
            // 
            this.ribbonBarPoolCheck.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarPoolCheck.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarPoolCheck.BackgroundStyle.Class = "";
            this.ribbonBarPoolCheck.ContainerControlProcessDialogKey = true;
            this.ribbonBarPoolCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarPoolCheck.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPoolFinanceCheck,
            this.btnPoolRefundCheck});
            this.ribbonBarPoolCheck.Location = new System.Drawing.Point(363, 0);
            this.ribbonBarPoolCheck.Name = "ribbonBarPoolCheck";
            this.ribbonBarPoolCheck.Size = new System.Drawing.Size(154, 90);
            this.ribbonBarPoolCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarPoolCheck.TabIndex = 1;
            this.ribbonBarPoolCheck.Text = "�ظ���";
            // 
            // 
            // 
            this.ribbonBarPoolCheck.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarPoolCheck.TitleStyleMouseOver.Class = "";
            // 
            // btnPoolFinanceCheck
            // 
            this.btnPoolFinanceCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnPoolFinanceCheck.Image")));
            this.btnPoolFinanceCheck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPoolFinanceCheck.Name = "btnPoolFinanceCheck";
            this.btnPoolFinanceCheck.SubItemsExpandWidth = 14;
            this.btnPoolFinanceCheck.Text = "�����ʸ���";
            // 
            // btnPoolRefundCheck
            // 
            this.btnPoolRefundCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnPoolRefundCheck.Image")));
            this.btnPoolRefundCheck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPoolRefundCheck.Name = "btnPoolRefundCheck";
            this.btnPoolRefundCheck.SubItemsExpandWidth = 14;
            this.btnPoolRefundCheck.Text = "�ػ����";
            // 
            // ribbonBarInvoiceCheck
            // 
            this.ribbonBarInvoiceCheck.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarInvoiceCheck.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarInvoiceCheck.BackgroundStyle.Class = "";
            this.ribbonBarInvoiceCheck.ContainerControlProcessDialogKey = true;
            this.ribbonBarInvoiceCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarInvoiceCheck.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCDACheck,
            this.btnAssignCheck,
            this.btnFinanceCheck,
            this.btnPaymentCheck,
            this.btnRefundCheck});
            this.ribbonBarInvoiceCheck.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarInvoiceCheck.Name = "ribbonBarInvoiceCheck";
            this.ribbonBarInvoiceCheck.Size = new System.Drawing.Size(360, 90);
            this.ribbonBarInvoiceCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarInvoiceCheck.TabIndex = 0;
            this.ribbonBarInvoiceCheck.Text = "����";
            // 
            // 
            // 
            this.ribbonBarInvoiceCheck.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarInvoiceCheck.TitleStyleMouseOver.Class = "";
            // 
            // btnCDACheck
            // 
            this.btnCDACheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCDACheck.Image")));
            this.btnCDACheck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCDACheck.Name = "btnCDACheck";
            this.btnCDACheck.SubItemsExpandWidth = 14;
            this.btnCDACheck.Text = "���֪ͨ�����";
            this.btnCDACheck.Click += new System.EventHandler(this.CheckCDA);
            // 
            // btnAssignCheck
            // 
            this.btnAssignCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignCheck.Image")));
            this.btnAssignCheck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAssignCheck.Name = "btnAssignCheck";
            this.btnAssignCheck.SubItemsExpandWidth = 14;
            this.btnAssignCheck.Text = "ת�ø���";
            // 
            // btnFinanceCheck
            // 
            this.btnFinanceCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceCheck.Image")));
            this.btnFinanceCheck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFinanceCheck.Name = "btnFinanceCheck";
            this.btnFinanceCheck.SubItemsExpandWidth = 14;
            this.btnFinanceCheck.Text = "���ʸ���";
            // 
            // btnPaymentCheck
            // 
            this.btnPaymentCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnPaymentCheck.Image")));
            this.btnPaymentCheck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPaymentCheck.Name = "btnPaymentCheck";
            this.btnPaymentCheck.SubItemsExpandWidth = 14;
            this.btnPaymentCheck.Text = "�����";
            // 
            // btnRefundCheck
            // 
            this.btnRefundCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnRefundCheck.Image")));
            this.btnRefundCheck.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRefundCheck.Name = "btnRefundCheck";
            this.btnRefundCheck.SubItemsExpandWidth = 14;
            this.btnRefundCheck.Text = "�����";
            // 
            // ribbonPanelARImport
            // 
            this.ribbonPanelARImport.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelARImport.Controls.Add(this.ribbonBarPoolIMport);
            this.ribbonPanelARImport.Controls.Add(this.ribbonBarARImport);
            this.ribbonPanelARImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelARImport.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanelARImport.Name = "ribbonPanelARImport";
            this.ribbonPanelARImport.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelARImport.Size = new System.Drawing.Size(1082, 93);
            // 
            // 
            // 
            this.ribbonPanelARImport.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanelARImport.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanelARImport.StyleMouseOver.Class = "";
            this.ribbonPanelARImport.TabIndex = 13;
            this.ribbonPanelARImport.Visible = false;
            // 
            // ribbonBarPoolIMport
            // 
            this.ribbonBarPoolIMport.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarPoolIMport.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarPoolIMport.BackgroundStyle.Class = "";
            this.ribbonBarPoolIMport.ContainerControlProcessDialogKey = true;
            this.ribbonBarPoolIMport.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarPoolIMport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPoolFinanceImport,
            this.btnPoolRefundImport});
            this.ribbonBarPoolIMport.Location = new System.Drawing.Point(657, 0);
            this.ribbonBarPoolIMport.Name = "ribbonBarPoolIMport";
            this.ribbonBarPoolIMport.Size = new System.Drawing.Size(309, 90);
            this.ribbonBarPoolIMport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarPoolIMport.TabIndex = 1;
            this.ribbonBarPoolIMport.Text = "�����ʱ�����";
            // 
            // 
            // 
            this.ribbonBarPoolIMport.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarPoolIMport.TitleStyleMouseOver.Class = "";
            // 
            // btnPoolFinanceImport
            // 
            this.btnPoolFinanceImport.Image = ((System.Drawing.Image)(resources.GetObject("btnPoolFinanceImport.Image")));
            this.btnPoolFinanceImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPoolFinanceImport.Name = "btnPoolFinanceImport";
            this.btnPoolFinanceImport.SubItemsExpandWidth = 14;
            this.btnPoolFinanceImport.Text = "�ſ���ϸ�������ʣ�";
            this.btnPoolFinanceImport.Click += new System.EventHandler(this.ImportPoolFinance);
            // 
            // btnPoolRefundImport
            // 
            this.btnPoolRefundImport.Image = ((System.Drawing.Image)(resources.GetObject("btnPoolRefundImport.Image")));
            this.btnPoolRefundImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPoolRefundImport.Name = "btnPoolRefundImport";
            this.btnPoolRefundImport.SubItemsExpandWidth = 14;
            this.btnPoolRefundImport.Text = "����������ϸ�������ʣ�";
            this.btnPoolRefundImport.Click += new System.EventHandler(this.ImportPoolRefund);
            // 
            // ribbonBarARImport
            // 
            this.ribbonBarARImport.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarARImport.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarARImport.BackgroundStyle.Class = "";
            this.ribbonBarARImport.ContainerControlProcessDialogKey = true;
            this.ribbonBarARImport.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarARImport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAssignImport,
            this.btnAssignImportNew,
            this.btnFinanceImport,
            this.btnPaymentImport,
            this.btnCreditNoteImport,
            this.btnRefundImport});
            this.ribbonBarARImport.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarARImport.Name = "ribbonBarARImport";
            this.ribbonBarARImport.Size = new System.Drawing.Size(654, 90);
            this.ribbonBarARImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarARImport.TabIndex = 0;
            this.ribbonBarARImport.Text = "Ӧ���˿������";
            // 
            // 
            // 
            this.ribbonBarARImport.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarARImport.TitleStyleMouseOver.Class = "";
            // 
            // btnAssignImport
            // 
            this.btnAssignImport.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignImport.Image")));
            this.btnAssignImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAssignImport.Name = "btnAssignImport";
            this.btnAssignImport.SubItemsExpandWidth = 14;
            this.btnAssignImport.Text = "Ӧ���˿�ת���嵥";
            this.btnAssignImport.Click += new System.EventHandler(this.ImportAssign);
            // 
            // btnAssignImportNew
            // 
            this.btnAssignImportNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignImportNew.Image")));
            this.btnAssignImportNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAssignImportNew.Name = "btnAssignImportNew";
            this.btnAssignImportNew.SubItemsExpandWidth = 14;
            this.btnAssignImportNew.Text = "Ӧ���˿�ת���嵥(��)";
            this.btnAssignImportNew.Click += new System.EventHandler(this.ImportAssignNew);
            // 
            // btnFinanceImport
            // 
            this.btnFinanceImport.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceImport.Image")));
            this.btnFinanceImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFinanceImport.Name = "btnFinanceImport";
            this.btnFinanceImport.SubItemsExpandWidth = 14;
            this.btnFinanceImport.Text = "�ſ���ϸ��";
            this.btnFinanceImport.Click += new System.EventHandler(this.ImportFinance);
            // 
            // btnPaymentImport
            // 
            this.btnPaymentImport.Image = ((System.Drawing.Image)(resources.GetObject("btnPaymentImport.Image")));
            this.btnPaymentImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPaymentImport.Name = "btnPaymentImport";
            this.btnPaymentImport.SubItemsExpandWidth = 14;
            this.btnPaymentImport.Text = "�����˿���ϸ��";
            this.btnPaymentImport.Click += new System.EventHandler(this.ImportPayment);
            // 
            // btnCreditNoteImport
            // 
            this.btnCreditNoteImport.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditNoteImport.Image")));
            this.btnCreditNoteImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCreditNoteImport.Name = "btnCreditNoteImport";
            this.btnCreditNoteImport.SubItemsExpandWidth = 14;
            this.btnCreditNoteImport.Text = "��������˿���ϸ��";
            this.btnCreditNoteImport.Click += new System.EventHandler(this.ImportCreditNote);
            // 
            // btnRefundImport
            // 
            this.btnRefundImport.Image = ((System.Drawing.Image)(resources.GetObject("btnRefundImport.Image")));
            this.btnRefundImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRefundImport.Name = "btnRefundImport";
            this.btnRefundImport.SubItemsExpandWidth = 14;
            this.btnRefundImport.Text = "����������ϸ��";
            this.btnRefundImport.Click += new System.EventHandler(this.ImportRefund);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.ribbonBarUserMgr);
            this.ribbonPanel3.Controls.Add(this.ribbonBarSystem);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(1082, 93);
            // 
            // 
            // 
            this.ribbonPanel3.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanel3.StyleMouseOver.Class = "";
            this.ribbonPanel3.TabIndex = 11;
            this.ribbonPanel3.Visible = false;
            // 
            // ribbonBarUserMgr
            // 
            this.ribbonBarUserMgr.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarUserMgr.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarUserMgr.BackgroundStyle.Class = "";
            this.ribbonBarUserMgr.ContainerControlProcessDialogKey = true;
            this.ribbonBarUserMgr.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarUserMgr.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUserMgr});
            this.ribbonBarUserMgr.Location = new System.Drawing.Point(375, 0);
            this.ribbonBarUserMgr.Name = "ribbonBarUserMgr";
            this.ribbonBarUserMgr.Size = new System.Drawing.Size(71, 90);
            this.ribbonBarUserMgr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarUserMgr.TabIndex = 1;
            this.ribbonBarUserMgr.Text = "�û�";
            // 
            // 
            // 
            this.ribbonBarUserMgr.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarUserMgr.TitleStyleMouseOver.Class = "";
            // 
            // btnUserMgr
            // 
            this.btnUserMgr.Image = ((System.Drawing.Image)(resources.GetObject("btnUserMgr.Image")));
            this.btnUserMgr.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUserMgr.Name = "btnUserMgr";
            this.btnUserMgr.SubItemsExpandWidth = 14;
            this.btnUserMgr.Text = "�û���Ϣ";
            this.btnUserMgr.Click += new System.EventHandler(this.QueryUsers);
            // 
            // ribbonBarSystem
            // 
            this.ribbonBarSystem.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarSystem.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarSystem.BackgroundStyle.Class = "";
            this.ribbonBarSystem.ContainerControlProcessDialogKey = true;
            this.ribbonBarSystem.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarSystem.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUserImport,
            this.btnDepartmentImport,
            this.btnFactorImport,
            this.btnExchangeRateImport});
            this.ribbonBarSystem.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarSystem.Name = "ribbonBarSystem";
            this.ribbonBarSystem.Size = new System.Drawing.Size(372, 90);
            this.ribbonBarSystem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarSystem.TabIndex = 0;
            this.ribbonBarSystem.Text = "����";
            // 
            // 
            // 
            this.ribbonBarSystem.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarSystem.TitleStyleMouseOver.Class = "";
            // 
            // btnUserImport
            // 
            this.btnUserImport.Image = ((System.Drawing.Image)(resources.GetObject("btnUserImport.Image")));
            this.btnUserImport.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnUserImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUserImport.Name = "btnUserImport";
            this.btnUserImport.SubItemsExpandWidth = 14;
            this.btnUserImport.Text = "�����û���Ϣ";
            this.btnUserImport.Click += new System.EventHandler(this.ImportUsers);
            // 
            // btnDepartmentImport
            // 
            this.btnDepartmentImport.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartmentImport.Image")));
            this.btnDepartmentImport.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnDepartmentImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDepartmentImport.Name = "btnDepartmentImport";
            this.btnDepartmentImport.SubItemsExpandWidth = 14;
            this.btnDepartmentImport.Text = "���벿����Ϣ";
            this.btnDepartmentImport.Click += new System.EventHandler(this.ImportDepartments);
            // 
            // btnFactorImport
            // 
            this.btnFactorImport.Image = ((System.Drawing.Image)(resources.GetObject("btnFactorImport.Image")));
            this.btnFactorImport.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnFactorImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFactorImport.Name = "btnFactorImport";
            this.btnFactorImport.SubItemsExpandWidth = 14;
            this.btnFactorImport.Text = "���뱣������Ϣ";
            this.btnFactorImport.Click += new System.EventHandler(this.ImportFactors);
            // 
            // btnExchangeRateImport
            // 
            this.btnExchangeRateImport.Image = ((System.Drawing.Image)(resources.GetObject("btnExchangeRateImport.Image")));
            this.btnExchangeRateImport.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnExchangeRateImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExchangeRateImport.Name = "btnExchangeRateImport";
            this.btnExchangeRateImport.SubItemsExpandWidth = 14;
            this.btnExchangeRateImport.Text = "���������Ϣ";
            this.btnExchangeRateImport.Click += new System.EventHandler(this.ImportExchangeRate);
            // 
            // ribbonPanelMigration
            // 
            this.ribbonPanelMigration.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelMigration.Controls.Add(this.ribbonBarInvoiceImport);
            this.ribbonPanelMigration.Controls.Add(this.ribbonBarCreditLineImport);
            this.ribbonPanelMigration.Controls.Add(this.ribbonBarCaseImport);
            this.ribbonPanelMigration.Controls.Add(this.ribbonBarBasicInfoImport);
            this.ribbonPanelMigration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelMigration.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanelMigration.Name = "ribbonPanelMigration";
            this.ribbonPanelMigration.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelMigration.Size = new System.Drawing.Size(1082, 93);
            // 
            // 
            // 
            this.ribbonPanelMigration.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanelMigration.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanelMigration.StyleMouseOver.Class = "";
            this.ribbonPanelMigration.TabIndex = 8;
            this.ribbonPanelMigration.Visible = false;
            // 
            // ribbonBarInvoiceImport
            // 
            this.ribbonBarInvoiceImport.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarInvoiceImport.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarInvoiceImport.BackgroundStyle.Class = "";
            this.ribbonBarInvoiceImport.ContainerControlProcessDialogKey = true;
            this.ribbonBarInvoiceImport.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarInvoiceImport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnInvoicesImport});
            this.ribbonBarInvoiceImport.Location = new System.Drawing.Point(805, 0);
            this.ribbonBarInvoiceImport.Name = "ribbonBarInvoiceImport";
            this.ribbonBarInvoiceImport.Size = new System.Drawing.Size(59, 90);
            this.ribbonBarInvoiceImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarInvoiceImport.TabIndex = 3;
            this.ribbonBarInvoiceImport.Text = "̨�ʵ���";
            // 
            // 
            // 
            this.ribbonBarInvoiceImport.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarInvoiceImport.TitleStyleMouseOver.Class = "";
            // 
            // btnInvoicesImport
            // 
            this.btnInvoicesImport.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoicesImport.Image")));
            this.btnInvoicesImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInvoicesImport.Name = "btnInvoicesImport";
            this.btnInvoicesImport.SubItemsExpandWidth = 14;
            this.btnInvoicesImport.Text = "̨��";
            this.btnInvoicesImport.Click += new System.EventHandler(this.ImportInvoices);
            // 
            // ribbonBarCreditLineImport
            // 
            this.ribbonBarCreditLineImport.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarCreditLineImport.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCreditLineImport.BackgroundStyle.Class = "";
            this.ribbonBarCreditLineImport.ContainerControlProcessDialogKey = true;
            this.ribbonBarCreditLineImport.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarCreditLineImport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClientCreditLineImport,
            this.btnFactorCreditLineImport,
            this.btnCDAImport});
            this.ribbonBarCreditLineImport.Location = new System.Drawing.Point(527, 0);
            this.ribbonBarCreditLineImport.Name = "ribbonBarCreditLineImport";
            this.ribbonBarCreditLineImport.Size = new System.Drawing.Size(278, 90);
            this.ribbonBarCreditLineImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCreditLineImport.TabIndex = 2;
            this.ribbonBarCreditLineImport.Text = "�����Ϣ����";
            // 
            // 
            // 
            this.ribbonBarCreditLineImport.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCreditLineImport.TitleStyleMouseOver.Class = "";
            // 
            // btnClientCreditLineImport
            // 
            this.btnClientCreditLineImport.Image = ((System.Drawing.Image)(resources.GetObject("btnClientCreditLineImport.Image")));
            this.btnClientCreditLineImport.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnClientCreditLineImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClientCreditLineImport.Name = "btnClientCreditLineImport";
            this.btnClientCreditLineImport.SubItemsExpandWidth = 14;
            this.btnClientCreditLineImport.Text = "�ͻ������Ϣ";
            this.btnClientCreditLineImport.Click += new System.EventHandler(this.ImportClientCreditLine);
            // 
            // btnFactorCreditLineImport
            // 
            this.btnFactorCreditLineImport.Image = ((System.Drawing.Image)(resources.GetObject("btnFactorCreditLineImport.Image")));
            this.btnFactorCreditLineImport.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnFactorCreditLineImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFactorCreditLineImport.Name = "btnFactorCreditLineImport";
            this.btnFactorCreditLineImport.SubItemsExpandWidth = 14;
            this.btnFactorCreditLineImport.Text = "�������������Ϣ";
            this.btnFactorCreditLineImport.Click += new System.EventHandler(this.ImportFactorCreditLine);
            // 
            // btnCDAImport
            // 
            this.btnCDAImport.Image = ((System.Drawing.Image)(resources.GetObject("btnCDAImport.Image")));
            this.btnCDAImport.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnCDAImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCDAImport.Name = "btnCDAImport";
            this.btnCDAImport.SubItemsExpandWidth = 14;
            this.btnCDAImport.Text = "���֪ͨ��";
            this.btnCDAImport.Click += new System.EventHandler(this.ImportCDA);
            // 
            // ribbonBarCaseImport
            // 
            this.ribbonBarCaseImport.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarCaseImport.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCaseImport.BackgroundStyle.Class = "";
            this.ribbonBarCaseImport.ContainerControlProcessDialogKey = true;
            this.ribbonBarCaseImport.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarCaseImport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCaseImport,
            this.btnCreditCoverNegImport,
            this.btnContractImport});
            this.ribbonBarCaseImport.Location = new System.Drawing.Point(312, 0);
            this.ribbonBarCaseImport.Name = "ribbonBarCaseImport";
            this.ribbonBarCaseImport.Size = new System.Drawing.Size(215, 90);
            this.ribbonBarCaseImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCaseImport.TabIndex = 1;
            this.ribbonBarCaseImport.Text = "��������";
            // 
            // 
            // 
            this.ribbonBarCaseImport.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCaseImport.TitleStyleMouseOver.Class = "";
            // 
            // btnCaseImport
            // 
            this.btnCaseImport.Image = ((System.Drawing.Image)(resources.GetObject("btnCaseImport.Image")));
            this.btnCaseImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCaseImport.Name = "btnCaseImport";
            this.btnCaseImport.SubItemsExpandWidth = 14;
            this.btnCaseImport.Text = "����";
            this.btnCaseImport.Click += new System.EventHandler(this.ImportCases);
            // 
            // btnCreditCoverNegImport
            // 
            this.btnCreditCoverNegImport.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditCoverNegImport.Image")));
            this.btnCreditCoverNegImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCreditCoverNegImport.Name = "btnCreditCoverNegImport";
            this.btnCreditCoverNegImport.SubItemsExpandWidth = 14;
            this.btnCreditCoverNegImport.Text = "�����������";
            this.btnCreditCoverNegImport.Click += new System.EventHandler(this.ImportCreditCoverNeg);
            // 
            // btnContractImport
            // 
            this.btnContractImport.Image = ((System.Drawing.Image)(resources.GetObject("btnContractImport.Image")));
            this.btnContractImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnContractImport.Name = "btnContractImport";
            this.btnContractImport.SubItemsExpandWidth = 14;
            this.btnContractImport.Text = "�����ͬ";
            this.btnContractImport.Click += new System.EventHandler(this.ImportContract);
            // 
            // ribbonBarBasicInfoImport
            // 
            this.ribbonBarBasicInfoImport.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarBasicInfoImport.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarBasicInfoImport.BackgroundStyle.Class = "";
            this.ribbonBarBasicInfoImport.ContainerControlProcessDialogKey = true;
            this.ribbonBarBasicInfoImport.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarBasicInfoImport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClientImport,
            this.btnClientOverwriteImport,
            this.btnClientReviewImport,
            this.btnFactorImport2});
            this.ribbonBarBasicInfoImport.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarBasicInfoImport.Name = "ribbonBarBasicInfoImport";
            this.ribbonBarBasicInfoImport.Size = new System.Drawing.Size(309, 90);
            this.ribbonBarBasicInfoImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarBasicInfoImport.TabIndex = 0;
            this.ribbonBarBasicInfoImport.Text = "������Ϣ����";
            // 
            // 
            // 
            this.ribbonBarBasicInfoImport.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarBasicInfoImport.TitleStyleMouseOver.Class = "";
            // 
            // btnClientImport
            // 
            this.btnClientImport.Image = ((System.Drawing.Image)(resources.GetObject("btnClientImport.Image")));
            this.btnClientImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClientImport.Name = "btnClientImport";
            this.btnClientImport.SubItemsExpandWidth = 14;
            this.btnClientImport.Text = "�ͻ���Ϣ";
            this.btnClientImport.Click += new System.EventHandler(this.ImportClients);
            // 
            // btnClientOverwriteImport
            // 
            this.btnClientOverwriteImport.Image = ((System.Drawing.Image)(resources.GetObject("btnClientOverwriteImport.Image")));
            this.btnClientOverwriteImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClientOverwriteImport.Name = "btnClientOverwriteImport";
            this.btnClientOverwriteImport.SubItemsExpandWidth = 14;
            this.btnClientOverwriteImport.Text = "�ͻ���Ϣ(����)";
            this.btnClientOverwriteImport.Click += new System.EventHandler(this.ImportClientsOverwrite);
            // 
            // btnClientReviewImport
            // 
            this.btnClientReviewImport.Image = ((System.Drawing.Image)(resources.GetObject("btnClientReviewImport.Image")));
            this.btnClientReviewImport.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnClientReviewImport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClientReviewImport.Name = "btnClientReviewImport";
            this.btnClientReviewImport.SubItemsExpandWidth = 14;
            this.btnClientReviewImport.Text = "Э�����";
            this.btnClientReviewImport.Click += new System.EventHandler(this.ImportClientsReview);
            // 
            // btnFactorImport2
            // 
            this.btnFactorImport2.Image = ((System.Drawing.Image)(resources.GetObject("btnFactorImport2.Image")));
            this.btnFactorImport2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFactorImport2.Name = "btnFactorImport2";
            this.btnFactorImport2.SubItemsExpandWidth = 14;
            this.btnFactorImport2.Text = "����������Ϣ";
            this.btnFactorImport2.Click += new System.EventHandler(this.ImportFactors);
            // 
            // ribbonPanelReport
            // 
            this.ribbonPanelReport.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelReport.Controls.Add(this.ribbonBarAnalysisReport);
            this.ribbonPanelReport.Controls.Add(this.ribbonBarTransactionReport);
            this.ribbonPanelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelReport.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanelReport.Name = "ribbonPanelReport";
            this.ribbonPanelReport.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelReport.Size = new System.Drawing.Size(1082, 93);
            // 
            // 
            // 
            this.ribbonPanelReport.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanelReport.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanelReport.StyleMouseOver.Class = "";
            this.ribbonPanelReport.TabIndex = 3;
            this.ribbonPanelReport.Visible = false;
            // 
            // ribbonBarAnalysisReport
            // 
            this.ribbonBarAnalysisReport.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarAnalysisReport.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarAnalysisReport.BackgroundStyle.Class = "";
            this.ribbonBarAnalysisReport.ContainerControlProcessDialogKey = true;
            this.ribbonBarAnalysisReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarAnalysisReport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCaseStat,
            this.btnDepartmentStat,
            this.btnLocationStat,
            this.btnFactorCommissionStat});
            this.ribbonBarAnalysisReport.Location = new System.Drawing.Point(603, 0);
            this.ribbonBarAnalysisReport.Name = "ribbonBarAnalysisReport";
            this.ribbonBarAnalysisReport.Size = new System.Drawing.Size(285, 90);
            this.ribbonBarAnalysisReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarAnalysisReport.TabIndex = 1;
            this.ribbonBarAnalysisReport.Text = "ͳ�Ʒ���";
            // 
            // 
            // 
            this.ribbonBarAnalysisReport.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarAnalysisReport.TitleStyleMouseOver.Class = "";
            // 
            // btnCaseStat
            // 
            this.btnCaseStat.Image = ((System.Drawing.Image)(resources.GetObject("btnCaseStat.Image")));
            this.btnCaseStat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCaseStat.Name = "btnCaseStat";
            this.btnCaseStat.SubItemsExpandWidth = 14;
            this.btnCaseStat.Text = "����ͳ��";
            this.btnCaseStat.Click += new System.EventHandler(this.StatCase);
            // 
            // btnDepartmentStat
            // 
            this.btnDepartmentStat.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartmentStat.Image")));
            this.btnDepartmentStat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDepartmentStat.Name = "btnDepartmentStat";
            this.btnDepartmentStat.SubItemsExpandWidth = 14;
            this.btnDepartmentStat.Text = "�ֲ�ͳ��";
            this.btnDepartmentStat.Click += new System.EventHandler(this.StatDepartment);
            // 
            // btnLocationStat
            // 
            this.btnLocationStat.Image = ((System.Drawing.Image)(resources.GetObject("btnLocationStat.Image")));
            this.btnLocationStat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLocationStat.Name = "btnLocationStat";
            this.btnLocationStat.SubItemsExpandWidth = 14;
            this.btnLocationStat.Text = "����ͳ��";
            this.btnLocationStat.Click += new System.EventHandler(this.StatLocation);
            // 
            // btnFactorCommissionStat
            // 
            this.btnFactorCommissionStat.Image = ((System.Drawing.Image)(resources.GetObject("btnFactorCommissionStat.Image")));
            this.btnFactorCommissionStat.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFactorCommissionStat.Name = "btnFactorCommissionStat";
            this.btnFactorCommissionStat.SubItemsExpandWidth = 14;
            this.btnFactorCommissionStat.Text = "������������";
            this.btnFactorCommissionStat.Click += new System.EventHandler(this.StatFactorCommission);
            // 
            // ribbonBarTransactionReport
            // 
            this.ribbonBarTransactionReport.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarTransactionReport.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarTransactionReport.BackgroundStyle.Class = "";
            this.ribbonBarTransactionReport.ContainerControlProcessDialogKey = true;
            this.ribbonBarTransactionReport.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarTransactionReport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnARAssignReport,
            this.btnFinanceReport,
            this.btnFeeReport,
            this.btnFlawReport,
            this.btnCDAReport,
            this.btnLeger,
            this.btnSendLeger});
            this.ribbonBarTransactionReport.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarTransactionReport.Name = "ribbonBarTransactionReport";
            this.ribbonBarTransactionReport.Size = new System.Drawing.Size(600, 90);
            this.ribbonBarTransactionReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarTransactionReport.TabIndex = 0;
            this.ribbonBarTransactionReport.Text = "ҵ�񱨱�";
            // 
            // 
            // 
            this.ribbonBarTransactionReport.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarTransactionReport.TitleStyleMouseOver.Class = "";
            // 
            // btnARAssignReport
            // 
            this.btnARAssignReport.Image = ((System.Drawing.Image)(resources.GetObject("btnARAssignReport.Image")));
            this.btnARAssignReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnARAssignReport.Name = "btnARAssignReport";
            this.btnARAssignReport.SubItemsExpandWidth = 14;
            this.btnARAssignReport.Text = "Ӧ���˿�ת����ϸ��";
            this.btnARAssignReport.Click += new System.EventHandler(this.ReportARPayment);
            // 
            // btnFinanceReport
            // 
            this.btnFinanceReport.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceReport.Image")));
            this.btnFinanceReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFinanceReport.Name = "btnFinanceReport";
            this.btnFinanceReport.SubItemsExpandWidth = 14;
            this.btnFinanceReport.Text = "�������˿���ϸ��";
            this.btnFinanceReport.Click += new System.EventHandler(this.ReportFinance);
            // 
            // btnFeeReport
            // 
            this.btnFeeReport.Image = ((System.Drawing.Image)(resources.GetObject("btnFeeReport.Image")));
            this.btnFeeReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFeeReport.Name = "btnFeeReport";
            this.btnFeeReport.SubItemsExpandWidth = 14;
            this.btnFeeReport.Text = "���������ϸ��";
            this.btnFeeReport.Click += new System.EventHandler(this.ReportFee);
            // 
            // btnFlawReport
            // 
            this.btnFlawReport.Image = ((System.Drawing.Image)(resources.GetObject("btnFlawReport.Image")));
            this.btnFlawReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFlawReport.Name = "btnFlawReport";
            this.btnFlawReport.SubItemsExpandWidth = 14;
            this.btnFlawReport.Text = "覴�֪ͨ��";
            this.btnFlawReport.Click += new System.EventHandler(this.ReportInvoiceFlaw);
            // 
            // btnCDAReport
            // 
            this.btnCDAReport.Image = ((System.Drawing.Image)(resources.GetObject("btnCDAReport.Image")));
            this.btnCDAReport.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnCDAReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCDAReport.Name = "btnCDAReport";
            this.btnCDAReport.SubItemsExpandWidth = 14;
            this.btnCDAReport.Text = "���֪ͨ��";
            this.btnCDAReport.Click += new System.EventHandler(this.ReportCDA);
            // 
            // btnLeger
            // 
            this.btnLeger.Image = ((System.Drawing.Image)(resources.GetObject("btnLeger.Image")));
            this.btnLeger.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLeger.Name = "btnLeger";
            this.btnLeger.SubItemsExpandWidth = 14;
            this.btnLeger.Text = "̨��";
            this.btnLeger.Click += new System.EventHandler(this.ReportLeger);
            // 
            // btnSendLeger
            // 
            this.btnSendLeger.Image = ((System.Drawing.Image)(resources.GetObject("btnSendLeger.Image")));
            this.btnSendLeger.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnSendLeger.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSendLeger.Name = "btnSendLeger";
            this.btnSendLeger.SubItemsExpandWidth = 14;
            this.btnSendLeger.Text = "���ʱ���";
            this.btnSendLeger.Click += new System.EventHandler(this.EmailLeger);
            // 
            // ribbonPanelQuery
            // 
            this.ribbonPanelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelQuery.Controls.Add(this.ribbonBarPoolQuery);
            this.ribbonPanelQuery.Controls.Add(this.ribbonBarBatchQuery);
            this.ribbonPanelQuery.Controls.Add(this.ribbonBarCaseQuery);
            this.ribbonPanelQuery.Controls.Add(this.ribbonBarCreditLineQuery);
            this.ribbonPanelQuery.Controls.Add(this.ribbonBarClientQuery);
            this.ribbonPanelQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelQuery.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanelQuery.Name = "ribbonPanelQuery";
            this.ribbonPanelQuery.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelQuery.Size = new System.Drawing.Size(1082, 93);
            // 
            // 
            // 
            this.ribbonPanelQuery.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanelQuery.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanelQuery.StyleMouseOver.Class = "";
            this.ribbonPanelQuery.TabIndex = 7;
            this.ribbonPanelQuery.Visible = false;
            // 
            // ribbonBarPoolQuery
            // 
            this.ribbonBarPoolQuery.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarPoolQuery.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarPoolQuery.BackgroundStyle.Class = "";
            this.ribbonBarPoolQuery.ContainerControlProcessDialogKey = true;
            this.ribbonBarPoolQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarPoolQuery.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPoolFinanceBatchQuery,
            this.btnPoolRefundQuery});
            this.ribbonBarPoolQuery.Location = new System.Drawing.Point(1069, 0);
            this.ribbonBarPoolQuery.Name = "ribbonBarPoolQuery";
            this.ribbonBarPoolQuery.Size = new System.Drawing.Size(110, 90);
            this.ribbonBarPoolQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarPoolQuery.TabIndex = 4;
            this.ribbonBarPoolQuery.Text = "�ز�ѯ";
            // 
            // 
            // 
            this.ribbonBarPoolQuery.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarPoolQuery.TitleStyleMouseOver.Class = "";
            // 
            // btnPoolFinanceBatchQuery
            // 
            this.btnPoolFinanceBatchQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnPoolFinanceBatchQuery.Image")));
            this.btnPoolFinanceBatchQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPoolFinanceBatchQuery.Name = "btnPoolFinanceBatchQuery";
            this.btnPoolFinanceBatchQuery.SubItemsExpandWidth = 14;
            this.btnPoolFinanceBatchQuery.Text = "������";
            this.btnPoolFinanceBatchQuery.Click += new System.EventHandler(this.QueryPoolFinanceBatch);
            // 
            // btnPoolRefundQuery
            // 
            this.btnPoolRefundQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnPoolRefundQuery.Image")));
            this.btnPoolRefundQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPoolRefundQuery.Name = "btnPoolRefundQuery";
            this.btnPoolRefundQuery.SubItemsExpandWidth = 14;
            this.btnPoolRefundQuery.Text = "�ػ���";
            this.btnPoolRefundQuery.Click += new System.EventHandler(this.QueryPoolRefundBatch);
            // 
            // ribbonBarBatchQuery
            // 
            this.ribbonBarBatchQuery.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarBatchQuery.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarBatchQuery.BackgroundStyle.Class = "";
            this.ribbonBarBatchQuery.ContainerControlProcessDialogKey = true;
            this.ribbonBarBatchQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarBatchQuery.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAssignBatchQuery,
            this.btnFinanceBatchQuery,
            this.btnPaymentBatchQuery,
            this.btnRefundBatchQuery});
            this.ribbonBarBatchQuery.Location = new System.Drawing.Point(897, 0);
            this.ribbonBarBatchQuery.Name = "ribbonBarBatchQuery";
            this.ribbonBarBatchQuery.Size = new System.Drawing.Size(172, 90);
            this.ribbonBarBatchQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarBatchQuery.TabIndex = 3;
            this.ribbonBarBatchQuery.Text = "���β�ѯ";
            // 
            // 
            // 
            this.ribbonBarBatchQuery.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarBatchQuery.TitleStyleMouseOver.Class = "";
            // 
            // btnAssignBatchQuery
            // 
            this.btnAssignBatchQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnAssignBatchQuery.Image")));
            this.btnAssignBatchQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnAssignBatchQuery.Name = "btnAssignBatchQuery";
            this.btnAssignBatchQuery.SubItemsExpandWidth = 14;
            this.btnAssignBatchQuery.Text = "ת��";
            this.btnAssignBatchQuery.Click += new System.EventHandler(this.QueryAssignBatch);
            // 
            // btnFinanceBatchQuery
            // 
            this.btnFinanceBatchQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceBatchQuery.Image")));
            this.btnFinanceBatchQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFinanceBatchQuery.Name = "btnFinanceBatchQuery";
            this.btnFinanceBatchQuery.SubItemsExpandWidth = 14;
            this.btnFinanceBatchQuery.Text = "����";
            this.btnFinanceBatchQuery.Click += new System.EventHandler(this.QueryFinanceBatch);
            // 
            // btnPaymentBatchQuery
            // 
            this.btnPaymentBatchQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnPaymentBatchQuery.Image")));
            this.btnPaymentBatchQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPaymentBatchQuery.Name = "btnPaymentBatchQuery";
            this.btnPaymentBatchQuery.SubItemsExpandWidth = 14;
            this.btnPaymentBatchQuery.Text = "����";
            this.btnPaymentBatchQuery.Click += new System.EventHandler(this.QueryPaymentBatch);
            // 
            // btnRefundBatchQuery
            // 
            this.btnRefundBatchQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnRefundBatchQuery.Image")));
            this.btnRefundBatchQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRefundBatchQuery.Name = "btnRefundBatchQuery";
            this.btnRefundBatchQuery.SubItemsExpandWidth = 14;
            this.btnRefundBatchQuery.Text = "����";
            this.btnRefundBatchQuery.Click += new System.EventHandler(this.QueryRefundBatch);
            // 
            // ribbonBarCaseQuery
            // 
            this.ribbonBarCaseQuery.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarCaseQuery.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCaseQuery.BackgroundStyle.Class = "";
            this.ribbonBarCaseQuery.ContainerControlProcessDialogKey = true;
            this.ribbonBarCaseQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarCaseQuery.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnContractQuery,
            this.btnCaseQuery,
            this.btnCreditCoverNegQuery2,
            this.btnInvoiceQuery,
            this.btnOverDueQuery,
            this.btnCreditNoteQuery});
            this.ribbonBarCaseQuery.Location = new System.Drawing.Point(577, 0);
            this.ribbonBarCaseQuery.Name = "ribbonBarCaseQuery";
            this.ribbonBarCaseQuery.Size = new System.Drawing.Size(320, 90);
            this.ribbonBarCaseQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCaseQuery.TabIndex = 2;
            this.ribbonBarCaseQuery.Text = "���Ӳ�ѯ";
            // 
            // 
            // 
            this.ribbonBarCaseQuery.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCaseQuery.TitleStyleMouseOver.Class = "";
            // 
            // btnContractQuery
            // 
            this.btnContractQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnContractQuery.Image")));
            this.btnContractQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnContractQuery.Name = "btnContractQuery";
            this.btnContractQuery.SubItemsExpandWidth = 14;
            this.btnContractQuery.Text = "�����ͬ";
            this.btnContractQuery.Click += new System.EventHandler(this.QueryContract);
            // 
            // btnCaseQuery
            // 
            this.btnCaseQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnCaseQuery.Image")));
            this.btnCaseQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCaseQuery.Name = "btnCaseQuery";
            this.btnCaseQuery.SubItemsExpandWidth = 14;
            this.btnCaseQuery.Text = "����";
            this.btnCaseQuery.Click += new System.EventHandler(this.QueryCase);
            // 
            // btnCreditCoverNegQuery2
            // 
            this.btnCreditCoverNegQuery2.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditCoverNegQuery2.Image")));
            this.btnCreditCoverNegQuery2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCreditCoverNegQuery2.Name = "btnCreditCoverNegQuery2";
            this.btnCreditCoverNegQuery2.SubItemsExpandWidth = 14;
            this.btnCreditCoverNegQuery2.Text = "�������";
            this.btnCreditCoverNegQuery2.Click += new System.EventHandler(this.QueryCreditCoverNegs);
            // 
            // btnInvoiceQuery
            // 
            this.btnInvoiceQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoiceQuery.Image")));
            this.btnInvoiceQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInvoiceQuery.Name = "btnInvoiceQuery";
            this.btnInvoiceQuery.SubItemsExpandWidth = 14;
            this.btnInvoiceQuery.Text = "��Ʊ";
            this.btnInvoiceQuery.Click += new System.EventHandler(this.QueryInvoice);
            // 
            // btnOverDueQuery
            // 
            this.btnOverDueQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnOverDueQuery.Image")));
            this.btnOverDueQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnOverDueQuery.Name = "btnOverDueQuery";
            this.btnOverDueQuery.SubItemsExpandWidth = 14;
            this.btnOverDueQuery.Text = "����";
            this.btnOverDueQuery.Click += new System.EventHandler(this.QueryOverDue);
            // 
            // btnCreditNoteQuery
            // 
            this.btnCreditNoteQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditNoteQuery.Image")));
            this.btnCreditNoteQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCreditNoteQuery.Name = "btnCreditNoteQuery";
            this.btnCreditNoteQuery.SubItemsExpandWidth = 14;
            this.btnCreditNoteQuery.Text = "����֪ͨ";
            this.btnCreditNoteQuery.Click += new System.EventHandler(this.QueryCreditNote);
            // 
            // ribbonBarCreditLineQuery
            // 
            this.ribbonBarCreditLineQuery.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarCreditLineQuery.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCreditLineQuery.BackgroundStyle.Class = "";
            this.ribbonBarCreditLineQuery.ContainerControlProcessDialogKey = true;
            this.ribbonBarCreditLineQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarCreditLineQuery.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClinetCreditLineQuery,
            this.btnGroupCreditLineQuery,
            this.btnFactorCreditLine,
            this.btnCDAQuery});
            this.ribbonBarCreditLineQuery.Location = new System.Drawing.Point(280, 0);
            this.ribbonBarCreditLineQuery.Name = "ribbonBarCreditLineQuery";
            this.ribbonBarCreditLineQuery.Size = new System.Drawing.Size(297, 90);
            this.ribbonBarCreditLineQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCreditLineQuery.TabIndex = 1;
            this.ribbonBarCreditLineQuery.Text = "��Ȳ�ѯ";
            // 
            // 
            // 
            this.ribbonBarCreditLineQuery.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCreditLineQuery.TitleStyleMouseOver.Class = "";
            // 
            // btnClinetCreditLineQuery
            // 
            this.btnClinetCreditLineQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnClinetCreditLineQuery.Image")));
            this.btnClinetCreditLineQuery.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnClinetCreditLineQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClinetCreditLineQuery.Name = "btnClinetCreditLineQuery";
            this.btnClinetCreditLineQuery.SubItemsExpandWidth = 14;
            this.btnClinetCreditLineQuery.Text = "�ͻ����";
            this.btnClinetCreditLineQuery.Click += new System.EventHandler(this.QueryClientCreditLine);
            // 
            // btnGroupCreditLineQuery
            // 
            this.btnGroupCreditLineQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnGroupCreditLineQuery.Image")));
            this.btnGroupCreditLineQuery.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnGroupCreditLineQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGroupCreditLineQuery.Name = "btnGroupCreditLineQuery";
            this.btnGroupCreditLineQuery.SubItemsExpandWidth = 14;
            this.btnGroupCreditLineQuery.Text = "���Ŷ��";
            this.btnGroupCreditLineQuery.Click += new System.EventHandler(this.QueryClientGroupCreditLine);
            // 
            // btnFactorCreditLine
            // 
            this.btnFactorCreditLine.Image = ((System.Drawing.Image)(resources.GetObject("btnFactorCreditLine.Image")));
            this.btnFactorCreditLine.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnFactorCreditLine.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFactorCreditLine.Name = "btnFactorCreditLine";
            this.btnFactorCreditLine.SubItemsExpandWidth = 14;
            this.btnFactorCreditLine.Text = "�����������";
            this.btnFactorCreditLine.Click += new System.EventHandler(this.QueryFactorCreditLine);
            // 
            // btnCDAQuery
            // 
            this.btnCDAQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnCDAQuery.Image")));
            this.btnCDAQuery.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnCDAQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCDAQuery.Name = "btnCDAQuery";
            this.btnCDAQuery.SubItemsExpandWidth = 14;
            this.btnCDAQuery.Text = "���֪ͨ��";
            this.btnCDAQuery.Click += new System.EventHandler(this.QueryCDA);
            // 
            // ribbonBarClientQuery
            // 
            this.ribbonBarClientQuery.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarClientQuery.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarClientQuery.BackgroundStyle.Class = "";
            this.ribbonBarClientQuery.ContainerControlProcessDialogKey = true;
            this.ribbonBarClientQuery.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarClientQuery.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClientQuery,
            this.itemContainerClientQuery,
            this.btnFactorsQuery,
            this.btnDeptQuery,
            this.btnClientReviewQuery});
            this.ribbonBarClientQuery.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarClientQuery.Name = "ribbonBarClientQuery";
            this.ribbonBarClientQuery.Size = new System.Drawing.Size(277, 90);
            this.ribbonBarClientQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarClientQuery.TabIndex = 0;
            this.ribbonBarClientQuery.Text = "�ͻ���ѯ";
            // 
            // 
            // 
            this.ribbonBarClientQuery.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarClientQuery.TitleStyleMouseOver.Class = "";
            // 
            // btnClientQuery
            // 
            this.btnClientQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnClientQuery.Image")));
            this.btnClientQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClientQuery.Name = "btnClientQuery";
            this.btnClientQuery.SubItemsExpandWidth = 14;
            this.btnClientQuery.Text = "�ͻ�";
            this.btnClientQuery.Click += new System.EventHandler(this.QueryClients);
            // 
            // itemContainerClientQuery
            // 
            // 
            // 
            // 
            this.itemContainerClientQuery.BackgroundStyle.Class = "";
            this.itemContainerClientQuery.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainerClientQuery.Name = "itemContainerClientQuery";
            this.itemContainerClientQuery.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnQueryClientExport,
            this.btnQueryClientImport,
            this.btnQueryClientDominate});
            // 
            // btnQueryClientExport
            // 
            this.btnQueryClientExport.Name = "btnQueryClientExport";
            this.btnQueryClientExport.Text = "���ڱ���";
            this.btnQueryClientExport.Click += new System.EventHandler(this.QueryClientExport);
            // 
            // btnQueryClientImport
            // 
            this.btnQueryClientImport.Name = "btnQueryClientImport";
            this.btnQueryClientImport.Text = "���ڱ���";
            this.btnQueryClientImport.Click += new System.EventHandler(this.QueryClientImport);
            // 
            // btnQueryClientDominate
            // 
            this.btnQueryClientDominate.Name = "btnQueryClientDominate";
            this.btnQueryClientDominate.Text = "���ڱ���";
            this.btnQueryClientDominate.Click += new System.EventHandler(this.QueryClientDominate);
            // 
            // btnFactorsQuery
            // 
            this.btnFactorsQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnFactorsQuery.Image")));
            this.btnFactorsQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFactorsQuery.Name = "btnFactorsQuery";
            this.btnFactorsQuery.SubItemsExpandWidth = 14;
            this.btnFactorsQuery.Text = "��������";
            this.btnFactorsQuery.Click += new System.EventHandler(this.QueryFactors);
            // 
            // btnDeptQuery
            // 
            this.btnDeptQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnDeptQuery.Image")));
            this.btnDeptQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDeptQuery.Name = "btnDeptQuery";
            this.btnDeptQuery.SubItemsExpandWidth = 14;
            this.btnDeptQuery.Text = "����";
            this.btnDeptQuery.Click += new System.EventHandler(this.QueryDepartments);
            // 
            // btnClientReviewQuery
            // 
            this.btnClientReviewQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnClientReviewQuery.Image")));
            this.btnClientReviewQuery.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnClientReviewQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClientReviewQuery.Name = "btnClientReviewQuery";
            this.btnClientReviewQuery.SubItemsExpandWidth = 14;
            this.btnClientReviewQuery.Text = "Э�����";
            this.btnClientReviewQuery.Click += new System.EventHandler(this.QueryClientReviews);
            // 
            // ribbonPanelInfoMgr
            // 
            this.ribbonPanelInfoMgr.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarExchange);
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarDepartment);
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarFactor);
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarClient);
            this.ribbonPanelInfoMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelInfoMgr.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanelInfoMgr.Name = "ribbonPanelInfoMgr";
            this.ribbonPanelInfoMgr.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelInfoMgr.Size = new System.Drawing.Size(1082, 93);
            // 
            // 
            // 
            this.ribbonPanelInfoMgr.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanelInfoMgr.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanelInfoMgr.StyleMouseOver.Class = "";
            this.ribbonPanelInfoMgr.TabIndex = 2;
            // 
            // ribbonBarExchange
            // 
            this.ribbonBarExchange.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarExchange.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarExchange.BackgroundStyle.Class = "";
            this.ribbonBarExchange.ContainerControlProcessDialogKey = true;
            this.ribbonBarExchange.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarExchange.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExchangeQuery});
            this.ribbonBarExchange.Location = new System.Drawing.Point(367, 0);
            this.ribbonBarExchange.Name = "ribbonBarExchange";
            this.ribbonBarExchange.Size = new System.Drawing.Size(71, 90);
            this.ribbonBarExchange.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarExchange.TabIndex = 3;
            this.ribbonBarExchange.Text = "����";
            // 
            // 
            // 
            this.ribbonBarExchange.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarExchange.TitleStyleMouseOver.Class = "";
            // 
            // btnExchangeQuery
            // 
            this.btnExchangeQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnExchangeQuery.Image")));
            this.btnExchangeQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnExchangeQuery.Name = "btnExchangeQuery";
            this.btnExchangeQuery.SubItemsExpandWidth = 14;
            this.btnExchangeQuery.Text = "������Ϣ";
            this.btnExchangeQuery.Click += new System.EventHandler(this.QueryExchanges);
            // 
            // ribbonBarDepartment
            // 
            this.ribbonBarDepartment.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarDepartment.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarDepartment.BackgroundStyle.Class = "";
            this.ribbonBarDepartment.ContainerControlProcessDialogKey = true;
            this.ribbonBarDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarDepartment.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDepartMgr});
            this.ribbonBarDepartment.Location = new System.Drawing.Point(296, 0);
            this.ribbonBarDepartment.Name = "ribbonBarDepartment";
            this.ribbonBarDepartment.Size = new System.Drawing.Size(71, 90);
            this.ribbonBarDepartment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarDepartment.TabIndex = 2;
            this.ribbonBarDepartment.Text = "����";
            // 
            // 
            // 
            this.ribbonBarDepartment.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarDepartment.TitleStyleMouseOver.Class = "";
            // 
            // btnDepartMgr
            // 
            this.btnDepartMgr.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartMgr.Image")));
            this.btnDepartMgr.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDepartMgr.Name = "btnDepartMgr";
            this.btnDepartMgr.SubItemsExpandWidth = 14;
            this.btnDepartMgr.Text = "������Ϣ";
            this.btnDepartMgr.Click += new System.EventHandler(this.QueryDepartments);
            // 
            // ribbonBarFactor
            // 
            this.ribbonBarFactor.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarFactor.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarFactor.BackgroundStyle.Class = "";
            this.ribbonBarFactor.ContainerControlProcessDialogKey = true;
            this.ribbonBarFactor.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarFactor.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnFactorMgr,
            this.btnFactorNew});
            this.ribbonBarFactor.Location = new System.Drawing.Point(137, 0);
            this.ribbonBarFactor.Name = "ribbonBarFactor";
            this.ribbonBarFactor.Size = new System.Drawing.Size(159, 90);
            this.ribbonBarFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarFactor.TabIndex = 1;
            this.ribbonBarFactor.Text = "��������";
            // 
            // 
            // 
            this.ribbonBarFactor.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarFactor.TitleStyleMouseOver.Class = "";
            // 
            // btnFactorMgr
            // 
            this.btnFactorMgr.Image = ((System.Drawing.Image)(resources.GetObject("btnFactorMgr.Image")));
            this.btnFactorMgr.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFactorMgr.Name = "btnFactorMgr";
            this.btnFactorMgr.SubItemsExpandWidth = 14;
            this.btnFactorMgr.Text = "������Ϣ";
            this.btnFactorMgr.Click += new System.EventHandler(this.QueryFactors);
            // 
            // btnFactorNew
            // 
            this.btnFactorNew.Image = ((System.Drawing.Image)(resources.GetObject("btnFactorNew.Image")));
            this.btnFactorNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFactorNew.Name = "btnFactorNew";
            this.btnFactorNew.SubItemsExpandWidth = 14;
            this.btnFactorNew.Text = "������������";
            this.btnFactorNew.Click += new System.EventHandler(this.NewFactor);
            // 
            // ribbonBarClient
            // 
            this.ribbonBarClient.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarClient.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarClient.BackgroundStyle.Class = "";
            this.ribbonBarClient.ContainerControlProcessDialogKey = true;
            this.ribbonBarClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarClient.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnClientMgr,
            this.btnClientNew});
            this.ribbonBarClient.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarClient.Name = "ribbonBarClient";
            this.ribbonBarClient.Size = new System.Drawing.Size(134, 90);
            this.ribbonBarClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarClient.TabIndex = 0;
            this.ribbonBarClient.Text = "�ͻ�";
            // 
            // 
            // 
            this.ribbonBarClient.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarClient.TitleStyleMouseOver.Class = "";
            // 
            // btnClientMgr
            // 
            this.btnClientMgr.Image = ((System.Drawing.Image)(resources.GetObject("btnClientMgr.Image")));
            this.btnClientMgr.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClientMgr.Name = "btnClientMgr";
            this.btnClientMgr.SubItemsExpandWidth = 14;
            this.btnClientMgr.Text = "�ͻ���Ϣ";
            this.btnClientMgr.Click += new System.EventHandler(this.QueryClients);
            // 
            // btnClientNew
            // 
            this.btnClientNew.Image = ((System.Drawing.Image)(resources.GetObject("btnClientNew.Image")));
            this.btnClientNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClientNew.Name = "btnClientNew";
            this.btnClientNew.SubItemsExpandWidth = 14;
            this.btnClientNew.Text = "�����ͻ�";
            this.btnClientNew.Click += new System.EventHandler(this.NewClient);
            // 
            // ribbonPanelInvoiceMgr
            // 
            this.ribbonPanelInvoiceMgr.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarDispute);
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarPool);
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarRefund);
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarPayment);
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarFinance);
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarAssign);
            this.ribbonPanelInvoiceMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelInvoiceMgr.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanelInvoiceMgr.Name = "ribbonPanelInvoiceMgr";
            this.ribbonPanelInvoiceMgr.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelInvoiceMgr.Size = new System.Drawing.Size(1082, 93);
            // 
            // 
            // 
            this.ribbonPanelInvoiceMgr.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanelInvoiceMgr.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanelInvoiceMgr.StyleMouseOver.Class = "";
            this.ribbonPanelInvoiceMgr.TabIndex = 1;
            this.ribbonPanelInvoiceMgr.Visible = false;
            // 
            // ribbonBarDispute
            // 
            this.ribbonBarDispute.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarDispute.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarDispute.BackgroundStyle.Class = "";
            this.ribbonBarDispute.ContainerControlProcessDialogKey = true;
            this.ribbonBarDispute.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarDispute.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnFlawResolve,
            this.btnDispute});
            this.ribbonBarDispute.Location = new System.Drawing.Point(811, 0);
            this.ribbonBarDispute.Name = "ribbonBarDispute";
            this.ribbonBarDispute.Size = new System.Drawing.Size(134, 90);
            this.ribbonBarDispute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarDispute.TabIndex = 3;
            this.ribbonBarDispute.Text = "�̾���覴�";
            // 
            // 
            // 
            this.ribbonBarDispute.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarDispute.TitleStyleMouseOver.Class = "";
            // 
            // btnFlawResolve
            // 
            this.btnFlawResolve.Image = ((System.Drawing.Image)(resources.GetObject("btnFlawResolve.Image")));
            this.btnFlawResolve.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnFlawResolve.Name = "btnFlawResolve";
            this.btnFlawResolve.SubItemsExpandWidth = 14;
            this.btnFlawResolve.Text = "覴ý��";
            this.btnFlawResolve.Click += new System.EventHandler(this.FlawResolve);
            // 
            // btnDispute
            // 
            this.btnDispute.Image = ((System.Drawing.Image)(resources.GetObject("btnDispute.Image")));
            this.btnDispute.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDispute.Name = "btnDispute";
            this.btnDispute.SubItemsExpandWidth = 14;
            this.btnDispute.Text = "�̾�����";
            this.btnDispute.Click += new System.EventHandler(this.DisputeResolve);
            // 
            // ribbonBarPool
            // 
            this.ribbonBarPool.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarPool.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarPool.BackgroundStyle.Class = "";
            this.ribbonBarPool.ContainerControlProcessDialogKey = true;
            this.ribbonBarPool.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarPool.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnPoolFinance,
            this.btnPoolRefund});
            this.ribbonBarPool.Location = new System.Drawing.Point(677, 0);
            this.ribbonBarPool.Name = "ribbonBarPool";
            this.ribbonBarPool.Size = new System.Drawing.Size(134, 90);
            this.ribbonBarPool.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarPool.TabIndex = 4;
            this.ribbonBarPool.Text = "������";
            // 
            // 
            // 
            this.ribbonBarPool.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarPool.TitleStyleMouseOver.Class = "";
            // 
            // btnPoolFinance
            // 
            this.btnPoolFinance.Image = ((System.Drawing.Image)(resources.GetObject("btnPoolFinance.Image")));
            this.btnPoolFinance.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPoolFinance.Name = "btnPoolFinance";
            this.btnPoolFinance.SubItemsExpandWidth = 14;
            this.btnPoolFinance.Text = "������";
            this.btnPoolFinance.Click += new System.EventHandler(this.PoolFinance);
            // 
            // btnPoolRefund
            // 
            this.btnPoolRefund.Image = ((System.Drawing.Image)(resources.GetObject("btnPoolRefund.Image")));
            this.btnPoolRefund.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPoolRefund.Name = "btnPoolRefund";
            this.btnPoolRefund.SubItemsExpandWidth = 14;
            this.btnPoolRefund.Text = "�����ʻ���";
            this.btnPoolRefund.Click += new System.EventHandler(this.PoolRefund);
            // 
            // ribbonBarRefund
            // 
            this.ribbonBarRefund.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarRefund.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarRefund.BackgroundStyle.Class = "";
            this.ribbonBarRefund.ContainerControlProcessDialogKey = true;
            this.ribbonBarRefund.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarRefund.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnBuyerRefund,
            this.btnSellerRefund});
            this.ribbonBarRefund.Location = new System.Drawing.Point(518, 0);
            this.ribbonBarRefund.Name = "ribbonBarRefund";
            this.ribbonBarRefund.Size = new System.Drawing.Size(159, 90);
            this.ribbonBarRefund.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarRefund.TabIndex = 5;
            this.ribbonBarRefund.Text = "�������ʿ�";
            // 
            // 
            // 
            this.ribbonBarRefund.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarRefund.TitleStyleMouseOver.Class = "";
            // 
            // btnBuyerRefund
            // 
            this.btnBuyerRefund.Image = ((System.Drawing.Image)(resources.GetObject("btnBuyerRefund.Image")));
            this.btnBuyerRefund.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuyerRefund.Name = "btnBuyerRefund";
            this.btnBuyerRefund.SubItemsExpandWidth = 14;
            this.btnBuyerRefund.Text = "��ֱ�Ӹ���";
            this.btnBuyerRefund.Click += new System.EventHandler(this.InvoiceBuyerRefund);
            // 
            // btnSellerRefund
            // 
            this.btnSellerRefund.Image = ((System.Drawing.Image)(resources.GetObject("btnSellerRefund.Image")));
            this.btnSellerRefund.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSellerRefund.Name = "btnSellerRefund";
            this.btnSellerRefund.SubItemsExpandWidth = 14;
            this.btnSellerRefund.Text = "��������";
            this.btnSellerRefund.Click += new System.EventHandler(this.InvoiceSellerRefund);
            // 
            // ribbonBarPayment
            // 
            this.ribbonBarPayment.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarPayment.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarPayment.BackgroundStyle.Class = "";
            this.ribbonBarPayment.ContainerControlProcessDialogKey = true;
            this.ribbonBarPayment.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarPayment.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnBuyerPayment,
            this.btnIndirectPayment,
            this.btnGuaranteePayment,
            this.btnReassignment,
            this.btnCreditNotePayment});
            this.ribbonBarPayment.Location = new System.Drawing.Point(157, 0);
            this.ribbonBarPayment.Name = "ribbonBarPayment";
            this.ribbonBarPayment.Size = new System.Drawing.Size(361, 90);
            this.ribbonBarPayment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarPayment.TabIndex = 2;
            this.ribbonBarPayment.Text = "�����˿�";
            // 
            // 
            // 
            this.ribbonBarPayment.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarPayment.TitleStyleMouseOver.Class = "";
            // 
            // btnBuyerPayment
            // 
            this.btnBuyerPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnBuyerPayment.Image")));
            this.btnBuyerPayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBuyerPayment.Name = "btnBuyerPayment";
            this.btnBuyerPayment.SubItemsExpandWidth = 14;
            this.btnBuyerPayment.Text = "��ֱ�Ӹ���";
            this.btnBuyerPayment.Click += new System.EventHandler(this.InvoiceBuyerPayment);
            // 
            // btnIndirectPayment
            // 
            this.btnIndirectPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnIndirectPayment.Image")));
            this.btnIndirectPayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnIndirectPayment.Name = "btnIndirectPayment";
            this.btnIndirectPayment.SubItemsExpandWidth = 14;
            this.btnIndirectPayment.Text = "�򷽼�Ӹ���";
            this.btnIndirectPayment.Click += new System.EventHandler(this.InvoiceIndirectPayment);
            // 
            // btnGuaranteePayment
            // 
            this.btnGuaranteePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnGuaranteePayment.Image")));
            this.btnGuaranteePayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGuaranteePayment.Name = "btnGuaranteePayment";
            this.btnGuaranteePayment.SubItemsExpandWidth = 14;
            this.btnGuaranteePayment.Text = "��������";
            this.btnGuaranteePayment.Click += new System.EventHandler(this.InvoiceGuaranteePayment);
            // 
            // btnReassignment
            // 
            this.btnReassignment.Image = ((System.Drawing.Image)(resources.GetObject("btnReassignment.Image")));
            this.btnReassignment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnReassignment.Name = "btnReassignment";
            this.btnReassignment.SubItemsExpandWidth = 14;
            this.btnReassignment.Text = "��ת��";
            this.btnReassignment.Click += new System.EventHandler(this.InvoiceSellerReassign);
            // 
            // btnCreditNotePayment
            // 
            this.btnCreditNotePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditNotePayment.Image")));
            this.btnCreditNotePayment.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCreditNotePayment.Name = "btnCreditNotePayment";
            this.btnCreditNotePayment.SubItemsExpandWidth = 14;
            this.btnCreditNotePayment.Text = "����֪ͨ";
            this.btnCreditNotePayment.Click += new System.EventHandler(this.CreditNotePayment);
            // 
            // ribbonBarFinance
            // 
            this.ribbonBarFinance.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarFinance.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarFinance.BackgroundStyle.Class = "";
            this.ribbonBarFinance.ContainerControlProcessDialogKey = true;
            this.ribbonBarFinance.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarFinance.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnInvoiceFinance});
            this.ribbonBarFinance.Location = new System.Drawing.Point(74, 0);
            this.ribbonBarFinance.Name = "ribbonBarFinance";
            this.ribbonBarFinance.Size = new System.Drawing.Size(83, 90);
            this.ribbonBarFinance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarFinance.TabIndex = 1;
            this.ribbonBarFinance.Text = "����";
            // 
            // 
            // 
            this.ribbonBarFinance.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarFinance.TitleStyleMouseOver.Class = "";
            // 
            // btnInvoiceFinance
            // 
            this.btnInvoiceFinance.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoiceFinance.Image")));
            this.btnInvoiceFinance.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInvoiceFinance.Name = "btnInvoiceFinance";
            this.btnInvoiceFinance.SubItemsExpandWidth = 14;
            this.btnInvoiceFinance.Text = "Ԥ����֧��";
            this.btnInvoiceFinance.Click += new System.EventHandler(this.InvoiceFinance);
            // 
            // ribbonBarAssign
            // 
            this.ribbonBarAssign.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarAssign.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarAssign.BackgroundStyle.Class = "";
            this.ribbonBarAssign.ContainerControlProcessDialogKey = true;
            this.ribbonBarAssign.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarAssign.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnInvoiceAssign});
            this.ribbonBarAssign.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarAssign.Name = "ribbonBarAssign";
            this.ribbonBarAssign.Size = new System.Drawing.Size(71, 90);
            this.ribbonBarAssign.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarAssign.TabIndex = 0;
            this.ribbonBarAssign.Text = "ת��";
            // 
            // 
            // 
            this.ribbonBarAssign.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarAssign.TitleStyleMouseOver.Class = "";
            // 
            // btnInvoiceAssign
            // 
            this.btnInvoiceAssign.Image = ((System.Drawing.Image)(resources.GetObject("btnInvoiceAssign.Image")));
            this.btnInvoiceAssign.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInvoiceAssign.Name = "btnInvoiceAssign";
            this.btnInvoiceAssign.SubItemsExpandWidth = 14;
            this.btnInvoiceAssign.Text = "��Ʊ¼��";
            this.btnInvoiceAssign.Click += new System.EventHandler(this.InvoiceAssign);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBarCDA);
            this.ribbonPanel1.Controls.Add(this.ribbonBarCase);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1082, 93);
            // 
            // 
            // 
            this.ribbonPanel1.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.Class = "";
            this.ribbonPanel1.TabIndex = 9;
            this.ribbonPanel1.Visible = false;
            // 
            // ribbonBarCDA
            // 
            this.ribbonBarCDA.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarCDA.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCDA.BackgroundStyle.Class = "";
            this.ribbonBarCDA.ContainerControlProcessDialogKey = true;
            this.ribbonBarCDA.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarCDA.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCDANew,
            this.btnCDAQuery1});
            this.ribbonBarCDA.Location = new System.Drawing.Point(249, 0);
            this.ribbonBarCDA.Name = "ribbonBarCDA";
            this.ribbonBarCDA.Size = new System.Drawing.Size(208, 90);
            this.ribbonBarCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCDA.TabIndex = 1;
            this.ribbonBarCDA.Text = "���֪ͨ��";
            // 
            // 
            // 
            this.ribbonBarCDA.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCDA.TitleStyleMouseOver.Class = "";
            // 
            // btnCDANew
            // 
            this.btnCDANew.Image = ((System.Drawing.Image)(resources.GetObject("btnCDANew.Image")));
            this.btnCDANew.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnCDANew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCDANew.Name = "btnCDANew";
            this.btnCDANew.SubItemsExpandWidth = 14;
            this.btnCDANew.Text = "�������֪ͨ��";
            this.btnCDANew.Click += new System.EventHandler(this.NewCDA);
            // 
            // btnCDAQuery1
            // 
            this.btnCDAQuery1.Image = ((System.Drawing.Image)(resources.GetObject("btnCDAQuery1.Image")));
            this.btnCDAQuery1.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnCDAQuery1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCDAQuery1.Name = "btnCDAQuery1";
            this.btnCDAQuery1.SubItemsExpandWidth = 14;
            this.btnCDAQuery1.Text = "���֪ͨ���ѯ";
            this.btnCDAQuery1.Click += new System.EventHandler(this.QueryCDA);
            // 
            // ribbonBarCase
            // 
            this.ribbonBarCase.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarCase.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCase.BackgroundStyle.Class = "";
            this.ribbonBarCase.ContainerControlProcessDialogKey = true;
            this.ribbonBarCase.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarCase.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCaseNew,
            this.btnApplicationCaseQuery,
            this.btnCreditCoverNegQuery});
            this.ribbonBarCase.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarCase.Name = "ribbonBarCase";
            this.ribbonBarCase.Size = new System.Drawing.Size(246, 90);
            this.ribbonBarCase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCase.TabIndex = 0;
            this.ribbonBarCase.Text = "��������";
            // 
            // 
            // 
            this.ribbonBarCase.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCase.TitleStyleMouseOver.Class = "";
            // 
            // btnCaseNew
            // 
            this.btnCaseNew.Image = ((System.Drawing.Image)(resources.GetObject("btnCaseNew.Image")));
            this.btnCaseNew.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCaseNew.Name = "btnCaseNew";
            this.btnCaseNew.SubItemsExpandWidth = 14;
            this.btnCaseNew.Text = "�������밸";
            this.btnCaseNew.Click += new System.EventHandler(this.NewCase);
            // 
            // btnApplicationCaseQuery
            // 
            this.btnApplicationCaseQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnApplicationCaseQuery.Image")));
            this.btnApplicationCaseQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnApplicationCaseQuery.Name = "btnApplicationCaseQuery";
            this.btnApplicationCaseQuery.SubItemsExpandWidth = 14;
            this.btnApplicationCaseQuery.Text = "���밸��ѯ";
            this.btnApplicationCaseQuery.Click += new System.EventHandler(this.QueryApplicationCase);
            // 
            // btnCreditCoverNegQuery
            // 
            this.btnCreditCoverNegQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditCoverNegQuery.Image")));
            this.btnCreditCoverNegQuery.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCreditCoverNegQuery.Name = "btnCreditCoverNegQuery";
            this.btnCreditCoverNegQuery.SubItemsExpandWidth = 14;
            this.btnCreditCoverNegQuery.Text = "��������ѯ";
            this.btnCreditCoverNegQuery.Click += new System.EventHandler(this.QueryCreditCoverNegs);
            // 
            // ribbonPanelHelp
            // 
            this.ribbonPanelHelp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelHelp.Controls.Add(this.ribbonBarHelp);
            this.ribbonPanelHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelHelp.Location = new System.Drawing.Point(0, 59);
            this.ribbonPanelHelp.Name = "ribbonPanelHelp";
            this.ribbonPanelHelp.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelHelp.Size = new System.Drawing.Size(1082, 93);
            // 
            // 
            // 
            this.ribbonPanelHelp.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanelHelp.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanelHelp.StyleMouseOver.Class = "";
            this.ribbonPanelHelp.TabIndex = 6;
            this.ribbonPanelHelp.Visible = false;
            // 
            // ribbonBarHelp
            // 
            this.ribbonBarHelp.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarHelp.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarHelp.BackgroundStyle.Class = "";
            this.ribbonBarHelp.ContainerControlProcessDialogKey = true;
            this.ribbonBarHelp.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarHelp.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUserUpdate,
            this.btnCheckUpdate,
            this.btnBugReport,
            this.btnHelp});
            this.ribbonBarHelp.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarHelp.Name = "ribbonBarHelp";
            this.ribbonBarHelp.Size = new System.Drawing.Size(238, 90);
            this.ribbonBarHelp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarHelp.TabIndex = 0;
            this.ribbonBarHelp.Text = "����";
            // 
            // 
            // 
            this.ribbonBarHelp.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarHelp.TitleStyleMouseOver.Class = "";
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUserUpdate.Image")));
            this.btnUserUpdate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.SubItemsExpandWidth = 14;
            this.btnUserUpdate.Text = "������Ϣ";
            this.btnUserUpdate.Click += new System.EventHandler(this.DetailUser);
            // 
            // btnCheckUpdate
            // 
            this.btnCheckUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckUpdate.Image")));
            this.btnCheckUpdate.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnCheckUpdate.Name = "btnCheckUpdate";
            this.btnCheckUpdate.SubItemsExpandWidth = 14;
            this.btnCheckUpdate.Text = "������";
            this.btnCheckUpdate.Click += new System.EventHandler(this.CheckUpdate);
            // 
            // btnBugReport
            // 
            this.btnBugReport.Image = ((System.Drawing.Image)(resources.GetObject("btnBugReport.Image")));
            this.btnBugReport.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBugReport.Name = "btnBugReport";
            this.btnBugReport.SubItemsExpandWidth = 14;
            this.btnBugReport.Text = "���ⷴ��";
            this.btnBugReport.Click += new System.EventHandler(this.ReportBug);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnHelp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.SubItemsExpandWidth = 14;
            this.btnHelp.Text = "����";
            this.btnHelp.Click += new System.EventHandler(this.About);
            // 
            // itemInfoMgr
            // 
            this.itemInfoMgr.Checked = true;
            this.itemInfoMgr.Name = "itemInfoMgr";
            this.itemInfoMgr.Panel = this.ribbonPanelInfoMgr;
            this.itemInfoMgr.Text = "��Ϣ����";
            // 
            // ribbonTabItemCaseMgr
            // 
            this.ribbonTabItemCaseMgr.Name = "ribbonTabItemCaseMgr";
            this.ribbonTabItemCaseMgr.Panel = this.ribbonPanel1;
            this.ribbonTabItemCaseMgr.Text = "��������";
            // 
            // itemAccountsReceivableMgr
            // 
            this.itemAccountsReceivableMgr.Name = "itemAccountsReceivableMgr";
            this.itemAccountsReceivableMgr.Panel = this.ribbonPanelInvoiceMgr;
            this.itemAccountsReceivableMgr.Text = "Ӧ���˿����";
            // 
            // ribbonItemARImport
            // 
            this.ribbonItemARImport.Name = "ribbonItemARImport";
            this.ribbonItemARImport.Panel = this.ribbonPanelARImport;
            this.ribbonItemARImport.Text = "������";
            // 
            // ribbonTabItemCheck
            // 
            this.ribbonTabItemCheck.Name = "ribbonTabItemCheck";
            this.ribbonTabItemCheck.Panel = this.ribbonPanel2;
            this.ribbonTabItemCheck.Text = "����";
            this.ribbonTabItemCheck.Visible = false;
            // 
            // itemQuery
            // 
            this.itemQuery.Name = "itemQuery";
            this.itemQuery.Panel = this.ribbonPanelQuery;
            this.itemQuery.Text = "��ѯ";
            // 
            // itemReport
            // 
            this.itemReport.Name = "itemReport";
            this.itemReport.Panel = this.ribbonPanelReport;
            this.itemReport.Text = "����";
            // 
            // tabItemMigration
            // 
            this.tabItemMigration.Name = "tabItemMigration";
            this.tabItemMigration.Panel = this.ribbonPanelMigration;
            this.tabItemMigration.Text = "������ֲ";
            // 
            // ribbonTabItemSystem
            // 
            this.ribbonTabItemSystem.Name = "ribbonTabItemSystem";
            this.ribbonTabItemSystem.Panel = this.ribbonPanel3;
            this.ribbonTabItemSystem.Text = "ϵͳ����";
            // 
            // itemHelp
            // 
            this.itemHelp.Name = "itemHelp";
            this.itemHelp.Panel = this.ribbonPanelHelp;
            this.itemHelp.Text = "����";
            // 
            // menuLogo
            // 
            this.menuLogo.Image = ((System.Drawing.Image)(resources.GetObject("menuLogo.Image")));
            this.menuLogo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.menuLogo.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.menuLogo.Name = "menuLogo";
            // 
            // office2007StartButton
            // 
            this.office2007StartButton.AutoExpandOnClick = true;
            this.office2007StartButton.CanCustomize = false;
            this.office2007StartButton.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton.Image = ((System.Drawing.Image)(resources.GetObject("office2007StartButton.Image")));
            this.office2007StartButton.ImagePaddingHorizontal = 2;
            this.office2007StartButton.ImagePaddingVertical = 2;
            this.office2007StartButton.Name = "office2007StartButton";
            this.office2007StartButton.ShowSubItems = false;
            this.office2007StartButton.Text = "&File";
            this.office2007StartButton.Click += new System.EventHandler(this.MainPage);
            // 
            // cbStyleManager
            // 
            this.cbStyleManager.ComboWidth = 100;
            this.cbStyleManager.DropDownHeight = 106;
            this.cbStyleManager.Items.AddRange(new object[] {
            "Office2007Blue",
            "Office2007Silver",
            "Office2007Black",
            "Office2007VistaGlass",
            "Office2010Silver",
            "Windows7Blue"});
            this.cbStyleManager.Name = "cbStyleManager";
            this.cbStyleManager.WatermarkText = "������";
            this.cbStyleManager.SelectedIndexChanged += new System.EventHandler(this.ChangeStyle);
            // 
            // btnMainPage
            // 
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Text = "��������";
            this.btnMainPage.Click += new System.EventHandler(this.AlertPage);
            // 
            // qatCustomizeItem
            // 
            this.qatCustomizeItem.Name = "qatCustomizeItem";
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // statusbar
            // 
            this.statusbar.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.statusbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusbar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblCommandStatus,
            this.lblCurrentUser});
            this.statusbar.Location = new System.Drawing.Point(4, 707);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(1082, 21);
            this.statusbar.Stretch = true;
            this.statusbar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.statusbar.TabIndex = 0;
            this.statusbar.TabStop = false;
            // 
            // lblCommandStatus
            // 
            this.lblCommandStatus.Name = "lblCommandStatus";
            this.lblCommandStatus.Stretch = true;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Name = "lblCurrentUser";
            // 
            // ribbonDetailPanel
            // 
            this.ribbonDetailPanel.AutoSize = true;
            this.ribbonDetailPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonDetailPanel.Location = new System.Drawing.Point(4, 155);
            this.ribbonDetailPanel.Name = "ribbonDetailPanel";
            this.ribbonDetailPanel.Size = new System.Drawing.Size(1082, 552);
            // 
            // 
            // 
            this.ribbonDetailPanel.Style.Class = "RibbonClientPanel";
            // 
            // 
            // 
            this.ribbonDetailPanel.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonDetailPanel.StyleMouseOver.Class = "";
            this.ribbonDetailPanel.TabIndex = 2;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Text";
            this.notifyIcon.BalloonTipTitle = "Title";
            this.notifyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "EasyFactoring";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.ShowFromTray);
            // 
            // notifyMenu
            // 
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.menuItemHide,
            this.toolStripSeparator1,
            this.menuItemCheckAlert,
            this.toolStripSeparator2,
            this.menuItemExit});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(140, 104);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.Size = new System.Drawing.Size(139, 22);
            this.menuItemOpen.Text = "�ָ�����(&O)";
            this.menuItemOpen.Click += new System.EventHandler(this.ShowFromTray);
            // 
            // menuItemHide
            // 
            this.menuItemHide.Name = "menuItemHide";
            this.menuItemHide.Size = new System.Drawing.Size(139, 22);
            this.menuItemHide.Text = "���ش���(&H)";
            this.menuItemHide.Click += new System.EventHandler(this.HideInTray);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(136, 6);
            // 
            // menuItemCheckAlert
            // 
            this.menuItemCheckAlert.Name = "menuItemCheckAlert";
            this.menuItemCheckAlert.Size = new System.Drawing.Size(139, 22);
            this.menuItemCheckAlert.Text = "�������(&C)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(136, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(139, 22);
            this.menuItemExit.Text = "�˳�ϵͳ(&E)";
            this.menuItemExit.Click += new System.EventHandler(this.Exit);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // labelItem1
            // 
            this.labelItem1.BackColor = System.Drawing.Color.Transparent;
            this.labelItem1.Image = ((System.Drawing.Image)(resources.GetObject("labelItem1.Image")));
            this.labelItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Right;
            this.labelItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.labelItem1.Name = "labelItem1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 730);
            this.Controls.Add(this.ribbonDetailPanel);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.MainWindow_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanelARImport.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanelMigration.ResumeLayout(false);
            this.ribbonPanelReport.ResumeLayout(false);
            this.ribbonPanelQuery.ResumeLayout(false);
            this.ribbonPanelInfoMgr.ResumeLayout(false);
            this.ribbonPanelInvoiceMgr.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanelHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusbar)).EndInit();
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBarRefund;
        private DevComponents.DotNetBar.ButtonItem btnBuyerRefund;
        private DevComponents.DotNetBar.ButtonItem btnSellerRefund;
        private DevComponents.DotNetBar.ButtonItem btnFlawResolve;
        private DevComponents.DotNetBar.ButtonItem btnSendLeger;
        private DevComponents.DotNetBar.ButtonItem btnAssignImportNew;
        private DevComponents.DotNetBar.ButtonItem btnCreditNoteQuery;
        private DevComponents.DotNetBar.ButtonItem btnFactorCommissionStat;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.LabelItem menuLogo;
    }
}
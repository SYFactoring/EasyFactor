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
		#region Fields (133) 

        private DevComponents.DotNetBar.ButtonItem btnApplicationCaseQuery;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.ButtonItem btnARAssignReport;
        private DevComponents.DotNetBar.ButtonItem btnAssignCheck;
        private DevComponents.DotNetBar.ButtonItem btnBuyerPayment;
        private DevComponents.DotNetBar.ButtonItem btnCaseNew;
        private DevComponents.DotNetBar.ButtonItem btnCaseQuery;
        private DevComponents.DotNetBar.ButtonItem btnCDACheck;
        private DevComponents.DotNetBar.ButtonItem btnCDAImport;
        private DevComponents.DotNetBar.ButtonItem btnCDANew;
        private DevComponents.DotNetBar.ButtonItem btnCDAQuery;
        private DevComponents.DotNetBar.ButtonItem btnCDAQuery1;
        private DevComponents.DotNetBar.ButtonItem btnCDAReport;
        private DevComponents.DotNetBar.ButtonItem btnClientCreditLineImport;
        private DevComponents.DotNetBar.ButtonItem btnClientImport;
        private DevComponents.DotNetBar.ButtonItem btnClientMgr;
        private DevComponents.DotNetBar.ButtonItem btnClientNew;
        private DevComponents.DotNetBar.ButtonItem btnClientQuery;
        private DevComponents.DotNetBar.ButtonItem btnClientReviewImport;
        private DevComponents.DotNetBar.ButtonItem btnClinetCreditLineQuery;
        private DevComponents.DotNetBar.ButtonItem btnContractImport;
        private DevComponents.DotNetBar.ButtonItem btnContractQuery;
        private DevComponents.DotNetBar.ButtonItem btnCreditCoverNegQuery;
        private DevComponents.DotNetBar.ButtonItem btnCreditCoverNegQuery2;
        private DevComponents.DotNetBar.ButtonItem btnCreditNotePayment;
        private DevComponents.DotNetBar.ButtonItem btnDepartmentImport;
        private DevComponents.DotNetBar.ButtonItem btnDepartMgr;
        private DevComponents.DotNetBar.ButtonItem btnDeptQuery;
        private DevComponents.DotNetBar.ButtonItem btnDispute;
        private DevComponents.DotNetBar.ButtonItem btnExample1;
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
        private DevComponents.DotNetBar.ButtonItem btnFinanceCheck;
        private DevComponents.DotNetBar.ButtonItem btnFinanceReport;
        private DevComponents.DotNetBar.ButtonItem btnFlawReport;
        private DevComponents.DotNetBar.ButtonItem btnFlawResolve;
        private DevComponents.DotNetBar.ButtonItem btnGroupCreditLineQuery;
        private DevComponents.DotNetBar.ButtonItem btnGuaranteePayment;
        private DevComponents.DotNetBar.ButtonItem btnHelp;
        private DevComponents.DotNetBar.ButtonItem btnIndirectPayment;
        private DevComponents.DotNetBar.ButtonItem btnInvoiceAssign;
        private DevComponents.DotNetBar.ButtonItem btnInvoiceFinance;
        private DevComponents.DotNetBar.ButtonItem btnInvoiceQuery;
        private DevComponents.DotNetBar.ButtonItem btnInvoicesImport;
        private DevComponents.DotNetBar.ButtonItem btnLeger;
        private DevComponents.DotNetBar.ButtonItem btnLocalCaseImport;
        private DevComponents.DotNetBar.ButtonItem btnMainPage;
        private DevComponents.DotNetBar.ButtonItem btnOverDueQuery;
        private DevComponents.DotNetBar.ButtonItem btnPaymentCheck;
        private DevComponents.DotNetBar.ButtonItem btnQueryClientDominate;
        private DevComponents.DotNetBar.ButtonItem btnQueryClientExport;
        private DevComponents.DotNetBar.ButtonItem btnQueryClientImport;
        private DevComponents.DotNetBar.ButtonItem btnReassignment;
        private DevComponents.DotNetBar.ButtonItem btnRefundCheck;
        private DevComponents.DotNetBar.ButtonItem btnSellerRefund;
        private DevComponents.DotNetBar.ButtonItem btnStartClose;
        private DevComponents.DotNetBar.ButtonItem btnStartExit;
        private DevComponents.DotNetBar.ButtonItem btnStartNew;
        private DevComponents.DotNetBar.ButtonItem btnStartOpen;
        private DevComponents.DotNetBar.ButtonItem btnStartOptions;
        private DevComponents.DotNetBar.ButtonItem btnStartPrint;
        private DevComponents.DotNetBar.ButtonItem btnStartSave;
        private DevComponents.DotNetBar.ButtonItem btnStartShare;
        private DevComponents.DotNetBar.ButtonItem btnUserImport;
        private DevComponents.DotNetBar.ButtonItem btnUserMgr;
        private DevComponents.DotNetBar.ButtonItem btnUserUpdate;
        private DevComponents.DotNetBar.ButtonItem buttonItemInterCaseImport;
        private DevComponents.DotNetBar.ComboBoxItem cbStyleManager;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer;
        private DevComponents.DotNetBar.RibbonTabItem itemAccountsReceivableMgr;
        private DevComponents.DotNetBar.ItemContainer itemContainerClientQuery;
        private DevComponents.DotNetBar.ItemContainer itemContainerInner;
        private DevComponents.DotNetBar.ItemContainer itemContainerStartBottom;
        private DevComponents.DotNetBar.ItemContainer itemContainerStartLeft;
        private DevComponents.DotNetBar.ItemContainer itemContainerStartOuter;
        private DevComponents.DotNetBar.RibbonTabItem itemHelp;
        private DevComponents.DotNetBar.RibbonTabItem itemInfoMgr;
        private DevComponents.DotNetBar.RibbonTabItem itemQuery;
        private DevComponents.DotNetBar.RibbonTabItem itemReport;
        private DevComponents.DotNetBar.LabelItem lblCommandStatus;
        private DevComponents.DotNetBar.LabelItem lblCurrentUser;
        private DevComponents.DotNetBar.LabelItem lblRecentDocs;
        private DevComponents.DotNetBar.Controls.ReflectionLabel logoLabel;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem;
        private DevComponents.DotNetBar.RibbonBar ribbonBarAnalysisReport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarAssign;
        private DevComponents.DotNetBar.RibbonBar ribbonBarBasicInfoImport;
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
        private DevComponents.DotNetBar.RibbonBar ribbonBarSystem;
        private DevComponents.DotNetBar.RibbonBar ribbonBarTransactionReport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarUserMgr;
        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonDetailPanel;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
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

		#endregion Fields 

		#region Methods (1) 

		// Protected Methods (1) 

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

		#endregion Methods 



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
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
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarCDA = new DevComponents.DotNetBar.RibbonBar();
            this.btnCDANew = new DevComponents.DotNetBar.ButtonItem();
            this.btnCDAQuery1 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarCase = new DevComponents.DotNetBar.RibbonBar();
            this.btnCaseNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnApplicationCaseQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreditCoverNegQuery = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelInvoiceMgr = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarDispute = new DevComponents.DotNetBar.RibbonBar();
            this.btnDispute = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarPayment = new DevComponents.DotNetBar.RibbonBar();
            this.btnBuyerPayment = new DevComponents.DotNetBar.ButtonItem();
            this.btnIndirectPayment = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuaranteePayment = new DevComponents.DotNetBar.ButtonItem();
            this.btnReassignment = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreditNotePayment = new DevComponents.DotNetBar.ButtonItem();
            this.btnSellerRefund = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarFinance = new DevComponents.DotNetBar.RibbonBar();
            this.btnInvoiceFinance = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarAssign = new DevComponents.DotNetBar.RibbonBar();
            this.btnInvoiceAssign = new DevComponents.DotNetBar.ButtonItem();
            this.btnFlawResolve = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarInvoiceCheck = new DevComponents.DotNetBar.RibbonBar();
            this.btnCDACheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnAssignCheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnFinanceCheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnPaymentCheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefundCheck = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelQuery = new DevComponents.DotNetBar.RibbonPanel();
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
            this.ribbonPanelReport = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarAnalysisReport = new DevComponents.DotNetBar.RibbonBar();
            this.btnCaseStat = new DevComponents.DotNetBar.ButtonItem();
            this.btnDepartmentStat = new DevComponents.DotNetBar.ButtonItem();
            this.btnLocationStat = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarTransactionReport = new DevComponents.DotNetBar.RibbonBar();
            this.btnARAssignReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFinanceReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFeeReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFlawReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnCDAReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnLeger = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelMigration = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarInvoiceImport = new DevComponents.DotNetBar.RibbonBar();
            this.btnInvoicesImport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarCreditLineImport = new DevComponents.DotNetBar.RibbonBar();
            this.btnClientCreditLineImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorCreditLineImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnCDAImport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarCaseImport = new DevComponents.DotNetBar.RibbonBar();
            this.btnLocalCaseImport = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemInterCaseImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnContractImport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarBasicInfoImport = new DevComponents.DotNetBar.RibbonBar();
            this.btnClientImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnClientReviewImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorImport2 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarUserMgr = new DevComponents.DotNetBar.RibbonBar();
            this.btnUserMgr = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarSystem = new DevComponents.DotNetBar.RibbonBar();
            this.btnUserImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnDepartmentImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnExchangeRateImport = new DevComponents.DotNetBar.ButtonItem();
            this.btnCommissionCompute = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelHelp = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarHelp = new DevComponents.DotNetBar.RibbonBar();
            this.btnUserUpdate = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelp = new DevComponents.DotNetBar.ButtonItem();
            this.itemInfoMgr = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemCaseMgr = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemAccountsReceivableMgr = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemCheck = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemQuery = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemReport = new DevComponents.DotNetBar.RibbonTabItem();
            this.tabItemMigration = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemSystem = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemHelp = new DevComponents.DotNetBar.RibbonTabItem();
            this.office2007StartButton = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainerStartOuter = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainerInner = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainerStartLeft = new DevComponents.DotNetBar.ItemContainer();
            this.btnStartNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnStartOpen = new DevComponents.DotNetBar.ButtonItem();
            this.btnStartSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnStartShare = new DevComponents.DotNetBar.ButtonItem();
            this.btnStartPrint = new DevComponents.DotNetBar.ButtonItem();
            this.btnStartClose = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer = new DevComponents.DotNetBar.GalleryContainer();
            this.lblRecentDocs = new DevComponents.DotNetBar.LabelItem();
            this.btnExample1 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainerStartBottom = new DevComponents.DotNetBar.ItemContainer();
            this.btnStartOptions = new DevComponents.DotNetBar.ButtonItem();
            this.btnStartExit = new DevComponents.DotNetBar.ButtonItem();
            this.cbStyleManager = new DevComponents.DotNetBar.ComboBoxItem();
            this.btnMainPage = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager = new DevComponents.DotNetBar.StyleManager();
            this.statusbar = new DevComponents.DotNetBar.Bar();
            this.lblCommandStatus = new DevComponents.DotNetBar.LabelItem();
            this.lblCurrentUser = new DevComponents.DotNetBar.LabelItem();
            this.ribbonDetailPanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.logoLabel = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btnPoolFinance = new DevComponents.DotNetBar.ButtonItem();
            this.btnPoolRefund = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl.SuspendLayout();
            this.ribbonPanelInfoMgr.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanelInvoiceMgr.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonPanelQuery.SuspendLayout();
            this.ribbonPanelReport.SuspendLayout();
            this.ribbonPanelMigration.SuspendLayout();
            this.ribbonPanel3.SuspendLayout();
            this.ribbonPanelHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusbar)).BeginInit();
            this.ribbonDetailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            // 
            // 
            // 
            this.ribbonControl.BackgroundStyle.Class = "";
            this.ribbonControl.CaptionVisible = true;
            this.ribbonControl.Controls.Add(this.ribbonPanelInvoiceMgr);
            this.ribbonControl.Controls.Add(this.ribbonPanelInfoMgr);
            this.ribbonControl.Controls.Add(this.ribbonPanel1);
            this.ribbonControl.Controls.Add(this.ribbonPanel2);
            this.ribbonControl.Controls.Add(this.ribbonPanelQuery);
            this.ribbonControl.Controls.Add(this.ribbonPanelReport);
            this.ribbonControl.Controls.Add(this.ribbonPanelMigration);
            this.ribbonControl.Controls.Add(this.ribbonPanel3);
            this.ribbonControl.Controls.Add(this.ribbonPanelHelp);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemInfoMgr,
            this.ribbonTabItemCaseMgr,
            this.itemAccountsReceivableMgr,
            this.ribbonTabItemCheck,
            this.itemQuery,
            this.itemReport,
            this.tabItemMigration,
            this.ribbonTabItemSystem,
            this.itemHelp});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton,
            this.cbStyleManager,
            this.btnMainPage,
            this.qatCustomizeItem});
            this.ribbonControl.Size = new System.Drawing.Size(1000, 154);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl.SystemText.MaximizeRibbonText = "菜单最大化";
            this.ribbonControl.SystemText.MinimizeRibbonText = "菜单最小化";
            this.ribbonControl.SystemText.QatCustomizeMenuLabel = "配置快捷工具栏";
            this.ribbonControl.SystemText.QatCustomizeText = "配置快捷工具栏...";
            this.ribbonControl.SystemText.QatDialogCaption = "配置快捷工具栏";
            this.ribbonControl.SystemText.QatDialogPlacementCheckbox = "将快捷工具栏置于菜单之下";
            this.ribbonControl.SystemText.QatPlaceAboveRibbonText = "将快捷工具栏置于菜单之上";
            this.ribbonControl.SystemText.QatPlaceBelowRibbonText = "将快捷工具栏置于菜单之下";
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabIndex = 0;
            // 
            // ribbonPanelInfoMgr
            // 
            this.ribbonPanelInfoMgr.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarExchange);
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarDepartment);
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarFactor);
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarClient);
            this.ribbonPanelInfoMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelInfoMgr.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelInfoMgr.Name = "ribbonPanelInfoMgr";
            this.ribbonPanelInfoMgr.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelInfoMgr.Size = new System.Drawing.Size(1000, 96);
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
            this.ribbonPanelInfoMgr.Visible = false;
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
            this.ribbonBarExchange.Location = new System.Drawing.Point(359, 0);
            this.ribbonBarExchange.Name = "ribbonBarExchange";
            this.ribbonBarExchange.Size = new System.Drawing.Size(71, 93);
            this.ribbonBarExchange.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarExchange.TabIndex = 0;
            this.ribbonBarExchange.Text = "汇率";
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
            this.btnExchangeQuery.Text = "汇率信息";
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
            this.ribbonBarDepartment.Location = new System.Drawing.Point(290, 0);
            this.ribbonBarDepartment.Name = "ribbonBarDepartment";
            this.ribbonBarDepartment.Size = new System.Drawing.Size(69, 93);
            this.ribbonBarDepartment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarDepartment.TabIndex = 2;
            this.ribbonBarDepartment.Text = "部门";
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
            this.btnDepartMgr.Name = "btnDepartMgr";
            this.btnDepartMgr.SubItemsExpandWidth = 14;
            this.btnDepartMgr.Text = "部门信息";
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
            this.ribbonBarFactor.Location = new System.Drawing.Point(135, 0);
            this.ribbonBarFactor.Name = "ribbonBarFactor";
            this.ribbonBarFactor.Size = new System.Drawing.Size(155, 93);
            this.ribbonBarFactor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarFactor.TabIndex = 1;
            this.ribbonBarFactor.Text = "合作机构";
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
            this.btnFactorMgr.Name = "btnFactorMgr";
            this.btnFactorMgr.SubItemsExpandWidth = 14;
            this.btnFactorMgr.Text = "机构信息";
            this.btnFactorMgr.Click += new System.EventHandler(this.QueryFactors);
            // 
            // btnFactorNew
            // 
            this.btnFactorNew.Name = "btnFactorNew";
            this.btnFactorNew.SubItemsExpandWidth = 14;
            this.btnFactorNew.Text = "新增合作机构";
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
            this.ribbonBarClient.Size = new System.Drawing.Size(132, 93);
            this.ribbonBarClient.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarClient.TabIndex = 0;
            this.ribbonBarClient.Text = "客户";
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
            this.btnClientMgr.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnClientMgr.Name = "btnClientMgr";
            this.btnClientMgr.SubItemsExpandWidth = 14;
            this.btnClientMgr.Text = "客户信息";
            this.btnClientMgr.Click += new System.EventHandler(this.QueryClients);
            // 
            // btnClientNew
            // 
            this.btnClientNew.Name = "btnClientNew";
            this.btnClientNew.SubItemsExpandWidth = 14;
            this.btnClientNew.Text = "新增客户";
            this.btnClientNew.Click += new System.EventHandler(this.NewClient);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBarCDA);
            this.ribbonPanel1.Controls.Add(this.ribbonBarCase);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1000, 96);
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
            this.ribbonBarCDA.Location = new System.Drawing.Point(243, 0);
            this.ribbonBarCDA.Name = "ribbonBarCDA";
            this.ribbonBarCDA.Size = new System.Drawing.Size(204, 93);
            this.ribbonBarCDA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCDA.TabIndex = 7;
            this.ribbonBarCDA.Text = "额度通知书";
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
            this.btnCDANew.Name = "btnCDANew";
            this.btnCDANew.SubItemsExpandWidth = 14;
            this.btnCDANew.Text = "制作额度通知书";
            this.btnCDANew.Click += new System.EventHandler(this.NewCDA);
            // 
            // btnCDAQuery1
            // 
            this.btnCDAQuery1.Name = "btnCDAQuery1";
            this.btnCDAQuery1.SubItemsExpandWidth = 14;
            this.btnCDAQuery1.Text = "额度通知书查询";
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
            this.ribbonBarCase.Size = new System.Drawing.Size(240, 93);
            this.ribbonBarCase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCase.TabIndex = 6;
            this.ribbonBarCase.Text = "案件申请";
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
            this.btnCaseNew.Name = "btnCaseNew";
            this.btnCaseNew.SubItemsExpandWidth = 14;
            this.btnCaseNew.Text = "新增申请案";
            this.btnCaseNew.Click += new System.EventHandler(this.NewCase);
            // 
            // btnApplicationCaseQuery
            // 
            this.btnApplicationCaseQuery.Name = "btnApplicationCaseQuery";
            this.btnApplicationCaseQuery.SubItemsExpandWidth = 14;
            this.btnApplicationCaseQuery.Text = "申请案查询";
            this.btnApplicationCaseQuery.Click += new System.EventHandler(this.QueryApplicationCase);
            // 
            // btnCreditCoverNegQuery
            // 
            this.btnCreditCoverNegQuery.Name = "btnCreditCoverNegQuery";
            this.btnCreditCoverNegQuery.SubItemsExpandWidth = 14;
            this.btnCreditCoverNegQuery.Text = "额度申请查询";
            this.btnCreditCoverNegQuery.Click += new System.EventHandler(this.QueryCreditCoverNegs);
            // 
            // ribbonPanelInvoiceMgr
            // 
            this.ribbonPanelInvoiceMgr.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarDispute);
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarPayment);
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarFinance);
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarAssign);
            this.ribbonPanelInvoiceMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelInvoiceMgr.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelInvoiceMgr.Name = "ribbonPanelInvoiceMgr";
            this.ribbonPanelInvoiceMgr.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelInvoiceMgr.Size = new System.Drawing.Size(1000, 96);
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
            this.btnDispute});
            this.ribbonBarDispute.Location = new System.Drawing.Point(718, 0);
            this.ribbonBarDispute.Name = "ribbonBarDispute";
            this.ribbonBarDispute.Size = new System.Drawing.Size(69, 93);
            this.ribbonBarDispute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarDispute.TabIndex = 6;
            this.ribbonBarDispute.Text = "商纠";
            // 
            // 
            // 
            this.ribbonBarDispute.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarDispute.TitleStyleMouseOver.Class = "";
            // 
            // btnDispute
            // 
            this.btnDispute.Name = "btnDispute";
            this.btnDispute.SubItemsExpandWidth = 14;
            this.btnDispute.Text = "商纠处理";
            this.btnDispute.Click += new System.EventHandler(this.DisputeResolve);
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
            this.btnCreditNotePayment,
            this.btnSellerRefund,
            this.btnPoolRefund});
            this.ribbonBarPayment.Location = new System.Drawing.Point(267, 0);
            this.ribbonBarPayment.Name = "ribbonBarPayment";
            this.ribbonBarPayment.Size = new System.Drawing.Size(451, 93);
            this.ribbonBarPayment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarPayment.TabIndex = 0;
            this.ribbonBarPayment.Text = "销帐";
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
            this.btnBuyerPayment.Text = "买方付款";
            this.btnBuyerPayment.Click += new System.EventHandler(this.InvoiceBuyerPayment);
            // 
            // btnIndirectPayment
            // 
            this.btnIndirectPayment.Name = "btnIndirectPayment";
            this.btnIndirectPayment.SubItemsExpandWidth = 14;
            this.btnIndirectPayment.Text = "间接付款";
            this.btnIndirectPayment.Click += new System.EventHandler(this.InvoiceIndirectPayment);
            // 
            // btnGuaranteePayment
            // 
            this.btnGuaranteePayment.Name = "btnGuaranteePayment";
            this.btnGuaranteePayment.SubItemsExpandWidth = 14;
            this.btnGuaranteePayment.Text = "担保付款";
            this.btnGuaranteePayment.Click += new System.EventHandler(this.InvoiceGuaranteePayment);
            // 
            // btnReassignment
            // 
            this.btnReassignment.Name = "btnReassignment";
            this.btnReassignment.SubItemsExpandWidth = 14;
            this.btnReassignment.Text = "卖方回购";
            this.btnReassignment.Click += new System.EventHandler(this.InvoiceSellerReassign);
            // 
            // btnCreditNotePayment
            // 
            this.btnCreditNotePayment.Name = "btnCreditNotePayment";
            this.btnCreditNotePayment.SubItemsExpandWidth = 14;
            this.btnCreditNotePayment.Text = "贷项通知";
            this.btnCreditNotePayment.Click += new System.EventHandler(this.CreditNotePayment);
            // 
            // btnSellerRefund
            // 
            this.btnSellerRefund.Image = ((System.Drawing.Image)(resources.GetObject("btnSellerRefund.Image")));
            this.btnSellerRefund.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSellerRefund.Name = "btnSellerRefund";
            this.btnSellerRefund.SubItemsExpandWidth = 14;
            this.btnSellerRefund.Text = "卖方还款";
            this.btnSellerRefund.Click += new System.EventHandler(this.InvoiceSellerRefund);
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
            this.btnInvoiceFinance,
            this.btnPoolFinance});
            this.ribbonBarFinance.Location = new System.Drawing.Point(135, 0);
            this.ribbonBarFinance.Name = "ribbonBarFinance";
            this.ribbonBarFinance.Size = new System.Drawing.Size(132, 93);
            this.ribbonBarFinance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarFinance.TabIndex = 5;
            this.ribbonBarFinance.Text = "融资";
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
            this.btnInvoiceFinance.Text = "预付款支用";
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
            this.btnInvoiceAssign,
            this.btnFlawResolve});
            this.ribbonBarAssign.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarAssign.Name = "ribbonBarAssign";
            this.ribbonBarAssign.Size = new System.Drawing.Size(132, 93);
            this.ribbonBarAssign.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarAssign.TabIndex = 4;
            this.ribbonBarAssign.Text = "转让";
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
            this.btnInvoiceAssign.Text = "发票录入";
            this.btnInvoiceAssign.Click += new System.EventHandler(this.InvoiceAssign);
            // 
            // btnFlawResolve
            // 
            this.btnFlawResolve.Name = "btnFlawResolve";
            this.btnFlawResolve.SubItemsExpandWidth = 14;
            this.btnFlawResolve.Text = "瑕疵解除";
            this.btnFlawResolve.Click += new System.EventHandler(this.FlawResolve);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel2.Controls.Add(this.ribbonBarInvoiceCheck);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(1000, 96);
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
            this.ribbonBarInvoiceCheck.Size = new System.Drawing.Size(350, 93);
            this.ribbonBarInvoiceCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarInvoiceCheck.TabIndex = 4;
            this.ribbonBarInvoiceCheck.Text = "复核";
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
            this.btnCDACheck.Name = "btnCDACheck";
            this.btnCDACheck.SubItemsExpandWidth = 14;
            this.btnCDACheck.Text = "额度通知书审核";
            this.btnCDACheck.Click += new System.EventHandler(this.CheckCDA);
            // 
            // btnAssignCheck
            // 
            this.btnAssignCheck.Name = "btnAssignCheck";
            this.btnAssignCheck.SubItemsExpandWidth = 14;
            this.btnAssignCheck.Text = "转让复核";
            this.btnAssignCheck.Click += new System.EventHandler(this.CheckAssignBatch);
            // 
            // btnFinanceCheck
            // 
            this.btnFinanceCheck.Name = "btnFinanceCheck";
            this.btnFinanceCheck.SubItemsExpandWidth = 14;
            this.btnFinanceCheck.Text = "融资复核";
            this.btnFinanceCheck.Click += new System.EventHandler(this.CheckFinanceBatch);
            // 
            // btnPaymentCheck
            // 
            this.btnPaymentCheck.Name = "btnPaymentCheck";
            this.btnPaymentCheck.SubItemsExpandWidth = 14;
            this.btnPaymentCheck.Text = "付款复核";
            this.btnPaymentCheck.Click += new System.EventHandler(this.CheckPaymentBatch);
            // 
            // btnRefundCheck
            // 
            this.btnRefundCheck.Name = "btnRefundCheck";
            this.btnRefundCheck.SubItemsExpandWidth = 14;
            this.btnRefundCheck.Text = "还款复核";
            this.btnRefundCheck.Click += new System.EventHandler(this.CheckRefundBatch);
            // 
            // ribbonPanelQuery
            // 
            this.ribbonPanelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelQuery.Controls.Add(this.ribbonBarBatchQuery);
            this.ribbonPanelQuery.Controls.Add(this.ribbonBarCaseQuery);
            this.ribbonPanelQuery.Controls.Add(this.ribbonBarCreditLineQuery);
            this.ribbonPanelQuery.Controls.Add(this.ribbonBarClientQuery);
            this.ribbonPanelQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelQuery.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelQuery.Name = "ribbonPanelQuery";
            this.ribbonPanelQuery.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelQuery.Size = new System.Drawing.Size(1000, 96);
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
            this.ribbonBarBatchQuery.Location = new System.Drawing.Point(732, 0);
            this.ribbonBarBatchQuery.Name = "ribbonBarBatchQuery";
            this.ribbonBarBatchQuery.Size = new System.Drawing.Size(152, 93);
            this.ribbonBarBatchQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarBatchQuery.TabIndex = 3;
            this.ribbonBarBatchQuery.Text = "批次查询";
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
            this.btnAssignBatchQuery.Name = "btnAssignBatchQuery";
            this.btnAssignBatchQuery.SubItemsExpandWidth = 14;
            this.btnAssignBatchQuery.Text = "转让";
            this.btnAssignBatchQuery.Click += new System.EventHandler(this.QueryAssignBatch);
            // 
            // btnFinanceBatchQuery
            // 
            this.btnFinanceBatchQuery.Name = "btnFinanceBatchQuery";
            this.btnFinanceBatchQuery.SubItemsExpandWidth = 14;
            this.btnFinanceBatchQuery.Text = "融资";
            this.btnFinanceBatchQuery.Click += new System.EventHandler(this.QueryFinanceBatch);
            // 
            // btnPaymentBatchQuery
            // 
            this.btnPaymentBatchQuery.Name = "btnPaymentBatchQuery";
            this.btnPaymentBatchQuery.SubItemsExpandWidth = 14;
            this.btnPaymentBatchQuery.Text = "付款";
            this.btnPaymentBatchQuery.Click += new System.EventHandler(this.QueryPaymentBatch);
            // 
            // btnRefundBatchQuery
            // 
            this.btnRefundBatchQuery.Name = "btnRefundBatchQuery";
            this.btnRefundBatchQuery.SubItemsExpandWidth = 14;
            this.btnRefundBatchQuery.Text = "还款";
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
            this.btnOverDueQuery});
            this.ribbonBarCaseQuery.Location = new System.Drawing.Point(494, 0);
            this.ribbonBarCaseQuery.Name = "ribbonBarCaseQuery";
            this.ribbonBarCaseQuery.Size = new System.Drawing.Size(238, 93);
            this.ribbonBarCaseQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCaseQuery.TabIndex = 2;
            this.ribbonBarCaseQuery.Text = "案子查询";
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
            this.btnContractQuery.Name = "btnContractQuery";
            this.btnContractQuery.SubItemsExpandWidth = 14;
            this.btnContractQuery.Text = "保理合同";
            this.btnContractQuery.Click += new System.EventHandler(this.QueryContract);
            // 
            // btnCaseQuery
            // 
            this.btnCaseQuery.Name = "btnCaseQuery";
            this.btnCaseQuery.SubItemsExpandWidth = 14;
            this.btnCaseQuery.Text = "案件";
            this.btnCaseQuery.Click += new System.EventHandler(this.QueryCase);
            // 
            // btnCreditCoverNegQuery2
            // 
            this.btnCreditCoverNegQuery2.Name = "btnCreditCoverNegQuery2";
            this.btnCreditCoverNegQuery2.SubItemsExpandWidth = 14;
            this.btnCreditCoverNegQuery2.Text = "额度申请";
            this.btnCreditCoverNegQuery2.Click += new System.EventHandler(this.QueryCreditCoverNegs);
            // 
            // btnInvoiceQuery
            // 
            this.btnInvoiceQuery.Name = "btnInvoiceQuery";
            this.btnInvoiceQuery.SubItemsExpandWidth = 14;
            this.btnInvoiceQuery.Text = "发票";
            this.btnInvoiceQuery.Click += new System.EventHandler(this.QueryInvoice);
            // 
            // btnOverDueQuery
            // 
            this.btnOverDueQuery.Name = "btnOverDueQuery";
            this.btnOverDueQuery.SubItemsExpandWidth = 14;
            this.btnOverDueQuery.Text = "逾期";
            this.btnOverDueQuery.Click += new System.EventHandler(this.QueryOverDue);
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
            this.ribbonBarCreditLineQuery.Location = new System.Drawing.Point(205, 0);
            this.ribbonBarCreditLineQuery.Name = "ribbonBarCreditLineQuery";
            this.ribbonBarCreditLineQuery.Size = new System.Drawing.Size(289, 93);
            this.ribbonBarCreditLineQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCreditLineQuery.TabIndex = 1;
            this.ribbonBarCreditLineQuery.Text = "额度查询";
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
            this.btnClinetCreditLineQuery.Name = "btnClinetCreditLineQuery";
            this.btnClinetCreditLineQuery.SubItemsExpandWidth = 14;
            this.btnClinetCreditLineQuery.Text = "客户额度";
            this.btnClinetCreditLineQuery.Click += new System.EventHandler(this.QueryClientCreditLine);
            // 
            // btnGroupCreditLineQuery
            // 
            this.btnGroupCreditLineQuery.Name = "btnGroupCreditLineQuery";
            this.btnGroupCreditLineQuery.SubItemsExpandWidth = 14;
            this.btnGroupCreditLineQuery.Text = "集团额度";
            this.btnGroupCreditLineQuery.Click += new System.EventHandler(this.QueryClientGroupCreditLine);
            // 
            // btnFactorCreditLine
            // 
            this.btnFactorCreditLine.Name = "btnFactorCreditLine";
            this.btnFactorCreditLine.SubItemsExpandWidth = 14;
            this.btnFactorCreditLine.Text = "合作机构额度";
            this.btnFactorCreditLine.Click += new System.EventHandler(this.QueryFactorCreditLine);
            // 
            // btnCDAQuery
            // 
            this.btnCDAQuery.Name = "btnCDAQuery";
            this.btnCDAQuery.SubItemsExpandWidth = 14;
            this.btnCDAQuery.Text = "额度通知书";
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
            this.btnDeptQuery});
            this.ribbonBarClientQuery.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarClientQuery.Name = "ribbonBarClientQuery";
            this.ribbonBarClientQuery.Size = new System.Drawing.Size(202, 93);
            this.ribbonBarClientQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarClientQuery.TabIndex = 0;
            this.ribbonBarClientQuery.Text = "客户查询";
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
            this.btnClientQuery.Name = "btnClientQuery";
            this.btnClientQuery.SubItemsExpandWidth = 14;
            this.btnClientQuery.Text = "客户";
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
            this.btnQueryClientExport.Text = "出口保理";
            this.btnQueryClientExport.Click += new System.EventHandler(this.QueryClientExport);
            // 
            // btnQueryClientImport
            // 
            this.btnQueryClientImport.Name = "btnQueryClientImport";
            this.btnQueryClientImport.Text = "进口保理";
            this.btnQueryClientImport.Click += new System.EventHandler(this.QueryClientImport);
            // 
            // btnQueryClientDominate
            // 
            this.btnQueryClientDominate.Name = "btnQueryClientDominate";
            this.btnQueryClientDominate.Text = "国内保理";
            this.btnQueryClientDominate.Click += new System.EventHandler(this.QueryClientDominate);
            // 
            // btnFactorsQuery
            // 
            this.btnFactorsQuery.Name = "btnFactorsQuery";
            this.btnFactorsQuery.SubItemsExpandWidth = 14;
            this.btnFactorsQuery.Text = "合作机构";
            this.btnFactorsQuery.Click += new System.EventHandler(this.QueryFactors);
            // 
            // btnDeptQuery
            // 
            this.btnDeptQuery.Name = "btnDeptQuery";
            this.btnDeptQuery.SubItemsExpandWidth = 14;
            this.btnDeptQuery.Text = "部门";
            this.btnDeptQuery.Click += new System.EventHandler(this.QueryDepartments);
            // 
            // ribbonPanelReport
            // 
            this.ribbonPanelReport.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelReport.Controls.Add(this.ribbonBarAnalysisReport);
            this.ribbonPanelReport.Controls.Add(this.ribbonBarTransactionReport);
            this.ribbonPanelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelReport.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelReport.Name = "ribbonPanelReport";
            this.ribbonPanelReport.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelReport.Size = new System.Drawing.Size(1000, 96);
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
            this.btnLocationStat});
            this.ribbonBarAnalysisReport.Location = new System.Drawing.Point(527, 0);
            this.ribbonBarAnalysisReport.Name = "ribbonBarAnalysisReport";
            this.ribbonBarAnalysisReport.Size = new System.Drawing.Size(191, 93);
            this.ribbonBarAnalysisReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarAnalysisReport.TabIndex = 1;
            this.ribbonBarAnalysisReport.Text = "统计分析";
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
            this.btnCaseStat.Name = "btnCaseStat";
            this.btnCaseStat.SubItemsExpandWidth = 14;
            this.btnCaseStat.Text = "案件统计";
            this.btnCaseStat.Click += new System.EventHandler(this.StatCase);
            // 
            // btnDepartmentStat
            // 
            this.btnDepartmentStat.Name = "btnDepartmentStat";
            this.btnDepartmentStat.SubItemsExpandWidth = 14;
            this.btnDepartmentStat.Text = "分部统计";
            this.btnDepartmentStat.Click += new System.EventHandler(this.StatDepartment);
            // 
            // btnLocationStat
            // 
            this.btnLocationStat.Name = "btnLocationStat";
            this.btnLocationStat.SubItemsExpandWidth = 14;
            this.btnLocationStat.Text = "区域统计";
            this.btnLocationStat.Click += new System.EventHandler(this.StatLocation);
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
            this.btnLeger});
            this.ribbonBarTransactionReport.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarTransactionReport.Name = "ribbonBarTransactionReport";
            this.ribbonBarTransactionReport.Size = new System.Drawing.Size(524, 93);
            this.ribbonBarTransactionReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarTransactionReport.TabIndex = 0;
            this.ribbonBarTransactionReport.Text = "业务报表";
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
            this.btnARAssignReport.Text = "应收账款转让明细表";
            this.btnARAssignReport.Click += new System.EventHandler(this.ReportARPayment);
            // 
            // btnFinanceReport
            // 
            this.btnFinanceReport.Name = "btnFinanceReport";
            this.btnFinanceReport.SubItemsExpandWidth = 14;
            this.btnFinanceReport.Text = "可融资账款明细表";
            this.btnFinanceReport.Click += new System.EventHandler(this.ReportFinance);
            // 
            // btnFeeReport
            // 
            this.btnFeeReport.Name = "btnFeeReport";
            this.btnFeeReport.SubItemsExpandWidth = 14;
            this.btnFeeReport.Text = "保理费用明细表";
            this.btnFeeReport.Click += new System.EventHandler(this.ReportFee);
            // 
            // btnFlawReport
            // 
            this.btnFlawReport.Name = "btnFlawReport";
            this.btnFlawReport.SubItemsExpandWidth = 14;
            this.btnFlawReport.Text = "瑕疵通知书";
            this.btnFlawReport.Click += new System.EventHandler(this.ReportInvoiceFlaw);
            // 
            // btnCDAReport
            // 
            this.btnCDAReport.Name = "btnCDAReport";
            this.btnCDAReport.SubItemsExpandWidth = 14;
            this.btnCDAReport.Text = "额度通知书";
            this.btnCDAReport.Click += new System.EventHandler(this.ReportCDA);
            // 
            // btnLeger
            // 
            this.btnLeger.Name = "btnLeger";
            this.btnLeger.SubItemsExpandWidth = 14;
            this.btnLeger.Text = "台帐";
            this.btnLeger.Click += new System.EventHandler(this.ReportLeger);
            // 
            // ribbonPanelMigration
            // 
            this.ribbonPanelMigration.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelMigration.Controls.Add(this.ribbonBarInvoiceImport);
            this.ribbonPanelMigration.Controls.Add(this.ribbonBarCreditLineImport);
            this.ribbonPanelMigration.Controls.Add(this.ribbonBarCaseImport);
            this.ribbonPanelMigration.Controls.Add(this.ribbonBarBasicInfoImport);
            this.ribbonPanelMigration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelMigration.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelMigration.Name = "ribbonPanelMigration";
            this.ribbonPanelMigration.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelMigration.Size = new System.Drawing.Size(1000, 96);
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
            this.ribbonBarInvoiceImport.Location = new System.Drawing.Point(712, 0);
            this.ribbonBarInvoiceImport.Name = "ribbonBarInvoiceImport";
            this.ribbonBarInvoiceImport.Size = new System.Drawing.Size(44, 93);
            this.ribbonBarInvoiceImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarInvoiceImport.TabIndex = 3;
            this.ribbonBarInvoiceImport.Text = "台帐导入";
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
            this.btnInvoicesImport.Name = "btnInvoicesImport";
            this.btnInvoicesImport.SubItemsExpandWidth = 14;
            this.btnInvoicesImport.Text = "台帐";
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
            this.ribbonBarCreditLineImport.Location = new System.Drawing.Point(434, 0);
            this.ribbonBarCreditLineImport.Name = "ribbonBarCreditLineImport";
            this.ribbonBarCreditLineImport.Size = new System.Drawing.Size(278, 93);
            this.ribbonBarCreditLineImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCreditLineImport.TabIndex = 4;
            this.ribbonBarCreditLineImport.Text = "额度信息导入";
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
            this.btnClientCreditLineImport.Name = "btnClientCreditLineImport";
            this.btnClientCreditLineImport.SubItemsExpandWidth = 14;
            this.btnClientCreditLineImport.Text = "客户额度信息";
            this.btnClientCreditLineImport.Click += new System.EventHandler(this.ImportClientCreditLine);
            // 
            // btnFactorCreditLineImport
            // 
            this.btnFactorCreditLineImport.Name = "btnFactorCreditLineImport";
            this.btnFactorCreditLineImport.SubItemsExpandWidth = 14;
            this.btnFactorCreditLineImport.Text = "合作机构额度信息";
            this.btnFactorCreditLineImport.Click += new System.EventHandler(this.ImportFactorCreditLine);
            // 
            // btnCDAImport
            // 
            this.btnCDAImport.Name = "btnCDAImport";
            this.btnCDAImport.SubItemsExpandWidth = 14;
            this.btnCDAImport.Text = "额度通知书";
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
            this.btnLocalCaseImport,
            this.buttonItemInterCaseImport,
            this.btnContractImport});
            this.ribbonBarCaseImport.Location = new System.Drawing.Point(219, 0);
            this.ribbonBarCaseImport.Name = "ribbonBarCaseImport";
            this.ribbonBarCaseImport.Size = new System.Drawing.Size(215, 93);
            this.ribbonBarCaseImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCaseImport.TabIndex = 5;
            this.ribbonBarCaseImport.Text = "案件导入";
            // 
            // 
            // 
            this.ribbonBarCaseImport.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCaseImport.TitleStyleMouseOver.Class = "";
            // 
            // btnLocalCaseImport
            // 
            this.btnLocalCaseImport.Name = "btnLocalCaseImport";
            this.btnLocalCaseImport.SubItemsExpandWidth = 14;
            this.btnLocalCaseImport.Text = "国内保理案";
            this.btnLocalCaseImport.Click += new System.EventHandler(this.ImportCases);
            // 
            // buttonItemInterCaseImport
            // 
            this.buttonItemInterCaseImport.Name = "buttonItemInterCaseImport";
            this.buttonItemInterCaseImport.SubItemsExpandWidth = 14;
            this.buttonItemInterCaseImport.Text = "国际保理案";
            this.buttonItemInterCaseImport.Click += new System.EventHandler(this.ImportCases);
            // 
            // btnContractImport
            // 
            this.btnContractImport.Name = "btnContractImport";
            this.btnContractImport.SubItemsExpandWidth = 14;
            this.btnContractImport.Text = "保理合同";
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
            this.btnClientReviewImport,
            this.btnFactorImport2});
            this.ribbonBarBasicInfoImport.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarBasicInfoImport.Name = "ribbonBarBasicInfoImport";
            this.ribbonBarBasicInfoImport.Size = new System.Drawing.Size(216, 93);
            this.ribbonBarBasicInfoImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarBasicInfoImport.TabIndex = 2;
            this.ribbonBarBasicInfoImport.Text = "基础信息导入";
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
            this.btnClientImport.Name = "btnClientImport";
            this.btnClientImport.SubItemsExpandWidth = 14;
            this.btnClientImport.Text = "客户信息";
            this.btnClientImport.Click += new System.EventHandler(this.ImportClients);
            // 
            // btnClientReviewImport
            // 
            this.btnClientReviewImport.Name = "btnClientReviewImport";
            this.btnClientReviewImport.SubItemsExpandWidth = 14;
            this.btnClientReviewImport.Text = "协查意见";
            this.btnClientReviewImport.Click += new System.EventHandler(this.ImportClientsReview);
            // 
            // btnFactorImport2
            // 
            this.btnFactorImport2.Name = "btnFactorImport2";
            this.btnFactorImport2.SubItemsExpandWidth = 14;
            this.btnFactorImport2.Text = "合作机构信息";
            this.btnFactorImport2.Click += new System.EventHandler(this.ImportFactors);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel3.Controls.Add(this.ribbonBarUserMgr);
            this.ribbonPanel3.Controls.Add(this.ribbonBarSystem);
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(1000, 96);
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
            this.ribbonBarUserMgr.Location = new System.Drawing.Point(440, 0);
            this.ribbonBarUserMgr.Name = "ribbonBarUserMgr";
            this.ribbonBarUserMgr.Size = new System.Drawing.Size(71, 93);
            this.ribbonBarUserMgr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarUserMgr.TabIndex = 4;
            this.ribbonBarUserMgr.Text = "用户";
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
            this.btnUserMgr.Text = "用户信息";
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
            this.btnExchangeRateImport,
            this.btnCommissionCompute});
            this.ribbonBarSystem.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarSystem.Name = "ribbonBarSystem";
            this.ribbonBarSystem.Size = new System.Drawing.Size(437, 93);
            this.ribbonBarSystem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarSystem.TabIndex = 0;
            this.ribbonBarSystem.Text = "管理";
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
            this.btnUserImport.Name = "btnUserImport";
            this.btnUserImport.SubItemsExpandWidth = 14;
            this.btnUserImport.Text = "导入用户信息";
            this.btnUserImport.Click += new System.EventHandler(this.ImportUsers);
            // 
            // btnDepartmentImport
            // 
            this.btnDepartmentImport.Name = "btnDepartmentImport";
            this.btnDepartmentImport.SubItemsExpandWidth = 14;
            this.btnDepartmentImport.Text = "导入部门信息";
            this.btnDepartmentImport.Click += new System.EventHandler(this.ImportDepartments);
            // 
            // btnFactorImport
            // 
            this.btnFactorImport.Name = "btnFactorImport";
            this.btnFactorImport.SubItemsExpandWidth = 14;
            this.btnFactorImport.Text = "导入保理商信息";
            this.btnFactorImport.Click += new System.EventHandler(this.ImportFactors);
            // 
            // btnExchangeRateImport
            // 
            this.btnExchangeRateImport.Name = "btnExchangeRateImport";
            this.btnExchangeRateImport.SubItemsExpandWidth = 14;
            this.btnExchangeRateImport.Text = "导入汇率信息";
            this.btnExchangeRateImport.Click += new System.EventHandler(this.ImportExchangeRate);
            // 
            // btnCommissionCompute
            // 
            this.btnCommissionCompute.Name = "btnCommissionCompute";
            this.btnCommissionCompute.SubItemsExpandWidth = 14;
            this.btnCommissionCompute.Text = "计算手续费";
            this.btnCommissionCompute.Click += new System.EventHandler(this.ComputeCommission);
            // 
            // ribbonPanelHelp
            // 
            this.ribbonPanelHelp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelHelp.Controls.Add(this.ribbonBarHelp);
            this.ribbonPanelHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelHelp.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelHelp.Name = "ribbonPanelHelp";
            this.ribbonPanelHelp.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelHelp.Size = new System.Drawing.Size(1000, 96);
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
            this.btnHelp});
            this.ribbonBarHelp.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarHelp.Name = "ribbonBarHelp";
            this.ribbonBarHelp.Size = new System.Drawing.Size(112, 93);
            this.ribbonBarHelp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarHelp.TabIndex = 0;
            this.ribbonBarHelp.Text = "帮助";
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
            this.btnUserUpdate.Text = "个人信息";
            this.btnUserUpdate.Click += new System.EventHandler(this.DetailUser);
            // 
            // btnHelp
            // 
            this.btnHelp.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.SubItemsExpandWidth = 14;
            this.btnHelp.Text = "关于";
            this.btnHelp.Click += new System.EventHandler(this.About);
            // 
            // itemInfoMgr
            // 
            this.itemInfoMgr.Name = "itemInfoMgr";
            this.itemInfoMgr.Panel = this.ribbonPanelInfoMgr;
            this.itemInfoMgr.Text = "信息管理";
            // 
            // ribbonTabItemCaseMgr
            // 
            this.ribbonTabItemCaseMgr.Name = "ribbonTabItemCaseMgr";
            this.ribbonTabItemCaseMgr.Panel = this.ribbonPanel1;
            this.ribbonTabItemCaseMgr.Text = "案件管理";
            // 
            // itemAccountsReceivableMgr
            // 
            this.itemAccountsReceivableMgr.Checked = true;
            this.itemAccountsReceivableMgr.Name = "itemAccountsReceivableMgr";
            this.itemAccountsReceivableMgr.Panel = this.ribbonPanelInvoiceMgr;
            this.itemAccountsReceivableMgr.Text = "应收账款管理";
            // 
            // ribbonTabItemCheck
            // 
            this.ribbonTabItemCheck.Name = "ribbonTabItemCheck";
            this.ribbonTabItemCheck.Panel = this.ribbonPanel2;
            this.ribbonTabItemCheck.Text = "复核";
            // 
            // itemQuery
            // 
            this.itemQuery.Name = "itemQuery";
            this.itemQuery.Panel = this.ribbonPanelQuery;
            this.itemQuery.Text = "查询";
            // 
            // itemReport
            // 
            this.itemReport.Name = "itemReport";
            this.itemReport.Panel = this.ribbonPanelReport;
            this.itemReport.Text = "报表";
            // 
            // tabItemMigration
            // 
            this.tabItemMigration.Name = "tabItemMigration";
            this.tabItemMigration.Panel = this.ribbonPanelMigration;
            this.tabItemMigration.Text = "数据移植";
            // 
            // ribbonTabItemSystem
            // 
            this.ribbonTabItemSystem.Name = "ribbonTabItemSystem";
            this.ribbonTabItemSystem.Panel = this.ribbonPanel3;
            this.ribbonTabItemSystem.Text = "系统管理";
            // 
            // itemHelp
            // 
            this.itemHelp.Name = "itemHelp";
            this.itemHelp.Panel = this.ribbonPanelHelp;
            this.itemHelp.Text = "帮助";
            // 
            // office2007StartButton
            // 
            this.office2007StartButton.AutoExpandOnClick = true;
            this.office2007StartButton.CanCustomize = false;
            this.office2007StartButton.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton.ImagePaddingHorizontal = 2;
            this.office2007StartButton.ImagePaddingVertical = 2;
            this.office2007StartButton.Name = "office2007StartButton";
            this.office2007StartButton.ShowSubItems = false;
            this.office2007StartButton.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainerStartOuter});
            this.office2007StartButton.Text = "&File";
            // 
            // itemContainerStartOuter
            // 
            // 
            // 
            // 
            this.itemContainerStartOuter.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainerStartOuter.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainerStartOuter.Name = "itemContainerStartOuter";
            this.itemContainerStartOuter.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainerInner,
            this.itemContainerStartBottom});
            // 
            // itemContainerInner
            // 
            // 
            // 
            // 
            this.itemContainerInner.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainerInner.ItemSpacing = 0;
            this.itemContainerInner.Name = "itemContainerInner";
            this.itemContainerInner.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainerStartLeft,
            this.galleryContainer});
            // 
            // itemContainerStartLeft
            // 
            // 
            // 
            // 
            this.itemContainerStartLeft.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainerStartLeft.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainerStartLeft.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainerStartLeft.Name = "itemContainerStartLeft";
            this.itemContainerStartLeft.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnStartNew,
            this.btnStartOpen,
            this.btnStartSave,
            this.btnStartShare,
            this.btnStartPrint,
            this.btnStartClose});
            // 
            // btnStartNew
            // 
            this.btnStartNew.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartNew.Enabled = false;
            this.btnStartNew.Name = "btnStartNew";
            this.btnStartNew.SubItemsExpandWidth = 24;
            this.btnStartNew.Text = "&New";
            // 
            // btnStartOpen
            // 
            this.btnStartOpen.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartOpen.Enabled = false;
            this.btnStartOpen.Name = "btnStartOpen";
            this.btnStartOpen.SubItemsExpandWidth = 24;
            this.btnStartOpen.Text = "&Open...";
            // 
            // btnStartSave
            // 
            this.btnStartSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartSave.Enabled = false;
            this.btnStartSave.Name = "btnStartSave";
            this.btnStartSave.SubItemsExpandWidth = 24;
            this.btnStartSave.Text = "&Save...";
            // 
            // btnStartShare
            // 
            this.btnStartShare.BeginGroup = true;
            this.btnStartShare.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartShare.Enabled = false;
            this.btnStartShare.Name = "btnStartShare";
            this.btnStartShare.SubItemsExpandWidth = 24;
            this.btnStartShare.Text = "S&hare...";
            // 
            // btnStartPrint
            // 
            this.btnStartPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartPrint.Enabled = false;
            this.btnStartPrint.Name = "btnStartPrint";
            this.btnStartPrint.SubItemsExpandWidth = 24;
            this.btnStartPrint.Text = "&Print...";
            // 
            // btnStartClose
            // 
            this.btnStartClose.BeginGroup = true;
            this.btnStartClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartClose.Enabled = false;
            this.btnStartClose.Name = "btnStartClose";
            this.btnStartClose.SubItemsExpandWidth = 24;
            this.btnStartClose.Text = "&Close";
            // 
            // galleryContainer
            // 
            // 
            // 
            // 
            this.galleryContainer.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer.EnableGalleryPopup = false;
            this.galleryContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer.MultiLine = false;
            this.galleryContainer.Name = "galleryContainer";
            this.galleryContainer.PopupUsesStandardScrollbars = false;
            this.galleryContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblRecentDocs,
            this.btnExample1});
            // 
            // lblRecentDocs
            // 
            this.lblRecentDocs.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.lblRecentDocs.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.lblRecentDocs.CanCustomize = false;
            this.lblRecentDocs.Name = "lblRecentDocs";
            this.lblRecentDocs.PaddingBottom = 2;
            this.lblRecentDocs.PaddingTop = 2;
            this.lblRecentDocs.Stretch = true;
            this.lblRecentDocs.Text = "Recent Documents";
            // 
            // btnExample1
            // 
            this.btnExample1.Enabled = false;
            this.btnExample1.Name = "btnExample1";
            this.btnExample1.Text = "&1. Short News 5-7.rtf";
            // 
            // itemContainerStartBottom
            // 
            // 
            // 
            // 
            this.itemContainerStartBottom.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainerStartBottom.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainerStartBottom.Name = "itemContainerStartBottom";
            this.itemContainerStartBottom.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnStartOptions,
            this.btnStartExit});
            // 
            // btnStartOptions
            // 
            this.btnStartOptions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartOptions.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStartOptions.Enabled = false;
            this.btnStartOptions.Name = "btnStartOptions";
            this.btnStartOptions.SubItemsExpandWidth = 24;
            this.btnStartOptions.Text = "Opt&ions";
            // 
            // btnStartExit
            // 
            this.btnStartExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStartExit.Name = "btnStartExit";
            this.btnStartExit.SubItemsExpandWidth = 24;
            this.btnStartExit.Text = "E&xit";
            this.btnStartExit.Click += new System.EventHandler(this.Exit);
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
            this.cbStyleManager.WatermarkText = "界面风格";
            this.cbStyleManager.SelectedIndexChanged += new System.EventHandler(this.ChangeStyle);
            // 
            // btnMainPage
            // 
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Text = "首页";
            this.btnMainPage.Click += new System.EventHandler(this.MainPage);
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
            this.statusbar.Size = new System.Drawing.Size(1000, 21);
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
            this.ribbonDetailPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonDetailPanel.Controls.Add(this.logoLabel);
            this.ribbonDetailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonDetailPanel.Location = new System.Drawing.Point(4, 155);
            this.ribbonDetailPanel.Name = "ribbonDetailPanel";
            this.ribbonDetailPanel.Size = new System.Drawing.Size(1000, 552);
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
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.logoLabel.BackgroundStyle.Class = "";
            this.logoLabel.Location = new System.Drawing.Point(12, 6);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(768, 289);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "<b><font size=\"+60\"><i>Easy</i><font color=\"#B02B2C\">Factoring</font></font></b>";
            // 
            // btnPoolFinance
            // 
            this.btnPoolFinance.Name = "btnPoolFinance";
            this.btnPoolFinance.SubItemsExpandWidth = 14;
            this.btnPoolFinance.Text = "池融资";
            // 
            // btnPoolRefund
            // 
            this.btnPoolRefund.Name = "btnPoolRefund";
            this.btnPoolRefund.SubItemsExpandWidth = 14;
            this.btnPoolRefund.Text = "池融资还款";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.ribbonDetailPanel);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.ribbonPanelInfoMgr.ResumeLayout(false);
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanelInvoiceMgr.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonPanelQuery.ResumeLayout(false);
            this.ribbonPanelReport.ResumeLayout(false);
            this.ribbonPanelMigration.ResumeLayout(false);
            this.ribbonPanel3.ResumeLayout(false);
            this.ribbonPanelHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusbar)).EndInit();
            this.ribbonDetailPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem btnCaseStat;
        private DevComponents.DotNetBar.ButtonItem btnDepartmentStat;
        private DevComponents.DotNetBar.ButtonItem btnLocationStat;
        private DevComponents.DotNetBar.ButtonItem btnCommissionCompute;
        private DevComponents.DotNetBar.RibbonBar ribbonBarBatchQuery;
        private DevComponents.DotNetBar.ButtonItem btnAssignBatchQuery;
        private DevComponents.DotNetBar.ButtonItem btnFinanceBatchQuery;
        private DevComponents.DotNetBar.ButtonItem btnPaymentBatchQuery;
        private DevComponents.DotNetBar.ButtonItem btnRefundBatchQuery;
        private DevComponents.DotNetBar.ButtonItem btnPoolFinance;
        private DevComponents.DotNetBar.ButtonItem btnPoolRefund;
    }
}
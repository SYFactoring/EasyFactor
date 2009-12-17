//-----------------------------------------------------------------------
// <copyright file="MainWindow.Designer.cs" company="CISL@Fudan">
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
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelInvoiceMgr;
        private DevComponents.DotNetBar.RibbonBar ribbonBarInvoiceMgr;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelInfoMgr;
        private DevComponents.DotNetBar.RibbonTabItem itemAccountsReceivableMgr;
        private DevComponents.DotNetBar.RibbonTabItem itemInfoMgr;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton;
        private DevComponents.DotNetBar.ItemContainer itemContainerStartOuter;
        private DevComponents.DotNetBar.ItemContainer itemContainerInner;
        private DevComponents.DotNetBar.ItemContainer itemContainerStartLeft;
        private DevComponents.DotNetBar.ButtonItem btnStartNew;
        private DevComponents.DotNetBar.ButtonItem btnStartOpen;
        private DevComponents.DotNetBar.ButtonItem btnStartSave;
        private DevComponents.DotNetBar.ButtonItem btnStartShare;
        private DevComponents.DotNetBar.ButtonItem btnStartPrint;
        private DevComponents.DotNetBar.ButtonItem btnStartClose;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer;
        private DevComponents.DotNetBar.LabelItem lblRecentDocs;
        private DevComponents.DotNetBar.ButtonItem btnExample1;
        private DevComponents.DotNetBar.ItemContainer itemContainerStartBottom;
        private DevComponents.DotNetBar.ButtonItem btnStartOptions;
        private DevComponents.DotNetBar.ButtonItem btnStartExit;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelReport;
        private DevComponents.DotNetBar.RibbonTabItem itemReport;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelCaseQuery;
        private DevComponents.DotNetBar.RibbonTabItem itemCaseInfo;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelHelp;
        private DevComponents.DotNetBar.RibbonTabItem itemHelp;
        private DevComponents.DotNetBar.RibbonBar ribbonBarInvoiceCheck;
        private DevComponents.DotNetBar.ButtonItem btnInvoiceAssign;
        private DevComponents.DotNetBar.ButtonItem btnFlawResolve;
        private DevComponents.DotNetBar.ButtonItem btnInvoiceFinance;
        private DevComponents.DotNetBar.ButtonItem btnCDACheck;
        private DevComponents.DotNetBar.RibbonBar ribbonBarClient;
        private DevComponents.DotNetBar.ButtonItem btnClientMgr;
        private DevComponents.DotNetBar.ButtonItem btnClientNew;
        private DevComponents.DotNetBar.Bar statusbar;
        private DevComponents.DotNetBar.LabelItem lblCommandStatus;
        private DevComponents.DotNetBar.LabelItem lblCurrentUser;
        private DevComponents.DotNetBar.RibbonBar ribbonBarDepartment;
        private DevComponents.DotNetBar.ButtonItem btnDepartMgr;
        private DevComponents.DotNetBar.RibbonBar ribbonBarFactor;
        private DevComponents.DotNetBar.ButtonItem btnFactorMgr;
        private DevComponents.DotNetBar.ButtonItem btnFactorNew;
        private DevComponents.DotNetBar.RibbonBar ribbonBarCaseRequest;
        private DevComponents.DotNetBar.ButtonItem btnCaseNew;
        private DevComponents.DotNetBar.ButtonItem btnCDANew;
        private DevComponents.DotNetBar.ButtonItem btnBuyerPayment;
        private DevComponents.DotNetBar.ButtonItem btnIndirectPayment;
        private DevComponents.DotNetBar.ButtonItem btnAssignCheck;
        private DevComponents.DotNetBar.ButtonItem btnFinanceCheck;
        private DevComponents.DotNetBar.ButtonItem btnPaymentCheck;
        private DevComponents.DotNetBar.ButtonItem btnSellerPayment;
        private DevComponents.DotNetBar.ButtonItem btnGuaranteePayment;
        private DevComponents.DotNetBar.ButtonItem btnReassignment;
        private DevComponents.DotNetBar.ButtonItem btnDispute;
        private DevComponents.DotNetBar.RibbonBar ribbonBarTransactionReport;
        private DevComponents.DotNetBar.ButtonItem btnCDAReport;
        private DevComponents.DotNetBar.ButtonItem btnFlawReport;
        private DevComponents.DotNetBar.ButtonItem btnAssignReport;
        private DevComponents.DotNetBar.ButtonItem btnFinanceReport;
        private DevComponents.DotNetBar.ButtonItem btnFeeReport;
        private DevComponents.DotNetBar.ButtonItem btnReceivableAccountPaymentReport;
        private DevComponents.DotNetBar.ButtonItem btnFinancePaymentReport;
        private DevComponents.DotNetBar.ButtonItem btnFactorFeeReport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarCaseQuery;
        private DevComponents.DotNetBar.RibbonBar ribbonBarAnalysisReport;
        private DevComponents.DotNetBar.RibbonBar ribbonBarUserMgr;
        private DevComponents.DotNetBar.ButtonItem btnUserMgr;
        private DevComponents.DotNetBar.ButtonItem btnCaseQuery;
        private DevComponents.DotNetBar.ButtonItem btnOverDueQuery;
        private DevComponents.DotNetBar.RibbonBar ribbonBarHelp;
        private DevComponents.DotNetBar.ButtonItem btnHelp;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanelInfoMgr = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarUserMgr = new DevComponents.DotNetBar.RibbonBar();
            this.btnUserMgr = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarDepartment = new DevComponents.DotNetBar.RibbonBar();
            this.btnDepartMgr = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarFactor = new DevComponents.DotNetBar.RibbonBar();
            this.btnFactorMgr = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorNew = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarClient = new DevComponents.DotNetBar.RibbonBar();
            this.btnClientMgr = new DevComponents.DotNetBar.ButtonItem();
            this.btnClientNew = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelCaseQuery = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarCaseQuery = new DevComponents.DotNetBar.RibbonBar();
            this.btnContractQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnCaseQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnCreditCoverNegQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnOverDueQuery = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarCaseRequest = new DevComponents.DotNetBar.RibbonBar();
            this.btnCaseNew = new DevComponents.DotNetBar.ButtonItem();
            this.btnCDANew = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelInvoiceMgr = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarInvoiceCheck = new DevComponents.DotNetBar.RibbonBar();
            this.btnCDACheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnAssignCheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnFinanceCheck = new DevComponents.DotNetBar.ButtonItem();
            this.btnPaymentCheck = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBarInvoiceMgr = new DevComponents.DotNetBar.RibbonBar();
            this.btnFlawResolve = new DevComponents.DotNetBar.ButtonItem();
            this.btnInvoiceFinance = new DevComponents.DotNetBar.ButtonItem();
            this.btnBuyerPayment = new DevComponents.DotNetBar.ButtonItem();
            this.btnIndirectPayment = new DevComponents.DotNetBar.ButtonItem();
            this.btnSellerPayment = new DevComponents.DotNetBar.ButtonItem();
            this.btnGuaranteePayment = new DevComponents.DotNetBar.ButtonItem();
            this.btnReassignment = new DevComponents.DotNetBar.ButtonItem();
            this.btnDispute = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelReport = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarAnalysisReport = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBarTransactionReport = new DevComponents.DotNetBar.RibbonBar();
            this.btnCDAReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFlawReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnAssignReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFinanceReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFeeReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnReceivableAccountPaymentReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFinancePaymentReport = new DevComponents.DotNetBar.ButtonItem();
            this.btnFactorFeeReport = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonPanelHelp = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarHelp = new DevComponents.DotNetBar.RibbonBar();
            this.btnHelp = new DevComponents.DotNetBar.ButtonItem();
            this.itemInfoMgr = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemCaseInfo = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemAccountsReceivableMgr = new DevComponents.DotNetBar.RibbonTabItem();
            this.itemReport = new DevComponents.DotNetBar.RibbonTabItem();
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
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.qatCustomizeItem = new DevComponents.DotNetBar.QatCustomizeItem();
            this.styleManager = new DevComponents.DotNetBar.StyleManager();
            this.statusbar = new DevComponents.DotNetBar.Bar();
            this.lblCommandStatus = new DevComponents.DotNetBar.LabelItem();
            this.lblCurrentUser = new DevComponents.DotNetBar.LabelItem();
            this.ribbonDetailPanel = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.btnCDAQuery = new DevComponents.DotNetBar.ButtonItem();
            this.btnInvoiceAssign = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl.SuspendLayout();
            this.ribbonPanelInfoMgr.SuspendLayout();
            this.ribbonPanelCaseQuery.SuspendLayout();
            this.ribbonPanelInvoiceMgr.SuspendLayout();
            this.ribbonPanelReport.SuspendLayout();
            this.ribbonPanelHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusbar)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            // 
            // 
            // 
            this.ribbonControl.BackgroundStyle.Class = "";
            this.ribbonControl.CaptionVisible = true;
            this.ribbonControl.Controls.Add(this.ribbonPanelCaseQuery);
            this.ribbonControl.Controls.Add(this.ribbonPanelInvoiceMgr);
            this.ribbonControl.Controls.Add(this.ribbonPanelReport);
            this.ribbonControl.Controls.Add(this.ribbonPanelInfoMgr);
            this.ribbonControl.Controls.Add(this.ribbonPanelHelp);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemInfoMgr,
            this.itemCaseInfo,
            this.itemAccountsReceivableMgr,
            this.itemReport,
            this.itemHelp});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton,
            this.cbStyleManager,
            this.qatCustomizeItem});
            this.ribbonControl.Size = new System.Drawing.Size(1000, 154);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabIndex = 0;
            // 
            // ribbonPanelInfoMgr
            // 
            this.ribbonPanelInfoMgr.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarUserMgr);
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarDepartment);
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarFactor);
            this.ribbonPanelInfoMgr.Controls.Add(this.ribbonBarClient);
            this.ribbonPanelInfoMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelInfoMgr.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanelInfoMgr.Name = "ribbonPanelInfoMgr";
            this.ribbonPanelInfoMgr.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelInfoMgr.Size = new System.Drawing.Size(1000, 152);
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
            this.ribbonBarUserMgr.Location = new System.Drawing.Point(397, 0);
            this.ribbonBarUserMgr.Name = "ribbonBarUserMgr";
            this.ribbonBarUserMgr.Size = new System.Drawing.Size(100, 149);
            this.ribbonBarUserMgr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarUserMgr.TabIndex = 3;
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
            this.btnUserMgr.Name = "btnUserMgr";
            this.btnUserMgr.SubItemsExpandWidth = 14;
            this.btnUserMgr.Text = "用户信息";
            this.btnUserMgr.Click += new System.EventHandler(this.UserMgr);
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
            this.ribbonBarDepartment.Location = new System.Drawing.Point(305, 0);
            this.ribbonBarDepartment.Name = "ribbonBarDepartment";
            this.ribbonBarDepartment.Size = new System.Drawing.Size(92, 149);
            this.ribbonBarDepartment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarDepartment.TabIndex = 2;
            this.ribbonBarDepartment.Text = "分部";
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
            this.btnDepartMgr.Text = "分部信息";
            this.btnDepartMgr.Click += new System.EventHandler(this.DepartmentMgr);
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
            this.ribbonBarFactor.Location = new System.Drawing.Point(147, 0);
            this.ribbonBarFactor.Name = "ribbonBarFactor";
            this.ribbonBarFactor.Size = new System.Drawing.Size(158, 149);
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
            this.btnFactorMgr.Click += new System.EventHandler(this.FactorMgr);
            // 
            // btnFactorNew
            // 
            this.btnFactorNew.Name = "btnFactorNew";
            this.btnFactorNew.SubItemsExpandWidth = 14;
            this.btnFactorNew.Text = "添加合作机构";
            this.btnFactorNew.Click += new System.EventHandler(this.FactorNew);
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
            this.ribbonBarClient.Size = new System.Drawing.Size(144, 149);
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
            this.btnClientMgr.Click += new System.EventHandler(this.ClientMgr);
            // 
            // btnClientNew
            // 
            this.btnClientNew.Name = "btnClientNew";
            this.btnClientNew.SubItemsExpandWidth = 14;
            this.btnClientNew.Text = "添加客户";
            this.btnClientNew.Click += new System.EventHandler(this.ClientNew);
            // 
            // ribbonPanelCaseQuery
            // 
            this.ribbonPanelCaseQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelCaseQuery.Controls.Add(this.ribbonBarCaseQuery);
            this.ribbonPanelCaseQuery.Controls.Add(this.ribbonBarCaseRequest);
            this.ribbonPanelCaseQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelCaseQuery.Location = new System.Drawing.Point(0, 56);
            this.ribbonPanelCaseQuery.Name = "ribbonPanelCaseQuery";
            this.ribbonPanelCaseQuery.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelCaseQuery.Size = new System.Drawing.Size(1000, 96);
            // 
            // 
            // 
            this.ribbonPanelCaseQuery.Style.Class = "";
            // 
            // 
            // 
            this.ribbonPanelCaseQuery.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.ribbonPanelCaseQuery.StyleMouseOver.Class = "";
            this.ribbonPanelCaseQuery.TabIndex = 4;
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
            this.btnCreditCoverNegQuery,
            this.btnCDAQuery,
            this.btnOverDueQuery});
            this.ribbonBarCaseQuery.Location = new System.Drawing.Point(147, 0);
            this.ribbonBarCaseQuery.Name = "ribbonBarCaseQuery";
            this.ribbonBarCaseQuery.Size = new System.Drawing.Size(381, 93);
            this.ribbonBarCaseQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCaseQuery.TabIndex = 1;
            this.ribbonBarCaseQuery.Text = "查询";
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
            this.btnContractQuery.Text = "主合同查询";
            this.btnContractQuery.Click += new System.EventHandler(this.ContractMgr);
            // 
            // btnCaseQuery
            // 
            this.btnCaseQuery.Name = "btnCaseQuery";
            this.btnCaseQuery.SubItemsExpandWidth = 14;
            this.btnCaseQuery.Text = "案件查询";
            this.btnCaseQuery.Click += new System.EventHandler(this.CaseQuery);
            // 
            // btnCreditCoverNegQuery
            // 
            this.btnCreditCoverNegQuery.Name = "btnCreditCoverNegQuery";
            this.btnCreditCoverNegQuery.SubItemsExpandWidth = 14;
            this.btnCreditCoverNegQuery.Text = "申请案查询";
            this.btnCreditCoverNegQuery.Click += new System.EventHandler(this.CreditCoverNegMgr);
            // 
            // btnOverDueQuery
            // 
            this.btnOverDueQuery.Name = "btnOverDueQuery";
            this.btnOverDueQuery.SubItemsExpandWidth = 14;
            this.btnOverDueQuery.Text = "逾期查询";
            // 
            // ribbonBarCaseRequest
            // 
            this.ribbonBarCaseRequest.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarCaseRequest.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCaseRequest.BackgroundStyle.Class = "";
            this.ribbonBarCaseRequest.ContainerControlProcessDialogKey = true;
            this.ribbonBarCaseRequest.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarCaseRequest.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCaseNew,
            this.btnCDANew});
            this.ribbonBarCaseRequest.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarCaseRequest.Name = "ribbonBarCaseRequest";
            this.ribbonBarCaseRequest.Size = new System.Drawing.Size(144, 93);
            this.ribbonBarCaseRequest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarCaseRequest.TabIndex = 0;
            this.ribbonBarCaseRequest.Text = "申请";
            // 
            // 
            // 
            this.ribbonBarCaseRequest.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarCaseRequest.TitleStyleMouseOver.Class = "";
            // 
            // btnCaseNew
            // 
            this.btnCaseNew.Name = "btnCaseNew";
            this.btnCaseNew.SubItemsExpandWidth = 14;
            this.btnCaseNew.Text = "案件申请";
            this.btnCaseNew.Click += new System.EventHandler(this.CaseApplication);
            // 
            // btnCDANew
            // 
            this.btnCDANew.Name = "btnCDANew";
            this.btnCDANew.SubItemsExpandWidth = 14;
            this.btnCDANew.Text = "额度通知书";
            this.btnCDANew.Click += new System.EventHandler(this.CDANew);
            // 
            // ribbonPanelInvoiceMgr
            // 
            this.ribbonPanelInvoiceMgr.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarInvoiceCheck);
            this.ribbonPanelInvoiceMgr.Controls.Add(this.ribbonBarInvoiceMgr);
            this.ribbonPanelInvoiceMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelInvoiceMgr.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanelInvoiceMgr.Name = "ribbonPanelInvoiceMgr";
            this.ribbonPanelInvoiceMgr.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelInvoiceMgr.Size = new System.Drawing.Size(1000, 152);
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
            this.btnPaymentCheck});
            this.ribbonBarInvoiceCheck.Location = new System.Drawing.Point(589, 0);
            this.ribbonBarInvoiceCheck.Name = "ribbonBarInvoiceCheck";
            this.ribbonBarInvoiceCheck.Size = new System.Drawing.Size(249, 149);
            this.ribbonBarInvoiceCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarInvoiceCheck.TabIndex = 1;
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
            this.btnCDACheck.Text = "CDA复核";
            // 
            // btnAssignCheck
            // 
            this.btnAssignCheck.Name = "btnAssignCheck";
            this.btnAssignCheck.SubItemsExpandWidth = 14;
            this.btnAssignCheck.Text = "转让复核";
            // 
            // btnFinanceCheck
            // 
            this.btnFinanceCheck.Name = "btnFinanceCheck";
            this.btnFinanceCheck.SubItemsExpandWidth = 14;
            this.btnFinanceCheck.Text = "融资复核";
            // 
            // btnPaymentCheck
            // 
            this.btnPaymentCheck.Name = "btnPaymentCheck";
            this.btnPaymentCheck.SubItemsExpandWidth = 14;
            this.btnPaymentCheck.Text = "还款复核";
            // 
            // ribbonBarInvoiceMgr
            // 
            this.ribbonBarInvoiceMgr.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarInvoiceMgr.BackgroundMouseOverStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarInvoiceMgr.BackgroundStyle.Class = "";
            this.ribbonBarInvoiceMgr.ContainerControlProcessDialogKey = true;
            this.ribbonBarInvoiceMgr.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarInvoiceMgr.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnInvoiceAssign,
            this.btnFlawResolve,
            this.btnInvoiceFinance,
            this.btnBuyerPayment,
            this.btnIndirectPayment,
            this.btnSellerPayment,
            this.btnGuaranteePayment,
            this.btnReassignment,
            this.btnDispute});
            this.ribbonBarInvoiceMgr.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarInvoiceMgr.Name = "ribbonBarInvoiceMgr";
            this.ribbonBarInvoiceMgr.Size = new System.Drawing.Size(586, 149);
            this.ribbonBarInvoiceMgr.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarInvoiceMgr.TabIndex = 0;
            this.ribbonBarInvoiceMgr.Text = "应收账款管理";
            // 
            // 
            // 
            this.ribbonBarInvoiceMgr.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarInvoiceMgr.TitleStyleMouseOver.Class = "";
            // 
            // btnFlawResolve
            // 
            this.btnFlawResolve.Name = "btnFlawResolve";
            this.btnFlawResolve.SubItemsExpandWidth = 14;
            this.btnFlawResolve.Text = "瑕疵解除";
            // 
            // btnInvoiceFinance
            // 
            this.btnInvoiceFinance.Name = "btnInvoiceFinance";
            this.btnInvoiceFinance.SubItemsExpandWidth = 14;
            this.btnInvoiceFinance.Text = "预付款支用";
            // 
            // btnBuyerPayment
            // 
            this.btnBuyerPayment.Name = "btnBuyerPayment";
            this.btnBuyerPayment.SubItemsExpandWidth = 14;
            this.btnBuyerPayment.Text = "买方还款";
            // 
            // btnIndirectPayment
            // 
            this.btnIndirectPayment.Name = "btnIndirectPayment";
            this.btnIndirectPayment.SubItemsExpandWidth = 14;
            this.btnIndirectPayment.Text = "间接还款";
            // 
            // btnSellerPayment
            // 
            this.btnSellerPayment.Name = "btnSellerPayment";
            this.btnSellerPayment.SubItemsExpandWidth = 14;
            this.btnSellerPayment.Text = "卖方还款";
            // 
            // btnGuaranteePayment
            // 
            this.btnGuaranteePayment.Name = "btnGuaranteePayment";
            this.btnGuaranteePayment.SubItemsExpandWidth = 14;
            this.btnGuaranteePayment.Text = "担保付款";
            // 
            // btnReassignment
            // 
            this.btnReassignment.Name = "btnReassignment";
            this.btnReassignment.SubItemsExpandWidth = 14;
            this.btnReassignment.Text = "卖方回购";
            // 
            // btnDispute
            // 
            this.btnDispute.Name = "btnDispute";
            this.btnDispute.SubItemsExpandWidth = 14;
            this.btnDispute.Text = "商纠处理";
            // 
            // ribbonPanelReport
            // 
            this.ribbonPanelReport.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelReport.Controls.Add(this.ribbonBarAnalysisReport);
            this.ribbonPanelReport.Controls.Add(this.ribbonBarTransactionReport);
            this.ribbonPanelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelReport.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanelReport.Name = "ribbonPanelReport";
            this.ribbonPanelReport.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelReport.Size = new System.Drawing.Size(1000, 152);
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
            this.ribbonBarAnalysisReport.Location = new System.Drawing.Point(767, 0);
            this.ribbonBarAnalysisReport.Name = "ribbonBarAnalysisReport";
            this.ribbonBarAnalysisReport.Size = new System.Drawing.Size(100, 149);
            this.ribbonBarAnalysisReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarAnalysisReport.TabIndex = 1;
            this.ribbonBarAnalysisReport.Text = "分析报表";
            // 
            // 
            // 
            this.ribbonBarAnalysisReport.TitleStyle.Class = "";
            // 
            // 
            // 
            this.ribbonBarAnalysisReport.TitleStyleMouseOver.Class = "";
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
            this.btnCDAReport,
            this.btnFlawReport,
            this.btnAssignReport,
            this.btnFinanceReport,
            this.btnFeeReport,
            this.btnReceivableAccountPaymentReport,
            this.btnFinancePaymentReport,
            this.btnFactorFeeReport});
            this.ribbonBarTransactionReport.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarTransactionReport.Name = "ribbonBarTransactionReport";
            this.ribbonBarTransactionReport.Size = new System.Drawing.Size(764, 149);
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
            // btnCDAReport
            // 
            this.btnCDAReport.Name = "btnCDAReport";
            this.btnCDAReport.SubItemsExpandWidth = 14;
            this.btnCDAReport.Text = "额度通知书";
            // 
            // btnFlawReport
            // 
            this.btnFlawReport.Name = "btnFlawReport";
            this.btnFlawReport.SubItemsExpandWidth = 14;
            this.btnFlawReport.Text = "瑕疵通知书";
            // 
            // btnAssignReport
            // 
            this.btnAssignReport.Name = "btnAssignReport";
            this.btnAssignReport.SubItemsExpandWidth = 14;
            this.btnAssignReport.Text = "转让明细表";
            // 
            // btnFinanceReport
            // 
            this.btnFinanceReport.Name = "btnFinanceReport";
            this.btnFinanceReport.SubItemsExpandWidth = 14;
            this.btnFinanceReport.Text = "可融资账款明细表";
            // 
            // btnFeeReport
            // 
            this.btnFeeReport.Name = "btnFeeReport";
            this.btnFeeReport.SubItemsExpandWidth = 14;
            this.btnFeeReport.Text = "保理费用明细表";
            // 
            // btnReceivableAccountPaymentReport
            // 
            this.btnReceivableAccountPaymentReport.Name = "btnReceivableAccountPaymentReport";
            this.btnReceivableAccountPaymentReport.SubItemsExpandWidth = 14;
            this.btnReceivableAccountPaymentReport.Text = "应收账款销帐明细表";
            // 
            // btnFinancePaymentReport
            // 
            this.btnFinancePaymentReport.Name = "btnFinancePaymentReport";
            this.btnFinancePaymentReport.SubItemsExpandWidth = 14;
            this.btnFinancePaymentReport.Text = "融资销帐明细表";
            // 
            // btnFactorFeeReport
            // 
            this.btnFactorFeeReport.Name = "btnFactorFeeReport";
            this.btnFactorFeeReport.SubItemsExpandWidth = 14;
            this.btnFactorFeeReport.Text = "保理商费用明细表";
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
            this.btnHelp});
            this.ribbonBarHelp.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarHelp.Name = "ribbonBarHelp";
            this.ribbonBarHelp.Size = new System.Drawing.Size(167, 93);
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
            // btnHelp
            // 
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
            // itemCaseInfo
            // 
            this.itemCaseInfo.Checked = true;
            this.itemCaseInfo.Name = "itemCaseInfo";
            this.itemCaseInfo.Panel = this.ribbonPanelCaseQuery;
            this.itemCaseInfo.Text = "案件管理";
            // 
            // itemAccountsReceivableMgr
            // 
            this.itemAccountsReceivableMgr.Name = "itemAccountsReceivableMgr";
            this.itemAccountsReceivableMgr.Panel = this.ribbonPanelInvoiceMgr;
            this.itemAccountsReceivableMgr.Text = "应收账款管理";
            // 
            // itemReport
            // 
            this.itemReport.Name = "itemReport";
            this.itemReport.Panel = this.ribbonPanelReport;
            this.itemReport.Text = "报表";
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
            this.btnStartNew.Name = "btnStartNew";
            this.btnStartNew.SubItemsExpandWidth = 24;
            this.btnStartNew.Text = "&New";
            // 
            // btnStartOpen
            // 
            this.btnStartOpen.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartOpen.Name = "btnStartOpen";
            this.btnStartOpen.SubItemsExpandWidth = 24;
            this.btnStartOpen.Text = "&Open...";
            // 
            // btnStartSave
            // 
            this.btnStartSave.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartSave.Name = "btnStartSave";
            this.btnStartSave.SubItemsExpandWidth = 24;
            this.btnStartSave.Text = "&Save...";
            // 
            // btnStartShare
            // 
            this.btnStartShare.BeginGroup = true;
            this.btnStartShare.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartShare.Name = "btnStartShare";
            this.btnStartShare.SubItemsExpandWidth = 24;
            this.btnStartShare.Text = "S&hare...";
            // 
            // btnStartPrint
            // 
            this.btnStartPrint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnStartPrint.Name = "btnStartPrint";
            this.btnStartPrint.SubItemsExpandWidth = 24;
            this.btnStartPrint.Text = "&Print...";
            // 
            // btnStartClose
            // 
            this.btnStartClose.BeginGroup = true;
            this.btnStartClose.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
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
            // 
            // cbStyleManager
            // 
            this.cbStyleManager.ComboWidth = 100;
            this.cbStyleManager.DropDownHeight = 106;
            this.cbStyleManager.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5,
            this.comboItem6});
            this.cbStyleManager.Name = "cbStyleManager";
            this.cbStyleManager.WatermarkText = "界面风格";
            this.cbStyleManager.SelectedIndexChanged += new System.EventHandler(this.ChangeStyle);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Office2007Blue";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Office2007Silver";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Office2007Black";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Office2007VistaGlass";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "Office2010Silver";
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "Windows7Blue";
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
            // btnCDAQuery
            // 
            this.btnCDAQuery.Name = "btnCDAQuery";
            this.btnCDAQuery.SubItemsExpandWidth = 14;
            this.btnCDAQuery.Text = "额度通知书查询";
            this.btnCDAQuery.Click += new System.EventHandler(this.CDAMgr);
            // 
            // btnInvoiceAssign
            // 
            this.btnInvoiceAssign.Image = global::CMBC.EasyFactor.Properties.Resources.invoice_icon_48;
            this.btnInvoiceAssign.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnInvoiceAssign.Name = "btnInvoiceAssign";
            this.btnInvoiceAssign.SubItemsExpandWidth = 14;
            this.btnInvoiceAssign.Text = "发票录入";
            this.btnInvoiceAssign.Click += new System.EventHandler(this.InvoiceAssign);
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
            this.Text = "中国民生银行保理运营系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.ribbonPanelInfoMgr.ResumeLayout(false);
            this.ribbonPanelCaseQuery.ResumeLayout(false);
            this.ribbonPanelInvoiceMgr.ResumeLayout(false);
            this.ribbonPanelReport.ResumeLayout(false);
            this.ribbonPanelHelp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ComboBoxItem cbStyleManager;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonDetailPanel;
        private DevComponents.DotNetBar.ButtonItem btnCreditCoverNegQuery;
        private DevComponents.DotNetBar.ButtonItem btnContractQuery;
        private DevComponents.DotNetBar.ButtonItem btnCDAQuery;
    }
}
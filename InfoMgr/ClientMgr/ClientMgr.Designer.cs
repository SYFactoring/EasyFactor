//-----------------------------------------------------------------------
// <copyright file="ClientMgrUI.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    /// <summary>
    /// Client Management User Interface Designer
    /// </summary>
    public partial class ClientMgr
    {
        #region Fields (63)

        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressENColumn;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbClientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CellPhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityENColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCoreNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEDICodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientGroupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientLevelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameEN_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameEN_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientTypeColumn;
        private System.Windows.Forms.ContextMenuStrip cmuClientMgr;
        private DevComponents.DotNetBar.Controls.ComboTree cbDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyCodeColumn;
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryNameCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaxNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndustryColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsGroupColumn;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.LabelX lblClientNo;
        private DevComponents.DotNetBar.LabelX lblClientType;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblDepartment;
        private DevComponents.DotNetBar.LabelX lblPM;
        private DevComponents.DotNetBar.LabelX lblRM;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientCreditLineNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientImport;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuItemContractNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn PMNameColumn;
        private DevComponents.DotNetBar.PanelEx pnlQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductENColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinceCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvinceENColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepresentativeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMNameColumn;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientEDICode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPM;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelephoneColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebsiteColumn;

        #endregion Fields

        #region Methods (1)

        // Protected Methods (1) 

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #endregion Methods



        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmuClientMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemClientSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemClientNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientCreditLineNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContractNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientImport = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlQuery = new DevComponents.DotNetBar.PanelEx();
            this.cbIsSigned = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbDepartment = new DevComponents.DotNetBar.Controls.ComboTree();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.cbClientType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblClientType = new DevComponents.DotNetBar.LabelX();
            this.tbClientEDICode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientNo = new DevComponents.DotNetBar.LabelX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.tbRM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRM = new DevComponents.DotNetBar.LabelX();
            this.tbPM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPM = new DevComponents.DotNetBar.LabelX();
            this.lblDepartment = new DevComponents.DotNetBar.LabelX();
            this.dgvClients = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.IsGroupColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEDICodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientCoreNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameEN_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameEN_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductENColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressENColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityENColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinceCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvinceENColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryNameCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepresentativeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebsiteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelephoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellPhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndustryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PMNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientGroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuClientMgr.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // cmuClientMgr
            // 
            this.cmuClientMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemClientSelect,
            this.menuItemClientDetail,
            this.toolStripSeparator,
            this.menuItemClientNew,
            this.menuItemClientCreditLineNew,
            this.menuItemContractNew,
            this.menuItemClientUpdate,
            this.menuItemClientDelete,
            this.menuItemClientImport});
            this.cmuClientMgr.Name = "contextMenuClientMgr";
            this.cmuClientMgr.Size = new System.Drawing.Size(147, 186);
            // 
            // menuItemClientSelect
            // 
            this.menuItemClientSelect.Name = "menuItemClientSelect";
            this.menuItemClientSelect.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientSelect.Text = "选定客户";
            this.menuItemClientSelect.Click += new System.EventHandler(this.SelectClient);
            // 
            // menuItemClientDetail
            // 
            this.menuItemClientDetail.Name = "menuItemClientDetail";
            this.menuItemClientDetail.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientDetail.Text = "详细信息";
            this.menuItemClientDetail.Click += new System.EventHandler(this.DetailClient);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItemClientNew
            // 
            this.menuItemClientNew.Name = "menuItemClientNew";
            this.menuItemClientNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientNew.Text = "新建客户";
            this.menuItemClientNew.Click += new System.EventHandler(this.NewClient);
            // 
            // menuItemClientCreditLineNew
            // 
            this.menuItemClientCreditLineNew.Name = "menuItemClientCreditLineNew";
            this.menuItemClientCreditLineNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientCreditLineNew.Text = "新建额度信息";
            this.menuItemClientCreditLineNew.Click += new System.EventHandler(this.NewClientCreditLine);
            // 
            // menuItemContractNew
            // 
            this.menuItemContractNew.Name = "menuItemContractNew";
            this.menuItemContractNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemContractNew.Text = "新建主合同";
            this.menuItemContractNew.Click += new System.EventHandler(this.NewContract);
            // 
            // menuItemClientUpdate
            // 
            this.menuItemClientUpdate.Name = "menuItemClientUpdate";
            this.menuItemClientUpdate.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientUpdate.Text = "更新客户";
            this.menuItemClientUpdate.Click += new System.EventHandler(this.UpdateClient);
            // 
            // menuItemClientDelete
            // 
            this.menuItemClientDelete.Name = "menuItemClientDelete";
            this.menuItemClientDelete.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientDelete.Text = "删除客户";
            this.menuItemClientDelete.Click += new System.EventHandler(this.DeleteClient);
            // 
            // menuItemClientImport
            // 
            this.menuItemClientImport.Name = "menuItemClientImport";
            this.menuItemClientImport.Size = new System.Drawing.Size(146, 22);
            this.menuItemClientImport.Text = "导入客户";
            this.menuItemClientImport.Click += new System.EventHandler(this.ImportClients);
            // 
            // pnlQuery
            // 
            this.pnlQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlQuery.Controls.Add(this.cbIsSigned);
            this.pnlQuery.Controls.Add(this.cbDepartment);
            this.pnlQuery.Controls.Add(this.lblCount);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.cbClientType);
            this.pnlQuery.Controls.Add(this.lblClientType);
            this.pnlQuery.Controls.Add(this.tbClientEDICode);
            this.pnlQuery.Controls.Add(this.lblClientNo);
            this.pnlQuery.Controls.Add(this.tbClientName);
            this.pnlQuery.Controls.Add(this.lblClientName);
            this.pnlQuery.Controls.Add(this.tbRM);
            this.pnlQuery.Controls.Add(this.lblRM);
            this.pnlQuery.Controls.Add(this.tbPM);
            this.pnlQuery.Controls.Add(this.lblPM);
            this.pnlQuery.Controls.Add(this.lblDepartment);
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 0);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(800, 61);
            this.pnlQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlQuery.Style.GradientAngle = 90;
            this.pnlQuery.TabIndex = 1;
            // 
            // cbIsSigned
            // 
            this.cbIsSigned.AutoSize = true;
            // 
            // 
            // 
            this.cbIsSigned.BackgroundStyle.Class = "";
            this.cbIsSigned.Checked = true;
            this.cbIsSigned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsSigned.CheckValue = "Y";
            this.cbIsSigned.Location = new System.Drawing.Point(505, 35);
            this.cbIsSigned.Name = "cbIsSigned";
            this.cbIsSigned.Size = new System.Drawing.Size(76, 16);
            this.cbIsSigned.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbIsSigned.TabIndex = 14;
            this.cbIsSigned.Text = "是否签约";
            // 
            // cbDepartment
            // 
            this.cbDepartment.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.cbDepartment.BackgroundStyle.Class = "TextBoxBorder";
            this.cbDepartment.ButtonDropDown.Visible = true;
            this.cbDepartment.ColumnsVisible = false;
            this.cbDepartment.DropDownWidth = 150;
            this.cbDepartment.Location = new System.Drawing.Point(60, 32);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(100, 23);
            this.cbDepartment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbDepartment.TabIndex = 3;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(598, 30);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 13;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(505, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(39, 26);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryClients);
            // 
            // cbClientType
            // 
            this.cbClientType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientType.ItemHeight = 14;
            this.cbClientType.Items.AddRange(new object[] {
            "全部",
            "国有",
            "民营",
            "三资",
            "私营",
            "中外合资"});
            this.cbClientType.Location = new System.Drawing.Point(399, 6);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(100, 20);
            this.cbClientType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbClientType.TabIndex = 2;
            // 
            // lblClientType
            // 
            // 
            // 
            // 
            this.lblClientType.BackgroundStyle.Class = "";
            this.lblClientType.Location = new System.Drawing.Point(336, 6);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(75, 23);
            this.lblClientType.TabIndex = 4;
            this.lblClientType.Text = "客户类型";
            // 
            // tbClientEDICode
            // 
            // 
            // 
            // 
            this.tbClientEDICode.Border.Class = "TextBoxBorder";
            this.tbClientEDICode.Location = new System.Drawing.Point(60, 6);
            this.tbClientEDICode.Name = "tbClientEDICode";
            this.tbClientEDICode.Size = new System.Drawing.Size(100, 20);
            this.tbClientEDICode.TabIndex = 0;
            // 
            // lblClientNo
            // 
            // 
            // 
            // 
            this.lblClientNo.BackgroundStyle.Class = "";
            this.lblClientNo.Location = new System.Drawing.Point(3, 6);
            this.lblClientNo.Name = "lblClientNo";
            this.lblClientNo.Size = new System.Drawing.Size(75, 23);
            this.lblClientNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblClientNo.TabIndex = 0;
            this.lblClientNo.Text = "保理代码";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Location = new System.Drawing.Point(227, 6);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 20);
            this.tbClientName.TabIndex = 1;
            // 
            // lblClientName
            // 
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.Class = "";
            this.lblClientName.Location = new System.Drawing.Point(168, 6);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(75, 23);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "客户名称";
            // 
            // tbRM
            // 
            // 
            // 
            // 
            this.tbRM.Border.Class = "TextBoxBorder";
            this.tbRM.Location = new System.Drawing.Point(399, 32);
            this.tbRM.Name = "tbRM";
            this.tbRM.Size = new System.Drawing.Size(100, 20);
            this.tbRM.TabIndex = 5;
            // 
            // lblRM
            // 
            // 
            // 
            // 
            this.lblRM.BackgroundStyle.Class = "";
            this.lblRM.Location = new System.Drawing.Point(337, 32);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(75, 23);
            this.lblRM.TabIndex = 10;
            this.lblRM.Text = "客户经理";
            // 
            // tbPM
            // 
            // 
            // 
            // 
            this.tbPM.Border.Class = "TextBoxBorder";
            this.tbPM.Location = new System.Drawing.Point(227, 32);
            this.tbPM.Name = "tbPM";
            this.tbPM.Size = new System.Drawing.Size(100, 20);
            this.tbPM.TabIndex = 4;
            // 
            // lblPM
            // 
            // 
            // 
            // 
            this.lblPM.BackgroundStyle.Class = "";
            this.lblPM.Location = new System.Drawing.Point(168, 30);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(75, 23);
            this.lblPM.TabIndex = 8;
            this.lblPM.Text = "产品经理";
            // 
            // lblDepartment
            // 
            // 
            // 
            // 
            this.lblDepartment.BackgroundStyle.Class = "";
            this.lblDepartment.Location = new System.Drawing.Point(3, 32);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(75, 23);
            this.lblDepartment.TabIndex = 6;
            this.lblDepartment.Text = "所属机构";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientEDICodeColumn,
            this.ClientCoreNoColumn,
            this.ClientNameCNColumn,
            this.ClientNameEN_1Column,
            this.ClientNameEN_2Column,
            this.ProductCNColumn,
            this.ProductENColumn,
            this.AddressCNColumn,
            this.AddressENColumn,
            this.CityCNColumn,
            this.CityENColumn,
            this.ProvinceCNColumn,
            this.ProvinceENColumn,
            this.CountryNameCNColumn,
            this.PostCodeColumn,
            this.RepresentativeColumn,
            this.WebsiteColumn,
            this.ContactColumn,
            this.TelephoneColumn,
            this.EmailColumn,
            this.FaxNumberColumn,
            this.CellPhoneColumn,
            this.RegistrationNumberColumn,
            this.CompanyCodeColumn,
            this.IsGroupColumn,
            this.GroupNoColumn,
            this.ClientTypeColumn,
            this.ClientLevelColumn,
            this.IndustryColumn,
            this.DepartmentCodeColumn,
            this.DepartmentColumn,
            this.PMNameColumn,
            this.RMNameColumn,
            this.CommentColumn,
            this.CountryCodeColumn,
            this.ClientGroupColumn});
            this.dgvClients.ContextMenuStrip = this.cmuClientMgr;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvClients.Location = new System.Drawing.Point(0, 61);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvClients.RowTemplate.Height = 23;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(800, 539);
            this.dgvClients.TabIndex = 2;
            this.dgvClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            // 
            // IsGroupColumn
            // 
            this.IsGroupColumn.DataPropertyName = "IsGroup";
            this.IsGroupColumn.FalseValue = "false";
            this.IsGroupColumn.HeaderText = "是否集团客户";
            this.IsGroupColumn.Name = "IsGroupColumn";
            this.IsGroupColumn.ReadOnly = true;
            this.IsGroupColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsGroupColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsGroupColumn.TrueValue = "true";
            this.IsGroupColumn.Width = 104;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientEDICode";
            this.dataGridViewTextBoxColumn1.HeaderText = "保理代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientCoreNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "客户号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 68;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClientNameCN";
            this.dataGridViewTextBoxColumn3.HeaderText = "客户名称(中)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 98;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ClientNameEN_1";
            this.dataGridViewTextBoxColumn4.HeaderText = "客户名称(英1)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 104;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ClientNameEN_2";
            this.dataGridViewTextBoxColumn5.HeaderText = "客户名称(英2)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 104;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProductCN";
            this.dataGridViewTextBoxColumn6.HeaderText = "营业范围(中)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 98;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProductEN";
            this.dataGridViewTextBoxColumn7.HeaderText = "营业范围(英)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 98;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "AddressCN";
            this.dataGridViewTextBoxColumn8.HeaderText = "地址(中)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 74;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "AddressEN";
            this.dataGridViewTextBoxColumn9.HeaderText = "地址(英)";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 74;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CityCN";
            this.dataGridViewTextBoxColumn10.HeaderText = "城市(中)";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 74;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CityEN";
            this.dataGridViewTextBoxColumn11.HeaderText = "城市(英)";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 74;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ProvinceCN";
            this.dataGridViewTextBoxColumn12.HeaderText = "省/州(中)";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 79;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ProvinceEN";
            this.dataGridViewTextBoxColumn13.HeaderText = "省/州(英)";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 79;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CountryNameCN";
            this.dataGridViewTextBoxColumn14.HeaderText = "国家";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 56;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PostCode";
            this.dataGridViewTextBoxColumn15.HeaderText = "邮编";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 56;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Representative";
            this.dataGridViewTextBoxColumn16.HeaderText = "公司法人/负责人";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 121;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Website";
            this.dataGridViewTextBoxColumn17.HeaderText = "网址";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 56;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Contact";
            this.dataGridViewTextBoxColumn18.HeaderText = "联系人";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 68;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn19.HeaderText = "联系电话";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 80;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn20.HeaderText = "Email";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 57;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "FaxNumber";
            this.dataGridViewTextBoxColumn21.HeaderText = "传真";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 56;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "CellPhone";
            this.dataGridViewTextBoxColumn22.HeaderText = "手机";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 56;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "RegistrationNumber";
            this.dataGridViewTextBoxColumn23.HeaderText = "营业执照号码";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 104;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "CompanyCode";
            this.dataGridViewTextBoxColumn24.HeaderText = "组织机构代码";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 104;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "GroupNo";
            this.dataGridViewTextBoxColumn25.HeaderText = "所属集团客户号";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 116;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "ClientType";
            this.dataGridViewTextBoxColumn26.HeaderText = "客户类别";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 80;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "ClientLevel";
            this.dataGridViewTextBoxColumn27.HeaderText = "客户级别";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 80;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Industry";
            this.dataGridViewTextBoxColumn28.HeaderText = "所属行业";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 80;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "BranchCode";
            this.dataGridViewTextBoxColumn29.HeaderText = "所属机构代码";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Visible = false;
            this.dataGridViewTextBoxColumn29.Width = 104;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn30.HeaderText = "所属机构";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 80;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "PMName";
            this.dataGridViewTextBoxColumn31.HeaderText = "产品经理";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 80;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "RMName";
            this.dataGridViewTextBoxColumn32.HeaderText = "客户经理";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 80;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn33.HeaderText = "备注";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 56;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "CountryCode";
            this.dataGridViewTextBoxColumn34.HeaderText = "CountryCode";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Visible = false;
            this.dataGridViewTextBoxColumn34.Width = 93;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "ClientGroup";
            this.dataGridViewTextBoxColumn35.HeaderText = "ClientGroup";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Visible = false;
            this.dataGridViewTextBoxColumn35.Width = 87;
            // 
            // clientEDICodeColumn
            // 
            this.clientEDICodeColumn.DataPropertyName = "ClientEDICode";
            this.clientEDICodeColumn.HeaderText = "保理代码";
            this.clientEDICodeColumn.Name = "clientEDICodeColumn";
            this.clientEDICodeColumn.ReadOnly = true;
            this.clientEDICodeColumn.Width = 80;
            // 
            // ClientCoreNoColumn
            // 
            this.ClientCoreNoColumn.DataPropertyName = "ClientCoreNo";
            this.ClientCoreNoColumn.HeaderText = "客户号";
            this.ClientCoreNoColumn.Name = "ClientCoreNoColumn";
            this.ClientCoreNoColumn.ReadOnly = true;
            this.ClientCoreNoColumn.Width = 68;
            // 
            // ClientNameCNColumn
            // 
            this.ClientNameCNColumn.DataPropertyName = "ClientNameCN";
            this.ClientNameCNColumn.HeaderText = "客户名称(中)";
            this.ClientNameCNColumn.Name = "ClientNameCNColumn";
            this.ClientNameCNColumn.ReadOnly = true;
            this.ClientNameCNColumn.Width = 98;
            // 
            // ClientNameEN_1Column
            // 
            this.ClientNameEN_1Column.DataPropertyName = "ClientNameEN_1";
            this.ClientNameEN_1Column.HeaderText = "客户名称(英1)";
            this.ClientNameEN_1Column.Name = "ClientNameEN_1Column";
            this.ClientNameEN_1Column.ReadOnly = true;
            this.ClientNameEN_1Column.Width = 104;
            // 
            // ClientNameEN_2Column
            // 
            this.ClientNameEN_2Column.DataPropertyName = "ClientNameEN_2";
            this.ClientNameEN_2Column.HeaderText = "客户名称(英2)";
            this.ClientNameEN_2Column.Name = "ClientNameEN_2Column";
            this.ClientNameEN_2Column.ReadOnly = true;
            this.ClientNameEN_2Column.Width = 104;
            // 
            // ProductCNColumn
            // 
            this.ProductCNColumn.DataPropertyName = "ProductCN";
            this.ProductCNColumn.HeaderText = "营业范围(中)";
            this.ProductCNColumn.Name = "ProductCNColumn";
            this.ProductCNColumn.ReadOnly = true;
            this.ProductCNColumn.Width = 98;
            // 
            // ProductENColumn
            // 
            this.ProductENColumn.DataPropertyName = "ProductEN";
            this.ProductENColumn.HeaderText = "营业范围(英)";
            this.ProductENColumn.Name = "ProductENColumn";
            this.ProductENColumn.ReadOnly = true;
            this.ProductENColumn.Width = 98;
            // 
            // AddressCNColumn
            // 
            this.AddressCNColumn.DataPropertyName = "AddressCN";
            this.AddressCNColumn.HeaderText = "地址(中)";
            this.AddressCNColumn.Name = "AddressCNColumn";
            this.AddressCNColumn.ReadOnly = true;
            this.AddressCNColumn.Width = 74;
            // 
            // AddressENColumn
            // 
            this.AddressENColumn.DataPropertyName = "AddressEN";
            this.AddressENColumn.HeaderText = "地址(英)";
            this.AddressENColumn.Name = "AddressENColumn";
            this.AddressENColumn.ReadOnly = true;
            this.AddressENColumn.Width = 74;
            // 
            // CityCNColumn
            // 
            this.CityCNColumn.DataPropertyName = "CityCN";
            this.CityCNColumn.HeaderText = "城市(中)";
            this.CityCNColumn.Name = "CityCNColumn";
            this.CityCNColumn.ReadOnly = true;
            this.CityCNColumn.Width = 74;
            // 
            // CityENColumn
            // 
            this.CityENColumn.DataPropertyName = "CityEN";
            this.CityENColumn.HeaderText = "城市(英)";
            this.CityENColumn.Name = "CityENColumn";
            this.CityENColumn.ReadOnly = true;
            this.CityENColumn.Width = 74;
            // 
            // ProvinceCNColumn
            // 
            this.ProvinceCNColumn.DataPropertyName = "ProvinceCN";
            this.ProvinceCNColumn.HeaderText = "省/州(中)";
            this.ProvinceCNColumn.Name = "ProvinceCNColumn";
            this.ProvinceCNColumn.ReadOnly = true;
            this.ProvinceCNColumn.Width = 79;
            // 
            // ProvinceENColumn
            // 
            this.ProvinceENColumn.DataPropertyName = "ProvinceEN";
            this.ProvinceENColumn.HeaderText = "省/州(英)";
            this.ProvinceENColumn.Name = "ProvinceENColumn";
            this.ProvinceENColumn.ReadOnly = true;
            this.ProvinceENColumn.Width = 79;
            // 
            // CountryNameCNColumn
            // 
            this.CountryNameCNColumn.DataPropertyName = "CountryNameCN";
            this.CountryNameCNColumn.HeaderText = "国家";
            this.CountryNameCNColumn.Name = "CountryNameCNColumn";
            this.CountryNameCNColumn.ReadOnly = true;
            this.CountryNameCNColumn.Width = 56;
            // 
            // PostCodeColumn
            // 
            this.PostCodeColumn.DataPropertyName = "PostCode";
            this.PostCodeColumn.HeaderText = "邮编";
            this.PostCodeColumn.Name = "PostCodeColumn";
            this.PostCodeColumn.ReadOnly = true;
            this.PostCodeColumn.Width = 56;
            // 
            // RepresentativeColumn
            // 
            this.RepresentativeColumn.DataPropertyName = "Representative";
            this.RepresentativeColumn.HeaderText = "公司法人/负责人";
            this.RepresentativeColumn.Name = "RepresentativeColumn";
            this.RepresentativeColumn.ReadOnly = true;
            this.RepresentativeColumn.Width = 121;
            // 
            // WebsiteColumn
            // 
            this.WebsiteColumn.DataPropertyName = "Website";
            this.WebsiteColumn.HeaderText = "网址";
            this.WebsiteColumn.Name = "WebsiteColumn";
            this.WebsiteColumn.ReadOnly = true;
            this.WebsiteColumn.Width = 56;
            // 
            // ContactColumn
            // 
            this.ContactColumn.DataPropertyName = "Contact";
            this.ContactColumn.HeaderText = "联系人";
            this.ContactColumn.Name = "ContactColumn";
            this.ContactColumn.ReadOnly = true;
            this.ContactColumn.Width = 68;
            // 
            // TelephoneColumn
            // 
            this.TelephoneColumn.DataPropertyName = "Telephone";
            this.TelephoneColumn.HeaderText = "联系电话";
            this.TelephoneColumn.Name = "TelephoneColumn";
            this.TelephoneColumn.ReadOnly = true;
            this.TelephoneColumn.Width = 80;
            // 
            // EmailColumn
            // 
            this.EmailColumn.DataPropertyName = "Email";
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            this.EmailColumn.Width = 57;
            // 
            // FaxNumberColumn
            // 
            this.FaxNumberColumn.DataPropertyName = "FaxNumber";
            this.FaxNumberColumn.HeaderText = "传真";
            this.FaxNumberColumn.Name = "FaxNumberColumn";
            this.FaxNumberColumn.ReadOnly = true;
            this.FaxNumberColumn.Width = 56;
            // 
            // CellPhoneColumn
            // 
            this.CellPhoneColumn.DataPropertyName = "CellPhone";
            this.CellPhoneColumn.HeaderText = "手机";
            this.CellPhoneColumn.Name = "CellPhoneColumn";
            this.CellPhoneColumn.ReadOnly = true;
            this.CellPhoneColumn.Width = 56;
            // 
            // RegistrationNumberColumn
            // 
            this.RegistrationNumberColumn.DataPropertyName = "RegistrationNumber";
            this.RegistrationNumberColumn.HeaderText = "营业执照号码";
            this.RegistrationNumberColumn.Name = "RegistrationNumberColumn";
            this.RegistrationNumberColumn.ReadOnly = true;
            this.RegistrationNumberColumn.Width = 104;
            // 
            // CompanyCodeColumn
            // 
            this.CompanyCodeColumn.DataPropertyName = "CompanyCode";
            this.CompanyCodeColumn.HeaderText = "组织机构代码";
            this.CompanyCodeColumn.Name = "CompanyCodeColumn";
            this.CompanyCodeColumn.ReadOnly = true;
            this.CompanyCodeColumn.Width = 104;
            // 
            // GroupNoColumn
            // 
            this.GroupNoColumn.DataPropertyName = "GroupNo";
            this.GroupNoColumn.HeaderText = "所属集团客户号";
            this.GroupNoColumn.Name = "GroupNoColumn";
            this.GroupNoColumn.ReadOnly = true;
            this.GroupNoColumn.Width = 116;
            // 
            // ClientTypeColumn
            // 
            this.ClientTypeColumn.DataPropertyName = "ClientType";
            this.ClientTypeColumn.HeaderText = "客户类别";
            this.ClientTypeColumn.Name = "ClientTypeColumn";
            this.ClientTypeColumn.ReadOnly = true;
            this.ClientTypeColumn.Width = 80;
            // 
            // ClientLevelColumn
            // 
            this.ClientLevelColumn.DataPropertyName = "ClientLevel";
            this.ClientLevelColumn.HeaderText = "客户级别";
            this.ClientLevelColumn.Name = "ClientLevelColumn";
            this.ClientLevelColumn.ReadOnly = true;
            this.ClientLevelColumn.Width = 80;
            // 
            // IndustryColumn
            // 
            this.IndustryColumn.DataPropertyName = "Industry";
            this.IndustryColumn.HeaderText = "所属行业";
            this.IndustryColumn.Name = "IndustryColumn";
            this.IndustryColumn.ReadOnly = true;
            this.IndustryColumn.Width = 80;
            // 
            // DepartmentCodeColumn
            // 
            this.DepartmentCodeColumn.DataPropertyName = "BranchCode";
            this.DepartmentCodeColumn.HeaderText = "所属机构代码";
            this.DepartmentCodeColumn.Name = "DepartmentCodeColumn";
            this.DepartmentCodeColumn.ReadOnly = true;
            this.DepartmentCodeColumn.Visible = false;
            this.DepartmentCodeColumn.Width = 104;
            // 
            // DepartmentColumn
            // 
            this.DepartmentColumn.DataPropertyName = "Department";
            this.DepartmentColumn.HeaderText = "所属机构";
            this.DepartmentColumn.Name = "DepartmentColumn";
            this.DepartmentColumn.ReadOnly = true;
            this.DepartmentColumn.Width = 80;
            // 
            // PMNameColumn
            // 
            this.PMNameColumn.DataPropertyName = "PMName";
            this.PMNameColumn.HeaderText = "产品经理";
            this.PMNameColumn.Name = "PMNameColumn";
            this.PMNameColumn.ReadOnly = true;
            this.PMNameColumn.Width = 80;
            // 
            // RMNameColumn
            // 
            this.RMNameColumn.DataPropertyName = "RMName";
            this.RMNameColumn.HeaderText = "客户经理";
            this.RMNameColumn.Name = "RMNameColumn";
            this.RMNameColumn.ReadOnly = true;
            this.RMNameColumn.Width = 80;
            // 
            // CommentColumn
            // 
            this.CommentColumn.DataPropertyName = "Comment";
            this.CommentColumn.HeaderText = "备注";
            this.CommentColumn.Name = "CommentColumn";
            this.CommentColumn.ReadOnly = true;
            this.CommentColumn.Width = 56;
            // 
            // CountryCodeColumn
            // 
            this.CountryCodeColumn.DataPropertyName = "CountryCode";
            this.CountryCodeColumn.HeaderText = "CountryCode";
            this.CountryCodeColumn.Name = "CountryCodeColumn";
            this.CountryCodeColumn.ReadOnly = true;
            this.CountryCodeColumn.Visible = false;
            this.CountryCodeColumn.Width = 93;
            // 
            // ClientGroupColumn
            // 
            this.ClientGroupColumn.DataPropertyName = "ClientGroup";
            this.ClientGroupColumn.HeaderText = "ClientGroup";
            this.ClientGroupColumn.Name = "ClientGroupColumn";
            this.ClientGroupColumn.ReadOnly = true;
            this.ClientGroupColumn.Visible = false;
            this.ClientGroupColumn.Width = 87;
            // 
            // ClientMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.pnlQuery);
            this.Name = "ClientMgr";
            this.Size = new System.Drawing.Size(800, 600);
            this.cmuClientMgr.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsSigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
    }
}

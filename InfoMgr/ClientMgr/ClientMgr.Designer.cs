//-----------------------------------------------------------------------
// <copyright file="ClientMgr.Designer.cs" company="Yiming Liu@Fudan">
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
		#region?Fields?(37)?

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCaseType;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbClientType;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbIsContractSigned;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLocation;
        private System.Windows.Forms.ContextMenuStrip cmuClientMgr;
        private System.ComponentModel.IContainer components;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClients;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblLocation;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientCreditLineNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientExport;
        private System.Windows.Forms.ToolStripMenuItem menuItemContractNew;
        private DevComponents.DotNetBar.PanelEx pnlQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientEDICode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		#endregion?Fields?

		#region?Methods?(1)?

		//?Protected?Methods?(1)?

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

		#endregion?Methods?



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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblClientType = new DevComponents.DotNetBar.LabelX();
            this.lblClientNo = new DevComponents.DotNetBar.LabelX();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.lblRM = new DevComponents.DotNetBar.LabelX();
            this.lblCaseType = new DevComponents.DotNetBar.LabelX();
            this.cmuClientMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemClientSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemClientNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientCreditLineNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContractNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClientDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemClientExport = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlQuery = new DevComponents.DotNetBar.PanelEx();
            this.cbLocation = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblLocation = new DevComponents.DotNetBar.LabelX();
            this.cbCaseType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.cbIsContractSigned = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.cbClientType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.tbClientEDICode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbRM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvClients = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.clientEDICodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientCoreNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameENColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressENColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryNameCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndustryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuClientMgr.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientType
            // 
            this.lblClientType.AutoSize = true;
            // 
            // 
            // 
            this.lblClientType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClientType.Location = new System.Drawing.Point(340, 6);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(56, 18);
            this.lblClientType.TabIndex = 4;
            this.lblClientType.Text = "客户类型";
            this.lblClientType.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblClientNo
            // 
            this.lblClientNo.AutoSize = true;
            // 
            // 
            // 
            this.lblClientNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClientNo.Location = new System.Drawing.Point(3, 6);
            this.lblClientNo.Name = "lblClientNo";
            this.lblClientNo.Size = new System.Drawing.Size(56, 18);
            this.lblClientNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.lblClientNo.TabIndex = 0;
            this.lblClientNo.Text = "保理代码";
            this.lblClientNo.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClientName.Location = new System.Drawing.Point(170, 6);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(56, 18);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "客户名称";
            this.lblClientName.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblRM
            // 
            this.lblRM.AutoSize = true;
            // 
            // 
            // 
            this.lblRM.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblRM.Location = new System.Drawing.Point(170, 31);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(56, 18);
            this.lblRM.TabIndex = 11;
            this.lblRM.Text = "客户经理";
            this.lblRM.TextLineAlignment = System.Drawing.StringAlignment.Far;
            // 
            // lblCaseType
            // 
            this.lblCaseType.AutoSize = true;
            // 
            // 
            // 
            this.lblCaseType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCaseType.Location = new System.Drawing.Point(509, 8);
            this.lblCaseType.Name = "lblCaseType";
            this.lblCaseType.Size = new System.Drawing.Size(56, 18);
            this.lblCaseType.TabIndex = 16;
            this.lblCaseType.Text = "案件类型";
            this.lblCaseType.TextLineAlignment = System.Drawing.StringAlignment.Far;
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
            this.menuItemClientDelete,
            this.toolStripSeparator1,
            this.menuItemClientExport});
            this.cmuClientMgr.Name = "contextMenuClientMgr";
            this.cmuClientMgr.Size = new System.Drawing.Size(149, 170);
            // 
            // menuItemClientSelect
            // 
            this.menuItemClientSelect.Name = "menuItemClientSelect";
            this.menuItemClientSelect.Size = new System.Drawing.Size(148, 22);
            this.menuItemClientSelect.Text = "选定客户";
            this.menuItemClientSelect.Click += new System.EventHandler(this.SelectClient);
            // 
            // menuItemClientDetail
            // 
            this.menuItemClientDetail.Name = "menuItemClientDetail";
            this.menuItemClientDetail.Size = new System.Drawing.Size(148, 22);
            this.menuItemClientDetail.Text = "详细信息";
            this.menuItemClientDetail.Click += new System.EventHandler(this.DetailClient);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(145, 6);
            // 
            // menuItemClientNew
            // 
            this.menuItemClientNew.Name = "menuItemClientNew";
            this.menuItemClientNew.Size = new System.Drawing.Size(148, 22);
            this.menuItemClientNew.Text = "新建客户";
            this.menuItemClientNew.Click += new System.EventHandler(this.NewClient);
            // 
            // menuItemClientCreditLineNew
            // 
            this.menuItemClientCreditLineNew.Name = "menuItemClientCreditLineNew";
            this.menuItemClientCreditLineNew.Size = new System.Drawing.Size(148, 22);
            this.menuItemClientCreditLineNew.Text = "新建额度信息";
            this.menuItemClientCreditLineNew.Click += new System.EventHandler(this.NewClientCreditLine);
            // 
            // menuItemContractNew
            // 
            this.menuItemContractNew.Name = "menuItemContractNew";
            this.menuItemContractNew.Size = new System.Drawing.Size(148, 22);
            this.menuItemContractNew.Text = "新建保理合同";
            this.menuItemContractNew.Click += new System.EventHandler(this.NewContract);
            // 
            // menuItemClientDelete
            // 
            this.menuItemClientDelete.Name = "menuItemClientDelete";
            this.menuItemClientDelete.Size = new System.Drawing.Size(148, 22);
            this.menuItemClientDelete.Text = "删除客户";
            this.menuItemClientDelete.Click += new System.EventHandler(this.DeleteClient);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // menuItemClientExport
            // 
            this.menuItemClientExport.Name = "menuItemClientExport";
            this.menuItemClientExport.Size = new System.Drawing.Size(148, 22);
            this.menuItemClientExport.Text = "导出所选客户";
            this.menuItemClientExport.Click += new System.EventHandler(this.ExportClients);
            // 
            // pnlQuery
            // 
            this.pnlQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.pnlQuery.Controls.Add(this.cbLocation);
            this.pnlQuery.Controls.Add(this.lblLocation);
            this.pnlQuery.Controls.Add(this.cbCaseType);
            this.pnlQuery.Controls.Add(this.lblCaseType);
            this.pnlQuery.Controls.Add(this.btnReset);
            this.pnlQuery.Controls.Add(this.cbIsContractSigned);
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
            this.pnlQuery.DisabledBackColor = System.Drawing.Color.Empty;
            this.pnlQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuery.Location = new System.Drawing.Point(0, 0);
            this.pnlQuery.Name = "pnlQuery";
            this.pnlQuery.Size = new System.Drawing.Size(937, 56);
            this.pnlQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pnlQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pnlQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlQuery.Style.GradientAngle = 90;
            this.pnlQuery.TabIndex = 1;
            // 
            // cbLocation
            // 
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.ItemHeight = 14;
            this.cbLocation.Location = new System.Drawing.Point(59, 31);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(101, 20);
            this.cbLocation.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbLocation.TabIndex = 25;
            // 
            // lblLocation
            // 
            // 
            // 
            // 
            this.lblLocation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLocation.Location = new System.Drawing.Point(3, 29);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(59, 21);
            this.lblLocation.TabIndex = 24;
            this.lblLocation.Text = "业务地区";
            // 
            // cbCaseType
            // 
            this.cbCaseType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCaseType.ItemHeight = 14;
            this.cbCaseType.Items.AddRange(new object[] {
            "全部",
            "进口保理",
            "出口保理",
            "国内保理"});
            this.cbCaseType.Location = new System.Drawing.Point(566, 6);
            this.cbCaseType.Name = "cbCaseType";
            this.cbCaseType.Size = new System.Drawing.Size(100, 20);
            this.cbCaseType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbCaseType.TabIndex = 17;
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Location = new System.Drawing.Point(672, 30);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 21);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "清空";
            this.btnReset.Click += new System.EventHandler(this.Reset);
            // 
            // cbIsContractSigned
            // 
            this.cbIsContractSigned.AutoSize = true;
            // 
            // 
            // 
            this.cbIsContractSigned.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbIsContractSigned.Location = new System.Drawing.Point(340, 32);
            this.cbIsContractSigned.Name = "cbIsContractSigned";
            this.cbIsContractSigned.Size = new System.Drawing.Size(125, 18);
            this.cbIsContractSigned.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbIsContractSigned.TabIndex = 6;
            this.cbIsContractSigned.Text = "是否签订保理合同";
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Location = new System.Drawing.Point(738, 34);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 15;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(672, 6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(60, 20);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnQuery.TabIndex = 13;
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
            "三资"});
            this.cbClientType.Location = new System.Drawing.Point(397, 6);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(100, 20);
            this.cbClientType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbClientType.TabIndex = 5;
            // 
            // tbClientEDICode
            // 
            // 
            // 
            // 
            this.tbClientEDICode.Border.Class = "TextBoxBorder";
            this.tbClientEDICode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbClientEDICode.Location = new System.Drawing.Point(60, 6);
            this.tbClientEDICode.Name = "tbClientEDICode";
            this.tbClientEDICode.Size = new System.Drawing.Size(100, 21);
            this.tbClientEDICode.TabIndex = 1;
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbClientName.Location = new System.Drawing.Point(227, 6);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 21);
            this.tbClientName.TabIndex = 3;
            // 
            // tbRM
            // 
            // 
            // 
            // 
            this.tbRM.Border.Class = "TextBoxBorder";
            this.tbRM.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbRM.Location = new System.Drawing.Point(227, 30);
            this.tbRM.Name = "tbRM";
            this.tbRM.Size = new System.Drawing.Size(100, 21);
            this.tbRM.TabIndex = 12;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.ClientNameENColumn,
            this.AddressCNColumn,
            this.AddressENColumn,
            this.CountryNameCNColumn,
            this.colClientType,
            this.GroupNoColumn,
            this.IndustryColumn,
            this.DepartmentCodeColumn,
            this.LocationColumn,
            this.RMColumn});
            this.dgvClients.ContextMenuStrip = this.cmuClientMgr;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvClients.Location = new System.Drawing.Point(0, 56);
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClients.RowTemplate.Height = 23;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvClients.Size = new System.Drawing.Size(937, 498);
            this.dgvClients.TabIndex = 2;
            this.dgvClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvClients.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvClientsRowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ClientEDICode";
            this.dataGridViewTextBoxColumn1.FillWeight = 81.40282F;
            this.dataGridViewTextBoxColumn1.HeaderText = "保理代码";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 62;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ClientCoreNo";
            this.dataGridViewTextBoxColumn2.FillWeight = 81.40282F;
            this.dataGridViewTextBoxColumn2.HeaderText = "客户号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 62;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClientNameCN";
            this.dataGridViewTextBoxColumn3.FillWeight = 304.5686F;
            this.dataGridViewTextBoxColumn3.HeaderText = "客户名称(中)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 232;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ClientNameEN";
            this.dataGridViewTextBoxColumn4.FillWeight = 81.40282F;
            this.dataGridViewTextBoxColumn4.HeaderText = "客户名称(英)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AddressCN";
            this.dataGridViewTextBoxColumn5.FillWeight = 81.40282F;
            this.dataGridViewTextBoxColumn5.HeaderText = "地址(中)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 62;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AddressEN";
            this.dataGridViewTextBoxColumn6.FillWeight = 81.40282F;
            this.dataGridViewTextBoxColumn6.HeaderText = "地址(英)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 62;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CountryCode";
            this.dataGridViewTextBoxColumn7.FillWeight = 81.40282F;
            this.dataGridViewTextBoxColumn7.HeaderText = "国家";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 62;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ClientType";
            this.dataGridViewTextBoxColumn8.FillWeight = 81.40282F;
            this.dataGridViewTextBoxColumn8.HeaderText = "客户类型";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 62;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "GroupEDICode";
            this.dataGridViewTextBoxColumn9.FillWeight = 81.40282F;
            this.dataGridViewTextBoxColumn9.HeaderText = "所属集团客户号";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 62;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Industry";
            this.dataGridViewTextBoxColumn10.FillWeight = 81.40282F;
            this.dataGridViewTextBoxColumn10.HeaderText = "所属行业";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 62;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "BranchCode";
            this.dataGridViewTextBoxColumn11.HeaderText = "所属机构代码";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn12.FillWeight = 81.40282F;
            this.dataGridViewTextBoxColumn12.HeaderText = "所属机构";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 62;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "PMName";
            this.dataGridViewTextBoxColumn13.FillWeight = 81.40282F;
            this.dataGridViewTextBoxColumn13.HeaderText = "产品经理";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 62;
            // 
            // clientEDICodeColumn
            // 
            this.clientEDICodeColumn.DataPropertyName = "ClientEDICode";
            this.clientEDICodeColumn.FillWeight = 81.40282F;
            this.clientEDICodeColumn.HeaderText = "保理代码";
            this.clientEDICodeColumn.Name = "clientEDICodeColumn";
            this.clientEDICodeColumn.ReadOnly = true;
            // 
            // ClientCoreNoColumn
            // 
            this.ClientCoreNoColumn.DataPropertyName = "ClientCoreNo";
            this.ClientCoreNoColumn.FillWeight = 81.40282F;
            this.ClientCoreNoColumn.HeaderText = "客户号";
            this.ClientCoreNoColumn.Name = "ClientCoreNoColumn";
            this.ClientCoreNoColumn.ReadOnly = true;
            // 
            // ClientNameCNColumn
            // 
            this.ClientNameCNColumn.DataPropertyName = "ClientNameCN";
            this.ClientNameCNColumn.FillWeight = 304.5686F;
            this.ClientNameCNColumn.HeaderText = "客户名称(中)";
            this.ClientNameCNColumn.Name = "ClientNameCNColumn";
            this.ClientNameCNColumn.ReadOnly = true;
            // 
            // ClientNameENColumn
            // 
            this.ClientNameENColumn.DataPropertyName = "ClientNameEN";
            this.ClientNameENColumn.FillWeight = 81.40282F;
            this.ClientNameENColumn.HeaderText = "客户名称(英)";
            this.ClientNameENColumn.Name = "ClientNameENColumn";
            this.ClientNameENColumn.ReadOnly = true;
            // 
            // AddressCNColumn
            // 
            this.AddressCNColumn.DataPropertyName = "AddressCN";
            this.AddressCNColumn.FillWeight = 81.40282F;
            this.AddressCNColumn.HeaderText = "地址(中)";
            this.AddressCNColumn.Name = "AddressCNColumn";
            this.AddressCNColumn.ReadOnly = true;
            // 
            // AddressENColumn
            // 
            this.AddressENColumn.DataPropertyName = "AddressEN";
            this.AddressENColumn.FillWeight = 81.40282F;
            this.AddressENColumn.HeaderText = "地址(英)";
            this.AddressENColumn.Name = "AddressENColumn";
            this.AddressENColumn.ReadOnly = true;
            // 
            // CountryNameCNColumn
            // 
            this.CountryNameCNColumn.DataPropertyName = "CountryCode";
            this.CountryNameCNColumn.FillWeight = 81.40282F;
            this.CountryNameCNColumn.HeaderText = "国家";
            this.CountryNameCNColumn.Name = "CountryNameCNColumn";
            this.CountryNameCNColumn.ReadOnly = true;
            // 
            // colClientType
            // 
            this.colClientType.DataPropertyName = "ClientType";
            this.colClientType.FillWeight = 81.40282F;
            this.colClientType.HeaderText = "客户类型";
            this.colClientType.Name = "colClientType";
            this.colClientType.ReadOnly = true;
            // 
            // GroupNoColumn
            // 
            this.GroupNoColumn.DataPropertyName = "GroupEDICode";
            this.GroupNoColumn.FillWeight = 81.40282F;
            this.GroupNoColumn.HeaderText = "所属集团客户号";
            this.GroupNoColumn.Name = "GroupNoColumn";
            this.GroupNoColumn.ReadOnly = true;
            // 
            // IndustryColumn
            // 
            this.IndustryColumn.DataPropertyName = "Industry";
            this.IndustryColumn.FillWeight = 81.40282F;
            this.IndustryColumn.HeaderText = "所属行业";
            this.IndustryColumn.Name = "IndustryColumn";
            this.IndustryColumn.ReadOnly = true;
            // 
            // DepartmentCodeColumn
            // 
            this.DepartmentCodeColumn.DataPropertyName = "BranchCode";
            this.DepartmentCodeColumn.HeaderText = "所属机构代码";
            this.DepartmentCodeColumn.Name = "DepartmentCodeColumn";
            this.DepartmentCodeColumn.ReadOnly = true;
            this.DepartmentCodeColumn.Visible = false;
            // 
            // LocationColumn
            // 
            this.LocationColumn.DataPropertyName = "Location";
            this.LocationColumn.HeaderText = "业务地区";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            // 
            // RMColumn
            // 
            this.RMColumn.DataPropertyName = "RMName";
            this.RMColumn.HeaderText = "客户经理";
            this.RMColumn.Name = "RMColumn";
            this.RMColumn.ReadOnly = true;
            // 
            // ClientMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.pnlQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "ClientMgr";
            this.Size = new System.Drawing.Size(937, 554);
            this.cmuClientMgr.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevComponents.DotNetBar.LabelX lblClientType;
        private DevComponents.DotNetBar.LabelX lblClientNo;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.LabelX lblRM;
        private DevComponents.DotNetBar.LabelX lblCaseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEDICodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCoreNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameENColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressENColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryNameCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndustryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMColumn;
    }
}

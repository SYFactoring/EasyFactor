﻿//-----------------------------------------------------------------------
// <copyright file="ClientMgrUI.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    /// <summary>
    /// Client Management User Interface Designer
    /// </summary>
    partial class ClientMgr
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ContextMenuStrip contextMenuClientMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewClient;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdateClient;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteClient;

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
            this.contextMenuClientMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewClient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewClientCreditCover = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpdateClient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteClient = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemImportClients = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlQuery = new DevComponents.DotNetBar.PanelEx();
            this.comboTreeDepartment = new DevComponents.DotNetBar.Controls.ComboTree();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.cbClientType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
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
            this.ClientCoreNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientEDICodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameEN1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameEN_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Industry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Representative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wetsiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuClientMgr.SuspendLayout();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuClientMgr
            // 
            this.contextMenuClientMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelect,
            this.menuItemDetail,
            this.toolStripSeparator,
            this.menuItemEdit});
            this.contextMenuClientMgr.Name = "contextMenuClientMgr";
            this.contextMenuClientMgr.Size = new System.Drawing.Size(99, 76);
            // 
            // menuItemSelect
            // 
            this.menuItemSelect.Name = "menuItemSelect";
            this.menuItemSelect.Size = new System.Drawing.Size(98, 22);
            this.menuItemSelect.Text = "选定";
            this.menuItemSelect.Click += new System.EventHandler(this.SelectClient);
            // 
            // menuItemDetail
            // 
            this.menuItemDetail.Name = "menuItemDetail";
            this.menuItemDetail.Size = new System.Drawing.Size(98, 22);
            this.menuItemDetail.Text = "详细";
            this.menuItemDetail.Click += new System.EventHandler(this.DetailClient);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(95, 6);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewClient,
            this.menuItemNewClientCreditCover,
            this.menuItemUpdateClient,
            this.menuItemDeleteClient,
            this.menuItemImportClients});
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(98, 22);
            this.menuItemEdit.Text = "维护";
            // 
            // menuItemNewClient
            // 
            this.menuItemNewClient.Name = "menuItemNewClient";
            this.menuItemNewClient.Size = new System.Drawing.Size(146, 22);
            this.menuItemNewClient.Text = "新建客户";
            this.menuItemNewClient.Click += new System.EventHandler(this.NewClient);
            // 
            // menuItemNewClientCreditCover
            // 
            this.menuItemNewClientCreditCover.Name = "menuItemNewClientCreditCover";
            this.menuItemNewClientCreditCover.Size = new System.Drawing.Size(146, 22);
            this.menuItemNewClientCreditCover.Text = "新建额度信息";
            this.menuItemNewClientCreditCover.Click += new System.EventHandler(this.UpdateClientCreditLine);
            // 
            // menuItemUpdateClient
            // 
            this.menuItemUpdateClient.Name = "menuItemUpdateClient";
            this.menuItemUpdateClient.Size = new System.Drawing.Size(146, 22);
            this.menuItemUpdateClient.Text = "更新客户";
            this.menuItemUpdateClient.Click += new System.EventHandler(this.UpdateClient);
            // 
            // menuItemDeleteClient
            // 
            this.menuItemDeleteClient.Name = "menuItemDeleteClient";
            this.menuItemDeleteClient.Size = new System.Drawing.Size(146, 22);
            this.menuItemDeleteClient.Text = "删除客户";
            this.menuItemDeleteClient.Click += new System.EventHandler(this.DeleteClient);
            // 
            // menuItemImportClients
            // 
            this.menuItemImportClients.Name = "menuItemImportClients";
            this.menuItemImportClients.Size = new System.Drawing.Size(146, 22);
            this.menuItemImportClients.Text = "导入客户";
            this.menuItemImportClients.Click += new System.EventHandler(this.ImportClients);
            // 
            // pnlQuery
            // 
            this.pnlQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlQuery.Controls.Add(this.comboTreeDepartment);
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
            // comboTreeDepartment
            // 
            this.comboTreeDepartment.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.comboTreeDepartment.BackgroundStyle.Class = "TextBoxBorder";
            this.comboTreeDepartment.ButtonDropDown.Visible = true;
            this.comboTreeDepartment.ColumnsVisible = false;
            this.comboTreeDepartment.DropDownWidth = 150;
            this.comboTreeDepartment.Location = new System.Drawing.Point(60, 32);
            this.comboTreeDepartment.Name = "comboTreeDepartment";
            this.comboTreeDepartment.Size = new System.Drawing.Size(100, 23);
            this.comboTreeDepartment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboTreeDepartment.TabIndex = 7;
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
            this.lblCount.Size = new System.Drawing.Size(75, 23);
            this.lblCount.TabIndex = 13;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(505, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 49);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryClients);
            // 
            // cbClientType
            // 
            this.cbClientType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientType.ItemHeight = 14;
            this.cbClientType.Items.AddRange(new object[] {
            this.comboItem6,
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5});
            this.cbClientType.Location = new System.Drawing.Point(399, 6);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(100, 20);
            this.cbClientType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbClientType.TabIndex = 5;
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "全部";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "国有";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "民营";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "三资";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "私营";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "中外合资";
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
            this.tbClientEDICode.TabIndex = 1;
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
            this.tbClientName.TabIndex = 3;
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
            this.tbRM.TabIndex = 11;
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
            this.tbPM.TabIndex = 9;
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
            // dgvClient
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.AutoGenerateColumns = false;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.ClientCoreNoColumn,
            this.clientEDICodeColumn,
            this.clientNameCNDataGridViewTextBoxColumn,
            this.clientNameEN1DataGridViewTextBoxColumn,
            this.ClientNameEN_2Column,
            this.clientTypeDataGridViewTextBoxColumn,
            this.Industry,
            this.productCNDataGridViewTextBoxColumn,
            this.productENDataGridViewTextBoxColumn,
            this.addressCNDataGridViewTextBoxColumn,
            this.addressENDataGridViewTextBoxColumn,
            this.cityCNDataGridViewTextBoxColumn,
            this.cityENDataGridViewTextBoxColumn,
            this.provinceCNDataGridViewTextBoxColumn,
            this.provinceENDataGridViewTextBoxColumn,
            this.postCodeDataGridViewTextBoxColumn,
            this.CountryCode,
            this.Representative,
            this.wetsiteDataGridViewTextBoxColumn,
            this.Contact,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.faxNumberDataGridViewTextBoxColumn,
            this.cellPhoneDataGridViewTextBoxColumn,
            this.clientLevelDataGridViewTextBoxColumn,
            this.IsGroup,
            this.GroupNo,
            this.RegistrationNumber,
            this.companyCodeDataGridViewTextBoxColumn,
            this.BranchCode,
            this.pMNameDataGridViewTextBoxColumn,
            this.ColumnRMName,
            this.commentDataGridViewTextBoxColumn});
            this.dgvClients.ContextMenuStrip = this.contextMenuClientMgr;
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
            this.dgvClients.Name = "dgvClient";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowTemplate.Height = 23;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(800, 539);
            this.dgvClients.TabIndex = 2;
            this.dgvClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            // 
            // ClientCoreNoColumn
            // 
            this.ClientCoreNoColumn.DataPropertyName = "ClientCoreNo";
            this.ClientCoreNoColumn.HeaderText = "客户号";
            this.ClientCoreNoColumn.Name = "ClientCoreNoColumn";
            this.ClientCoreNoColumn.ReadOnly = true;
            this.ClientCoreNoColumn.Width = 68;
            // 
            // clientEDICodeColumn
            // 
            this.clientEDICodeColumn.DataPropertyName = "ClientEDICode";
            this.clientEDICodeColumn.HeaderText = "保理代码";
            this.clientEDICodeColumn.Name = "clientEDICodeColumn";
            this.clientEDICodeColumn.ReadOnly = true;
            this.clientEDICodeColumn.Width = 80;
            // 
            // clientNameCNDataGridViewTextBoxColumn
            // 
            this.clientNameCNDataGridViewTextBoxColumn.DataPropertyName = "ClientNameCN";
            this.clientNameCNDataGridViewTextBoxColumn.FillWeight = 247.7837F;
            this.clientNameCNDataGridViewTextBoxColumn.HeaderText = "客户名称(中)";
            this.clientNameCNDataGridViewTextBoxColumn.Name = "clientNameCNDataGridViewTextBoxColumn";
            this.clientNameCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientNameCNDataGridViewTextBoxColumn.Width = 98;
            // 
            // clientNameEN1DataGridViewTextBoxColumn
            // 
            this.clientNameEN1DataGridViewTextBoxColumn.DataPropertyName = "ClientNameEN_1";
            this.clientNameEN1DataGridViewTextBoxColumn.FillWeight = 223.7242F;
            this.clientNameEN1DataGridViewTextBoxColumn.HeaderText = "客户名称(英)";
            this.clientNameEN1DataGridViewTextBoxColumn.Name = "clientNameEN1DataGridViewTextBoxColumn";
            this.clientNameEN1DataGridViewTextBoxColumn.ReadOnly = true;
            this.clientNameEN1DataGridViewTextBoxColumn.Width = 98;
            // 
            // ClientNameEN_2Column
            // 
            this.ClientNameEN_2Column.DataPropertyName = "ClientNameEN_2";
            this.ClientNameEN_2Column.HeaderText = "客户名称(英)";
            this.ClientNameEN_2Column.Name = "ClientNameEN_2Column";
            this.ClientNameEN_2Column.ReadOnly = true;
            this.ClientNameEN_2Column.Width = 98;
            // 
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.FillWeight = 50.02522F;
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "客户类型";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            this.clientTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientTypeDataGridViewTextBoxColumn.Width = 80;
            // 
            // Industry
            // 
            this.Industry.DataPropertyName = "Industry";
            this.Industry.HeaderText = "行业类别";
            this.Industry.Name = "Industry";
            this.Industry.ReadOnly = true;
            this.Industry.Width = 80;
            // 
            // productCNDataGridViewTextBoxColumn
            // 
            this.productCNDataGridViewTextBoxColumn.DataPropertyName = "ProductCN";
            this.productCNDataGridViewTextBoxColumn.FillWeight = 60.28388F;
            this.productCNDataGridViewTextBoxColumn.HeaderText = "经营范围(中)";
            this.productCNDataGridViewTextBoxColumn.Name = "productCNDataGridViewTextBoxColumn";
            this.productCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCNDataGridViewTextBoxColumn.Width = 98;
            // 
            // productENDataGridViewTextBoxColumn
            // 
            this.productENDataGridViewTextBoxColumn.DataPropertyName = "ProductEN";
            this.productENDataGridViewTextBoxColumn.FillWeight = 55.54407F;
            this.productENDataGridViewTextBoxColumn.HeaderText = "经营范围(英)";
            this.productENDataGridViewTextBoxColumn.Name = "productENDataGridViewTextBoxColumn";
            this.productENDataGridViewTextBoxColumn.ReadOnly = true;
            this.productENDataGridViewTextBoxColumn.Width = 98;
            // 
            // addressCNDataGridViewTextBoxColumn
            // 
            this.addressCNDataGridViewTextBoxColumn.DataPropertyName = "AddressCN";
            this.addressCNDataGridViewTextBoxColumn.FillWeight = 157.0093F;
            this.addressCNDataGridViewTextBoxColumn.HeaderText = "地址(中)";
            this.addressCNDataGridViewTextBoxColumn.Name = "addressCNDataGridViewTextBoxColumn";
            this.addressCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressCNDataGridViewTextBoxColumn.Width = 74;
            // 
            // addressENDataGridViewTextBoxColumn
            // 
            this.addressENDataGridViewTextBoxColumn.DataPropertyName = "AddressEN";
            this.addressENDataGridViewTextBoxColumn.FillWeight = 144.377F;
            this.addressENDataGridViewTextBoxColumn.HeaderText = "地址(英)";
            this.addressENDataGridViewTextBoxColumn.Name = "addressENDataGridViewTextBoxColumn";
            this.addressENDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressENDataGridViewTextBoxColumn.Width = 74;
            // 
            // cityCNDataGridViewTextBoxColumn
            // 
            this.cityCNDataGridViewTextBoxColumn.DataPropertyName = "CityCN";
            this.cityCNDataGridViewTextBoxColumn.FillWeight = 132.8628F;
            this.cityCNDataGridViewTextBoxColumn.HeaderText = "城市(中)";
            this.cityCNDataGridViewTextBoxColumn.Name = "cityCNDataGridViewTextBoxColumn";
            this.cityCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityCNDataGridViewTextBoxColumn.Width = 74;
            // 
            // cityENDataGridViewTextBoxColumn
            // 
            this.cityENDataGridViewTextBoxColumn.DataPropertyName = "CityEN";
            this.cityENDataGridViewTextBoxColumn.FillWeight = 122.3677F;
            this.cityENDataGridViewTextBoxColumn.HeaderText = "城市(英)";
            this.cityENDataGridViewTextBoxColumn.Name = "cityENDataGridViewTextBoxColumn";
            this.cityENDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityENDataGridViewTextBoxColumn.Width = 74;
            // 
            // provinceCNDataGridViewTextBoxColumn
            // 
            this.provinceCNDataGridViewTextBoxColumn.DataPropertyName = "ProvinceCN";
            this.provinceCNDataGridViewTextBoxColumn.FillWeight = 121.2194F;
            this.provinceCNDataGridViewTextBoxColumn.HeaderText = "省/州(中)";
            this.provinceCNDataGridViewTextBoxColumn.Name = "provinceCNDataGridViewTextBoxColumn";
            this.provinceCNDataGridViewTextBoxColumn.ReadOnly = true;
            this.provinceCNDataGridViewTextBoxColumn.Width = 79;
            // 
            // provinceENDataGridViewTextBoxColumn
            // 
            this.provinceENDataGridViewTextBoxColumn.DataPropertyName = "ProvinceEN";
            this.provinceENDataGridViewTextBoxColumn.FillWeight = 111.0485F;
            this.provinceENDataGridViewTextBoxColumn.HeaderText = "省/州(英)";
            this.provinceENDataGridViewTextBoxColumn.Name = "provinceENDataGridViewTextBoxColumn";
            this.provinceENDataGridViewTextBoxColumn.ReadOnly = true;
            this.provinceENDataGridViewTextBoxColumn.Width = 79;
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.FillWeight = 86.2853F;
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "邮编";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            this.postCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.postCodeDataGridViewTextBoxColumn.Width = 56;
            // 
            // CountryCode
            // 
            this.CountryCode.DataPropertyName = "CountryNameCN";
            this.CountryCode.HeaderText = "国家";
            this.CountryCode.Name = "CountryCode";
            this.CountryCode.ReadOnly = true;
            this.CountryCode.Width = 56;
            // 
            // Representative
            // 
            this.Representative.DataPropertyName = "Representative";
            this.Representative.HeaderText = "公司法人/负责人";
            this.Representative.Name = "Representative";
            this.Representative.ReadOnly = true;
            this.Representative.Width = 121;
            // 
            // wetsiteDataGridViewTextBoxColumn
            // 
            this.wetsiteDataGridViewTextBoxColumn.DataPropertyName = "Wetsite";
            this.wetsiteDataGridViewTextBoxColumn.FillWeight = 73.34142F;
            this.wetsiteDataGridViewTextBoxColumn.HeaderText = "公司网址";
            this.wetsiteDataGridViewTextBoxColumn.Name = "wetsiteDataGridViewTextBoxColumn";
            this.wetsiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.wetsiteDataGridViewTextBoxColumn.Width = 80;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "联系人";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            this.Contact.Width = 68;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.FillWeight = 64.20696F;
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "联系电话";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telephoneDataGridViewTextBoxColumn.Width = 80;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 59.19745F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // faxNumberDataGridViewTextBoxColumn
            // 
            this.faxNumberDataGridViewTextBoxColumn.DataPropertyName = "FaxNumber";
            this.faxNumberDataGridViewTextBoxColumn.FillWeight = 56.56484F;
            this.faxNumberDataGridViewTextBoxColumn.HeaderText = "传真号码";
            this.faxNumberDataGridViewTextBoxColumn.Name = "faxNumberDataGridViewTextBoxColumn";
            this.faxNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.faxNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // cellPhoneDataGridViewTextBoxColumn
            // 
            this.cellPhoneDataGridViewTextBoxColumn.DataPropertyName = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.FillWeight = 53.15775F;
            this.cellPhoneDataGridViewTextBoxColumn.HeaderText = "手机号码";
            this.cellPhoneDataGridViewTextBoxColumn.Name = "cellPhoneDataGridViewTextBoxColumn";
            this.cellPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.cellPhoneDataGridViewTextBoxColumn.Width = 80;
            // 
            // clientLevelDataGridViewTextBoxColumn
            // 
            this.clientLevelDataGridViewTextBoxColumn.DataPropertyName = "ClientLevel";
            this.clientLevelDataGridViewTextBoxColumn.FillWeight = 40.11348F;
            this.clientLevelDataGridViewTextBoxColumn.HeaderText = "客户级别";
            this.clientLevelDataGridViewTextBoxColumn.Name = "clientLevelDataGridViewTextBoxColumn";
            this.clientLevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientLevelDataGridViewTextBoxColumn.Width = 80;
            // 
            // IsGroup
            // 
            this.IsGroup.DataPropertyName = "IsGroup";
            this.IsGroup.HeaderText = "是否集团客户";
            this.IsGroup.Name = "IsGroup";
            this.IsGroup.ReadOnly = true;
            this.IsGroup.Width = 104;
            // 
            // GroupNo
            // 
            this.GroupNo.DataPropertyName = "GroupNo";
            this.GroupNo.HeaderText = "所属集团客户号";
            this.GroupNo.Name = "GroupNo";
            this.GroupNo.ReadOnly = true;
            this.GroupNo.Width = 116;
            // 
            // RegistrationNumber
            // 
            this.RegistrationNumber.DataPropertyName = "RegistrationNumber";
            this.RegistrationNumber.HeaderText = "营业执照号码";
            this.RegistrationNumber.Name = "RegistrationNumber";
            this.RegistrationNumber.ReadOnly = true;
            this.RegistrationNumber.Width = 104;
            // 
            // companyCodeDataGridViewTextBoxColumn
            // 
            this.companyCodeDataGridViewTextBoxColumn.DataPropertyName = "CompanyCode";
            this.companyCodeDataGridViewTextBoxColumn.FillWeight = 41.97921F;
            this.companyCodeDataGridViewTextBoxColumn.HeaderText = "组织机构代码";
            this.companyCodeDataGridViewTextBoxColumn.Name = "companyCodeDataGridViewTextBoxColumn";
            this.companyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyCodeDataGridViewTextBoxColumn.Width = 104;
            // 
            // BranchCode
            // 
            this.BranchCode.DataPropertyName = "BranchCode";
            this.BranchCode.HeaderText = "所属机构";
            this.BranchCode.Name = "BranchCode";
            this.BranchCode.ReadOnly = true;
            this.BranchCode.Width = 80;
            // 
            // pMNameDataGridViewTextBoxColumn
            // 
            this.pMNameDataGridViewTextBoxColumn.DataPropertyName = "PMName";
            this.pMNameDataGridViewTextBoxColumn.FillWeight = 33.33396F;
            this.pMNameDataGridViewTextBoxColumn.HeaderText = "产品经理";
            this.pMNameDataGridViewTextBoxColumn.Name = "pMNameDataGridViewTextBoxColumn";
            this.pMNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pMNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // ColumnRMName
            // 
            this.ColumnRMName.DataPropertyName = "RMName";
            this.ColumnRMName.HeaderText = "客户经理";
            this.ColumnRMName.Name = "ColumnRMName";
            this.ColumnRMName.ReadOnly = true;
            this.ColumnRMName.Width = 80;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.FillWeight = 37.53305F;
            this.commentDataGridViewTextBoxColumn.HeaderText = "备注";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 56;
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
            this.contextMenuClientMgr.ResumeLayout(false);
            this.pnlQuery.ResumeLayout(false);
            this.pnlQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pnlQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRM;
        private DevComponents.DotNetBar.LabelX lblRM;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPM;
        private DevComponents.DotNetBar.LabelX lblPM;
        private DevComponents.DotNetBar.LabelX lblDepartment;
        private DevComponents.DotNetBar.LabelX lblClientType;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientEDICode;
        private DevComponents.DotNetBar.LabelX lblClientNo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClients;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbClientType;
        private DevComponents.DotNetBar.LabelX lblCount;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewClientCreditCover;
        private System.Windows.Forms.ToolStripMenuItem menuItemImportClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCoreNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientEDICodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameEN1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameEN_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Industry;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Representative;
        private System.Windows.Forms.DataGridViewTextBoxColumn wetsiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.ComboTree comboTreeDepartment;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem6;

    }
}

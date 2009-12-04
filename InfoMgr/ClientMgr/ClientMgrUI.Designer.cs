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
    partial class ClientMgrUI
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
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;

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
            this.contextMenuClientMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.clientMgrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlQuery = new DevComponents.DotNetBar.PanelEx();
            this.lblClientType = new DevComponents.DotNetBar.LabelX();
            this.tbClientNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientNo = new DevComponents.DotNetBar.LabelX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.tbRM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblRM = new DevComponents.DotNetBar.LabelX();
            this.tbPM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPM = new DevComponents.DotNetBar.LabelX();
            this.tbDepartment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDepartment = new DevComponents.DotNetBar.LabelX();
            this.dgvClient = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clientNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameEN1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameEN2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbClientType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbItemNORMAL = new DevComponents.Editors.ComboItem();
            this.cbItemVIP = new DevComponents.Editors.ComboItem();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.contextMenuClientMgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientMgrBindingSource)).BeginInit();
            this.pnlQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
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
            this.menuItemSelect.Click += new System.EventHandler(this.ItemSelect);
            // 
            // menuItemDetail
            // 
            this.menuItemDetail.Name = "menuItemDetail";
            this.menuItemDetail.Size = new System.Drawing.Size(98, 22);
            this.menuItemDetail.Text = "详细";
            this.menuItemDetail.Click += new System.EventHandler(this.ItemDetail);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(95, 6);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemUpdate,
            this.menuItemDelete});
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(98, 22);
            this.menuItemEdit.Text = "维护";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(98, 22);
            this.menuItemNew.Text = "新建";
            this.menuItemNew.Click += new System.EventHandler(this.ItemNew);
            // 
            // menuItemUpdate
            // 
            this.menuItemUpdate.Name = "menuItemUpdate";
            this.menuItemUpdate.Size = new System.Drawing.Size(98, 22);
            this.menuItemUpdate.Text = "更新";
            this.menuItemUpdate.Click += new System.EventHandler(this.ItemUpdate);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(98, 22);
            this.menuItemDelete.Text = "删除";
            this.menuItemDelete.Click += new System.EventHandler(this.ItemDelete);
            // 
            // clientMgrBindingSource
            // 
            this.clientMgrBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Client);
            // 
            // pnlQuery
            // 
            this.pnlQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pnlQuery.Controls.Add(this.lblCount);
            this.pnlQuery.Controls.Add(this.btnQuery);
            this.pnlQuery.Controls.Add(this.cbClientType);
            this.pnlQuery.Controls.Add(this.lblClientType);
            this.pnlQuery.Controls.Add(this.tbClientNo);
            this.pnlQuery.Controls.Add(this.lblClientNo);
            this.pnlQuery.Controls.Add(this.tbClientName);
            this.pnlQuery.Controls.Add(this.lblClientName);
            this.pnlQuery.Controls.Add(this.tbRM);
            this.pnlQuery.Controls.Add(this.lblRM);
            this.pnlQuery.Controls.Add(this.tbPM);
            this.pnlQuery.Controls.Add(this.lblPM);
            this.pnlQuery.Controls.Add(this.tbDepartment);
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
            // lblClientType
            // 
            // 
            // 
            // 
            this.lblClientType.BackgroundStyle.Class = "";
            this.lblClientType.Location = new System.Drawing.Point(333, 34);
            this.lblClientType.Name = "lblClientType";
            this.lblClientType.Size = new System.Drawing.Size(75, 23);
            this.lblClientType.TabIndex = 10;
            this.lblClientType.Text = "客户类型";
            // 
            // tbClientNo
            // 
            // 
            // 
            // 
            this.tbClientNo.Border.Class = "TextBoxBorder";
            this.tbClientNo.Location = new System.Drawing.Point(227, 34);
            this.tbClientNo.Name = "tbClientNo";
            this.tbClientNo.Size = new System.Drawing.Size(100, 20);
            this.tbClientNo.TabIndex = 3;
            // 
            // lblClientNo
            // 
            // 
            // 
            // 
            this.lblClientNo.BackgroundStyle.Class = "";
            this.lblClientNo.Location = new System.Drawing.Point(168, 37);
            this.lblClientNo.Name = "lblClientNo";
            this.lblClientNo.Size = new System.Drawing.Size(75, 23);
            this.lblClientNo.TabIndex = 8;
            this.lblClientNo.Text = "客户代码";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Location = new System.Drawing.Point(62, 34);
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
            this.lblClientName.Location = new System.Drawing.Point(3, 37);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(75, 23);
            this.lblClientName.TabIndex = 6;
            this.lblClientName.Text = "客户名称";
            // 
            // tbRM
            // 
            // 
            // 
            // 
            this.tbRM.Border.Class = "TextBoxBorder";
            this.tbRM.Location = new System.Drawing.Point(399, 8);
            this.tbRM.Name = "tbRM";
            this.tbRM.Size = new System.Drawing.Size(100, 20);
            this.tbRM.TabIndex = 4;
            // 
            // lblRM
            // 
            // 
            // 
            // 
            this.lblRM.BackgroundStyle.Class = "";
            this.lblRM.Location = new System.Drawing.Point(333, 8);
            this.lblRM.Name = "lblRM";
            this.lblRM.Size = new System.Drawing.Size(75, 23);
            this.lblRM.TabIndex = 4;
            this.lblRM.Text = "客户经理";
            // 
            // tbPM
            // 
            // 
            // 
            // 
            this.tbPM.Border.Class = "TextBoxBorder";
            this.tbPM.Location = new System.Drawing.Point(227, 7);
            this.tbPM.Name = "tbPM";
            this.tbPM.Size = new System.Drawing.Size(100, 20);
            this.tbPM.TabIndex = 2;
            // 
            // lblPM
            // 
            // 
            // 
            // 
            this.lblPM.BackgroundStyle.Class = "";
            this.lblPM.Location = new System.Drawing.Point(168, 8);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(75, 23);
            this.lblPM.TabIndex = 2;
            this.lblPM.Text = "产品经理";
            // 
            // tbDepartment
            // 
            // 
            // 
            // 
            this.tbDepartment.Border.Class = "TextBoxBorder";
            this.tbDepartment.Location = new System.Drawing.Point(62, 7);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(100, 20);
            this.tbDepartment.TabIndex = 0;
            // 
            // lblDepartment
            // 
            // 
            // 
            // 
            this.lblDepartment.BackgroundStyle.Class = "";
            this.lblDepartment.Location = new System.Drawing.Point(3, 8);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(75, 23);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "所属机构";
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.AllowUserToOrderColumns = true;
            this.dgvClient.AutoGenerateColumns = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientNoColumn,
            this.clientNameCNDataGridViewTextBoxColumn,
            this.clientNameEN1DataGridViewTextBoxColumn,
            this.clientNameEN2DataGridViewTextBoxColumn,
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
            this.clientTypeDataGridViewTextBoxColumn,
            this.productCNDataGridViewTextBoxColumn,
            this.productENDataGridViewTextBoxColumn,
            this.clientLevelDataGridViewTextBoxColumn,
            this.IsGroup,
            this.GroupNo,
            this.RegistrationNumber,
            this.companyCodeDataGridViewTextBoxColumn,
            this.BranchCode,
            this.pMNameDataGridViewTextBoxColumn,
            this.ColumnRMName,
            this.commentDataGridViewTextBoxColumn});
            this.dgvClient.ContextMenuStrip = this.contextMenuClientMgr;
            this.dgvClient.DataSource = this.clientMgrBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvClient.Location = new System.Drawing.Point(0, 61);
            this.dgvClient.MultiSelect = false;
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowTemplate.Height = 23;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(800, 539);
            this.dgvClient.TabIndex = 2;
            // 
            // clientNoColumn
            // 
            this.clientNoColumn.DataPropertyName = "ClientNo";
            this.clientNoColumn.FillWeight = 209.5112F;
            this.clientNoColumn.HeaderText = "客户代码";
            this.clientNoColumn.Name = "clientNoColumn";
            this.clientNoColumn.ReadOnly = true;
            // 
            // clientNameCNDataGridViewTextBoxColumn
            // 
            this.clientNameCNDataGridViewTextBoxColumn.DataPropertyName = "ClientNameCN";
            this.clientNameCNDataGridViewTextBoxColumn.FillWeight = 247.7837F;
            this.clientNameCNDataGridViewTextBoxColumn.HeaderText = "客户名称";
            this.clientNameCNDataGridViewTextBoxColumn.Name = "clientNameCNDataGridViewTextBoxColumn";
            this.clientNameCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameEN1DataGridViewTextBoxColumn
            // 
            this.clientNameEN1DataGridViewTextBoxColumn.DataPropertyName = "ClientNameEN_1";
            this.clientNameEN1DataGridViewTextBoxColumn.FillWeight = 223.7242F;
            this.clientNameEN1DataGridViewTextBoxColumn.HeaderText = "ClientName_1";
            this.clientNameEN1DataGridViewTextBoxColumn.Name = "clientNameEN1DataGridViewTextBoxColumn";
            this.clientNameEN1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameEN2DataGridViewTextBoxColumn
            // 
            this.clientNameEN2DataGridViewTextBoxColumn.DataPropertyName = "ClientNameEN_2";
            this.clientNameEN2DataGridViewTextBoxColumn.FillWeight = 202.1438F;
            this.clientNameEN2DataGridViewTextBoxColumn.HeaderText = "ClientName_2";
            this.clientNameEN2DataGridViewTextBoxColumn.Name = "clientNameEN2DataGridViewTextBoxColumn";
            this.clientNameEN2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressCNDataGridViewTextBoxColumn
            // 
            this.addressCNDataGridViewTextBoxColumn.DataPropertyName = "AddressCN";
            this.addressCNDataGridViewTextBoxColumn.FillWeight = 157.0093F;
            this.addressCNDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressCNDataGridViewTextBoxColumn.Name = "addressCNDataGridViewTextBoxColumn";
            this.addressCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressENDataGridViewTextBoxColumn
            // 
            this.addressENDataGridViewTextBoxColumn.DataPropertyName = "AddressEN";
            this.addressENDataGridViewTextBoxColumn.FillWeight = 144.377F;
            this.addressENDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressENDataGridViewTextBoxColumn.Name = "addressENDataGridViewTextBoxColumn";
            this.addressENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityCNDataGridViewTextBoxColumn
            // 
            this.cityCNDataGridViewTextBoxColumn.DataPropertyName = "CityCN";
            this.cityCNDataGridViewTextBoxColumn.FillWeight = 132.8628F;
            this.cityCNDataGridViewTextBoxColumn.HeaderText = "城市";
            this.cityCNDataGridViewTextBoxColumn.Name = "cityCNDataGridViewTextBoxColumn";
            this.cityCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityENDataGridViewTextBoxColumn
            // 
            this.cityENDataGridViewTextBoxColumn.DataPropertyName = "CityEN";
            this.cityENDataGridViewTextBoxColumn.FillWeight = 122.3677F;
            this.cityENDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityENDataGridViewTextBoxColumn.Name = "cityENDataGridViewTextBoxColumn";
            this.cityENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinceCNDataGridViewTextBoxColumn
            // 
            this.provinceCNDataGridViewTextBoxColumn.DataPropertyName = "ProvinceCN";
            this.provinceCNDataGridViewTextBoxColumn.FillWeight = 121.2194F;
            this.provinceCNDataGridViewTextBoxColumn.HeaderText = "省/州";
            this.provinceCNDataGridViewTextBoxColumn.Name = "provinceCNDataGridViewTextBoxColumn";
            this.provinceCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinceENDataGridViewTextBoxColumn
            // 
            this.provinceENDataGridViewTextBoxColumn.DataPropertyName = "ProvinceEN";
            this.provinceENDataGridViewTextBoxColumn.FillWeight = 111.0485F;
            this.provinceENDataGridViewTextBoxColumn.HeaderText = "Province/State";
            this.provinceENDataGridViewTextBoxColumn.Name = "provinceENDataGridViewTextBoxColumn";
            this.provinceENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.FillWeight = 86.2853F;
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "邮编";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            this.postCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CountryCode
            // 
            this.CountryCode.DataPropertyName = "CountryCode";
            this.CountryCode.HeaderText = "国家";
            this.CountryCode.Name = "CountryCode";
            this.CountryCode.ReadOnly = true;
            // 
            // Representative
            // 
            this.Representative.DataPropertyName = "Representative";
            this.Representative.HeaderText = "公司法人/负责人";
            this.Representative.Name = "Representative";
            this.Representative.ReadOnly = true;
            // 
            // wetsiteDataGridViewTextBoxColumn
            // 
            this.wetsiteDataGridViewTextBoxColumn.DataPropertyName = "Wetsite";
            this.wetsiteDataGridViewTextBoxColumn.FillWeight = 73.34142F;
            this.wetsiteDataGridViewTextBoxColumn.HeaderText = "公司网址";
            this.wetsiteDataGridViewTextBoxColumn.Name = "wetsiteDataGridViewTextBoxColumn";
            this.wetsiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.DataPropertyName = "Contact";
            this.Contact.HeaderText = "联系人";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.FillWeight = 64.20696F;
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "联系电话";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 59.19745F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxNumberDataGridViewTextBoxColumn
            // 
            this.faxNumberDataGridViewTextBoxColumn.DataPropertyName = "FaxNumber";
            this.faxNumberDataGridViewTextBoxColumn.FillWeight = 56.56484F;
            this.faxNumberDataGridViewTextBoxColumn.HeaderText = "传真号码";
            this.faxNumberDataGridViewTextBoxColumn.Name = "faxNumberDataGridViewTextBoxColumn";
            this.faxNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellPhoneDataGridViewTextBoxColumn
            // 
            this.cellPhoneDataGridViewTextBoxColumn.DataPropertyName = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.FillWeight = 53.15775F;
            this.cellPhoneDataGridViewTextBoxColumn.HeaderText = "手机号码";
            this.cellPhoneDataGridViewTextBoxColumn.Name = "cellPhoneDataGridViewTextBoxColumn";
            this.cellPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientTypeDataGridViewTextBoxColumn
            // 
            this.clientTypeDataGridViewTextBoxColumn.DataPropertyName = "ClientType";
            this.clientTypeDataGridViewTextBoxColumn.FillWeight = 50.02522F;
            this.clientTypeDataGridViewTextBoxColumn.HeaderText = "客户类型";
            this.clientTypeDataGridViewTextBoxColumn.Name = "clientTypeDataGridViewTextBoxColumn";
            this.clientTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productCNDataGridViewTextBoxColumn
            // 
            this.productCNDataGridViewTextBoxColumn.DataPropertyName = "ProductCN";
            this.productCNDataGridViewTextBoxColumn.FillWeight = 60.28388F;
            this.productCNDataGridViewTextBoxColumn.HeaderText = "经营范围";
            this.productCNDataGridViewTextBoxColumn.Name = "productCNDataGridViewTextBoxColumn";
            this.productCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productENDataGridViewTextBoxColumn
            // 
            this.productENDataGridViewTextBoxColumn.DataPropertyName = "ProductEN";
            this.productENDataGridViewTextBoxColumn.FillWeight = 55.54407F;
            this.productENDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productENDataGridViewTextBoxColumn.Name = "productENDataGridViewTextBoxColumn";
            this.productENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientLevelDataGridViewTextBoxColumn
            // 
            this.clientLevelDataGridViewTextBoxColumn.DataPropertyName = "ClientLevel";
            this.clientLevelDataGridViewTextBoxColumn.FillWeight = 40.11348F;
            this.clientLevelDataGridViewTextBoxColumn.HeaderText = "客户级别";
            this.clientLevelDataGridViewTextBoxColumn.Name = "clientLevelDataGridViewTextBoxColumn";
            this.clientLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IsGroup
            // 
            this.IsGroup.DataPropertyName = "IsGroup";
            this.IsGroup.HeaderText = "是否集团客户";
            this.IsGroup.Name = "IsGroup";
            this.IsGroup.ReadOnly = true;
            // 
            // GroupNo
            // 
            this.GroupNo.DataPropertyName = "GroupNo";
            this.GroupNo.HeaderText = "所属集团客户号";
            this.GroupNo.Name = "GroupNo";
            this.GroupNo.ReadOnly = true;
            // 
            // RegistrationNumber
            // 
            this.RegistrationNumber.DataPropertyName = "RegistrationNumber";
            this.RegistrationNumber.HeaderText = "营业执照号码";
            this.RegistrationNumber.Name = "RegistrationNumber";
            this.RegistrationNumber.ReadOnly = true;
            // 
            // companyCodeDataGridViewTextBoxColumn
            // 
            this.companyCodeDataGridViewTextBoxColumn.DataPropertyName = "CompanyCode";
            this.companyCodeDataGridViewTextBoxColumn.FillWeight = 41.97921F;
            this.companyCodeDataGridViewTextBoxColumn.HeaderText = "组织机构代码";
            this.companyCodeDataGridViewTextBoxColumn.Name = "companyCodeDataGridViewTextBoxColumn";
            this.companyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BranchCode
            // 
            this.BranchCode.DataPropertyName = "BranchCode";
            this.BranchCode.HeaderText = "所属机构";
            this.BranchCode.Name = "BranchCode";
            this.BranchCode.ReadOnly = true;
            // 
            // pMNameDataGridViewTextBoxColumn
            // 
            this.pMNameDataGridViewTextBoxColumn.DataPropertyName = "PMName";
            this.pMNameDataGridViewTextBoxColumn.FillWeight = 33.33396F;
            this.pMNameDataGridViewTextBoxColumn.HeaderText = "产品经理";
            this.pMNameDataGridViewTextBoxColumn.Name = "pMNameDataGridViewTextBoxColumn";
            this.pMNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ColumnRMName
            // 
            this.ColumnRMName.DataPropertyName = "RMName";
            this.ColumnRMName.HeaderText = "客户经理";
            this.ColumnRMName.Name = "ColumnRMName";
            this.ColumnRMName.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.FillWeight = 37.53305F;
            this.commentDataGridViewTextBoxColumn.HeaderText = "备注";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cbClientType
            // 
            this.cbClientType.DisplayMember = "Text";
            this.cbClientType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClientType.FormattingEnabled = true;
            this.cbClientType.ItemHeight = 14;
            this.cbClientType.Items.AddRange(new object[] {
            this.cbItemNORMAL,
            this.cbItemVIP});
            this.cbClientType.Location = new System.Drawing.Point(399, 34);
            this.cbClientType.Name = "cbClientType";
            this.cbClientType.Size = new System.Drawing.Size(100, 20);
            this.cbClientType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbClientType.TabIndex = 5;
            // 
            // cbItemNORMAL
            // 
            this.cbItemNORMAL.Text = "NORMAL";
            // 
            // cbItemVIP
            // 
            this.cbItemVIP.Text = "VIP";
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(516, 6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 49);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.Query);
            // 
            // lblCount
            // 
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(598, 30);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(75, 23);
            this.lblCount.TabIndex = 11;
            // 
            // ClientMgrUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.pnlQuery);
            this.Name = "ClientMgrUI";
            this.Size = new System.Drawing.Size(800, 600);
            this.contextMenuClientMgr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientMgrBindingSource)).EndInit();
            this.pnlQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource clientMgrBindingSource;
        private DevComponents.DotNetBar.PanelEx pnlQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRM;
        private DevComponents.DotNetBar.LabelX lblRM;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPM;
        private DevComponents.DotNetBar.LabelX lblPM;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDepartment;
        private DevComponents.DotNetBar.LabelX lblDepartment;
        private DevComponents.DotNetBar.LabelX lblClientType;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientNo;
        private DevComponents.DotNetBar.LabelX lblClientNo;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameEN1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameEN2DataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BranchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbClientType;
        private DevComponents.Editors.ComboItem cbItemNORMAL;
        private DevComponents.Editors.ComboItem cbItemVIP;
        private DevComponents.DotNetBar.LabelX lblCount;

    }
}

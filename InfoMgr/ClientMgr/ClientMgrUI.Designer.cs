//-----------------------------------------------------------------------
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
        private System.Windows.Forms.ToolStrip tsClientMgr;
        private System.Windows.Forms.ToolStripLabel labelCompany;
        private System.Windows.Forms.ToolStripTextBox tbCompany;
        private System.Windows.Forms.ToolStripLabel labelClientName;
        private System.Windows.Forms.ToolStripTextBox tbClientName;
        private System.Windows.Forms.ToolStripLabel lblFactorCode;
        private System.Windows.Forms.ToolStripTextBox tbFactorCode;
        private System.Windows.Forms.ToolStripButton btnQuery;
        private System.Windows.Forms.ToolStripLabel lblCount;

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
            this.tsClientMgr = new System.Windows.Forms.ToolStrip();
            this.labelCompany = new System.Windows.Forms.ToolStripLabel();
            this.tbCompany = new System.Windows.Forms.ToolStripTextBox();
            this.labelClientName = new System.Windows.Forms.ToolStripLabel();
            this.tbClientName = new System.Windows.Forms.ToolStripTextBox();
            this.lblFactorCode = new System.Windows.Forms.ToolStripLabel();
            this.tbFactorCode = new System.Windows.Forms.ToolStripTextBox();
            this.btnQuery = new System.Windows.Forms.ToolStripButton();
            this.lblCount = new System.Windows.Forms.ToolStripLabel();
            this.dgvClient = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clientMgrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ediNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.responsibleAgencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wetsiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyRegistrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuClientMgr.SuspendLayout();
            this.tsClientMgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientMgrBindingSource)).BeginInit();
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
            this.contextMenuClientMgr.Size = new System.Drawing.Size(101, 76);
            // 
            // menuItemSelect
            // 
            this.menuItemSelect.Name = "menuItemSelect";
            this.menuItemSelect.Size = new System.Drawing.Size(100, 22);
            this.menuItemSelect.Text = "选定";
            this.menuItemSelect.Click += new System.EventHandler(this.ItemSelect);
            // 
            // menuItemDetail
            // 
            this.menuItemDetail.Name = "menuItemDetail";
            this.menuItemDetail.Size = new System.Drawing.Size(100, 22);
            this.menuItemDetail.Text = "详细";
            this.menuItemDetail.Click += new System.EventHandler(this.ItemDetail);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(97, 6);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemUpdate,
            this.menuItemDelete});
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(100, 22);
            this.menuItemEdit.Text = "维护";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.Size = new System.Drawing.Size(100, 22);
            this.menuItemNew.Text = "新建";
            this.menuItemNew.Click += new System.EventHandler(this.ItemNew);
            // 
            // menuItemUpdate
            // 
            this.menuItemUpdate.Name = "menuItemUpdate";
            this.menuItemUpdate.Size = new System.Drawing.Size(100, 22);
            this.menuItemUpdate.Text = "更新";
            this.menuItemUpdate.Click += new System.EventHandler(this.ItemUpdate);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.Size = new System.Drawing.Size(100, 22);
            this.menuItemDelete.Text = "删除";
            this.menuItemDelete.Click += new System.EventHandler(this.ItemDelete);
            // 
            // tsClientMgr
            // 
            this.tsClientMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelCompany,
            this.tbCompany,
            this.labelClientName,
            this.tbClientName,
            this.lblFactorCode,
            this.tbFactorCode,
            this.btnQuery,
            this.lblCount});
            this.tsClientMgr.Location = new System.Drawing.Point(0, 0);
            this.tsClientMgr.Name = "tsClientMgr";
            this.tsClientMgr.Size = new System.Drawing.Size(800, 25);
            this.tsClientMgr.TabIndex = 2;
            this.tsClientMgr.Text = "toolStrip1";
            // 
            // labelCompany
            // 
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(56, 22);
            this.labelCompany.Text = "所属机构";
            // 
            // tbCompany
            // 
            this.tbCompany.Name = "tbCompany";
            this.tbCompany.Size = new System.Drawing.Size(100, 25);
            // 
            // labelClientName
            // 
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(56, 22);
            this.labelClientName.Text = "客户名称";
            // 
            // tbClientName
            // 
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 25);
            // 
            // lblFactorCode
            // 
            this.lblFactorCode.Name = "lblFactorCode";
            this.lblFactorCode.Size = new System.Drawing.Size(56, 22);
            this.lblFactorCode.Text = "保理代码";
            // 
            // tbFactorCode
            // 
            this.tbFactorCode.Name = "tbFactorCode";
            this.tbFactorCode.Size = new System.Drawing.Size(100, 25);
            // 
            // btnQuery
            // 
            this.btnQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(36, 22);
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.Query);
            // 
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 22);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.AllowUserToOrderColumns = true;
            this.dgvClient.AutoGenerateColumns = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ediNoColumn,
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
            this.responsibleAgencyDataGridViewTextBoxColumn,
            this.wetsiteDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.faxNumberDataGridViewTextBoxColumn,
            this.cellPhoneDataGridViewTextBoxColumn,
            this.clientTypeDataGridViewTextBoxColumn,
            this.productCNDataGridViewTextBoxColumn,
            this.productENDataGridViewTextBoxColumn,
            this.clientLevelDataGridViewTextBoxColumn,
            this.companyRegistrationNumberDataGridViewTextBoxColumn,
            this.companyCodeDataGridViewTextBoxColumn,
            this.pMNameDataGridViewTextBoxColumn,
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
            this.dgvClient.Location = new System.Drawing.Point(0, 25);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowTemplate.Height = 23;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(800, 529);
            this.dgvClient.TabIndex = 3;
            this.dgvClient.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellDoubleClick);
            // 
            // clientMgrBindingSource
            // 
            this.clientMgrBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Client);
            // 
            // ediNoColumn
            // 
            this.ediNoColumn.DataPropertyName = "EDINo";
            this.ediNoColumn.FillWeight = 209.5112F;
            this.ediNoColumn.HeaderText = "保理代码";
            this.ediNoColumn.Name = "ediNoColumn";
            this.ediNoColumn.ReadOnly = true;
            // 
            // clientNameCNDataGridViewTextBoxColumn
            // 
            this.clientNameCNDataGridViewTextBoxColumn.DataPropertyName = "ClientNameCN";
            this.clientNameCNDataGridViewTextBoxColumn.FillWeight = 247.7837F;
            this.clientNameCNDataGridViewTextBoxColumn.HeaderText = "客户名称(中文)";
            this.clientNameCNDataGridViewTextBoxColumn.Name = "clientNameCNDataGridViewTextBoxColumn";
            this.clientNameCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameEN1DataGridViewTextBoxColumn
            // 
            this.clientNameEN1DataGridViewTextBoxColumn.DataPropertyName = "ClientNameEN_1";
            this.clientNameEN1DataGridViewTextBoxColumn.FillWeight = 223.7242F;
            this.clientNameEN1DataGridViewTextBoxColumn.HeaderText = "客户名称(英文)1";
            this.clientNameEN1DataGridViewTextBoxColumn.Name = "clientNameEN1DataGridViewTextBoxColumn";
            this.clientNameEN1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameEN2DataGridViewTextBoxColumn
            // 
            this.clientNameEN2DataGridViewTextBoxColumn.DataPropertyName = "ClientNameEN_2";
            this.clientNameEN2DataGridViewTextBoxColumn.FillWeight = 202.1438F;
            this.clientNameEN2DataGridViewTextBoxColumn.HeaderText = "客户名称(英文)2";
            this.clientNameEN2DataGridViewTextBoxColumn.Name = "clientNameEN2DataGridViewTextBoxColumn";
            this.clientNameEN2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressCNDataGridViewTextBoxColumn
            // 
            this.addressCNDataGridViewTextBoxColumn.DataPropertyName = "AddressCN";
            this.addressCNDataGridViewTextBoxColumn.FillWeight = 157.0093F;
            this.addressCNDataGridViewTextBoxColumn.HeaderText = "地址(中文)";
            this.addressCNDataGridViewTextBoxColumn.Name = "addressCNDataGridViewTextBoxColumn";
            this.addressCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressENDataGridViewTextBoxColumn
            // 
            this.addressENDataGridViewTextBoxColumn.DataPropertyName = "AddressEN";
            this.addressENDataGridViewTextBoxColumn.FillWeight = 144.377F;
            this.addressENDataGridViewTextBoxColumn.HeaderText = "地址(英文)";
            this.addressENDataGridViewTextBoxColumn.Name = "addressENDataGridViewTextBoxColumn";
            this.addressENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityCNDataGridViewTextBoxColumn
            // 
            this.cityCNDataGridViewTextBoxColumn.DataPropertyName = "CityCN";
            this.cityCNDataGridViewTextBoxColumn.FillWeight = 132.8628F;
            this.cityCNDataGridViewTextBoxColumn.HeaderText = "城市(中文)";
            this.cityCNDataGridViewTextBoxColumn.Name = "cityCNDataGridViewTextBoxColumn";
            this.cityCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityENDataGridViewTextBoxColumn
            // 
            this.cityENDataGridViewTextBoxColumn.DataPropertyName = "CityEN";
            this.cityENDataGridViewTextBoxColumn.FillWeight = 122.3677F;
            this.cityENDataGridViewTextBoxColumn.HeaderText = "城市(英文)";
            this.cityENDataGridViewTextBoxColumn.Name = "cityENDataGridViewTextBoxColumn";
            this.cityENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinceCNDataGridViewTextBoxColumn
            // 
            this.provinceCNDataGridViewTextBoxColumn.DataPropertyName = "ProvinceCN";
            this.provinceCNDataGridViewTextBoxColumn.FillWeight = 121.2194F;
            this.provinceCNDataGridViewTextBoxColumn.HeaderText = "省/州(中文)";
            this.provinceCNDataGridViewTextBoxColumn.Name = "provinceCNDataGridViewTextBoxColumn";
            this.provinceCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provinceENDataGridViewTextBoxColumn
            // 
            this.provinceENDataGridViewTextBoxColumn.DataPropertyName = "ProvinceEN";
            this.provinceENDataGridViewTextBoxColumn.FillWeight = 111.0485F;
            this.provinceENDataGridViewTextBoxColumn.HeaderText = "省/州(英文)";
            this.provinceENDataGridViewTextBoxColumn.Name = "provinceENDataGridViewTextBoxColumn";
            this.provinceENDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postCodeDataGridViewTextBoxColumn
            // 
            this.postCodeDataGridViewTextBoxColumn.DataPropertyName = "PostCode";
            this.postCodeDataGridViewTextBoxColumn.FillWeight = 86.2853F;
            this.postCodeDataGridViewTextBoxColumn.HeaderText = "邮政编码";
            this.postCodeDataGridViewTextBoxColumn.Name = "postCodeDataGridViewTextBoxColumn";
            this.postCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responsibleAgencyDataGridViewTextBoxColumn
            // 
            this.responsibleAgencyDataGridViewTextBoxColumn.DataPropertyName = "ResponsibleAgency";
            this.responsibleAgencyDataGridViewTextBoxColumn.FillWeight = 102.9131F;
            this.responsibleAgencyDataGridViewTextBoxColumn.HeaderText = "公司法人/负责人";
            this.responsibleAgencyDataGridViewTextBoxColumn.Name = "responsibleAgencyDataGridViewTextBoxColumn";
            this.responsibleAgencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wetsiteDataGridViewTextBoxColumn
            // 
            this.wetsiteDataGridViewTextBoxColumn.DataPropertyName = "Wetsite";
            this.wetsiteDataGridViewTextBoxColumn.FillWeight = 73.34142F;
            this.wetsiteDataGridViewTextBoxColumn.HeaderText = "公司网址";
            this.wetsiteDataGridViewTextBoxColumn.Name = "wetsiteDataGridViewTextBoxColumn";
            this.wetsiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.FillWeight = 68.58244F;
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "联系人";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.productCNDataGridViewTextBoxColumn.HeaderText = "经营范围(中文)";
            this.productCNDataGridViewTextBoxColumn.Name = "productCNDataGridViewTextBoxColumn";
            this.productCNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productENDataGridViewTextBoxColumn
            // 
            this.productENDataGridViewTextBoxColumn.DataPropertyName = "ProductEN";
            this.productENDataGridViewTextBoxColumn.FillWeight = 55.54407F;
            this.productENDataGridViewTextBoxColumn.HeaderText = "经营范围(英文)";
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
            // companyRegistrationNumberDataGridViewTextBoxColumn
            // 
            this.companyRegistrationNumberDataGridViewTextBoxColumn.DataPropertyName = "CompanyRegistrationNumber";
            this.companyRegistrationNumberDataGridViewTextBoxColumn.FillWeight = 44.8903F;
            this.companyRegistrationNumberDataGridViewTextBoxColumn.HeaderText = "营业执照号码";
            this.companyRegistrationNumberDataGridViewTextBoxColumn.Name = "companyRegistrationNumberDataGridViewTextBoxColumn";
            this.companyRegistrationNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyCodeDataGridViewTextBoxColumn
            // 
            this.companyCodeDataGridViewTextBoxColumn.DataPropertyName = "CompanyCode";
            this.companyCodeDataGridViewTextBoxColumn.FillWeight = 41.97921F;
            this.companyCodeDataGridViewTextBoxColumn.HeaderText = "组织机构代码";
            this.companyCodeDataGridViewTextBoxColumn.Name = "companyCodeDataGridViewTextBoxColumn";
            this.companyCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pMNameDataGridViewTextBoxColumn
            // 
            this.pMNameDataGridViewTextBoxColumn.DataPropertyName = "PMName";
            this.pMNameDataGridViewTextBoxColumn.FillWeight = 33.33396F;
            this.pMNameDataGridViewTextBoxColumn.HeaderText = "客户经理";
            this.pMNameDataGridViewTextBoxColumn.Name = "pMNameDataGridViewTextBoxColumn";
            this.pMNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.FillWeight = 37.53305F;
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ClientMgrUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.tsClientMgr);
            this.Name = "ClientMgrUI";
            this.Size = new System.Drawing.Size(800, 554);
            this.contextMenuClientMgr.ResumeLayout(false);
            this.tsClientMgr.ResumeLayout(false);
            this.tsClientMgr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientMgrBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClient;
        private System.Windows.Forms.BindingSource clientMgrBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ediNoColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn responsibleAgencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wetsiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyRegistrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;

    }
}

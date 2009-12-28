//-----------------------------------------------------------------------
// <copyright file="FactorDetailUI.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    /// <summary>
    /// Factor Managerment User Interface Designer
    /// </summary>
    public partial class FactorMgr
    {
		#region Fields (65) 

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCountry;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFactorType;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ContextMenuStrip contextMenuFactorMgr;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFactors;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblCountry;
        private DevComponents.DotNetBar.LabelX lblFactorCode;
        private DevComponents.DotNetBar.LabelX lblFactorName;
        private DevComponents.DotNetBar.LabelX lblFactorType;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorCreditLineNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorImport;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorUpdate;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;

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



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuFactorMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemFactorSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFactorDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFactorNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFactorCreditLineNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFactorUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFactorDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFactorImport = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.cbCountry = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCountry = new DevComponents.DotNetBar.LabelX();
            this.cbFactorType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbFactorName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactorName = new DevComponents.DotNetBar.LabelX();
            this.tbFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactorCode = new DevComponents.DotNetBar.LabelX();
            this.lblFactorType = new DevComponents.DotNetBar.LabelX();
            this.dgvFactors = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.factorCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameENColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalAddress_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalAddress_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCodePostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityPostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitingAddress_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitingAddress_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCodeVisitingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityVisitingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebsiteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefax_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefax_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingHoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneralCorrespondence_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneralCorrespondence_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacts_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacts_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacts_3Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacts_4Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Management_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Management_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShareHoldersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IFISColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfLatestRevisionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsGroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNameCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupNameENColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCorrespondentBankColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAgreementSignColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuFactorMgr.SuspendLayout();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuFactorMgr
            // 
            this.contextMenuFactorMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFactorSelect,
            this.menuItemFactorDetail,
            this.toolStripSeparator,
            this.menuItemFactorNew,
            this.menuItemFactorCreditLineNew,
            this.menuItemFactorUpdate,
            this.menuItemFactorDelete,
            this.menuItemFactorImport});
            this.contextMenuFactorMgr.Name = "contextMenuFactorMgr";
            this.contextMenuFactorMgr.Size = new System.Drawing.Size(147, 164);
            // 
            // menuItemFactorSelect
            // 
            this.menuItemFactorSelect.Name = "menuItemFactorSelect";
            this.menuItemFactorSelect.Size = new System.Drawing.Size(146, 22);
            this.menuItemFactorSelect.Text = "选定机构";
            this.menuItemFactorSelect.Click += new System.EventHandler(this.SelectFactor);
            // 
            // menuItemFactorDetail
            // 
            this.menuItemFactorDetail.Name = "menuItemFactorDetail";
            this.menuItemFactorDetail.Size = new System.Drawing.Size(146, 22);
            this.menuItemFactorDetail.Text = "详细信息";
            this.menuItemFactorDetail.Click += new System.EventHandler(this.DetailFactor);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItemFactorNew
            // 
            this.menuItemFactorNew.Name = "menuItemFactorNew";
            this.menuItemFactorNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemFactorNew.Text = "新建机构";
            this.menuItemFactorNew.Click += new System.EventHandler(this.NewFactor);
            // 
            // menuItemFactorCreditLineNew
            // 
            this.menuItemFactorCreditLineNew.Name = "menuItemFactorCreditLineNew";
            this.menuItemFactorCreditLineNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemFactorCreditLineNew.Text = "新建额度信息";
            this.menuItemFactorCreditLineNew.Click += new System.EventHandler(this.NewFactorCreditLine);
            // 
            // menuItemFactorUpdate
            // 
            this.menuItemFactorUpdate.Name = "menuItemFactorUpdate";
            this.menuItemFactorUpdate.Size = new System.Drawing.Size(146, 22);
            this.menuItemFactorUpdate.Text = "更新机构";
            this.menuItemFactorUpdate.Click += new System.EventHandler(this.UpdateFactor);
            // 
            // menuItemFactorDelete
            // 
            this.menuItemFactorDelete.Name = "menuItemFactorDelete";
            this.menuItemFactorDelete.Size = new System.Drawing.Size(146, 22);
            this.menuItemFactorDelete.Text = "删除机构";
            this.menuItemFactorDelete.Click += new System.EventHandler(this.DeleteFactor);
            // 
            // menuItemFactorImport
            // 
            this.menuItemFactorImport.Name = "menuItemFactorImport";
            this.menuItemFactorImport.Size = new System.Drawing.Size(146, 22);
            this.menuItemFactorImport.Text = "导入机构";
            this.menuItemFactorImport.Click += new System.EventHandler(this.ImportFactos);
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.btnReset);
            this.panelQuery.Controls.Add(this.cbCountry);
            this.panelQuery.Controls.Add(this.lblCountry);
            this.panelQuery.Controls.Add(this.cbFactorType);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbFactorName);
            this.panelQuery.Controls.Add(this.lblFactorName);
            this.panelQuery.Controls.Add(this.tbFactorCode);
            this.panelQuery.Controls.Add(this.lblFactorCode);
            this.panelQuery.Controls.Add(this.lblFactorType);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(911, 30);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Location = new System.Drawing.Point(693, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(41, 23);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "重置";
            this.btnReset.Click += new System.EventHandler(this.Reset);
            // 
            // cbCountry
            // 
            this.cbCountry.DisplayMember = "Text";
            this.cbCountry.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(216, 5);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(99, 21);
            this.cbCountry.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCountry.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            // 
            // 
            // 
            this.lblCountry.BackgroundStyle.Class = "";
            this.lblCountry.Location = new System.Drawing.Point(175, 5);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(44, 16);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "所在国";
            // 
            // cbFactorType
            // 
            this.cbFactorType.DisplayMember = "Text";
            this.cbFactorType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFactorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFactorType.FormattingEnabled = true;
            this.cbFactorType.Items.AddRange(new object[] {
            "全部",
            "保理商",
            "保险公司",
            "监管机构",
            "代付行"});
            this.cbFactorType.Location = new System.Drawing.Point(70, 5);
            this.cbFactorType.Name = "cbFactorType";
            this.cbFactorType.Size = new System.Drawing.Size(99, 21);
            this.cbFactorType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFactorType.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(740, 8);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 7;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(646, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(41, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryFactors);
            // 
            // tbFactorName
            // 
            // 
            // 
            // 
            this.tbFactorName.Border.Class = "TextBoxBorder";
            this.tbFactorName.Location = new System.Drawing.Point(540, 5);
            this.tbFactorName.Name = "tbFactorName";
            this.tbFactorName.Size = new System.Drawing.Size(100, 20);
            this.tbFactorName.TabIndex = 5;
            // 
            // lblFactorName
            // 
            this.lblFactorName.AutoSize = true;
            // 
            // 
            // 
            this.lblFactorName.BackgroundStyle.Class = "";
            this.lblFactorName.Location = new System.Drawing.Point(485, 5);
            this.lblFactorName.Name = "lblFactorName";
            this.lblFactorName.Size = new System.Drawing.Size(56, 16);
            this.lblFactorName.TabIndex = 4;
            this.lblFactorName.Text = "机构名称";
            // 
            // tbFactorCode
            // 
            // 
            // 
            // 
            this.tbFactorCode.Border.Class = "TextBoxBorder";
            this.tbFactorCode.Location = new System.Drawing.Point(379, 5);
            this.tbFactorCode.Name = "tbFactorCode";
            this.tbFactorCode.Size = new System.Drawing.Size(100, 20);
            this.tbFactorCode.TabIndex = 3;
            // 
            // lblFactorCode
            // 
            this.lblFactorCode.AutoSize = true;
            // 
            // 
            // 
            this.lblFactorCode.BackgroundStyle.Class = "";
            this.lblFactorCode.Location = new System.Drawing.Point(321, 5);
            this.lblFactorCode.Name = "lblFactorCode";
            this.lblFactorCode.Size = new System.Drawing.Size(56, 16);
            this.lblFactorCode.TabIndex = 2;
            this.lblFactorCode.Text = "机构编号";
            // 
            // lblFactorType
            // 
            this.lblFactorType.AutoSize = true;
            // 
            // 
            // 
            this.lblFactorType.BackgroundStyle.Class = "";
            this.lblFactorType.Location = new System.Drawing.Point(5, 5);
            this.lblFactorType.Name = "lblFactorType";
            this.lblFactorType.Size = new System.Drawing.Size(56, 16);
            this.lblFactorType.TabIndex = 0;
            this.lblFactorType.Text = "机构类型";
            // 
            // dgvFactors
            // 
            this.dgvFactors.AllowUserToAddRows = false;
            this.dgvFactors.AllowUserToDeleteRows = false;
            this.dgvFactors.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factorCodeColumn,
            this.FactorTypeColumn,
            this.CompanyNameCNColumn,
            this.CompanyNameENColumn,
            this.ShortNameColumn,
            this.CountryNameColumn,
            this.DepartmentColumn,
            this.PostalAddress_1Column,
            this.PostalAddress_2Column,
            this.PostalCodePostColumn,
            this.CityPostColumn,
            this.VisitingAddress_1Column,
            this.VisitingAddress_2Column,
            this.PostalCodeVisitingColumn,
            this.CityVisitingColumn,
            this.EmailColumn,
            this.WebsiteColumn,
            this.Telephone_1Column,
            this.Telephone_2Column,
            this.Telefax_1Column,
            this.Telefax_2Column,
            this.WorkingHoursColumn,
            this.GeneralCorrespondence_1Column,
            this.GeneralCorrespondence_2Column,
            this.Contacts_1Column,
            this.Contacts_2Column,
            this.Contacts_3Column,
            this.Contacts_4Column,
            this.Management_1Column,
            this.Management_2Column,
            this.ShareHoldersColumn,
            this.IFISColumn,
            this.MembershipStatusColumn,
            this.MembershipDateColumn,
            this.DateOfLatestRevisionColumn,
            this.IsGroupColumn,
            this.GroupNoColumn,
            this.GroupNameCNColumn,
            this.GroupNameENColumn,
            this.IsCorrespondentBankColumn,
            this.IsAgreementSignColumn,
            this.CommentColumn});
            this.dgvFactors.ContextMenuStrip = this.contextMenuFactorMgr;
            this.dgvFactors.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFactors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFactors.Location = new System.Drawing.Point(0, 30);
            this.dgvFactors.MultiSelect = false;
            this.dgvFactors.Name = "dgvFactors";
            this.dgvFactors.ReadOnly = true;
            this.dgvFactors.RowTemplate.Height = 23;
            this.dgvFactors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactors.Size = new System.Drawing.Size(911, 318);
            this.dgvFactors.TabIndex = 2;
            this.dgvFactors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            // 
            // factorCodeColumn
            // 
            this.factorCodeColumn.DataPropertyName = "FactorCode";
            this.factorCodeColumn.HeaderText = "机构代码";
            this.factorCodeColumn.Name = "factorCodeColumn";
            this.factorCodeColumn.ReadOnly = true;
            // 
            // FactorTypeColumn
            // 
            this.FactorTypeColumn.DataPropertyName = "FactorType";
            this.FactorTypeColumn.HeaderText = "机构类型";
            this.FactorTypeColumn.Name = "FactorTypeColumn";
            this.FactorTypeColumn.ReadOnly = true;
            // 
            // CompanyNameCNColumn
            // 
            this.CompanyNameCNColumn.DataPropertyName = "CompanyNameCN";
            this.CompanyNameCNColumn.HeaderText = "公司名称(中)";
            this.CompanyNameCNColumn.Name = "CompanyNameCNColumn";
            this.CompanyNameCNColumn.ReadOnly = true;
            // 
            // CompanyNameENColumn
            // 
            this.CompanyNameENColumn.DataPropertyName = "CompanyNameEN";
            this.CompanyNameENColumn.HeaderText = "公司名称(英)";
            this.CompanyNameENColumn.Name = "CompanyNameENColumn";
            this.CompanyNameENColumn.ReadOnly = true;
            // 
            // ShortNameColumn
            // 
            this.ShortNameColumn.DataPropertyName = "ShortName";
            this.ShortNameColumn.HeaderText = "Short Name";
            this.ShortNameColumn.Name = "ShortNameColumn";
            this.ShortNameColumn.ReadOnly = true;
            // 
            // CountryNameColumn
            // 
            this.CountryNameColumn.DataPropertyName = "CountryName";
            this.CountryNameColumn.HeaderText = "Country Name";
            this.CountryNameColumn.Name = "CountryNameColumn";
            this.CountryNameColumn.ReadOnly = true;
            // 
            // DepartmentColumn
            // 
            this.DepartmentColumn.DataPropertyName = "Department";
            this.DepartmentColumn.HeaderText = "Department";
            this.DepartmentColumn.Name = "DepartmentColumn";
            this.DepartmentColumn.ReadOnly = true;
            // 
            // PostalAddress_1Column
            // 
            this.PostalAddress_1Column.DataPropertyName = "PostalAddress_1";
            this.PostalAddress_1Column.HeaderText = "Postal Address 1";
            this.PostalAddress_1Column.Name = "PostalAddress_1Column";
            this.PostalAddress_1Column.ReadOnly = true;
            // 
            // PostalAddress_2Column
            // 
            this.PostalAddress_2Column.DataPropertyName = "PostalAddress_2";
            this.PostalAddress_2Column.HeaderText = "Postal Address 2";
            this.PostalAddress_2Column.Name = "PostalAddress_2Column";
            this.PostalAddress_2Column.ReadOnly = true;
            // 
            // PostalCodePostColumn
            // 
            this.PostalCodePostColumn.DataPropertyName = "PostalCodePost";
            this.PostalCodePostColumn.HeaderText = "Postal Code Post";
            this.PostalCodePostColumn.Name = "PostalCodePostColumn";
            this.PostalCodePostColumn.ReadOnly = true;
            // 
            // CityPostColumn
            // 
            this.CityPostColumn.DataPropertyName = "CityPost";
            this.CityPostColumn.HeaderText = "City Post";
            this.CityPostColumn.Name = "CityPostColumn";
            this.CityPostColumn.ReadOnly = true;
            // 
            // VisitingAddress_1Column
            // 
            this.VisitingAddress_1Column.DataPropertyName = "VisitingAddress_1";
            this.VisitingAddress_1Column.HeaderText = "Visiting Address 1";
            this.VisitingAddress_1Column.Name = "VisitingAddress_1Column";
            this.VisitingAddress_1Column.ReadOnly = true;
            // 
            // VisitingAddress_2Column
            // 
            this.VisitingAddress_2Column.DataPropertyName = "VisitingAddress_2";
            this.VisitingAddress_2Column.HeaderText = "Visiting Address 2";
            this.VisitingAddress_2Column.Name = "VisitingAddress_2Column";
            this.VisitingAddress_2Column.ReadOnly = true;
            // 
            // PostalCodeVisitingColumn
            // 
            this.PostalCodeVisitingColumn.DataPropertyName = "PostalCodeVisiting";
            this.PostalCodeVisitingColumn.HeaderText = "Postal Code Visiting";
            this.PostalCodeVisitingColumn.Name = "PostalCodeVisitingColumn";
            this.PostalCodeVisitingColumn.ReadOnly = true;
            // 
            // CityVisitingColumn
            // 
            this.CityVisitingColumn.DataPropertyName = "CityVisiting";
            this.CityVisitingColumn.HeaderText = "City Visiting";
            this.CityVisitingColumn.Name = "CityVisitingColumn";
            this.CityVisitingColumn.ReadOnly = true;
            // 
            // EmailColumn
            // 
            this.EmailColumn.DataPropertyName = "Email";
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            // 
            // WebsiteColumn
            // 
            this.WebsiteColumn.DataPropertyName = "Website";
            this.WebsiteColumn.HeaderText = "Website";
            this.WebsiteColumn.Name = "WebsiteColumn";
            this.WebsiteColumn.ReadOnly = true;
            // 
            // Telephone_1Column
            // 
            this.Telephone_1Column.DataPropertyName = "Telephone_1";
            this.Telephone_1Column.HeaderText = "Telephone 1";
            this.Telephone_1Column.Name = "Telephone_1Column";
            this.Telephone_1Column.ReadOnly = true;
            // 
            // Telephone_2Column
            // 
            this.Telephone_2Column.DataPropertyName = "Telephone_2";
            this.Telephone_2Column.HeaderText = "Telephone 2";
            this.Telephone_2Column.Name = "Telephone_2Column";
            this.Telephone_2Column.ReadOnly = true;
            // 
            // Telefax_1Column
            // 
            this.Telefax_1Column.DataPropertyName = "Telefax_1";
            this.Telefax_1Column.HeaderText = "Telefax 1";
            this.Telefax_1Column.Name = "Telefax_1Column";
            this.Telefax_1Column.ReadOnly = true;
            // 
            // Telefax_2Column
            // 
            this.Telefax_2Column.DataPropertyName = "Telefax_2";
            this.Telefax_2Column.HeaderText = "Telefax 2";
            this.Telefax_2Column.Name = "Telefax_2Column";
            this.Telefax_2Column.ReadOnly = true;
            // 
            // WorkingHoursColumn
            // 
            this.WorkingHoursColumn.DataPropertyName = "WorkingHours";
            this.WorkingHoursColumn.HeaderText = "Working Hours";
            this.WorkingHoursColumn.Name = "WorkingHoursColumn";
            this.WorkingHoursColumn.ReadOnly = true;
            // 
            // GeneralCorrespondence_1Column
            // 
            this.GeneralCorrespondence_1Column.DataPropertyName = "GeneralCorrespondence_1";
            this.GeneralCorrespondence_1Column.HeaderText = "General Correspondence 1";
            this.GeneralCorrespondence_1Column.Name = "GeneralCorrespondence_1Column";
            this.GeneralCorrespondence_1Column.ReadOnly = true;
            // 
            // GeneralCorrespondence_2Column
            // 
            this.GeneralCorrespondence_2Column.DataPropertyName = "GeneralCorrespondence_2";
            this.GeneralCorrespondence_2Column.HeaderText = "General Correspondence 2";
            this.GeneralCorrespondence_2Column.Name = "GeneralCorrespondence_2Column";
            this.GeneralCorrespondence_2Column.ReadOnly = true;
            // 
            // Contacts_1Column
            // 
            this.Contacts_1Column.DataPropertyName = "Contacts_1";
            this.Contacts_1Column.HeaderText = "Contacts 1";
            this.Contacts_1Column.Name = "Contacts_1Column";
            this.Contacts_1Column.ReadOnly = true;
            // 
            // Contacts_2Column
            // 
            this.Contacts_2Column.DataPropertyName = "Contacts_2";
            this.Contacts_2Column.HeaderText = "Contacts 2";
            this.Contacts_2Column.Name = "Contacts_2Column";
            this.Contacts_2Column.ReadOnly = true;
            // 
            // Contacts_3Column
            // 
            this.Contacts_3Column.DataPropertyName = "Contacts_3";
            this.Contacts_3Column.HeaderText = "Contacts 3";
            this.Contacts_3Column.Name = "Contacts_3Column";
            this.Contacts_3Column.ReadOnly = true;
            // 
            // Contacts_4Column
            // 
            this.Contacts_4Column.DataPropertyName = "Contacts_4";
            this.Contacts_4Column.HeaderText = "Contacts 4";
            this.Contacts_4Column.Name = "Contacts_4Column";
            this.Contacts_4Column.ReadOnly = true;
            // 
            // Management_1Column
            // 
            this.Management_1Column.DataPropertyName = "Management_1";
            this.Management_1Column.HeaderText = "Management 1";
            this.Management_1Column.Name = "Management_1Column";
            this.Management_1Column.ReadOnly = true;
            // 
            // Management_2Column
            // 
            this.Management_2Column.DataPropertyName = "Management_2";
            this.Management_2Column.HeaderText = "Management 2";
            this.Management_2Column.Name = "Management_2Column";
            this.Management_2Column.ReadOnly = true;
            // 
            // ShareHoldersColumn
            // 
            this.ShareHoldersColumn.DataPropertyName = "ShareHolders";
            this.ShareHoldersColumn.HeaderText = "Share Holders";
            this.ShareHoldersColumn.Name = "ShareHoldersColumn";
            this.ShareHoldersColumn.ReadOnly = true;
            // 
            // IFISColumn
            // 
            this.IFISColumn.DataPropertyName = "IFISAvailableOnPrivateForum";
            this.IFISColumn.HeaderText = "IFIS Available On Private Forum";
            this.IFISColumn.Name = "IFISColumn";
            this.IFISColumn.ReadOnly = true;
            // 
            // MembershipStatusColumn
            // 
            this.MembershipStatusColumn.DataPropertyName = "MembershipStatus";
            this.MembershipStatusColumn.HeaderText = "Memebership Status";
            this.MembershipStatusColumn.Name = "MembershipStatusColumn";
            this.MembershipStatusColumn.ReadOnly = true;
            // 
            // MembershipDateColumn
            // 
            this.MembershipDateColumn.DataPropertyName = "MembershipDate";
            this.MembershipDateColumn.HeaderText = "Membership Date";
            this.MembershipDateColumn.Name = "MembershipDateColumn";
            this.MembershipDateColumn.ReadOnly = true;
            // 
            // DateOfLatestRevisionColumn
            // 
            this.DateOfLatestRevisionColumn.DataPropertyName = "DateOfLatestRevision";
            this.DateOfLatestRevisionColumn.HeaderText = "Date of Latest Revision";
            this.DateOfLatestRevisionColumn.Name = "DateOfLatestRevisionColumn";
            this.DateOfLatestRevisionColumn.ReadOnly = true;
            // 
            // IsGroupColumn
            // 
            this.IsGroupColumn.DataPropertyName = "IsGroup";
            this.IsGroupColumn.HeaderText = "是否集团公司";
            this.IsGroupColumn.Name = "IsGroupColumn";
            this.IsGroupColumn.ReadOnly = true;
            // 
            // GroupNoColumn
            // 
            this.GroupNoColumn.DataPropertyName = "GroupNo";
            this.GroupNoColumn.HeaderText = "所属集团号";
            this.GroupNoColumn.Name = "GroupNoColumn";
            this.GroupNoColumn.ReadOnly = true;
            // 
            // GroupNameCNColumn
            // 
            this.GroupNameCNColumn.DataPropertyName = "GroupNameCN";
            this.GroupNameCNColumn.HeaderText = "集团名称(中)";
            this.GroupNameCNColumn.Name = "GroupNameCNColumn";
            this.GroupNameCNColumn.ReadOnly = true;
            // 
            // GroupNameENColumn
            // 
            this.GroupNameENColumn.DataPropertyName = "GroupNameEN";
            this.GroupNameENColumn.HeaderText = "集团名称(英)";
            this.GroupNameENColumn.Name = "GroupNameENColumn";
            this.GroupNameENColumn.ReadOnly = true;
            // 
            // IsCorrespondentBankColumn
            // 
            this.IsCorrespondentBankColumn.DataPropertyName = "IsCorrespondentBank";
            this.IsCorrespondentBankColumn.HeaderText = "是否我行代理行";
            this.IsCorrespondentBankColumn.Name = "IsCorrespondentBankColumn";
            this.IsCorrespondentBankColumn.ReadOnly = true;
            // 
            // IsAgreementSignColumn
            // 
            this.IsAgreementSignColumn.DataPropertyName = "IsAgreementSigned";
            this.IsAgreementSignColumn.HeaderText = "是否签订代理协议";
            this.IsAgreementSignColumn.Name = "IsAgreementSignColumn";
            this.IsAgreementSignColumn.ReadOnly = true;
            // 
            // CommentColumn
            // 
            this.CommentColumn.DataPropertyName = "Comment";
            this.CommentColumn.HeaderText = "备注";
            this.CommentColumn.Name = "CommentColumn";
            this.CommentColumn.ReadOnly = true;
            // 
            // FactorMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dgvFactors);
            this.Controls.Add(this.panelQuery);
            this.Name = "FactorMgr";
            this.Size = new System.Drawing.Size(911, 348);
            this.contextMenuFactorMgr.ResumeLayout(false);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameENColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalAddress_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalAddress_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCodePostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityPostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitingAddress_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitingAddress_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCodeVisitingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityVisitingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebsiteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefax_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefax_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingHoursColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneralCorrespondence_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneralCorrespondence_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacts_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacts_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacts_3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacts_4Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Management_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Management_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShareHoldersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IFISColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfLatestRevisionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsGroupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNameCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNameENColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCorrespondentBankColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsAgreementSignColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentColumn;
    }
}

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
            this.CountryNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLineOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnReset.TabIndex = 9;
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
            this.cbCountry.TabIndex = 3;
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
            this.lblCountry.TabIndex = 2;
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
            this.lblCount.TabIndex = 10;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(646, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(41, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 8;
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
            this.tbFactorName.TabIndex = 7;
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
            this.lblFactorName.TabIndex = 6;
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
            this.tbFactorCode.TabIndex = 5;
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
            this.lblFactorCode.TabIndex = 4;
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
            this.dgvFactors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.CountryNameColumn,
            this.colCreditLine,
            this.colDueDate,
            this.colCreditLineOutstanding,
            this.colAssignOutstanding});
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
            this.dgvFactors.TabIndex = 0;
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
            this.CompanyNameENColumn.FillWeight = 300F;
            this.CompanyNameENColumn.HeaderText = "公司名称(英)";
            this.CompanyNameENColumn.Name = "CompanyNameENColumn";
            this.CompanyNameENColumn.ReadOnly = true;
            // 
            // CountryNameColumn
            // 
            this.CountryNameColumn.DataPropertyName = "CountryName";
            this.CountryNameColumn.FillWeight = 120F;
            this.CountryNameColumn.HeaderText = "国家";
            this.CountryNameColumn.Name = "CountryNameColumn";
            this.CountryNameColumn.ReadOnly = true;
            // 
            // colCreditLine
            // 
            this.colCreditLine.DataPropertyName = "CreditLine";
            this.colCreditLine.HeaderText = "额度";
            this.colCreditLine.Name = "colCreditLine";
            this.colCreditLine.ReadOnly = true;
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "DueDate";
            this.colDueDate.HeaderText = "到期日";
            this.colDueDate.Name = "colDueDate";
            this.colDueDate.ReadOnly = true;
            // 
            // colCreditLineOutstanding
            // 
            this.colCreditLineOutstanding.DataPropertyName = "CreditLineOutstanding";
            this.colCreditLineOutstanding.HeaderText = "剩余额度";
            this.colCreditLineOutstanding.Name = "colCreditLineOutstanding";
            this.colCreditLineOutstanding.ReadOnly = true;
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            this.colAssignOutstanding.HeaderText = "应收账款余额";
            this.colAssignOutstanding.Name = "colAssignOutstanding";
            this.colAssignOutstanding.ReadOnly = true;
            // 
            // FactorMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.dgvFactors);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOutstanding;
    }
}

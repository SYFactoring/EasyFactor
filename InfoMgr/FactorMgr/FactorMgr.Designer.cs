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
		#region?Fields?(26)?

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCountry;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFactorType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameENColumn;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ContextMenuStrip contextMenuFactorMgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryNameColumn;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFactors;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorTypeColumn;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblCountry;
        private DevComponents.DotNetBar.LabelX lblFactorCode;
        private DevComponents.DotNetBar.LabelX lblFactorName;
        private DevComponents.DotNetBar.LabelX lblFactorType;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorCreditLineNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemFactorSelect;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;

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
            this.menuItemFactorDelete = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuItemFactorDelete});
            this.contextMenuFactorMgr.Name = "contextMenuFactorMgr";
            this.contextMenuFactorMgr.Size = new System.Drawing.Size(147, 120);
            // 
            // menuItemFactorSelect
            // 
            this.menuItemFactorSelect.Name = "menuItemFactorSelect";
            this.menuItemFactorSelect.Size = new System.Drawing.Size(146, 22);
            this.menuItemFactorSelect.Text = "ѡ������";
            this.menuItemFactorSelect.Click += new System.EventHandler(this.SelectFactor);
            // 
            // menuItemFactorDetail
            // 
            this.menuItemFactorDetail.Name = "menuItemFactorDetail";
            this.menuItemFactorDetail.Size = new System.Drawing.Size(146, 22);
            this.menuItemFactorDetail.Text = "��ϸ��Ϣ";
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
            this.menuItemFactorNew.Text = "�½�����";
            this.menuItemFactorNew.Click += new System.EventHandler(this.NewFactor);
            // 
            // menuItemFactorCreditLineNew
            // 
            this.menuItemFactorCreditLineNew.Name = "menuItemFactorCreditLineNew";
            this.menuItemFactorCreditLineNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemFactorCreditLineNew.Text = "�½������Ϣ";
            this.menuItemFactorCreditLineNew.Click += new System.EventHandler(this.NewFactorCreditLine);
            // 
            // menuItemFactorDelete
            // 
            this.menuItemFactorDelete.Name = "menuItemFactorDelete";
            this.menuItemFactorDelete.Size = new System.Drawing.Size(146, 22);
            this.menuItemFactorDelete.Text = "ɾ������";
            this.menuItemFactorDelete.Click += new System.EventHandler(this.DeleteFactor);
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
            this.btnReset.Text = "����";
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
            this.lblCountry.Text = "���ڹ�";
            // 
            // cbFactorType
            // 
            this.cbFactorType.DisplayMember = "Text";
            this.cbFactorType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFactorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFactorType.FormattingEnabled = true;
            this.cbFactorType.Items.AddRange(new object[] {
            "ȫ��",
            "������",
            "���չ�˾",
            "��ܻ���",
            "������"});
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
            this.btnQuery.Text = "��ѯ";
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
            this.lblFactorName.Text = "��������";
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
            this.lblFactorCode.Text = "�������";
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
            this.lblFactorType.Text = "��������";
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
            this.CountryNameColumn});
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
            this.dgvFactors.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvFactors_RowPostPaint);
            // 
            // factorCodeColumn
            // 
            this.factorCodeColumn.DataPropertyName = "FactorCode";
            this.factorCodeColumn.HeaderText = "��������";
            this.factorCodeColumn.Name = "factorCodeColumn";
            this.factorCodeColumn.ReadOnly = true;
            // 
            // FactorTypeColumn
            // 
            this.FactorTypeColumn.DataPropertyName = "FactorType";
            this.FactorTypeColumn.HeaderText = "��������";
            this.FactorTypeColumn.Name = "FactorTypeColumn";
            this.FactorTypeColumn.ReadOnly = true;
            // 
            // CompanyNameCNColumn
            // 
            this.CompanyNameCNColumn.DataPropertyName = "CompanyNameCN";
            this.CompanyNameCNColumn.HeaderText = "��˾����(��)";
            this.CompanyNameCNColumn.Name = "CompanyNameCNColumn";
            this.CompanyNameCNColumn.ReadOnly = true;
            // 
            // CompanyNameENColumn
            // 
            this.CompanyNameENColumn.DataPropertyName = "CompanyNameEN";
            this.CompanyNameENColumn.FillWeight = 300F;
            this.CompanyNameENColumn.HeaderText = "��˾����(Ӣ)";
            this.CompanyNameENColumn.Name = "CompanyNameENColumn";
            this.CompanyNameENColumn.ReadOnly = true;
            // 
            // CountryNameColumn
            // 
            this.CountryNameColumn.DataPropertyName = "CountryName";
            this.CountryNameColumn.FillWeight = 120F;
            this.CountryNameColumn.HeaderText = "����";
            this.CountryNameColumn.Name = "CountryNameColumn";
            this.CountryNameColumn.ReadOnly = true;
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
    }
}

//-----------------------------------------------------------------------
// <copyright file="FactorDetailUI.Designer.cs" company="CISL@Fudan">
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
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ContextMenuStrip contextMenuFactorMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelectFactor;
        private System.Windows.Forms.ToolStripMenuItem menuItemDetailFactor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewFactor;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdateFactor;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteFactor;
        private System.Windows.Forms.ToolStripMenuItem menuItemImportFactors;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuFactorMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelectFactor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDetailFactor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemNewFactor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpdateFactor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteFactor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemImportFactors = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.cbFactorType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbFactorName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactorName = new DevComponents.DotNetBar.LabelX();
            this.tbFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFactorCode = new DevComponents.DotNetBar.LabelX();
            this.lblFactorType = new DevComponents.DotNetBar.LabelX();
            this.dgvFactors = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.factorCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuFactorMgr.SuspendLayout();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactors)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuFactorMgr
            // 
            this.contextMenuFactorMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelectFactor,
            this.menuItemDetailFactor,
            this.toolStripSeparator,
            this.menuItemNewFactor,
            this.menuItemUpdateFactor,
            this.menuItemDeleteFactor,
            this.menuItemImportFactors});
            this.contextMenuFactorMgr.Name = "contextMenuFactorMgr";
            this.contextMenuFactorMgr.Size = new System.Drawing.Size(153, 164);
            // 
            // menuItemSelectFactor
            // 
            this.menuItemSelectFactor.Name = "menuItemSelectFactor";
            this.menuItemSelectFactor.Size = new System.Drawing.Size(152, 22);
            this.menuItemSelectFactor.Text = "选定机构";
            this.menuItemSelectFactor.Click += new System.EventHandler(this.SelectFactor);
            // 
            // menuItemDetailFactor
            // 
            this.menuItemDetailFactor.Name = "menuItemDetailFactor";
            this.menuItemDetailFactor.Size = new System.Drawing.Size(152, 22);
            this.menuItemDetailFactor.Text = "详细信息";
            this.menuItemDetailFactor.Click += new System.EventHandler(this.DetailFactor);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // menuItemNewFactor
            // 
            this.menuItemNewFactor.Name = "menuItemNewFactor";
            this.menuItemNewFactor.Size = new System.Drawing.Size(152, 22);
            this.menuItemNewFactor.Text = "新建机构";
            this.menuItemNewFactor.Click += new System.EventHandler(this.NewFactor);
            // 
            // menuItemUpdateFactor
            // 
            this.menuItemUpdateFactor.Name = "menuItemUpdateFactor";
            this.menuItemUpdateFactor.Size = new System.Drawing.Size(152, 22);
            this.menuItemUpdateFactor.Text = "更新机构";
            this.menuItemUpdateFactor.Click += new System.EventHandler(this.UpdateFactor);
            // 
            // menuItemDeleteFactor
            // 
            this.menuItemDeleteFactor.Name = "menuItemDeleteFactor";
            this.menuItemDeleteFactor.Size = new System.Drawing.Size(152, 22);
            this.menuItemDeleteFactor.Text = "删除机构";
            this.menuItemDeleteFactor.Click += new System.EventHandler(this.DeleteFactor);
            // 
            // menuItemImportFactors
            // 
            this.menuItemImportFactors.Name = "menuItemImportFactors";
            this.menuItemImportFactors.Size = new System.Drawing.Size(152, 22);
            this.menuItemImportFactors.Text = "导入机构";
            this.menuItemImportFactors.Click += new System.EventHandler(this.ImportFactosImpl);
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.panelQuery.Size = new System.Drawing.Size(911, 34);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 1;
            // 
            // cbFactorType
            // 
            this.cbFactorType.DisplayMember = "Text";
            this.cbFactorType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFactorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFactorType.FormattingEnabled = true;
            this.cbFactorType.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4});
            this.cbFactorType.Location = new System.Drawing.Point(82, 10);
            this.cbFactorType.Name = "cbFactorType";
            this.cbFactorType.Size = new System.Drawing.Size(99, 21);
            this.cbFactorType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFactorType.TabIndex = 1;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "保理商";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "保险公司";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "监管机构";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "代付行";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(596, 5);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 7;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(515, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
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
            this.tbFactorName.Location = new System.Drawing.Point(409, 8);
            this.tbFactorName.Name = "tbFactorName";
            this.tbFactorName.Size = new System.Drawing.Size(100, 20);
            this.tbFactorName.TabIndex = 5;
            // 
            // lblFactorName
            // 
            // 
            // 
            // 
            this.lblFactorName.BackgroundStyle.Class = "";
            this.lblFactorName.Location = new System.Drawing.Point(354, 10);
            this.lblFactorName.Name = "lblFactorName";
            this.lblFactorName.Size = new System.Drawing.Size(75, 23);
            this.lblFactorName.TabIndex = 4;
            this.lblFactorName.Text = "机构名称";
            // 
            // tbFactorCode
            // 
            // 
            // 
            // 
            this.tbFactorCode.Border.Class = "TextBoxBorder";
            this.tbFactorCode.Location = new System.Drawing.Point(248, 7);
            this.tbFactorCode.Name = "tbFactorCode";
            this.tbFactorCode.Size = new System.Drawing.Size(100, 20);
            this.tbFactorCode.TabIndex = 3;
            // 
            // lblFactorCode
            // 
            // 
            // 
            // 
            this.lblFactorCode.BackgroundStyle.Class = "";
            this.lblFactorCode.Location = new System.Drawing.Point(190, 9);
            this.lblFactorCode.Name = "lblFactorCode";
            this.lblFactorCode.Size = new System.Drawing.Size(61, 23);
            this.lblFactorCode.TabIndex = 2;
            this.lblFactorCode.Text = "机构编号";
            // 
            // lblFactorType
            // 
            // 
            // 
            // 
            this.lblFactorType.BackgroundStyle.Class = "";
            this.lblFactorType.Location = new System.Drawing.Point(12, 10);
            this.lblFactorType.Name = "lblFactorType";
            this.lblFactorType.Size = new System.Drawing.Size(64, 23);
            this.lblFactorType.TabIndex = 0;
            this.lblFactorType.Text = "机构类型";
            // 
            // dgvFactors
            // 
            this.dgvFactors.AllowUserToAddRows = false;
            this.dgvFactors.AllowUserToDeleteRows = false;
            this.dgvFactors.AllowUserToOrderColumns = true;
            this.dgvFactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factorCodeColumn});
            this.dgvFactors.ContextMenuStrip = this.contextMenuFactorMgr;
            this.dgvFactors.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactors.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFactors.Location = new System.Drawing.Point(0, 34);
            this.dgvFactors.MultiSelect = false;
            this.dgvFactors.Name = "dgvFactors";
            this.dgvFactors.ReadOnly = true;
            this.dgvFactors.RowTemplate.Height = 23;
            this.dgvFactors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFactors.Size = new System.Drawing.Size(911, 314);
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

        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.LabelX lblFactorName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorCode;
        private DevComponents.DotNetBar.LabelX lblFactorCode;
        private DevComponents.DotNetBar.LabelX lblFactorType;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorName;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFactors;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFactorType;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorCodeColumn;
    }
}

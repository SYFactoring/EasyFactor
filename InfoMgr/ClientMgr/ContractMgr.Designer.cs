namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    partial class ContractMgr
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.panelContractQuery = new DevComponents.DotNetBar.PanelEx();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnContractQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbContractCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblContractCode = new DevComponents.DotNetBar.LabelX();
            this.dgvContracts = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ContractCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuContractMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemContractSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContractDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemContractNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContractUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContractDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContractImport = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContractQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.cmuContractMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContractQuery
            // 
            this.panelContractQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelContractQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelContractQuery.Controls.Add(this.lblCount);
            this.panelContractQuery.Controls.Add(this.btnContractQuery);
            this.panelContractQuery.Controls.Add(this.tbContractCode);
            this.panelContractQuery.Controls.Add(this.lblContractCode);
            this.panelContractQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContractQuery.Location = new System.Drawing.Point(0, 0);
            this.panelContractQuery.Name = "panelContractQuery";
            this.panelContractQuery.Size = new System.Drawing.Size(593, 32);
            this.panelContractQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelContractQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelContractQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelContractQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelContractQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelContractQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelContractQuery.Style.GradientAngle = 90;
            this.panelContractQuery.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(244, 3);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 3;
            // 
            // btnContractQuery
            // 
            this.btnContractQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractQuery.Location = new System.Drawing.Point(163, 3);
            this.btnContractQuery.Name = "btnContractQuery";
            this.btnContractQuery.Size = new System.Drawing.Size(75, 23);
            this.btnContractQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnContractQuery.TabIndex = 2;
            this.btnContractQuery.Text = "查询";
            this.btnContractQuery.Click += new System.EventHandler(this.QueryContracts);
            // 
            // tbContractCode
            // 
            // 
            // 
            // 
            this.tbContractCode.Border.Class = "TextBoxBorder";
            this.tbContractCode.Location = new System.Drawing.Point(57, 3);
            this.tbContractCode.Name = "tbContractCode";
            this.tbContractCode.Size = new System.Drawing.Size(100, 20);
            this.tbContractCode.TabIndex = 1;
            // 
            // lblContractCode
            // 
            // 
            // 
            // 
            this.lblContractCode.BackgroundStyle.Class = "";
            this.lblContractCode.Location = new System.Drawing.Point(3, 3);
            this.lblContractCode.Name = "lblContractCode";
            this.lblContractCode.Size = new System.Drawing.Size(58, 23);
            this.lblContractCode.TabIndex = 0;
            this.lblContractCode.Text = "合同编号";
            // 
            // dgvContracts
            // 
            this.dgvContracts.AllowUserToAddRows = false;
            this.dgvContracts.AllowUserToDeleteRows = false;
            this.dgvContracts.AllowUserToOrderColumns = true;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractCodeColumn});
            this.dgvContracts.ContextMenuStrip = this.cmuContractMgr;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContracts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvContracts.Location = new System.Drawing.Point(0, 32);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            this.dgvContracts.Size = new System.Drawing.Size(593, 358);
            this.dgvContracts.TabIndex = 1;
            // 
            // ContractCodeColumn
            // 
            this.ContractCodeColumn.DataPropertyName = "ContractCode";
            this.ContractCodeColumn.HeaderText = "合同编号";
            this.ContractCodeColumn.Name = "ContractCodeColumn";
            this.ContractCodeColumn.ReadOnly = true;
            // 
            // cmuContractMgr
            // 
            this.cmuContractMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemContractSelect,
            this.menuItemContractDetail,
            this.toolStripSeparator,
            this.menuItemContractNew,
            this.menuItemContractUpdate,
            this.menuItemContractDelete,
            this.menuItemContractImport});
            this.cmuContractMgr.Name = "cmuContractMgr";
            this.cmuContractMgr.Size = new System.Drawing.Size(153, 164);
            // 
            // menuItemContractSelect
            // 
            this.menuItemContractSelect.Name = "menuItemContractSelect";
            this.menuItemContractSelect.Size = new System.Drawing.Size(152, 22);
            this.menuItemContractSelect.Text = "选定合同";
            this.menuItemContractSelect.Click += new System.EventHandler(this.SelectContract);
            // 
            // menuItemContractDetail
            // 
            this.menuItemContractDetail.Name = "menuItemContractDetail";
            this.menuItemContractDetail.Size = new System.Drawing.Size(152, 22);
            this.menuItemContractDetail.Text = "详细信息";
            this.menuItemContractDetail.Click += new System.EventHandler(this.DetailContract);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // menuItemContractNew
            // 
            this.menuItemContractNew.Name = "menuItemContractNew";
            this.menuItemContractNew.Size = new System.Drawing.Size(152, 22);
            this.menuItemContractNew.Text = "新建合同";
            this.menuItemContractNew.Click += new System.EventHandler(this.NewContract);
            // 
            // menuItemContractUpdate
            // 
            this.menuItemContractUpdate.Name = "menuItemContractUpdate";
            this.menuItemContractUpdate.Size = new System.Drawing.Size(152, 22);
            this.menuItemContractUpdate.Text = "更新合同";
            this.menuItemContractUpdate.Click += new System.EventHandler(this.UpdateContract);
            // 
            // menuItemContractDelete
            // 
            this.menuItemContractDelete.Name = "menuItemContractDelete";
            this.menuItemContractDelete.Size = new System.Drawing.Size(152, 22);
            this.menuItemContractDelete.Text = "删除合同";
            this.menuItemContractDelete.Click += new System.EventHandler(this.DeleteContract);
            // 
            // menuItemContractImport
            // 
            this.menuItemContractImport.Name = "menuItemContractImport";
            this.menuItemContractImport.Size = new System.Drawing.Size(152, 22);
            this.menuItemContractImport.Text = "导入合同";
            this.menuItemContractImport.Click += new System.EventHandler(this.ImportContracts);
            // 
            // ContractMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvContracts);
            this.Controls.Add(this.panelContractQuery);
            this.Name = "ContractMgr";
            this.Size = new System.Drawing.Size(593, 390);
            this.panelContractQuery.ResumeLayout(false);
            this.panelContractQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.cmuContractMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelContractQuery;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvContracts;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.ButtonX btnContractQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbContractCode;
        private DevComponents.DotNetBar.LabelX lblContractCode;
        private System.Windows.Forms.ContextMenuStrip cmuContractMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemContractSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemContractDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemContractNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemContractUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuItemContractDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemContractImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractCodeColumn;
    }
}

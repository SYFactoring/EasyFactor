namespace CMBC.EasyFactor.CaseMgr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelContractQuery = new DevComponents.DotNetBar.PanelEx();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnContractQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbContractCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblContractCode = new DevComponents.DotNetBar.LabelX();
            this.dgvContracts = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmuContractMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemContractSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContractDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemContractNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContractUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContractDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemContractImport = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblContractStatus = new DevComponents.DotNetBar.LabelX();
            this.cbContractStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.ContractCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientEDICodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractValueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractDueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateUserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContractQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.cmuContractMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContractQuery
            // 
            this.panelContractQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelContractQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelContractQuery.Controls.Add(this.cbContractStatus);
            this.panelContractQuery.Controls.Add(this.lblContractStatus);
            this.panelContractQuery.Controls.Add(this.tbClientName);
            this.panelContractQuery.Controls.Add(this.lblClientName);
            this.panelContractQuery.Controls.Add(this.lblCount);
            this.panelContractQuery.Controls.Add(this.btnContractQuery);
            this.panelContractQuery.Controls.Add(this.tbContractCode);
            this.panelContractQuery.Controls.Add(this.lblContractCode);
            this.panelContractQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContractQuery.Location = new System.Drawing.Point(0, 0);
            this.panelContractQuery.Name = "panelContractQuery";
            this.panelContractQuery.Size = new System.Drawing.Size(768, 32);
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
            this.lblCount.Location = new System.Drawing.Point(562, 9);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(36, 16);
            this.lblCount.TabIndex = 3;
            // 
            // btnContractQuery
            // 
            this.btnContractQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnContractQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnContractQuery.Location = new System.Drawing.Point(481, 5);
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
            this.tbContractCode.Location = new System.Drawing.Point(57, 6);
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
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractCodeColumn,
            this.ClientEDICodeColumn,
            this.ClientColumn,
            this.ContractValueDateColumn,
            this.ContractDueDateColumn,
            this.ContractStatusColumn,
            this.CreateUserNameColumn});
            this.dgvContracts.ContextMenuStrip = this.cmuContractMgr;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContracts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContracts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvContracts.Location = new System.Drawing.Point(0, 32);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            this.dgvContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracts.Size = new System.Drawing.Size(768, 358);
            this.dgvContracts.TabIndex = 1;
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
            this.cmuContractMgr.Size = new System.Drawing.Size(123, 142);
            // 
            // menuItemContractSelect
            // 
            this.menuItemContractSelect.Name = "menuItemContractSelect";
            this.menuItemContractSelect.Size = new System.Drawing.Size(122, 22);
            this.menuItemContractSelect.Text = "选定合同";
            this.menuItemContractSelect.Click += new System.EventHandler(this.SelectContract);
            // 
            // menuItemContractDetail
            // 
            this.menuItemContractDetail.Name = "menuItemContractDetail";
            this.menuItemContractDetail.Size = new System.Drawing.Size(122, 22);
            this.menuItemContractDetail.Text = "详细信息";
            this.menuItemContractDetail.Click += new System.EventHandler(this.DetailContract);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(119, 6);
            // 
            // menuItemContractNew
            // 
            this.menuItemContractNew.Name = "menuItemContractNew";
            this.menuItemContractNew.Size = new System.Drawing.Size(122, 22);
            this.menuItemContractNew.Text = "新建合同";
            this.menuItemContractNew.Click += new System.EventHandler(this.NewContract);
            // 
            // menuItemContractUpdate
            // 
            this.menuItemContractUpdate.Name = "menuItemContractUpdate";
            this.menuItemContractUpdate.Size = new System.Drawing.Size(122, 22);
            this.menuItemContractUpdate.Text = "更新合同";
            this.menuItemContractUpdate.Click += new System.EventHandler(this.UpdateContract);
            // 
            // menuItemContractDelete
            // 
            this.menuItemContractDelete.Name = "menuItemContractDelete";
            this.menuItemContractDelete.Size = new System.Drawing.Size(122, 22);
            this.menuItemContractDelete.Text = "删除合同";
            this.menuItemContractDelete.Click += new System.EventHandler(this.DeleteContract);
            // 
            // menuItemContractImport
            // 
            this.menuItemContractImport.Name = "menuItemContractImport";
            this.menuItemContractImport.Size = new System.Drawing.Size(122, 22);
            this.menuItemContractImport.Text = "导入合同";
            this.menuItemContractImport.Click += new System.EventHandler(this.ImportContracts);
            // 
            // lblClientName
            // 
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.Class = "";
            this.lblClientName.Location = new System.Drawing.Point(163, 3);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(58, 23);
            this.lblClientName.TabIndex = 4;
            this.lblClientName.Text = "客户名称";
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Location = new System.Drawing.Point(216, 5);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 20);
            this.tbClientName.TabIndex = 5;
            // 
            // lblContractStatus
            // 
            // 
            // 
            // 
            this.lblContractStatus.BackgroundStyle.Class = "";
            this.lblContractStatus.Location = new System.Drawing.Point(322, 3);
            this.lblContractStatus.Name = "lblContractStatus";
            this.lblContractStatus.Size = new System.Drawing.Size(58, 23);
            this.lblContractStatus.TabIndex = 6;
            this.lblContractStatus.Text = "合同状态";
            // 
            // cbContractStatus
            // 
            this.cbContractStatus.DisplayMember = "Text";
            this.cbContractStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbContractStatus.FormattingEnabled = true;
            this.cbContractStatus.ItemHeight = 14;
            this.cbContractStatus.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cbContractStatus.Location = new System.Drawing.Point(377, 5);
            this.cbContractStatus.Name = "cbContractStatus";
            this.cbContractStatus.Size = new System.Drawing.Size(98, 20);
            this.cbContractStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbContractStatus.TabIndex = 7;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "正常";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "已过期";
            // 
            // ContractCodeColumn
            // 
            this.ContractCodeColumn.DataPropertyName = "ContractCode";
            this.ContractCodeColumn.HeaderText = "合同编号";
            this.ContractCodeColumn.Name = "ContractCodeColumn";
            this.ContractCodeColumn.ReadOnly = true;
            // 
            // ClientEDICodeColumn
            // 
            this.ClientEDICodeColumn.DataPropertyName = "ClientEDICode";
            this.ClientEDICodeColumn.HeaderText = "客户保理代码";
            this.ClientEDICodeColumn.Name = "ClientEDICodeColumn";
            this.ClientEDICodeColumn.ReadOnly = true;
            // 
            // ClientColumn
            // 
            this.ClientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClientColumn.DataPropertyName = "Client";
            this.ClientColumn.HeaderText = "客户名称";
            this.ClientColumn.Name = "ClientColumn";
            this.ClientColumn.ReadOnly = true;
            this.ClientColumn.Width = 200;
            // 
            // ContractValueDateColumn
            // 
            this.ContractValueDateColumn.DataPropertyName = "ContractValueDate";
            this.ContractValueDateColumn.HeaderText = "生效日";
            this.ContractValueDateColumn.Name = "ContractValueDateColumn";
            this.ContractValueDateColumn.ReadOnly = true;
            // 
            // ContractDueDateColumn
            // 
            this.ContractDueDateColumn.DataPropertyName = "ContractDueDate";
            this.ContractDueDateColumn.HeaderText = "过期日";
            this.ContractDueDateColumn.Name = "ContractDueDateColumn";
            this.ContractDueDateColumn.ReadOnly = true;
            // 
            // ContractStatusColumn
            // 
            this.ContractStatusColumn.DataPropertyName = "ContractStatus";
            this.ContractStatusColumn.HeaderText = "合同状态";
            this.ContractStatusColumn.Name = "ContractStatusColumn";
            this.ContractStatusColumn.ReadOnly = true;
            // 
            // CreateUserNameColumn
            // 
            this.CreateUserNameColumn.DataPropertyName = "CreateUserName";
            this.CreateUserNameColumn.HeaderText = "经办人";
            this.CreateUserNameColumn.Name = "CreateUserNameColumn";
            this.CreateUserNameColumn.ReadOnly = true;
            // 
            // ContractMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvContracts);
            this.Controls.Add(this.panelContractQuery);
            this.Name = "ContractMgr";
            this.Size = new System.Drawing.Size(768, 390);
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
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbContractStatus;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.LabelX lblContractStatus;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientEDICodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractValueDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractDueDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateUserNameColumn;
    }
}

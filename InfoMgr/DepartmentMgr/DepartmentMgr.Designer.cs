namespace CMBC.EasyFactor.InfoMgr.DepartmentMgr
{
    partial class DepartmentMgr
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
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbDepartmentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDeparmentName = new DevComponents.DotNetBar.LabelX();
            this.tbDepartmentCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDepartmentCode = new DevComponents.DotNetBar.LabelX();
            this.dgvDepts = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.DepartmentCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomainColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressCNColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressENColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax_1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax_2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuDeptMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelectDept = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemImportDepts = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepts)).BeginInit();
            this.cmuDeptMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.btnReset);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbDepartmentName);
            this.panelQuery.Controls.Add(this.lblDeparmentName);
            this.panelQuery.Controls.Add(this.tbDepartmentCode);
            this.panelQuery.Controls.Add(this.lblDepartmentCode);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(605, 31);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Location = new System.Drawing.Point(379, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(42, 23);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.Click += new System.EventHandler(this.Reset);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(427, 7);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCount.TabIndex = 6;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(330, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(43, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.QueryDepartments);
            // 
            // tbDepartmentName
            // 
            // 
            // 
            // 
            this.tbDepartmentName.Border.Class = "TextBoxBorder";
            this.tbDepartmentName.Location = new System.Drawing.Point(224, 5);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(100, 20);
            this.tbDepartmentName.TabIndex = 3;
            // 
            // lblDeparmentName
            // 
            // 
            // 
            // 
            this.lblDeparmentName.BackgroundStyle.Class = "";
            this.lblDeparmentName.Location = new System.Drawing.Point(167, 3);
            this.lblDeparmentName.Name = "lblDeparmentName";
            this.lblDeparmentName.Size = new System.Drawing.Size(56, 23);
            this.lblDeparmentName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDeparmentName.TabIndex = 2;
            this.lblDeparmentName.Text = "分部名称";
            // 
            // tbDepartmentCode
            // 
            // 
            // 
            // 
            this.tbDepartmentCode.Border.Class = "TextBoxBorder";
            this.tbDepartmentCode.Location = new System.Drawing.Point(61, 5);
            this.tbDepartmentCode.Name = "tbDepartmentCode";
            this.tbDepartmentCode.Size = new System.Drawing.Size(100, 20);
            this.tbDepartmentCode.TabIndex = 1;
            // 
            // lblDepartmentCode
            // 
            // 
            // 
            // 
            this.lblDepartmentCode.BackgroundStyle.Class = "";
            this.lblDepartmentCode.Location = new System.Drawing.Point(3, 3);
            this.lblDepartmentCode.Name = "lblDepartmentCode";
            this.lblDepartmentCode.Size = new System.Drawing.Size(56, 23);
            this.lblDepartmentCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDepartmentCode.TabIndex = 0;
            this.lblDepartmentCode.Text = "分部编号";
            // 
            // dgvDepts
            // 
            this.dgvDepts.AllowUserToAddRows = false;
            this.dgvDepts.AllowUserToDeleteRows = false;
            this.dgvDepts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentCodeColumn,
            this.DepartmentNameColumn,
            this.LocationColumn,
            this.DomainColumn,
            this.AddressCNColumn,
            this.AddressENColumn,
            this.PostCodeColumn,
            this.ManagerColumn,
            this.Contact_1Column,
            this.Email_1Column,
            this.Phone_1Column,
            this.Fax_1Column,
            this.Contact_2Column,
            this.Email_2Column,
            this.Phone_2Column,
            this.Fax_2Column});
            this.dgvDepts.ContextMenuStrip = this.cmuDeptMgr;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDepts.Location = new System.Drawing.Point(0, 31);
            this.dgvDepts.MultiSelect = false;
            this.dgvDepts.Name = "dgvDepts";
            this.dgvDepts.ReadOnly = true;
            this.dgvDepts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepts.Size = new System.Drawing.Size(605, 429);
            this.dgvDepts.TabIndex = 0;
            this.dgvDepts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            // 
            // DepartmentCodeColumn
            // 
            this.DepartmentCodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DepartmentCodeColumn.DataPropertyName = "DepartmentCode";
            this.DepartmentCodeColumn.FillWeight = 77.31959F;
            this.DepartmentCodeColumn.HeaderText = "部门代码";
            this.DepartmentCodeColumn.Name = "DepartmentCodeColumn";
            this.DepartmentCodeColumn.ReadOnly = true;
            // 
            // DepartmentNameColumn
            // 
            this.DepartmentNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DepartmentNameColumn.DataPropertyName = "DepartmentName";
            this.DepartmentNameColumn.HeaderText = "部门名称";
            this.DepartmentNameColumn.Name = "DepartmentNameColumn";
            this.DepartmentNameColumn.ReadOnly = true;
            // 
            // LocationColumn
            // 
            this.LocationColumn.DataPropertyName = "Location";
            this.LocationColumn.FillWeight = 77.31959F;
            this.LocationColumn.HeaderText = "城市";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            // 
            // DomainColumn
            // 
            this.DomainColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DomainColumn.DataPropertyName = "Domain";
            this.DomainColumn.FillWeight = 417.5258F;
            this.DomainColumn.HeaderText = "事业部";
            this.DomainColumn.Name = "DomainColumn";
            this.DomainColumn.ReadOnly = true;
            // 
            // AddressCNColumn
            // 
            this.AddressCNColumn.DataPropertyName = "AddressCN";
            this.AddressCNColumn.FillWeight = 77.31959F;
            this.AddressCNColumn.HeaderText = "中文地址";
            this.AddressCNColumn.Name = "AddressCNColumn";
            this.AddressCNColumn.ReadOnly = true;
            // 
            // AddressENColumn
            // 
            this.AddressENColumn.DataPropertyName = "AddressEN";
            this.AddressENColumn.FillWeight = 77.31959F;
            this.AddressENColumn.HeaderText = "英文地址";
            this.AddressENColumn.Name = "AddressENColumn";
            this.AddressENColumn.ReadOnly = true;
            // 
            // PostCodeColumn
            // 
            this.PostCodeColumn.DataPropertyName = "PostCode";
            this.PostCodeColumn.FillWeight = 77.31959F;
            this.PostCodeColumn.HeaderText = "邮编";
            this.PostCodeColumn.Name = "PostCodeColumn";
            this.PostCodeColumn.ReadOnly = true;
            // 
            // ManagerColumn
            // 
            this.ManagerColumn.DataPropertyName = "Manager";
            this.ManagerColumn.FillWeight = 77.31959F;
            this.ManagerColumn.HeaderText = "负责人";
            this.ManagerColumn.Name = "ManagerColumn";
            this.ManagerColumn.ReadOnly = true;
            // 
            // Contact_1Column
            // 
            this.Contact_1Column.DataPropertyName = "Contact_1";
            this.Contact_1Column.FillWeight = 77.31959F;
            this.Contact_1Column.HeaderText = "联系人1";
            this.Contact_1Column.Name = "Contact_1Column";
            this.Contact_1Column.ReadOnly = true;
            // 
            // Email_1Column
            // 
            this.Email_1Column.DataPropertyName = "Email_1";
            this.Email_1Column.FillWeight = 77.31959F;
            this.Email_1Column.HeaderText = "Email";
            this.Email_1Column.Name = "Email_1Column";
            this.Email_1Column.ReadOnly = true;
            // 
            // Phone_1Column
            // 
            this.Phone_1Column.DataPropertyName = "Phone_1";
            this.Phone_1Column.FillWeight = 77.31959F;
            this.Phone_1Column.HeaderText = "联系电话";
            this.Phone_1Column.Name = "Phone_1Column";
            this.Phone_1Column.ReadOnly = true;
            // 
            // Fax_1Column
            // 
            this.Fax_1Column.DataPropertyName = "Fax_1";
            this.Fax_1Column.FillWeight = 77.31959F;
            this.Fax_1Column.HeaderText = "传真";
            this.Fax_1Column.Name = "Fax_1Column";
            this.Fax_1Column.ReadOnly = true;
            // 
            // Contact_2Column
            // 
            this.Contact_2Column.DataPropertyName = "Contact_2";
            this.Contact_2Column.FillWeight = 77.31959F;
            this.Contact_2Column.HeaderText = "联系人2";
            this.Contact_2Column.Name = "Contact_2Column";
            this.Contact_2Column.ReadOnly = true;
            // 
            // Email_2Column
            // 
            this.Email_2Column.DataPropertyName = "Email_2";
            this.Email_2Column.FillWeight = 77.31959F;
            this.Email_2Column.HeaderText = "Email";
            this.Email_2Column.Name = "Email_2Column";
            this.Email_2Column.ReadOnly = true;
            // 
            // Phone_2Column
            // 
            this.Phone_2Column.DataPropertyName = "Phone_2";
            this.Phone_2Column.FillWeight = 77.31959F;
            this.Phone_2Column.HeaderText = "联系电话";
            this.Phone_2Column.Name = "Phone_2Column";
            this.Phone_2Column.ReadOnly = true;
            // 
            // Fax_2Column
            // 
            this.Fax_2Column.DataPropertyName = "Fax_2";
            this.Fax_2Column.FillWeight = 77.31959F;
            this.Fax_2Column.HeaderText = "传真";
            this.Fax_2Column.Name = "Fax_2Column";
            this.Fax_2Column.ReadOnly = true;
            // 
            // cmuDeptMgr
            // 
            this.cmuDeptMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelectDept,
            this.menuItemImportDepts});
            this.cmuDeptMgr.Name = "cmuDeptMgr";
            this.cmuDeptMgr.Size = new System.Drawing.Size(123, 48);
            // 
            // menuItemSelectDept
            // 
            this.menuItemSelectDept.Name = "menuItemSelectDept";
            this.menuItemSelectDept.Size = new System.Drawing.Size(122, 22);
            this.menuItemSelectDept.Text = "选定分部";
            this.menuItemSelectDept.Click += new System.EventHandler(this.SelectDepartment);
            // 
            // menuItemImportDepts
            // 
            this.menuItemImportDepts.Name = "menuItemImportDepts";
            this.menuItemImportDepts.Size = new System.Drawing.Size(122, 22);
            this.menuItemImportDepts.Text = "导入分部";
            this.menuItemImportDepts.Click += new System.EventHandler(this.ImportDepartments);
            // 
            // DepartmentMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDepts);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "DepartmentMgr";
            this.Size = new System.Drawing.Size(605, 460);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepts)).EndInit();
            this.cmuDeptMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDepts;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDepartmentName;
        private DevComponents.DotNetBar.LabelX lblDeparmentName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDepartmentCode;
        private DevComponents.DotNetBar.LabelX lblDepartmentCode;
        private DevComponents.DotNetBar.LabelX lblCount;
        private System.Windows.Forms.ContextMenuStrip cmuDeptMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelectDept;
        private System.Windows.Forms.ToolStripMenuItem menuItemImportDepts;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomainColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressCNColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressENColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax_1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax_2Column;
        private DevComponents.DotNetBar.ButtonX btnReset;
    }
}

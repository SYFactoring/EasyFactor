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
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbDepartmentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDeparmentName = new DevComponents.DotNetBar.LabelX();
            this.tbDepartmentCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDepartmentCode = new DevComponents.DotNetBar.LabelX();
            this.dgvDepts = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmuDeptMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemImport = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepts)).BeginInit();
            this.cmuDeptMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(412, 4);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCount.TabIndex = 5;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(330, 2);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
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
            this.lblDeparmentName.Location = new System.Drawing.Point(171, 7);
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
            this.tbDepartmentCode.Location = new System.Drawing.Point(65, 5);
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
            this.lblDepartmentCode.Location = new System.Drawing.Point(3, 7);
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
            this.dgvDepts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDepts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDepts.Location = new System.Drawing.Point(0, 31);
            this.dgvDepts.MultiSelect = false;
            this.dgvDepts.Name = "dgvDepts";
            this.dgvDepts.ReadOnly = true;
            this.dgvDepts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepts.Size = new System.Drawing.Size(605, 429);
            this.dgvDepts.TabIndex = 1;
            this.dgvDepts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            // 
            // cmuDeptMgr
            // 
            this.cmuDeptMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelect,
            this.menuItemImport});
            this.cmuDeptMgr.Name = "cmuDeptMgr";
            this.cmuDeptMgr.Size = new System.Drawing.Size(99, 48);
            // 
            // menuItemSelect
            // 
            this.menuItemSelect.Name = "menuItemSelect";
            this.menuItemSelect.Size = new System.Drawing.Size(98, 22);
            this.menuItemSelect.Text = "选定";
            this.menuItemSelect.Click += new System.EventHandler(this.SelectDepartment);
            // 
            // menuItemImport
            // 
            this.menuItemImport.Name = "menuItemImport";
            this.menuItemImport.Size = new System.Drawing.Size(98, 22);
            this.menuItemImport.Text = "导入";
            this.menuItemImport.Click += new System.EventHandler(this.ImportDepartments);
            // 
            // DepartmentCodeColumn
            // 
            this.DepartmentCodeColumn.DataPropertyName = "DepartmentCode";
            this.DepartmentCodeColumn.HeaderText = "部门代码";
            this.DepartmentCodeColumn.Name = "DepartmentCodeColumn";
            this.DepartmentCodeColumn.ReadOnly = true;
            this.DepartmentCodeColumn.Width = 80;
            // 
            // DepartmentNameColumn
            // 
            this.DepartmentNameColumn.DataPropertyName = "DepartmentName";
            this.DepartmentNameColumn.HeaderText = "部门名称";
            this.DepartmentNameColumn.Name = "DepartmentNameColumn";
            this.DepartmentNameColumn.ReadOnly = true;
            this.DepartmentNameColumn.Width = 80;
            // 
            // LocationColumn
            // 
            this.LocationColumn.DataPropertyName = "Location";
            this.LocationColumn.HeaderText = "城市";
            this.LocationColumn.Name = "LocationColumn";
            this.LocationColumn.ReadOnly = true;
            this.LocationColumn.Width = 56;
            // 
            // DomainColumn
            // 
            this.DomainColumn.DataPropertyName = "Domain";
            this.DomainColumn.HeaderText = "事业部";
            this.DomainColumn.Name = "DomainColumn";
            this.DomainColumn.ReadOnly = true;
            this.DomainColumn.Width = 68;
            // 
            // AddressCNColumn
            // 
            this.AddressCNColumn.DataPropertyName = "AddressCN";
            this.AddressCNColumn.HeaderText = "中文地址";
            this.AddressCNColumn.Name = "AddressCNColumn";
            this.AddressCNColumn.ReadOnly = true;
            this.AddressCNColumn.Width = 80;
            // 
            // AddressENColumn
            // 
            this.AddressENColumn.DataPropertyName = "AddressEN";
            this.AddressENColumn.HeaderText = "英文地址";
            this.AddressENColumn.Name = "AddressENColumn";
            this.AddressENColumn.ReadOnly = true;
            this.AddressENColumn.Width = 80;
            // 
            // PostCodeColumn
            // 
            this.PostCodeColumn.DataPropertyName = "PostCode";
            this.PostCodeColumn.HeaderText = "邮编";
            this.PostCodeColumn.Name = "PostCodeColumn";
            this.PostCodeColumn.ReadOnly = true;
            this.PostCodeColumn.Width = 56;
            // 
            // ManagerColumn
            // 
            this.ManagerColumn.DataPropertyName = "Manager";
            this.ManagerColumn.HeaderText = "负责人";
            this.ManagerColumn.Name = "ManagerColumn";
            this.ManagerColumn.ReadOnly = true;
            this.ManagerColumn.Width = 68;
            // 
            // Contact_1Column
            // 
            this.Contact_1Column.DataPropertyName = "Contact_1";
            this.Contact_1Column.HeaderText = "联系人1";
            this.Contact_1Column.Name = "Contact_1Column";
            this.Contact_1Column.ReadOnly = true;
            this.Contact_1Column.Width = 74;
            // 
            // Email_1Column
            // 
            this.Email_1Column.DataPropertyName = "Email_1";
            this.Email_1Column.HeaderText = "Email";
            this.Email_1Column.Name = "Email_1Column";
            this.Email_1Column.ReadOnly = true;
            this.Email_1Column.Width = 57;
            // 
            // Phone_1Column
            // 
            this.Phone_1Column.DataPropertyName = "Phone_1";
            this.Phone_1Column.HeaderText = "联系电话";
            this.Phone_1Column.Name = "Phone_1Column";
            this.Phone_1Column.ReadOnly = true;
            this.Phone_1Column.Width = 80;
            // 
            // Fax_1Column
            // 
            this.Fax_1Column.DataPropertyName = "Fax_1";
            this.Fax_1Column.HeaderText = "传真";
            this.Fax_1Column.Name = "Fax_1Column";
            this.Fax_1Column.ReadOnly = true;
            this.Fax_1Column.Width = 56;
            // 
            // Contact_2Column
            // 
            this.Contact_2Column.DataPropertyName = "Contact_2";
            this.Contact_2Column.HeaderText = "联系人2";
            this.Contact_2Column.Name = "Contact_2Column";
            this.Contact_2Column.ReadOnly = true;
            this.Contact_2Column.Width = 74;
            // 
            // Email_2Column
            // 
            this.Email_2Column.DataPropertyName = "Email_2";
            this.Email_2Column.HeaderText = "Email";
            this.Email_2Column.Name = "Email_2Column";
            this.Email_2Column.ReadOnly = true;
            this.Email_2Column.Width = 57;
            // 
            // Phone_2Column
            // 
            this.Phone_2Column.DataPropertyName = "Phone_2";
            this.Phone_2Column.HeaderText = "联系电话";
            this.Phone_2Column.Name = "Phone_2Column";
            this.Phone_2Column.ReadOnly = true;
            this.Phone_2Column.Width = 80;
            // 
            // Fax_2Column
            // 
            this.Fax_2Column.DataPropertyName = "Fax_2";
            this.Fax_2Column.HeaderText = "传真";
            this.Fax_2Column.Name = "Fax_2Column";
            this.Fax_2Column.ReadOnly = true;
            this.Fax_2Column.Width = 56;
            // 
            // DepartmentMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDepts);
            this.Controls.Add(this.panelQuery);
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
        private System.Windows.Forms.ToolStripMenuItem menuItemSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemImport;
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
    }
}

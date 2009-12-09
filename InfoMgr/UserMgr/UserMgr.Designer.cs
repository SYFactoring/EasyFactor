//-----------------------------------------------------------------------
// <copyright file="UserMgrUI.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.UserMgr
{
    /// <summary>
    /// User Management User Interface Designer
    /// </summary>
    public partial class UserMgr
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ContextMenuStrip cmuUserMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;

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
            this.cmuUserMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbKeyword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblKeyword = new DevComponents.DotNetBar.LabelX();
            this.dgvUsers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.UserIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIAccountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuUserMgr.SuspendLayout();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // cmuUserMgr
            // 
            this.cmuUserMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelect,
            this.menuItemDetail,
            this.toolStripSeparator,
            this.menuItemEdit});
            this.cmuUserMgr.Name = "contextMenuUserMgr";
            this.cmuUserMgr.Size = new System.Drawing.Size(99, 76);
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
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbKeyword);
            this.panelQuery.Controls.Add(this.lblKeyword);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(800, 33);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 5;
            // 
            // lblCount
            // 
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(243, 6);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(320, 23);
            this.lblCount.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(161, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.Query);
            // 
            // tbKeyword
            // 
            // 
            // 
            // 
            this.tbKeyword.Border.Class = "TextBoxBorder";
            this.tbKeyword.Location = new System.Drawing.Point(55, 7);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(100, 20);
            this.tbKeyword.TabIndex = 1;
            // 
            // lblKeyword
            // 
            // 
            // 
            // 
            this.lblKeyword.BackgroundStyle.Class = "";
            this.lblKeyword.Location = new System.Drawing.Point(4, 7);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(44, 23);
            this.lblKeyword.TabIndex = 0;
            this.lblKeyword.Text = "关键词";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIDColumn,
            this.UserName,
            this.EDIAccountColumn,
            this.RoleColumn,
            this.Phone,
            this.Telphone,
            this.Email,
            this.MSN,
            this.LoginDate});
            this.dgvUsers.ContextMenuStrip = this.cmuUserMgr;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvUsers.Location = new System.Drawing.Point(0, 33);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(800, 567);
            this.dgvUsers.TabIndex = 6;
            // 
            // UserIDColumn
            // 
            this.UserIDColumn.DataPropertyName = "UserID";
            this.UserIDColumn.HeaderText = "用户ID";
            this.UserIDColumn.Name = "UserIDColumn";
            this.UserIDColumn.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "姓名";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // EDIAccountColumn
            // 
            this.EDIAccountColumn.DataPropertyName = "EDIAccount";
            this.EDIAccountColumn.HeaderText = "EDI帐号";
            this.EDIAccountColumn.Name = "EDIAccountColumn";
            this.EDIAccountColumn.ReadOnly = true;
            // 
            // RoleColumn
            // 
            this.RoleColumn.DataPropertyName = "Role";
            this.RoleColumn.HeaderText = "角色";
            this.RoleColumn.Name = "RoleColumn";
            this.RoleColumn.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "电话";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Telphone
            // 
            this.Telphone.DataPropertyName = "Telphone";
            this.Telphone.HeaderText = "手机";
            this.Telphone.Name = "Telphone";
            this.Telphone.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // MSN
            // 
            this.MSN.DataPropertyName = "MSN";
            this.MSN.HeaderText = "MSN";
            this.MSN.Name = "MSN";
            this.MSN.ReadOnly = true;
            // 
            // LoginDate
            // 
            this.LoginDate.DataPropertyName = "LoginDate";
            this.LoginDate.HeaderText = "最后登录日期";
            this.LoginDate.Name = "LoginDate";
            this.LoginDate.ReadOnly = true;
            // 
            // UserMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.cmuUserMgr;
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panelQuery);
            this.Name = "UserMgr";
            this.Size = new System.Drawing.Size(800, 600);
            this.cmuUserMgr.ResumeLayout(false);
            this.panelQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.LabelX lblKeyword;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbKeyword;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDIAccountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginDate;
    }
}

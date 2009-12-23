//-----------------------------------------------------------------------
// <copyright file="UserMgrUI.Designer.cs" company="Yiming Liu@Fudan">
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
        #region Fields (25)

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private System.Windows.Forms.ContextMenuStrip cmuUserMgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEDIAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUsers;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblUserID;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemDetailUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemImportUsers;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelectUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdateUser;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbUserID;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmuUserMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelectUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDetailUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpdateUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemImportUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbUserID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUserID = new DevComponents.DotNetBar.LabelX();
            this.dgvUsers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEDIAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuUserMgr.SuspendLayout();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // cmuUserMgr
            // 
            this.cmuUserMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelectUser,
            this.menuItemDetailUser,
            this.toolStripSeparator,
            this.menuItemNewUser,
            this.menuItemUpdateUser,
            this.menuItemDeleteUser,
            this.menuItemImportUsers});
            this.cmuUserMgr.Name = "contextMenuUserMgr";
            this.cmuUserMgr.Size = new System.Drawing.Size(123, 142);
            // 
            // menuItemSelectUser
            // 
            this.menuItemSelectUser.Name = "menuItemSelectUser";
            this.menuItemSelectUser.Size = new System.Drawing.Size(122, 22);
            this.menuItemSelectUser.Text = "选定用户";
            this.menuItemSelectUser.Click += new System.EventHandler(this.SelectUser);
            // 
            // menuItemDetailUser
            // 
            this.menuItemDetailUser.Name = "menuItemDetailUser";
            this.menuItemDetailUser.Size = new System.Drawing.Size(122, 22);
            this.menuItemDetailUser.Text = "详细信息";
            this.menuItemDetailUser.Click += new System.EventHandler(this.DetailUser);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(119, 6);
            // 
            // menuItemNewUser
            // 
            this.menuItemNewUser.Name = "menuItemNewUser";
            this.menuItemNewUser.Size = new System.Drawing.Size(122, 22);
            this.menuItemNewUser.Text = "新建用户";
            this.menuItemNewUser.Click += new System.EventHandler(this.NewUser);
            // 
            // menuItemUpdateUser
            // 
            this.menuItemUpdateUser.Name = "menuItemUpdateUser";
            this.menuItemUpdateUser.Size = new System.Drawing.Size(122, 22);
            this.menuItemUpdateUser.Text = "更新用户";
            this.menuItemUpdateUser.Click += new System.EventHandler(this.UpdateUser);
            // 
            // menuItemDeleteUser
            // 
            this.menuItemDeleteUser.Name = "menuItemDeleteUser";
            this.menuItemDeleteUser.Size = new System.Drawing.Size(122, 22);
            this.menuItemDeleteUser.Text = "删除用户";
            this.menuItemDeleteUser.Click += new System.EventHandler(this.DeleteUser);
            // 
            // menuItemImportUsers
            // 
            this.menuItemImportUsers.Name = "menuItemImportUsers";
            this.menuItemImportUsers.Size = new System.Drawing.Size(122, 22);
            this.menuItemImportUsers.Text = "导入用户";
            this.menuItemImportUsers.Click += new System.EventHandler(this.ImportUsers);
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbUserID);
            this.panelQuery.Controls.Add(this.lblUserID);
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
            this.lblCount.Location = new System.Drawing.Point(242, 4);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(497, 23);
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
            this.btnQuery.Click += new System.EventHandler(this.QueryUsers);
            // 
            // tbUserID
            // 
            // 
            // 
            // 
            this.tbUserID.Border.Class = "TextBoxBorder";
            this.tbUserID.Location = new System.Drawing.Point(55, 7);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(100, 20);
            this.tbUserID.TabIndex = 1;
            // 
            // lblUserID
            // 
            // 
            // 
            // 
            this.lblUserID.BackgroundStyle.Class = "";
            this.lblUserID.Location = new System.Drawing.Point(4, 7);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(44, 23);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "用户ID";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserID,
            this.colName,
            this.colEDIAccount,
            this.colRole,
            this.colPhone,
            this.colTelphone,
            this.colEmail,
            this.colMSN,
            this.colLoginDate,
            this.colPassword});
            this.dgvUsers.ContextMenuStrip = this.cmuUserMgr;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            // 
            // UserIDColumn
            // 
            this.colUserID.DataPropertyName = "UserID";
            this.colUserID.HeaderText = "用户ID";
            this.colUserID.Name = "UserIDColumn";
            this.colUserID.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "姓名";
            this.colName.Name = "NameColumn";
            this.colName.ReadOnly = true;
            // 
            // EDIAccountColumn
            // 
            this.colEDIAccount.DataPropertyName = "EDIAccount";
            this.colEDIAccount.HeaderText = "EDI帐号";
            this.colEDIAccount.Name = "EDIAccountColumn";
            this.colEDIAccount.ReadOnly = true;
            // 
            // RoleColumn
            // 
            this.colRole.DataPropertyName = "Role";
            this.colRole.HeaderText = "角色";
            this.colRole.Name = "RoleColumn";
            this.colRole.ReadOnly = true;
            // 
            // PhoneColumn
            // 
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "电话";
            this.colPhone.Name = "PhoneColumn";
            this.colPhone.ReadOnly = true;
            // 
            // TelphoneColumn
            // 
            this.colTelphone.DataPropertyName = "Telphone";
            this.colTelphone.HeaderText = "手机";
            this.colTelphone.Name = "TelphoneColumn";
            this.colTelphone.ReadOnly = true;
            // 
            // EmailColumn
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "EmailColumn";
            this.colEmail.ReadOnly = true;
            // 
            // MSNColumn
            // 
            this.colMSN.DataPropertyName = "MSN";
            this.colMSN.HeaderText = "MSN";
            this.colMSN.Name = "MSNColumn";
            this.colMSN.ReadOnly = true;
            // 
            // LoginDateColumn
            // 
            this.colLoginDate.DataPropertyName = "LoginDate";
            this.colLoginDate.HeaderText = "最后登录日期";
            this.colLoginDate.Name = "LoginDateColumn";
            this.colLoginDate.ReadOnly = true;
            // 
            // PasswordColumn
            // 
            this.colPassword.DataPropertyName = "Password";
            this.colPassword.HeaderText = "密码";
            this.colPassword.Name = "PasswordColumn";
            this.colPassword.ReadOnly = true;
            this.colPassword.Visible = false;
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
    }
}

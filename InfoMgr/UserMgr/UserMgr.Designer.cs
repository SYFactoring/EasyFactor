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
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUsers;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblUserID;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemDetailUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewUser;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelectUser;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmuUserMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelectUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDetailUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbUserID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblUserID = new DevComponents.DotNetBar.LabelX();
            this.dgvUsers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.UserIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIAccountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelphoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuItemDeleteUser});
            this.cmuUserMgr.Name = "contextMenuUserMgr";
            this.cmuUserMgr.Size = new System.Drawing.Size(153, 120);
            // 
            // menuItemSelectUser
            // 
            this.menuItemSelectUser.Name = "menuItemSelectUser";
            this.menuItemSelectUser.Size = new System.Drawing.Size(152, 22);
            this.menuItemSelectUser.Text = "选定用户";
            this.menuItemSelectUser.Click += new System.EventHandler(this.SelectUser);
            // 
            // menuItemDetailUser
            // 
            this.menuItemDetailUser.Name = "menuItemDetailUser";
            this.menuItemDetailUser.Size = new System.Drawing.Size(152, 22);
            this.menuItemDetailUser.Text = "详细信息";
            this.menuItemDetailUser.Click += new System.EventHandler(this.DetailUser);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // menuItemNewUser
            // 
            this.menuItemNewUser.Name = "menuItemNewUser";
            this.menuItemNewUser.Size = new System.Drawing.Size(152, 22);
            this.menuItemNewUser.Text = "新建用户";
            this.menuItemNewUser.Click += new System.EventHandler(this.NewUser);
            // 
            // menuItemDeleteUser
            // 
            this.menuItemDeleteUser.Name = "menuItemDeleteUser";
            this.menuItemDeleteUser.Size = new System.Drawing.Size(152, 22);
            this.menuItemDeleteUser.Text = "删除用户";
            this.menuItemDeleteUser.Click += new System.EventHandler(this.DeleteUser);
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
            this.panelQuery.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserIDColumn,
            this.NameColumn,
            this.EDIAccountColumn,
            this.RoleColumn,
            this.PhoneColumn,
            this.TelphoneColumn,
            this.EmailColumn,
            this.LoginDateColumn});
            this.dgvUsers.ContextMenuStrip = this.cmuUserMgr;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvUsers.Location = new System.Drawing.Point(0, 33);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(800, 567);
            this.dgvUsers.TabIndex = 1;
            this.dgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvUsers.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvUsers_RowPostPaint);
            // 
            // UserIDColumn
            // 
            this.UserIDColumn.DataPropertyName = "UserID";
            this.UserIDColumn.HeaderText = "用户ID";
            this.UserIDColumn.Name = "UserIDColumn";
            this.UserIDColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "Name";
            this.NameColumn.HeaderText = "姓名";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
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
            // PhoneColumn
            // 
            this.PhoneColumn.DataPropertyName = "Phone";
            this.PhoneColumn.HeaderText = "电话";
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.ReadOnly = true;
            // 
            // TelphoneColumn
            // 
            this.TelphoneColumn.DataPropertyName = "Telphone";
            this.TelphoneColumn.HeaderText = "手机";
            this.TelphoneColumn.Name = "TelphoneColumn";
            this.TelphoneColumn.ReadOnly = true;
            // 
            // EmailColumn
            // 
            this.EmailColumn.DataPropertyName = "Email";
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            // 
            // LoginDateColumn
            // 
            this.LoginDateColumn.DataPropertyName = "LoginDate";
            this.LoginDateColumn.HeaderText = "最后登录日期";
            this.LoginDateColumn.Name = "LoginDateColumn";
            this.LoginDateColumn.ReadOnly = true;
            // 
            // UserMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.cmuUserMgr;
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "UserMgr";
            this.Size = new System.Drawing.Size(800, 600);
            this.cmuUserMgr.ResumeLayout(false);
            this.panelQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDIAccountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelphoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginDateColumn;
    }
}

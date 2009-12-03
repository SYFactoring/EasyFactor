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
    public partial class UserMgrUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource userMgrBindingSource;
        private System.Windows.Forms.ToolStrip tsUserMgr;
        private System.Windows.Forms.ToolStripLabel lblKeyword;
        private System.Windows.Forms.ToolStripTextBox tbKeyword;
        private System.Windows.Forms.ToolStripButton queryBtn;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn msnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDateColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuUserMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripLabel lblCount;

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
            this.userMgrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsUserMgr = new System.Windows.Forms.ToolStrip();
            this.lblKeyword = new System.Windows.Forms.ToolStripLabel();
            this.tbKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.queryBtn = new System.Windows.Forms.ToolStripButton();
            this.dgvUser = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.userIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuUserMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCount = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.userMgrBindingSource)).BeginInit();
            this.tsUserMgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.contextMenuUserMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // userMgrBindingSource
            // 
            this.userMgrBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.User);
            // 
            // tsUserMgr
            // 
            this.tsUserMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblKeyword,
            this.tbKeyword,
            this.queryBtn,
            this.lblCount});
            this.tsUserMgr.Location = new System.Drawing.Point(0, 0);
            this.tsUserMgr.Name = "tsUserMgr";
            this.tsUserMgr.Size = new System.Drawing.Size(800, 25);
            this.tsUserMgr.TabIndex = 3;
            this.tsUserMgr.Text = "toolStrip1";
            // 
            // lblKeyword
            // 
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(43, 22);
            this.lblKeyword.Text = "关键字";
            // 
            // tbKeyword
            // 
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(100, 25);
            // 
            // queryBtn
            // 
            this.queryBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.queryBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.queryBtn.Name = "queryBtn";
            this.queryBtn.Size = new System.Drawing.Size(35, 22);
            this.queryBtn.Text = "查询";
            this.queryBtn.Click += new System.EventHandler(this.Query);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToOrderColumns = true;
            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDColumn,
            this.userNameColumn,
            this.passwordColumn,
            this.roleColumn,
            this.phoneColumn,
            this.telephoneColumn,
            this.emailColumn,
            this.msnColumn,
            this.loginDateColumn});
            this.dgvUser.ContextMenuStrip = this.contextMenuUserMgr;
            this.dgvUser.DataSource = this.userMgrBindingSource;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(0, 25);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(800, 575);
            this.dgvUser.TabIndex = 4;
            this.dgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            // 
            // userIDColumn
            // 
            this.userIDColumn.DataPropertyName = "UserID";
            this.userIDColumn.HeaderText = "登录ID";
            this.userIDColumn.Name = "userIDColumn";
            this.userIDColumn.ReadOnly = true;
            // 
            // userNameColumn
            // 
            this.userNameColumn.DataPropertyName = "UserName";
            this.userNameColumn.HeaderText = "用户名";
            this.userNameColumn.Name = "userNameColumn";
            this.userNameColumn.ReadOnly = true;
            // 
            // passwordColumn
            // 
            this.passwordColumn.DataPropertyName = "Password";
            this.passwordColumn.HeaderText = "Password";
            this.passwordColumn.Name = "passwordColumn";
            this.passwordColumn.ReadOnly = true;
            this.passwordColumn.Visible = false;
            // 
            // RoleColumn
            // 
            this.roleColumn.DataPropertyName = "Role";
            this.roleColumn.HeaderText = "角色";
            this.roleColumn.Name = "RoleColumn";
            this.roleColumn.ReadOnly = true;
            // 
            // phoneColumn
            // 
            this.phoneColumn.DataPropertyName = "Phone";
            this.phoneColumn.HeaderText = "电话";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.ReadOnly = true;
            // 
            // telephoneColumn
            // 
            this.telephoneColumn.DataPropertyName = "Telphone";
            this.telephoneColumn.HeaderText = "手机";
            this.telephoneColumn.Name = "telephoneColumn";
            this.telephoneColumn.ReadOnly = true;
            // 
            // emailColumn
            // 
            this.emailColumn.DataPropertyName = "Email";
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.ReadOnly = true;
            // 
            // msnColumn
            // 
            this.msnColumn.DataPropertyName = "MSN";
            this.msnColumn.HeaderText = "MSN";
            this.msnColumn.Name = "msnColumn";
            this.msnColumn.ReadOnly = true;
            // 
            // loginDateColumn
            // 
            this.loginDateColumn.DataPropertyName = "LoginDate";
            this.loginDateColumn.HeaderText = "最后登录时间";
            this.loginDateColumn.Name = "loginDateColumn";
            this.loginDateColumn.ReadOnly = true;
            // 
            // contextMenuUserMgr
            // 
            this.contextMenuUserMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSelect,
            this.menuItemDetail,
            this.toolStripSeparator,
            this.menuItemEdit});
            this.contextMenuUserMgr.Name = "contextMenuUserMgr";
            this.contextMenuUserMgr.Size = new System.Drawing.Size(99, 76);
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
            // lblCount
            // 
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 22);
            // 
            // UserMgrUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextMenuUserMgr;
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.tsUserMgr);
            this.Name = "UserMgrUI";
            this.Size = new System.Drawing.Size(800, 600);
            ((System.ComponentModel.ISupportInitialize)(this.userMgrBindingSource)).EndInit();
            this.tsUserMgr.ResumeLayout(false);
            this.tsUserMgr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.contextMenuUserMgr.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

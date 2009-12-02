//-----------------------------------------------------------------------
// <copyright file="UserDetailUI.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.UserMgr
{
    /// <summary>
    /// User Detail User Interface Design
    /// </summary>
    public partial class UserDetailUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker loginDateDateTimePicker;
        private System.Windows.Forms.TextBox msnTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ComboBox roleCombBox;
        private System.Windows.Forms.TextBox telphoneTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.ToolStrip tsUserDetail;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label loginDateLabel;
            System.Windows.Forms.Label mSNLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label roleLabel;
            System.Windows.Forms.Label telphoneLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userNameLabel;
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.loginDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.msnTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.roleCombBox = new System.Windows.Forms.ComboBox();
            this.telphoneTextBox = new System.Windows.Forms.TextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.tsUserDetail = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            emailLabel = new System.Windows.Forms.Label();
            loginDateLabel = new System.Windows.Forms.Label();
            mSNLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            telphoneLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.tsUserDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(13, 134);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email";
            // 
            // loginDateLabel
            // 
            loginDateLabel.AutoSize = true;
            loginDateLabel.Location = new System.Drawing.Point(13, 234);
            loginDateLabel.Name = "loginDateLabel";
            loginDateLabel.Size = new System.Drawing.Size(55, 13);
            loginDateLabel.TabIndex = 3;
            loginDateLabel.Text = "登录时间";
            // 
            // mSNLabel
            // 
            mSNLabel.AutoSize = true;
            mSNLabel.Location = new System.Drawing.Point(13, 209);
            mSNLabel.Name = "mSNLabel";
            mSNLabel.Size = new System.Drawing.Size(34, 13);
            mSNLabel.TabIndex = 5;
            mSNLabel.Text = "MSN:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(13, 84);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(31, 13);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "密码";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(13, 159);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(31, 13);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "电话";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(13, 109);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(31, 13);
            roleLabel.TabIndex = 11;
            roleLabel.Text = "角色";
            // 
            // telphoneLabel
            // 
            telphoneLabel.AutoSize = true;
            telphoneLabel.Location = new System.Drawing.Point(13, 184);
            telphoneLabel.Name = "telphoneLabel";
            telphoneLabel.Size = new System.Drawing.Size(31, 13);
            telphoneLabel.TabIndex = 13;
            telphoneLabel.Text = "手机";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(13, 35);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(42, 13);
            userIDLabel.TabIndex = 15;
            userIDLabel.Text = "登录ID";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(13, 59);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(43, 13);
            userNameLabel.TabIndex = 17;
            userNameLabel.Text = "用户名";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.User);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(82, 129);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(125, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // loginDateDateTimePicker
            // 
            this.loginDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "LoginDate", true));
            this.loginDateDateTimePicker.Enabled = false;
            this.loginDateDateTimePicker.Location = new System.Drawing.Point(82, 229);
            this.loginDateDateTimePicker.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.loginDateDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.loginDateDateTimePicker.Name = "loginDateDateTimePicker";
            this.loginDateDateTimePicker.Size = new System.Drawing.Size(125, 20);
            this.loginDateDateTimePicker.TabIndex = 8;
            // 
            // mSNTextBox
            // 
            this.msnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "MSN", true));
            this.msnTextBox.Location = new System.Drawing.Point(82, 204);
            this.msnTextBox.Name = "mSNTextBox";
            this.msnTextBox.Size = new System.Drawing.Size(125, 20);
            this.msnTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(82, 79);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(125, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(82, 154);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(125, 20);
            this.phoneTextBox.TabIndex = 5;
            // 
            // roleCombBox
            // 
            this.roleCombBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Role", true));
            this.roleCombBox.Items.AddRange(new object[] {
            "操作员",
            "审核员",
            "管理员"});
            this.roleCombBox.Location = new System.Drawing.Point(82, 104);
            this.roleCombBox.Name = "roleCombBox";
            this.roleCombBox.Size = new System.Drawing.Size(125, 21);
            this.roleCombBox.TabIndex = 3;
            // 
            // telphoneTextBox
            // 
            this.telphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Telphone", true));
            this.telphoneTextBox.Location = new System.Drawing.Point(82, 179);
            this.telphoneTextBox.Name = "telphoneTextBox";
            this.telphoneTextBox.Size = new System.Drawing.Size(125, 20);
            this.telphoneTextBox.TabIndex = 6;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(82, 29);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(125, 20);
            this.userIDTextBox.TabIndex = 0;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.userNameTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.userNameTextBox.Location = new System.Drawing.Point(82, 54);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(125, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // tsUserDetail
            // 
            this.tsUserDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCancel});
            this.tsUserDetail.Location = new System.Drawing.Point(0, 0);
            this.tsUserDetail.Name = "tsUserDetail";
            this.tsUserDetail.Size = new System.Drawing.Size(222, 25);
            this.tsUserDetail.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(35, 22);
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // btnCancel
            // 
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(35, 22);
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // UserDetailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(222, 261);
            this.Controls.Add(this.tsUserDetail);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(loginDateLabel);
            this.Controls.Add(this.loginDateDateTimePicker);
            this.Controls.Add(mSNLabel);
            this.Controls.Add(this.msnTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleCombBox);
            this.Controls.Add(telphoneLabel);
            this.Controls.Add(this.telphoneTextBox);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "UserDetailUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tsUserDetail.ResumeLayout(false);
            this.tsUserDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
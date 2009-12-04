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
    public partial class UserDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.MaskedTextBox emailTextBox;
        private System.Windows.Forms.MaskedTextBox loginDate;
        private System.Windows.Forms.MaskedTextBox msnTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.MaskedTextBox phoneTextBox;
        private System.Windows.Forms.MaskedTextBox telphoneTextBox;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;

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
            System.Windows.Forms.Label telphoneLabel;
            System.Windows.Forms.Label userIDLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label eDIAccountLabel;
            System.Windows.Forms.Label roleLabel;
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.MaskedTextBox();
            this.loginDate = new System.Windows.Forms.MaskedTextBox();
            this.msnTextBox = new System.Windows.Forms.MaskedTextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telphoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.eDIAccountTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            emailLabel = new System.Windows.Forms.Label();
            loginDateLabel = new System.Windows.Forms.Label();
            mSNLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            telphoneLabel = new System.Windows.Forms.Label();
            userIDLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            eDIAccountLabel = new System.Windows.Forms.Label();
            roleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(13, 151);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email";
            // 
            // loginDateLabel
            // 
            loginDateLabel.AutoSize = true;
            loginDateLabel.Location = new System.Drawing.Point(13, 251);
            loginDateLabel.Name = "loginDateLabel";
            loginDateLabel.Size = new System.Drawing.Size(55, 13);
            loginDateLabel.TabIndex = 3;
            loginDateLabel.Text = "登录时间";
            // 
            // mSNLabel
            // 
            mSNLabel.AutoSize = true;
            mSNLabel.Location = new System.Drawing.Point(13, 226);
            mSNLabel.Name = "mSNLabel";
            mSNLabel.Size = new System.Drawing.Size(34, 13);
            mSNLabel.TabIndex = 5;
            mSNLabel.Text = "MSN:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(13, 101);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(31, 13);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "密码";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(13, 176);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(31, 13);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "电话";
            // 
            // telphoneLabel
            // 
            telphoneLabel.AutoSize = true;
            telphoneLabel.Location = new System.Drawing.Point(13, 201);
            telphoneLabel.Name = "telphoneLabel";
            telphoneLabel.Size = new System.Drawing.Size(31, 13);
            telphoneLabel.TabIndex = 13;
            telphoneLabel.Text = "手机";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.Location = new System.Drawing.Point(13, 12);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(42, 13);
            userIDLabel.TabIndex = 15;
            userIDLabel.Text = "登录ID";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(13, 36);
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
            this.emailTextBox.Location = new System.Drawing.Point(82, 146);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(154, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // loginDate
            // 
            this.loginDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LoginDate", true));
            this.loginDate.Location = new System.Drawing.Point(82, 246);
            this.loginDate.Mask = "0000/90/90/ 90:00";
            this.loginDate.Name = "loginDate";
            this.loginDate.PromptChar = ' ';
            this.loginDate.ReadOnly = true;
            this.loginDate.Size = new System.Drawing.Size(154, 20);
            this.loginDate.TabIndex = 8;
            this.loginDate.ValidatingType = typeof(System.DateTime);
            // 
            // msnTextBox
            // 
            this.msnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "MSN", true));
            this.msnTextBox.Location = new System.Drawing.Point(82, 221);
            this.msnTextBox.Name = "msnTextBox";
            this.msnTextBox.Size = new System.Drawing.Size(154, 20);
            this.msnTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(82, 96);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(154, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(82, 171);
            this.phoneTextBox.Mask = "999-00000000";
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PromptChar = ' ';
            this.phoneTextBox.RejectInputOnFirstFailure = true;
            this.phoneTextBox.Size = new System.Drawing.Size(154, 20);
            this.phoneTextBox.TabIndex = 5;
            // 
            // telphoneTextBox
            // 
            this.telphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Telphone", true));
            this.telphoneTextBox.Location = new System.Drawing.Point(82, 196);
            this.telphoneTextBox.Mask = "00000000000";
            this.telphoneTextBox.Name = "telphoneTextBox";
            this.telphoneTextBox.PromptChar = ' ';
            this.telphoneTextBox.Size = new System.Drawing.Size(154, 20);
            this.telphoneTextBox.TabIndex = 6;
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(82, 6);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(154, 20);
            this.userIDTextBox.TabIndex = 0;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserName", true));
            this.userNameTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.userNameTextBox.Location = new System.Drawing.Point(82, 31);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(83, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.Save);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(165, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // eDIAccountLabel
            // 
            eDIAccountLabel.AutoSize = true;
            eDIAccountLabel.Location = new System.Drawing.Point(13, 65);
            eDIAccountLabel.Name = "eDIAccountLabel";
            eDIAccountLabel.Size = new System.Drawing.Size(49, 13);
            eDIAccountLabel.TabIndex = 20;
            eDIAccountLabel.Text = "EDI帐号";
            // 
            // eDIAccountTextBox
            // 
            this.eDIAccountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "EDIAccount", true));
            this.eDIAccountTextBox.Location = new System.Drawing.Point(87, 62);
            this.eDIAccountTextBox.Name = "eDIAccountTextBox";
            this.eDIAccountTextBox.Size = new System.Drawing.Size(149, 20);
            this.eDIAccountTextBox.TabIndex = 21;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new System.Drawing.Point(15, 125);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(31, 13);
            roleLabel.TabIndex = 21;
            roleLabel.Text = "角色";
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Role", true));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "操作员",
            "审核员",
            "管理员"});
            this.roleComboBox.Location = new System.Drawing.Point(82, 122);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(121, 21);
            this.roleComboBox.TabIndex = 22;
            // 
            // UserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(262, 322);
            this.Controls.Add(roleLabel);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(eDIAccountLabel);
            this.Controls.Add(this.eDIAccountTextBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(loginDateLabel);
            this.Controls.Add(this.loginDate);
            this.Controls.Add(mSNLabel);
            this.Controls.Add(this.msnTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(telphoneLabel);
            this.Controls.Add(this.telphoneTextBox);
            this.Controls.Add(userIDLabel);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "UserDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.TextBox eDIAccountTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;


    }
}
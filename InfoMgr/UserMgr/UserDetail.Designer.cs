//-----------------------------------------------------------------------
// <copyright file="UserDetailUI.Designer.cs" company="Yiming Liu@Fudan">
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
        #region Fields (19)

        private DevComponents.DotNetBar.ButtonX btnUserClose;
        private DevComponents.DotNetBar.ButtonX btnUserSave;
        private DevComponents.DotNetBar.ButtonX btnUserUpdate;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX eDIAccountTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX emailTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelUser;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.TextBoxX loginDate;
        private DevComponents.DotNetBar.Controls.TextBoxX msnTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX nameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX passwordTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX phoneTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx roleComboBox;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX telphoneTextBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX userIDTextBox;

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



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.LabelX emailLabel;
            DevComponents.DotNetBar.LabelX loginDateLabel;
            DevComponents.DotNetBar.LabelX mSNLabel;
            DevComponents.DotNetBar.LabelX passwordLabel;
            DevComponents.DotNetBar.LabelX phoneLabel;
            DevComponents.DotNetBar.LabelX telphoneLabel;
            DevComponents.DotNetBar.LabelX userIDLabel;
            DevComponents.DotNetBar.LabelX userNameLabel;
            DevComponents.DotNetBar.LabelX eDIAccountLabel;
            DevComponents.DotNetBar.LabelX roleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetail));
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.loginDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.msnTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.passwordTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.phoneTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.telphoneTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.userIDTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.nameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnUserSave = new DevComponents.DotNetBar.ButtonX();
            this.btnUserClose = new DevComponents.DotNetBar.ButtonX();
            this.eDIAccountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.roleComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupPanelUser = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnUserUpdate = new DevComponents.DotNetBar.ButtonX();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            emailLabel = new DevComponents.DotNetBar.LabelX();
            loginDateLabel = new DevComponents.DotNetBar.LabelX();
            mSNLabel = new DevComponents.DotNetBar.LabelX();
            passwordLabel = new DevComponents.DotNetBar.LabelX();
            phoneLabel = new DevComponents.DotNetBar.LabelX();
            telphoneLabel = new DevComponents.DotNetBar.LabelX();
            userIDLabel = new DevComponents.DotNetBar.LabelX();
            userNameLabel = new DevComponents.DotNetBar.LabelX();
            eDIAccountLabel = new DevComponents.DotNetBar.LabelX();
            roleLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupPanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            emailLabel.BackgroundStyle.Class = "";
            emailLabel.Location = new System.Drawing.Point(44, 147);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 16);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email";
            // 
            // loginDateLabel
            // 
            loginDateLabel.AutoSize = true;
            loginDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            loginDateLabel.BackgroundStyle.Class = "";
            loginDateLabel.Location = new System.Drawing.Point(23, 247);
            loginDateLabel.Name = "loginDateLabel";
            loginDateLabel.Size = new System.Drawing.Size(56, 16);
            loginDateLabel.TabIndex = 3;
            loginDateLabel.Text = "登录时间";
            // 
            // mSNLabel
            // 
            mSNLabel.AutoSize = true;
            mSNLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            mSNLabel.BackgroundStyle.Class = "";
            mSNLabel.Location = new System.Drawing.Point(45, 222);
            mSNLabel.Name = "mSNLabel";
            mSNLabel.Size = new System.Drawing.Size(34, 16);
            mSNLabel.TabIndex = 5;
            mSNLabel.Text = "MSN:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            passwordLabel.BackgroundStyle.Class = "";
            passwordLabel.Location = new System.Drawing.Point(48, 97);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(31, 16);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "密码";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            phoneLabel.BackgroundStyle.Class = "";
            phoneLabel.Location = new System.Drawing.Point(48, 172);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(31, 16);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "电话";
            // 
            // telphoneLabel
            // 
            telphoneLabel.AutoSize = true;
            telphoneLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            telphoneLabel.BackgroundStyle.Class = "";
            telphoneLabel.Location = new System.Drawing.Point(48, 197);
            telphoneLabel.Name = "telphoneLabel";
            telphoneLabel.Size = new System.Drawing.Size(31, 16);
            telphoneLabel.TabIndex = 13;
            telphoneLabel.Text = "手机";
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            userIDLabel.BackgroundStyle.Class = "";
            userIDLabel.Location = new System.Drawing.Point(37, 7);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(42, 16);
            userIDLabel.TabIndex = 15;
            userIDLabel.Text = "登录ID";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            userNameLabel.BackgroundStyle.Class = "";
            userNameLabel.Location = new System.Drawing.Point(35, 32);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(44, 16);
            userNameLabel.TabIndex = 17;
            userNameLabel.Text = "用户名";
            // 
            // eDIAccountLabel
            // 
            eDIAccountLabel.AutoSize = true;
            eDIAccountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            eDIAccountLabel.BackgroundStyle.Class = "";
            eDIAccountLabel.Location = new System.Drawing.Point(29, 63);
            eDIAccountLabel.Name = "eDIAccountLabel";
            eDIAccountLabel.Size = new System.Drawing.Size(50, 16);
            eDIAccountLabel.TabIndex = 20;
            eDIAccountLabel.Text = "EDI帐号";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            roleLabel.BackgroundStyle.Class = "";
            roleLabel.Location = new System.Drawing.Point(48, 122);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(31, 16);
            roleLabel.TabIndex = 21;
            roleLabel.Text = "角色";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.User);
            // 
            // emailTextBox
            // 
            // 
            // 
            // 
            this.emailTextBox.Border.Class = "TextBoxBorder";
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(92, 146);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(154, 20);
            this.emailTextBox.TabIndex = 4;
            // 
            // loginDate
            // 
            // 
            // 
            // 
            this.loginDate.Border.Class = "TextBoxBorder";
            this.loginDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "LoginDate", true));
            this.loginDate.Location = new System.Drawing.Point(92, 246);
            this.loginDate.Name = "loginDate";
            this.loginDate.ReadOnly = true;
            this.loginDate.Size = new System.Drawing.Size(154, 20);
            this.loginDate.TabIndex = 8;
            // 
            // msnTextBox
            // 
            // 
            // 
            // 
            this.msnTextBox.Border.Class = "TextBoxBorder";
            this.msnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "MSN", true));
            this.msnTextBox.Location = new System.Drawing.Point(92, 221);
            this.msnTextBox.Name = "msnTextBox";
            this.msnTextBox.Size = new System.Drawing.Size(154, 20);
            this.msnTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.Border.Class = "TextBoxBorder";
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(92, 96);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(154, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            // 
            // 
            // 
            this.phoneTextBox.Border.Class = "TextBoxBorder";
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(92, 171);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(154, 20);
            this.phoneTextBox.TabIndex = 5;
            // 
            // telphoneTextBox
            // 
            // 
            // 
            // 
            this.telphoneTextBox.Border.Class = "TextBoxBorder";
            this.telphoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Telphone", true));
            this.telphoneTextBox.Location = new System.Drawing.Point(92, 196);
            this.telphoneTextBox.Name = "telphoneTextBox";
            this.telphoneTextBox.Size = new System.Drawing.Size(154, 20);
            this.telphoneTextBox.TabIndex = 6;
            // 
            // userIDTextBox
            // 
            // 
            // 
            // 
            this.userIDTextBox.Border.Class = "TextBoxBorder";
            this.userIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "UserID", true));
            this.userIDTextBox.Location = new System.Drawing.Point(92, 6);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(154, 20);
            this.userIDTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.Border.Class = "TextBoxBorder";
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.nameTextBox.Location = new System.Drawing.Point(92, 31);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(154, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // btnUserSave
            // 
            this.btnUserSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUserSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUserSave.Location = new System.Drawing.Point(117, 288);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(75, 23);
            this.btnUserSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUserSave.TabIndex = 18;
            this.btnUserSave.Text = "保存";
            this.btnUserSave.Click += new System.EventHandler(this.UserSave);
            // 
            // btnUserClose
            // 
            this.btnUserClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUserClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUserClose.Location = new System.Drawing.Point(199, 288);
            this.btnUserClose.Name = "btnUserClose";
            this.btnUserClose.Size = new System.Drawing.Size(75, 23);
            this.btnUserClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUserClose.TabIndex = 19;
            this.btnUserClose.Text = "关闭";
            this.btnUserClose.Click += new System.EventHandler(this.UserClose);
            // 
            // eDIAccountTextBox
            // 
            // 
            // 
            // 
            this.eDIAccountTextBox.Border.Class = "TextBoxBorder";
            this.eDIAccountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "EDIAccount", true));
            this.eDIAccountTextBox.Location = new System.Drawing.Point(94, 62);
            this.eDIAccountTextBox.Name = "eDIAccountTextBox";
            this.eDIAccountTextBox.Size = new System.Drawing.Size(152, 20);
            this.eDIAccountTextBox.TabIndex = 21;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Role", true));
            this.roleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "操作员",
            "审核员",
            "管理员"});
            this.roleComboBox.Location = new System.Drawing.Point(92, 122);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(154, 21);
            this.roleComboBox.TabIndex = 22;
            // 
            // groupPanelUser
            // 
            this.groupPanelUser.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelUser.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelUser.Controls.Add(userIDLabel);
            this.groupPanelUser.Controls.Add(roleLabel);
            this.groupPanelUser.Controls.Add(this.nameTextBox);
            this.groupPanelUser.Controls.Add(this.roleComboBox);
            this.groupPanelUser.Controls.Add(userNameLabel);
            this.groupPanelUser.Controls.Add(eDIAccountLabel);
            this.groupPanelUser.Controls.Add(this.userIDTextBox);
            this.groupPanelUser.Controls.Add(this.eDIAccountTextBox);
            this.groupPanelUser.Controls.Add(this.telphoneTextBox);
            this.groupPanelUser.Controls.Add(telphoneLabel);
            this.groupPanelUser.Controls.Add(this.phoneTextBox);
            this.groupPanelUser.Controls.Add(emailLabel);
            this.groupPanelUser.Controls.Add(phoneLabel);
            this.groupPanelUser.Controls.Add(this.emailTextBox);
            this.groupPanelUser.Controls.Add(this.passwordTextBox);
            this.groupPanelUser.Controls.Add(loginDateLabel);
            this.groupPanelUser.Controls.Add(passwordLabel);
            this.groupPanelUser.Controls.Add(this.loginDate);
            this.groupPanelUser.Controls.Add(this.msnTextBox);
            this.groupPanelUser.Controls.Add(mSNLabel);
            this.groupPanelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelUser.Location = new System.Drawing.Point(0, 0);
            this.groupPanelUser.Name = "groupPanelUser";
            this.groupPanelUser.Size = new System.Drawing.Size(277, 279);
            // 
            // 
            // 
            this.groupPanelUser.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelUser.Style.BackColorGradientAngle = 90;
            this.groupPanelUser.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelUser.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelUser.Style.BorderBottomWidth = 1;
            this.groupPanelUser.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelUser.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelUser.Style.BorderLeftWidth = 1;
            this.groupPanelUser.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelUser.Style.BorderRightWidth = 1;
            this.groupPanelUser.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelUser.Style.BorderTopWidth = 1;
            this.groupPanelUser.Style.Class = "";
            this.groupPanelUser.Style.CornerDiameter = 4;
            this.groupPanelUser.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelUser.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelUser.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelUser.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelUser.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelUser.StyleMouseOver.Class = "";
            this.groupPanelUser.TabIndex = 23;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUserUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUserUpdate.Location = new System.Drawing.Point(36, 288);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUserUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUserUpdate.TabIndex = 24;
            this.btnUserUpdate.Text = "更新";
            this.btnUserUpdate.Click += new System.EventHandler(this.UserUpdate);
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // highlighter
            // 
            this.highlighter.ContainerControl = this;
            // 
            // UserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(277, 316);
            this.Controls.Add(this.btnUserUpdate);
            this.Controls.Add(this.groupPanelUser);
            this.Controls.Add(this.btnUserClose);
            this.Controls.Add(this.btnUserSave);
            this.DoubleBuffered = true;
            this.Name = "UserDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户详细信息";
            this.Leave += new System.EventHandler(this.UserDetail_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupPanelUser.ResumeLayout(false);
            this.groupPanelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
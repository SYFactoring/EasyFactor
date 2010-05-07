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
		#region?Fields?(30)?

        private DevComponents.DotNetBar.ButtonX btnPermissionUpdate;
        private DevComponents.DotNetBar.ButtonX btnSavePermission;
        private DevComponents.DotNetBar.ButtonX btnUserSave;
        private DevComponents.DotNetBar.ButtonX btnUserUpdate;
        private System.Windows.Forms.CheckedListBox cbPermission;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX eDIAccountTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX emailTextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelUser;
        private DevComponents.DotNetBar.Controls.TextBoxX loginDate;
        private DevComponents.DotNetBar.Controls.TextBoxX msnTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX nameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX password2TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX passwordTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX phoneTextBox;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx roleComboBox;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabItem tabItemPermission;
        private DevComponents.DotNetBar.TabItem tabItemUser;
        private DevComponents.DotNetBar.TabControlPanel tabPanelPermission;
        private DevComponents.DotNetBar.TabControlPanel tabPanelUser;
        private DevComponents.DotNetBar.Controls.TextBoxX telphoneTextBox;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ErrorProvider userErrorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter userHighlighter;
        private DevComponents.DotNetBar.Controls.TextBoxX userIDTextBox;
        private DevComponents.DotNetBar.Validator.SuperValidator userValidator;

		#endregion?Fields?

		#region?Methods?(1)?

		//?Protected?Methods?(1)?

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

            if (this.context != null)
            {
                this.context.Dispose();
            }

            base.Dispose(disposing);
        }

		#endregion?Methods?



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.LabelX userIDLabel;
            DevComponents.DotNetBar.LabelX roleLabel;
            DevComponents.DotNetBar.LabelX userNameLabel;
            DevComponents.DotNetBar.LabelX eDIAccountLabel;
            DevComponents.DotNetBar.LabelX telphoneLabel;
            DevComponents.DotNetBar.LabelX emailLabel;
            DevComponents.DotNetBar.LabelX phoneLabel;
            DevComponents.DotNetBar.LabelX loginDateLabel;
            DevComponents.DotNetBar.LabelX passwordLabel;
            DevComponents.DotNetBar.LabelX mSNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDetail));
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.userErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.userHighlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.password2TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.passwordTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.nameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.userIDTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelPermission = new DevComponents.DotNetBar.TabControlPanel();
            this.btnSavePermission = new DevComponents.DotNetBar.ButtonX();
            this.btnPermissionUpdate = new DevComponents.DotNetBar.ButtonX();
            this.cbPermission = new System.Windows.Forms.CheckedListBox();
            this.tabItemPermission = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelUser = new DevComponents.DotNetBar.TabControlPanel();
            this.btnUserUpdate = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelUser = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.roleComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.eDIAccountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.telphoneTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.phoneTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.emailTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.loginDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.msnTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnUserSave = new DevComponents.DotNetBar.ButtonX();
            this.tabItemUser = new DevComponents.DotNetBar.TabItem(this.components);
            userIDLabel = new DevComponents.DotNetBar.LabelX();
            roleLabel = new DevComponents.DotNetBar.LabelX();
            userNameLabel = new DevComponents.DotNetBar.LabelX();
            eDIAccountLabel = new DevComponents.DotNetBar.LabelX();
            telphoneLabel = new DevComponents.DotNetBar.LabelX();
            emailLabel = new DevComponents.DotNetBar.LabelX();
            phoneLabel = new DevComponents.DotNetBar.LabelX();
            loginDateLabel = new DevComponents.DotNetBar.LabelX();
            passwordLabel = new DevComponents.DotNetBar.LabelX();
            mSNLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanelPermission.SuspendLayout();
            this.tabPanelUser.SuspendLayout();
            this.groupPanelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            userIDLabel.AutoSize = true;
            userIDLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            userIDLabel.BackgroundStyle.Class = "";
            userIDLabel.Location = new System.Drawing.Point(33, 7);
            userIDLabel.Name = "userIDLabel";
            userIDLabel.Size = new System.Drawing.Size(41, 15);
            userIDLabel.TabIndex = 0;
            userIDLabel.Text = "<font color=\'red\'>*</font>登录ID";
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            roleLabel.BackgroundStyle.Class = "";
            roleLabel.Location = new System.Drawing.Point(44, 126);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new System.Drawing.Size(30, 15);
            roleLabel.TabIndex = 9;
            roleLabel.Text = "<font color=\'red\'>*</font>角色";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            userNameLabel.BackgroundStyle.Class = "";
            userNameLabel.Location = new System.Drawing.Point(32, 32);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(42, 15);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "<font color=\'red\'>*</font>用户名";
            // 
            // eDIAccountLabel
            // 
            eDIAccountLabel.AutoSize = true;
            eDIAccountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            eDIAccountLabel.BackgroundStyle.Class = "";
            eDIAccountLabel.Location = new System.Drawing.Point(29, 55);
            eDIAccountLabel.Name = "eDIAccountLabel";
            eDIAccountLabel.Size = new System.Drawing.Size(50, 16);
            eDIAccountLabel.TabIndex = 4;
            eDIAccountLabel.Text = "EDI帐号";
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
            telphoneLabel.TabIndex = 15;
            telphoneLabel.Text = "手机";
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
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email";
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
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "电话";
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
            loginDateLabel.TabIndex = 19;
            loginDateLabel.Text = "登录时间";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            passwordLabel.BackgroundStyle.Class = "";
            passwordLabel.Location = new System.Drawing.Point(44, 77);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(30, 15);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "<font color=\'red\'>*</font>密码";
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
            mSNLabel.TabIndex = 17;
            mSNLabel.Text = "MSN:";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.User);
            // 
            // userValidator
            // 
            this.userValidator.ContainerControl = this;
            this.userValidator.ErrorProvider = this.userErrorProvider;
            this.userValidator.Highlighter = this.userHighlighter;
            // 
            // userErrorProvider
            // 
            this.userErrorProvider.ContainerControl = this;
            this.userErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("userErrorProvider.Icon")));
            // 
            // userHighlighter
            // 
            this.userHighlighter.ContainerControl = this;
            // 
            // password2TextBox
            // 
            // 
            // 
            // 
            this.password2TextBox.Border.Class = "TextBoxBorder";
            this.password2TextBox.Location = new System.Drawing.Point(92, 97);
            this.password2TextBox.Name = "password2TextBox";
            this.password2TextBox.PasswordChar = '*';
            this.password2TextBox.Size = new System.Drawing.Size(154, 20);
            this.password2TextBox.TabIndex = 8;
            this.userValidator.SetValidator1(this.password2TextBox, this.compareValidator1);
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.passwordTextBox;
            this.compareValidator1.ErrorMessage = "两次密码输入必须相同";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.Border.Class = "TextBoxBorder";
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(92, 75);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(154, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.Border.Class = "TextBoxBorder";
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.nameTextBox.Location = new System.Drawing.Point(92, 29);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(154, 20);
            this.nameTextBox.TabIndex = 3;
            this.userValidator.SetValidator1(this.nameTextBox, this.requiredFieldValidator2);
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "必填";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            this.userIDTextBox.TabIndex = 1;
            this.userValidator.SetValidator1(this.userIDTextBox, this.requiredFieldValidator1);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "必填";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabPanelPermission);
            this.tabControl.Controls.Add(this.tabPanelUser);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(277, 343);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemUser);
            this.tabControl.Tabs.Add(this.tabItemPermission);
            this.tabControl.Text = "tabControl";
            // 
            // tabPanelPermission
            // 
            this.tabPanelPermission.Controls.Add(this.btnSavePermission);
            this.tabPanelPermission.Controls.Add(this.btnPermissionUpdate);
            this.tabPanelPermission.Controls.Add(this.cbPermission);
            this.tabPanelPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelPermission.Location = new System.Drawing.Point(0, 26);
            this.tabPanelPermission.Name = "tabPanelPermission";
            this.tabPanelPermission.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelPermission.Size = new System.Drawing.Size(277, 317);
            this.tabPanelPermission.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelPermission.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelPermission.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelPermission.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelPermission.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelPermission.Style.GradientAngle = 90;
            this.tabPanelPermission.TabIndex = 2;
            this.tabPanelPermission.TabItem = this.tabItemPermission;
            // 
            // btnSavePermission
            // 
            this.btnSavePermission.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSavePermission.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSavePermission.Enabled = false;
            this.btnSavePermission.Location = new System.Drawing.Point(12, 33);
            this.btnSavePermission.Name = "btnSavePermission";
            this.btnSavePermission.Size = new System.Drawing.Size(66, 23);
            this.btnSavePermission.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSavePermission.TabIndex = 3;
            this.btnSavePermission.Text = "保存";
            this.btnSavePermission.Click += new System.EventHandler(this.SavePermission);
            // 
            // btnPermissionUpdate
            // 
            this.btnPermissionUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPermissionUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPermissionUpdate.Location = new System.Drawing.Point(12, 4);
            this.btnPermissionUpdate.Name = "btnPermissionUpdate";
            this.btnPermissionUpdate.Size = new System.Drawing.Size(66, 23);
            this.btnPermissionUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPermissionUpdate.TabIndex = 2;
            this.btnPermissionUpdate.Text = "编辑";
            this.btnPermissionUpdate.Click += new System.EventHandler(this.UpdatePermission);
            // 
            // cbPermission
            // 
            this.cbPermission.CheckOnClick = true;
            this.cbPermission.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbPermission.Enabled = false;
            this.cbPermission.FormattingEnabled = true;
            this.cbPermission.Location = new System.Drawing.Point(87, 1);
            this.cbPermission.Name = "cbPermission";
            this.cbPermission.Size = new System.Drawing.Size(189, 304);
            this.cbPermission.TabIndex = 0;
            // 
            // tabItemPermission
            // 
            this.tabItemPermission.AttachedControl = this.tabPanelPermission;
            this.tabItemPermission.Name = "tabItemPermission";
            this.tabItemPermission.Text = "权限";
            // 
            // tabPanelUser
            // 
            this.tabPanelUser.Controls.Add(this.btnUserUpdate);
            this.tabPanelUser.Controls.Add(this.groupPanelUser);
            this.tabPanelUser.Controls.Add(this.btnUserSave);
            this.tabPanelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelUser.Location = new System.Drawing.Point(0, 26);
            this.tabPanelUser.Name = "tabPanelUser";
            this.tabPanelUser.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelUser.Size = new System.Drawing.Size(277, 317);
            this.tabPanelUser.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelUser.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelUser.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelUser.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelUser.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelUser.Style.GradientAngle = 90;
            this.tabPanelUser.TabIndex = 1;
            this.tabPanelUser.TabItem = this.tabItemUser;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUserUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUserUpdate.Location = new System.Drawing.Point(60, 286);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUserUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUserUpdate.TabIndex = 1;
            this.btnUserUpdate.Text = "编辑";
            this.btnUserUpdate.Click += new System.EventHandler(this.UpdateUser);
            // 
            // groupPanelUser
            // 
            this.groupPanelUser.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelUser.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelUser.Controls.Add(this.password2TextBox);
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
            this.groupPanelUser.Location = new System.Drawing.Point(1, 1);
            this.groupPanelUser.Name = "groupPanelUser";
            this.groupPanelUser.Size = new System.Drawing.Size(275, 279);
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
            this.groupPanelUser.TabIndex = 0;
            // 
            // roleComboBox
            // 
            this.roleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Role", true));
            this.roleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "营销组",
            "工作组",
            "维护组",
            "主管",
            "有权人"});
            this.roleComboBox.Location = new System.Drawing.Point(92, 122);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(154, 21);
            this.roleComboBox.TabIndex = 10;
            // 
            // eDIAccountTextBox
            // 
            // 
            // 
            // 
            this.eDIAccountTextBox.Border.Class = "TextBoxBorder";
            this.eDIAccountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "EDIAccount", true));
            this.eDIAccountTextBox.Location = new System.Drawing.Point(92, 53);
            this.eDIAccountTextBox.Name = "eDIAccountTextBox";
            this.eDIAccountTextBox.Size = new System.Drawing.Size(154, 20);
            this.eDIAccountTextBox.TabIndex = 5;
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
            this.telphoneTextBox.TabIndex = 16;
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
            this.phoneTextBox.TabIndex = 14;
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
            this.emailTextBox.TabIndex = 12;
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
            this.loginDate.TabIndex = 20;
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
            this.msnTextBox.TabIndex = 18;
            // 
            // btnUserSave
            // 
            this.btnUserSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUserSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUserSave.Location = new System.Drawing.Point(141, 286);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(75, 23);
            this.btnUserSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUserSave.TabIndex = 2;
            this.btnUserSave.Text = "保存";
            this.btnUserSave.Click += new System.EventHandler(this.SaveUser);
            // 
            // tabItemUser
            // 
            this.tabItemUser.AttachedControl = this.tabPanelUser;
            this.tabItemUser.Name = "tabItemUser";
            this.tabItemUser.Text = "基本信息";
            // 
            // UserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(277, 343);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "UserDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPanelPermission.ResumeLayout(false);
            this.tabPanelUser.ResumeLayout(false);
            this.groupPanelUser.ResumeLayout(false);
            this.groupPanelUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
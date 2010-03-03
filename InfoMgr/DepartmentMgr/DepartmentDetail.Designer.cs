//-----------------------------------------------------------------------
// <copyright file="DepartmentDetail.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.DepartmentMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DepartmentDetail
    {
        #region Fields (20)
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.Controls.TextBoxX addressCNTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX addressENTextBox;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX contact_1TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX contact_2TextBox;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DevComponents.DotNetBar.Controls.TextBoxX departmentCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX departmentNameTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx domainComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX email_1TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX email_2TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX fax_1TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX fax_2TextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelDepartment;
        private DevComponents.DotNetBar.Controls.TextBoxX locationTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX managerTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX phone_1TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX phone_2TextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX postCodeTextBox;

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
            DevComponents.DotNetBar.LabelX departmentCodeLabel;
            DevComponents.DotNetBar.LabelX departmentNameLabel;
            DevComponents.DotNetBar.LabelX domainLabel;
            DevComponents.DotNetBar.LabelX locationLabel;
            DevComponents.DotNetBar.LabelX addressCNLabel;
            DevComponents.DotNetBar.LabelX contact_1Label;
            DevComponents.DotNetBar.LabelX contact_2Label;
            DevComponents.DotNetBar.LabelX phone_1Label;
            DevComponents.DotNetBar.LabelX phone_2Label;
            DevComponents.DotNetBar.LabelX email_1Label;
            DevComponents.DotNetBar.LabelX email_2Label;
            DevComponents.DotNetBar.LabelX fax_1Label;
            DevComponents.DotNetBar.LabelX fax_2Label;
            DevComponents.DotNetBar.LabelX postCodeLabel;
            DevComponents.DotNetBar.LabelX managerLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentDetail));
            this.groupPanelDepartment = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.managerTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.fax_2TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.fax_1TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.email_2TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.email_1TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.phone_2TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.phone_1TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.contact_2TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.contact_1TextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.addressENTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.addressCNTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.locationTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.domainComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.departmentNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.departmentCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必选");
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            departmentCodeLabel = new DevComponents.DotNetBar.LabelX();
            departmentNameLabel = new DevComponents.DotNetBar.LabelX();
            domainLabel = new DevComponents.DotNetBar.LabelX();
            locationLabel = new DevComponents.DotNetBar.LabelX();
            addressCNLabel = new DevComponents.DotNetBar.LabelX();
            contact_1Label = new DevComponents.DotNetBar.LabelX();
            contact_2Label = new DevComponents.DotNetBar.LabelX();
            phone_1Label = new DevComponents.DotNetBar.LabelX();
            phone_2Label = new DevComponents.DotNetBar.LabelX();
            email_1Label = new DevComponents.DotNetBar.LabelX();
            email_2Label = new DevComponents.DotNetBar.LabelX();
            fax_1Label = new DevComponents.DotNetBar.LabelX();
            fax_2Label = new DevComponents.DotNetBar.LabelX();
            postCodeLabel = new DevComponents.DotNetBar.LabelX();
            managerLabel = new DevComponents.DotNetBar.LabelX();
            this.groupPanelDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentCodeLabel
            // 
            departmentCodeLabel.AutoSize = true;
            departmentCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            departmentCodeLabel.BackgroundStyle.Class = "";
            departmentCodeLabel.Location = new System.Drawing.Point(6, 7);
            departmentCodeLabel.Name = "departmentCodeLabel";
            departmentCodeLabel.Size = new System.Drawing.Size(57, 15);
            departmentCodeLabel.TabIndex = 0;
            departmentCodeLabel.Text = "<font color=\'red\'>*</font>部门编码:";
            // 
            // departmentNameLabel
            // 
            departmentNameLabel.AutoSize = true;
            departmentNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            departmentNameLabel.BackgroundStyle.Class = "";
            departmentNameLabel.Location = new System.Drawing.Point(18, 29);
            departmentNameLabel.Name = "departmentNameLabel";
            departmentNameLabel.Size = new System.Drawing.Size(45, 15);
            departmentNameLabel.TabIndex = 2;
            departmentNameLabel.Text = "<font color=\'red\'>*</font>部门名:";
            // 
            // domainLabel
            // 
            domainLabel.AutoSize = true;
            domainLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            domainLabel.BackgroundStyle.Class = "";
            domainLabel.Location = new System.Drawing.Point(234, 50);
            domainLabel.Name = "domainLabel";
            domainLabel.Size = new System.Drawing.Size(45, 15);
            domainLabel.TabIndex = 8;
            domainLabel.Text = "<font color=\'red\'>*</font>事业部:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            locationLabel.BackgroundStyle.Class = "";
            locationLabel.Location = new System.Drawing.Point(29, 50);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(33, 15);
            locationLabel.TabIndex = 6;
            locationLabel.Text = "<font color=\'red\'>*</font>城市:";
            // 
            // addressCNLabel
            // 
            addressCNLabel.AutoSize = true;
            addressCNLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            addressCNLabel.BackgroundStyle.Class = "";
            addressCNLabel.Location = new System.Drawing.Point(33, 72);
            addressCNLabel.Name = "addressCNLabel";
            addressCNLabel.Size = new System.Drawing.Size(34, 16);
            addressCNLabel.TabIndex = 10;
            addressCNLabel.Text = "地址:";
            // 
            // contact_1Label
            // 
            contact_1Label.AutoSize = true;
            contact_1Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            contact_1Label.BackgroundStyle.Class = "";
            contact_1Label.Location = new System.Drawing.Point(15, 136);
            contact_1Label.Name = "contact_1Label";
            contact_1Label.Size = new System.Drawing.Size(53, 16);
            contact_1Label.TabIndex = 15;
            contact_1Label.Text = "联系人1:";
            // 
            // contact_2Label
            // 
            contact_2Label.AutoSize = true;
            contact_2Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            contact_2Label.BackgroundStyle.Class = "";
            contact_2Label.Location = new System.Drawing.Point(228, 136);
            contact_2Label.Name = "contact_2Label";
            contact_2Label.Size = new System.Drawing.Size(53, 16);
            contact_2Label.TabIndex = 23;
            contact_2Label.Text = "联系人2:";
            // 
            // phone_1Label
            // 
            phone_1Label.AutoSize = true;
            phone_1Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            phone_1Label.BackgroundStyle.Class = "";
            phone_1Label.Location = new System.Drawing.Point(33, 158);
            phone_1Label.Name = "phone_1Label";
            phone_1Label.Size = new System.Drawing.Size(34, 16);
            phone_1Label.TabIndex = 17;
            phone_1Label.Text = "电话:";
            // 
            // phone_2Label
            // 
            phone_2Label.AutoSize = true;
            phone_2Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            phone_2Label.BackgroundStyle.Class = "";
            phone_2Label.Location = new System.Drawing.Point(246, 158);
            phone_2Label.Name = "phone_2Label";
            phone_2Label.Size = new System.Drawing.Size(34, 16);
            phone_2Label.TabIndex = 25;
            phone_2Label.Text = "电话:";
            // 
            // email_1Label
            // 
            email_1Label.AutoSize = true;
            email_1Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            email_1Label.BackgroundStyle.Class = "";
            email_1Label.Location = new System.Drawing.Point(29, 180);
            email_1Label.Name = "email_1Label";
            email_1Label.Size = new System.Drawing.Size(38, 16);
            email_1Label.TabIndex = 19;
            email_1Label.Text = "Email:";
            // 
            // email_2Label
            // 
            email_2Label.AutoSize = true;
            email_2Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            email_2Label.BackgroundStyle.Class = "";
            email_2Label.Location = new System.Drawing.Point(242, 180);
            email_2Label.Name = "email_2Label";
            email_2Label.Size = new System.Drawing.Size(38, 16);
            email_2Label.TabIndex = 27;
            email_2Label.Text = "Email:";
            // 
            // fax_1Label
            // 
            fax_1Label.AutoSize = true;
            fax_1Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            fax_1Label.BackgroundStyle.Class = "";
            fax_1Label.Location = new System.Drawing.Point(38, 202);
            fax_1Label.Name = "fax_1Label";
            fax_1Label.Size = new System.Drawing.Size(28, 16);
            fax_1Label.TabIndex = 21;
            fax_1Label.Text = "Fax:";
            // 
            // fax_2Label
            // 
            fax_2Label.AutoSize = true;
            fax_2Label.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            fax_2Label.BackgroundStyle.Class = "";
            fax_2Label.Location = new System.Drawing.Point(252, 202);
            fax_2Label.Name = "fax_2Label";
            fax_2Label.Size = new System.Drawing.Size(28, 16);
            fax_2Label.TabIndex = 29;
            fax_2Label.Text = "Fax:";
            // 
            // postCodeLabel
            // 
            postCodeLabel.AutoSize = true;
            postCodeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            postCodeLabel.BackgroundStyle.Class = "";
            postCodeLabel.Location = new System.Drawing.Point(33, 114);
            postCodeLabel.Name = "postCodeLabel";
            postCodeLabel.Size = new System.Drawing.Size(34, 16);
            postCodeLabel.TabIndex = 13;
            postCodeLabel.Text = "邮编:";
            // 
            // managerLabel
            // 
            managerLabel.AutoSize = true;
            managerLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            managerLabel.BackgroundStyle.Class = "";
            managerLabel.Location = new System.Drawing.Point(234, 28);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new System.Drawing.Size(47, 16);
            managerLabel.TabIndex = 4;
            managerLabel.Text = "负责人:";
            // 
            // groupPanelDepartment
            // 
            this.groupPanelDepartment.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelDepartment.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelDepartment.Controls.Add(managerLabel);
            this.groupPanelDepartment.Controls.Add(this.managerTextBox);
            this.groupPanelDepartment.Controls.Add(postCodeLabel);
            this.groupPanelDepartment.Controls.Add(this.postCodeTextBox);
            this.groupPanelDepartment.Controls.Add(fax_2Label);
            this.groupPanelDepartment.Controls.Add(this.fax_2TextBox);
            this.groupPanelDepartment.Controls.Add(fax_1Label);
            this.groupPanelDepartment.Controls.Add(this.fax_1TextBox);
            this.groupPanelDepartment.Controls.Add(email_2Label);
            this.groupPanelDepartment.Controls.Add(this.email_2TextBox);
            this.groupPanelDepartment.Controls.Add(email_1Label);
            this.groupPanelDepartment.Controls.Add(this.email_1TextBox);
            this.groupPanelDepartment.Controls.Add(phone_2Label);
            this.groupPanelDepartment.Controls.Add(this.phone_2TextBox);
            this.groupPanelDepartment.Controls.Add(phone_1Label);
            this.groupPanelDepartment.Controls.Add(this.phone_1TextBox);
            this.groupPanelDepartment.Controls.Add(contact_2Label);
            this.groupPanelDepartment.Controls.Add(this.contact_2TextBox);
            this.groupPanelDepartment.Controls.Add(contact_1Label);
            this.groupPanelDepartment.Controls.Add(this.contact_1TextBox);
            this.groupPanelDepartment.Controls.Add(this.addressENTextBox);
            this.groupPanelDepartment.Controls.Add(addressCNLabel);
            this.groupPanelDepartment.Controls.Add(this.addressCNTextBox);
            this.groupPanelDepartment.Controls.Add(locationLabel);
            this.groupPanelDepartment.Controls.Add(this.locationTextBox);
            this.groupPanelDepartment.Controls.Add(domainLabel);
            this.groupPanelDepartment.Controls.Add(this.domainComboBox);
            this.groupPanelDepartment.Controls.Add(departmentNameLabel);
            this.groupPanelDepartment.Controls.Add(this.departmentNameTextBox);
            this.groupPanelDepartment.Controls.Add(departmentCodeLabel);
            this.groupPanelDepartment.Controls.Add(this.departmentCodeTextBox);
            this.groupPanelDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelDepartment.Location = new System.Drawing.Point(0, 0);
            this.groupPanelDepartment.Name = "groupPanelDepartment";
            this.groupPanelDepartment.Size = new System.Drawing.Size(458, 233);
            // 
            // 
            // 
            this.groupPanelDepartment.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelDepartment.Style.BackColorGradientAngle = 90;
            this.groupPanelDepartment.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelDepartment.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDepartment.Style.BorderBottomWidth = 1;
            this.groupPanelDepartment.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelDepartment.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDepartment.Style.BorderLeftWidth = 1;
            this.groupPanelDepartment.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDepartment.Style.BorderRightWidth = 1;
            this.groupPanelDepartment.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDepartment.Style.BorderTopWidth = 1;
            this.groupPanelDepartment.Style.Class = "";
            this.groupPanelDepartment.Style.CornerDiameter = 4;
            this.groupPanelDepartment.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelDepartment.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelDepartment.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelDepartment.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelDepartment.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelDepartment.StyleMouseOver.Class = "";
            this.groupPanelDepartment.TabIndex = 0;
            // 
            // managerTextBox
            // 
            // 
            // 
            // 
            this.managerTextBox.Border.Class = "TextBoxBorder";
            this.managerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Manager", true));
            this.managerTextBox.Location = new System.Drawing.Point(287, 27);
            this.managerTextBox.Name = "managerTextBox";
            this.managerTextBox.Size = new System.Drawing.Size(120, 20);
            this.managerTextBox.TabIndex = 5;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Department);
            // 
            // postCodeTextBox
            // 
            // 
            // 
            // 
            this.postCodeTextBox.Border.Class = "TextBoxBorder";
            this.postCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "PostCode", true));
            this.postCodeTextBox.Location = new System.Drawing.Point(69, 114);
            this.postCodeTextBox.Name = "postCodeTextBox";
            this.postCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.postCodeTextBox.TabIndex = 14;
            // 
            // fax_2TextBox
            // 
            // 
            // 
            // 
            this.fax_2TextBox.Border.Class = "TextBoxBorder";
            this.fax_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Fax_2", true));
            this.fax_2TextBox.Location = new System.Drawing.Point(286, 201);
            this.fax_2TextBox.Name = "fax_2TextBox";
            this.fax_2TextBox.Size = new System.Drawing.Size(121, 20);
            this.fax_2TextBox.TabIndex = 30;
            // 
            // fax_1TextBox
            // 
            // 
            // 
            // 
            this.fax_1TextBox.Border.Class = "TextBoxBorder";
            this.fax_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Fax_1", true));
            this.fax_1TextBox.Location = new System.Drawing.Point(69, 201);
            this.fax_1TextBox.Name = "fax_1TextBox";
            this.fax_1TextBox.Size = new System.Drawing.Size(120, 20);
            this.fax_1TextBox.TabIndex = 22;
            // 
            // email_2TextBox
            // 
            // 
            // 
            // 
            this.email_2TextBox.Border.Class = "TextBoxBorder";
            this.email_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Email_2", true));
            this.email_2TextBox.Location = new System.Drawing.Point(287, 179);
            this.email_2TextBox.Name = "email_2TextBox";
            this.email_2TextBox.Size = new System.Drawing.Size(120, 20);
            this.email_2TextBox.TabIndex = 28;
            // 
            // email_1TextBox
            // 
            // 
            // 
            // 
            this.email_1TextBox.Border.Class = "TextBoxBorder";
            this.email_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Email_1", true));
            this.email_1TextBox.Location = new System.Drawing.Point(69, 179);
            this.email_1TextBox.Name = "email_1TextBox";
            this.email_1TextBox.Size = new System.Drawing.Size(120, 20);
            this.email_1TextBox.TabIndex = 20;
            // 
            // phone_2TextBox
            // 
            // 
            // 
            // 
            this.phone_2TextBox.Border.Class = "TextBoxBorder";
            this.phone_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Phone_2", true));
            this.phone_2TextBox.Location = new System.Drawing.Point(287, 157);
            this.phone_2TextBox.Name = "phone_2TextBox";
            this.phone_2TextBox.Size = new System.Drawing.Size(120, 20);
            this.phone_2TextBox.TabIndex = 26;
            // 
            // phone_1TextBox
            // 
            // 
            // 
            // 
            this.phone_1TextBox.Border.Class = "TextBoxBorder";
            this.phone_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Phone_1", true));
            this.phone_1TextBox.Location = new System.Drawing.Point(69, 157);
            this.phone_1TextBox.Name = "phone_1TextBox";
            this.phone_1TextBox.Size = new System.Drawing.Size(120, 20);
            this.phone_1TextBox.TabIndex = 18;
            // 
            // contact_2TextBox
            // 
            // 
            // 
            // 
            this.contact_2TextBox.Border.Class = "TextBoxBorder";
            this.contact_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Contact_2", true));
            this.contact_2TextBox.Location = new System.Drawing.Point(287, 135);
            this.contact_2TextBox.Name = "contact_2TextBox";
            this.contact_2TextBox.Size = new System.Drawing.Size(121, 20);
            this.contact_2TextBox.TabIndex = 24;
            // 
            // contact_1TextBox
            // 
            // 
            // 
            // 
            this.contact_1TextBox.Border.Class = "TextBoxBorder";
            this.contact_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Contact_1", true));
            this.contact_1TextBox.Location = new System.Drawing.Point(69, 136);
            this.contact_1TextBox.Name = "contact_1TextBox";
            this.contact_1TextBox.Size = new System.Drawing.Size(120, 20);
            this.contact_1TextBox.TabIndex = 16;
            // 
            // addressENTextBox
            // 
            // 
            // 
            // 
            this.addressENTextBox.Border.Class = "TextBoxBorder";
            this.addressENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "AddressEN", true));
            this.addressENTextBox.Location = new System.Drawing.Point(69, 93);
            this.addressENTextBox.Name = "addressENTextBox";
            this.addressENTextBox.Size = new System.Drawing.Size(339, 20);
            this.addressENTextBox.TabIndex = 12;
            this.addressENTextBox.WatermarkText = "英文地址";
            // 
            // addressCNTextBox
            // 
            // 
            // 
            // 
            this.addressCNTextBox.Border.Class = "TextBoxBorder";
            this.addressCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "AddressCN", true));
            this.addressCNTextBox.Location = new System.Drawing.Point(69, 71);
            this.addressCNTextBox.Name = "addressCNTextBox";
            this.addressCNTextBox.Size = new System.Drawing.Size(339, 20);
            this.addressCNTextBox.TabIndex = 11;
            this.addressCNTextBox.WatermarkText = "中文地址";
            // 
            // locationTextBox
            // 
            // 
            // 
            // 
            this.locationTextBox.Border.Class = "TextBoxBorder";
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(69, 49);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 7;
            this.superValidator.SetValidator1(this.locationTextBox, this.requiredFieldValidator1);
            // 
            // domainComboBox
            // 
            this.domainComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "Domain", true));
            this.domainComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.domainComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.domainComboBox.FormattingEnabled = true;
            this.domainComboBox.Items.AddRange(new object[] {
            "贸易金融事业部",
            "分行营业部",
            "地产金融事业部",
            "交通金融事业部",
            "金融市场事业部",
            "能源金融事业部",
            "冶金金融事业部",
            "中小企业金融事业部"});
            this.domainComboBox.Location = new System.Drawing.Point(287, 48);
            this.domainComboBox.Name = "domainComboBox";
            this.domainComboBox.Size = new System.Drawing.Size(121, 21);
            this.domainComboBox.TabIndex = 9;
            this.superValidator.SetValidator1(this.domainComboBox, this.requiredFieldValidator2);
            // 
            // departmentNameTextBox
            // 
            // 
            // 
            // 
            this.departmentNameTextBox.Border.Class = "TextBoxBorder";
            this.departmentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "DepartmentName", true));
            this.departmentNameTextBox.Location = new System.Drawing.Point(69, 27);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.departmentNameTextBox.TabIndex = 3;
            // 
            // departmentCodeTextBox
            // 
            // 
            // 
            // 
            this.departmentCodeTextBox.Border.Class = "TextBoxBorder";
            this.departmentCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentBindingSource, "DepartmentCode", true));
            this.departmentCodeTextBox.Location = new System.Drawing.Point(69, 5);
            this.departmentCodeTextBox.Name = "departmentCodeTextBox";
            this.departmentCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.departmentCodeTextBox.TabIndex = 1;
            this.superValidator.SetValidator1(this.departmentCodeTextBox, this.requiredFieldValidator3);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(228, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.SaveDepartment);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Location = new System.Drawing.Point(147, 239);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "编辑";
            this.btnUpdate.Click += new System.EventHandler(this.UpdateDepartment);
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "必填";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "必选";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "必填";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            // DepartmentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 276);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupPanelDepartment);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "DepartmentDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "部门信息";
            this.groupPanelDepartment.ResumeLayout(false);
            this.groupPanelDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
    }
}
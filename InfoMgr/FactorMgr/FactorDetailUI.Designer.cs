//-----------------------------------------------------------------------
// <copyright file="FactorDetailUI.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    /// <summary>
    /// Factor Detail User Interface Designer
    /// </summary>
    public partial class FactorDetailUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource factorBindingSource;
        private System.Windows.Forms.GroupBox groupBoxFactor;
        private System.Windows.Forms.TextBox tbBranchName;
        private System.Windows.Forms.TextBox tbCityVisiting;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.TextBox tbContact1;
        private System.Windows.Forms.TextBox tbContact2;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbFactorCode;
        private System.Windows.Forms.ComboBox cbFactorType;
        private System.Windows.Forms.TextBox tbPostalCodePost;
        private System.Windows.Forms.TextBox tbTelefax1;
        private System.Windows.Forms.TextBox tbTelefax2;
        private System.Windows.Forms.TextBox tbTelephone1;
        private System.Windows.Forms.TextBox tbTelephone2;
        private System.Windows.Forms.TextBox tbVisitingAddress;
        private System.Windows.Forms.TextBox tbWebSite;
        private System.Windows.Forms.GroupBox groupBoxCover;
        private System.Windows.Forms.ToolStrip toolStrip1;
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
            System.Windows.Forms.Label labelBranchName;
            System.Windows.Forms.Label labelCityVisiting;
            System.Windows.Forms.Label labelCompanyName;
            System.Windows.Forms.Label labelContacts_1;
            System.Windows.Forms.Label labelContacts_2;
            System.Windows.Forms.Label labelCountry;
            System.Windows.Forms.Label labelEmail;
            System.Windows.Forms.Label labelFactorCode;
            System.Windows.Forms.Label labelFactorType;
            System.Windows.Forms.Label labelPostalCodePost;
            System.Windows.Forms.Label labelTelefax_1;
            System.Windows.Forms.Label labelTelefax_2;
            System.Windows.Forms.Label labelTelephone_1;
            System.Windows.Forms.Label labelTelephone_2;
            System.Windows.Forms.Label labelVisitingAddress;
            System.Windows.Forms.Label labelWebSite;
            this.factorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxFactor = new System.Windows.Forms.GroupBox();
            this.tbBranchName = new System.Windows.Forms.TextBox();
            this.tbCityVisiting = new System.Windows.Forms.TextBox();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tbContact1 = new System.Windows.Forms.TextBox();
            this.tbContact2 = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbFactorCode = new System.Windows.Forms.TextBox();
            this.cbFactorType = new System.Windows.Forms.ComboBox();
            this.tbPostalCodePost = new System.Windows.Forms.TextBox();
            this.tbTelefax1 = new System.Windows.Forms.TextBox();
            this.tbTelefax2 = new System.Windows.Forms.TextBox();
            this.tbTelephone1 = new System.Windows.Forms.TextBox();
            this.tbTelephone2 = new System.Windows.Forms.TextBox();
            this.tbVisitingAddress = new System.Windows.Forms.TextBox();
            this.tbWebSite = new System.Windows.Forms.TextBox();
            this.groupBoxCover = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            labelBranchName = new System.Windows.Forms.Label();
            labelCityVisiting = new System.Windows.Forms.Label();
            labelCompanyName = new System.Windows.Forms.Label();
            labelContacts_1 = new System.Windows.Forms.Label();
            labelContacts_2 = new System.Windows.Forms.Label();
            labelCountry = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            labelFactorCode = new System.Windows.Forms.Label();
            labelFactorType = new System.Windows.Forms.Label();
            labelPostalCodePost = new System.Windows.Forms.Label();
            labelTelefax_1 = new System.Windows.Forms.Label();
            labelTelefax_2 = new System.Windows.Forms.Label();
            labelTelephone_1 = new System.Windows.Forms.Label();
            labelTelephone_2 = new System.Windows.Forms.Label();
            labelVisitingAddress = new System.Windows.Forms.Label();
            labelWebSite = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.factorBindingSource)).BeginInit();
            this.groupBoxFactor.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBranchName
            // 
            labelBranchName.AutoSize = true;
            labelBranchName.Location = new System.Drawing.Point(265, 56);
            labelBranchName.Name = "labelBranchName";
            labelBranchName.Size = new System.Drawing.Size(55, 13);
            labelBranchName.TabIndex = 75;
            labelBranchName.Text = "分行名称";
            // 
            // labelCityVisiting
            // 
            labelCityVisiting.AutoSize = true;
            labelCityVisiting.Location = new System.Drawing.Point(265, 88);
            labelCityVisiting.Name = "labelCityVisiting";
            labelCityVisiting.Size = new System.Drawing.Size(31, 13);
            labelCityVisiting.TabIndex = 79;
            labelCityVisiting.Text = "城市";
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Location = new System.Drawing.Point(35, 56);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new System.Drawing.Size(55, 13);
            labelCompanyName.TabIndex = 83;
            labelCompanyName.Text = "机构名称";
            // 
            // labelContacts_1
            // 
            labelContacts_1.AutoSize = true;
            labelContacts_1.Location = new System.Drawing.Point(35, 151);
            labelContacts_1.Name = "labelContacts_1";
            labelContacts_1.Size = new System.Drawing.Size(52, 13);
            labelContacts_1.TabIndex = 85;
            labelContacts_1.Text = "联系人 1";
            // 
            // labelContacts_2
            // 
            labelContacts_2.AutoSize = true;
            labelContacts_2.Location = new System.Drawing.Point(265, 151);
            labelContacts_2.Name = "labelContacts_2";
            labelContacts_2.Size = new System.Drawing.Size(52, 13);
            labelContacts_2.TabIndex = 87;
            labelContacts_2.Text = "联系人 2";
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new System.Drawing.Point(35, 88);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new System.Drawing.Size(31, 13);
            labelCountry.TabIndex = 93;
            labelCountry.Text = "国别";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new System.Drawing.Point(265, 243);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(59, 13);
            labelEmail.TabIndex = 99;
            labelEmail.Text = "Email 地址";
            // 
            // labelFactorCode
            // 
            labelFactorCode.AutoSize = true;
            labelFactorCode.Location = new System.Drawing.Point(35, 25);
            labelFactorCode.Name = "labelFactorCode";
            labelFactorCode.Size = new System.Drawing.Size(55, 13);
            labelFactorCode.TabIndex = 101;
            labelFactorCode.Text = "机构编号";
            // 
            // labelFactorType
            // 
            labelFactorType.AutoSize = true;
            labelFactorType.Location = new System.Drawing.Point(265, 25);
            labelFactorType.Name = "labelFactorType";
            labelFactorType.Size = new System.Drawing.Size(55, 13);
            labelFactorType.TabIndex = 103;
            labelFactorType.Text = "机构类型";
            // 
            // labelPostalCodePost
            // 
            labelPostalCodePost.AutoSize = true;
            labelPostalCodePost.Location = new System.Drawing.Point(265, 119);
            labelPostalCodePost.Name = "labelPostalCodePost";
            labelPostalCodePost.Size = new System.Drawing.Size(31, 13);
            labelPostalCodePost.TabIndex = 123;
            labelPostalCodePost.Text = "邮编";
            // 
            // labelTelefax_1
            // 
            labelTelefax_1.AutoSize = true;
            labelTelefax_1.Location = new System.Drawing.Point(35, 213);
            labelTelefax_1.Name = "labelTelefax_1";
            labelTelefax_1.Size = new System.Drawing.Size(40, 13);
            labelTelefax_1.TabIndex = 131;
            labelTelefax_1.Text = "传真 1";
            // 
            // labelTelefax_2
            // 
            labelTelefax_2.AutoSize = true;
            labelTelefax_2.Location = new System.Drawing.Point(265, 213);
            labelTelefax_2.Name = "labelTelefax_2";
            labelTelefax_2.Size = new System.Drawing.Size(40, 13);
            labelTelefax_2.TabIndex = 133;
            labelTelefax_2.Text = "传真 2";
            // 
            // labelTelephone_1
            // 
            labelTelephone_1.AutoSize = true;
            labelTelephone_1.Location = new System.Drawing.Point(35, 182);
            labelTelephone_1.Name = "labelTelephone_1";
            labelTelephone_1.Size = new System.Drawing.Size(40, 13);
            labelTelephone_1.TabIndex = 135;
            labelTelephone_1.Text = "电话 1";
            // 
            // labelTelephone_2
            // 
            labelTelephone_2.AutoSize = true;
            labelTelephone_2.Location = new System.Drawing.Point(265, 182);
            labelTelephone_2.Name = "labelTelephone_2";
            labelTelephone_2.Size = new System.Drawing.Size(40, 13);
            labelTelephone_2.TabIndex = 137;
            labelTelephone_2.Text = "电话 2";
            // 
            // labelVisitingAddress
            // 
            labelVisitingAddress.AutoSize = true;
            labelVisitingAddress.Location = new System.Drawing.Point(35, 119);
            labelVisitingAddress.Name = "labelVisitingAddress";
            labelVisitingAddress.Size = new System.Drawing.Size(31, 13);
            labelVisitingAddress.TabIndex = 139;
            labelVisitingAddress.Text = "地址";
            // 
            // labelWebSite
            // 
            labelWebSite.AutoSize = true;
            labelWebSite.Location = new System.Drawing.Point(35, 243);
            labelWebSite.Name = "labelWebSite";
            labelWebSite.Size = new System.Drawing.Size(55, 13);
            labelWebSite.TabIndex = 143;
            labelWebSite.Text = "公司网址";
            // 
            // factorBindingSource
            // 
            this.factorBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Factor);
            // 
            // groupBoxFactor
            // 
            this.groupBoxFactor.Controls.Add(labelBranchName);
            this.groupBoxFactor.Controls.Add(this.tbBranchName);
            this.groupBoxFactor.Controls.Add(labelCityVisiting);
            this.groupBoxFactor.Controls.Add(this.tbCityVisiting);
            this.groupBoxFactor.Controls.Add(labelCompanyName);
            this.groupBoxFactor.Controls.Add(this.tbCompanyName);
            this.groupBoxFactor.Controls.Add(labelContacts_1);
            this.groupBoxFactor.Controls.Add(this.tbContact1);
            this.groupBoxFactor.Controls.Add(labelContacts_2);
            this.groupBoxFactor.Controls.Add(this.tbContact2);
            this.groupBoxFactor.Controls.Add(labelCountry);
            this.groupBoxFactor.Controls.Add(this.cbCountry);
            this.groupBoxFactor.Controls.Add(labelEmail);
            this.groupBoxFactor.Controls.Add(this.tbEmail);
            this.groupBoxFactor.Controls.Add(labelFactorCode);
            this.groupBoxFactor.Controls.Add(this.tbFactorCode);
            this.groupBoxFactor.Controls.Add(labelFactorType);
            this.groupBoxFactor.Controls.Add(this.cbFactorType);
            this.groupBoxFactor.Controls.Add(labelPostalCodePost);
            this.groupBoxFactor.Controls.Add(this.tbPostalCodePost);
            this.groupBoxFactor.Controls.Add(labelTelefax_1);
            this.groupBoxFactor.Controls.Add(this.tbTelefax1);
            this.groupBoxFactor.Controls.Add(labelTelefax_2);
            this.groupBoxFactor.Controls.Add(this.tbTelefax2);
            this.groupBoxFactor.Controls.Add(labelTelephone_1);
            this.groupBoxFactor.Controls.Add(this.tbTelephone1);
            this.groupBoxFactor.Controls.Add(labelTelephone_2);
            this.groupBoxFactor.Controls.Add(this.tbTelephone2);
            this.groupBoxFactor.Controls.Add(labelVisitingAddress);
            this.groupBoxFactor.Controls.Add(this.tbVisitingAddress);
            this.groupBoxFactor.Controls.Add(labelWebSite);
            this.groupBoxFactor.Controls.Add(this.tbWebSite);
            this.groupBoxFactor.Location = new System.Drawing.Point(12, 29);
            this.groupBoxFactor.Name = "groupBoxFactor";
            this.groupBoxFactor.Size = new System.Drawing.Size(492, 293);
            this.groupBoxFactor.TabIndex = 75;
            this.groupBoxFactor.TabStop = false;
            this.groupBoxFactor.Text = "基本信息";
            // 
            // tbBranchName
            // 
            this.tbBranchName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "BranchName", true));
            this.tbBranchName.Location = new System.Drawing.Point(358, 55);
            this.tbBranchName.Name = "tbBranchName";
            this.tbBranchName.Size = new System.Drawing.Size(100, 20);
            this.tbBranchName.TabIndex = 3;
            // 
            // tbCityVisiting
            // 
            this.tbCityVisiting.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "CityVisiting", true));
            this.tbCityVisiting.Location = new System.Drawing.Point(358, 86);
            this.tbCityVisiting.Name = "tbCityVisiting";
            this.tbCityVisiting.Size = new System.Drawing.Size(100, 20);
            this.tbCityVisiting.TabIndex = 5;
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "CompanyName", true));
            this.tbCompanyName.Location = new System.Drawing.Point(126, 56);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(100, 20);
            this.tbCompanyName.TabIndex = 2;
            // 
            // tbContact1
            // 
            this.tbContact1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Contacts_1", true));
            this.tbContact1.Location = new System.Drawing.Point(126, 151);
            this.tbContact1.Name = "tbContact1";
            this.tbContact1.Size = new System.Drawing.Size(100, 20);
            this.tbContact1.TabIndex = 8;
            // 
            // tbContact2
            // 
            this.tbContact2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Contacts_2", true));
            this.tbContact2.Location = new System.Drawing.Point(358, 146);
            this.tbContact2.Name = "tbContact2";
            this.tbContact2.Size = new System.Drawing.Size(100, 20);
            this.tbContact2.TabIndex = 11;
            // 
            // cbCountry
            // 
            this.cbCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Country", true));
            this.cbCountry.DisplayMember = "CountryFormat";
            this.cbCountry.Location = new System.Drawing.Point(126, 88);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(100, 21);
            this.cbCountry.TabIndex = 4;
            this.cbCountry.ValueMember = "CountryCode";
            // 
            // tbEmail
            // 
            this.tbEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Email", true));
            this.tbEmail.Location = new System.Drawing.Point(358, 237);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 15;
            // 
            // tbFactorCode
            // 
            this.tbFactorCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "FactorCode", true));
            this.tbFactorCode.Location = new System.Drawing.Point(126, 25);
            this.tbFactorCode.Name = "tbFactorCode";
            this.tbFactorCode.Size = new System.Drawing.Size(100, 20);
            this.tbFactorCode.TabIndex = 0;
            // 
            // cbFactorType
            // 
            this.cbFactorType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "FactorType", true));
            this.cbFactorType.Items.AddRange(new object[] {
            "保理商",
            "保险公司",
            "监管机构",
            "代付行"});
            this.cbFactorType.Location = new System.Drawing.Point(358, 25);
            this.cbFactorType.Name = "cbFactorType";
            this.cbFactorType.Size = new System.Drawing.Size(100, 21);
            this.cbFactorType.TabIndex = 1;
            // 
            // tbPostalCodePost
            // 
            this.tbPostalCodePost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "PostalCodePost", true));
            this.tbPostalCodePost.Location = new System.Drawing.Point(358, 116);
            this.tbPostalCodePost.Name = "tbPostalCodePost";
            this.tbPostalCodePost.Size = new System.Drawing.Size(100, 20);
            this.tbPostalCodePost.TabIndex = 7;
            // 
            // tbTelefax1
            // 
            this.tbTelefax1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Telefax_1", true));
            this.tbTelefax1.Location = new System.Drawing.Point(126, 213);
            this.tbTelefax1.Name = "tbTelefax1";
            this.tbTelefax1.Size = new System.Drawing.Size(100, 20);
            this.tbTelefax1.TabIndex = 10;
            // 
            // tbTelefax2
            // 
            this.tbTelefax2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Telefax_2", true));
            this.tbTelefax2.Location = new System.Drawing.Point(358, 207);
            this.tbTelefax2.Name = "tbTelefax2";
            this.tbTelefax2.Size = new System.Drawing.Size(100, 20);
            this.tbTelefax2.TabIndex = 13;
            // 
            // tbTelephone1
            // 
            this.tbTelephone1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Telephone_1", true));
            this.tbTelephone1.Location = new System.Drawing.Point(126, 182);
            this.tbTelephone1.Name = "tbTelephone1";
            this.tbTelephone1.Size = new System.Drawing.Size(100, 20);
            this.tbTelephone1.TabIndex = 9;
            // 
            // tbTelephone2
            // 
            this.tbTelephone2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "Telephone_2", true));
            this.tbTelephone2.Location = new System.Drawing.Point(358, 177);
            this.tbTelephone2.Name = "tbTelephone2";
            this.tbTelephone2.Size = new System.Drawing.Size(100, 20);
            this.tbTelephone2.TabIndex = 12;
            // 
            // tbVisitingAddress
            // 
            this.tbVisitingAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "VisitingAddress_1", true));
            this.tbVisitingAddress.Location = new System.Drawing.Point(126, 119);
            this.tbVisitingAddress.Name = "tbVisitingAddress";
            this.tbVisitingAddress.Size = new System.Drawing.Size(100, 20);
            this.tbVisitingAddress.TabIndex = 6;
            // 
            // tbWebSite
            // 
            this.tbWebSite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.factorBindingSource, "WebSite", true));
            this.tbWebSite.Location = new System.Drawing.Point(126, 243);
            this.tbWebSite.Name = "tbWebSite";
            this.tbWebSite.Size = new System.Drawing.Size(100, 20);
            this.tbWebSite.TabIndex = 14;
            // 
            // groupBoxCover
            // 
            this.groupBoxCover.Location = new System.Drawing.Point(12, 328);
            this.groupBoxCover.Name = "groupBoxCover";
            this.groupBoxCover.Size = new System.Drawing.Size(492, 148);
            this.groupBoxCover.TabIndex = 151;
            this.groupBoxCover.TabStop = false;
            this.groupBoxCover.Text = "额度信息";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(522, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // FactorDetailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 474);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxCover);
            this.Controls.Add(this.groupBoxFactor);
            this.Name = "FactorDetailUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "保理商详细信息";
            this.Load += new System.EventHandler(this.FactorDetailUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.factorBindingSource)).EndInit();
            this.groupBoxFactor.ResumeLayout(false);
            this.groupBoxFactor.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
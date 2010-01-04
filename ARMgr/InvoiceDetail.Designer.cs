namespace CMBC.EasyFactor.ARMgr
{
    partial class InvoiceDetail
    {
        #region Fields (33)

        private DevComponents.DotNetBar.Controls.TextBoxX assignAmountTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX assignDateTextBox;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX dueDateTextBox;
        private System.Windows.Forms.CheckedListBox flawReasonCheckedListBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput flawResolveDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX flawResolveReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX flawResolveUserNameTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceAmountTextBox;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput invoiceDateTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceNoTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceReferenceNumberTextBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX isFlawCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX isFlawCheckBox2;
        private DevComponents.DotNetBar.Controls.TextBoxX netPaymentTermsTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX orderNumberReferenceTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx paymentConditionsComboBox;
        private DevComponents.DotNetBar.Controls.TextBoxX primaryDiscountDaysTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX primaryDiscountRateTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX secondaryDiscountDaysTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX secondaryDiscountRateTextBox;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabItem tabItemFinance;
        private DevComponents.DotNetBar.TabItem tabItemFlaw;
        private DevComponents.DotNetBar.TabItem tabItemInvoice;
        private DevComponents.DotNetBar.TabItem tabItemPayment;
        private DevComponents.DotNetBar.TabControlPanel tabPanelFinance;
        private DevComponents.DotNetBar.TabControlPanel tabPanelFlaw;
        private DevComponents.DotNetBar.TabControlPanel tabPanelInvoice;
        private DevComponents.DotNetBar.TabControlPanel tabPanelPayment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFlawReason;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput valueDateTextBox;

        #endregion Fields

        #region Methods (1)

        // Protected Methods (1) 

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            DevComponents.DotNetBar.LabelX lblInvoiceBasicInfo;
            DevComponents.DotNetBar.LabelX invoiceNoLabel;
            DevComponents.DotNetBar.LabelX invoiceDateLabel;
            DevComponents.DotNetBar.LabelX invoiceAmountLabel;
            DevComponents.DotNetBar.LabelX dueDateLabel;
            DevComponents.DotNetBar.LabelX valueDateLabel;
            DevComponents.DotNetBar.LabelX assignAmountLabel;
            DevComponents.DotNetBar.LabelX assignDateLabel;
            DevComponents.DotNetBar.LabelX lblMoreInfo;
            DevComponents.DotNetBar.LabelX netPaymentTermsLabel;
            DevComponents.DotNetBar.LabelX primaryDiscountDaysLabel;
            DevComponents.DotNetBar.LabelX primaryDiscountRateLabel;
            DevComponents.DotNetBar.LabelX secondaryDiscountDaysLabel;
            DevComponents.DotNetBar.LabelX secondaryDiscountRateLabel;
            DevComponents.DotNetBar.LabelX paymentConditionsLabel;
            DevComponents.DotNetBar.LabelX orderNumberReferenceLabel;
            DevComponents.DotNetBar.LabelX invoiceReferenceNumberLabel;
            DevComponents.DotNetBar.LabelX flawReasonLabel;
            DevComponents.DotNetBar.LabelX labelX1;
            DevComponents.DotNetBar.LabelX labelX2;
            DevComponents.DotNetBar.LabelX flawResolveReasonLabel;
            DevComponents.DotNetBar.LabelX flawResolveDateLabel;
            DevComponents.DotNetBar.LabelX flawResolveUserNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetail));
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelFlaw = new DevComponents.DotNetBar.TabControlPanel();
            this.flawResolveUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flawResolveDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.flawResolveReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFlawReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.flawReasonCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.isFlawCheckBox2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tabItemFlaw = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelInvoice = new DevComponents.DotNetBar.TabControlPanel();
            this.btnInvoiceReset = new DevComponents.DotNetBar.ButtonX();
            this.btnInvoiceSave = new DevComponents.DotNetBar.ButtonX();
            this.btnInvoiceUpdate = new DevComponents.DotNetBar.ButtonX();
            this.invoiceReferenceNumberTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.orderNumberReferenceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.paymentConditionsComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.secondaryDiscountRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.secondaryDiscountDaysTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.primaryDiscountRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.primaryDiscountDaysTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.netPaymentTermsTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.isFlawCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.assignDateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.assignAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.valueDateTextBox = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dueDateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoiceAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoiceDateTextBox = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.invoiceNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemInvoice = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelFinance = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemFinance = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelPayment = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItemPayment = new DevComponents.DotNetBar.TabItem(this.components);
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            lblInvoiceBasicInfo = new DevComponents.DotNetBar.LabelX();
            invoiceNoLabel = new DevComponents.DotNetBar.LabelX();
            invoiceDateLabel = new DevComponents.DotNetBar.LabelX();
            invoiceAmountLabel = new DevComponents.DotNetBar.LabelX();
            dueDateLabel = new DevComponents.DotNetBar.LabelX();
            valueDateLabel = new DevComponents.DotNetBar.LabelX();
            assignAmountLabel = new DevComponents.DotNetBar.LabelX();
            assignDateLabel = new DevComponents.DotNetBar.LabelX();
            lblMoreInfo = new DevComponents.DotNetBar.LabelX();
            netPaymentTermsLabel = new DevComponents.DotNetBar.LabelX();
            primaryDiscountDaysLabel = new DevComponents.DotNetBar.LabelX();
            primaryDiscountRateLabel = new DevComponents.DotNetBar.LabelX();
            secondaryDiscountDaysLabel = new DevComponents.DotNetBar.LabelX();
            secondaryDiscountRateLabel = new DevComponents.DotNetBar.LabelX();
            paymentConditionsLabel = new DevComponents.DotNetBar.LabelX();
            orderNumberReferenceLabel = new DevComponents.DotNetBar.LabelX();
            invoiceReferenceNumberLabel = new DevComponents.DotNetBar.LabelX();
            flawReasonLabel = new DevComponents.DotNetBar.LabelX();
            labelX1 = new DevComponents.DotNetBar.LabelX();
            labelX2 = new DevComponents.DotNetBar.LabelX();
            flawResolveReasonLabel = new DevComponents.DotNetBar.LabelX();
            flawResolveDateLabel = new DevComponents.DotNetBar.LabelX();
            flawResolveUserNameLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanelFlaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flawResolveDateDateTimePicker)).BeginInit();
            this.tabPanelInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueDateTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDateTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoiceBasicInfo
            // 
            lblInvoiceBasicInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            lblInvoiceBasicInfo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblInvoiceBasicInfo.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            lblInvoiceBasicInfo.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Blue;
            lblInvoiceBasicInfo.BackgroundStyle.BorderBottomWidth = 2;
            lblInvoiceBasicInfo.BackgroundStyle.Class = "";
            lblInvoiceBasicInfo.Location = new System.Drawing.Point(0, 0);
            lblInvoiceBasicInfo.Name = "lblInvoiceBasicInfo";
            lblInvoiceBasicInfo.Size = new System.Drawing.Size(572, 23);
            lblInvoiceBasicInfo.TabIndex = 0;
            lblInvoiceBasicInfo.Text = "基本信息";
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceNoLabel.BackgroundStyle.Class = "";
            invoiceNoLabel.Location = new System.Drawing.Point(28, 40);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(47, 16);
            invoiceNoLabel.TabIndex = 1;
            invoiceNoLabel.Text = "发票号:";
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceDateLabel.BackgroundStyle.Class = "";
            invoiceDateLabel.Location = new System.Drawing.Point(215, 40);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(47, 16);
            invoiceDateLabel.TabIndex = 3;
            invoiceDateLabel.Text = "发票日:";
            // 
            // invoiceAmountLabel
            // 
            invoiceAmountLabel.AutoSize = true;
            invoiceAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceAmountLabel.BackgroundStyle.Class = "";
            invoiceAmountLabel.Location = new System.Drawing.Point(16, 66);
            invoiceAmountLabel.Name = "invoiceAmountLabel";
            invoiceAmountLabel.Size = new System.Drawing.Size(59, 16);
            invoiceAmountLabel.TabIndex = 5;
            invoiceAmountLabel.Text = "票面金额:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            dueDateLabel.BackgroundStyle.Class = "";
            dueDateLabel.Location = new System.Drawing.Point(215, 66);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(47, 16);
            dueDateLabel.TabIndex = 7;
            dueDateLabel.Text = "到期日:";
            // 
            // valueDateLabel
            // 
            valueDateLabel.AutoSize = true;
            valueDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            valueDateLabel.BackgroundStyle.Class = "";
            valueDateLabel.Location = new System.Drawing.Point(414, 64);
            valueDateLabel.Name = "valueDateLabel";
            valueDateLabel.Size = new System.Drawing.Size(47, 16);
            valueDateLabel.TabIndex = 9;
            valueDateLabel.Text = "生效日:";
            // 
            // assignAmountLabel
            // 
            assignAmountLabel.AutoSize = true;
            assignAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            assignAmountLabel.BackgroundStyle.Class = "";
            assignAmountLabel.Location = new System.Drawing.Point(16, 89);
            assignAmountLabel.Name = "assignAmountLabel";
            assignAmountLabel.Size = new System.Drawing.Size(59, 16);
            assignAmountLabel.TabIndex = 11;
            assignAmountLabel.Text = "转让金额:";
            // 
            // assignDateLabel
            // 
            assignDateLabel.AutoSize = true;
            assignDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            assignDateLabel.BackgroundStyle.Class = "";
            assignDateLabel.Location = new System.Drawing.Point(215, 87);
            assignDateLabel.Name = "assignDateLabel";
            assignDateLabel.Size = new System.Drawing.Size(47, 16);
            assignDateLabel.TabIndex = 13;
            assignDateLabel.Text = "转让日:";
            // 
            // lblMoreInfo
            // 
            lblMoreInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            lblMoreInfo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblMoreInfo.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            lblMoreInfo.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Blue;
            lblMoreInfo.BackgroundStyle.BorderBottomWidth = 2;
            lblMoreInfo.BackgroundStyle.Class = "";
            lblMoreInfo.Location = new System.Drawing.Point(0, 118);
            lblMoreInfo.Name = "lblMoreInfo";
            lblMoreInfo.Size = new System.Drawing.Size(572, 23);
            lblMoreInfo.TabIndex = 17;
            lblMoreInfo.Text = "附加信息";
            // 
            // netPaymentTermsLabel
            // 
            netPaymentTermsLabel.AutoSize = true;
            netPaymentTermsLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            netPaymentTermsLabel.BackgroundStyle.Class = "";
            netPaymentTermsLabel.Location = new System.Drawing.Point(12, 154);
            netPaymentTermsLabel.Name = "netPaymentTermsLabel";
            netPaymentTermsLabel.Size = new System.Drawing.Size(110, 16);
            netPaymentTermsLabel.TabIndex = 18;
            netPaymentTermsLabel.Text = "Net Payment Terms:";
            // 
            // primaryDiscountDaysLabel
            // 
            primaryDiscountDaysLabel.AutoSize = true;
            primaryDiscountDaysLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            primaryDiscountDaysLabel.BackgroundStyle.Class = "";
            primaryDiscountDaysLabel.Location = new System.Drawing.Point(28, 183);
            primaryDiscountDaysLabel.Name = "primaryDiscountDaysLabel";
            primaryDiscountDaysLabel.Size = new System.Drawing.Size(124, 16);
            primaryDiscountDaysLabel.TabIndex = 20;
            primaryDiscountDaysLabel.Text = "Primary Discount Days:";
            // 
            // primaryDiscountRateLabel
            // 
            primaryDiscountRateLabel.AutoSize = true;
            primaryDiscountRateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            primaryDiscountRateLabel.BackgroundStyle.Class = "";
            primaryDiscountRateLabel.Location = new System.Drawing.Point(311, 183);
            primaryDiscountRateLabel.Name = "primaryDiscountRateLabel";
            primaryDiscountRateLabel.Size = new System.Drawing.Size(122, 16);
            primaryDiscountRateLabel.TabIndex = 22;
            primaryDiscountRateLabel.Text = "Primary Discount Rate:";
            // 
            // secondaryDiscountDaysLabel
            // 
            secondaryDiscountDaysLabel.AutoSize = true;
            secondaryDiscountDaysLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            secondaryDiscountDaysLabel.BackgroundStyle.Class = "";
            secondaryDiscountDaysLabel.Location = new System.Drawing.Point(13, 206);
            secondaryDiscountDaysLabel.Name = "secondaryDiscountDaysLabel";
            secondaryDiscountDaysLabel.Size = new System.Drawing.Size(139, 16);
            secondaryDiscountDaysLabel.TabIndex = 24;
            secondaryDiscountDaysLabel.Text = "Secondary Discount Days:";
            // 
            // secondaryDiscountRateLabel
            // 
            secondaryDiscountRateLabel.AutoSize = true;
            secondaryDiscountRateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            secondaryDiscountRateLabel.BackgroundStyle.Class = "";
            secondaryDiscountRateLabel.Location = new System.Drawing.Point(294, 206);
            secondaryDiscountRateLabel.Name = "secondaryDiscountRateLabel";
            secondaryDiscountRateLabel.Size = new System.Drawing.Size(138, 16);
            secondaryDiscountRateLabel.TabIndex = 26;
            secondaryDiscountRateLabel.Text = "Secondary Discount Rate:";
            // 
            // paymentConditionsLabel
            // 
            paymentConditionsLabel.AutoSize = true;
            paymentConditionsLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            paymentConditionsLabel.BackgroundStyle.Class = "";
            paymentConditionsLabel.Location = new System.Drawing.Point(43, 233);
            paymentConditionsLabel.Name = "paymentConditionsLabel";
            paymentConditionsLabel.Size = new System.Drawing.Size(111, 16);
            paymentConditionsLabel.TabIndex = 28;
            paymentConditionsLabel.Text = "Payment Conditions:";
            // 
            // orderNumberReferenceLabel
            // 
            orderNumberReferenceLabel.AutoSize = true;
            orderNumberReferenceLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            orderNumberReferenceLabel.BackgroundStyle.Class = "";
            orderNumberReferenceLabel.Location = new System.Drawing.Point(17, 257);
            orderNumberReferenceLabel.Name = "orderNumberReferenceLabel";
            orderNumberReferenceLabel.Size = new System.Drawing.Size(137, 16);
            orderNumberReferenceLabel.TabIndex = 30;
            orderNumberReferenceLabel.Text = "Order Number Reference:";
            // 
            // invoiceReferenceNumberLabel
            // 
            invoiceReferenceNumberLabel.AutoSize = true;
            invoiceReferenceNumberLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceReferenceNumberLabel.BackgroundStyle.Class = "";
            invoiceReferenceNumberLabel.Location = new System.Drawing.Point(8, 279);
            invoiceReferenceNumberLabel.Name = "invoiceReferenceNumberLabel";
            invoiceReferenceNumberLabel.Size = new System.Drawing.Size(144, 16);
            invoiceReferenceNumberLabel.TabIndex = 32;
            invoiceReferenceNumberLabel.Text = "Invoice Reference Number:";
            // 
            // flawReasonLabel
            // 
            flawReasonLabel.AutoSize = true;
            flawReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            flawReasonLabel.BackgroundStyle.Class = "";
            flawReasonLabel.Location = new System.Drawing.Point(112, 30);
            flawReasonLabel.Name = "flawReasonLabel";
            flawReasonLabel.Size = new System.Drawing.Size(59, 16);
            flawReasonLabel.TabIndex = 17;
            flawReasonLabel.Text = "瑕疵原因:";
            // 
            // labelX1
            // 
            labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            labelX1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            labelX1.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Blue;
            labelX1.BackgroundStyle.BorderBottomWidth = 2;
            labelX1.BackgroundStyle.Class = "";
            labelX1.Location = new System.Drawing.Point(0, 0);
            labelX1.Name = "labelX1";
            labelX1.Size = new System.Drawing.Size(572, 23);
            labelX1.TabIndex = 20;
            labelX1.Text = "瑕疵设定";
            // 
            // labelX2
            // 
            labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            labelX2.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            labelX2.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Blue;
            labelX2.BackgroundStyle.BorderBottomWidth = 2;
            labelX2.BackgroundStyle.Class = "";
            labelX2.Location = new System.Drawing.Point(0, 129);
            labelX2.Name = "labelX2";
            labelX2.Size = new System.Drawing.Size(572, 23);
            labelX2.TabIndex = 21;
            labelX2.Text = "瑕疵解除";
            // 
            // flawResolveReasonLabel
            // 
            flawResolveReasonLabel.AutoSize = true;
            flawResolveReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            flawResolveReasonLabel.BackgroundStyle.Class = "";
            flawResolveReasonLabel.Location = new System.Drawing.Point(12, 166);
            flawResolveReasonLabel.Name = "flawResolveReasonLabel";
            flawResolveReasonLabel.Size = new System.Drawing.Size(59, 16);
            flawResolveReasonLabel.TabIndex = 21;
            flawResolveReasonLabel.Text = "解除原因:";
            // 
            // flawResolveDateLabel
            // 
            flawResolveDateLabel.AutoSize = true;
            flawResolveDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            flawResolveDateLabel.BackgroundStyle.Class = "";
            flawResolveDateLabel.Location = new System.Drawing.Point(376, 164);
            flawResolveDateLabel.Name = "flawResolveDateLabel";
            flawResolveDateLabel.Size = new System.Drawing.Size(47, 16);
            flawResolveDateLabel.TabIndex = 22;
            flawResolveDateLabel.Text = "解除日:";
            // 
            // flawResolveUserNameLabel
            // 
            flawResolveUserNameLabel.AutoSize = true;
            flawResolveUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            flawResolveUserNameLabel.BackgroundStyle.Class = "";
            flawResolveUserNameLabel.Location = new System.Drawing.Point(376, 189);
            flawResolveUserNameLabel.Name = "flawResolveUserNameLabel";
            flawResolveUserNameLabel.Size = new System.Drawing.Size(47, 16);
            flawResolveUserNameLabel.TabIndex = 23;
            flawResolveUserNameLabel.Text = "经办人:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabPanelInvoice);
            this.tabControl.Controls.Add(this.tabPanelFlaw);
            this.tabControl.Controls.Add(this.tabPanelFinance);
            this.tabControl.Controls.Add(this.tabPanelPayment);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(572, 394);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemInvoice);
            this.tabControl.Tabs.Add(this.tabItemFlaw);
            this.tabControl.Tabs.Add(this.tabItemFinance);
            this.tabControl.Tabs.Add(this.tabItemPayment);
            // 
            // tabPanelFlaw
            // 
            this.tabPanelFlaw.AutoScroll = true;
            this.tabPanelFlaw.Controls.Add(flawResolveUserNameLabel);
            this.tabPanelFlaw.Controls.Add(this.flawResolveUserNameTextBox);
            this.tabPanelFlaw.Controls.Add(flawResolveDateLabel);
            this.tabPanelFlaw.Controls.Add(this.flawResolveDateDateTimePicker);
            this.tabPanelFlaw.Controls.Add(flawResolveReasonLabel);
            this.tabPanelFlaw.Controls.Add(this.flawResolveReasonTextBox);
            this.tabPanelFlaw.Controls.Add(labelX2);
            this.tabPanelFlaw.Controls.Add(labelX1);
            this.tabPanelFlaw.Controls.Add(this.tbFlawReason);
            this.tabPanelFlaw.Controls.Add(flawReasonLabel);
            this.tabPanelFlaw.Controls.Add(this.flawReasonCheckedListBox);
            this.tabPanelFlaw.Controls.Add(this.isFlawCheckBox2);
            this.tabPanelFlaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelFlaw.Location = new System.Drawing.Point(0, 26);
            this.tabPanelFlaw.Name = "tabPanelFlaw";
            this.tabPanelFlaw.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelFlaw.Size = new System.Drawing.Size(572, 368);
            this.tabPanelFlaw.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelFlaw.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelFlaw.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelFlaw.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelFlaw.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelFlaw.Style.GradientAngle = 90;
            this.tabPanelFlaw.TabIndex = 4;
            this.tabPanelFlaw.TabItem = this.tabItemFlaw;
            // 
            // flawResolveUserNameTextBox
            // 
            // 
            // 
            // 
            this.flawResolveUserNameTextBox.Border.Class = "TextBoxBorder";
            this.flawResolveUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FlawResolveUserName", true));
            this.flawResolveUserNameTextBox.Location = new System.Drawing.Point(428, 186);
            this.flawResolveUserNameTextBox.Name = "flawResolveUserNameTextBox";
            this.flawResolveUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.flawResolveUserNameTextBox.TabIndex = 24;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Invoice);
            // 
            // flawResolveDateDateTimePicker
            // 
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.flawResolveDateDateTimePicker.ButtonDropDown.Visible = true;
            this.flawResolveDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "FlawResolveDate", true));
            this.flawResolveDateDateTimePicker.Location = new System.Drawing.Point(428, 160);
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.flawResolveDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.flawResolveDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.flawResolveDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.flawResolveDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.flawResolveDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.flawResolveDateDateTimePicker.Name = "flawResolveDateDateTimePicker";
            this.flawResolveDateDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.flawResolveDateDateTimePicker.TabIndex = 23;
            // 
            // flawResolveReasonTextBox
            // 
            // 
            // 
            // 
            this.flawResolveReasonTextBox.Border.Class = "TextBoxBorder";
            this.flawResolveReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FlawResolveReason", true));
            this.flawResolveReasonTextBox.Location = new System.Drawing.Point(76, 163);
            this.flawResolveReasonTextBox.Multiline = true;
            this.flawResolveReasonTextBox.Name = "flawResolveReasonTextBox";
            this.flawResolveReasonTextBox.Size = new System.Drawing.Size(256, 38);
            this.flawResolveReasonTextBox.TabIndex = 22;
            // 
            // tbFlawReason
            // 
            // 
            // 
            // 
            this.tbFlawReason.Border.Class = "TextBoxBorder";
            this.tbFlawReason.Location = new System.Drawing.Point(376, 29);
            this.tbFlawReason.Multiline = true;
            this.tbFlawReason.Name = "tbFlawReason";
            this.tbFlawReason.Size = new System.Drawing.Size(170, 94);
            this.tbFlawReason.TabIndex = 19;
            // 
            // flawReasonCheckedListBox
            // 
            this.flawReasonCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceBindingSource, "FlawReason", true));
            this.flawReasonCheckedListBox.FormattingEnabled = true;
            this.flawReasonCheckedListBox.Items.AddRange(new object[] {
            "卖方/买方基本资料不符",
            "发票为存根联或副联复印件",
            "发票无转让字据记载或贴错",
            "账款到期日不符",
            "单据内容不符",
            "额度通知书过期或未签回",
            "保理主合同过期或未签回",
            "交货凭证内容不完整",
            "其他"});
            this.flawReasonCheckedListBox.Location = new System.Drawing.Point(177, 29);
            this.flawReasonCheckedListBox.Name = "flawReasonCheckedListBox";
            this.flawReasonCheckedListBox.Size = new System.Drawing.Size(193, 94);
            this.flawReasonCheckedListBox.TabIndex = 18;
            // 
            // isFlawCheckBox2
            // 
            this.isFlawCheckBox2.AutoSize = true;
            this.isFlawCheckBox2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isFlawCheckBox2.BackgroundStyle.Class = "";
            this.isFlawCheckBox2.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "IsFlaw", true));
            this.isFlawCheckBox2.Location = new System.Drawing.Point(30, 31);
            this.isFlawCheckBox2.Name = "isFlawCheckBox2";
            this.isFlawCheckBox2.Size = new System.Drawing.Size(76, 16);
            this.isFlawCheckBox2.TabIndex = 17;
            this.isFlawCheckBox2.Text = "是否瑕疵";
            // 
            // tabItemFlaw
            // 
            this.tabItemFlaw.AttachedControl = this.tabPanelFlaw;
            this.tabItemFlaw.Name = "tabItemFlaw";
            this.tabItemFlaw.Text = "瑕疵处理";
            // 
            // tabPanelInvoice
            // 
            this.tabPanelInvoice.AutoScroll = true;
            this.tabPanelInvoice.Controls.Add(this.btnInvoiceReset);
            this.tabPanelInvoice.Controls.Add(this.btnInvoiceSave);
            this.tabPanelInvoice.Controls.Add(this.btnInvoiceUpdate);
            this.tabPanelInvoice.Controls.Add(invoiceReferenceNumberLabel);
            this.tabPanelInvoice.Controls.Add(this.invoiceReferenceNumberTextBox);
            this.tabPanelInvoice.Controls.Add(orderNumberReferenceLabel);
            this.tabPanelInvoice.Controls.Add(this.orderNumberReferenceTextBox);
            this.tabPanelInvoice.Controls.Add(paymentConditionsLabel);
            this.tabPanelInvoice.Controls.Add(this.paymentConditionsComboBox);
            this.tabPanelInvoice.Controls.Add(secondaryDiscountRateLabel);
            this.tabPanelInvoice.Controls.Add(this.secondaryDiscountRateTextBox);
            this.tabPanelInvoice.Controls.Add(secondaryDiscountDaysLabel);
            this.tabPanelInvoice.Controls.Add(this.secondaryDiscountDaysTextBox);
            this.tabPanelInvoice.Controls.Add(primaryDiscountRateLabel);
            this.tabPanelInvoice.Controls.Add(this.primaryDiscountRateTextBox);
            this.tabPanelInvoice.Controls.Add(primaryDiscountDaysLabel);
            this.tabPanelInvoice.Controls.Add(this.primaryDiscountDaysTextBox);
            this.tabPanelInvoice.Controls.Add(netPaymentTermsLabel);
            this.tabPanelInvoice.Controls.Add(this.netPaymentTermsTextBox);
            this.tabPanelInvoice.Controls.Add(lblMoreInfo);
            this.tabPanelInvoice.Controls.Add(this.isFlawCheckBox);
            this.tabPanelInvoice.Controls.Add(assignDateLabel);
            this.tabPanelInvoice.Controls.Add(this.assignDateTextBox);
            this.tabPanelInvoice.Controls.Add(assignAmountLabel);
            this.tabPanelInvoice.Controls.Add(this.assignAmountTextBox);
            this.tabPanelInvoice.Controls.Add(valueDateLabel);
            this.tabPanelInvoice.Controls.Add(this.valueDateTextBox);
            this.tabPanelInvoice.Controls.Add(dueDateLabel);
            this.tabPanelInvoice.Controls.Add(this.dueDateTextBox);
            this.tabPanelInvoice.Controls.Add(invoiceAmountLabel);
            this.tabPanelInvoice.Controls.Add(this.invoiceAmountTextBox);
            this.tabPanelInvoice.Controls.Add(invoiceDateLabel);
            this.tabPanelInvoice.Controls.Add(this.invoiceDateTextBox);
            this.tabPanelInvoice.Controls.Add(invoiceNoLabel);
            this.tabPanelInvoice.Controls.Add(this.invoiceNoTextBox);
            this.tabPanelInvoice.Controls.Add(lblInvoiceBasicInfo);
            this.tabPanelInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelInvoice.Location = new System.Drawing.Point(0, 26);
            this.tabPanelInvoice.Name = "tabPanelInvoice";
            this.tabPanelInvoice.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelInvoice.Size = new System.Drawing.Size(572, 368);
            this.tabPanelInvoice.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelInvoice.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelInvoice.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelInvoice.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelInvoice.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelInvoice.Style.GradientAngle = 90;
            this.tabPanelInvoice.TabIndex = 1;
            this.tabPanelInvoice.TabItem = this.tabItemInvoice;
            // 
            // btnInvoiceReset
            // 
            this.btnInvoiceReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInvoiceReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInvoiceReset.Location = new System.Drawing.Point(339, 333);
            this.btnInvoiceReset.Name = "btnInvoiceReset";
            this.btnInvoiceReset.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInvoiceReset.TabIndex = 36;
            this.btnInvoiceReset.Text = "重置";
            this.btnInvoiceReset.Click += new System.EventHandler(this.ResetInvoice);
            // 
            // btnInvoiceSave
            // 
            this.btnInvoiceSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInvoiceSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInvoiceSave.Location = new System.Drawing.Point(258, 333);
            this.btnInvoiceSave.Name = "btnInvoiceSave";
            this.btnInvoiceSave.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInvoiceSave.TabIndex = 35;
            this.btnInvoiceSave.Text = "保存";
            this.btnInvoiceSave.Click += new System.EventHandler(this.SaveInvoice);
            // 
            // btnInvoiceUpdate
            // 
            this.btnInvoiceUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInvoiceUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInvoiceUpdate.Location = new System.Drawing.Point(177, 333);
            this.btnInvoiceUpdate.Name = "btnInvoiceUpdate";
            this.btnInvoiceUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInvoiceUpdate.TabIndex = 34;
            this.btnInvoiceUpdate.Text = "编辑";
            this.btnInvoiceUpdate.Click += new System.EventHandler(this.UpdateInvoice);
            // 
            // invoiceReferenceNumberTextBox
            // 
            // 
            // 
            // 
            this.invoiceReferenceNumberTextBox.Border.Class = "TextBoxBorder";
            this.invoiceReferenceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceReferenceNumber", true));
            this.invoiceReferenceNumberTextBox.Location = new System.Drawing.Point(152, 276);
            this.invoiceReferenceNumberTextBox.Name = "invoiceReferenceNumberTextBox";
            this.invoiceReferenceNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceReferenceNumberTextBox.TabIndex = 33;
            // 
            // orderNumberReferenceTextBox
            // 
            // 
            // 
            // 
            this.orderNumberReferenceTextBox.Border.Class = "TextBoxBorder";
            this.orderNumberReferenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "OrderNumberReference", true));
            this.orderNumberReferenceTextBox.Location = new System.Drawing.Point(152, 254);
            this.orderNumberReferenceTextBox.Name = "orderNumberReferenceTextBox";
            this.orderNumberReferenceTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderNumberReferenceTextBox.TabIndex = 31;
            // 
            // paymentConditionsComboBox
            // 
            this.paymentConditionsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PaymentConditions", true));
            this.paymentConditionsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paymentConditionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentConditionsComboBox.FormattingEnabled = true;
            this.paymentConditionsComboBox.Location = new System.Drawing.Point(152, 230);
            this.paymentConditionsComboBox.Name = "paymentConditionsComboBox";
            this.paymentConditionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.paymentConditionsComboBox.TabIndex = 29;
            // 
            // secondaryDiscountRateTextBox
            // 
            // 
            // 
            // 
            this.secondaryDiscountRateTextBox.Border.Class = "TextBoxBorder";
            this.secondaryDiscountRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "SecondaryDiscountRate", true));
            this.secondaryDiscountRateTextBox.Location = new System.Drawing.Point(432, 203);
            this.secondaryDiscountRateTextBox.Name = "secondaryDiscountRateTextBox";
            this.secondaryDiscountRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondaryDiscountRateTextBox.TabIndex = 27;
            // 
            // secondaryDiscountDaysTextBox
            // 
            // 
            // 
            // 
            this.secondaryDiscountDaysTextBox.Border.Class = "TextBoxBorder";
            this.secondaryDiscountDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "SecondaryDiscountDays", true));
            this.secondaryDiscountDaysTextBox.Location = new System.Drawing.Point(152, 203);
            this.secondaryDiscountDaysTextBox.Name = "secondaryDiscountDaysTextBox";
            this.secondaryDiscountDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondaryDiscountDaysTextBox.TabIndex = 25;
            // 
            // primaryDiscountRateTextBox
            // 
            // 
            // 
            // 
            this.primaryDiscountRateTextBox.Border.Class = "TextBoxBorder";
            this.primaryDiscountRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PrimaryDiscountRate", true));
            this.primaryDiscountRateTextBox.Location = new System.Drawing.Point(432, 180);
            this.primaryDiscountRateTextBox.Name = "primaryDiscountRateTextBox";
            this.primaryDiscountRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryDiscountRateTextBox.TabIndex = 23;
            // 
            // primaryDiscountDaysTextBox
            // 
            // 
            // 
            // 
            this.primaryDiscountDaysTextBox.Border.Class = "TextBoxBorder";
            this.primaryDiscountDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PrimaryDiscountDays", true));
            this.primaryDiscountDaysTextBox.Location = new System.Drawing.Point(150, 180);
            this.primaryDiscountDaysTextBox.Name = "primaryDiscountDaysTextBox";
            this.primaryDiscountDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryDiscountDaysTextBox.TabIndex = 21;
            // 
            // netPaymentTermsTextBox
            // 
            // 
            // 
            // 
            this.netPaymentTermsTextBox.Border.Class = "TextBoxBorder";
            this.netPaymentTermsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "NetPaymentTerms", true));
            this.netPaymentTermsTextBox.Location = new System.Drawing.Point(123, 151);
            this.netPaymentTermsTextBox.Name = "netPaymentTermsTextBox";
            this.netPaymentTermsTextBox.Size = new System.Drawing.Size(444, 20);
            this.netPaymentTermsTextBox.TabIndex = 19;
            // 
            // isFlawCheckBox
            // 
            this.isFlawCheckBox.AutoSize = true;
            this.isFlawCheckBox.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isFlawCheckBox.BackgroundStyle.Class = "";
            this.isFlawCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "IsFlaw", true));
            this.isFlawCheckBox.Location = new System.Drawing.Point(414, 88);
            this.isFlawCheckBox.Name = "isFlawCheckBox";
            this.isFlawCheckBox.Size = new System.Drawing.Size(76, 16);
            this.isFlawCheckBox.TabIndex = 16;
            this.isFlawCheckBox.Text = "是否瑕疵";
            // 
            // assignDateTextBox
            // 
            // 
            // 
            // 
            this.assignDateTextBox.Border.Class = "TextBoxBorder";
            this.assignDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "AssignDate", true));
            this.assignDateTextBox.Location = new System.Drawing.Point(277, 86);
            this.assignDateTextBox.Name = "assignDateTextBox";
            this.assignDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.assignDateTextBox.TabIndex = 14;
            // 
            // assignAmountTextBox
            // 
            // 
            // 
            // 
            this.assignAmountTextBox.Border.Class = "TextBoxBorder";
            this.assignAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "AssignAmount", true));
            this.assignAmountTextBox.Location = new System.Drawing.Point(81, 86);
            this.assignAmountTextBox.Name = "assignAmountTextBox";
            this.assignAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.assignAmountTextBox.TabIndex = 12;
            // 
            // valueDateTextBox
            // 
            // 
            // 
            // 
            this.valueDateTextBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.valueDateTextBox.ButtonDropDown.Visible = true;
            this.valueDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "ValueDate", true));
            this.valueDateTextBox.Location = new System.Drawing.Point(467, 63);
            // 
            // 
            // 
            this.valueDateTextBox.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.valueDateTextBox.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.valueDateTextBox.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.valueDateTextBox.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.valueDateTextBox.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.valueDateTextBox.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.valueDateTextBox.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.valueDateTextBox.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.valueDateTextBox.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.valueDateTextBox.Name = "valueDateTextBox";
            this.valueDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.valueDateTextBox.TabIndex = 10;
            // 
            // dueDateTextBox
            // 
            // 
            // 
            // 
            this.dueDateTextBox.Border.Class = "TextBoxBorder";
            this.dueDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DueDate", true));
            this.dueDateTextBox.Location = new System.Drawing.Point(277, 63);
            this.dueDateTextBox.Name = "dueDateTextBox";
            this.dueDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dueDateTextBox.TabIndex = 8;
            // 
            // invoiceAmountTextBox
            // 
            // 
            // 
            // 
            this.invoiceAmountTextBox.Border.Class = "TextBoxBorder";
            this.invoiceAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceAmount", true));
            this.invoiceAmountTextBox.Location = new System.Drawing.Point(81, 63);
            this.invoiceAmountTextBox.Name = "invoiceAmountTextBox";
            this.invoiceAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceAmountTextBox.TabIndex = 6;
            // 
            // invoiceDateTextBox
            // 
            // 
            // 
            // 
            this.invoiceDateTextBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.invoiceDateTextBox.ButtonDropDown.Visible = true;
            this.invoiceDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceDate", true));
            this.invoiceDateTextBox.Location = new System.Drawing.Point(277, 39);
            // 
            // 
            // 
            this.invoiceDateTextBox.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.invoiceDateTextBox.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.invoiceDateTextBox.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.invoiceDateTextBox.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.invoiceDateTextBox.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.invoiceDateTextBox.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.invoiceDateTextBox.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.invoiceDateTextBox.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.invoiceDateTextBox.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.invoiceDateTextBox.Name = "invoiceDateTextBox";
            this.invoiceDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceDateTextBox.TabIndex = 4;
            // 
            // invoiceNoTextBox
            // 
            // 
            // 
            // 
            this.invoiceNoTextBox.Border.Class = "TextBoxBorder";
            this.invoiceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceNo", true));
            this.invoiceNoTextBox.Location = new System.Drawing.Point(81, 39);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceNoTextBox.TabIndex = 2;
            // 
            // tabItemInvoice
            // 
            this.tabItemInvoice.AttachedControl = this.tabPanelInvoice;
            this.tabItemInvoice.Name = "tabItemInvoice";
            this.tabItemInvoice.Text = "发票明细";
            // 
            // tabPanelFinance
            // 
            this.tabPanelFinance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelFinance.Location = new System.Drawing.Point(0, 26);
            this.tabPanelFinance.Name = "tabPanelFinance";
            this.tabPanelFinance.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelFinance.Size = new System.Drawing.Size(572, 368);
            this.tabPanelFinance.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelFinance.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelFinance.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelFinance.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelFinance.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelFinance.Style.GradientAngle = 90;
            this.tabPanelFinance.TabIndex = 2;
            this.tabPanelFinance.TabItem = this.tabItemFinance;
            // 
            // tabItemFinance
            // 
            this.tabItemFinance.AttachedControl = this.tabPanelFinance;
            this.tabItemFinance.Name = "tabItemFinance";
            this.tabItemFinance.Text = "融资明细";
            // 
            // tabPanelPayment
            // 
            this.tabPanelPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelPayment.Location = new System.Drawing.Point(0, 26);
            this.tabPanelPayment.Name = "tabPanelPayment";
            this.tabPanelPayment.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelPayment.Size = new System.Drawing.Size(572, 368);
            this.tabPanelPayment.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelPayment.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelPayment.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelPayment.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelPayment.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelPayment.Style.GradientAngle = 90;
            this.tabPanelPayment.TabIndex = 3;
            this.tabPanelPayment.TabItem = this.tabItemPayment;
            // 
            // tabItemPayment
            // 
            this.tabItemPayment.AttachedControl = this.tabPanelPayment;
            this.tabItemPayment.Name = "tabItemPayment";
            this.tabItemPayment.Text = "还款明细";
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
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 394);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Name = "InvoiceDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "发票详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPanelFlaw.ResumeLayout(false);
            this.tabPanelFlaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flawResolveDateDateTimePicker)).EndInit();
            this.tabPanelInvoice.ResumeLayout(false);
            this.tabPanelInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueDateTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDateTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnInvoiceReset;
        private DevComponents.DotNetBar.ButtonX btnInvoiceSave;
        private DevComponents.DotNetBar.ButtonX btnInvoiceUpdate;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
    }
}
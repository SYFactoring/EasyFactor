﻿namespace CMBC.EasyFactor.ARMgr
{
    partial class InvoiceDetail
    {
        #region Fields (68)

        private DevComponents.DotNetBar.Controls.TextBoxX assignAmountTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput assignDateTextBox;
        private DevComponents.DotNetBar.ButtonX btnInvoiceReset;
        private DevComponents.DotNetBar.ButtonX btnInvoiceSave;
        private DevComponents.DotNetBar.ButtonX btnInvoiceUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput commissionDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX commissionTextBox;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX disputeAmountTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput disputeDateDateTimePicker;
        private System.Windows.Forms.CheckedListBox disputeReasonCheckedListBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput disputeResolveDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX disputeResolveReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX disputeResolveUserNameTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx disputeTypeComboBoxEx;
        private DevComponents.DotNetBar.Controls.TextBoxX disputeUserNameTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dueDateTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Controls.TextBoxX financeAmountTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financeDateDateTimePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financeDueDateDateTimePicker;
        private System.Windows.Forms.CheckedListBox flawReasonCheckedListBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput flawResolveDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX flawResolveReasonTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX flawResolveUserNameTextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelDispute;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelDisputeResolve;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelFlaw;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelFlawResolve;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelInvoiceAdv;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelInvoiceBasic;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelInvoiceProcess;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput interestDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX interestTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceAmountTextBox;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx invoiceCurrencyComboBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput invoiceDateTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceNoTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceReferenceNumberTextBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX isDisputeCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX isFlawCheckBox;
        private DevComponents.DotNetBar.Controls.TextBoxX netPaymentTermsTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX orderNumberReferenceTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX paymentAmountTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx paymentConditionsComboBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput paymentDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX primaryDiscountDaysTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX primaryDiscountRateTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX refundAmountTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput refundDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX secondaryDiscountDaysTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX secondaryDiscountRateTextBox;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanelDispute;
        private DevComponents.DotNetBar.TabItem tabItemDispute;
        private DevComponents.DotNetBar.TabItem tabItemEDI;
        private DevComponents.DotNetBar.TabItem tabItemFlaw;
        private DevComponents.DotNetBar.TabItem tabItemInvoice;
        private DevComponents.DotNetBar.TabControlPanel tabPanelEDI;
        private DevComponents.DotNetBar.TabControlPanel tabPanelFlaw;
        private DevComponents.DotNetBar.TabControlPanel tabPanelInvoice;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDisputeReason;
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
            DevComponents.DotNetBar.LabelX flawResolveReasonLabel;
            DevComponents.DotNetBar.LabelX flawResolveDateLabel;
            DevComponents.DotNetBar.LabelX flawResolveUserNameLabel;
            DevComponents.DotNetBar.LabelX assignDateLabel;
            DevComponents.DotNetBar.LabelX assignAmountLabel;
            DevComponents.DotNetBar.LabelX dueDateLabel;
            DevComponents.DotNetBar.LabelX invoiceAmountLabel;
            DevComponents.DotNetBar.LabelX invoiceDateLabel;
            DevComponents.DotNetBar.LabelX invoiceNoLabel;
            DevComponents.DotNetBar.LabelX flawReasonLabel;
            DevComponents.DotNetBar.LabelX invoiceReferenceNumberLabel;
            DevComponents.DotNetBar.LabelX orderNumberReferenceLabel;
            DevComponents.DotNetBar.LabelX paymentConditionsLabel;
            DevComponents.DotNetBar.LabelX valueDateLabel;
            DevComponents.DotNetBar.LabelX secondaryDiscountRateLabel;
            DevComponents.DotNetBar.LabelX secondaryDiscountDaysLabel;
            DevComponents.DotNetBar.LabelX primaryDiscountRateLabel;
            DevComponents.DotNetBar.LabelX primaryDiscountDaysLabel;
            DevComponents.DotNetBar.LabelX netPaymentTermsLabel;
            DevComponents.DotNetBar.LabelX invoiceCurrencyLabel;
            DevComponents.DotNetBar.LabelX financeAmountLabel;
            DevComponents.DotNetBar.LabelX financeDateLabel;
            DevComponents.DotNetBar.LabelX financeDueDateLabel;
            DevComponents.DotNetBar.LabelX paymentAmountLabel;
            DevComponents.DotNetBar.LabelX paymentDateLabel;
            DevComponents.DotNetBar.LabelX refundAmountLabel;
            DevComponents.DotNetBar.LabelX refundDateLabel;
            DevComponents.DotNetBar.LabelX commissionLabel;
            DevComponents.DotNetBar.LabelX commissionDateLabel;
            DevComponents.DotNetBar.LabelX interestLabel;
            DevComponents.DotNetBar.LabelX interestDateLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX disputeReasonLabel;
            DevComponents.DotNetBar.LabelX disputeDateLabel;
            DevComponents.DotNetBar.LabelX disputeResolveReasonLabel;
            DevComponents.DotNetBar.LabelX disputeResolveUserNameLabel;
            DevComponents.DotNetBar.LabelX disputeTypeLabel;
            DevComponents.DotNetBar.LabelX disputeUserNameLabel;
            DevComponents.DotNetBar.LabelX disputeAmountLabel;
            DevComponents.DotNetBar.LabelX disputeResolveDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetail));
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelInvoice = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanelInvoiceProcess = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.interestDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interestTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.commissionDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.commissionTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.refundDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.refundAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.paymentDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.paymentAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeDueDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financeDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financeAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.assignAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.assignDateTextBox = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupPanelInvoiceBasic = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.commentTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoiceCurrencyComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.dueDateTextBox = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.invoiceAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoiceDateTextBox = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.invoiceNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnInvoiceReset = new DevComponents.DotNetBar.ButtonX();
            this.btnInvoiceSave = new DevComponents.DotNetBar.ButtonX();
            this.btnInvoiceUpdate = new DevComponents.DotNetBar.ButtonX();
            this.tabItemInvoice = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelFlaw = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanelFlawResolve = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.flawResolveReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.flawResolveDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.flawResolveUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelFlaw = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tbFlawReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.flawReasonCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.isFlawCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tabItemFlaw = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelEDI = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanelInvoiceAdv = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.invoiceReferenceNumberTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.orderNumberReferenceTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.paymentConditionsComboBox = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.valueDateTextBox = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.secondaryDiscountRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.secondaryDiscountDaysTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.primaryDiscountRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.primaryDiscountDaysTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.netPaymentTermsTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemEDI = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanelDispute = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanelDisputeResolve = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.disputeResolveDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.disputeResolveUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.disputeResolveReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelDispute = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.disputeTypeComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.disputeAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.disputeDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.disputeUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.isDisputeCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tabItemDispute = new DevComponents.DotNetBar.TabItem(this.components);
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.disputeReasonCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tbDisputeReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            flawResolveReasonLabel = new DevComponents.DotNetBar.LabelX();
            flawResolveDateLabel = new DevComponents.DotNetBar.LabelX();
            flawResolveUserNameLabel = new DevComponents.DotNetBar.LabelX();
            assignDateLabel = new DevComponents.DotNetBar.LabelX();
            assignAmountLabel = new DevComponents.DotNetBar.LabelX();
            dueDateLabel = new DevComponents.DotNetBar.LabelX();
            invoiceAmountLabel = new DevComponents.DotNetBar.LabelX();
            invoiceDateLabel = new DevComponents.DotNetBar.LabelX();
            invoiceNoLabel = new DevComponents.DotNetBar.LabelX();
            flawReasonLabel = new DevComponents.DotNetBar.LabelX();
            invoiceReferenceNumberLabel = new DevComponents.DotNetBar.LabelX();
            orderNumberReferenceLabel = new DevComponents.DotNetBar.LabelX();
            paymentConditionsLabel = new DevComponents.DotNetBar.LabelX();
            valueDateLabel = new DevComponents.DotNetBar.LabelX();
            secondaryDiscountRateLabel = new DevComponents.DotNetBar.LabelX();
            secondaryDiscountDaysLabel = new DevComponents.DotNetBar.LabelX();
            primaryDiscountRateLabel = new DevComponents.DotNetBar.LabelX();
            primaryDiscountDaysLabel = new DevComponents.DotNetBar.LabelX();
            netPaymentTermsLabel = new DevComponents.DotNetBar.LabelX();
            invoiceCurrencyLabel = new DevComponents.DotNetBar.LabelX();
            financeAmountLabel = new DevComponents.DotNetBar.LabelX();
            financeDateLabel = new DevComponents.DotNetBar.LabelX();
            financeDueDateLabel = new DevComponents.DotNetBar.LabelX();
            paymentAmountLabel = new DevComponents.DotNetBar.LabelX();
            paymentDateLabel = new DevComponents.DotNetBar.LabelX();
            refundAmountLabel = new DevComponents.DotNetBar.LabelX();
            refundDateLabel = new DevComponents.DotNetBar.LabelX();
            commissionLabel = new DevComponents.DotNetBar.LabelX();
            commissionDateLabel = new DevComponents.DotNetBar.LabelX();
            interestLabel = new DevComponents.DotNetBar.LabelX();
            interestDateLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            disputeReasonLabel = new DevComponents.DotNetBar.LabelX();
            disputeDateLabel = new DevComponents.DotNetBar.LabelX();
            disputeResolveReasonLabel = new DevComponents.DotNetBar.LabelX();
            disputeResolveUserNameLabel = new DevComponents.DotNetBar.LabelX();
            disputeTypeLabel = new DevComponents.DotNetBar.LabelX();
            disputeUserNameLabel = new DevComponents.DotNetBar.LabelX();
            disputeAmountLabel = new DevComponents.DotNetBar.LabelX();
            disputeResolveDateLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanelInvoice.SuspendLayout();
            this.groupPanelInvoiceProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDueDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignDateTextBox)).BeginInit();
            this.groupPanelInvoiceBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dueDateTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDateTextBox)).BeginInit();
            this.tabPanelFlaw.SuspendLayout();
            this.groupPanelFlawResolve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flawResolveDateDateTimePicker)).BeginInit();
            this.groupPanelFlaw.SuspendLayout();
            this.tabPanelEDI.SuspendLayout();
            this.groupPanelInvoiceAdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueDateTextBox)).BeginInit();
            this.tabControlPanelDispute.SuspendLayout();
            this.groupPanelDisputeResolve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disputeResolveDateDateTimePicker)).BeginInit();
            this.groupPanelDispute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disputeDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // flawResolveReasonLabel
            // 
            flawResolveReasonLabel.AutoSize = true;
            flawResolveReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            flawResolveReasonLabel.BackgroundStyle.Class = "";
            flawResolveReasonLabel.Location = new System.Drawing.Point(23, 14);
            flawResolveReasonLabel.Name = "flawResolveReasonLabel";
            flawResolveReasonLabel.Size = new System.Drawing.Size(59, 16);
            flawResolveReasonLabel.TabIndex = 0;
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
            flawResolveDateLabel.Location = new System.Drawing.Point(387, 12);
            flawResolveDateLabel.Name = "flawResolveDateLabel";
            flawResolveDateLabel.Size = new System.Drawing.Size(47, 16);
            flawResolveDateLabel.TabIndex = 2;
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
            flawResolveUserNameLabel.Location = new System.Drawing.Point(387, 37);
            flawResolveUserNameLabel.Name = "flawResolveUserNameLabel";
            flawResolveUserNameLabel.Size = new System.Drawing.Size(47, 16);
            flawResolveUserNameLabel.TabIndex = 4;
            flawResolveUserNameLabel.Text = "经办人:";
            // 
            // assignDateLabel
            // 
            assignDateLabel.AutoSize = true;
            assignDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            assignDateLabel.BackgroundStyle.Class = "";
            assignDateLabel.Location = new System.Drawing.Point(179, 3);
            assignDateLabel.Name = "assignDateLabel";
            assignDateLabel.Size = new System.Drawing.Size(47, 16);
            assignDateLabel.TabIndex = 12;
            assignDateLabel.Text = "转让日:";
            // 
            // assignAmountLabel
            // 
            assignAmountLabel.AutoSize = true;
            assignAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            assignAmountLabel.BackgroundStyle.Class = "";
            assignAmountLabel.Location = new System.Drawing.Point(8, 3);
            assignAmountLabel.Name = "assignAmountLabel";
            assignAmountLabel.Size = new System.Drawing.Size(59, 16);
            assignAmountLabel.TabIndex = 10;
            assignAmountLabel.Text = "转让金额:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            dueDateLabel.BackgroundStyle.Class = "";
            dueDateLabel.Location = new System.Drawing.Point(370, 28);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(47, 16);
            dueDateLabel.TabIndex = 6;
            dueDateLabel.Text = "到期日:";
            // 
            // invoiceAmountLabel
            // 
            invoiceAmountLabel.AutoSize = true;
            invoiceAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceAmountLabel.BackgroundStyle.Class = "";
            invoiceAmountLabel.Location = new System.Drawing.Point(8, 30);
            invoiceAmountLabel.Name = "invoiceAmountLabel";
            invoiceAmountLabel.Size = new System.Drawing.Size(59, 16);
            invoiceAmountLabel.TabIndex = 4;
            invoiceAmountLabel.Text = "票面金额:";
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceDateLabel.BackgroundStyle.Class = "";
            invoiceDateLabel.Location = new System.Drawing.Point(179, 28);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(47, 16);
            invoiceDateLabel.TabIndex = 2;
            invoiceDateLabel.Text = "发票日:";
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceNoLabel.BackgroundStyle.Class = "";
            invoiceNoLabel.Location = new System.Drawing.Point(20, 5);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(47, 16);
            invoiceNoLabel.TabIndex = 0;
            invoiceNoLabel.Text = "发票号:";
            // 
            // flawReasonLabel
            // 
            flawReasonLabel.AutoSize = true;
            flawReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            flawReasonLabel.BackgroundStyle.Class = "";
            flawReasonLabel.Location = new System.Drawing.Point(105, 11);
            flawReasonLabel.Name = "flawReasonLabel";
            flawReasonLabel.Size = new System.Drawing.Size(59, 16);
            flawReasonLabel.TabIndex = 1;
            flawReasonLabel.Text = "瑕疵原因:";
            // 
            // invoiceReferenceNumberLabel
            // 
            invoiceReferenceNumberLabel.AutoSize = true;
            invoiceReferenceNumberLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceReferenceNumberLabel.BackgroundStyle.Class = "";
            invoiceReferenceNumberLabel.Location = new System.Drawing.Point(-1, 159);
            invoiceReferenceNumberLabel.Name = "invoiceReferenceNumberLabel";
            invoiceReferenceNumberLabel.Size = new System.Drawing.Size(144, 16);
            invoiceReferenceNumberLabel.TabIndex = 14;
            invoiceReferenceNumberLabel.Text = "Invoice Reference Number:";
            // 
            // orderNumberReferenceLabel
            // 
            orderNumberReferenceLabel.AutoSize = true;
            orderNumberReferenceLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            orderNumberReferenceLabel.BackgroundStyle.Class = "";
            orderNumberReferenceLabel.Location = new System.Drawing.Point(8, 137);
            orderNumberReferenceLabel.Name = "orderNumberReferenceLabel";
            orderNumberReferenceLabel.Size = new System.Drawing.Size(137, 16);
            orderNumberReferenceLabel.TabIndex = 12;
            orderNumberReferenceLabel.Text = "Order Number Reference:";
            // 
            // paymentConditionsLabel
            // 
            paymentConditionsLabel.AutoSize = true;
            paymentConditionsLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            paymentConditionsLabel.BackgroundStyle.Class = "";
            paymentConditionsLabel.Location = new System.Drawing.Point(34, 113);
            paymentConditionsLabel.Name = "paymentConditionsLabel";
            paymentConditionsLabel.Size = new System.Drawing.Size(111, 16);
            paymentConditionsLabel.TabIndex = 10;
            paymentConditionsLabel.Text = "Payment Conditions:";
            // 
            // valueDateLabel
            // 
            valueDateLabel.AutoSize = true;
            valueDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            valueDateLabel.BackgroundStyle.Class = "";
            valueDateLabel.Location = new System.Drawing.Point(352, 110);
            valueDateLabel.Name = "valueDateLabel";
            valueDateLabel.Size = new System.Drawing.Size(65, 16);
            valueDateLabel.TabIndex = 8;
            valueDateLabel.Text = "Value Date:";
            // 
            // secondaryDiscountRateLabel
            // 
            secondaryDiscountRateLabel.AutoSize = true;
            secondaryDiscountRateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            secondaryDiscountRateLabel.BackgroundStyle.Class = "";
            secondaryDiscountRateLabel.Location = new System.Drawing.Point(285, 86);
            secondaryDiscountRateLabel.Name = "secondaryDiscountRateLabel";
            secondaryDiscountRateLabel.Size = new System.Drawing.Size(138, 16);
            secondaryDiscountRateLabel.TabIndex = 8;
            secondaryDiscountRateLabel.Text = "Secondary Discount Rate:";
            // 
            // secondaryDiscountDaysLabel
            // 
            secondaryDiscountDaysLabel.AutoSize = true;
            secondaryDiscountDaysLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            secondaryDiscountDaysLabel.BackgroundStyle.Class = "";
            secondaryDiscountDaysLabel.Location = new System.Drawing.Point(4, 86);
            secondaryDiscountDaysLabel.Name = "secondaryDiscountDaysLabel";
            secondaryDiscountDaysLabel.Size = new System.Drawing.Size(139, 16);
            secondaryDiscountDaysLabel.TabIndex = 4;
            secondaryDiscountDaysLabel.Text = "Secondary Discount Days:";
            // 
            // primaryDiscountRateLabel
            // 
            primaryDiscountRateLabel.AutoSize = true;
            primaryDiscountRateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            primaryDiscountRateLabel.BackgroundStyle.Class = "";
            primaryDiscountRateLabel.Location = new System.Drawing.Point(295, 64);
            primaryDiscountRateLabel.Name = "primaryDiscountRateLabel";
            primaryDiscountRateLabel.Size = new System.Drawing.Size(122, 16);
            primaryDiscountRateLabel.TabIndex = 6;
            primaryDiscountRateLabel.Text = "Primary Discount Rate:";
            // 
            // primaryDiscountDaysLabel
            // 
            primaryDiscountDaysLabel.AutoSize = true;
            primaryDiscountDaysLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            primaryDiscountDaysLabel.BackgroundStyle.Class = "";
            primaryDiscountDaysLabel.Location = new System.Drawing.Point(19, 63);
            primaryDiscountDaysLabel.Name = "primaryDiscountDaysLabel";
            primaryDiscountDaysLabel.Size = new System.Drawing.Size(124, 16);
            primaryDiscountDaysLabel.TabIndex = 2;
            primaryDiscountDaysLabel.Text = "Primary Discount Days:";
            // 
            // netPaymentTermsLabel
            // 
            netPaymentTermsLabel.AutoSize = true;
            netPaymentTermsLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            netPaymentTermsLabel.BackgroundStyle.Class = "";
            netPaymentTermsLabel.Location = new System.Drawing.Point(33, 8);
            netPaymentTermsLabel.Name = "netPaymentTermsLabel";
            netPaymentTermsLabel.Size = new System.Drawing.Size(110, 16);
            netPaymentTermsLabel.TabIndex = 0;
            netPaymentTermsLabel.Text = "Net Payment Terms:";
            // 
            // invoiceCurrencyLabel
            // 
            invoiceCurrencyLabel.AutoSize = true;
            invoiceCurrencyLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceCurrencyLabel.BackgroundStyle.Class = "";
            invoiceCurrencyLabel.Location = new System.Drawing.Point(179, 6);
            invoiceCurrencyLabel.Name = "invoiceCurrencyLabel";
            invoiceCurrencyLabel.Size = new System.Drawing.Size(59, 16);
            invoiceCurrencyLabel.TabIndex = 13;
            invoiceCurrencyLabel.Text = "发票币别:";
            // 
            // financeAmountLabel
            // 
            financeAmountLabel.AutoSize = true;
            financeAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeAmountLabel.BackgroundStyle.Class = "";
            financeAmountLabel.Location = new System.Drawing.Point(8, 24);
            financeAmountLabel.Name = "financeAmountLabel";
            financeAmountLabel.Size = new System.Drawing.Size(59, 16);
            financeAmountLabel.TabIndex = 13;
            financeAmountLabel.Text = "融资金额:";
            // 
            // financeDateLabel
            // 
            financeDateLabel.AutoSize = true;
            financeDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeDateLabel.BackgroundStyle.Class = "";
            financeDateLabel.Location = new System.Drawing.Point(179, 24);
            financeDateLabel.Name = "financeDateLabel";
            financeDateLabel.Size = new System.Drawing.Size(47, 16);
            financeDateLabel.TabIndex = 14;
            financeDateLabel.Text = "融资日:";
            // 
            // financeDueDateLabel
            // 
            financeDueDateLabel.AutoSize = true;
            financeDueDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeDueDateLabel.BackgroundStyle.Class = "";
            financeDueDateLabel.Location = new System.Drawing.Point(360, 24);
            financeDueDateLabel.Name = "financeDueDateLabel";
            financeDueDateLabel.Size = new System.Drawing.Size(72, 16);
            financeDueDateLabel.TabIndex = 15;
            financeDueDateLabel.Text = "融资到期日:";
            // 
            // paymentAmountLabel
            // 
            paymentAmountLabel.AutoSize = true;
            paymentAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            paymentAmountLabel.BackgroundStyle.Class = "";
            paymentAmountLabel.Location = new System.Drawing.Point(8, 46);
            paymentAmountLabel.Name = "paymentAmountLabel";
            paymentAmountLabel.Size = new System.Drawing.Size(59, 16);
            paymentAmountLabel.TabIndex = 16;
            paymentAmountLabel.Text = "付款金额:";
            // 
            // paymentDateLabel
            // 
            paymentDateLabel.AutoSize = true;
            paymentDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            paymentDateLabel.BackgroundStyle.Class = "";
            paymentDateLabel.Location = new System.Drawing.Point(179, 46);
            paymentDateLabel.Name = "paymentDateLabel";
            paymentDateLabel.Size = new System.Drawing.Size(47, 16);
            paymentDateLabel.TabIndex = 17;
            paymentDateLabel.Text = "付款日:";
            // 
            // refundAmountLabel
            // 
            refundAmountLabel.AutoSize = true;
            refundAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            refundAmountLabel.BackgroundStyle.Class = "";
            refundAmountLabel.Location = new System.Drawing.Point(8, 68);
            refundAmountLabel.Name = "refundAmountLabel";
            refundAmountLabel.Size = new System.Drawing.Size(59, 16);
            refundAmountLabel.TabIndex = 18;
            refundAmountLabel.Text = "还款金额:";
            // 
            // refundDateLabel
            // 
            refundDateLabel.AutoSize = true;
            refundDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            refundDateLabel.BackgroundStyle.Class = "";
            refundDateLabel.Location = new System.Drawing.Point(179, 68);
            refundDateLabel.Name = "refundDateLabel";
            refundDateLabel.Size = new System.Drawing.Size(47, 16);
            refundDateLabel.TabIndex = 19;
            refundDateLabel.Text = "还款日:";
            // 
            // commissionLabel
            // 
            commissionLabel.AutoSize = true;
            commissionLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commissionLabel.BackgroundStyle.Class = "";
            commissionLabel.Location = new System.Drawing.Point(20, 89);
            commissionLabel.Name = "commissionLabel";
            commissionLabel.Size = new System.Drawing.Size(47, 16);
            commissionLabel.TabIndex = 20;
            commissionLabel.Text = "手续费:";
            // 
            // commissionDateLabel
            // 
            commissionDateLabel.AutoSize = true;
            commissionDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commissionDateLabel.BackgroundStyle.Class = "";
            commissionDateLabel.Location = new System.Drawing.Point(179, 89);
            commissionDateLabel.Name = "commissionDateLabel";
            commissionDateLabel.Size = new System.Drawing.Size(47, 16);
            commissionDateLabel.TabIndex = 21;
            commissionDateLabel.Text = "收费日:";
            // 
            // interestLabel
            // 
            interestLabel.AutoSize = true;
            interestLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            interestLabel.BackgroundStyle.Class = "";
            interestLabel.Location = new System.Drawing.Point(21, 111);
            interestLabel.Name = "interestLabel";
            interestLabel.Size = new System.Drawing.Size(47, 16);
            interestLabel.TabIndex = 22;
            interestLabel.Text = "利息费:";
            // 
            // interestDateLabel
            // 
            interestDateLabel.AutoSize = true;
            interestDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            interestDateLabel.BackgroundStyle.Class = "";
            interestDateLabel.Location = new System.Drawing.Point(179, 111);
            interestDateLabel.Name = "interestDateLabel";
            interestDateLabel.Size = new System.Drawing.Size(47, 16);
            interestDateLabel.TabIndex = 24;
            interestDateLabel.Text = "收息日:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.Class = "";
            commentLabel.Location = new System.Drawing.Point(31, 52);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(34, 16);
            commentLabel.TabIndex = 14;
            commentLabel.Text = "备注:";
            // 
            // disputeReasonLabel
            // 
            disputeReasonLabel.AutoSize = true;
            disputeReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeReasonLabel.BackgroundStyle.Class = "";
            disputeReasonLabel.Location = new System.Drawing.Point(113, 10);
            disputeReasonLabel.Name = "disputeReasonLabel";
            disputeReasonLabel.Size = new System.Drawing.Size(59, 16);
            disputeReasonLabel.TabIndex = 1;
            disputeReasonLabel.Text = "商纠原因:";
            // 
            // disputeDateLabel
            // 
            disputeDateLabel.AutoSize = true;
            disputeDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeDateLabel.BackgroundStyle.Class = "";
            disputeDateLabel.Location = new System.Drawing.Point(229, 111);
            disputeDateLabel.Name = "disputeDateLabel";
            disputeDateLabel.Size = new System.Drawing.Size(47, 16);
            disputeDateLabel.TabIndex = 3;
            disputeDateLabel.Text = "商纠日:";
            // 
            // disputeResolveReasonLabel
            // 
            disputeResolveReasonLabel.AutoSize = true;
            disputeResolveReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeResolveReasonLabel.BackgroundStyle.Class = "";
            disputeResolveReasonLabel.Location = new System.Drawing.Point(15, 13);
            disputeResolveReasonLabel.Name = "disputeResolveReasonLabel";
            disputeResolveReasonLabel.Size = new System.Drawing.Size(59, 16);
            disputeResolveReasonLabel.TabIndex = 4;
            disputeResolveReasonLabel.Text = "解除原因:";
            // 
            // disputeResolveUserNameLabel
            // 
            disputeResolveUserNameLabel.AutoSize = true;
            disputeResolveUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeResolveUserNameLabel.BackgroundStyle.Class = "";
            disputeResolveUserNameLabel.Location = new System.Drawing.Point(389, 29);
            disputeResolveUserNameLabel.Name = "disputeResolveUserNameLabel";
            disputeResolveUserNameLabel.Size = new System.Drawing.Size(47, 16);
            disputeResolveUserNameLabel.TabIndex = 5;
            disputeResolveUserNameLabel.Text = "经办人:";
            // 
            // disputeTypeLabel
            // 
            disputeTypeLabel.AutoSize = true;
            disputeTypeLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeTypeLabel.BackgroundStyle.Class = "";
            disputeTypeLabel.Location = new System.Drawing.Point(19, 109);
            disputeTypeLabel.Name = "disputeTypeLabel";
            disputeTypeLabel.Size = new System.Drawing.Size(59, 16);
            disputeTypeLabel.TabIndex = 3;
            disputeTypeLabel.Text = "商纠类型:";
            // 
            // disputeUserNameLabel
            // 
            disputeUserNameLabel.AutoSize = true;
            disputeUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeUserNameLabel.BackgroundStyle.Class = "";
            disputeUserNameLabel.Location = new System.Drawing.Point(229, 130);
            disputeUserNameLabel.Name = "disputeUserNameLabel";
            disputeUserNameLabel.Size = new System.Drawing.Size(47, 16);
            disputeUserNameLabel.TabIndex = 5;
            disputeUserNameLabel.Text = "经办人:";
            // 
            // disputeAmountLabel
            // 
            disputeAmountLabel.AutoSize = true;
            disputeAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeAmountLabel.BackgroundStyle.Class = "";
            disputeAmountLabel.Location = new System.Drawing.Point(19, 131);
            disputeAmountLabel.Name = "disputeAmountLabel";
            disputeAmountLabel.Size = new System.Drawing.Size(59, 16);
            disputeAmountLabel.TabIndex = 7;
            disputeAmountLabel.Text = "商纠金额:";
            // 
            // disputeResolveDateLabel
            // 
            disputeResolveDateLabel.AutoSize = true;
            disputeResolveDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeResolveDateLabel.BackgroundStyle.Class = "";
            disputeResolveDateLabel.Location = new System.Drawing.Point(389, 4);
            disputeResolveDateLabel.Name = "disputeResolveDateLabel";
            disputeResolveDateLabel.Size = new System.Drawing.Size(47, 16);
            disputeResolveDateLabel.TabIndex = 6;
            disputeResolveDateLabel.Text = "解除日:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabControlPanelDispute);
            this.tabControl.Controls.Add(this.tabPanelFlaw);
            this.tabControl.Controls.Add(this.tabPanelEDI);
            this.tabControl.Controls.Add(this.tabPanelInvoice);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(558, 345);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemInvoice);
            this.tabControl.Tabs.Add(this.tabItemFlaw);
            this.tabControl.Tabs.Add(this.tabItemDispute);
            this.tabControl.Tabs.Add(this.tabItemEDI);
            // 
            // tabPanelInvoice
            // 
            this.tabPanelInvoice.AutoScroll = true;
            this.tabPanelInvoice.Controls.Add(this.groupPanelInvoiceProcess);
            this.tabPanelInvoice.Controls.Add(this.groupPanelInvoiceBasic);
            this.tabPanelInvoice.Controls.Add(this.btnInvoiceReset);
            this.tabPanelInvoice.Controls.Add(this.btnInvoiceSave);
            this.tabPanelInvoice.Controls.Add(this.btnInvoiceUpdate);
            this.tabPanelInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelInvoice.Location = new System.Drawing.Point(0, 26);
            this.tabPanelInvoice.Name = "tabPanelInvoice";
            this.tabPanelInvoice.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelInvoice.Size = new System.Drawing.Size(558, 319);
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
            // groupPanelInvoiceProcess
            // 
            this.groupPanelInvoiceProcess.AutoScroll = true;
            this.groupPanelInvoiceProcess.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelInvoiceProcess.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelInvoiceProcess.Controls.Add(interestDateLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.interestDateDateTimePicker);
            this.groupPanelInvoiceProcess.Controls.Add(interestLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.interestTextBox);
            this.groupPanelInvoiceProcess.Controls.Add(commissionDateLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.commissionDateDateTimePicker);
            this.groupPanelInvoiceProcess.Controls.Add(commissionLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.commissionTextBox);
            this.groupPanelInvoiceProcess.Controls.Add(refundDateLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.refundDateDateTimePicker);
            this.groupPanelInvoiceProcess.Controls.Add(refundAmountLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.refundAmountTextBox);
            this.groupPanelInvoiceProcess.Controls.Add(paymentDateLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.paymentDateDateTimePicker);
            this.groupPanelInvoiceProcess.Controls.Add(paymentAmountLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.paymentAmountTextBox);
            this.groupPanelInvoiceProcess.Controls.Add(financeDueDateLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.financeDueDateDateTimePicker);
            this.groupPanelInvoiceProcess.Controls.Add(financeDateLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.financeDateDateTimePicker);
            this.groupPanelInvoiceProcess.Controls.Add(financeAmountLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.financeAmountTextBox);
            this.groupPanelInvoiceProcess.Controls.Add(assignAmountLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.assignAmountTextBox);
            this.groupPanelInvoiceProcess.Controls.Add(assignDateLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.assignDateTextBox);
            this.groupPanelInvoiceProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelInvoiceProcess.Location = new System.Drawing.Point(1, 106);
            this.groupPanelInvoiceProcess.Name = "groupPanelInvoiceProcess";
            this.groupPanelInvoiceProcess.Size = new System.Drawing.Size(556, 136);
            // 
            // 
            // 
            this.groupPanelInvoiceProcess.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelInvoiceProcess.Style.BackColorGradientAngle = 90;
            this.groupPanelInvoiceProcess.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelInvoiceProcess.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceProcess.Style.BorderBottomWidth = 1;
            this.groupPanelInvoiceProcess.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelInvoiceProcess.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceProcess.Style.BorderLeftWidth = 1;
            this.groupPanelInvoiceProcess.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceProcess.Style.BorderRightWidth = 1;
            this.groupPanelInvoiceProcess.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceProcess.Style.BorderTopWidth = 1;
            this.groupPanelInvoiceProcess.Style.Class = "";
            this.groupPanelInvoiceProcess.Style.CornerDiameter = 4;
            this.groupPanelInvoiceProcess.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelInvoiceProcess.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelInvoiceProcess.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelInvoiceProcess.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelInvoiceProcess.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelInvoiceProcess.StyleMouseOver.Class = "";
            this.groupPanelInvoiceProcess.TabIndex = 5;
            // 
            // interestDateDateTimePicker
            // 
            // 
            // 
            // 
            this.interestDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.interestDateDateTimePicker.ButtonDropDown.Visible = true;
            this.interestDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "InterestDate", true));
            this.interestDateDateTimePicker.Location = new System.Drawing.Point(232, 107);
            // 
            // 
            // 
            this.interestDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.interestDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.interestDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.interestDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.interestDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.interestDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.interestDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.interestDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.interestDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.interestDateDateTimePicker.Name = "interestDateDateTimePicker";
            this.interestDateDateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.interestDateDateTimePicker.TabIndex = 25;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Invoice);
            // 
            // interestTextBox
            // 
            // 
            // 
            // 
            this.interestTextBox.Border.Class = "TextBoxBorder";
            this.interestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Interest", true));
            this.interestTextBox.Location = new System.Drawing.Point(73, 107);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(100, 20);
            this.interestTextBox.TabIndex = 23;
            // 
            // commissionDateDateTimePicker
            // 
            // 
            // 
            // 
            this.commissionDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.commissionDateDateTimePicker.ButtonDropDown.Visible = true;
            this.commissionDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "CommissionDate", true));
            this.commissionDateDateTimePicker.Location = new System.Drawing.Point(232, 86);
            // 
            // 
            // 
            this.commissionDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.commissionDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.commissionDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.commissionDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.commissionDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.commissionDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.commissionDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.commissionDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.commissionDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.commissionDateDateTimePicker.Name = "commissionDateDateTimePicker";
            this.commissionDateDateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.commissionDateDateTimePicker.TabIndex = 22;
            // 
            // commissionTextBox
            // 
            // 
            // 
            // 
            this.commissionTextBox.Border.Class = "TextBoxBorder";
            this.commissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Commission", true));
            this.commissionTextBox.Location = new System.Drawing.Point(73, 86);
            this.commissionTextBox.Name = "commissionTextBox";
            this.commissionTextBox.Size = new System.Drawing.Size(100, 20);
            this.commissionTextBox.TabIndex = 21;
            // 
            // refundDateDateTimePicker
            // 
            // 
            // 
            // 
            this.refundDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.refundDateDateTimePicker.ButtonDropDown.Visible = true;
            this.refundDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "RefundDate", true));
            this.refundDateDateTimePicker.Location = new System.Drawing.Point(232, 65);
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.refundDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.refundDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.refundDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.refundDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.refundDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.refundDateDateTimePicker.Name = "refundDateDateTimePicker";
            this.refundDateDateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.refundDateDateTimePicker.TabIndex = 20;
            // 
            // refundAmountTextBox
            // 
            // 
            // 
            // 
            this.refundAmountTextBox.Border.Class = "TextBoxBorder";
            this.refundAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "RefundAmount", true));
            this.refundAmountTextBox.Location = new System.Drawing.Point(73, 65);
            this.refundAmountTextBox.Name = "refundAmountTextBox";
            this.refundAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.refundAmountTextBox.TabIndex = 19;
            // 
            // paymentDateDateTimePicker
            // 
            // 
            // 
            // 
            this.paymentDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.paymentDateDateTimePicker.ButtonDropDown.Visible = true;
            this.paymentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "PaymentDate", true));
            this.paymentDateDateTimePicker.Location = new System.Drawing.Point(232, 43);
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.paymentDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.paymentDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.paymentDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.paymentDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.paymentDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.paymentDateDateTimePicker.Name = "paymentDateDateTimePicker";
            this.paymentDateDateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.paymentDateDateTimePicker.TabIndex = 18;
            // 
            // paymentAmountTextBox
            // 
            // 
            // 
            // 
            this.paymentAmountTextBox.Border.Class = "TextBoxBorder";
            this.paymentAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PaymentAmount", true));
            this.paymentAmountTextBox.Location = new System.Drawing.Point(73, 43);
            this.paymentAmountTextBox.Name = "paymentAmountTextBox";
            this.paymentAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.paymentAmountTextBox.TabIndex = 17;
            // 
            // financeDueDateDateTimePicker
            // 
            // 
            // 
            // 
            this.financeDueDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financeDueDateDateTimePicker.ButtonDropDown.Visible = true;
            this.financeDueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "FinanceDueDate", true));
            this.financeDueDateDateTimePicker.Location = new System.Drawing.Point(436, 21);
            // 
            // 
            // 
            this.financeDueDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeDueDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financeDueDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.financeDueDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.financeDueDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.financeDueDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financeDueDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeDueDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.financeDueDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financeDueDateDateTimePicker.Name = "financeDueDateDateTimePicker";
            this.financeDueDateDateTimePicker.Size = new System.Drawing.Size(103, 20);
            this.financeDueDateDateTimePicker.TabIndex = 16;
            // 
            // financeDateDateTimePicker
            // 
            // 
            // 
            // 
            this.financeDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financeDateDateTimePicker.ButtonDropDown.Visible = true;
            this.financeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "FinanceDate", true));
            this.financeDateDateTimePicker.Location = new System.Drawing.Point(231, 21);
            // 
            // 
            // 
            this.financeDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financeDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.financeDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.financeDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.financeDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financeDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.financeDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financeDateDateTimePicker.Name = "financeDateDateTimePicker";
            this.financeDateDateTimePicker.Size = new System.Drawing.Size(119, 20);
            this.financeDateDateTimePicker.TabIndex = 15;
            // 
            // financeAmountTextBox
            // 
            // 
            // 
            // 
            this.financeAmountTextBox.Border.Class = "TextBoxBorder";
            this.financeAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FinanceAmount", true));
            this.financeAmountTextBox.Location = new System.Drawing.Point(73, 21);
            this.financeAmountTextBox.Name = "financeAmountTextBox";
            this.financeAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeAmountTextBox.TabIndex = 14;
            // 
            // assignAmountTextBox
            // 
            // 
            // 
            // 
            this.assignAmountTextBox.Border.Class = "TextBoxBorder";
            this.assignAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "AssignAmount", true));
            this.assignAmountTextBox.Location = new System.Drawing.Point(73, 0);
            this.assignAmountTextBox.Name = "assignAmountTextBox";
            this.assignAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.assignAmountTextBox.TabIndex = 11;
            // 
            // assignDateTextBox
            // 
            // 
            // 
            // 
            this.assignDateTextBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.assignDateTextBox.ButtonDropDown.Visible = true;
            this.assignDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "AssignDate", true));
            this.assignDateTextBox.Location = new System.Drawing.Point(232, 0);
            // 
            // 
            // 
            this.assignDateTextBox.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.assignDateTextBox.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.assignDateTextBox.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.assignDateTextBox.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.assignDateTextBox.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.assignDateTextBox.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.assignDateTextBox.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.assignDateTextBox.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.assignDateTextBox.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.assignDateTextBox.Name = "assignDateTextBox";
            this.assignDateTextBox.Size = new System.Drawing.Size(118, 20);
            this.assignDateTextBox.TabIndex = 13;
            // 
            // groupPanelInvoiceBasic
            // 
            this.groupPanelInvoiceBasic.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelInvoiceBasic.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelInvoiceBasic.Controls.Add(commentLabel);
            this.groupPanelInvoiceBasic.Controls.Add(this.commentTextBox);
            this.groupPanelInvoiceBasic.Controls.Add(invoiceCurrencyLabel);
            this.groupPanelInvoiceBasic.Controls.Add(this.invoiceCurrencyComboBox);
            this.groupPanelInvoiceBasic.Controls.Add(dueDateLabel);
            this.groupPanelInvoiceBasic.Controls.Add(this.dueDateTextBox);
            this.groupPanelInvoiceBasic.Controls.Add(invoiceAmountLabel);
            this.groupPanelInvoiceBasic.Controls.Add(this.invoiceAmountTextBox);
            this.groupPanelInvoiceBasic.Controls.Add(invoiceDateLabel);
            this.groupPanelInvoiceBasic.Controls.Add(this.invoiceDateTextBox);
            this.groupPanelInvoiceBasic.Controls.Add(invoiceNoLabel);
            this.groupPanelInvoiceBasic.Controls.Add(this.invoiceNoTextBox);
            this.groupPanelInvoiceBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelInvoiceBasic.Location = new System.Drawing.Point(1, 1);
            this.groupPanelInvoiceBasic.Name = "groupPanelInvoiceBasic";
            this.groupPanelInvoiceBasic.Size = new System.Drawing.Size(556, 105);
            // 
            // 
            // 
            this.groupPanelInvoiceBasic.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelInvoiceBasic.Style.BackColorGradientAngle = 90;
            this.groupPanelInvoiceBasic.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelInvoiceBasic.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceBasic.Style.BorderBottomWidth = 1;
            this.groupPanelInvoiceBasic.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelInvoiceBasic.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceBasic.Style.BorderLeftWidth = 1;
            this.groupPanelInvoiceBasic.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceBasic.Style.BorderRightWidth = 1;
            this.groupPanelInvoiceBasic.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceBasic.Style.BorderTopWidth = 1;
            this.groupPanelInvoiceBasic.Style.Class = "";
            this.groupPanelInvoiceBasic.Style.CornerDiameter = 4;
            this.groupPanelInvoiceBasic.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelInvoiceBasic.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelInvoiceBasic.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelInvoiceBasic.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelInvoiceBasic.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelInvoiceBasic.StyleMouseOver.Class = "";
            this.groupPanelInvoiceBasic.TabIndex = 0;
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(73, 49);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(459, 43);
            this.commentTextBox.TabIndex = 15;
            // 
            // invoiceCurrencyComboBox
            // 
            this.invoiceCurrencyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.invoiceCurrencyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.invoiceCurrencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceCurrency", true));
            this.invoiceCurrencyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.invoiceCurrencyComboBox.FormattingEnabled = true;
            this.invoiceCurrencyComboBox.Location = new System.Drawing.Point(244, 3);
            this.invoiceCurrencyComboBox.Name = "invoiceCurrencyComboBox";
            this.invoiceCurrencyComboBox.Size = new System.Drawing.Size(100, 21);
            this.invoiceCurrencyComboBox.TabIndex = 14;
            // 
            // dueDateTextBox
            // 
            // 
            // 
            // 
            this.dueDateTextBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dueDateTextBox.ButtonDropDown.Visible = true;
            this.dueDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DueDate", true));
            this.dueDateTextBox.Location = new System.Drawing.Point(432, 25);
            // 
            // 
            // 
            this.dueDateTextBox.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dueDateTextBox.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dueDateTextBox.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.dueDateTextBox.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dueDateTextBox.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dueDateTextBox.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dueDateTextBox.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dueDateTextBox.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dueDateTextBox.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dueDateTextBox.Name = "dueDateTextBox";
            this.dueDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dueDateTextBox.TabIndex = 7;
            // 
            // invoiceAmountTextBox
            // 
            // 
            // 
            // 
            this.invoiceAmountTextBox.Border.Class = "TextBoxBorder";
            this.invoiceAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceAmount", true));
            this.invoiceAmountTextBox.Location = new System.Drawing.Point(73, 27);
            this.invoiceAmountTextBox.Name = "invoiceAmountTextBox";
            this.invoiceAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceAmountTextBox.TabIndex = 5;
            // 
            // invoiceDateTextBox
            // 
            // 
            // 
            // 
            this.invoiceDateTextBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.invoiceDateTextBox.ButtonDropDown.Visible = true;
            this.invoiceDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceDate", true));
            this.invoiceDateTextBox.Location = new System.Drawing.Point(232, 27);
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
            this.invoiceDateTextBox.Size = new System.Drawing.Size(112, 20);
            this.invoiceDateTextBox.TabIndex = 3;
            // 
            // invoiceNoTextBox
            // 
            // 
            // 
            // 
            this.invoiceNoTextBox.Border.Class = "TextBoxBorder";
            this.invoiceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceNo", true));
            this.invoiceNoTextBox.Location = new System.Drawing.Point(73, 4);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.invoiceNoTextBox.TabIndex = 1;
            // 
            // btnInvoiceReset
            // 
            this.btnInvoiceReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInvoiceReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInvoiceReset.Location = new System.Drawing.Point(338, 285);
            this.btnInvoiceReset.Name = "btnInvoiceReset";
            this.btnInvoiceReset.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInvoiceReset.TabIndex = 4;
            this.btnInvoiceReset.Text = "重置";
            this.btnInvoiceReset.Click += new System.EventHandler(this.ResetInvoice);
            // 
            // btnInvoiceSave
            // 
            this.btnInvoiceSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInvoiceSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInvoiceSave.Location = new System.Drawing.Point(257, 285);
            this.btnInvoiceSave.Name = "btnInvoiceSave";
            this.btnInvoiceSave.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInvoiceSave.TabIndex = 3;
            this.btnInvoiceSave.Text = "保存";
            this.btnInvoiceSave.Click += new System.EventHandler(this.SaveInvoice);
            // 
            // btnInvoiceUpdate
            // 
            this.btnInvoiceUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInvoiceUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInvoiceUpdate.Location = new System.Drawing.Point(176, 285);
            this.btnInvoiceUpdate.Name = "btnInvoiceUpdate";
            this.btnInvoiceUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnInvoiceUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInvoiceUpdate.TabIndex = 2;
            this.btnInvoiceUpdate.Text = "编辑";
            this.btnInvoiceUpdate.Click += new System.EventHandler(this.UpdateInvoice);
            // 
            // tabItemInvoice
            // 
            this.tabItemInvoice.AttachedControl = this.tabPanelInvoice;
            this.tabItemInvoice.Name = "tabItemInvoice";
            this.tabItemInvoice.Text = "发票明细";
            // 
            // tabPanelFlaw
            // 
            this.tabPanelFlaw.AutoScroll = true;
            this.tabPanelFlaw.Controls.Add(this.groupPanelFlawResolve);
            this.tabPanelFlaw.Controls.Add(this.groupPanelFlaw);
            this.tabPanelFlaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelFlaw.Location = new System.Drawing.Point(0, 26);
            this.tabPanelFlaw.Name = "tabPanelFlaw";
            this.tabPanelFlaw.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelFlaw.Size = new System.Drawing.Size(558, 319);
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
            // groupPanelFlawResolve
            // 
            this.groupPanelFlawResolve.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelFlawResolve.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelFlawResolve.Controls.Add(flawResolveReasonLabel);
            this.groupPanelFlawResolve.Controls.Add(this.flawResolveReasonTextBox);
            this.groupPanelFlawResolve.Controls.Add(flawResolveUserNameLabel);
            this.groupPanelFlawResolve.Controls.Add(this.flawResolveDateDateTimePicker);
            this.groupPanelFlawResolve.Controls.Add(this.flawResolveUserNameTextBox);
            this.groupPanelFlawResolve.Controls.Add(flawResolveDateLabel);
            this.groupPanelFlawResolve.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelFlawResolve.Location = new System.Drawing.Point(1, 123);
            this.groupPanelFlawResolve.Name = "groupPanelFlawResolve";
            this.groupPanelFlawResolve.Size = new System.Drawing.Size(556, 127);
            // 
            // 
            // 
            this.groupPanelFlawResolve.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelFlawResolve.Style.BackColorGradientAngle = 90;
            this.groupPanelFlawResolve.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelFlawResolve.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFlawResolve.Style.BorderBottomWidth = 1;
            this.groupPanelFlawResolve.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelFlawResolve.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFlawResolve.Style.BorderLeftWidth = 1;
            this.groupPanelFlawResolve.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFlawResolve.Style.BorderRightWidth = 1;
            this.groupPanelFlawResolve.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFlawResolve.Style.BorderTopWidth = 1;
            this.groupPanelFlawResolve.Style.Class = "";
            this.groupPanelFlawResolve.Style.CornerDiameter = 4;
            this.groupPanelFlawResolve.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelFlawResolve.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelFlawResolve.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelFlawResolve.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelFlawResolve.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelFlawResolve.StyleMouseOver.Class = "";
            this.groupPanelFlawResolve.TabIndex = 1;
            // 
            // flawResolveReasonTextBox
            // 
            // 
            // 
            // 
            this.flawResolveReasonTextBox.Border.Class = "TextBoxBorder";
            this.flawResolveReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FlawResolveReason", true));
            this.flawResolveReasonTextBox.Location = new System.Drawing.Point(87, 11);
            this.flawResolveReasonTextBox.Multiline = true;
            this.flawResolveReasonTextBox.Name = "flawResolveReasonTextBox";
            this.flawResolveReasonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.flawResolveReasonTextBox.Size = new System.Drawing.Size(256, 43);
            this.flawResolveReasonTextBox.TabIndex = 1;
            // 
            // flawResolveDateDateTimePicker
            // 
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.flawResolveDateDateTimePicker.ButtonDropDown.Visible = true;
            this.flawResolveDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "FlawResolveDate", true));
            this.flawResolveDateDateTimePicker.Location = new System.Drawing.Point(439, 8);
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
            this.flawResolveDateDateTimePicker.TabIndex = 3;
            // 
            // flawResolveUserNameTextBox
            // 
            // 
            // 
            // 
            this.flawResolveUserNameTextBox.Border.Class = "TextBoxBorder";
            this.flawResolveUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FlawResolveUserName", true));
            this.flawResolveUserNameTextBox.Location = new System.Drawing.Point(439, 34);
            this.flawResolveUserNameTextBox.Name = "flawResolveUserNameTextBox";
            this.flawResolveUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.flawResolveUserNameTextBox.TabIndex = 5;
            // 
            // groupPanelFlaw
            // 
            this.groupPanelFlaw.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelFlaw.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelFlaw.Controls.Add(this.tbFlawReason);
            this.groupPanelFlaw.Controls.Add(flawReasonLabel);
            this.groupPanelFlaw.Controls.Add(this.flawReasonCheckedListBox);
            this.groupPanelFlaw.Controls.Add(this.isFlawCheckBox);
            this.groupPanelFlaw.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelFlaw.Location = new System.Drawing.Point(1, 1);
            this.groupPanelFlaw.Name = "groupPanelFlaw";
            this.groupPanelFlaw.Size = new System.Drawing.Size(556, 122);
            // 
            // 
            // 
            this.groupPanelFlaw.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelFlaw.Style.BackColorGradientAngle = 90;
            this.groupPanelFlaw.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelFlaw.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFlaw.Style.BorderBottomWidth = 1;
            this.groupPanelFlaw.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelFlaw.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFlaw.Style.BorderLeftWidth = 1;
            this.groupPanelFlaw.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFlaw.Style.BorderRightWidth = 1;
            this.groupPanelFlaw.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelFlaw.Style.BorderTopWidth = 1;
            this.groupPanelFlaw.Style.Class = "";
            this.groupPanelFlaw.Style.CornerDiameter = 4;
            this.groupPanelFlaw.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelFlaw.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelFlaw.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelFlaw.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelFlaw.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelFlaw.StyleMouseOver.Class = "";
            this.groupPanelFlaw.TabIndex = 0;
            // 
            // tbFlawReason
            // 
            // 
            // 
            // 
            this.tbFlawReason.Border.Class = "TextBoxBorder";
            this.tbFlawReason.Location = new System.Drawing.Point(369, 10);
            this.tbFlawReason.Multiline = true;
            this.tbFlawReason.Name = "tbFlawReason";
            this.tbFlawReason.Size = new System.Drawing.Size(170, 94);
            this.tbFlawReason.TabIndex = 3;
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
            "保理合同过期或未签回",
            "交货凭证内容不完整",
            "其他"});
            this.flawReasonCheckedListBox.Location = new System.Drawing.Point(170, 10);
            this.flawReasonCheckedListBox.Name = "flawReasonCheckedListBox";
            this.flawReasonCheckedListBox.Size = new System.Drawing.Size(193, 94);
            this.flawReasonCheckedListBox.TabIndex = 2;
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
            this.isFlawCheckBox.Location = new System.Drawing.Point(23, 12);
            this.isFlawCheckBox.Name = "isFlawCheckBox";
            this.isFlawCheckBox.Size = new System.Drawing.Size(76, 16);
            this.isFlawCheckBox.TabIndex = 0;
            this.isFlawCheckBox.Text = "是否瑕疵";
            // 
            // tabItemFlaw
            // 
            this.tabItemFlaw.AttachedControl = this.tabPanelFlaw;
            this.tabItemFlaw.Name = "tabItemFlaw";
            this.tabItemFlaw.Text = "瑕疵处理";
            // 
            // tabPanelEDI
            // 
            this.tabPanelEDI.Controls.Add(this.groupPanelInvoiceAdv);
            this.tabPanelEDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelEDI.Location = new System.Drawing.Point(0, 26);
            this.tabPanelEDI.Name = "tabPanelEDI";
            this.tabPanelEDI.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelEDI.Size = new System.Drawing.Size(558, 319);
            this.tabPanelEDI.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelEDI.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelEDI.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelEDI.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelEDI.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelEDI.Style.GradientAngle = 90;
            this.tabPanelEDI.TabIndex = 2;
            this.tabPanelEDI.TabItem = this.tabItemEDI;
            // 
            // groupPanelInvoiceAdv
            // 
            this.groupPanelInvoiceAdv.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelInvoiceAdv.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelInvoiceAdv.Controls.Add(invoiceReferenceNumberLabel);
            this.groupPanelInvoiceAdv.Controls.Add(this.invoiceReferenceNumberTextBox);
            this.groupPanelInvoiceAdv.Controls.Add(orderNumberReferenceLabel);
            this.groupPanelInvoiceAdv.Controls.Add(this.orderNumberReferenceTextBox);
            this.groupPanelInvoiceAdv.Controls.Add(paymentConditionsLabel);
            this.groupPanelInvoiceAdv.Controls.Add(valueDateLabel);
            this.groupPanelInvoiceAdv.Controls.Add(this.paymentConditionsComboBox);
            this.groupPanelInvoiceAdv.Controls.Add(this.valueDateTextBox);
            this.groupPanelInvoiceAdv.Controls.Add(secondaryDiscountRateLabel);
            this.groupPanelInvoiceAdv.Controls.Add(this.secondaryDiscountRateTextBox);
            this.groupPanelInvoiceAdv.Controls.Add(secondaryDiscountDaysLabel);
            this.groupPanelInvoiceAdv.Controls.Add(this.secondaryDiscountDaysTextBox);
            this.groupPanelInvoiceAdv.Controls.Add(primaryDiscountRateLabel);
            this.groupPanelInvoiceAdv.Controls.Add(this.primaryDiscountRateTextBox);
            this.groupPanelInvoiceAdv.Controls.Add(primaryDiscountDaysLabel);
            this.groupPanelInvoiceAdv.Controls.Add(this.primaryDiscountDaysTextBox);
            this.groupPanelInvoiceAdv.Controls.Add(netPaymentTermsLabel);
            this.groupPanelInvoiceAdv.Controls.Add(this.netPaymentTermsTextBox);
            this.groupPanelInvoiceAdv.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelInvoiceAdv.Location = new System.Drawing.Point(1, 1);
            this.groupPanelInvoiceAdv.Name = "groupPanelInvoiceAdv";
            this.groupPanelInvoiceAdv.Size = new System.Drawing.Size(556, 185);
            // 
            // 
            // 
            this.groupPanelInvoiceAdv.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelInvoiceAdv.Style.BackColorGradientAngle = 90;
            this.groupPanelInvoiceAdv.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelInvoiceAdv.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceAdv.Style.BorderBottomWidth = 1;
            this.groupPanelInvoiceAdv.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelInvoiceAdv.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceAdv.Style.BorderLeftWidth = 1;
            this.groupPanelInvoiceAdv.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceAdv.Style.BorderRightWidth = 1;
            this.groupPanelInvoiceAdv.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelInvoiceAdv.Style.BorderTopWidth = 1;
            this.groupPanelInvoiceAdv.Style.Class = "";
            this.groupPanelInvoiceAdv.Style.CornerDiameter = 4;
            this.groupPanelInvoiceAdv.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelInvoiceAdv.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelInvoiceAdv.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelInvoiceAdv.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelInvoiceAdv.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelInvoiceAdv.StyleMouseOver.Class = "";
            this.groupPanelInvoiceAdv.TabIndex = 2;
            // 
            // invoiceReferenceNumberTextBox
            // 
            // 
            // 
            // 
            this.invoiceReferenceNumberTextBox.Border.Class = "TextBoxBorder";
            this.invoiceReferenceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceReferenceNumber", true));
            this.invoiceReferenceNumberTextBox.Location = new System.Drawing.Point(145, 156);
            this.invoiceReferenceNumberTextBox.Name = "invoiceReferenceNumberTextBox";
            this.invoiceReferenceNumberTextBox.Size = new System.Drawing.Size(120, 20);
            this.invoiceReferenceNumberTextBox.TabIndex = 15;
            // 
            // orderNumberReferenceTextBox
            // 
            // 
            // 
            // 
            this.orderNumberReferenceTextBox.Border.Class = "TextBoxBorder";
            this.orderNumberReferenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "OrderNumberReference", true));
            this.orderNumberReferenceTextBox.Location = new System.Drawing.Point(144, 134);
            this.orderNumberReferenceTextBox.Name = "orderNumberReferenceTextBox";
            this.orderNumberReferenceTextBox.Size = new System.Drawing.Size(121, 20);
            this.orderNumberReferenceTextBox.TabIndex = 13;
            // 
            // paymentConditionsComboBox
            // 
            this.paymentConditionsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PaymentConditions", true));
            this.paymentConditionsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paymentConditionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentConditionsComboBox.FormattingEnabled = true;
            this.paymentConditionsComboBox.Items.AddRange(new object[] {
            "Open account",
            "Bill of exchange against acceptance",
            "Bill of exchange against payment",
            "Documents through banks",
            "Instalment payment without draft",
            "Instalment payment with draft",
            "Other"});
            this.paymentConditionsComboBox.Location = new System.Drawing.Point(143, 110);
            this.paymentConditionsComboBox.Name = "paymentConditionsComboBox";
            this.paymentConditionsComboBox.Size = new System.Drawing.Size(122, 21);
            this.paymentConditionsComboBox.TabIndex = 11;
            // 
            // valueDateTextBox
            // 
            // 
            // 
            // 
            this.valueDateTextBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.valueDateTextBox.ButtonDropDown.Visible = true;
            this.valueDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "ValueDate", true));
            this.valueDateTextBox.Location = new System.Drawing.Point(423, 109);
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
            this.valueDateTextBox.TabIndex = 9;
            // 
            // secondaryDiscountRateTextBox
            // 
            // 
            // 
            // 
            this.secondaryDiscountRateTextBox.Border.Class = "TextBoxBorder";
            this.secondaryDiscountRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "SecondaryDiscountRate", true));
            this.secondaryDiscountRateTextBox.Location = new System.Drawing.Point(423, 83);
            this.secondaryDiscountRateTextBox.Name = "secondaryDiscountRateTextBox";
            this.secondaryDiscountRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondaryDiscountRateTextBox.TabIndex = 9;
            // 
            // secondaryDiscountDaysTextBox
            // 
            // 
            // 
            // 
            this.secondaryDiscountDaysTextBox.Border.Class = "TextBoxBorder";
            this.secondaryDiscountDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "SecondaryDiscountDays", true));
            this.secondaryDiscountDaysTextBox.Location = new System.Drawing.Point(143, 83);
            this.secondaryDiscountDaysTextBox.Name = "secondaryDiscountDaysTextBox";
            this.secondaryDiscountDaysTextBox.Size = new System.Drawing.Size(122, 20);
            this.secondaryDiscountDaysTextBox.TabIndex = 5;
            // 
            // primaryDiscountRateTextBox
            // 
            // 
            // 
            // 
            this.primaryDiscountRateTextBox.Border.Class = "TextBoxBorder";
            this.primaryDiscountRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PrimaryDiscountRate", true));
            this.primaryDiscountRateTextBox.Location = new System.Drawing.Point(423, 60);
            this.primaryDiscountRateTextBox.Name = "primaryDiscountRateTextBox";
            this.primaryDiscountRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.primaryDiscountRateTextBox.TabIndex = 7;
            // 
            // primaryDiscountDaysTextBox
            // 
            // 
            // 
            // 
            this.primaryDiscountDaysTextBox.Border.Class = "TextBoxBorder";
            this.primaryDiscountDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PrimaryDiscountDays", true));
            this.primaryDiscountDaysTextBox.Location = new System.Drawing.Point(143, 60);
            this.primaryDiscountDaysTextBox.Name = "primaryDiscountDaysTextBox";
            this.primaryDiscountDaysTextBox.Size = new System.Drawing.Size(122, 20);
            this.primaryDiscountDaysTextBox.TabIndex = 3;
            // 
            // netPaymentTermsTextBox
            // 
            // 
            // 
            // 
            this.netPaymentTermsTextBox.Border.Class = "TextBoxBorder";
            this.netPaymentTermsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "NetPaymentTerms", true));
            this.netPaymentTermsTextBox.Location = new System.Drawing.Point(143, 7);
            this.netPaymentTermsTextBox.Multiline = true;
            this.netPaymentTermsTextBox.Name = "netPaymentTermsTextBox";
            this.netPaymentTermsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.netPaymentTermsTextBox.Size = new System.Drawing.Size(380, 47);
            this.netPaymentTermsTextBox.TabIndex = 1;
            // 
            // tabItemEDI
            // 
            this.tabItemEDI.AttachedControl = this.tabPanelEDI;
            this.tabItemEDI.Name = "tabItemEDI";
            this.tabItemEDI.Text = "更多";
            // 
            // tabControlPanelDispute
            // 
            this.tabControlPanelDispute.Controls.Add(this.groupPanelDisputeResolve);
            this.tabControlPanelDispute.Controls.Add(this.groupPanelDispute);
            this.tabControlPanelDispute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelDispute.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanelDispute.Name = "tabControlPanelDispute";
            this.tabControlPanelDispute.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelDispute.Size = new System.Drawing.Size(558, 319);
            this.tabControlPanelDispute.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanelDispute.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanelDispute.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelDispute.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanelDispute.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelDispute.Style.GradientAngle = 90;
            this.tabControlPanelDispute.TabIndex = 5;
            this.tabControlPanelDispute.TabItem = this.tabItemDispute;
            // 
            // groupPanelDisputeResolve
            // 
            this.groupPanelDisputeResolve.AutoScroll = true;
            this.groupPanelDisputeResolve.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelDisputeResolve.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelDisputeResolve.Controls.Add(disputeResolveDateLabel);
            this.groupPanelDisputeResolve.Controls.Add(this.disputeResolveDateDateTimePicker);
            this.groupPanelDisputeResolve.Controls.Add(disputeResolveUserNameLabel);
            this.groupPanelDisputeResolve.Controls.Add(this.disputeResolveUserNameTextBox);
            this.groupPanelDisputeResolve.Controls.Add(disputeResolveReasonLabel);
            this.groupPanelDisputeResolve.Controls.Add(this.disputeResolveReasonTextBox);
            this.groupPanelDisputeResolve.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelDisputeResolve.Location = new System.Drawing.Point(1, 173);
            this.groupPanelDisputeResolve.Name = "groupPanelDisputeResolve";
            this.groupPanelDisputeResolve.Size = new System.Drawing.Size(556, 79);
            // 
            // 
            // 
            this.groupPanelDisputeResolve.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelDisputeResolve.Style.BackColorGradientAngle = 90;
            this.groupPanelDisputeResolve.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelDisputeResolve.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDisputeResolve.Style.BorderBottomWidth = 1;
            this.groupPanelDisputeResolve.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelDisputeResolve.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDisputeResolve.Style.BorderLeftWidth = 1;
            this.groupPanelDisputeResolve.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDisputeResolve.Style.BorderRightWidth = 1;
            this.groupPanelDisputeResolve.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDisputeResolve.Style.BorderTopWidth = 1;
            this.groupPanelDisputeResolve.Style.Class = "";
            this.groupPanelDisputeResolve.Style.CornerDiameter = 4;
            this.groupPanelDisputeResolve.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelDisputeResolve.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelDisputeResolve.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelDisputeResolve.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelDisputeResolve.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelDisputeResolve.StyleMouseOver.Class = "";
            this.groupPanelDisputeResolve.TabIndex = 1;
            // 
            // disputeResolveDateDateTimePicker
            // 
            // 
            // 
            // 
            this.disputeResolveDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.disputeResolveDateDateTimePicker.ButtonDropDown.Visible = true;
            this.disputeResolveDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "DisputeResolveDate", true));
            this.disputeResolveDateDateTimePicker.Location = new System.Drawing.Point(442, 3);
            // 
            // 
            // 
            this.disputeResolveDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.disputeResolveDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.disputeResolveDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.disputeResolveDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.disputeResolveDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.disputeResolveDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.disputeResolveDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.disputeResolveDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.disputeResolveDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.disputeResolveDateDateTimePicker.Name = "disputeResolveDateDateTimePicker";
            this.disputeResolveDateDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.disputeResolveDateDateTimePicker.TabIndex = 7;
            // 
            // disputeResolveUserNameTextBox
            // 
            // 
            // 
            // 
            this.disputeResolveUserNameTextBox.Border.Class = "TextBoxBorder";
            this.disputeResolveUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DisputeResolveUserName", true));
            this.disputeResolveUserNameTextBox.Location = new System.Drawing.Point(442, 29);
            this.disputeResolveUserNameTextBox.Name = "disputeResolveUserNameTextBox";
            this.disputeResolveUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.disputeResolveUserNameTextBox.TabIndex = 6;
            // 
            // disputeResolveReasonTextBox
            // 
            // 
            // 
            // 
            this.disputeResolveReasonTextBox.Border.Class = "TextBoxBorder";
            this.disputeResolveReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DisputeResolveReason", true));
            this.disputeResolveReasonTextBox.Location = new System.Drawing.Point(86, 3);
            this.disputeResolveReasonTextBox.Multiline = true;
            this.disputeResolveReasonTextBox.Name = "disputeResolveReasonTextBox";
            this.disputeResolveReasonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.disputeResolveReasonTextBox.Size = new System.Drawing.Size(296, 61);
            this.disputeResolveReasonTextBox.TabIndex = 5;
            // 
            // groupPanelDispute
            // 
            this.groupPanelDispute.AutoScroll = true;
            this.groupPanelDispute.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelDispute.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelDispute.Controls.Add(this.tbDisputeReason);
            this.groupPanelDispute.Controls.Add(this.disputeReasonCheckedListBox);
            this.groupPanelDispute.Controls.Add(this.disputeTypeComboBoxEx);
            this.groupPanelDispute.Controls.Add(disputeAmountLabel);
            this.groupPanelDispute.Controls.Add(this.disputeAmountTextBox);
            this.groupPanelDispute.Controls.Add(disputeUserNameLabel);
            this.groupPanelDispute.Controls.Add(disputeDateLabel);
            this.groupPanelDispute.Controls.Add(this.disputeDateDateTimePicker);
            this.groupPanelDispute.Controls.Add(this.disputeUserNameTextBox);
            this.groupPanelDispute.Controls.Add(disputeTypeLabel);
            this.groupPanelDispute.Controls.Add(disputeReasonLabel);
            this.groupPanelDispute.Controls.Add(this.isDisputeCheckBox);
            this.groupPanelDispute.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelDispute.Location = new System.Drawing.Point(1, 1);
            this.groupPanelDispute.Name = "groupPanelDispute";
            this.groupPanelDispute.Size = new System.Drawing.Size(556, 172);
            // 
            // 
            // 
            this.groupPanelDispute.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelDispute.Style.BackColorGradientAngle = 90;
            this.groupPanelDispute.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelDispute.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDispute.Style.BorderBottomWidth = 1;
            this.groupPanelDispute.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelDispute.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDispute.Style.BorderLeftWidth = 1;
            this.groupPanelDispute.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDispute.Style.BorderRightWidth = 1;
            this.groupPanelDispute.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDispute.Style.BorderTopWidth = 1;
            this.groupPanelDispute.Style.Class = "";
            this.groupPanelDispute.Style.CornerDiameter = 4;
            this.groupPanelDispute.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelDispute.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelDispute.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelDispute.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelDispute.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanelDispute.StyleMouseOver.Class = "";
            this.groupPanelDispute.TabIndex = 0;
            // 
            // disputeTypeComboBoxEx
            // 
            this.disputeTypeComboBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DisputeType", true));
            this.disputeTypeComboBoxEx.DisplayMember = "Text";
            this.disputeTypeComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.disputeTypeComboBoxEx.FormattingEnabled = true;
            this.disputeTypeComboBoxEx.ItemHeight = 14;
            this.disputeTypeComboBoxEx.Location = new System.Drawing.Point(85, 109);
            this.disputeTypeComboBoxEx.Name = "disputeTypeComboBoxEx";
            this.disputeTypeComboBoxEx.Size = new System.Drawing.Size(100, 20);
            this.disputeTypeComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.disputeTypeComboBoxEx.TabIndex = 9;
            this.disputeTypeComboBoxEx.Items.AddRange(new string[]{
            "Invoice (default)",
            "Credit note",
            "Non factored invoice",
            "Non factored credit note",
            "Payment"
            });
            // 
            // disputeAmountTextBox
            // 
            // 
            // 
            // 
            this.disputeAmountTextBox.Border.Class = "TextBoxBorder";
            this.disputeAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DisputeAmount", true));
            this.disputeAmountTextBox.Location = new System.Drawing.Point(85, 130);
            this.disputeAmountTextBox.Name = "disputeAmountTextBox";
            this.disputeAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.disputeAmountTextBox.TabIndex = 8;
            // 
            // disputeDateDateTimePicker
            // 
            // 
            // 
            // 
            this.disputeDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.disputeDateDateTimePicker.ButtonDropDown.Visible = true;
            this.disputeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "DisputeDate", true));
            this.disputeDateDateTimePicker.Location = new System.Drawing.Point(282, 109);
            // 
            // 
            // 
            this.disputeDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.disputeDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.disputeDateDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            // 
            // 
            // 
            this.disputeDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.disputeDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.disputeDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.disputeDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.disputeDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.disputeDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.disputeDateDateTimePicker.Name = "disputeDateDateTimePicker";
            this.disputeDateDateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.disputeDateDateTimePicker.TabIndex = 4;
            // 
            // disputeUserNameTextBox
            // 
            // 
            // 
            // 
            this.disputeUserNameTextBox.Border.Class = "TextBoxBorder";
            this.disputeUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DisputeUserName", true));
            this.disputeUserNameTextBox.Location = new System.Drawing.Point(282, 132);
            this.disputeUserNameTextBox.Name = "disputeUserNameTextBox";
            this.disputeUserNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.disputeUserNameTextBox.TabIndex = 6;
            // 
            // isDisputeCheckBox
            // 
            this.isDisputeCheckBox.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isDisputeCheckBox.BackgroundStyle.Class = "";
            this.isDisputeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "IsDispute", true));
            this.isDisputeCheckBox.Location = new System.Drawing.Point(19, 7);
            this.isDisputeCheckBox.Name = "isDisputeCheckBox";
            this.isDisputeCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isDisputeCheckBox.TabIndex = 1;
            this.isDisputeCheckBox.Text = "是否商纠";
            // 
            // tabItemDispute
            // 
            this.tabItemDispute.AttachedControl = this.tabControlPanelDispute;
            this.tabItemDispute.Name = "tabItemDispute";
            this.tabItemDispute.Text = "商纠处理";
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
            // disputeReasonCheckedListBox
            // 
            this.disputeReasonCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceBindingSource, "FlawReason", true));
            this.disputeReasonCheckedListBox.FormattingEnabled = true;
            this.disputeReasonCheckedListBox.Items.AddRange(new object[] {
            "Settlement agreed with seller",
            "Direct payment to Export Factor",
            "Direct payment to seller",
            "Direct payment to seller’s agent",
            "Invoice not received",
            "Duplicate invoice",
            "Wrong invoice details",
            "Credit note to buyer, not to us",
            "Debit note to seller",
            "Offset against credit balances or other invoices",
            "Discount beyond terms",
            "Trade discount deducted",
            "Counter claim",
            "Deduction for other costs",
            "Wrong delivery",
            "Proof of delivery required",
            "Wrong goods",
            "Damaged goods",
            "Goods on consignment",
            "Goods returned to seller",
            "Goods returned to agent",
            "Buyer refuses delivery",
            "Other reasons, see message text"});
            this.disputeReasonCheckedListBox.Location = new System.Drawing.Point(178, 7);
            this.disputeReasonCheckedListBox.Name = "disputeReasonCheckedListBox";
            this.disputeReasonCheckedListBox.Size = new System.Drawing.Size(193, 94);
            this.disputeReasonCheckedListBox.TabIndex = 10;
            // 
            // tbDisputeReason
            // 
            // 
            // 
            // 
            this.tbDisputeReason.Border.Class = "TextBoxBorder";
            this.tbDisputeReason.Location = new System.Drawing.Point(377, 7);
            this.tbDisputeReason.Multiline = true;
            this.tbDisputeReason.Name = "tbDisputeReason";
            this.tbDisputeReason.Size = new System.Drawing.Size(170, 94);
            this.tbDisputeReason.TabIndex = 11;
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 345);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.Name = "InvoiceDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "发票详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPanelInvoice.ResumeLayout(false);
            this.groupPanelInvoiceProcess.ResumeLayout(false);
            this.groupPanelInvoiceProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commissionDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDueDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignDateTextBox)).EndInit();
            this.groupPanelInvoiceBasic.ResumeLayout(false);
            this.groupPanelInvoiceBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dueDateTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDateTextBox)).EndInit();
            this.tabPanelFlaw.ResumeLayout(false);
            this.groupPanelFlawResolve.ResumeLayout(false);
            this.groupPanelFlawResolve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flawResolveDateDateTimePicker)).EndInit();
            this.groupPanelFlaw.ResumeLayout(false);
            this.groupPanelFlaw.PerformLayout();
            this.tabPanelEDI.ResumeLayout(false);
            this.groupPanelInvoiceAdv.ResumeLayout(false);
            this.groupPanelInvoiceAdv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueDateTextBox)).EndInit();
            this.tabControlPanelDispute.ResumeLayout(false);
            this.groupPanelDisputeResolve.ResumeLayout(false);
            this.groupPanelDisputeResolve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disputeResolveDateDateTimePicker)).EndInit();
            this.groupPanelDispute.ResumeLayout(false);
            this.groupPanelDispute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disputeDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
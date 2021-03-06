//-----------------------------------------------------------------------
// <copyright file="InvoiceDetail.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceDetail
    {
		#region?Fields?(104)?

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.Controls.TextBoxX assignAmountTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput assignDateTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX assignOutstandingTextBox;
        private DevComponents.DotNetBar.ButtonX btnDispute;
        private DevComponents.DotNetBar.ButtonX btnDisputeResolve;
        private DevComponents.DotNetBar.ButtonX btnDisputeSave;
        private DevComponents.DotNetBar.ButtonX btnEDISave;
        private DevComponents.DotNetBar.ButtonX btnFlaw;
        private DevComponents.DotNetBar.ButtonX btnFlawResolve;
        private DevComponents.DotNetBar.ButtonX btnFlawSave;
        private DevComponents.DotNetBar.ButtonX btnInvoiceSave;
        private DevComponents.DotNetBar.ButtonX btnInvoiceUpdate;
        private DevComponents.DotNetBar.Controls.TextBoxX commentTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX paidCommissionTextBox;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFinanceLogs;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPaymentLogs;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRefundLogs;
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
        private DevComponents.DotNetBar.Controls.TextBoxX financeOutstandingTextBox;
        private System.Windows.Forms.CheckedListBox flawReasonCheckedListBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput flawResolveDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX flawResolveUserNameTextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelDispute;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelDisputeResolve;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelFlaw;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelFlawResolve;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelInvoiceAdv;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelInvoiceBasic;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelInvoiceProcess;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceAmountTextBox;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx invoiceCurrencyComboBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput invoiceDateTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceNoTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX invoiceReferenceNumberTextBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX isDisputeCheckBox;
        private DevComponents.DotNetBar.Controls.CheckBoxX isFlawCheckBox;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaymentLogDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemRefundLogDelete;
        private DevComponents.DotNetBar.Controls.TextBoxX interestTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX netPaymentTermsTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX orderNumberReferenceTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX paymentAmountTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx paymentConditionsComboBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput paymentDateDateTimePicker;
        private System.Windows.Forms.ContextMenuStrip paymentLogMgr;
        private DevComponents.DotNetBar.Controls.TextBoxX primaryDiscountDaysTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX primaryDiscountRateTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX refundAmountTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput refundDateDateTimePicker;
        private System.Windows.Forms.ContextMenuStrip refundLogMgr;
        private DevComponents.DotNetBar.Controls.TextBoxX secondaryDiscountDaysTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX secondaryDiscountRateTextBox;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.TabControl tabControl;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanelDispute;
        private DevComponents.DotNetBar.TabItem tabItemDispute;
        private DevComponents.DotNetBar.TabItem tabItemEDI;
        private DevComponents.DotNetBar.TabItem tabItemFlaw;
        private DevComponents.DotNetBar.TabItem tabItemInvoice;
        private DevComponents.DotNetBar.TabItem tabItemLog;
        private DevComponents.DotNetBar.TabControlPanel tabPanelEDI;
        private DevComponents.DotNetBar.TabControlPanel tabPanelFlaw;
        private DevComponents.DotNetBar.TabControlPanel tabPanelInvoice;
        private DevComponents.DotNetBar.TabControlPanel tabPanelLog;
        private DevComponents.DotNetBar.Controls.TextBoxX tbAssignBatch;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDisputeReason;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceBatch;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFlawReason;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFlawResolveReason;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPaymentBatch;
        private DevComponents.DotNetBar.Controls.TextBoxX tbRefundBatch;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput valueDateTextBox;

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

            if (this._context != null)
            {
                this._context.Dispose();
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
            DevComponents.DotNetBar.LabelX paidCommissionLabel;
            DevComponents.DotNetBar.LabelX interestLabel;
            DevComponents.DotNetBar.LabelX commentLabel;
            DevComponents.DotNetBar.LabelX disputeReasonLabel;
            DevComponents.DotNetBar.LabelX disputeDateLabel;
            DevComponents.DotNetBar.LabelX disputeResolveReasonLabel;
            DevComponents.DotNetBar.LabelX disputeResolveUserNameLabel;
            DevComponents.DotNetBar.LabelX disputeTypeLabel;
            DevComponents.DotNetBar.LabelX disputeUserNameLabel;
            DevComponents.DotNetBar.LabelX disputeAmountLabel;
            DevComponents.DotNetBar.LabelX disputeResolveDateLabel;
            DevComponents.DotNetBar.LabelX assignBatchNoLabel;
            DevComponents.DotNetBar.LabelX financeBatchNoLabel;
            DevComponents.DotNetBar.LabelX lblRefundBatch;
            DevComponents.DotNetBar.LabelX lblPaymentBatch;
            DevComponents.DotNetBar.LabelX lblFinanceBatch;
            DevComponents.DotNetBar.LabelX lblAssignBatch;
            DevComponents.DotNetBar.LabelX lblFactorCommission;
            DevComponents.DotNetBar.LabelX unpaidCommissionLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new DevComponents.DotNetBar.TabControl();
            this.tabPanelInvoice = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanelInvoiceProcess = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.unpaidCommissionTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFactorCommission = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbRefundBatch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbPaymentBatch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFinanceBatch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbAssignBatch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeOutstandingTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.assignOutstandingTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.interestTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.paidCommissionTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
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
            this.btnInvoiceSave = new DevComponents.DotNetBar.ButtonX();
            this.btnInvoiceUpdate = new DevComponents.DotNetBar.ButtonX();
            this.tabItemInvoice = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelLog = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvPaymentLogs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colPaymentCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditNoteNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditNoteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentLogMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemPaymentLogDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFinanceLogs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvRefundLogs = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colRefundCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRefundDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundLogMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemRefundLogDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabItemLog = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelFlaw = new DevComponents.DotNetBar.TabControlPanel();
            this.btnFlawSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelFlawResolve = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnFlawResolve = new DevComponents.DotNetBar.ButtonX();
            this.tbFlawResolveReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.flawResolveDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.flawResolveUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelFlaw = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.isFlawCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnFlaw = new DevComponents.DotNetBar.ButtonX();
            this.tbFlawReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.flawReasonCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tabItemFlaw = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanelDispute = new DevComponents.DotNetBar.TabControlPanel();
            this.btnDisputeSave = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelDisputeResolve = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnDisputeResolve = new DevComponents.DotNetBar.ButtonX();
            this.disputeResolveDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.disputeResolveUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.disputeResolveReasonTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelDispute = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.isDisputeCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnDispute = new DevComponents.DotNetBar.ButtonX();
            this.tbDisputeReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.disputeReasonCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.disputeTypeComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.disputeAmountTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.disputeDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.disputeUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tabItemDispute = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabPanelEDI = new DevComponents.DotNetBar.TabControlPanel();
            this.btnEDISave = new DevComponents.DotNetBar.ButtonX();
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
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReassignDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceRateType1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceRateType2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceInterest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            paidCommissionLabel = new DevComponents.DotNetBar.LabelX();
            interestLabel = new DevComponents.DotNetBar.LabelX();
            commentLabel = new DevComponents.DotNetBar.LabelX();
            disputeReasonLabel = new DevComponents.DotNetBar.LabelX();
            disputeDateLabel = new DevComponents.DotNetBar.LabelX();
            disputeResolveReasonLabel = new DevComponents.DotNetBar.LabelX();
            disputeResolveUserNameLabel = new DevComponents.DotNetBar.LabelX();
            disputeTypeLabel = new DevComponents.DotNetBar.LabelX();
            disputeUserNameLabel = new DevComponents.DotNetBar.LabelX();
            disputeAmountLabel = new DevComponents.DotNetBar.LabelX();
            disputeResolveDateLabel = new DevComponents.DotNetBar.LabelX();
            assignBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            financeBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            lblRefundBatch = new DevComponents.DotNetBar.LabelX();
            lblPaymentBatch = new DevComponents.DotNetBar.LabelX();
            lblFinanceBatch = new DevComponents.DotNetBar.LabelX();
            lblAssignBatch = new DevComponents.DotNetBar.LabelX();
            lblFactorCommission = new DevComponents.DotNetBar.LabelX();
            unpaidCommissionLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPanelInvoice.SuspendLayout();
            this.groupPanelInvoiceProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDueDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDateDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignDateTextBox)).BeginInit();
            this.groupPanelInvoiceBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dueDateTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDateTextBox)).BeginInit();
            this.tabPanelLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentLogs)).BeginInit();
            this.paymentLogMgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundLogs)).BeginInit();
            this.refundLogMgr.SuspendLayout();
            this.tabPanelFlaw.SuspendLayout();
            this.groupPanelFlawResolve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flawResolveDateDateTimePicker)).BeginInit();
            this.groupPanelFlaw.SuspendLayout();
            this.tabControlPanelDispute.SuspendLayout();
            this.groupPanelDisputeResolve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disputeResolveDateDateTimePicker)).BeginInit();
            this.groupPanelDispute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disputeDateDateTimePicker)).BeginInit();
            this.tabPanelEDI.SuspendLayout();
            this.groupPanelInvoiceAdv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueDateTextBox)).BeginInit();
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
            flawResolveReasonLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            flawResolveReasonLabel.Location = new System.Drawing.Point(23, 32);
            flawResolveReasonLabel.Name = "flawResolveReasonLabel";
            flawResolveReasonLabel.Size = new System.Drawing.Size(62, 18);
            flawResolveReasonLabel.TabIndex = 1;
            flawResolveReasonLabel.Text = "解除原因:";
            // 
            // flawResolveDateLabel
            // 
            flawResolveDateLabel.AutoSize = true;
            flawResolveDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            flawResolveDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            flawResolveDateLabel.Location = new System.Drawing.Point(106, 87);
            flawResolveDateLabel.Name = "flawResolveDateLabel";
            flawResolveDateLabel.Size = new System.Drawing.Size(50, 18);
            flawResolveDateLabel.TabIndex = 3;
            flawResolveDateLabel.Text = "解除日:";
            // 
            // flawResolveUserNameLabel
            // 
            flawResolveUserNameLabel.AutoSize = true;
            flawResolveUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            flawResolveUserNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            flawResolveUserNameLabel.Location = new System.Drawing.Point(271, 87);
            flawResolveUserNameLabel.Name = "flawResolveUserNameLabel";
            flawResolveUserNameLabel.Size = new System.Drawing.Size(50, 18);
            flawResolveUserNameLabel.TabIndex = 5;
            flawResolveUserNameLabel.Text = "经办人:";
            // 
            // assignDateLabel
            // 
            assignDateLabel.AutoSize = true;
            assignDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            assignDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            assignDateLabel.Location = new System.Drawing.Point(179, 3);
            assignDateLabel.Name = "assignDateLabel";
            assignDateLabel.Size = new System.Drawing.Size(50, 18);
            assignDateLabel.TabIndex = 2;
            assignDateLabel.Text = "转让日:";
            // 
            // assignAmountLabel
            // 
            assignAmountLabel.AutoSize = true;
            assignAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            assignAmountLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            assignAmountLabel.Location = new System.Drawing.Point(8, 3);
            assignAmountLabel.Name = "assignAmountLabel";
            assignAmountLabel.Size = new System.Drawing.Size(62, 18);
            assignAmountLabel.TabIndex = 0;
            assignAmountLabel.Text = "转让金额:";
            // 
            // dueDateLabel
            // 
            dueDateLabel.AutoSize = true;
            dueDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            dueDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            dueDateLabel.Location = new System.Drawing.Point(370, 26);
            dueDateLabel.Name = "dueDateLabel";
            dueDateLabel.Size = new System.Drawing.Size(50, 18);
            dueDateLabel.TabIndex = 10;
            dueDateLabel.Text = "到期日:";
            // 
            // invoiceAmountLabel
            // 
            invoiceAmountLabel.AutoSize = true;
            invoiceAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceAmountLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            invoiceAmountLabel.Location = new System.Drawing.Point(8, 28);
            invoiceAmountLabel.Name = "invoiceAmountLabel";
            invoiceAmountLabel.Size = new System.Drawing.Size(62, 18);
            invoiceAmountLabel.TabIndex = 6;
            invoiceAmountLabel.Text = "票面金额:";
            // 
            // invoiceDateLabel
            // 
            invoiceDateLabel.AutoSize = true;
            invoiceDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            invoiceDateLabel.Location = new System.Drawing.Point(179, 26);
            invoiceDateLabel.Name = "invoiceDateLabel";
            invoiceDateLabel.Size = new System.Drawing.Size(50, 18);
            invoiceDateLabel.TabIndex = 8;
            invoiceDateLabel.Text = "发票日:";
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            invoiceNoLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            invoiceNoLabel.Location = new System.Drawing.Point(20, 5);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(50, 18);
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
            flawReasonLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            flawReasonLabel.Location = new System.Drawing.Point(21, 67);
            flawReasonLabel.Name = "flawReasonLabel";
            flawReasonLabel.Size = new System.Drawing.Size(62, 18);
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
            invoiceReferenceNumberLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            invoiceReferenceNumberLabel.Location = new System.Drawing.Point(-1, 150);
            invoiceReferenceNumberLabel.Name = "invoiceReferenceNumberLabel";
            invoiceReferenceNumberLabel.Size = new System.Drawing.Size(161, 16);
            invoiceReferenceNumberLabel.TabIndex = 16;
            invoiceReferenceNumberLabel.Text = "Invoice Reference Number:";
            // 
            // orderNumberReferenceLabel
            // 
            orderNumberReferenceLabel.AutoSize = true;
            orderNumberReferenceLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            orderNumberReferenceLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            orderNumberReferenceLabel.Location = new System.Drawing.Point(8, 126);
            orderNumberReferenceLabel.Name = "orderNumberReferenceLabel";
            orderNumberReferenceLabel.Size = new System.Drawing.Size(149, 16);
            orderNumberReferenceLabel.TabIndex = 14;
            orderNumberReferenceLabel.Text = "Order Number Reference:";
            // 
            // paymentConditionsLabel
            // 
            paymentConditionsLabel.AutoSize = true;
            paymentConditionsLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            paymentConditionsLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            paymentConditionsLabel.Location = new System.Drawing.Point(34, 104);
            paymentConditionsLabel.Name = "paymentConditionsLabel";
            paymentConditionsLabel.Size = new System.Drawing.Size(124, 16);
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
            valueDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            valueDateLabel.Location = new System.Drawing.Point(352, 102);
            valueDateLabel.Name = "valueDateLabel";
            valueDateLabel.Size = new System.Drawing.Size(75, 16);
            valueDateLabel.TabIndex = 12;
            valueDateLabel.Text = "Value Date:";
            // 
            // secondaryDiscountRateLabel
            // 
            secondaryDiscountRateLabel.AutoSize = true;
            secondaryDiscountRateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            secondaryDiscountRateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            secondaryDiscountRateLabel.Location = new System.Drawing.Point(285, 79);
            secondaryDiscountRateLabel.Name = "secondaryDiscountRateLabel";
            secondaryDiscountRateLabel.Size = new System.Drawing.Size(155, 16);
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
            secondaryDiscountDaysLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            secondaryDiscountDaysLabel.Location = new System.Drawing.Point(3, 82);
            secondaryDiscountDaysLabel.Name = "secondaryDiscountDaysLabel";
            secondaryDiscountDaysLabel.Size = new System.Drawing.Size(155, 16);
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
            primaryDiscountRateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            primaryDiscountRateLabel.Location = new System.Drawing.Point(295, 59);
            primaryDiscountRateLabel.Name = "primaryDiscountRateLabel";
            primaryDiscountRateLabel.Size = new System.Drawing.Size(143, 16);
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
            primaryDiscountDaysLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            primaryDiscountDaysLabel.Location = new System.Drawing.Point(13, 57);
            primaryDiscountDaysLabel.Name = "primaryDiscountDaysLabel";
            primaryDiscountDaysLabel.Size = new System.Drawing.Size(143, 16);
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
            netPaymentTermsLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            netPaymentTermsLabel.Location = new System.Drawing.Point(34, 10);
            netPaymentTermsLabel.Name = "netPaymentTermsLabel";
            netPaymentTermsLabel.Size = new System.Drawing.Size(118, 16);
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
            invoiceCurrencyLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            invoiceCurrencyLabel.Location = new System.Drawing.Point(192, 6);
            invoiceCurrencyLabel.Name = "invoiceCurrencyLabel";
            invoiceCurrencyLabel.Size = new System.Drawing.Size(37, 18);
            invoiceCurrencyLabel.TabIndex = 2;
            invoiceCurrencyLabel.Text = "币别:";
            // 
            // financeAmountLabel
            // 
            financeAmountLabel.AutoSize = true;
            financeAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeAmountLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeAmountLabel.Location = new System.Drawing.Point(8, 22);
            financeAmountLabel.Name = "financeAmountLabel";
            financeAmountLabel.Size = new System.Drawing.Size(62, 18);
            financeAmountLabel.TabIndex = 4;
            financeAmountLabel.Text = "融资金额:";
            // 
            // financeDateLabel
            // 
            financeDateLabel.AutoSize = true;
            financeDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeDateLabel.Location = new System.Drawing.Point(179, 22);
            financeDateLabel.Name = "financeDateLabel";
            financeDateLabel.Size = new System.Drawing.Size(50, 18);
            financeDateLabel.TabIndex = 6;
            financeDateLabel.Text = "融资日:";
            // 
            // financeDueDateLabel
            // 
            financeDueDateLabel.AutoSize = true;
            financeDueDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeDueDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeDueDateLabel.Location = new System.Drawing.Point(154, 42);
            financeDueDateLabel.Name = "financeDueDateLabel";
            financeDueDateLabel.Size = new System.Drawing.Size(74, 18);
            financeDueDateLabel.TabIndex = 8;
            financeDueDateLabel.Text = "预计回购日:";
            // 
            // paymentAmountLabel
            // 
            paymentAmountLabel.AutoSize = true;
            paymentAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            paymentAmountLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            paymentAmountLabel.Location = new System.Drawing.Point(8, 61);
            paymentAmountLabel.Name = "paymentAmountLabel";
            paymentAmountLabel.Size = new System.Drawing.Size(62, 18);
            paymentAmountLabel.TabIndex = 10;
            paymentAmountLabel.Text = "付款金额:";
            // 
            // paymentDateLabel
            // 
            paymentDateLabel.AutoSize = true;
            paymentDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            paymentDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            paymentDateLabel.Location = new System.Drawing.Point(179, 61);
            paymentDateLabel.Name = "paymentDateLabel";
            paymentDateLabel.Size = new System.Drawing.Size(50, 18);
            paymentDateLabel.TabIndex = 12;
            paymentDateLabel.Text = "付款日:";
            // 
            // refundAmountLabel
            // 
            refundAmountLabel.AutoSize = true;
            refundAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            refundAmountLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            refundAmountLabel.Location = new System.Drawing.Point(8, 81);
            refundAmountLabel.Name = "refundAmountLabel";
            refundAmountLabel.Size = new System.Drawing.Size(62, 18);
            refundAmountLabel.TabIndex = 14;
            refundAmountLabel.Text = "还款金额:";
            // 
            // refundDateLabel
            // 
            refundDateLabel.AutoSize = true;
            refundDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            refundDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            refundDateLabel.Location = new System.Drawing.Point(179, 81);
            refundDateLabel.Name = "refundDateLabel";
            refundDateLabel.Size = new System.Drawing.Size(50, 18);
            refundDateLabel.TabIndex = 16;
            refundDateLabel.Text = "还款日:";
            // 
            // paidCommissionLabel
            // 
            paidCommissionLabel.AutoSize = true;
            paidCommissionLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            paidCommissionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            paidCommissionLabel.Location = new System.Drawing.Point(-1, 99);
            paidCommissionLabel.Name = "paidCommissionLabel";
            paidCommissionLabel.Size = new System.Drawing.Size(74, 18);
            paidCommissionLabel.TabIndex = 18;
            paidCommissionLabel.Text = "已收手续费:";
            // 
            // interestLabel
            // 
            interestLabel.AutoSize = true;
            interestLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            interestLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            interestLabel.Location = new System.Drawing.Point(179, 123);
            interestLabel.Name = "interestLabel";
            interestLabel.Size = new System.Drawing.Size(62, 18);
            interestLabel.TabIndex = 22;
            interestLabel.Text = "利息收入:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            commentLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            commentLabel.Location = new System.Drawing.Point(31, 48);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(37, 18);
            commentLabel.TabIndex = 12;
            commentLabel.Text = "备注:";
            // 
            // disputeReasonLabel
            // 
            disputeReasonLabel.AutoSize = true;
            disputeReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeReasonLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            disputeReasonLabel.Location = new System.Drawing.Point(19, 63);
            disputeReasonLabel.Name = "disputeReasonLabel";
            disputeReasonLabel.Size = new System.Drawing.Size(62, 18);
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
            disputeDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            disputeDateLabel.Location = new System.Drawing.Point(317, 118);
            disputeDateLabel.Name = "disputeDateLabel";
            disputeDateLabel.Size = new System.Drawing.Size(50, 18);
            disputeDateLabel.TabIndex = 6;
            disputeDateLabel.Text = "商纠日:";
            // 
            // disputeResolveReasonLabel
            // 
            disputeResolveReasonLabel.AutoSize = true;
            disputeResolveReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeResolveReasonLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            disputeResolveReasonLabel.Location = new System.Drawing.Point(19, 35);
            disputeResolveReasonLabel.Name = "disputeResolveReasonLabel";
            disputeResolveReasonLabel.Size = new System.Drawing.Size(62, 18);
            disputeResolveReasonLabel.TabIndex = 1;
            disputeResolveReasonLabel.Text = "解除原因:";
            // 
            // disputeResolveUserNameLabel
            // 
            disputeResolveUserNameLabel.AutoSize = true;
            disputeResolveUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeResolveUserNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            disputeResolveUserNameLabel.Location = new System.Drawing.Point(317, 65);
            disputeResolveUserNameLabel.Name = "disputeResolveUserNameLabel";
            disputeResolveUserNameLabel.Size = new System.Drawing.Size(50, 18);
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
            disputeTypeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            disputeTypeLabel.Location = new System.Drawing.Point(107, 116);
            disputeTypeLabel.Name = "disputeTypeLabel";
            disputeTypeLabel.Size = new System.Drawing.Size(62, 18);
            disputeTypeLabel.TabIndex = 4;
            disputeTypeLabel.Text = "商纠类型:";
            // 
            // disputeUserNameLabel
            // 
            disputeUserNameLabel.AutoSize = true;
            disputeUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeUserNameLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            disputeUserNameLabel.Location = new System.Drawing.Point(317, 136);
            disputeUserNameLabel.Name = "disputeUserNameLabel";
            disputeUserNameLabel.Size = new System.Drawing.Size(50, 18);
            disputeUserNameLabel.TabIndex = 10;
            disputeUserNameLabel.Text = "经办人:";
            // 
            // disputeAmountLabel
            // 
            disputeAmountLabel.AutoSize = true;
            disputeAmountLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeAmountLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            disputeAmountLabel.Location = new System.Drawing.Point(107, 137);
            disputeAmountLabel.Name = "disputeAmountLabel";
            disputeAmountLabel.Size = new System.Drawing.Size(62, 18);
            disputeAmountLabel.TabIndex = 8;
            disputeAmountLabel.Text = "商纠金额:";
            // 
            // disputeResolveDateLabel
            // 
            disputeResolveDateLabel.AutoSize = true;
            disputeResolveDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            disputeResolveDateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            disputeResolveDateLabel.Location = new System.Drawing.Point(119, 65);
            disputeResolveDateLabel.Name = "disputeResolveDateLabel";
            disputeResolveDateLabel.Size = new System.Drawing.Size(50, 18);
            disputeResolveDateLabel.TabIndex = 3;
            disputeResolveDateLabel.Text = "解除日:";
            // 
            // assignBatchNoLabel
            // 
            assignBatchNoLabel.AutoSize = true;
            assignBatchNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            assignBatchNoLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            assignBatchNoLabel.Location = new System.Drawing.Point(367, 4);
            assignBatchNoLabel.Name = "assignBatchNoLabel";
            assignBatchNoLabel.Size = new System.Drawing.Size(62, 18);
            assignBatchNoLabel.TabIndex = 26;
            assignBatchNoLabel.Text = "转让余额:";
            // 
            // financeBatchNoLabel
            // 
            financeBatchNoLabel.AutoSize = true;
            financeBatchNoLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            financeBatchNoLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeBatchNoLabel.Location = new System.Drawing.Point(367, 21);
            financeBatchNoLabel.Name = "financeBatchNoLabel";
            financeBatchNoLabel.Size = new System.Drawing.Size(62, 18);
            financeBatchNoLabel.TabIndex = 28;
            financeBatchNoLabel.Text = "融资余额:";
            // 
            // lblRefundBatch
            // 
            lblRefundBatch.AutoSize = true;
            lblRefundBatch.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblRefundBatch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblRefundBatch.Location = new System.Drawing.Point(366, 103);
            lblRefundBatch.Name = "lblRefundBatch";
            lblRefundBatch.Size = new System.Drawing.Size(62, 18);
            lblRefundBatch.TabIndex = 36;
            lblRefundBatch.Text = "还款批次:";
            // 
            // lblPaymentBatch
            // 
            lblPaymentBatch.AutoSize = true;
            lblPaymentBatch.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblPaymentBatch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblPaymentBatch.Location = new System.Drawing.Point(366, 84);
            lblPaymentBatch.Name = "lblPaymentBatch";
            lblPaymentBatch.Size = new System.Drawing.Size(62, 18);
            lblPaymentBatch.TabIndex = 34;
            lblPaymentBatch.Text = "付款批次:";
            // 
            // lblFinanceBatch
            // 
            lblFinanceBatch.AutoSize = true;
            lblFinanceBatch.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblFinanceBatch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblFinanceBatch.Location = new System.Drawing.Point(367, 64);
            lblFinanceBatch.Name = "lblFinanceBatch";
            lblFinanceBatch.Size = new System.Drawing.Size(62, 18);
            lblFinanceBatch.TabIndex = 32;
            lblFinanceBatch.Text = "融资批次:";
            // 
            // lblAssignBatch
            // 
            lblAssignBatch.AutoSize = true;
            lblAssignBatch.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblAssignBatch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblAssignBatch.Location = new System.Drawing.Point(367, 44);
            lblAssignBatch.Name = "lblAssignBatch";
            lblAssignBatch.Size = new System.Drawing.Size(62, 18);
            lblAssignBatch.TabIndex = 30;
            lblAssignBatch.Text = "转让批次:";
            // 
            // lblFactorCommission
            // 
            lblFactorCommission.AutoSize = true;
            lblFactorCommission.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            lblFactorCommission.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblFactorCommission.Location = new System.Drawing.Point(179, 101);
            lblFactorCommission.Name = "lblFactorCommission";
            lblFactorCommission.Size = new System.Drawing.Size(62, 18);
            lblFactorCommission.TabIndex = 40;
            lblFactorCommission.Text = "IF手续费:";
            // 
            // unpaidCommissionLabel
            // 
            unpaidCommissionLabel.AutoSize = true;
            unpaidCommissionLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            unpaidCommissionLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            unpaidCommissionLabel.Location = new System.Drawing.Point(-1, 120);
            unpaidCommissionLabel.Name = "unpaidCommissionLabel";
            unpaidCommissionLabel.Size = new System.Drawing.Size(74, 18);
            unpaidCommissionLabel.TabIndex = 42;
            unpaidCommissionLabel.Text = "未收手续费:";
            // 
            // tabControl
            // 
            this.tabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl.CanReorderTabs = true;
            this.tabControl.Controls.Add(this.tabPanelLog);
            this.tabControl.Controls.Add(this.tabPanelInvoice);
            this.tabControl.Controls.Add(this.tabPanelFlaw);
            this.tabControl.Controls.Add(this.tabControlPanelDispute);
            this.tabControl.Controls.Add(this.tabPanelEDI);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl.SelectedTabIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(550, 328);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl.Tabs.Add(this.tabItemInvoice);
            this.tabControl.Tabs.Add(this.tabItemLog);
            this.tabControl.Tabs.Add(this.tabItemFlaw);
            this.tabControl.Tabs.Add(this.tabItemDispute);
            this.tabControl.Tabs.Add(this.tabItemEDI);
            // 
            // tabPanelInvoice
            // 
            this.tabPanelInvoice.AutoScroll = true;
            this.tabPanelInvoice.Controls.Add(this.groupPanelInvoiceProcess);
            this.tabPanelInvoice.Controls.Add(this.groupPanelInvoiceBasic);
            this.tabPanelInvoice.Controls.Add(this.btnInvoiceSave);
            this.tabPanelInvoice.Controls.Add(this.btnInvoiceUpdate);
            this.tabPanelInvoice.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabPanelInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelInvoice.Location = new System.Drawing.Point(0, 26);
            this.tabPanelInvoice.Name = "tabPanelInvoice";
            this.tabPanelInvoice.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelInvoice.Size = new System.Drawing.Size(550, 302);
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
            this.groupPanelInvoiceProcess.Controls.Add(unpaidCommissionLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.unpaidCommissionTextBox);
            this.groupPanelInvoiceProcess.Controls.Add(lblFactorCommission);
            this.groupPanelInvoiceProcess.Controls.Add(this.tbFactorCommission);
            this.groupPanelInvoiceProcess.Controls.Add(lblRefundBatch);
            this.groupPanelInvoiceProcess.Controls.Add(this.tbRefundBatch);
            this.groupPanelInvoiceProcess.Controls.Add(lblPaymentBatch);
            this.groupPanelInvoiceProcess.Controls.Add(this.tbPaymentBatch);
            this.groupPanelInvoiceProcess.Controls.Add(lblFinanceBatch);
            this.groupPanelInvoiceProcess.Controls.Add(this.tbFinanceBatch);
            this.groupPanelInvoiceProcess.Controls.Add(lblAssignBatch);
            this.groupPanelInvoiceProcess.Controls.Add(this.tbAssignBatch);
            this.groupPanelInvoiceProcess.Controls.Add(financeBatchNoLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.financeOutstandingTextBox);
            this.groupPanelInvoiceProcess.Controls.Add(assignBatchNoLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.assignOutstandingTextBox);
            this.groupPanelInvoiceProcess.Controls.Add(interestLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.interestTextBox);
            this.groupPanelInvoiceProcess.Controls.Add(paidCommissionLabel);
            this.groupPanelInvoiceProcess.Controls.Add(this.paidCommissionTextBox);
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
            this.groupPanelInvoiceProcess.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelInvoiceProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelInvoiceProcess.Location = new System.Drawing.Point(1, 98);
            this.groupPanelInvoiceProcess.Name = "groupPanelInvoiceProcess";
            this.groupPanelInvoiceProcess.Size = new System.Drawing.Size(548, 150);
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
            this.groupPanelInvoiceProcess.Style.CornerDiameter = 4;
            this.groupPanelInvoiceProcess.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelInvoiceProcess.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelInvoiceProcess.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelInvoiceProcess.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelInvoiceProcess.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelInvoiceProcess.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelInvoiceProcess.TabIndex = 0;
            // 
            // unpaidCommissionTextBox
            // 
            // 
            // 
            // 
            this.unpaidCommissionTextBox.Border.Class = "TextBoxBorder";
            this.unpaidCommissionTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.unpaidCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "UnpaidCommission", true));
            this.unpaidCommissionTextBox.Location = new System.Drawing.Point(73, 120);
            this.unpaidCommissionTextBox.Name = "unpaidCommissionTextBox";
            this.unpaidCommissionTextBox.Size = new System.Drawing.Size(100, 21);
            this.unpaidCommissionTextBox.TabIndex = 43;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Invoice);
            // 
            // tbFactorCommission
            // 
            // 
            // 
            // 
            this.tbFactorCommission.Border.Class = "TextBoxBorder";
            this.tbFactorCommission.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFactorCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FactorCommission", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.tbFactorCommission.Location = new System.Drawing.Point(245, 100);
            this.tbFactorCommission.Name = "tbFactorCommission";
            this.tbFactorCommission.Size = new System.Drawing.Size(103, 21);
            this.tbFactorCommission.TabIndex = 41;
            // 
            // tbRefundBatch
            // 
            // 
            // 
            // 
            this.tbRefundBatch.Border.Class = "TextBoxBorder";
            this.tbRefundBatch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbRefundBatch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "RefundBatchNos", true));
            this.tbRefundBatch.Location = new System.Drawing.Point(432, 100);
            this.tbRefundBatch.Name = "tbRefundBatch";
            this.tbRefundBatch.Size = new System.Drawing.Size(100, 21);
            this.tbRefundBatch.TabIndex = 37;
            this.tbRefundBatch.DoubleClick += new System.EventHandler(this.DetailRefundBatch);
            // 
            // tbPaymentBatch
            // 
            // 
            // 
            // 
            this.tbPaymentBatch.Border.Class = "TextBoxBorder";
            this.tbPaymentBatch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbPaymentBatch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PaymentBatchNos", true));
            this.tbPaymentBatch.Location = new System.Drawing.Point(432, 81);
            this.tbPaymentBatch.Name = "tbPaymentBatch";
            this.tbPaymentBatch.Size = new System.Drawing.Size(100, 21);
            this.tbPaymentBatch.TabIndex = 35;
            this.tbPaymentBatch.DoubleClick += new System.EventHandler(this.DetailPaymentBatch);
            // 
            // tbFinanceBatch
            // 
            // 
            // 
            // 
            this.tbFinanceBatch.Border.Class = "TextBoxBorder";
            this.tbFinanceBatch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFinanceBatch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FinanceBatchNos", true));
            this.tbFinanceBatch.Location = new System.Drawing.Point(432, 62);
            this.tbFinanceBatch.Name = "tbFinanceBatch";
            this.tbFinanceBatch.Size = new System.Drawing.Size(100, 21);
            this.tbFinanceBatch.TabIndex = 33;
            this.tbFinanceBatch.DoubleClick += new System.EventHandler(this.DetailFinanceBatch);
            // 
            // tbAssignBatch
            // 
            // 
            // 
            // 
            this.tbAssignBatch.Border.Class = "TextBoxBorder";
            this.tbAssignBatch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbAssignBatch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "AssignBatchNo", true));
            this.tbAssignBatch.Location = new System.Drawing.Point(432, 41);
            this.tbAssignBatch.Name = "tbAssignBatch";
            this.tbAssignBatch.Size = new System.Drawing.Size(100, 21);
            this.tbAssignBatch.TabIndex = 31;
            this.tbAssignBatch.DoubleClick += new System.EventHandler(this.DetailAssignBatch);
            // 
            // financeOutstandingTextBox
            // 
            // 
            // 
            // 
            this.financeOutstandingTextBox.Border.Class = "TextBoxBorder";
            this.financeOutstandingTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeOutstandingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FinanceOutstanding", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.financeOutstandingTextBox.Location = new System.Drawing.Point(433, 20);
            this.financeOutstandingTextBox.Name = "financeOutstandingTextBox";
            this.financeOutstandingTextBox.Size = new System.Drawing.Size(100, 21);
            this.financeOutstandingTextBox.TabIndex = 29;
            // 
            // assignOutstandingTextBox
            // 
            // 
            // 
            // 
            this.assignOutstandingTextBox.Border.Class = "TextBoxBorder";
            this.assignOutstandingTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignOutstandingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "AssignOutstanding", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.assignOutstandingTextBox.Location = new System.Drawing.Point(433, 1);
            this.assignOutstandingTextBox.Name = "assignOutstandingTextBox";
            this.assignOutstandingTextBox.Size = new System.Drawing.Size(100, 21);
            this.assignOutstandingTextBox.TabIndex = 27;
            // 
            // interestTextBox
            // 
            // 
            // 
            // 
            this.interestTextBox.Border.Class = "TextBoxBorder";
            this.interestTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.interestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Interest", true));
            this.interestTextBox.Location = new System.Drawing.Point(244, 122);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(100, 21);
            this.interestTextBox.TabIndex = 23;
            // 
            // paidCommissionTextBox
            // 
            // 
            // 
            // 
            this.paidCommissionTextBox.Border.Class = "TextBoxBorder";
            this.paidCommissionTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paidCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PaidCommission", true));
            this.paidCommissionTextBox.Location = new System.Drawing.Point(73, 99);
            this.paidCommissionTextBox.Name = "paidCommissionTextBox";
            this.paidCommissionTextBox.Size = new System.Drawing.Size(100, 21);
            this.paidCommissionTextBox.TabIndex = 19;
            // 
            // refundDateDateTimePicker
            // 
            // 
            // 
            // 
            this.refundDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.refundDateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.refundDateDateTimePicker.ButtonDropDown.Visible = true;
            this.refundDateDateTimePicker.ButtonFreeText.Checked = true;
            this.refundDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "RefundDate", true));
            this.refundDateDateTimePicker.FreeTextEntryMode = true;
            this.refundDateDateTimePicker.IsPopupCalendarOpen = false;
            this.refundDateDateTimePicker.Location = new System.Drawing.Point(232, 79);
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.refundDateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.refundDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.refundDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.refundDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.refundDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.refundDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.refundDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.refundDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.refundDateDateTimePicker.Name = "refundDateDateTimePicker";
            this.refundDateDateTimePicker.Size = new System.Drawing.Size(118, 21);
            this.refundDateDateTimePicker.TabIndex = 17;
            // 
            // refundAmountTextBox
            // 
            // 
            // 
            // 
            this.refundAmountTextBox.Border.Class = "TextBoxBorder";
            this.refundAmountTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.refundAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "RefundAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.refundAmountTextBox.Location = new System.Drawing.Point(73, 79);
            this.refundAmountTextBox.Name = "refundAmountTextBox";
            this.refundAmountTextBox.Size = new System.Drawing.Size(100, 21);
            this.refundAmountTextBox.TabIndex = 15;
            // 
            // paymentDateDateTimePicker
            // 
            // 
            // 
            // 
            this.paymentDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.paymentDateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paymentDateDateTimePicker.ButtonDropDown.Visible = true;
            this.paymentDateDateTimePicker.ButtonFreeText.Checked = true;
            this.paymentDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "PaymentDate", true));
            this.paymentDateDateTimePicker.FreeTextEntryMode = true;
            this.paymentDateDateTimePicker.IsPopupCalendarOpen = false;
            this.paymentDateDateTimePicker.Location = new System.Drawing.Point(232, 59);
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.paymentDateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paymentDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paymentDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.paymentDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.paymentDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.paymentDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paymentDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.paymentDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.paymentDateDateTimePicker.Name = "paymentDateDateTimePicker";
            this.paymentDateDateTimePicker.Size = new System.Drawing.Size(118, 21);
            this.paymentDateDateTimePicker.TabIndex = 13;
            // 
            // paymentAmountTextBox
            // 
            // 
            // 
            // 
            this.paymentAmountTextBox.Border.Class = "TextBoxBorder";
            this.paymentAmountTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.paymentAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PaymentAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.paymentAmountTextBox.Location = new System.Drawing.Point(73, 59);
            this.paymentAmountTextBox.Name = "paymentAmountTextBox";
            this.paymentAmountTextBox.Size = new System.Drawing.Size(100, 21);
            this.paymentAmountTextBox.TabIndex = 11;
            // 
            // financeDueDateDateTimePicker
            // 
            // 
            // 
            // 
            this.financeDueDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financeDueDateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeDueDateDateTimePicker.ButtonDropDown.Visible = true;
            this.financeDueDateDateTimePicker.ButtonFreeText.Checked = true;
            this.financeDueDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "ReassignDate", true));
            this.financeDueDateDateTimePicker.FreeTextEntryMode = true;
            this.financeDueDateDateTimePicker.IsPopupCalendarOpen = false;
            this.financeDueDateDateTimePicker.Location = new System.Drawing.Point(232, 40);
            // 
            // 
            // 
            this.financeDueDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeDueDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financeDueDateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeDueDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.financeDueDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeDueDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.financeDueDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financeDueDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeDueDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeDueDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.financeDueDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financeDueDateDateTimePicker.Name = "financeDueDateDateTimePicker";
            this.financeDueDateDateTimePicker.Size = new System.Drawing.Size(118, 21);
            this.financeDueDateDateTimePicker.TabIndex = 9;
            // 
            // financeDateDateTimePicker
            // 
            // 
            // 
            // 
            this.financeDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financeDateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeDateDateTimePicker.ButtonDropDown.Visible = true;
            this.financeDateDateTimePicker.ButtonFreeText.Checked = true;
            this.financeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "FinanceDate", true));
            this.financeDateDateTimePicker.FreeTextEntryMode = true;
            this.financeDateDateTimePicker.IsPopupCalendarOpen = false;
            this.financeDateDateTimePicker.Location = new System.Drawing.Point(231, 19);
            // 
            // 
            // 
            this.financeDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financeDateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.financeDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.financeDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financeDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financeDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.financeDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financeDateDateTimePicker.Name = "financeDateDateTimePicker";
            this.financeDateDateTimePicker.Size = new System.Drawing.Size(119, 21);
            this.financeDateDateTimePicker.TabIndex = 7;
            // 
            // financeAmountTextBox
            // 
            // 
            // 
            // 
            this.financeAmountTextBox.Border.Class = "TextBoxBorder";
            this.financeAmountTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FinanceAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.financeAmountTextBox.Location = new System.Drawing.Point(73, 19);
            this.financeAmountTextBox.Name = "financeAmountTextBox";
            this.financeAmountTextBox.Size = new System.Drawing.Size(100, 21);
            this.financeAmountTextBox.TabIndex = 5;
            // 
            // assignAmountTextBox
            // 
            // 
            // 
            // 
            this.assignAmountTextBox.Border.Class = "TextBoxBorder";
            this.assignAmountTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "AssignAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.assignAmountTextBox.Location = new System.Drawing.Point(73, 0);
            this.assignAmountTextBox.Name = "assignAmountTextBox";
            this.assignAmountTextBox.Size = new System.Drawing.Size(100, 21);
            this.assignAmountTextBox.TabIndex = 1;
            // 
            // assignDateTextBox
            // 
            // 
            // 
            // 
            this.assignDateTextBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.assignDateTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignDateTextBox.ButtonDropDown.Visible = true;
            this.assignDateTextBox.ButtonFreeText.Checked = true;
            this.assignDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceAssignBatch.AssignDate", true));
            this.assignDateTextBox.FreeTextEntryMode = true;
            this.assignDateTextBox.IsPopupCalendarOpen = false;
            this.assignDateTextBox.Location = new System.Drawing.Point(232, 0);
            // 
            // 
            // 
            this.assignDateTextBox.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.assignDateTextBox.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.assignDateTextBox.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignDateTextBox.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.assignDateTextBox.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignDateTextBox.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.assignDateTextBox.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.assignDateTextBox.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.assignDateTextBox.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.assignDateTextBox.MonthCalendar.TodayButtonVisible = true;
            this.assignDateTextBox.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.assignDateTextBox.Name = "assignDateTextBox";
            this.assignDateTextBox.Size = new System.Drawing.Size(118, 21);
            this.assignDateTextBox.TabIndex = 3;
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
            this.groupPanelInvoiceBasic.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelInvoiceBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelInvoiceBasic.Location = new System.Drawing.Point(1, 1);
            this.groupPanelInvoiceBasic.Name = "groupPanelInvoiceBasic";
            this.groupPanelInvoiceBasic.Size = new System.Drawing.Size(548, 97);
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
            this.groupPanelInvoiceBasic.Style.CornerDiameter = 4;
            this.groupPanelInvoiceBasic.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelInvoiceBasic.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelInvoiceBasic.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelInvoiceBasic.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelInvoiceBasic.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelInvoiceBasic.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelInvoiceBasic.TabIndex = 0;
            // 
            // commentTextBox
            // 
            // 
            // 
            // 
            this.commentTextBox.Border.Class = "TextBoxBorder";
            this.commentTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(73, 45);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commentTextBox.Size = new System.Drawing.Size(459, 40);
            this.commentTextBox.TabIndex = 13;
            // 
            // invoiceCurrencyComboBox
            // 
            this.invoiceCurrencyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.invoiceCurrencyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.invoiceCurrencyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceCurrency", true));
            this.invoiceCurrencyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.invoiceCurrencyComboBox.FormattingEnabled = true;
            this.invoiceCurrencyComboBox.ItemHeight = 15;
            this.invoiceCurrencyComboBox.Location = new System.Drawing.Point(232, 3);
            this.invoiceCurrencyComboBox.Name = "invoiceCurrencyComboBox";
            this.invoiceCurrencyComboBox.Size = new System.Drawing.Size(112, 21);
            this.invoiceCurrencyComboBox.TabIndex = 3;
            // 
            // dueDateTextBox
            // 
            // 
            // 
            // 
            this.dueDateTextBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dueDateTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dueDateTextBox.ButtonDropDown.Visible = true;
            this.dueDateTextBox.ButtonFreeText.Checked = true;
            this.dueDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DueDate", true));
            this.dueDateTextBox.FreeTextEntryMode = true;
            this.dueDateTextBox.IsPopupCalendarOpen = false;
            this.dueDateTextBox.Location = new System.Drawing.Point(432, 25);
            // 
            // 
            // 
            this.dueDateTextBox.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dueDateTextBox.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dueDateTextBox.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dueDateTextBox.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dueDateTextBox.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dueDateTextBox.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dueDateTextBox.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dueDateTextBox.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dueDateTextBox.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dueDateTextBox.MonthCalendar.TodayButtonVisible = true;
            this.dueDateTextBox.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dueDateTextBox.Name = "dueDateTextBox";
            this.dueDateTextBox.Size = new System.Drawing.Size(100, 21);
            this.dueDateTextBox.TabIndex = 11;
            // 
            // invoiceAmountTextBox
            // 
            // 
            // 
            // 
            this.invoiceAmountTextBox.Border.Class = "TextBoxBorder";
            this.invoiceAmountTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.invoiceAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.invoiceAmountTextBox.Location = new System.Drawing.Point(73, 25);
            this.invoiceAmountTextBox.Name = "invoiceAmountTextBox";
            this.invoiceAmountTextBox.Size = new System.Drawing.Size(100, 21);
            this.invoiceAmountTextBox.TabIndex = 7;
            // 
            // invoiceDateTextBox
            // 
            // 
            // 
            // 
            this.invoiceDateTextBox.BackgroundStyle.Class = "DateTimeInputBackground";
            this.invoiceDateTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.invoiceDateTextBox.ButtonDropDown.Visible = true;
            this.invoiceDateTextBox.ButtonFreeText.Checked = true;
            this.invoiceDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceDate", true));
            this.invoiceDateTextBox.FreeTextEntryMode = true;
            this.invoiceDateTextBox.IsPopupCalendarOpen = false;
            this.invoiceDateTextBox.Location = new System.Drawing.Point(232, 25);
            // 
            // 
            // 
            this.invoiceDateTextBox.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.invoiceDateTextBox.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.invoiceDateTextBox.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.invoiceDateTextBox.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.invoiceDateTextBox.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.invoiceDateTextBox.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.invoiceDateTextBox.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.invoiceDateTextBox.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.invoiceDateTextBox.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.invoiceDateTextBox.MonthCalendar.TodayButtonVisible = true;
            this.invoiceDateTextBox.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.invoiceDateTextBox.Name = "invoiceDateTextBox";
            this.invoiceDateTextBox.Size = new System.Drawing.Size(112, 21);
            this.invoiceDateTextBox.TabIndex = 9;
            // 
            // invoiceNoTextBox
            // 
            // 
            // 
            // 
            this.invoiceNoTextBox.Border.Class = "TextBoxBorder";
            this.invoiceNoTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.invoiceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceNo", true));
            this.invoiceNoTextBox.Location = new System.Drawing.Point(73, 4);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.invoiceNoTextBox.TabIndex = 1;
            // 
            // btnInvoiceSave
            // 
            this.btnInvoiceSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInvoiceSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInvoiceSave.Location = new System.Drawing.Point(266, 265);
            this.btnInvoiceSave.Name = "btnInvoiceSave";
            this.btnInvoiceSave.Size = new System.Drawing.Size(75, 21);
            this.btnInvoiceSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnInvoiceSave.TabIndex = 1;
            this.btnInvoiceSave.Text = "保存";
            this.btnInvoiceSave.Click += new System.EventHandler(this.SaveInvoice);
            // 
            // btnInvoiceUpdate
            // 
            this.btnInvoiceUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInvoiceUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInvoiceUpdate.Location = new System.Drawing.Point(185, 265);
            this.btnInvoiceUpdate.Name = "btnInvoiceUpdate";
            this.btnInvoiceUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnInvoiceUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnInvoiceUpdate.TabIndex = 0;
            this.btnInvoiceUpdate.Text = "编辑";
            this.btnInvoiceUpdate.Click += new System.EventHandler(this.UpdateInvoice);
            // 
            // tabItemInvoice
            // 
            this.tabItemInvoice.AttachedControl = this.tabPanelInvoice;
            this.tabItemInvoice.Name = "tabItemInvoice";
            this.tabItemInvoice.Text = "发票明细";
            // 
            // tabPanelLog
            // 
            this.tabPanelLog.Controls.Add(this.dgvPaymentLogs);
            this.tabPanelLog.Controls.Add(this.dgvFinanceLogs);
            this.tabPanelLog.Controls.Add(this.dgvRefundLogs);
            this.tabPanelLog.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabPanelLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelLog.Location = new System.Drawing.Point(0, 26);
            this.tabPanelLog.Name = "tabPanelLog";
            this.tabPanelLog.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelLog.Size = new System.Drawing.Size(550, 302);
            this.tabPanelLog.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabPanelLog.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabPanelLog.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabPanelLog.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabPanelLog.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabPanelLog.Style.GradientAngle = 90;
            this.tabPanelLog.TabIndex = 6;
            this.tabPanelLog.TabItem = this.tabItemLog;
            // 
            // dgvPaymentLogs
            // 
            this.dgvPaymentLogs.AllowUserToAddRows = false;
            this.dgvPaymentLogs.AllowUserToDeleteRows = false;
            this.dgvPaymentLogs.AllowUserToOrderColumns = true;
            this.dgvPaymentLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaymentLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaymentCurrency,
            this.colPaymentAmount,
            this.colPaymentDate,
            this.colCreditNoteNo,
            this.colCreditNoteDate,
            this.colComment});
            this.dgvPaymentLogs.ContextMenuStrip = this.paymentLogMgr;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaymentLogs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPaymentLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPaymentLogs.Location = new System.Drawing.Point(1, 103);
            this.dgvPaymentLogs.Name = "dgvPaymentLogs";
            this.dgvPaymentLogs.ReadOnly = true;
            this.dgvPaymentLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPaymentLogs.Size = new System.Drawing.Size(548, 93);
            this.dgvPaymentLogs.TabIndex = 6;
            // 
            // colPaymentCurrency
            // 
            this.colPaymentCurrency.DataPropertyName = "PaymentCurrency";
            this.colPaymentCurrency.HeaderText = "币别";
            this.colPaymentCurrency.Name = "colPaymentCurrency";
            this.colPaymentCurrency.ReadOnly = true;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.DataPropertyName = "PaymentAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.colPaymentAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colPaymentAmount.HeaderText = "付款金额";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.ReadOnly = true;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.DataPropertyName = "PaymentDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.colPaymentDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPaymentDate.HeaderText = "付款日";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.ReadOnly = true;
            // 
            // colCreditNoteNo
            // 
            this.colCreditNoteNo.DataPropertyName = "CreditNoteNo";
            this.colCreditNoteNo.HeaderText = "贷项通知编号";
            this.colCreditNoteNo.Name = "colCreditNoteNo";
            this.colCreditNoteNo.ReadOnly = true;
            this.colCreditNoteNo.Visible = false;
            // 
            // colCreditNoteDate
            // 
            this.colCreditNoteDate.DataPropertyName = "CreditNoteDate";
            this.colCreditNoteDate.HeaderText = "贷项通知日";
            this.colCreditNoteDate.Name = "colCreditNoteDate";
            this.colCreditNoteDate.ReadOnly = true;
            this.colCreditNoteDate.Visible = false;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // paymentLogMgr
            // 
            this.paymentLogMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPaymentLogDelete});
            this.paymentLogMgr.Name = "cmuContractMgr";
            this.paymentLogMgr.Size = new System.Drawing.Size(118, 26);
            // 
            // menuItemPaymentLogDelete
            // 
            this.menuItemPaymentLogDelete.Name = "menuItemPaymentLogDelete";
            this.menuItemPaymentLogDelete.Size = new System.Drawing.Size(117, 22);
            this.menuItemPaymentLogDelete.Text = "删除(&D)";
            this.menuItemPaymentLogDelete.Click += new System.EventHandler(this.DeletePaymentLog);
            // 
            // dgvFinanceLogs
            // 
            this.dgvFinanceLogs.AllowUserToAddRows = false;
            this.dgvFinanceLogs.AllowUserToDeleteRows = false;
            this.dgvFinanceLogs.AllowUserToOrderColumns = true;
            this.dgvFinanceLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinanceLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFinanceLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinanceLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFinanceCurrency,
            this.colFinanceAmount,
            this.colFinanceDate,
            this.colReassignDate,
            this.colFinanceRate,
            this.colFinanceRateType1,
            this.colFinanceRateType2,
            this.colCommission,
            this.colFinanceInterest,
            this.colFinanceComment});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFinanceLogs.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvFinanceLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvFinanceLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFinanceLogs.Location = new System.Drawing.Point(1, 1);
            this.dgvFinanceLogs.Name = "dgvFinanceLogs";
            this.dgvFinanceLogs.ReadOnly = true;
            this.dgvFinanceLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFinanceLogs.Size = new System.Drawing.Size(548, 102);
            this.dgvFinanceLogs.TabIndex = 5;
            // 
            // dgvRefundLogs
            // 
            this.dgvRefundLogs.AllowUserToAddRows = false;
            this.dgvRefundLogs.AllowUserToDeleteRows = false;
            this.dgvRefundLogs.AllowUserToOrderColumns = true;
            this.dgvRefundLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRefundLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvRefundLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefundLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRefundCurrency,
            this.colRefundAmount,
            this.colRefundDate,
            this.colInterest,
            this.dataGridViewTextBoxColumn2});
            this.dgvRefundLogs.ContextMenuStrip = this.refundLogMgr;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRefundLogs.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvRefundLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRefundLogs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRefundLogs.Location = new System.Drawing.Point(1, 196);
            this.dgvRefundLogs.Name = "dgvRefundLogs";
            this.dgvRefundLogs.ReadOnly = true;
            this.dgvRefundLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRefundLogs.Size = new System.Drawing.Size(548, 105);
            this.dgvRefundLogs.TabIndex = 3;
            // 
            // colRefundCurrency
            // 
            this.colRefundCurrency.DataPropertyName = "RefundCurrency";
            this.colRefundCurrency.HeaderText = "币别";
            this.colRefundCurrency.Name = "colRefundCurrency";
            this.colRefundCurrency.ReadOnly = true;
            // 
            // colRefundAmount
            // 
            this.colRefundAmount.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N2";
            this.colRefundAmount.DefaultCellStyle = dataGridViewCellStyle14;
            this.colRefundAmount.HeaderText = "还款金额";
            this.colRefundAmount.Name = "colRefundAmount";
            this.colRefundAmount.ReadOnly = true;
            // 
            // colRefundDate
            // 
            this.colRefundDate.DataPropertyName = "RefundDate";
            dataGridViewCellStyle15.Format = "d";
            dataGridViewCellStyle15.NullValue = null;
            this.colRefundDate.DefaultCellStyle = dataGridViewCellStyle15;
            this.colRefundDate.HeaderText = "还款日";
            this.colRefundDate.Name = "colRefundDate";
            this.colRefundDate.ReadOnly = true;
            // 
            // colInterest
            // 
            this.colInterest.DataPropertyName = "Interest";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = null;
            this.colInterest.DefaultCellStyle = dataGridViewCellStyle16;
            this.colInterest.HeaderText = "利息收入";
            this.colInterest.Name = "colInterest";
            this.colInterest.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Comment";
            dataGridViewCellStyle17.Format = "d";
            dataGridViewCellStyle17.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn2.HeaderText = "备注";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // refundLogMgr
            // 
            this.refundLogMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRefundLogDelete});
            this.refundLogMgr.Name = "cmuContractMgr";
            this.refundLogMgr.Size = new System.Drawing.Size(110, 26);
            // 
            // menuItemRefundLogDelete
            // 
            this.menuItemRefundLogDelete.Name = "menuItemRefundLogDelete";
            this.menuItemRefundLogDelete.Size = new System.Drawing.Size(109, 22);
            this.menuItemRefundLogDelete.Text = "&D删除";
            this.menuItemRefundLogDelete.Click += new System.EventHandler(this.DeleteRefundLog);
            // 
            // tabItemLog
            // 
            this.tabItemLog.AttachedControl = this.tabPanelLog;
            this.tabItemLog.Name = "tabItemLog";
            this.tabItemLog.Text = "融资/付款/还款记录";
            // 
            // tabPanelFlaw
            // 
            this.tabPanelFlaw.AutoScroll = true;
            this.tabPanelFlaw.Controls.Add(this.btnFlawSave);
            this.tabPanelFlaw.Controls.Add(this.groupPanelFlawResolve);
            this.tabPanelFlaw.Controls.Add(this.groupPanelFlaw);
            this.tabPanelFlaw.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabPanelFlaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelFlaw.Location = new System.Drawing.Point(0, 26);
            this.tabPanelFlaw.Name = "tabPanelFlaw";
            this.tabPanelFlaw.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelFlaw.Size = new System.Drawing.Size(550, 302);
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
            // btnFlawSave
            // 
            this.btnFlawSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFlawSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFlawSave.Location = new System.Drawing.Point(275, 271);
            this.btnFlawSave.Name = "btnFlawSave";
            this.btnFlawSave.Size = new System.Drawing.Size(75, 21);
            this.btnFlawSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFlawSave.TabIndex = 2;
            this.btnFlawSave.Text = "保存";
            this.btnFlawSave.Click += new System.EventHandler(this.SaveInvoice);
            // 
            // groupPanelFlawResolve
            // 
            this.groupPanelFlawResolve.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelFlawResolve.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelFlawResolve.Controls.Add(this.btnFlawResolve);
            this.groupPanelFlawResolve.Controls.Add(flawResolveReasonLabel);
            this.groupPanelFlawResolve.Controls.Add(this.tbFlawResolveReason);
            this.groupPanelFlawResolve.Controls.Add(flawResolveUserNameLabel);
            this.groupPanelFlawResolve.Controls.Add(this.flawResolveDateDateTimePicker);
            this.groupPanelFlawResolve.Controls.Add(this.flawResolveUserNameTextBox);
            this.groupPanelFlawResolve.Controls.Add(flawResolveDateLabel);
            this.groupPanelFlawResolve.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelFlawResolve.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelFlawResolve.Location = new System.Drawing.Point(1, 142);
            this.groupPanelFlawResolve.Name = "groupPanelFlawResolve";
            this.groupPanelFlawResolve.Size = new System.Drawing.Size(548, 117);
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
            this.groupPanelFlawResolve.Style.CornerDiameter = 4;
            this.groupPanelFlawResolve.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelFlawResolve.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelFlawResolve.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelFlawResolve.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelFlawResolve.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelFlawResolve.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelFlawResolve.TabIndex = 1;
            // 
            // btnFlawResolve
            // 
            this.btnFlawResolve.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFlawResolve.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFlawResolve.Location = new System.Drawing.Point(15, 6);
            this.btnFlawResolve.Name = "btnFlawResolve";
            this.btnFlawResolve.Size = new System.Drawing.Size(75, 21);
            this.btnFlawResolve.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFlawResolve.TabIndex = 0;
            this.btnFlawResolve.Text = "瑕疵解除";
            this.btnFlawResolve.Click += new System.EventHandler(this.FlawResolve);
            // 
            // tbFlawResolveReason
            // 
            // 
            // 
            // 
            this.tbFlawResolveReason.Border.Class = "TextBoxBorder";
            this.tbFlawResolveReason.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFlawResolveReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FlawResolveReason", true));
            this.tbFlawResolveReason.Location = new System.Drawing.Point(105, 0);
            this.tbFlawResolveReason.Multiline = true;
            this.tbFlawResolveReason.Name = "tbFlawResolveReason";
            this.tbFlawResolveReason.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbFlawResolveReason.Size = new System.Drawing.Size(434, 73);
            this.tbFlawResolveReason.TabIndex = 2;
            // 
            // flawResolveDateDateTimePicker
            // 
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.flawResolveDateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.flawResolveDateDateTimePicker.ButtonDropDown.Visible = true;
            this.flawResolveDateDateTimePicker.ButtonFreeText.Checked = true;
            this.flawResolveDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "FlawResolveDate", true));
            this.flawResolveDateDateTimePicker.FreeTextEntryMode = true;
            this.flawResolveDateDateTimePicker.IsPopupCalendarOpen = false;
            this.flawResolveDateDateTimePicker.Location = new System.Drawing.Point(156, 87);
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.flawResolveDateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.flawResolveDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.flawResolveDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.flawResolveDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.flawResolveDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.flawResolveDateDateTimePicker.Name = "flawResolveDateDateTimePicker";
            this.flawResolveDateDateTimePicker.Size = new System.Drawing.Size(100, 21);
            this.flawResolveDateDateTimePicker.TabIndex = 4;
            // 
            // flawResolveUserNameTextBox
            // 
            // 
            // 
            // 
            this.flawResolveUserNameTextBox.Border.Class = "TextBoxBorder";
            this.flawResolveUserNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.flawResolveUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FlawResolveUserName", true));
            this.flawResolveUserNameTextBox.Location = new System.Drawing.Point(324, 86);
            this.flawResolveUserNameTextBox.Name = "flawResolveUserNameTextBox";
            this.flawResolveUserNameTextBox.ReadOnly = true;
            this.flawResolveUserNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.flawResolveUserNameTextBox.TabIndex = 6;
            // 
            // groupPanelFlaw
            // 
            this.groupPanelFlaw.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelFlaw.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelFlaw.Controls.Add(this.isFlawCheckBox);
            this.groupPanelFlaw.Controls.Add(this.btnFlaw);
            this.groupPanelFlaw.Controls.Add(this.tbFlawReason);
            this.groupPanelFlaw.Controls.Add(flawReasonLabel);
            this.groupPanelFlaw.Controls.Add(this.flawReasonCheckedListBox);
            this.groupPanelFlaw.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelFlaw.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelFlaw.Location = new System.Drawing.Point(1, 1);
            this.groupPanelFlaw.Name = "groupPanelFlaw";
            this.groupPanelFlaw.Size = new System.Drawing.Size(548, 141);
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
            this.groupPanelFlaw.Style.CornerDiameter = 4;
            this.groupPanelFlaw.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelFlaw.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelFlaw.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelFlaw.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelFlaw.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelFlaw.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelFlaw.TabIndex = 0;
            // 
            // isFlawCheckBox
            // 
            this.isFlawCheckBox.AutoSize = true;
            this.isFlawCheckBox.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isFlawCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.isFlawCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "IsFlaw", true));
            this.isFlawCheckBox.Location = new System.Drawing.Point(13, 19);
            this.isFlawCheckBox.Name = "isFlawCheckBox";
            this.isFlawCheckBox.Size = new System.Drawing.Size(76, 18);
            this.isFlawCheckBox.TabIndex = 5;
            this.isFlawCheckBox.Text = "是否瑕疵";
            // 
            // btnFlaw
            // 
            this.btnFlaw.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFlaw.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFlaw.Location = new System.Drawing.Point(13, 40);
            this.btnFlaw.Name = "btnFlaw";
            this.btnFlaw.Size = new System.Drawing.Size(75, 21);
            this.btnFlaw.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFlaw.TabIndex = 0;
            this.btnFlaw.Text = "瑕疵设定";
            this.btnFlaw.Click += new System.EventHandler(this.Flaw);
            // 
            // tbFlawReason
            // 
            // 
            // 
            // 
            this.tbFlawReason.Border.Class = "TextBoxBorder";
            this.tbFlawReason.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFlawReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "FlawOtherReason", true));
            this.tbFlawReason.Location = new System.Drawing.Point(344, 9);
            this.tbFlawReason.Multiline = true;
            this.tbFlawReason.Name = "tbFlawReason";
            this.tbFlawReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFlawReason.Size = new System.Drawing.Size(195, 115);
            this.tbFlawReason.TabIndex = 3;
            this.tbFlawReason.WatermarkText = "其他原因";
            // 
            // flawReasonCheckedListBox
            // 
            this.flawReasonCheckedListBox.CheckOnClick = true;
            this.flawReasonCheckedListBox.FormattingEnabled = true;
            this.flawReasonCheckedListBox.Location = new System.Drawing.Point(105, 10);
            this.flawReasonCheckedListBox.Name = "flawReasonCheckedListBox";
            this.flawReasonCheckedListBox.Size = new System.Drawing.Size(233, 100);
            this.flawReasonCheckedListBox.TabIndex = 2;
            // 
            // tabItemFlaw
            // 
            this.tabItemFlaw.AttachedControl = this.tabPanelFlaw;
            this.tabItemFlaw.Name = "tabItemFlaw";
            this.tabItemFlaw.Text = "瑕疵处理";
            // 
            // tabControlPanelDispute
            // 
            this.tabControlPanelDispute.Controls.Add(this.btnDisputeSave);
            this.tabControlPanelDispute.Controls.Add(this.groupPanelDisputeResolve);
            this.tabControlPanelDispute.Controls.Add(this.groupPanelDispute);
            this.tabControlPanelDispute.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanelDispute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelDispute.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanelDispute.Name = "tabControlPanelDispute";
            this.tabControlPanelDispute.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelDispute.Size = new System.Drawing.Size(550, 302);
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
            // btnDisputeSave
            // 
            this.btnDisputeSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDisputeSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDisputeSave.Location = new System.Drawing.Point(321, 273);
            this.btnDisputeSave.Name = "btnDisputeSave";
            this.btnDisputeSave.Size = new System.Drawing.Size(75, 21);
            this.btnDisputeSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnDisputeSave.TabIndex = 3;
            this.btnDisputeSave.Text = "保存";
            this.btnDisputeSave.Click += new System.EventHandler(this.SaveInvoice);
            // 
            // groupPanelDisputeResolve
            // 
            this.groupPanelDisputeResolve.AutoScroll = true;
            this.groupPanelDisputeResolve.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelDisputeResolve.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelDisputeResolve.Controls.Add(this.btnDisputeResolve);
            this.groupPanelDisputeResolve.Controls.Add(disputeResolveDateLabel);
            this.groupPanelDisputeResolve.Controls.Add(this.disputeResolveDateDateTimePicker);
            this.groupPanelDisputeResolve.Controls.Add(disputeResolveUserNameLabel);
            this.groupPanelDisputeResolve.Controls.Add(this.disputeResolveUserNameTextBox);
            this.groupPanelDisputeResolve.Controls.Add(disputeResolveReasonLabel);
            this.groupPanelDisputeResolve.Controls.Add(this.disputeResolveReasonTextBox);
            this.groupPanelDisputeResolve.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelDisputeResolve.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelDisputeResolve.Location = new System.Drawing.Point(1, 172);
            this.groupPanelDisputeResolve.Name = "groupPanelDisputeResolve";
            this.groupPanelDisputeResolve.Size = new System.Drawing.Size(548, 96);
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
            this.groupPanelDisputeResolve.Style.CornerDiameter = 4;
            this.groupPanelDisputeResolve.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelDisputeResolve.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelDisputeResolve.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelDisputeResolve.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelDisputeResolve.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelDisputeResolve.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelDisputeResolve.TabIndex = 1;
            // 
            // btnDisputeResolve
            // 
            this.btnDisputeResolve.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDisputeResolve.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDisputeResolve.Location = new System.Drawing.Point(8, 8);
            this.btnDisputeResolve.Name = "btnDisputeResolve";
            this.btnDisputeResolve.Size = new System.Drawing.Size(75, 21);
            this.btnDisputeResolve.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnDisputeResolve.TabIndex = 0;
            this.btnDisputeResolve.Text = "商纠解除";
            this.btnDisputeResolve.Click += new System.EventHandler(this.DisputeResolve);
            // 
            // disputeResolveDateDateTimePicker
            // 
            // 
            // 
            // 
            this.disputeResolveDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.disputeResolveDateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeResolveDateDateTimePicker.ButtonDropDown.Visible = true;
            this.disputeResolveDateDateTimePicker.ButtonFreeText.Checked = true;
            this.disputeResolveDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "DisputeResolveDate", true));
            this.disputeResolveDateDateTimePicker.FreeTextEntryMode = true;
            this.disputeResolveDateDateTimePicker.IsPopupCalendarOpen = false;
            this.disputeResolveDateDateTimePicker.Location = new System.Drawing.Point(172, 64);
            // 
            // 
            // 
            this.disputeResolveDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.disputeResolveDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.disputeResolveDateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeResolveDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.disputeResolveDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeResolveDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.disputeResolveDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.disputeResolveDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.disputeResolveDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeResolveDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.disputeResolveDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.disputeResolveDateDateTimePicker.Name = "disputeResolveDateDateTimePicker";
            this.disputeResolveDateDateTimePicker.Size = new System.Drawing.Size(100, 21);
            this.disputeResolveDateDateTimePicker.TabIndex = 4;
            // 
            // disputeResolveUserNameTextBox
            // 
            // 
            // 
            // 
            this.disputeResolveUserNameTextBox.Border.Class = "TextBoxBorder";
            this.disputeResolveUserNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeResolveUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DisputeResolveUserName", true));
            this.disputeResolveUserNameTextBox.Location = new System.Drawing.Point(370, 65);
            this.disputeResolveUserNameTextBox.Name = "disputeResolveUserNameTextBox";
            this.disputeResolveUserNameTextBox.ReadOnly = true;
            this.disputeResolveUserNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.disputeResolveUserNameTextBox.TabIndex = 6;
            // 
            // disputeResolveReasonTextBox
            // 
            // 
            // 
            // 
            this.disputeResolveReasonTextBox.Border.Class = "TextBoxBorder";
            this.disputeResolveReasonTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeResolveReasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DisputeResolveReason", true));
            this.disputeResolveReasonTextBox.Location = new System.Drawing.Point(98, 3);
            this.disputeResolveReasonTextBox.Multiline = true;
            this.disputeResolveReasonTextBox.Name = "disputeResolveReasonTextBox";
            this.disputeResolveReasonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.disputeResolveReasonTextBox.Size = new System.Drawing.Size(425, 56);
            this.disputeResolveReasonTextBox.TabIndex = 2;
            // 
            // groupPanelDispute
            // 
            this.groupPanelDispute.AutoScroll = true;
            this.groupPanelDispute.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelDispute.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelDispute.Controls.Add(this.isDisputeCheckBox);
            this.groupPanelDispute.Controls.Add(this.btnDispute);
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
            this.groupPanelDispute.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelDispute.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelDispute.Location = new System.Drawing.Point(1, 1);
            this.groupPanelDispute.Name = "groupPanelDispute";
            this.groupPanelDispute.Size = new System.Drawing.Size(548, 171);
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
            this.groupPanelDispute.Style.CornerDiameter = 4;
            this.groupPanelDispute.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelDispute.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelDispute.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelDispute.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelDispute.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelDispute.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelDispute.TabIndex = 0;
            // 
            // isDisputeCheckBox
            // 
            this.isDisputeCheckBox.AutoSize = true;
            this.isDisputeCheckBox.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isDisputeCheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.isDisputeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.invoiceBindingSource, "IsDispute", true));
            this.isDisputeCheckBox.Location = new System.Drawing.Point(8, 16);
            this.isDisputeCheckBox.Name = "isDisputeCheckBox";
            this.isDisputeCheckBox.Size = new System.Drawing.Size(76, 18);
            this.isDisputeCheckBox.TabIndex = 12;
            this.isDisputeCheckBox.Text = "是否商纠";
            // 
            // btnDispute
            // 
            this.btnDispute.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDispute.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDispute.Location = new System.Drawing.Point(8, 36);
            this.btnDispute.Name = "btnDispute";
            this.btnDispute.Size = new System.Drawing.Size(75, 21);
            this.btnDispute.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnDispute.TabIndex = 0;
            this.btnDispute.Text = "商纠设定";
            this.btnDispute.Click += new System.EventHandler(this.Dispute);
            // 
            // tbDisputeReason
            // 
            // 
            // 
            // 
            this.tbDisputeReason.Border.Class = "TextBoxBorder";
            this.tbDisputeReason.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbDisputeReason.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DisputeOtherReason", true));
            this.tbDisputeReason.Location = new System.Drawing.Point(352, 6);
            this.tbDisputeReason.Multiline = true;
            this.tbDisputeReason.Name = "tbDisputeReason";
            this.tbDisputeReason.Size = new System.Drawing.Size(171, 102);
            this.tbDisputeReason.TabIndex = 3;
            this.tbDisputeReason.WatermarkText = "其他原因";
            // 
            // disputeReasonCheckedListBox
            // 
            this.disputeReasonCheckedListBox.CheckOnClick = true;
            this.disputeReasonCheckedListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.invoiceBindingSource, "FlawReason", true));
            this.disputeReasonCheckedListBox.FormattingEnabled = true;
            this.disputeReasonCheckedListBox.Location = new System.Drawing.Point(98, 7);
            this.disputeReasonCheckedListBox.Name = "disputeReasonCheckedListBox";
            this.disputeReasonCheckedListBox.Size = new System.Drawing.Size(248, 100);
            this.disputeReasonCheckedListBox.TabIndex = 2;
            // 
            // disputeTypeComboBoxEx
            // 
            this.disputeTypeComboBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DisputeType", true));
            this.disputeTypeComboBoxEx.DisplayMember = "Text";
            this.disputeTypeComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.disputeTypeComboBoxEx.FormattingEnabled = true;
            this.disputeTypeComboBoxEx.ItemHeight = 14;
            this.disputeTypeComboBoxEx.Items.AddRange(new object[] {
            "1-Invoice (default)",
            "2-Credit note",
            "3-Non factored invoice",
            "4-Non factored credit note",
            "5-Payment"});
            this.disputeTypeComboBoxEx.Location = new System.Drawing.Point(173, 116);
            this.disputeTypeComboBoxEx.Name = "disputeTypeComboBoxEx";
            this.disputeTypeComboBoxEx.Size = new System.Drawing.Size(100, 20);
            this.disputeTypeComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.disputeTypeComboBoxEx.TabIndex = 5;
            // 
            // disputeAmountTextBox
            // 
            // 
            // 
            // 
            this.disputeAmountTextBox.Border.Class = "TextBoxBorder";
            this.disputeAmountTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DisputeAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.disputeAmountTextBox.Location = new System.Drawing.Point(173, 136);
            this.disputeAmountTextBox.Name = "disputeAmountTextBox";
            this.disputeAmountTextBox.Size = new System.Drawing.Size(100, 21);
            this.disputeAmountTextBox.TabIndex = 9;
            // 
            // disputeDateDateTimePicker
            // 
            // 
            // 
            // 
            this.disputeDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.disputeDateDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeDateDateTimePicker.ButtonDropDown.Visible = true;
            this.disputeDateDateTimePicker.ButtonFreeText.Checked = true;
            this.disputeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.invoiceBindingSource, "DisputeDate", true));
            this.disputeDateDateTimePicker.FreeTextEntryMode = true;
            this.disputeDateDateTimePicker.IsPopupCalendarOpen = false;
            this.disputeDateDateTimePicker.Location = new System.Drawing.Point(370, 116);
            // 
            // 
            // 
            this.disputeDateDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.disputeDateDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.disputeDateDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeDateDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.disputeDateDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeDateDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.disputeDateDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.disputeDateDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.disputeDateDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeDateDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.disputeDateDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.disputeDateDateTimePicker.Name = "disputeDateDateTimePicker";
            this.disputeDateDateTimePicker.Size = new System.Drawing.Size(100, 21);
            this.disputeDateDateTimePicker.TabIndex = 7;
            // 
            // disputeUserNameTextBox
            // 
            // 
            // 
            // 
            this.disputeUserNameTextBox.Border.Class = "TextBoxBorder";
            this.disputeUserNameTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.disputeUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "DisputeUserName", true));
            this.disputeUserNameTextBox.Location = new System.Drawing.Point(370, 136);
            this.disputeUserNameTextBox.Name = "disputeUserNameTextBox";
            this.disputeUserNameTextBox.ReadOnly = true;
            this.disputeUserNameTextBox.Size = new System.Drawing.Size(100, 21);
            this.disputeUserNameTextBox.TabIndex = 11;
            // 
            // tabItemDispute
            // 
            this.tabItemDispute.AttachedControl = this.tabControlPanelDispute;
            this.tabItemDispute.Name = "tabItemDispute";
            this.tabItemDispute.Text = "商纠处理";
            // 
            // tabPanelEDI
            // 
            this.tabPanelEDI.Controls.Add(this.btnEDISave);
            this.tabPanelEDI.Controls.Add(this.groupPanelInvoiceAdv);
            this.tabPanelEDI.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabPanelEDI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanelEDI.Location = new System.Drawing.Point(0, 26);
            this.tabPanelEDI.Name = "tabPanelEDI";
            this.tabPanelEDI.Padding = new System.Windows.Forms.Padding(1);
            this.tabPanelEDI.Size = new System.Drawing.Size(550, 302);
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
            // btnEDISave
            // 
            this.btnEDISave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEDISave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEDISave.Location = new System.Drawing.Point(210, 183);
            this.btnEDISave.Name = "btnEDISave";
            this.btnEDISave.Size = new System.Drawing.Size(75, 21);
            this.btnEDISave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnEDISave.TabIndex = 4;
            this.btnEDISave.Text = "保存";
            this.btnEDISave.Click += new System.EventHandler(this.SaveEDI);
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
            this.groupPanelInvoiceAdv.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanelInvoiceAdv.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelInvoiceAdv.Location = new System.Drawing.Point(1, 1);
            this.groupPanelInvoiceAdv.Name = "groupPanelInvoiceAdv";
            this.groupPanelInvoiceAdv.Size = new System.Drawing.Size(548, 176);
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
            this.groupPanelInvoiceAdv.Style.CornerDiameter = 4;
            this.groupPanelInvoiceAdv.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelInvoiceAdv.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelInvoiceAdv.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelInvoiceAdv.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanelInvoiceAdv.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanelInvoiceAdv.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanelInvoiceAdv.TabIndex = 2;
            // 
            // invoiceReferenceNumberTextBox
            // 
            // 
            // 
            // 
            this.invoiceReferenceNumberTextBox.Border.Class = "TextBoxBorder";
            this.invoiceReferenceNumberTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.invoiceReferenceNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "InvoiceReferenceNumber", true));
            this.invoiceReferenceNumberTextBox.Location = new System.Drawing.Point(159, 148);
            this.invoiceReferenceNumberTextBox.Name = "invoiceReferenceNumberTextBox";
            this.invoiceReferenceNumberTextBox.Size = new System.Drawing.Size(120, 21);
            this.invoiceReferenceNumberTextBox.TabIndex = 17;
            // 
            // orderNumberReferenceTextBox
            // 
            // 
            // 
            // 
            this.orderNumberReferenceTextBox.Border.Class = "TextBoxBorder";
            this.orderNumberReferenceTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.orderNumberReferenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "OrderNumberReference", true));
            this.orderNumberReferenceTextBox.Location = new System.Drawing.Point(159, 124);
            this.orderNumberReferenceTextBox.Name = "orderNumberReferenceTextBox";
            this.orderNumberReferenceTextBox.Size = new System.Drawing.Size(121, 21);
            this.orderNumberReferenceTextBox.TabIndex = 15;
            // 
            // paymentConditionsComboBox
            // 
            this.paymentConditionsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PaymentConditions", true));
            this.paymentConditionsComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paymentConditionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentConditionsComboBox.FormattingEnabled = true;
            this.paymentConditionsComboBox.ItemHeight = 15;
            this.paymentConditionsComboBox.Items.AddRange(new object[] {
            "1-Open account",
            "2-Bill of exchange against acceptance",
            "3-Bill of exchange against payment",
            "4-Documents through banks",
            "5-Instalment payment without draft",
            "6-Instalment payment with draft",
            "7-Other"});
            this.paymentConditionsComboBox.Location = new System.Drawing.Point(159, 101);
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
            this.valueDateTextBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.valueDateTextBox.ButtonDropDown.Visible = true;
            this.valueDateTextBox.ButtonFreeText.Checked = true;
            this.valueDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "ValueDate", true));
            this.valueDateTextBox.FreeTextEntryMode = true;
            this.valueDateTextBox.IsPopupCalendarOpen = false;
            this.valueDateTextBox.Location = new System.Drawing.Point(439, 101);
            // 
            // 
            // 
            this.valueDateTextBox.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.valueDateTextBox.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.valueDateTextBox.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.valueDateTextBox.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.valueDateTextBox.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.valueDateTextBox.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.valueDateTextBox.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.valueDateTextBox.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.valueDateTextBox.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.valueDateTextBox.MonthCalendar.TodayButtonVisible = true;
            this.valueDateTextBox.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.valueDateTextBox.Name = "valueDateTextBox";
            this.valueDateTextBox.Size = new System.Drawing.Size(100, 21);
            this.valueDateTextBox.TabIndex = 13;
            // 
            // secondaryDiscountRateTextBox
            // 
            // 
            // 
            // 
            this.secondaryDiscountRateTextBox.Border.Class = "TextBoxBorder";
            this.secondaryDiscountRateTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.secondaryDiscountRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "SecondaryDiscountRate", true));
            this.secondaryDiscountRateTextBox.Location = new System.Drawing.Point(439, 78);
            this.secondaryDiscountRateTextBox.Name = "secondaryDiscountRateTextBox";
            this.secondaryDiscountRateTextBox.Size = new System.Drawing.Size(100, 21);
            this.secondaryDiscountRateTextBox.TabIndex = 9;
            // 
            // secondaryDiscountDaysTextBox
            // 
            // 
            // 
            // 
            this.secondaryDiscountDaysTextBox.Border.Class = "TextBoxBorder";
            this.secondaryDiscountDaysTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.secondaryDiscountDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "SecondaryDiscountDays", true));
            this.secondaryDiscountDaysTextBox.Location = new System.Drawing.Point(159, 77);
            this.secondaryDiscountDaysTextBox.Name = "secondaryDiscountDaysTextBox";
            this.secondaryDiscountDaysTextBox.Size = new System.Drawing.Size(122, 21);
            this.secondaryDiscountDaysTextBox.TabIndex = 5;
            // 
            // primaryDiscountRateTextBox
            // 
            // 
            // 
            // 
            this.primaryDiscountRateTextBox.Border.Class = "TextBoxBorder";
            this.primaryDiscountRateTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.primaryDiscountRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PrimaryDiscountRate", true));
            this.primaryDiscountRateTextBox.Location = new System.Drawing.Point(439, 54);
            this.primaryDiscountRateTextBox.Name = "primaryDiscountRateTextBox";
            this.primaryDiscountRateTextBox.Size = new System.Drawing.Size(100, 21);
            this.primaryDiscountRateTextBox.TabIndex = 7;
            // 
            // primaryDiscountDaysTextBox
            // 
            // 
            // 
            // 
            this.primaryDiscountDaysTextBox.Border.Class = "TextBoxBorder";
            this.primaryDiscountDaysTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.primaryDiscountDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "PrimaryDiscountDays", true));
            this.primaryDiscountDaysTextBox.Location = new System.Drawing.Point(159, 52);
            this.primaryDiscountDaysTextBox.Name = "primaryDiscountDaysTextBox";
            this.primaryDiscountDaysTextBox.Size = new System.Drawing.Size(122, 21);
            this.primaryDiscountDaysTextBox.TabIndex = 3;
            // 
            // netPaymentTermsTextBox
            // 
            // 
            // 
            // 
            this.netPaymentTermsTextBox.Border.Class = "TextBoxBorder";
            this.netPaymentTermsTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.netPaymentTermsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoiceBindingSource, "NetPaymentTerms", true));
            this.netPaymentTermsTextBox.Location = new System.Drawing.Point(159, 6);
            this.netPaymentTermsTextBox.Multiline = true;
            this.netPaymentTermsTextBox.Name = "netPaymentTermsTextBox";
            this.netPaymentTermsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.netPaymentTermsTextBox.Size = new System.Drawing.Size(380, 43);
            this.netPaymentTermsTextBox.TabIndex = 1;
            // 
            // tabItemEDI
            // 
            this.tabItemEDI.AttachedControl = this.tabPanelEDI;
            this.tabItemEDI.Name = "tabItemEDI";
            this.tabItemEDI.Text = "更多";
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PaymentCurrency";
            this.dataGridViewTextBoxColumn1.HeaderText = "币别";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 126;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PaymentDate";
            dataGridViewCellStyle19.Format = "d";
            dataGridViewCellStyle19.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn3.HeaderText = "付款日";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 126;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CreditNoteNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "贷项通知编号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CreditNoteDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "贷项通知日";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn6.HeaderText = "备注";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 126;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FinanceCurrency";
            this.dataGridViewTextBoxColumn7.HeaderText = "币别";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 84;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N2";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn8.HeaderText = "融资金额";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 84;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "FinanceDate";
            dataGridViewCellStyle21.Format = "d";
            dataGridViewCellStyle21.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn9.HeaderText = "融资日";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 84;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FinanceDueDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "融资到期日";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 85;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Commission";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "N2";
            this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn11.HeaderText = "手续费";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 84;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn12.HeaderText = "备注";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 84;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "RefundCurrency";
            this.dataGridViewTextBoxColumn13.HeaderText = "币别";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 126;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "RefundAmount";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "N2";
            this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn14.HeaderText = "还款金额";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 127;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "RefundDate";
            dataGridViewCellStyle24.Format = "d";
            dataGridViewCellStyle24.NullValue = null;
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn15.HeaderText = "还款日";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 126;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Comment";
            dataGridViewCellStyle25.Format = "d";
            dataGridViewCellStyle25.NullValue = null;
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn16.HeaderText = "备注";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 126;
            // 
            // colFinanceCurrency
            // 
            this.colFinanceCurrency.DataPropertyName = "FinanceCurrency";
            this.colFinanceCurrency.FillWeight = 98.90016F;
            this.colFinanceCurrency.HeaderText = "币别";
            this.colFinanceCurrency.Name = "colFinanceCurrency";
            this.colFinanceCurrency.ReadOnly = true;
            this.colFinanceCurrency.Width = 56;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colFinanceAmount.FillWeight = 98.90016F;
            this.colFinanceAmount.HeaderText = "融资金额";
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.ReadOnly = true;
            this.colFinanceAmount.Width = 80;
            // 
            // colFinanceDate
            // 
            this.colFinanceDate.DataPropertyName = "FinanceDate";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.colFinanceDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.colFinanceDate.FillWeight = 98.90016F;
            this.colFinanceDate.HeaderText = "融资日";
            this.colFinanceDate.Name = "colFinanceDate";
            this.colFinanceDate.ReadOnly = true;
            this.colFinanceDate.Width = 68;
            // 
            // colReassignDate
            // 
            this.colReassignDate.DataPropertyName = "ReassignDate";
            dataGridViewCellStyle8.Format = "d";
            this.colReassignDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.colReassignDate.FillWeight = 98.90016F;
            this.colReassignDate.HeaderText = "预计回购日";
            this.colReassignDate.Name = "colReassignDate";
            this.colReassignDate.ReadOnly = true;
            this.colReassignDate.Width = 92;
            // 
            // colFinanceRate
            // 
            this.colFinanceRate.DataPropertyName = "FinanceRate";
            dataGridViewCellStyle9.Format = "p4";
            dataGridViewCellStyle9.NullValue = null;
            this.colFinanceRate.DefaultCellStyle = dataGridViewCellStyle9;
            this.colFinanceRate.HeaderText = "融资利息";
            this.colFinanceRate.Name = "colFinanceRate";
            this.colFinanceRate.ReadOnly = true;
            this.colFinanceRate.Width = 80;
            // 
            // colFinanceRateType1
            // 
            this.colFinanceRateType1.DataPropertyName = "FinanceRateType1";
            this.colFinanceRateType1.HeaderText = "收息方式";
            this.colFinanceRateType1.Name = "colFinanceRateType1";
            this.colFinanceRateType1.ReadOnly = true;
            this.colFinanceRateType1.Width = 80;
            // 
            // colFinanceRateType2
            // 
            this.colFinanceRateType2.DataPropertyName = "FinanceRateType2";
            this.colFinanceRateType2.HeaderText = "计息方式";
            this.colFinanceRateType2.Name = "colFinanceRateType2";
            this.colFinanceRateType2.ReadOnly = true;
            this.colFinanceRateType2.Width = 80;
            // 
            // colCommission
            // 
            this.colCommission.DataPropertyName = "Commission";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.colCommission.DefaultCellStyle = dataGridViewCellStyle10;
            this.colCommission.FillWeight = 106.599F;
            this.colCommission.HeaderText = "手续费收入";
            this.colCommission.Name = "colCommission";
            this.colCommission.ReadOnly = true;
            this.colCommission.Width = 92;
            // 
            // colFinanceInterest
            // 
            this.colFinanceInterest.DataPropertyName = "Interest";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.colFinanceInterest.DefaultCellStyle = dataGridViewCellStyle11;
            this.colFinanceInterest.FillWeight = 98.90016F;
            this.colFinanceInterest.HeaderText = "利息收入";
            this.colFinanceInterest.Name = "colFinanceInterest";
            this.colFinanceInterest.ReadOnly = true;
            this.colFinanceInterest.Width = 80;
            // 
            // colFinanceComment
            // 
            this.colFinanceComment.DataPropertyName = "Comment";
            this.colFinanceComment.FillWeight = 98.90016F;
            this.colFinanceComment.HeaderText = "备注";
            this.colFinanceComment.Name = "colFinanceComment";
            this.colFinanceComment.ReadOnly = true;
            this.colFinanceComment.Width = 56;
            // 
            // InvoiceDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 328);
            this.Controls.Add(this.tabControl);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "InvoiceDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "发票详细信息";
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPanelInvoice.ResumeLayout(false);
            this.groupPanelInvoiceProcess.ResumeLayout(false);
            this.groupPanelInvoiceProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refundDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDueDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeDateDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignDateTextBox)).EndInit();
            this.groupPanelInvoiceBasic.ResumeLayout(false);
            this.groupPanelInvoiceBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dueDateTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDateTextBox)).EndInit();
            this.tabPanelLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentLogs)).EndInit();
            this.paymentLogMgr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinanceLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundLogs)).EndInit();
            this.refundLogMgr.ResumeLayout(false);
            this.tabPanelFlaw.ResumeLayout(false);
            this.groupPanelFlawResolve.ResumeLayout(false);
            this.groupPanelFlawResolve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flawResolveDateDateTimePicker)).EndInit();
            this.groupPanelFlaw.ResumeLayout(false);
            this.groupPanelFlaw.PerformLayout();
            this.tabControlPanelDispute.ResumeLayout(false);
            this.groupPanelDisputeResolve.ResumeLayout(false);
            this.groupPanelDisputeResolve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disputeResolveDateDateTimePicker)).EndInit();
            this.groupPanelDispute.ResumeLayout(false);
            this.groupPanelDispute.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disputeDateDateTimePicker)).EndInit();
            this.tabPanelEDI.ResumeLayout(false);
            this.groupPanelInvoiceAdv.ResumeLayout(false);
            this.groupPanelInvoiceAdv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueDateTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditNoteNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditNoteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFactorCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRefundDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevComponents.DotNetBar.Controls.TextBoxX unpaidCommissionTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReassignDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceRateType1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceRateType2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceInterest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceComment;
    }
}
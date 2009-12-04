//-----------------------------------------------------------------------
// <copyright file="ContractDetailUI.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.CaseMgr.ContractMgr
{
    /// <summary>
    /// 
    /// </summary>
    partial class ContractDetailUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.DateTimePicker contractDueDayDateTimePicker;
        private System.Windows.Forms.TextBox contractStatusTextBox;
        private System.Windows.Forms.DateTimePicker contractValueDayDateTimePicker;
        private System.Windows.Forms.TextBox createUserNameTextBox;
        private System.Windows.Forms.TextBox noticeTypeTextBox;
        private System.Windows.Forms.GroupBox gbFee;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox commissionTypeCommentTextBox;
        private System.Windows.Forms.TextBox commissonTypeTextBox;
        private System.Windows.Forms.TextBox eFPriceTextBox;
        private System.Windows.Forms.TextBox handFeeTextBox;
        private System.Windows.Forms.ComboBox cbHandFeeCurr;
        private System.Windows.Forms.TextBox iFPriceTextBox;
        private System.Windows.Forms.GroupBox gbCover;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox authorizationNoTextBox;
        private System.Windows.Forms.TextBox creditCoverTextBox;
        private System.Windows.Forms.TextBox creditCoverCurrTextBox;
        private System.Windows.Forms.DateTimePicker creditCoverPeriodBeginDateTimePicker;
        private System.Windows.Forms.DateTimePicker creditCoverPeriodEndDateTimePicker;
        private System.Windows.Forms.TextBox deductiblesTextBox;
        private System.Windows.Forms.TextBox financeGracePeriodTextBox;
        private System.Windows.Forms.TextBox financeLineTextBox;
        private System.Windows.Forms.TextBox financeLineCurrTextBox;
        private System.Windows.Forms.DateTimePicker financeLinePeriodBeginDateTimePicker;
        private System.Windows.Forms.DateTimePicker financeLinePeriodEndDateTimePicker;
        private System.Windows.Forms.TextBox financeProportionTextBox;
        private System.Windows.Forms.TextBox isCreditCoverRevolvingTextBox;
        private System.Windows.Forms.TextBox lossThresholdTextBox;
        private System.Windows.Forms.TextBox orderNumberTextBox;
        private System.Windows.Forms.TextBox paymentTermsTextBox;
        private System.Windows.Forms.TextBox pUGPeriodTextBox;
        private System.Windows.Forms.TextBox pUGProportionTextBox;
        private System.Windows.Forms.TextBox reassignGracePeriodTextBox;
        private System.Windows.Forms.GroupBox gbBasicInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox assignTypeTextBox;
        private System.Windows.Forms.TextBox bizTypeTextBox;
        private System.Windows.Forms.TextBox buyerFactorNoTextBox;
        private System.Windows.Forms.TextBox buyerNoTextBox;
        private System.Windows.Forms.TextBox contractNoTextBox;
        private System.Windows.Forms.ComboBox cbInvoiceCurrency;
        private System.Windows.Forms.TextBox isNoticeTextBox;
        private System.Windows.Forms.TextBox isRecoarseTextBox;
        private System.Windows.Forms.TextBox sellerFactorNoTextBox;
        private System.Windows.Forms.TextBox sellerNoTextBox;
        private System.Windows.Forms.ToolStrip tsContractDetail;
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
            System.Windows.Forms.Label labelFax;
            System.Windows.Forms.Label labelNoticePerson;
            System.Windows.Forms.Label labelComment;
            System.Windows.Forms.Label labelContractDueDay;
            System.Windows.Forms.Label labelContractStatus;
            System.Windows.Forms.Label labelContractValueDay;
            System.Windows.Forms.Label labelEmail;
            System.Windows.Forms.Label labelNoticeType;
            System.Windows.Forms.Label labelTotalFPrice;
            System.Windows.Forms.Label labelCommissionTypeComment;
            System.Windows.Forms.Label labelCommissonType;
            System.Windows.Forms.Label labelEFPrice;
            System.Windows.Forms.Label labelHandFee;
            System.Windows.Forms.Label labelHandFeeCurr;
            System.Windows.Forms.Label labelIFPrice;
            System.Windows.Forms.Label labelHighestFinanceLine;
            System.Windows.Forms.Label labelAuthorizationNo;
            System.Windows.Forms.Label labelCreditCover;
            System.Windows.Forms.Label labelCreditCoverCurr;
            System.Windows.Forms.Label labelCreditCoverPeriodBegin;
            System.Windows.Forms.Label creditPeriodEndLabel;
            System.Windows.Forms.Label labelDeductibles;
            System.Windows.Forms.Label labelFinanceGracePeriod;
            System.Windows.Forms.Label labelFinanceLine;
            System.Windows.Forms.Label labelFinanceLineCurr;
            System.Windows.Forms.Label labelFinanceLinePeriod;
            System.Windows.Forms.Label financeLinePeriodEndLabel;
            System.Windows.Forms.Label labelFinanceProportion;
            System.Windows.Forms.Label labelIsCreditCoverRevolving;
            System.Windows.Forms.Label labelLossThreshold;
            System.Windows.Forms.Label labelOrderNumber;
            System.Windows.Forms.Label labelPaymentTerms;
            System.Windows.Forms.Label labelPUGPeriod;
            System.Windows.Forms.Label labelPUGProportion;
            System.Windows.Forms.Label labelReassignGracePeriod;
            System.Windows.Forms.Label labelBuyerFactorName;
            System.Windows.Forms.Label labelSellerFactorName;
            System.Windows.Forms.Label labelAssignType;
            System.Windows.Forms.Label labelBizType;
            System.Windows.Forms.Label labelBuyerFactorNo;
            System.Windows.Forms.Label labelBuyerNo;
            System.Windows.Forms.Label labelContractNo;
            System.Windows.Forms.Label labelInvoiceCurrency;
            System.Windows.Forms.Label labelIsNotice;
            System.Windows.Forms.Label labelIsRecoarse;
            System.Windows.Forms.Label labelSellerFactorNo;
            System.Windows.Forms.Label labelSellerNo;
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.contractDueDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.contractStatusTextBox = new System.Windows.Forms.TextBox();
            this.contractValueDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createUserNameTextBox = new System.Windows.Forms.TextBox();
            this.noticeTypeTextBox = new System.Windows.Forms.TextBox();
            this.gbFee = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.commissionTypeCommentTextBox = new System.Windows.Forms.TextBox();
            this.commissonTypeTextBox = new System.Windows.Forms.TextBox();
            this.eFPriceTextBox = new System.Windows.Forms.TextBox();
            this.handFeeTextBox = new System.Windows.Forms.TextBox();
            this.cbHandFeeCurr = new System.Windows.Forms.ComboBox();
            this.iFPriceTextBox = new System.Windows.Forms.TextBox();
            this.gbCover = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.authorizationNoTextBox = new System.Windows.Forms.TextBox();
            this.creditCoverTextBox = new System.Windows.Forms.TextBox();
            this.creditCoverCurrTextBox = new System.Windows.Forms.TextBox();
            this.creditCoverPeriodBeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.creditCoverPeriodEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deductiblesTextBox = new System.Windows.Forms.TextBox();
            this.financeGracePeriodTextBox = new System.Windows.Forms.TextBox();
            this.financeLineTextBox = new System.Windows.Forms.TextBox();
            this.financeLineCurrTextBox = new System.Windows.Forms.TextBox();
            this.financeLinePeriodBeginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.financeLinePeriodEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.financeProportionTextBox = new System.Windows.Forms.TextBox();
            this.isCreditCoverRevolvingTextBox = new System.Windows.Forms.TextBox();
            this.lossThresholdTextBox = new System.Windows.Forms.TextBox();
            this.orderNumberTextBox = new System.Windows.Forms.TextBox();
            this.paymentTermsTextBox = new System.Windows.Forms.TextBox();
            this.pUGPeriodTextBox = new System.Windows.Forms.TextBox();
            this.pUGProportionTextBox = new System.Windows.Forms.TextBox();
            this.reassignGracePeriodTextBox = new System.Windows.Forms.TextBox();
            this.gbBasicInfo = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.assignTypeTextBox = new System.Windows.Forms.TextBox();
            this.bizTypeTextBox = new System.Windows.Forms.TextBox();
            this.buyerFactorNoTextBox = new System.Windows.Forms.TextBox();
            this.buyerNoTextBox = new System.Windows.Forms.TextBox();
            this.contractNoTextBox = new System.Windows.Forms.TextBox();
            this.cbInvoiceCurrency = new System.Windows.Forms.ComboBox();
            this.isNoticeTextBox = new System.Windows.Forms.TextBox();
            this.isRecoarseTextBox = new System.Windows.Forms.TextBox();
            this.sellerFactorNoTextBox = new System.Windows.Forms.TextBox();
            this.sellerNoTextBox = new System.Windows.Forms.TextBox();
            this.tsContractDetail = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            labelFax = new System.Windows.Forms.Label();
            labelNoticePerson = new System.Windows.Forms.Label();
            labelComment = new System.Windows.Forms.Label();
            labelContractDueDay = new System.Windows.Forms.Label();
            labelContractStatus = new System.Windows.Forms.Label();
            labelContractValueDay = new System.Windows.Forms.Label();
            labelEmail = new System.Windows.Forms.Label();
            labelNoticeType = new System.Windows.Forms.Label();
            labelTotalFPrice = new System.Windows.Forms.Label();
            labelCommissionTypeComment = new System.Windows.Forms.Label();
            labelCommissonType = new System.Windows.Forms.Label();
            labelEFPrice = new System.Windows.Forms.Label();
            labelHandFee = new System.Windows.Forms.Label();
            labelHandFeeCurr = new System.Windows.Forms.Label();
            labelIFPrice = new System.Windows.Forms.Label();
            labelHighestFinanceLine = new System.Windows.Forms.Label();
            labelAuthorizationNo = new System.Windows.Forms.Label();
            labelCreditCover = new System.Windows.Forms.Label();
            labelCreditCoverCurr = new System.Windows.Forms.Label();
            labelCreditCoverPeriodBegin = new System.Windows.Forms.Label();
            creditPeriodEndLabel = new System.Windows.Forms.Label();
            labelDeductibles = new System.Windows.Forms.Label();
            labelFinanceGracePeriod = new System.Windows.Forms.Label();
            labelFinanceLine = new System.Windows.Forms.Label();
            labelFinanceLineCurr = new System.Windows.Forms.Label();
            labelFinanceLinePeriod = new System.Windows.Forms.Label();
            financeLinePeriodEndLabel = new System.Windows.Forms.Label();
            labelFinanceProportion = new System.Windows.Forms.Label();
            labelIsCreditCoverRevolving = new System.Windows.Forms.Label();
            labelLossThreshold = new System.Windows.Forms.Label();
            labelOrderNumber = new System.Windows.Forms.Label();
            labelPaymentTerms = new System.Windows.Forms.Label();
            labelPUGPeriod = new System.Windows.Forms.Label();
            labelPUGProportion = new System.Windows.Forms.Label();
            labelReassignGracePeriod = new System.Windows.Forms.Label();
            labelBuyerFactorName = new System.Windows.Forms.Label();
            labelSellerFactorName = new System.Windows.Forms.Label();
            labelAssignType = new System.Windows.Forms.Label();
            labelBizType = new System.Windows.Forms.Label();
            labelBuyerFactorNo = new System.Windows.Forms.Label();
            labelBuyerNo = new System.Windows.Forms.Label();
            labelContractNo = new System.Windows.Forms.Label();
            labelInvoiceCurrency = new System.Windows.Forms.Label();
            labelIsNotice = new System.Windows.Forms.Label();
            labelIsRecoarse = new System.Windows.Forms.Label();
            labelSellerFactorNo = new System.Windows.Forms.Label();
            labelSellerNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            this.gbOther.SuspendLayout();
            this.gbFee.SuspendLayout();
            this.gbCover.SuspendLayout();
            this.gbBasicInfo.SuspendLayout();
            this.tsContractDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFax
            // 
            labelFax.AutoSize = true;
            labelFax.Location = new System.Drawing.Point(23, 127);
            labelFax.Name = "labelFax";
            labelFax.Size = new System.Drawing.Size(55, 13);
            labelFax.TabIndex = 109;
            labelFax.Text = "传真号码";
            // 
            // labelNoticePerson
            // 
            labelNoticePerson.AutoSize = true;
            labelNoticePerson.Location = new System.Drawing.Point(24, 98);
            labelNoticePerson.Name = "labelNoticePerson";
            labelNoticePerson.Size = new System.Drawing.Size(43, 13);
            labelNoticePerson.TabIndex = 107;
            labelNoticePerson.Text = "通知人";
            // 
            // labelComment
            // 
            labelComment.AutoSize = true;
            labelComment.Location = new System.Drawing.Point(335, 127);
            labelComment.Name = "labelComment";
            labelComment.Size = new System.Drawing.Size(31, 13);
            labelComment.TabIndex = 95;
            labelComment.Text = "备注";
            // 
            // labelContractDueDay
            // 
            labelContractDueDay.AutoSize = true;
            labelContractDueDay.Location = new System.Drawing.Point(335, 31);
            labelContractDueDay.Name = "labelContractDueDay";
            labelContractDueDay.Size = new System.Drawing.Size(67, 13);
            labelContractDueDay.TabIndex = 97;
            labelContractDueDay.Text = "合同到期日";
            // 
            // labelContractStatus
            // 
            labelContractStatus.AutoSize = true;
            labelContractStatus.Location = new System.Drawing.Point(24, 65);
            labelContractStatus.Name = "labelContractStatus";
            labelContractStatus.Size = new System.Drawing.Size(55, 13);
            labelContractStatus.TabIndex = 99;
            labelContractStatus.Text = "合同状态";
            // 
            // labelContractValueDay
            // 
            labelContractValueDay.AutoSize = true;
            labelContractValueDay.Location = new System.Drawing.Point(23, 33);
            labelContractValueDay.Name = "labelContractValueDay";
            labelContractValueDay.Size = new System.Drawing.Size(67, 13);
            labelContractValueDay.TabIndex = 101;
            labelContractValueDay.Text = "合同生效日";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new System.Drawing.Point(335, 98);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(56, 13);
            labelEmail.TabIndex = 103;
            labelEmail.Text = "Email地址";
            // 
            // labelNoticeType
            // 
            labelNoticeType.AutoSize = true;
            labelNoticeType.Location = new System.Drawing.Point(335, 65);
            labelNoticeType.Name = "labelNoticeType";
            labelNoticeType.Size = new System.Drawing.Size(55, 13);
            labelNoticeType.TabIndex = 105;
            labelNoticeType.Text = "通知方式";
            // 
            // labelTotalFPrice
            // 
            labelTotalFPrice.AutoSize = true;
            labelTotalFPrice.Location = new System.Drawing.Point(23, 26);
            labelTotalFPrice.Name = "labelTotalFPrice";
            labelTotalFPrice.Size = new System.Drawing.Size(67, 13);
            labelTotalFPrice.TabIndex = 103;
            labelTotalFPrice.Text = "总手续费率";
            // 
            // labelCommissionTypeComment
            // 
            labelCommissionTypeComment.AutoSize = true;
            labelCommissionTypeComment.Location = new System.Drawing.Point(335, 102);
            labelCommissionTypeComment.Name = "labelCommissionTypeComment";
            labelCommissionTypeComment.Size = new System.Drawing.Size(31, 13);
            labelCommissionTypeComment.TabIndex = 91;
            labelCommissionTypeComment.Text = "说明";
            // 
            // labelCommissonType
            // 
            labelCommissonType.AutoSize = true;
            labelCommissonType.Location = new System.Drawing.Point(24, 102);
            labelCommissonType.Name = "labelCommissonType";
            labelCommissonType.Size = new System.Drawing.Size(91, 13);
            labelCommissonType.TabIndex = 93;
            labelCommissonType.Text = "手续费结算方式";
            // 
            // labelEFPrice
            // 
            labelEFPrice.AutoSize = true;
            labelEFPrice.Location = new System.Drawing.Point(23, 64);
            labelEFPrice.Name = "labelEFPrice";
            labelEFPrice.Size = new System.Drawing.Size(115, 13);
            labelEFPrice.TabIndex = 95;
            labelEFPrice.Text = "买方保理商手续费率";
            // 
            // labelHandFee
            // 
            labelHandFee.AutoSize = true;
            labelHandFee.Location = new System.Drawing.Point(24, 140);
            labelHandFee.Name = "labelHandFee";
            labelHandFee.Size = new System.Drawing.Size(67, 13);
            labelHandFee.TabIndex = 97;
            labelHandFee.Text = "单据处理费";
            // 
            // labelHandFeeCurr
            // 
            labelHandFeeCurr.AutoSize = true;
            labelHandFeeCurr.Location = new System.Drawing.Point(335, 140);
            labelHandFeeCurr.Name = "labelHandFeeCurr";
            labelHandFeeCurr.Size = new System.Drawing.Size(91, 13);
            labelHandFeeCurr.TabIndex = 99;
            labelHandFeeCurr.Text = "单据处理费币别";
            // 
            // labelIFPrice
            // 
            labelIFPrice.AutoSize = true;
            labelIFPrice.Location = new System.Drawing.Point(335, 64);
            labelIFPrice.Name = "labelIFPrice";
            labelIFPrice.Size = new System.Drawing.Size(115, 13);
            labelIFPrice.TabIndex = 101;
            labelIFPrice.Text = "卖方保理商手续费率";
            // 
            // labelHighestFinanceLine
            // 
            labelHighestFinanceLine.AutoSize = true;
            labelHighestFinanceLine.Location = new System.Drawing.Point(23, 267);
            labelHighestFinanceLine.Name = "labelHighestFinanceLine";
            labelHighestFinanceLine.Size = new System.Drawing.Size(115, 13);
            labelHighestFinanceLine.TabIndex = 127;
            labelHighestFinanceLine.Text = "最高保理预付款额度";
            // 
            // labelAuthorizationNo
            // 
            labelAuthorizationNo.AutoSize = true;
            labelAuthorizationNo.Location = new System.Drawing.Point(334, 59);
            labelAuthorizationNo.Name = "labelAuthorizationNo";
            labelAuthorizationNo.Size = new System.Drawing.Size(55, 13);
            labelAuthorizationNo.TabIndex = 89;
            labelAuthorizationNo.Text = "核准编号";
            // 
            // labelCreditCover
            // 
            labelCreditCover.AutoSize = true;
            labelCreditCover.Location = new System.Drawing.Point(334, 24);
            labelCreditCover.Name = "labelCreditCover";
            labelCreditCover.Size = new System.Drawing.Size(103, 13);
            labelCreditCover.TabIndex = 91;
            labelCreditCover.Text = "买方信用风险额度";
            // 
            // labelCreditCoverCurr
            // 
            labelCreditCoverCurr.AutoSize = true;
            labelCreditCoverCurr.Location = new System.Drawing.Point(23, 24);
            labelCreditCoverCurr.Name = "labelCreditCoverCurr";
            labelCreditCoverCurr.Size = new System.Drawing.Size(103, 13);
            labelCreditCoverCurr.TabIndex = 93;
            labelCreditCoverCurr.Text = "买方风险额度币别";
            // 
            // labelCreditCoverPeriodBegin
            // 
            labelCreditCoverPeriodBegin.AutoSize = true;
            labelCreditCoverPeriodBegin.Location = new System.Drawing.Point(23, 131);
            labelCreditCoverPeriodBegin.Name = "labelCreditCoverPeriodBegin";
            labelCreditCoverPeriodBegin.Size = new System.Drawing.Size(151, 13);
            labelCreditCoverPeriodBegin.TabIndex = 95;
            labelCreditCoverPeriodBegin.Text = "买方信用风险额度有效期限";
            // 
            // creditPeriodEndLabel
            // 
            creditPeriodEndLabel.AutoSize = true;
            creditPeriodEndLabel.Location = new System.Drawing.Point(367, 134);
            creditPeriodEndLabel.Name = "creditPeriodEndLabel";
            creditPeriodEndLabel.Size = new System.Drawing.Size(14, 13);
            creditPeriodEndLabel.TabIndex = 97;
            creditPeriodEndLabel.Text = "~";
            // 
            // labelDeductibles
            // 
            labelDeductibles.AutoSize = true;
            labelDeductibles.Location = new System.Drawing.Point(23, 371);
            labelDeductibles.Name = "labelDeductibles";
            labelDeductibles.Size = new System.Drawing.Size(43, 13);
            labelDeductibles.TabIndex = 99;
            labelDeductibles.Text = "自付额";
            // 
            // labelFinanceGracePeriod
            // 
            labelFinanceGracePeriod.AutoSize = true;
            labelFinanceGracePeriod.Location = new System.Drawing.Point(23, 336);
            labelFinanceGracePeriod.Name = "labelFinanceGracePeriod";
            labelFinanceGracePeriod.Size = new System.Drawing.Size(67, 13);
            labelFinanceGracePeriod.TabIndex = 101;
            labelFinanceGracePeriod.Text = "融资宽限期";
            // 
            // labelFinanceLine
            // 
            labelFinanceLine.AutoSize = true;
            labelFinanceLine.Location = new System.Drawing.Point(334, 197);
            labelFinanceLine.Name = "labelFinanceLine";
            labelFinanceLine.Size = new System.Drawing.Size(67, 13);
            labelFinanceLine.TabIndex = 103;
            labelFinanceLine.Text = "预付款额度";
            // 
            // labelFinanceLineCurr
            // 
            labelFinanceLineCurr.AutoSize = true;
            labelFinanceLineCurr.Location = new System.Drawing.Point(23, 197);
            labelFinanceLineCurr.Name = "labelFinanceLineCurr";
            labelFinanceLineCurr.Size = new System.Drawing.Size(67, 13);
            labelFinanceLineCurr.TabIndex = 105;
            labelFinanceLineCurr.Text = "预付款币别";
            // 
            // labelFinanceLinePeriod
            // 
            labelFinanceLinePeriod.AutoSize = true;
            labelFinanceLinePeriod.Location = new System.Drawing.Point(22, 232);
            labelFinanceLinePeriod.Name = "labelFinanceLinePeriod";
            labelFinanceLinePeriod.Size = new System.Drawing.Size(115, 13);
            labelFinanceLinePeriod.TabIndex = 107;
            labelFinanceLinePeriod.Text = "预付款额度有效期限";
            // 
            // financeLinePeriodEndLabel
            // 
            financeLinePeriodEndLabel.AutoSize = true;
            financeLinePeriodEndLabel.Location = new System.Drawing.Point(367, 231);
            financeLinePeriodEndLabel.Name = "financeLinePeriodEndLabel";
            financeLinePeriodEndLabel.Size = new System.Drawing.Size(14, 13);
            financeLinePeriodEndLabel.TabIndex = 109;
            financeLinePeriodEndLabel.Text = "~";
            // 
            // labelFinanceProportion
            // 
            labelFinanceProportion.AutoSize = true;
            labelFinanceProportion.Location = new System.Drawing.Point(334, 267);
            labelFinanceProportion.Name = "labelFinanceProportion";
            labelFinanceProportion.Size = new System.Drawing.Size(67, 13);
            labelFinanceProportion.TabIndex = 111;
            labelFinanceProportion.Text = "预付款比例";
            // 
            // labelIsCreditCoverRevolving
            // 
            labelIsCreditCoverRevolving.AutoSize = true;
            labelIsCreditCoverRevolving.Location = new System.Drawing.Point(23, 59);
            labelIsCreditCoverRevolving.Name = "labelIsCreditCoverRevolving";
            labelIsCreditCoverRevolving.Size = new System.Drawing.Size(67, 13);
            labelIsCreditCoverRevolving.TabIndex = 113;
            labelIsCreditCoverRevolving.Text = "是否可循环";
            // 
            // labelLossThreshold
            // 
            labelLossThreshold.AutoSize = true;
            labelLossThreshold.Location = new System.Drawing.Point(334, 336);
            labelLossThreshold.Name = "labelLossThreshold";
            labelLossThreshold.Size = new System.Drawing.Size(79, 13);
            labelLossThreshold.TabIndex = 115;
            labelLossThreshold.Text = "最低损失门槛";
            // 
            // labelOrderNumber
            // 
            labelOrderNumber.AutoSize = true;
            labelOrderNumber.Location = new System.Drawing.Point(23, 301);
            labelOrderNumber.Name = "labelOrderNumber";
            labelOrderNumber.Size = new System.Drawing.Size(43, 13);
            labelOrderNumber.TabIndex = 117;
            labelOrderNumber.Text = "订单号";
            // 
            // labelPaymentTerms
            // 
            labelPaymentTerms.AutoSize = true;
            labelPaymentTerms.Location = new System.Drawing.Point(334, 301);
            labelPaymentTerms.Name = "labelPaymentTerms";
            labelPaymentTerms.Size = new System.Drawing.Size(55, 13);
            labelPaymentTerms.TabIndex = 119;
            labelPaymentTerms.Text = "付款条件";
            // 
            // labelPUGPeriod
            // 
            labelPUGPeriod.AutoSize = true;
            labelPUGPeriod.Location = new System.Drawing.Point(334, 92);
            labelPUGPeriod.Name = "labelPUGPeriod";
            labelPUGPeriod.Size = new System.Drawing.Size(115, 13);
            labelPUGPeriod.TabIndex = 121;
            labelPUGPeriod.Text = "担保付款期限（天）";
            // 
            // labelPUGProportion
            // 
            labelPUGProportion.AutoSize = true;
            labelPUGProportion.Location = new System.Drawing.Point(22, 93);
            labelPUGProportion.Name = "labelPUGProportion";
            labelPUGProportion.Size = new System.Drawing.Size(127, 13);
            labelPUGProportion.TabIndex = 123;
            labelPUGProportion.Text = "买方信用风险担保比例";
            // 
            // labelReassignGracePeriod
            // 
            labelReassignGracePeriod.AutoSize = true;
            labelReassignGracePeriod.Location = new System.Drawing.Point(23, 163);
            labelReassignGracePeriod.Name = "labelReassignGracePeriod";
            labelReassignGracePeriod.Size = new System.Drawing.Size(67, 13);
            labelReassignGracePeriod.TabIndex = 125;
            labelReassignGracePeriod.Text = "回购宽限期";
            // 
            // labelBuyerFactorName
            // 
            labelBuyerFactorName.AutoSize = true;
            labelBuyerFactorName.Location = new System.Drawing.Point(330, 80);
            labelBuyerFactorName.Name = "labelBuyerFactorName";
            labelBuyerFactorName.Size = new System.Drawing.Size(67, 13);
            labelBuyerFactorName.TabIndex = 109;
            labelBuyerFactorName.Text = "买方保理商";
            // 
            // labelSellerFactorName
            // 
            labelSellerFactorName.AutoSize = true;
            labelSellerFactorName.Location = new System.Drawing.Point(330, 51);
            labelSellerFactorName.Name = "labelSellerFactorName";
            labelSellerFactorName.Size = new System.Drawing.Size(67, 13);
            labelSellerFactorName.TabIndex = 107;
            labelSellerFactorName.Text = "卖方保理商";
            // 
            // labelAssignType
            // 
            labelAssignType.AutoSize = true;
            labelAssignType.Location = new System.Drawing.Point(19, 197);
            labelAssignType.Name = "labelAssignType";
            labelAssignType.Size = new System.Drawing.Size(55, 13);
            labelAssignType.TabIndex = 87;
            labelAssignType.Text = "转让方式";
            // 
            // labelBizType
            // 
            labelBizType.AutoSize = true;
            labelBizType.Location = new System.Drawing.Point(330, 109);
            labelBizType.Name = "labelBizType";
            labelBizType.Size = new System.Drawing.Size(55, 13);
            labelBizType.TabIndex = 89;
            labelBizType.Text = "业务类别";
            // 
            // labelBuyerFactorNo
            // 
            labelBuyerFactorNo.AutoSize = true;
            labelBuyerFactorNo.Location = new System.Drawing.Point(19, 109);
            labelBuyerFactorNo.Name = "labelBuyerFactorNo";
            labelBuyerFactorNo.Size = new System.Drawing.Size(91, 13);
            labelBuyerFactorNo.TabIndex = 91;
            labelBuyerFactorNo.Text = "买方保理商编号";
            // 
            // labelBuyerNo
            // 
            labelBuyerNo.AutoSize = true;
            labelBuyerNo.Location = new System.Drawing.Point(19, 80);
            labelBuyerNo.Name = "labelBuyerNo";
            labelBuyerNo.Size = new System.Drawing.Size(55, 13);
            labelBuyerNo.TabIndex = 93;
            labelBuyerNo.Text = "买方名称";
            // 
            // labelContractNo
            // 
            labelContractNo.AutoSize = true;
            labelContractNo.Location = new System.Drawing.Point(19, 22);
            labelContractNo.Name = "labelContractNo";
            labelContractNo.Size = new System.Drawing.Size(67, 13);
            labelContractNo.TabIndex = 95;
            labelContractNo.Text = "主合同编号";
            // 
            // labelInvoiceCurrency
            // 
            labelInvoiceCurrency.AutoSize = true;
            labelInvoiceCurrency.Location = new System.Drawing.Point(19, 139);
            labelInvoiceCurrency.Name = "labelInvoiceCurrency";
            labelInvoiceCurrency.Size = new System.Drawing.Size(55, 13);
            labelInvoiceCurrency.TabIndex = 97;
            labelInvoiceCurrency.Text = "发票币别";
            // 
            // labelIsNotice
            // 
            labelIsNotice.AutoSize = true;
            labelIsNotice.Location = new System.Drawing.Point(330, 139);
            labelIsNotice.Name = "labelIsNotice";
            labelIsNotice.Size = new System.Drawing.Size(67, 13);
            labelIsNotice.TabIndex = 99;
            labelIsNotice.Text = "是否明保理";
            // 
            // labelIsRecoarse
            // 
            labelIsRecoarse.AutoSize = true;
            labelIsRecoarse.Location = new System.Drawing.Point(19, 168);
            labelIsRecoarse.Name = "labelIsRecoarse";
            labelIsRecoarse.Size = new System.Drawing.Size(79, 13);
            labelIsRecoarse.TabIndex = 101;
            labelIsRecoarse.Text = "是否有追索权";
            // 
            // labelSellerFactorNo
            // 
            labelSellerFactorNo.AutoSize = true;
            labelSellerFactorNo.Location = new System.Drawing.Point(19, 51);
            labelSellerFactorNo.Name = "labelSellerFactorNo";
            labelSellerFactorNo.Size = new System.Drawing.Size(91, 13);
            labelSellerFactorNo.TabIndex = 103;
            labelSellerFactorNo.Text = "卖方保理商编号";
            // 
            // labelSellerNo
            // 
            labelSellerNo.AutoSize = true;
            labelSellerNo.Location = new System.Drawing.Point(330, 22);
            labelSellerNo.Name = "labelSellerNo";
            labelSellerNo.Size = new System.Drawing.Size(55, 13);
            labelSellerNo.TabIndex = 105;
            labelSellerNo.Text = "卖方名称";
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Contract);
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(labelFax);
            this.gbOther.Controls.Add(this.textBox6);
            this.gbOther.Controls.Add(labelNoticePerson);
            this.gbOther.Controls.Add(this.textBox5);
            this.gbOther.Controls.Add(labelComment);
            this.gbOther.Controls.Add(this.commentTextBox);
            this.gbOther.Controls.Add(labelContractDueDay);
            this.gbOther.Controls.Add(this.contractDueDayDateTimePicker);
            this.gbOther.Controls.Add(labelContractStatus);
            this.gbOther.Controls.Add(this.contractStatusTextBox);
            this.gbOther.Controls.Add(labelContractValueDay);
            this.gbOther.Controls.Add(this.contractValueDayDateTimePicker);
            this.gbOther.Controls.Add(labelEmail);
            this.gbOther.Controls.Add(this.createUserNameTextBox);
            this.gbOther.Controls.Add(labelNoticeType);
            this.gbOther.Controls.Add(this.noticeTypeTextBox);
            this.gbOther.Location = new System.Drawing.Point(14, 863);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(630, 163);
            this.gbOther.TabIndex = 91;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "其他信息";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Comment", true));
            this.textBox6.Location = new System.Drawing.Point(154, 124);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(154, 20);
            this.textBox6.TabIndex = 110;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "NoticeType", true));
            this.textBox5.Location = new System.Drawing.Point(154, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(154, 20);
            this.textBox5.TabIndex = 108;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(456, 118);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(152, 20);
            this.commentTextBox.TabIndex = 96;
            // 
            // contractDueDayDateTimePicker
            // 
            this.contractDueDayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "ContractDueDay", true));
            this.contractDueDayDateTimePicker.Location = new System.Drawing.Point(456, 24);
            this.contractDueDayDateTimePicker.Name = "contractDueDayDateTimePicker";
            this.contractDueDayDateTimePicker.Size = new System.Drawing.Size(152, 20);
            this.contractDueDayDateTimePicker.TabIndex = 98;
            // 
            // contractStatusTextBox
            // 
            this.contractStatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ContractStatus", true));
            this.contractStatusTextBox.Location = new System.Drawing.Point(154, 59);
            this.contractStatusTextBox.Name = "contractStatusTextBox";
            this.contractStatusTextBox.Size = new System.Drawing.Size(154, 20);
            this.contractStatusTextBox.TabIndex = 100;
            // 
            // contractValueDayDateTimePicker
            // 
            this.contractValueDayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "ContractValueDay", true));
            this.contractValueDayDateTimePicker.Location = new System.Drawing.Point(154, 26);
            this.contractValueDayDateTimePicker.Name = "contractValueDayDateTimePicker";
            this.contractValueDayDateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.contractValueDayDateTimePicker.TabIndex = 102;
            // 
            // createUserNameTextBox
            // 
            this.createUserNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "CreateUserName", true));
            this.createUserNameTextBox.Location = new System.Drawing.Point(456, 87);
            this.createUserNameTextBox.Name = "createUserNameTextBox";
            this.createUserNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.createUserNameTextBox.TabIndex = 104;
            // 
            // noticeTypeTextBox
            // 
            this.noticeTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "NoticeType", true));
            this.noticeTypeTextBox.Location = new System.Drawing.Point(456, 55);
            this.noticeTypeTextBox.Name = "noticeTypeTextBox";
            this.noticeTypeTextBox.Size = new System.Drawing.Size(152, 20);
            this.noticeTypeTextBox.TabIndex = 106;
            // 
            // gbFee
            // 
            this.gbFee.Controls.Add(labelTotalFPrice);
            this.gbFee.Controls.Add(this.textBox4);
            this.gbFee.Controls.Add(labelCommissionTypeComment);
            this.gbFee.Controls.Add(this.commissionTypeCommentTextBox);
            this.gbFee.Controls.Add(labelCommissonType);
            this.gbFee.Controls.Add(this.commissonTypeTextBox);
            this.gbFee.Controls.Add(labelEFPrice);
            this.gbFee.Controls.Add(this.eFPriceTextBox);
            this.gbFee.Controls.Add(labelHandFee);
            this.gbFee.Controls.Add(this.handFeeTextBox);
            this.gbFee.Controls.Add(labelHandFeeCurr);
            this.gbFee.Controls.Add(this.cbHandFeeCurr);
            this.gbFee.Controls.Add(labelIFPrice);
            this.gbFee.Controls.Add(this.iFPriceTextBox);
            this.gbFee.Location = new System.Drawing.Point(14, 686);
            this.gbFee.Name = "gbFee";
            this.gbFee.Size = new System.Drawing.Size(630, 170);
            this.gbFee.TabIndex = 92;
            this.gbFee.TabStop = false;
            this.gbFee.Text = "费用信息";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "IFPrice", true));
            this.textBox4.Location = new System.Drawing.Point(154, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 20);
            this.textBox4.TabIndex = 104;
            // 
            // commissionTypeCommentTextBox
            // 
            this.commissionTypeCommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "CommissionTypeComment", true));
            this.commissionTypeCommentTextBox.Location = new System.Drawing.Point(456, 99);
            this.commissionTypeCommentTextBox.Name = "commissionTypeCommentTextBox";
            this.commissionTypeCommentTextBox.Size = new System.Drawing.Size(152, 20);
            this.commissionTypeCommentTextBox.TabIndex = 92;
            // 
            // commissonTypeTextBox
            // 
            this.commissonTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "CommissonType", true));
            this.commissonTypeTextBox.Location = new System.Drawing.Point(154, 99);
            this.commissonTypeTextBox.Name = "commissonTypeTextBox";
            this.commissonTypeTextBox.Size = new System.Drawing.Size(154, 20);
            this.commissonTypeTextBox.TabIndex = 94;
            // 
            // eFPriceTextBox
            // 
            this.eFPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "EFPrice", true));
            this.eFPriceTextBox.Location = new System.Drawing.Point(154, 61);
            this.eFPriceTextBox.Name = "eFPriceTextBox";
            this.eFPriceTextBox.Size = new System.Drawing.Size(154, 20);
            this.eFPriceTextBox.TabIndex = 96;
            // 
            // handFeeTextBox
            // 
            this.handFeeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "HandFee", true));
            this.handFeeTextBox.Location = new System.Drawing.Point(154, 137);
            this.handFeeTextBox.Name = "handFeeTextBox";
            this.handFeeTextBox.Size = new System.Drawing.Size(154, 20);
            this.handFeeTextBox.TabIndex = 98;
            // 
            // cbHandFeeCurr
            // 
            this.cbHandFeeCurr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "HandFeeCurr", true));
            this.cbHandFeeCurr.DisplayMember = "CurrencyFormat";
            this.cbHandFeeCurr.Location = new System.Drawing.Point(456, 137);
            this.cbHandFeeCurr.Name = "cbHandFeeCurr";
            this.cbHandFeeCurr.Size = new System.Drawing.Size(152, 21);
            this.cbHandFeeCurr.TabIndex = 100;
            this.cbHandFeeCurr.ValueMember = "CurrencyCode";
            // 
            // iFPriceTextBox
            // 
            this.iFPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "IFPrice", true));
            this.iFPriceTextBox.Location = new System.Drawing.Point(456, 61);
            this.iFPriceTextBox.Name = "iFPriceTextBox";
            this.iFPriceTextBox.Size = new System.Drawing.Size(152, 20);
            this.iFPriceTextBox.TabIndex = 102;
            // 
            // gbCover
            // 
            this.gbCover.Controls.Add(labelHighestFinanceLine);
            this.gbCover.Controls.Add(this.textBox3);
            this.gbCover.Controls.Add(labelAuthorizationNo);
            this.gbCover.Controls.Add(this.authorizationNoTextBox);
            this.gbCover.Controls.Add(labelCreditCover);
            this.gbCover.Controls.Add(this.creditCoverTextBox);
            this.gbCover.Controls.Add(labelCreditCoverCurr);
            this.gbCover.Controls.Add(this.creditCoverCurrTextBox);
            this.gbCover.Controls.Add(labelCreditCoverPeriodBegin);
            this.gbCover.Controls.Add(this.creditCoverPeriodBeginDateTimePicker);
            this.gbCover.Controls.Add(creditPeriodEndLabel);
            this.gbCover.Controls.Add(this.creditCoverPeriodEndDateTimePicker);
            this.gbCover.Controls.Add(labelDeductibles);
            this.gbCover.Controls.Add(this.deductiblesTextBox);
            this.gbCover.Controls.Add(labelFinanceGracePeriod);
            this.gbCover.Controls.Add(this.financeGracePeriodTextBox);
            this.gbCover.Controls.Add(labelFinanceLine);
            this.gbCover.Controls.Add(this.financeLineTextBox);
            this.gbCover.Controls.Add(labelFinanceLineCurr);
            this.gbCover.Controls.Add(this.financeLineCurrTextBox);
            this.gbCover.Controls.Add(labelFinanceLinePeriod);
            this.gbCover.Controls.Add(this.financeLinePeriodBeginDateTimePicker);
            this.gbCover.Controls.Add(financeLinePeriodEndLabel);
            this.gbCover.Controls.Add(this.financeLinePeriodEndDateTimePicker);
            this.gbCover.Controls.Add(labelFinanceProportion);
            this.gbCover.Controls.Add(this.financeProportionTextBox);
            this.gbCover.Controls.Add(labelIsCreditCoverRevolving);
            this.gbCover.Controls.Add(this.isCreditCoverRevolvingTextBox);
            this.gbCover.Controls.Add(labelLossThreshold);
            this.gbCover.Controls.Add(this.lossThresholdTextBox);
            this.gbCover.Controls.Add(labelOrderNumber);
            this.gbCover.Controls.Add(this.orderNumberTextBox);
            this.gbCover.Controls.Add(labelPaymentTerms);
            this.gbCover.Controls.Add(this.paymentTermsTextBox);
            this.gbCover.Controls.Add(labelPUGPeriod);
            this.gbCover.Controls.Add(this.pUGPeriodTextBox);
            this.gbCover.Controls.Add(labelPUGProportion);
            this.gbCover.Controls.Add(this.pUGProportionTextBox);
            this.gbCover.Controls.Add(labelReassignGracePeriod);
            this.gbCover.Controls.Add(this.reassignGracePeriodTextBox);
            this.gbCover.Location = new System.Drawing.Point(15, 272);
            this.gbCover.Name = "gbCover";
            this.gbCover.Size = new System.Drawing.Size(629, 405);
            this.gbCover.TabIndex = 93;
            this.gbCover.TabStop = false;
            this.gbCover.Text = "买卖方关联额度信息";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Comment", true));
            this.textBox3.Location = new System.Drawing.Point(153, 263);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 20);
            this.textBox3.TabIndex = 128;
            // 
            // authorizationNoTextBox
            // 
            this.authorizationNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "AuthorizationNo", true));
            this.authorizationNoTextBox.Location = new System.Drawing.Point(455, 55);
            this.authorizationNoTextBox.Name = "authorizationNoTextBox";
            this.authorizationNoTextBox.Size = new System.Drawing.Size(152, 20);
            this.authorizationNoTextBox.TabIndex = 90;
            // 
            // creditCoverTextBox
            // 
            this.creditCoverTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "CreditCover", true));
            this.creditCoverTextBox.Location = new System.Drawing.Point(455, 21);
            this.creditCoverTextBox.Name = "creditCoverTextBox";
            this.creditCoverTextBox.Size = new System.Drawing.Size(152, 20);
            this.creditCoverTextBox.TabIndex = 92;
            // 
            // creditCoverCurrTextBox
            // 
            this.creditCoverCurrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "CreditCoverCurr", true));
            this.creditCoverCurrTextBox.Location = new System.Drawing.Point(153, 21);
            this.creditCoverCurrTextBox.Name = "creditCoverCurrTextBox";
            this.creditCoverCurrTextBox.Size = new System.Drawing.Size(154, 20);
            this.creditCoverCurrTextBox.TabIndex = 94;
            // 
            // creditCoverPeriodBeginDateTimePicker
            // 
            this.creditCoverPeriodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "CreditCoverPeriodBegin", true));
            this.creditCoverPeriodBeginDateTimePicker.Location = new System.Drawing.Point(203, 125);
            this.creditCoverPeriodBeginDateTimePicker.Name = "creditCoverPeriodBeginDateTimePicker";
            this.creditCoverPeriodBeginDateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.creditCoverPeriodBeginDateTimePicker.TabIndex = 96;
            // 
            // creditCoverPeriodEndDateTimePicker
            // 
            this.creditCoverPeriodEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "CreditCoverPeriodEnd", true));
            this.creditCoverPeriodEndDateTimePicker.Location = new System.Drawing.Point(384, 125);
            this.creditCoverPeriodEndDateTimePicker.Name = "creditCoverPeriodEndDateTimePicker";
            this.creditCoverPeriodEndDateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.creditCoverPeriodEndDateTimePicker.TabIndex = 98;
            // 
            // deductiblesTextBox
            // 
            this.deductiblesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "Deductibles", true));
            this.deductiblesTextBox.Location = new System.Drawing.Point(153, 367);
            this.deductiblesTextBox.Name = "deductiblesTextBox";
            this.deductiblesTextBox.Size = new System.Drawing.Size(154, 20);
            this.deductiblesTextBox.TabIndex = 100;
            // 
            // financeGracePeriodTextBox
            // 
            this.financeGracePeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "FinanceGracePeriod", true));
            this.financeGracePeriodTextBox.Location = new System.Drawing.Point(153, 333);
            this.financeGracePeriodTextBox.Name = "financeGracePeriodTextBox";
            this.financeGracePeriodTextBox.Size = new System.Drawing.Size(154, 20);
            this.financeGracePeriodTextBox.TabIndex = 102;
            // 
            // financeLineTextBox
            // 
            this.financeLineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "FinanceLine", true));
            this.financeLineTextBox.Location = new System.Drawing.Point(455, 194);
            this.financeLineTextBox.Name = "financeLineTextBox";
            this.financeLineTextBox.Size = new System.Drawing.Size(152, 20);
            this.financeLineTextBox.TabIndex = 104;
            // 
            // financeLineCurrTextBox
            // 
            this.financeLineCurrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "FinanceLineCurr", true));
            this.financeLineCurrTextBox.Location = new System.Drawing.Point(153, 194);
            this.financeLineCurrTextBox.Name = "financeLineCurrTextBox";
            this.financeLineCurrTextBox.Size = new System.Drawing.Size(154, 20);
            this.financeLineCurrTextBox.TabIndex = 106;
            // 
            // financeLinePeriodBeginDateTimePicker
            // 
            this.financeLinePeriodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "FinanceLinePeriodBegin", true));
            this.financeLinePeriodBeginDateTimePicker.Location = new System.Drawing.Point(203, 224);
            this.financeLinePeriodBeginDateTimePicker.Name = "financeLinePeriodBeginDateTimePicker";
            this.financeLinePeriodBeginDateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.financeLinePeriodBeginDateTimePicker.TabIndex = 108;
            // 
            // financeLinePeriodEndDateTimePicker
            // 
            this.financeLinePeriodEndDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contractBindingSource, "FinanceLinePeriodEnd", true));
            this.financeLinePeriodEndDateTimePicker.Location = new System.Drawing.Point(384, 225);
            this.financeLinePeriodEndDateTimePicker.Name = "financeLinePeriodEndDateTimePicker";
            this.financeLinePeriodEndDateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.financeLinePeriodEndDateTimePicker.TabIndex = 110;
            // 
            // financeProportionTextBox
            // 
            this.financeProportionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "FinanceProportion", true));
            this.financeProportionTextBox.Location = new System.Drawing.Point(455, 263);
            this.financeProportionTextBox.Name = "financeProportionTextBox";
            this.financeProportionTextBox.Size = new System.Drawing.Size(152, 20);
            this.financeProportionTextBox.TabIndex = 112;
            // 
            // isCreditCoverRevolvingTextBox
            // 
            this.isCreditCoverRevolvingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "IsCreditCoverRevolving", true));
            this.isCreditCoverRevolvingTextBox.Location = new System.Drawing.Point(153, 55);
            this.isCreditCoverRevolvingTextBox.Name = "isCreditCoverRevolvingTextBox";
            this.isCreditCoverRevolvingTextBox.Size = new System.Drawing.Size(154, 20);
            this.isCreditCoverRevolvingTextBox.TabIndex = 114;
            // 
            // lossThresholdTextBox
            // 
            this.lossThresholdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "LossThreshold", true));
            this.lossThresholdTextBox.Location = new System.Drawing.Point(455, 333);
            this.lossThresholdTextBox.Name = "lossThresholdTextBox";
            this.lossThresholdTextBox.Size = new System.Drawing.Size(152, 20);
            this.lossThresholdTextBox.TabIndex = 116;
            // 
            // orderNumberTextBox
            // 
            this.orderNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "OrderNumber", true));
            this.orderNumberTextBox.Location = new System.Drawing.Point(153, 298);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(154, 20);
            this.orderNumberTextBox.TabIndex = 118;
            // 
            // paymentTermsTextBox
            // 
            this.paymentTermsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "PaymentTerms", true));
            this.paymentTermsTextBox.Location = new System.Drawing.Point(455, 298);
            this.paymentTermsTextBox.Name = "paymentTermsTextBox";
            this.paymentTermsTextBox.Size = new System.Drawing.Size(152, 20);
            this.paymentTermsTextBox.TabIndex = 120;
            // 
            // pUGPeriodTextBox
            // 
            this.pUGPeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "PUGPeriod", true));
            this.pUGPeriodTextBox.Location = new System.Drawing.Point(455, 90);
            this.pUGPeriodTextBox.Name = "pUGPeriodTextBox";
            this.pUGPeriodTextBox.Size = new System.Drawing.Size(152, 20);
            this.pUGPeriodTextBox.TabIndex = 122;
            // 
            // pUGProportionTextBox
            // 
            this.pUGProportionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "PUGProportion", true));
            this.pUGProportionTextBox.Location = new System.Drawing.Point(153, 90);
            this.pUGProportionTextBox.Name = "pUGProportionTextBox";
            this.pUGProportionTextBox.Size = new System.Drawing.Size(154, 20);
            this.pUGProportionTextBox.TabIndex = 124;
            // 
            // reassignGracePeriodTextBox
            // 
            this.reassignGracePeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ReassignGracePeriod", true));
            this.reassignGracePeriodTextBox.Location = new System.Drawing.Point(153, 159);
            this.reassignGracePeriodTextBox.Name = "reassignGracePeriodTextBox";
            this.reassignGracePeriodTextBox.Size = new System.Drawing.Size(154, 20);
            this.reassignGracePeriodTextBox.TabIndex = 126;
            // 
            // gbBasicInfo
            // 
            this.gbBasicInfo.Controls.Add(labelBuyerFactorName);
            this.gbBasicInfo.Controls.Add(this.textBox2);
            this.gbBasicInfo.Controls.Add(labelSellerFactorName);
            this.gbBasicInfo.Controls.Add(this.textBox1);
            this.gbBasicInfo.Controls.Add(labelAssignType);
            this.gbBasicInfo.Controls.Add(this.assignTypeTextBox);
            this.gbBasicInfo.Controls.Add(labelBizType);
            this.gbBasicInfo.Controls.Add(this.bizTypeTextBox);
            this.gbBasicInfo.Controls.Add(labelBuyerFactorNo);
            this.gbBasicInfo.Controls.Add(this.buyerFactorNoTextBox);
            this.gbBasicInfo.Controls.Add(labelBuyerNo);
            this.gbBasicInfo.Controls.Add(this.buyerNoTextBox);
            this.gbBasicInfo.Controls.Add(labelContractNo);
            this.gbBasicInfo.Controls.Add(this.contractNoTextBox);
            this.gbBasicInfo.Controls.Add(labelInvoiceCurrency);
            this.gbBasicInfo.Controls.Add(this.cbInvoiceCurrency);
            this.gbBasicInfo.Controls.Add(labelIsNotice);
            this.gbBasicInfo.Controls.Add(this.isNoticeTextBox);
            this.gbBasicInfo.Controls.Add(labelIsRecoarse);
            this.gbBasicInfo.Controls.Add(this.isRecoarseTextBox);
            this.gbBasicInfo.Controls.Add(labelSellerFactorNo);
            this.gbBasicInfo.Controls.Add(this.sellerFactorNoTextBox);
            this.gbBasicInfo.Controls.Add(labelSellerNo);
            this.gbBasicInfo.Controls.Add(this.sellerNoTextBox);
            this.gbBasicInfo.Location = new System.Drawing.Point(19, 36);
            this.gbBasicInfo.Name = "gbBasicInfo";
            this.gbBasicInfo.Size = new System.Drawing.Size(625, 228);
            this.gbBasicInfo.TabIndex = 94;
            this.gbBasicInfo.TabStop = false;
            this.gbBasicInfo.Text = "基本信息";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "BuyerFactorNo", true));
            this.textBox2.Location = new System.Drawing.Point(451, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 110;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "SellerFactorNo", true));
            this.textBox1.Location = new System.Drawing.Point(451, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 108;
            // 
            // assignTypeTextBox
            // 
            this.assignTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "AssignType", true));
            this.assignTypeTextBox.Location = new System.Drawing.Point(149, 194);
            this.assignTypeTextBox.Name = "assignTypeTextBox";
            this.assignTypeTextBox.Size = new System.Drawing.Size(154, 20);
            this.assignTypeTextBox.TabIndex = 88;
            // 
            // bizTypeTextBox
            // 
            this.bizTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "BizType", true));
            this.bizTypeTextBox.Location = new System.Drawing.Point(451, 106);
            this.bizTypeTextBox.Name = "bizTypeTextBox";
            this.bizTypeTextBox.Size = new System.Drawing.Size(152, 20);
            this.bizTypeTextBox.TabIndex = 90;
            // 
            // buyerFactorNoTextBox
            // 
            this.buyerFactorNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "BuyerFactorNo", true));
            this.buyerFactorNoTextBox.Location = new System.Drawing.Point(149, 106);
            this.buyerFactorNoTextBox.Name = "buyerFactorNoTextBox";
            this.buyerFactorNoTextBox.Size = new System.Drawing.Size(154, 20);
            this.buyerFactorNoTextBox.TabIndex = 92;
            // 
            // buyerNoTextBox
            // 
            this.buyerNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "BuyerNo", true));
            this.buyerNoTextBox.Location = new System.Drawing.Point(149, 77);
            this.buyerNoTextBox.Name = "buyerNoTextBox";
            this.buyerNoTextBox.Size = new System.Drawing.Size(154, 20);
            this.buyerNoTextBox.TabIndex = 94;
            // 
            // contractNoTextBox
            // 
            this.contractNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "ContractNo", true));
            this.contractNoTextBox.Location = new System.Drawing.Point(149, 18);
            this.contractNoTextBox.Name = "contractNoTextBox";
            this.contractNoTextBox.Size = new System.Drawing.Size(154, 20);
            this.contractNoTextBox.TabIndex = 96;
            // 
            // cbInvoiceCurrency
            // 
            this.cbInvoiceCurrency.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "InvoiceCurrency", true));
            this.cbInvoiceCurrency.DisplayMember = "CurrencyFormat";
            this.cbInvoiceCurrency.Location = new System.Drawing.Point(149, 135);
            this.cbInvoiceCurrency.Name = "cbInvoiceCurrency";
            this.cbInvoiceCurrency.Size = new System.Drawing.Size(154, 21);
            this.cbInvoiceCurrency.TabIndex = 98;
            this.cbInvoiceCurrency.ValueMember = "CurrencyCode";
            // 
            // isNoticeTextBox
            // 
            this.isNoticeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "IsNotice", true));
            this.isNoticeTextBox.Location = new System.Drawing.Point(451, 135);
            this.isNoticeTextBox.Name = "isNoticeTextBox";
            this.isNoticeTextBox.Size = new System.Drawing.Size(152, 20);
            this.isNoticeTextBox.TabIndex = 100;
            // 
            // isRecoarseTextBox
            // 
            this.isRecoarseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "IsRecoarse", true));
            this.isRecoarseTextBox.Location = new System.Drawing.Point(149, 165);
            this.isRecoarseTextBox.Name = "isRecoarseTextBox";
            this.isRecoarseTextBox.Size = new System.Drawing.Size(154, 20);
            this.isRecoarseTextBox.TabIndex = 102;
            // 
            // sellerFactorNoTextBox
            // 
            this.sellerFactorNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "SellerFactorNo", true));
            this.sellerFactorNoTextBox.Location = new System.Drawing.Point(149, 48);
            this.sellerFactorNoTextBox.Name = "sellerFactorNoTextBox";
            this.sellerFactorNoTextBox.Size = new System.Drawing.Size(154, 20);
            this.sellerFactorNoTextBox.TabIndex = 104;
            // 
            // sellerNoTextBox
            // 
            this.sellerNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contractBindingSource, "SellerNo", true));
            this.sellerNoTextBox.Location = new System.Drawing.Point(451, 18);
            this.sellerNoTextBox.Name = "sellerNoTextBox";
            this.sellerNoTextBox.Size = new System.Drawing.Size(152, 20);
            this.sellerNoTextBox.TabIndex = 106;
            // 
            // tsContractDetail
            // 
            this.tsContractDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCancel});
            this.tsContractDetail.Location = new System.Drawing.Point(0, 0);
            this.tsContractDetail.Name = "tsContractDetail";
            this.tsContractDetail.Size = new System.Drawing.Size(644, 25);
            this.tsContractDetail.TabIndex = 95;
            this.tsContractDetail.Text = "toolStrip1";
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
            // ContractDetailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(660, 998);
            this.Controls.Add(this.tsContractDetail);
            this.Controls.Add(this.gbBasicInfo);
            this.Controls.Add(this.gbCover);
            this.Controls.Add(this.gbFee);
            this.Controls.Add(this.gbOther);
            this.Name = "ContractDetailUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ContractDetailUI";
            this.Load += new System.EventHandler(this.ContractDetailUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            this.gbOther.ResumeLayout(false);
            this.gbOther.PerformLayout();
            this.gbFee.ResumeLayout(false);
            this.gbFee.PerformLayout();
            this.gbCover.ResumeLayout(false);
            this.gbCover.PerformLayout();
            this.gbBasicInfo.ResumeLayout(false);
            this.gbBasicInfo.PerformLayout();
            this.tsContractDetail.ResumeLayout(false);
            this.tsContractDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
   }
}
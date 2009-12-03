//-----------------------------------------------------------------------
// <copyright file="InvoiceAssignUI.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InvoiceMgr.InvoiceAssign
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceAssignUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private CMBC.EasyFactor.InvoiceMgr.ContractInfo.ContractBasicInfo contractBasicInfoPanel;
        private CMBC.EasyFactor.InvoiceMgr.ContractInfo.ContractOtherInfo contractOtherInfoPanel;
        private System.Windows.Forms.Panel panelAssign;
        private System.Windows.Forms.Panel panelBatchInfo;
        private System.Windows.Forms.GroupBox gbBacthInfo;
        private System.Windows.Forms.Button btnBatchNoSelect;
        private System.Windows.Forms.Button btnBatchNoNew;
        private System.Windows.Forms.TextBox tbBatchNo;
        private System.Windows.Forms.Label lbBatchNo;
        private System.Windows.Forms.Label lbPriceIncoming;
        private System.Windows.Forms.Label lbAssignTotalAmount;
        private System.Windows.Forms.TextBox tbCurrency;
        private System.Windows.Forms.Label lbAssignCurrency;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label lbAssignDate;
        private System.Windows.Forms.TextBox tbTotalAmount;
        private System.Windows.Forms.Label lbHandFeeIncoming;
        private System.Windows.Forms.TextBox tbAssignSize;
        private System.Windows.Forms.Label lbAssignSize;
        private System.Windows.Forms.TextBox tbPriceIncoming;
        private System.Windows.Forms.TextBox tbHandFeeIncoming;

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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelAssign = new System.Windows.Forms.Panel();
            this.panelBatchInfo = new System.Windows.Forms.Panel();
            this.gbBacthInfo = new System.Windows.Forms.GroupBox();
            this.tbHandFeeIncoming = new System.Windows.Forms.TextBox();
            this.lbHandFeeIncoming = new System.Windows.Forms.Label();
            this.tbAssignSize = new System.Windows.Forms.TextBox();
            this.lbAssignSize = new System.Windows.Forms.Label();
            this.tbPriceIncoming = new System.Windows.Forms.TextBox();
            this.tbTotalAmount = new System.Windows.Forms.TextBox();
            this.lbPriceIncoming = new System.Windows.Forms.Label();
            this.lbAssignTotalAmount = new System.Windows.Forms.Label();
            this.tbCurrency = new System.Windows.Forms.TextBox();
            this.lbAssignCurrency = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lbAssignDate = new System.Windows.Forms.Label();
            this.btnBatchNoSelect = new System.Windows.Forms.Button();
            this.btnBatchNoNew = new System.Windows.Forms.Button();
            this.tbBatchNo = new System.Windows.Forms.TextBox();
            this.lbBatchNo = new System.Windows.Forms.Label();
            this.contractOtherInfoPanel = new CMBC.EasyFactor.InvoiceMgr.ContractInfo.ContractOtherInfo();
            this.contractBasicInfoPanel = new CMBC.EasyFactor.InvoiceMgr.ContractInfo.ContractBasicInfo();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelCenter.SuspendLayout();
            this.panelAssign.SuspendLayout();
            this.panelBatchInfo.SuspendLayout();
            this.gbBacthInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.panelAssign);
            this.panelCenter.Controls.Add(this.contractOtherInfoPanel);
            this.panelCenter.Controls.Add(this.contractBasicInfoPanel);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(752, 588);
            this.panelCenter.TabIndex = 1;
            // 
            // panelAssign
            // 
            this.panelAssign.AutoScroll = true;
            this.panelAssign.Controls.Add(this.panelBatchInfo);
            this.panelAssign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAssign.Location = new System.Drawing.Point(0, 119);
            this.panelAssign.Name = "panelAssign";
            this.panelAssign.Size = new System.Drawing.Size(752, 306);
            this.panelAssign.TabIndex = 2;
            this.panelAssign.Visible = false;
            // 
            // panelBatchInfo
            // 
            this.panelBatchInfo.BackColor = System.Drawing.SystemColors.Control;
            this.panelBatchInfo.Controls.Add(this.gbBacthInfo);
            this.panelBatchInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBatchInfo.Location = new System.Drawing.Point(0, 0);
            this.panelBatchInfo.Name = "panelBatchInfo";
            this.panelBatchInfo.Size = new System.Drawing.Size(752, 124);
            this.panelBatchInfo.TabIndex = 0;
            // 
            // gbBacthInfo
            // 
            this.gbBacthInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.gbBacthInfo.Controls.Add(this.tbHandFeeIncoming);
            this.gbBacthInfo.Controls.Add(this.lbHandFeeIncoming);
            this.gbBacthInfo.Controls.Add(this.tbAssignSize);
            this.gbBacthInfo.Controls.Add(this.lbAssignSize);
            this.gbBacthInfo.Controls.Add(this.tbPriceIncoming);
            this.gbBacthInfo.Controls.Add(this.tbTotalAmount);
            this.gbBacthInfo.Controls.Add(this.lbPriceIncoming);
            this.gbBacthInfo.Controls.Add(this.lbAssignTotalAmount);
            this.gbBacthInfo.Controls.Add(this.tbCurrency);
            this.gbBacthInfo.Controls.Add(this.lbAssignCurrency);
            this.gbBacthInfo.Controls.Add(this.tbDate);
            this.gbBacthInfo.Controls.Add(this.lbAssignDate);
            this.gbBacthInfo.Controls.Add(this.btnBatchNoSelect);
            this.gbBacthInfo.Controls.Add(this.btnBatchNoNew);
            this.gbBacthInfo.Controls.Add(this.tbBatchNo);
            this.gbBacthInfo.Controls.Add(this.lbBatchNo);
            this.gbBacthInfo.Location = new System.Drawing.Point(3, 5);
            this.gbBacthInfo.Name = "gbBacthInfo";
            this.gbBacthInfo.Size = new System.Drawing.Size(713, 115);
            this.gbBacthInfo.TabIndex = 0;
            this.gbBacthInfo.TabStop = false;
            this.gbBacthInfo.Text = "批次信息";
            // 
            // tbHandFeeIncoming
            // 
            this.tbHandFeeIncoming.Location = new System.Drawing.Point(275, 81);
            this.tbHandFeeIncoming.Name = "tbHandFeeIncoming";
            this.tbHandFeeIncoming.ReadOnly = true;
            this.tbHandFeeIncoming.Size = new System.Drawing.Size(120, 20);
            this.tbHandFeeIncoming.TabIndex = 15;
            // 
            // lbHandFeeIncoming
            // 
            this.lbHandFeeIncoming.AutoSize = true;
            this.lbHandFeeIncoming.Location = new System.Drawing.Point(198, 85);
            this.lbHandFeeIncoming.Name = "lbHandFeeIncoming";
            this.lbHandFeeIncoming.Size = new System.Drawing.Size(70, 13);
            this.lbHandFeeIncoming.TabIndex = 14;
            this.lbHandFeeIncoming.Text = "处理费收入:";
            // 
            // tbAssignSize
            // 
            this.tbAssignSize.Location = new System.Drawing.Point(72, 81);
            this.tbAssignSize.Name = "tbAssignSize";
            this.tbAssignSize.ReadOnly = true;
            this.tbAssignSize.Size = new System.Drawing.Size(120, 20);
            this.tbAssignSize.TabIndex = 13;
            // 
            // lbAssignSize
            // 
            this.lbAssignSize.AutoSize = true;
            this.lbAssignSize.Location = new System.Drawing.Point(7, 85);
            this.lbAssignSize.Name = "lbAssignSize";
            this.lbAssignSize.Size = new System.Drawing.Size(58, 13);
            this.lbAssignSize.TabIndex = 12;
            this.lbAssignSize.Text = "转让笔数:";
            // 
            // tbPriceIncoming
            // 
            this.tbPriceIncoming.Location = new System.Drawing.Point(275, 49);
            this.tbPriceIncoming.Name = "tbPriceIncoming";
            this.tbPriceIncoming.ReadOnly = true;
            this.tbPriceIncoming.Size = new System.Drawing.Size(120, 20);
            this.tbPriceIncoming.TabIndex = 11;
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount.Location = new System.Drawing.Point(72, 49);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.ReadOnly = true;
            this.tbTotalAmount.Size = new System.Drawing.Size(120, 20);
            this.tbTotalAmount.TabIndex = 10;
            // 
            // lbPriceIncoming
            // 
            this.lbPriceIncoming.AutoSize = true;
            this.lbPriceIncoming.Location = new System.Drawing.Point(198, 52);
            this.lbPriceIncoming.Name = "lbPriceIncoming";
            this.lbPriceIncoming.Size = new System.Drawing.Size(70, 13);
            this.lbPriceIncoming.TabIndex = 9;
            this.lbPriceIncoming.Text = "手续费收入:";
            // 
            // lbAssignTotalAmount
            // 
            this.lbAssignTotalAmount.AutoSize = true;
            this.lbAssignTotalAmount.Location = new System.Drawing.Point(7, 52);
            this.lbAssignTotalAmount.Name = "lbAssignTotalAmount";
            this.lbAssignTotalAmount.Size = new System.Drawing.Size(46, 13);
            this.lbAssignTotalAmount.TabIndex = 8;
            this.lbAssignTotalAmount.Text = "总金额:";
            // 
            // tbCurrency
            // 
            this.tbCurrency.Location = new System.Drawing.Point(592, 20);
            this.tbCurrency.Name = "tbCurrency";
            this.tbCurrency.ReadOnly = true;
            this.tbCurrency.Size = new System.Drawing.Size(115, 20);
            this.tbCurrency.TabIndex = 7;
            // 
            // lbAssignCurrency
            // 
            this.lbAssignCurrency.AutoSize = true;
            this.lbAssignCurrency.Location = new System.Drawing.Point(551, 23);
            this.lbAssignCurrency.Name = "lbAssignCurrency";
            this.lbAssignCurrency.Size = new System.Drawing.Size(34, 13);
            this.lbAssignCurrency.TabIndex = 6;
            this.lbAssignCurrency.Text = "币种:";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(425, 20);
            this.tbDate.Name = "tbDate";
            this.tbDate.ReadOnly = true;
            this.tbDate.Size = new System.Drawing.Size(120, 20);
            this.tbDate.TabIndex = 5;
            // 
            // lbAssignDate
            // 
            this.lbAssignDate.AutoSize = true;
            this.lbAssignDate.Location = new System.Drawing.Point(372, 23);
            this.lbAssignDate.Name = "lbAssignDate";
            this.lbAssignDate.Size = new System.Drawing.Size(46, 13);
            this.lbAssignDate.TabIndex = 4;
            this.lbAssignDate.Text = "转让日:";
            // 
            // btnBatchNoSelect
            // 
            this.btnBatchNoSelect.Location = new System.Drawing.Point(279, 17);
            this.btnBatchNoSelect.Name = "btnBatchNoSelect";
            this.btnBatchNoSelect.Size = new System.Drawing.Size(75, 25);
            this.btnBatchNoSelect.TabIndex = 3;
            this.btnBatchNoSelect.Text = "选择";
            this.btnBatchNoSelect.UseVisualStyleBackColor = true;
            // 
            // btnBatchNoNew
            // 
            this.btnBatchNoNew.Location = new System.Drawing.Point(198, 17);
            this.btnBatchNoNew.Name = "btnBatchNoNew";
            this.btnBatchNoNew.Size = new System.Drawing.Size(75, 25);
            this.btnBatchNoNew.TabIndex = 2;
            this.btnBatchNoNew.Text = "新建";
            this.btnBatchNoNew.UseVisualStyleBackColor = true;
            this.btnBatchNoNew.Click += new System.EventHandler(this.NewBatchNo);
            // 
            // tbBatchNo
            // 
            this.tbBatchNo.Location = new System.Drawing.Point(72, 20);
            this.tbBatchNo.Name = "tbBatchNo";
            this.tbBatchNo.ReadOnly = true;
            this.tbBatchNo.Size = new System.Drawing.Size(120, 20);
            this.tbBatchNo.TabIndex = 1;
            // 
            // lbBatchNo
            // 
            this.lbBatchNo.AutoSize = true;
            this.lbBatchNo.Location = new System.Drawing.Point(7, 23);
            this.lbBatchNo.Name = "lbBatchNo";
            this.lbBatchNo.Size = new System.Drawing.Size(58, 13);
            this.lbBatchNo.TabIndex = 0;
            this.lbBatchNo.Text = "转让批号:";
            // 
            // contractOtherInfoPanel
            // 
            this.contractOtherInfoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contractOtherInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contractOtherInfoPanel.Location = new System.Drawing.Point(0, 425);
            this.contractOtherInfoPanel.Name = "contractOtherInfoPanel";
            this.contractOtherInfoPanel.Size = new System.Drawing.Size(752, 163);
            this.contractOtherInfoPanel.TabIndex = 1;
            // 
            // contractBasicInfoPanel
            // 
            this.contractBasicInfoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contractBasicInfoPanel.Contract = null;
            this.contractBasicInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contractBasicInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.contractBasicInfoPanel.Name = "contractBasicInfoPanel";
            this.contractBasicInfoPanel.Size = new System.Drawing.Size(752, 119);
            this.contractBasicInfoPanel.TabIndex = 0;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Invoice);
            // 
            // InvoiceAssignUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelCenter);
            this.Name = "InvoiceAssignUI";
            this.Size = new System.Drawing.Size(752, 588);
            this.panelCenter.ResumeLayout(false);
            this.panelAssign.ResumeLayout(false);
            this.panelBatchInfo.ResumeLayout(false);
            this.gbBacthInfo.ResumeLayout(false);
            this.gbBacthInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

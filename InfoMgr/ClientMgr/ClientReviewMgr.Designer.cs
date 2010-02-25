//-----------------------------------------------------------------------
// <copyright file="ClientReviewMgr.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ClientReviewMgr
    {
        #region Fields (22)

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientEDICode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestCommissionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestFinancePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestFinanceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestFinanceType2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewStatus;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClientReviews;
        private DevComponents.DotNetBar.LabelX lblClientEDICode;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientEDICode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;

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



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.tbClientEDICode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientEDICode = new DevComponents.DotNetBar.LabelX();
            this.dgvClientReviews = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colClientEDICode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestFinanceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestFinanceType2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestFinancePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestCommissionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreateUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientReviews)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbClientName);
            this.panelQuery.Controls.Add(this.lblClientName);
            this.panelQuery.Controls.Add(this.tbClientEDICode);
            this.panelQuery.Controls.Add(this.lblClientEDICode);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(935, 33);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(529, 7);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 8;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(448, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.Query);
            // 
            // tbClientName
            // 
            // 
            // 
            // 
            this.tbClientName.Border.Class = "TextBoxBorder";
            this.tbClientName.Location = new System.Drawing.Point(236, 3);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 20);
            this.tbClientName.TabIndex = 3;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.Class = "";
            this.lblClientName.Location = new System.Drawing.Point(174, 5);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(56, 16);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "客户名称";
            // 
            // tbClientEDICode
            // 
            // 
            // 
            // 
            this.tbClientEDICode.Border.Class = "TextBoxBorder";
            this.tbClientEDICode.Location = new System.Drawing.Point(68, 3);
            this.tbClientEDICode.Name = "tbClientEDICode";
            this.tbClientEDICode.Size = new System.Drawing.Size(100, 20);
            this.tbClientEDICode.TabIndex = 1;
            // 
            // lblClientEDICode
            // 
            this.lblClientEDICode.AutoSize = true;
            // 
            // 
            // 
            this.lblClientEDICode.BackgroundStyle.Class = "";
            this.lblClientEDICode.Location = new System.Drawing.Point(6, 5);
            this.lblClientEDICode.Name = "lblClientEDICode";
            this.lblClientEDICode.Size = new System.Drawing.Size(56, 16);
            this.lblClientEDICode.TabIndex = 0;
            this.lblClientEDICode.Text = "保理代码";
            // 
            // dgvClientReviews
            // 
            this.dgvClientReviews.AllowUserToAddRows = false;
            this.dgvClientReviews.AllowUserToDeleteRows = false;
            this.dgvClientReviews.AllowUserToOrderColumns = true;
            this.dgvClientReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientReviews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClientEDICode,
            this.colClientName,
            this.colReviewNo,
            this.colRequestCurrency,
            this.colRequestAmount,
            this.colRequestFinanceType,
            this.colRequestFinanceType2,
            this.colRequestFinancePeriod,
            this.colRequestCommissionRate,
            this.colReviewStatus,
            this.colReviewDate,
            this.colCreateUserName,
            this.colComment});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientReviews.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClientReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientReviews.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvClientReviews.Location = new System.Drawing.Point(0, 33);
            this.dgvClientReviews.MultiSelect = false;
            this.dgvClientReviews.Name = "dgvClientReviews";
            this.dgvClientReviews.ReadOnly = true;
            this.dgvClientReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvClientReviews.Size = new System.Drawing.Size(935, 314);
            this.dgvClientReviews.TabIndex = 1;
            this.dgvClientReviews.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvClientReviews.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvClientCreditLines_RowPostPaint);
            // 
            // colClientEDICode
            // 
            this.colClientEDICode.DataPropertyName = "ClientEDICode";
            this.colClientEDICode.HeaderText = "保理代码";
            this.colClientEDICode.Name = "colClientEDICode";
            this.colClientEDICode.ReadOnly = true;
            // 
            // colClientName
            // 
            this.colClientName.DataPropertyName = "Client";
            this.colClientName.HeaderText = "客户名称";
            this.colClientName.Name = "colClientName";
            this.colClientName.ReadOnly = true;
            // 
            // colReviewNo
            // 
            this.colReviewNo.DataPropertyName = "ReviewNo";
            this.colReviewNo.HeaderText = "协查意见书编号";
            this.colReviewNo.Name = "colReviewNo";
            this.colReviewNo.ReadOnly = true;
            // 
            // colRequestCurrency
            // 
            this.colRequestCurrency.DataPropertyName = "RequestCurrency";
            this.colRequestCurrency.HeaderText = "授信币种";
            this.colRequestCurrency.Name = "colRequestCurrency";
            this.colRequestCurrency.ReadOnly = true;
            // 
            // colRequestAmount
            // 
            this.colRequestAmount.DataPropertyName = "RequestAmount";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colRequestAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRequestAmount.HeaderText = "授信金额";
            this.colRequestAmount.Name = "colRequestAmount";
            this.colRequestAmount.ReadOnly = true;
            // 
            // colRequestFinanceType
            // 
            this.colRequestFinanceType.DataPropertyName = "RequestFinanceType";
            this.colRequestFinanceType.HeaderText = "出账方式";
            this.colRequestFinanceType.Name = "colRequestFinanceType";
            this.colRequestFinanceType.ReadOnly = true;
            // 
            // colRequestFinanceType2
            // 
            this.colRequestFinanceType2.DataPropertyName = "RequestFinanceType2";
            this.colRequestFinanceType2.HeaderText = "融资管理";
            this.colRequestFinanceType2.Name = "colRequestFinanceType2";
            this.colRequestFinanceType2.ReadOnly = true;
            // 
            // colRequestFinancePeriod
            // 
            this.colRequestFinancePeriod.DataPropertyName = "RequestFinancePeriod";
            this.colRequestFinancePeriod.HeaderText = "融资期限(月)";
            this.colRequestFinancePeriod.Name = "colRequestFinancePeriod";
            this.colRequestFinancePeriod.ReadOnly = true;
            // 
            // colRequestCommissionRate
            // 
            this.colRequestCommissionRate.DataPropertyName = "RequestCommissionRate";
            dataGridViewCellStyle3.Format = "p";
            this.colRequestCommissionRate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colRequestCommissionRate.HeaderText = "手续费率";
            this.colRequestCommissionRate.Name = "colRequestCommissionRate";
            this.colRequestCommissionRate.ReadOnly = true;
            // 
            // colReviewStatus
            // 
            this.colReviewStatus.DataPropertyName = "ReviewStatus";
            this.colReviewStatus.HeaderText = "状态";
            this.colReviewStatus.Name = "colReviewStatus";
            this.colReviewStatus.ReadOnly = true;
            // 
            // colReviewDate
            // 
            this.colReviewDate.DataPropertyName = "ReviewDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.colReviewDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.colReviewDate.HeaderText = "签发日期";
            this.colReviewDate.Name = "colReviewDate";
            this.colReviewDate.ReadOnly = true;
            // 
            // colCreateUserName
            // 
            this.colCreateUserName.DataPropertyName = "CreateUserName";
            this.colCreateUserName.HeaderText = "经办人";
            this.colCreateUserName.Name = "colCreateUserName";
            this.colCreateUserName.ReadOnly = true;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "Comment";
            this.colComment.HeaderText = "备注";
            this.colComment.Name = "colComment";
            this.colComment.ReadOnly = true;
            // 
            // ClientReviewMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvClientReviews);
            this.Controls.Add(this.panelQuery);
            this.Name = "ClientReviewMgr";
            this.Size = new System.Drawing.Size(935, 347);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientReviews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}

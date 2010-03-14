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
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClientReviews;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientReviewNo;
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
            this.components = new System.ComponentModel.Container();
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
            this.tbClientReviewNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientReviewNo = new DevComponents.DotNetBar.LabelX();
            this.dgvClientReviews = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmuClientReviewMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemClientReviewDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemClientReviewDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.导出选定协查意见ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colClientEDICode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReviewNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsNotice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsRecoarse = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cmuClientReviewMgr.SuspendLayout();
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
            this.panelQuery.Controls.Add(this.tbClientReviewNo);
            this.panelQuery.Controls.Add(this.lblClientReviewNo);
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
            this.tbClientName.Location = new System.Drawing.Point(264, 3);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(152, 20);
            this.tbClientName.TabIndex = 3;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.Class = "";
            this.lblClientName.Location = new System.Drawing.Point(202, 5);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(56, 16);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "客户名称";
            // 
            // tbClientReviewNo
            // 
            // 
            // 
            // 
            this.tbClientReviewNo.Border.Class = "TextBoxBorder";
            this.tbClientReviewNo.Location = new System.Drawing.Point(96, 3);
            this.tbClientReviewNo.Name = "tbClientReviewNo";
            this.tbClientReviewNo.Size = new System.Drawing.Size(100, 20);
            this.tbClientReviewNo.TabIndex = 1;
            // 
            // lblClientReviewNo
            // 
            this.lblClientReviewNo.AutoSize = true;
            // 
            // 
            // 
            this.lblClientReviewNo.BackgroundStyle.Class = "";
            this.lblClientReviewNo.Location = new System.Drawing.Point(6, 5);
            this.lblClientReviewNo.Name = "lblClientReviewNo";
            this.lblClientReviewNo.Size = new System.Drawing.Size(93, 16);
            this.lblClientReviewNo.TabIndex = 0;
            this.lblClientReviewNo.Text = "协查意见书编号";
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
            this.colTransactionType,
            this.colIsNotice,
            this.colIsRecoarse,
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
            this.dgvClientReviews.ContextMenuStrip = this.cmuClientReviewMgr;
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
            this.dgvClientReviews.Name = "dgvClientReviews";
            this.dgvClientReviews.ReadOnly = true;
            this.dgvClientReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvClientReviews.Size = new System.Drawing.Size(935, 314);
            this.dgvClientReviews.TabIndex = 1;
            this.dgvClientReviews.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvClientReviews.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvClientCreditLines_RowPostPaint);
            this.dgvClientReviews.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClientReviews_CellFormatting);
            // 
            // cmuClientReviewMgr
            // 
            this.cmuClientReviewMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemClientReviewDetail,
            this.toolStripSeparator,
            this.menuItemClientReviewDelete,
            this.toolStripSeparator1,
            this.导出选定协查意见ToolStripMenuItem});
            this.cmuClientReviewMgr.Name = "contextMenuClientMgr";
            this.cmuClientReviewMgr.Size = new System.Drawing.Size(171, 82);
            // 
            // menuItemClientReviewDetail
            // 
            this.menuItemClientReviewDetail.Name = "menuItemClientReviewDetail";
            this.menuItemClientReviewDetail.Size = new System.Drawing.Size(170, 22);
            this.menuItemClientReviewDetail.Text = "详细信息(&M)";
            this.menuItemClientReviewDetail.Click += new System.EventHandler(this.DetailClientReview);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(167, 6);
            // 
            // menuItemClientReviewDelete
            // 
            this.menuItemClientReviewDelete.Name = "menuItemClientReviewDelete";
            this.menuItemClientReviewDelete.Size = new System.Drawing.Size(170, 22);
            this.menuItemClientReviewDelete.Text = "删除协查意见(&D)";
            this.menuItemClientReviewDelete.Click += new System.EventHandler(this.DeleteClientReview);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // 导出选定协查意见ToolStripMenuItem
            // 
            this.导出选定协查意见ToolStripMenuItem.Name = "导出选定协查意见ToolStripMenuItem";
            this.导出选定协查意见ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.导出选定协查意见ToolStripMenuItem.Text = "导出选定协查意见";
            this.导出选定协查意见ToolStripMenuItem.Click += new System.EventHandler(this.ExportClientReviews);
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
            // colTransactionType
            // 
            this.colTransactionType.DataPropertyName = "TransactionType";
            this.colTransactionType.HeaderText = "业务类别";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.ReadOnly = true;
            // 
            // colIsNotice
            // 
            this.colIsNotice.DataPropertyName = "IsNotice";
            this.colIsNotice.HeaderText = "明/暗保理";
            this.colIsNotice.Name = "colIsNotice";
            this.colIsNotice.ReadOnly = true;
            // 
            // colIsRecoarse
            // 
            this.colIsRecoarse.DataPropertyName = "IsRecoarse";
            this.colIsRecoarse.HeaderText = "是否有追索权";
            this.colIsRecoarse.Name = "colIsRecoarse";
            this.colIsRecoarse.ReadOnly = true;
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
            dataGridViewCellStyle3.Format = "p3";
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
            this.cmuClientReviewMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblClientReviewNo;
        private System.Windows.Forms.ContextMenuStrip cmuClientReviewMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientReviewDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemClientReviewDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 导出选定协查意见ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientEDICode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsRecoarse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestFinanceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestFinanceType2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestFinancePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestCommissionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReviewDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreateUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
    }
}

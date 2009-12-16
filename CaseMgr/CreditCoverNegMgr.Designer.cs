namespace CMBC.EasyFactor.CaseMgr
{
    partial class CreditCoverNegMgr
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCreditCoverQuery = new DevComponents.DotNetBar.PanelEx();
            this.dgvCreditCovers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblSellerFactorCode = new DevComponents.DotNetBar.LabelX();
            this.tbSellerFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbBuyerFactorCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblBuyerFactorCode = new DevComponents.DotNetBar.LabelX();
            this.btnCreditCoverQuery = new DevComponents.DotNetBar.ButtonX();
            this.llbCount = new DevComponents.DotNetBar.LabelX();
            this.cmuCreditCoverMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCreditCoverSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreditCoverDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCreditCoverNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreditCoverUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreditCoverDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCreditCoverQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCovers)).BeginInit();
            this.cmuCreditCoverMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreditCoverQuery
            // 
            this.panelCreditCoverQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelCreditCoverQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelCreditCoverQuery.Controls.Add(this.llbCount);
            this.panelCreditCoverQuery.Controls.Add(this.btnCreditCoverQuery);
            this.panelCreditCoverQuery.Controls.Add(this.tbBuyerFactorCode);
            this.panelCreditCoverQuery.Controls.Add(this.lblBuyerFactorCode);
            this.panelCreditCoverQuery.Controls.Add(this.tbSellerFactorCode);
            this.panelCreditCoverQuery.Controls.Add(this.lblSellerFactorCode);
            this.panelCreditCoverQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCreditCoverQuery.Location = new System.Drawing.Point(0, 0);
            this.panelCreditCoverQuery.Name = "panelCreditCoverQuery";
            this.panelCreditCoverQuery.Size = new System.Drawing.Size(549, 63);
            this.panelCreditCoverQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelCreditCoverQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelCreditCoverQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelCreditCoverQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelCreditCoverQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelCreditCoverQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelCreditCoverQuery.Style.GradientAngle = 90;
            this.panelCreditCoverQuery.TabIndex = 0;
            // 
            // dgvCreditCovers
            // 
            this.dgvCreditCovers.AllowUserToAddRows = false;
            this.dgvCreditCovers.AllowUserToDeleteRows = false;
            this.dgvCreditCovers.AllowUserToOrderColumns = true;
            this.dgvCreditCovers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreditCovers.ContextMenuStrip = this.cmuCreditCoverMgr;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditCovers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCreditCovers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCreditCovers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCreditCovers.Location = new System.Drawing.Point(0, 63);
            this.dgvCreditCovers.Name = "dgvCreditCovers";
            this.dgvCreditCovers.ReadOnly = true;
            this.dgvCreditCovers.Size = new System.Drawing.Size(549, 282);
            this.dgvCreditCovers.TabIndex = 1;
            // 
            // lblSellerFactorCode
            // 
            // 
            // 
            // 
            this.lblSellerFactorCode.BackgroundStyle.Class = "";
            this.lblSellerFactorCode.Location = new System.Drawing.Point(3, 3);
            this.lblSellerFactorCode.Name = "lblSellerFactorCode";
            this.lblSellerFactorCode.Size = new System.Drawing.Size(96, 23);
            this.lblSellerFactorCode.TabIndex = 0;
            this.lblSellerFactorCode.Text = "卖方保理商代码";
            // 
            // tbSellerFactorCode
            // 
            // 
            // 
            // 
            this.tbSellerFactorCode.Border.Class = "TextBoxBorder";
            this.tbSellerFactorCode.Location = new System.Drawing.Point(95, 5);
            this.tbSellerFactorCode.Name = "tbSellerFactorCode";
            this.tbSellerFactorCode.Size = new System.Drawing.Size(100, 20);
            this.tbSellerFactorCode.TabIndex = 1;
            // 
            // tbBuyerFactorCode
            // 
            // 
            // 
            // 
            this.tbBuyerFactorCode.Border.Class = "TextBoxBorder";
            this.tbBuyerFactorCode.Location = new System.Drawing.Point(95, 33);
            this.tbBuyerFactorCode.Name = "tbBuyerFactorCode";
            this.tbBuyerFactorCode.Size = new System.Drawing.Size(100, 20);
            this.tbBuyerFactorCode.TabIndex = 3;
            // 
            // lblBuyerFactorCode
            // 
            // 
            // 
            // 
            this.lblBuyerFactorCode.BackgroundStyle.Class = "";
            this.lblBuyerFactorCode.Location = new System.Drawing.Point(3, 31);
            this.lblBuyerFactorCode.Name = "lblBuyerFactorCode";
            this.lblBuyerFactorCode.Size = new System.Drawing.Size(96, 23);
            this.lblBuyerFactorCode.TabIndex = 2;
            this.lblBuyerFactorCode.Text = "买方保理商代码";
            // 
            // btnCreditCoverQuery
            // 
            this.btnCreditCoverQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCreditCoverQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCreditCoverQuery.Location = new System.Drawing.Point(216, 5);
            this.btnCreditCoverQuery.Name = "btnCreditCoverQuery";
            this.btnCreditCoverQuery.Size = new System.Drawing.Size(75, 48);
            this.btnCreditCoverQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCreditCoverQuery.TabIndex = 4;
            this.btnCreditCoverQuery.Text = "查询";
            // 
            // llbCount
            // 
            this.llbCount.AutoSize = true;
            // 
            // 
            // 
            this.llbCount.BackgroundStyle.Class = "";
            this.llbCount.Location = new System.Drawing.Point(297, 30);
            this.llbCount.Name = "llbCount";
            this.llbCount.Size = new System.Drawing.Size(75, 23);
            this.llbCount.TabIndex = 5;
            // 
            // cmuCreditCoverMgr
            // 
            this.cmuCreditCoverMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCreditCoverSelect,
            this.menuItemCreditCoverDetail,
            this.toolStripSeparator,
            this.menuItemCreditCoverNew,
            this.menuItemCreditCoverUpdate,
            this.menuItemCreditCoverDelete});
            this.cmuCreditCoverMgr.Name = "cmuContractMgr";
            this.cmuCreditCoverMgr.Size = new System.Drawing.Size(147, 120);
            // 
            // menuItemCreditCoverSelect
            // 
            this.menuItemCreditCoverSelect.Name = "menuItemCreditCoverSelect";
            this.menuItemCreditCoverSelect.Size = new System.Drawing.Size(146, 22);
            this.menuItemCreditCoverSelect.Text = "选定额度申请";
            // 
            // menuItemCreditCoverDetail
            // 
            this.menuItemCreditCoverDetail.Name = "menuItemCreditCoverDetail";
            this.menuItemCreditCoverDetail.Size = new System.Drawing.Size(146, 22);
            this.menuItemCreditCoverDetail.Text = "详细信息";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // menuItemCreditCoverNew
            // 
            this.menuItemCreditCoverNew.Name = "menuItemCreditCoverNew";
            this.menuItemCreditCoverNew.Size = new System.Drawing.Size(146, 22);
            this.menuItemCreditCoverNew.Text = "新建额度申请";
            // 
            // menuItemCreditCoverUpdate
            // 
            this.menuItemCreditCoverUpdate.Name = "menuItemCreditCoverUpdate";
            this.menuItemCreditCoverUpdate.Size = new System.Drawing.Size(146, 22);
            this.menuItemCreditCoverUpdate.Text = "更新额度申请";
            // 
            // menuItemCreditCoverDelete
            // 
            this.menuItemCreditCoverDelete.Name = "menuItemCreditCoverDelete";
            this.menuItemCreditCoverDelete.Size = new System.Drawing.Size(146, 22);
            this.menuItemCreditCoverDelete.Text = "删除额度申请";
            // 
            // CreditCoverMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCreditCovers);
            this.Controls.Add(this.panelCreditCoverQuery);
            this.Name = "CreditCoverMgr";
            this.Size = new System.Drawing.Size(549, 345);
            this.panelCreditCoverQuery.ResumeLayout(false);
            this.panelCreditCoverQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditCovers)).EndInit();
            this.cmuCreditCoverMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelCreditCoverQuery;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCreditCovers;
        private DevComponents.DotNetBar.LabelX llbCount;
        private DevComponents.DotNetBar.ButtonX btnCreditCoverQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbBuyerFactorCode;
        private DevComponents.DotNetBar.LabelX lblBuyerFactorCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbSellerFactorCode;
        private DevComponents.DotNetBar.LabelX lblSellerFactorCode;
        private System.Windows.Forms.ContextMenuStrip cmuCreditCoverMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditCoverDelete;
    }
}

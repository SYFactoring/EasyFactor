//-----------------------------------------------------------------------
// <copyright file="ClientCreditLineMgr.Designer.cs" company="CISL@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.ClientMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ClientCreditLineMgr
    {
		#region?Fields?(19)?

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbClientGroupType;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClientCreditLines;
        private DevComponents.DotNetBar.LabelX lblClientEDICode;
        private DevComponents.DotNetBar.LabelX lblClientName;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientEDICode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbClientName;

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

            base.Dispose(disposing);
        }

		#endregion?Methods?



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.cbClientGroupType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbClientName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientName = new DevComponents.DotNetBar.LabelX();
            this.tbClientEDICode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblClientEDICode = new DevComponents.DotNetBar.LabelX();
            this.dgvClientCreditLines = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmuCreditLineMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemCreditLineSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCreditLineDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.colClientEDICode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientNameCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientNameEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLineType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLineCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLineOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreditLineStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCreditLines)).BeginInit();
            this.cmuCreditLineMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.cbClientGroupType);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbClientName);
            this.panelQuery.Controls.Add(this.lblClientName);
            this.panelQuery.Controls.Add(this.tbClientEDICode);
            this.panelQuery.Controls.Add(this.lblClientEDICode);
            this.panelQuery.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(935, 30);
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
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Location = new System.Drawing.Point(529, 6);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 0);
            this.lblCount.TabIndex = 8;
            // 
            // cbClientGroupType
            // 
            this.cbClientGroupType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbClientGroupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClientGroupType.FocusHighlightEnabled = true;
            this.cbClientGroupType.ItemHeight = 14;
            this.cbClientGroupType.Items.AddRange(new object[] {
            "全部",
            "客户",
            "集团"});
            this.cbClientGroupType.Location = new System.Drawing.Point(342, 3);
            this.cbClientGroupType.Name = "cbClientGroupType";
            this.cbClientGroupType.Size = new System.Drawing.Size(100, 20);
            this.cbClientGroupType.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.cbClientGroupType.TabIndex = 7;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(448, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 21);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
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
            this.tbClientName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbClientName.Location = new System.Drawing.Point(236, 3);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 21);
            this.tbClientName.TabIndex = 3;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            // 
            // 
            // 
            this.lblClientName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClientName.Location = new System.Drawing.Point(174, 5);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(56, 18);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "客户名称";
            // 
            // tbClientEDICode
            // 
            // 
            // 
            // 
            this.tbClientEDICode.Border.Class = "TextBoxBorder";
            this.tbClientEDICode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbClientEDICode.Location = new System.Drawing.Point(68, 3);
            this.tbClientEDICode.Name = "tbClientEDICode";
            this.tbClientEDICode.Size = new System.Drawing.Size(100, 21);
            this.tbClientEDICode.TabIndex = 1;
            // 
            // lblClientEDICode
            // 
            this.lblClientEDICode.AutoSize = true;
            // 
            // 
            // 
            this.lblClientEDICode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblClientEDICode.Location = new System.Drawing.Point(6, 5);
            this.lblClientEDICode.Name = "lblClientEDICode";
            this.lblClientEDICode.Size = new System.Drawing.Size(56, 18);
            this.lblClientEDICode.TabIndex = 0;
            this.lblClientEDICode.Text = "保理代码";
            // 
            // dgvClientCreditLines
            // 
            this.dgvClientCreditLines.AllowUserToAddRows = false;
            this.dgvClientCreditLines.AllowUserToDeleteRows = false;
            this.dgvClientCreditLines.AllowUserToOrderColumns = true;
            this.dgvClientCreditLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientCreditLines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientCreditLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientCreditLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colClientEDICode,
            this.colClientNameCN,
            this.colClientNameEN,
            this.colCreditLineType,
            this.colCreditLineCurrency,
            this.colCreditLine,
            this.colCreditLineOutstanding,
            this.colPeriodBegin,
            this.colPeriodEnd,
            this.colCreditLineStatus});
            this.dgvClientCreditLines.ContextMenuStrip = this.cmuCreditLineMgr;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientCreditLines.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClientCreditLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientCreditLines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvClientCreditLines.Location = new System.Drawing.Point(0, 30);
            this.dgvClientCreditLines.Name = "dgvClientCreditLines";
            this.dgvClientCreditLines.ReadOnly = true;
            this.dgvClientCreditLines.RowTemplate.Height = 23;
            this.dgvClientCreditLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvClientCreditLines.Size = new System.Drawing.Size(935, 290);
            this.dgvClientCreditLines.TabIndex = 1;
            this.dgvClientCreditLines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvClientCreditLines.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvClientCreditLinesDataBindingComplete);
            this.dgvClientCreditLines.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvClientCreditLinesRowPostPaint);
            // 
            // cmuCreditLineMgr
            // 
            this.cmuCreditLineMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCreditLineSelect,
            this.menuItemCreditLineDetail});
            this.cmuCreditLineMgr.Name = "cmuContractMgr";
            this.cmuCreditLineMgr.Size = new System.Drawing.Size(149, 48);
            // 
            // menuItemCreditLineSelect
            // 
            this.menuItemCreditLineSelect.Name = "menuItemCreditLineSelect";
            this.menuItemCreditLineSelect.Size = new System.Drawing.Size(148, 22);
            this.menuItemCreditLineSelect.Text = "选定额度申请";
            this.menuItemCreditLineSelect.Click += new System.EventHandler(this.SelectClientCreditLine);
            // 
            // menuItemCreditLineDetail
            // 
            this.menuItemCreditLineDetail.Name = "menuItemCreditLineDetail";
            this.menuItemCreditLineDetail.Size = new System.Drawing.Size(148, 22);
            this.menuItemCreditLineDetail.Text = "详细信息";
            this.menuItemCreditLineDetail.Click += new System.EventHandler(this.DetailClientCreditLine);
            // 
            // colClientEDICode
            // 
            this.colClientEDICode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colClientEDICode.DataPropertyName = "ClientEDICode";
            this.colClientEDICode.Frozen = true;
            this.colClientEDICode.HeaderText = "保理代码";
            this.colClientEDICode.Name = "colClientEDICode";
            this.colClientEDICode.ReadOnly = true;
            this.colClientEDICode.Width = 99;
            // 
            // colClientNameCN
            // 
            this.colClientNameCN.DataPropertyName = "ClientNameCN";
            this.colClientNameCN.HeaderText = "客户名称（中）";
            this.colClientNameCN.Name = "colClientNameCN";
            this.colClientNameCN.ReadOnly = true;
            // 
            // colClientNameEN
            // 
            this.colClientNameEN.DataPropertyName = "ClientNameEN";
            this.colClientNameEN.HeaderText = "客户名称（英）";
            this.colClientNameEN.Name = "colClientNameEN";
            this.colClientNameEN.ReadOnly = true;
            // 
            // colCreditLineType
            // 
            this.colCreditLineType.DataPropertyName = "CreditLineType";
            this.colCreditLineType.HeaderText = "额度类型";
            this.colCreditLineType.Name = "colCreditLineType";
            this.colCreditLineType.ReadOnly = true;
            // 
            // colCreditLineCurrency
            // 
            this.colCreditLineCurrency.DataPropertyName = "CreditLineCurrency";
            this.colCreditLineCurrency.HeaderText = "额度币种";
            this.colCreditLineCurrency.Name = "colCreditLineCurrency";
            this.colCreditLineCurrency.ReadOnly = true;
            // 
            // colCreditLine
            // 
            this.colCreditLine.DataPropertyName = "CreditLine";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.colCreditLine.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCreditLine.HeaderText = "额度上限";
            this.colCreditLine.Name = "colCreditLine";
            this.colCreditLine.ReadOnly = true;
            // 
            // colCreditLineOutstanding
            // 
            this.colCreditLineOutstanding.DataPropertyName = "CreditLineOutstanding";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.colCreditLineOutstanding.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCreditLineOutstanding.HeaderText = "额度余额";
            this.colCreditLineOutstanding.Name = "colCreditLineOutstanding";
            this.colCreditLineOutstanding.ReadOnly = true;
            // 
            // colPeriodBegin
            // 
            this.colPeriodBegin.DataPropertyName = "PeriodBegin";
            this.colPeriodBegin.HeaderText = "有效期（始）";
            this.colPeriodBegin.Name = "colPeriodBegin";
            this.colPeriodBegin.ReadOnly = true;
            // 
            // colPeriodEnd
            // 
            this.colPeriodEnd.DataPropertyName = "PeriodEnd";
            this.colPeriodEnd.HeaderText = "有效期（终）";
            this.colPeriodEnd.Name = "colPeriodEnd";
            this.colPeriodEnd.ReadOnly = true;
            // 
            // colCreditLineStatus
            // 
            this.colCreditLineStatus.DataPropertyName = "CreditLineStatus";
            this.colCreditLineStatus.HeaderText = "额度状态";
            this.colCreditLineStatus.Name = "colCreditLineStatus";
            this.colCreditLineStatus.ReadOnly = true;
            // 
            // ClientCreditLineMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvClientCreditLines);
            this.Controls.Add(this.panelQuery);
            this.Name = "ClientCreditLineMgr";
            this.Size = new System.Drawing.Size(935, 320);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientCreditLines)).EndInit();
            this.cmuCreditLineMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmuCreditLineMgr;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditLineSelect;
        private System.Windows.Forms.ToolStripMenuItem menuItemCreditLineDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientEDICode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientNameCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientNameEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreditLineStatus;
    }
}

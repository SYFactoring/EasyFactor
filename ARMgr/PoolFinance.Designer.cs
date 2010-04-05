namespace CMBC.EasyFactor.ARMgr
{
    partial class PoolFinance
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
            DevComponents.DotNetBar.LabelX lblLoanNo;
            DevComponents.DotNetBar.LabelX lblFinanceLineBalance;
            DevComponents.DotNetBar.LabelX lblTotalInterest;
            DevComponents.DotNetBar.LabelX financeTypeLabel;
            DevComponents.DotNetBar.LabelX costRateLabel;
            DevComponents.DotNetBar.LabelX factorCodeLabel;
            DevComponents.DotNetBar.LabelX financeRateLabel;
            DevComponents.DotNetBar.LabelX financePeriodBeginLabel;
            DevComponents.DotNetBar.LabelX financeAmountLabel;
            DevComponents.DotNetBar.LabelX financeBatchNoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoolFinance));
            this.dgvClients = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.poolBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelFinanceBatch = new DevComponents.DotNetBar.PanelEx();
            this.tbLoanNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnFinanceBatchImport = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchExport = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbFinanceLineBalance = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbTotalInterest = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnFinanceBatchNew = new DevComponents.DotNetBar.ButtonX();
            this.btnFactorSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.financeTypeComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.costRateTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.factorCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financePeriodEndDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financePeriodBeginDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financeAmountTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.batchCurrencyComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.financeBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.colCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblLoanNo = new DevComponents.DotNetBar.LabelX();
            lblFinanceLineBalance = new DevComponents.DotNetBar.LabelX();
            lblTotalInterest = new DevComponents.DotNetBar.LabelX();
            financeTypeLabel = new DevComponents.DotNetBar.LabelX();
            costRateLabel = new DevComponents.DotNetBar.LabelX();
            factorCodeLabel = new DevComponents.DotNetBar.LabelX();
            financeRateLabel = new DevComponents.DotNetBar.LabelX();
            financePeriodBeginLabel = new DevComponents.DotNetBar.LabelX();
            financeAmountLabel = new DevComponents.DotNetBar.LabelX();
            financeBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolBindingNavigator)).BeginInit();
            this.poolBindingNavigator.SuspendLayout();
            this.panelFinanceBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodEndDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoanNo
            // 
            lblLoanNo.AutoSize = true;
            // 
            // 
            // 
            lblLoanNo.BackgroundStyle.Class = "";
            lblLoanNo.Location = new System.Drawing.Point(195, 5);
            lblLoanNo.Name = "lblLoanNo";
            lblLoanNo.Size = new System.Drawing.Size(59, 16);
            lblLoanNo.TabIndex = 2;
            lblLoanNo.Text = "放款编号:";
            // 
            // lblFinanceLineBalance
            // 
            lblFinanceLineBalance.AutoSize = true;
            // 
            // 
            // 
            lblFinanceLineBalance.BackgroundStyle.Class = "";
            lblFinanceLineBalance.Location = new System.Drawing.Point(945, 5);
            lblFinanceLineBalance.Name = "lblFinanceLineBalance";
            lblFinanceLineBalance.Size = new System.Drawing.Size(81, 16);
            lblFinanceLineBalance.TabIndex = 25;
            lblFinanceLineBalance.Text = "本次融资差额";
            // 
            // lblTotalInterest
            // 
            lblTotalInterest.AutoSize = true;
            // 
            // 
            // 
            lblTotalInterest.BackgroundStyle.Class = "";
            lblTotalInterest.Location = new System.Drawing.Point(920, 26);
            lblTotalInterest.Name = "lblTotalInterest";
            lblTotalInterest.Size = new System.Drawing.Size(106, 16);
            lblTotalInterest.TabIndex = 23;
            lblTotalInterest.Text = "本次应收利息总额";
            // 
            // financeTypeLabel
            // 
            financeTypeLabel.AutoSize = true;
            // 
            // 
            // 
            financeTypeLabel.BackgroundStyle.Class = "";
            financeTypeLabel.Location = new System.Drawing.Point(375, 5);
            financeTypeLabel.Name = "financeTypeLabel";
            financeTypeLabel.Size = new System.Drawing.Size(59, 16);
            financeTypeLabel.TabIndex = 4;
            financeTypeLabel.Text = "出账方式:";
            // 
            // costRateLabel
            // 
            costRateLabel.AutoSize = true;
            // 
            // 
            // 
            costRateLabel.BackgroundStyle.Class = "";
            costRateLabel.Location = new System.Drawing.Point(195, 27);
            costRateLabel.Name = "costRateLabel";
            costRateLabel.Size = new System.Drawing.Size(59, 16);
            costRateLabel.TabIndex = 8;
            costRateLabel.Text = "成本利率:";
            // 
            // factorCodeLabel
            // 
            factorCodeLabel.AutoSize = true;
            // 
            // 
            // 
            factorCodeLabel.BackgroundStyle.Class = "";
            factorCodeLabel.Location = new System.Drawing.Point(387, 48);
            factorCodeLabel.Name = "factorCodeLabel";
            factorCodeLabel.Size = new System.Drawing.Size(47, 16);
            factorCodeLabel.TabIndex = 16;
            factorCodeLabel.Text = "代付行:";
            // 
            // financeRateLabel
            // 
            financeRateLabel.AutoSize = true;
            // 
            // 
            // 
            financeRateLabel.BackgroundStyle.Class = "";
            financeRateLabel.Location = new System.Drawing.Point(15, 25);
            financeRateLabel.Name = "financeRateLabel";
            financeRateLabel.Size = new System.Drawing.Size(59, 16);
            financeRateLabel.TabIndex = 6;
            financeRateLabel.Text = "融资利率:";
            // 
            // financePeriodBeginLabel
            // 
            financePeriodBeginLabel.AutoSize = true;
            // 
            // 
            // 
            financePeriodBeginLabel.BackgroundStyle.Class = "";
            financePeriodBeginLabel.Location = new System.Drawing.Point(375, 26);
            financePeriodBeginLabel.Name = "financePeriodBeginLabel";
            financePeriodBeginLabel.Size = new System.Drawing.Size(59, 16);
            financePeriodBeginLabel.TabIndex = 10;
            financePeriodBeginLabel.Text = "融资期限:";
            // 
            // financeAmountLabel
            // 
            financeAmountLabel.AutoSize = true;
            // 
            // 
            // 
            financeAmountLabel.BackgroundStyle.Class = "";
            financeAmountLabel.Location = new System.Drawing.Point(15, 45);
            financeAmountLabel.Name = "financeAmountLabel";
            financeAmountLabel.Size = new System.Drawing.Size(59, 16);
            financeAmountLabel.TabIndex = 13;
            financeAmountLabel.Text = "融资金额:";
            // 
            // financeBatchNoLabel
            // 
            financeBatchNoLabel.AutoSize = true;
            // 
            // 
            // 
            financeBatchNoLabel.BackgroundStyle.Class = "";
            financeBatchNoLabel.Location = new System.Drawing.Point(15, 5);
            financeBatchNoLabel.Name = "financeBatchNoLabel";
            financeBatchNoLabel.Size = new System.Drawing.Size(59, 16);
            financeBatchNoLabel.TabIndex = 0;
            financeBatchNoLabel.Text = "融资批号:";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckBox,
            this.colCaseCode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvClients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvClients.Location = new System.Drawing.Point(0, 96);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvClients.Size = new System.Drawing.Size(755, 269);
            this.dgvClients.TabIndex = 5;
            // 
            // poolBindingNavigator
            // 
            this.poolBindingNavigator.AddNewItem = null;
            this.poolBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.poolBindingNavigator.DeleteItem = null;
            this.poolBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.poolBindingNavigator.Location = new System.Drawing.Point(0, 71);
            this.poolBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.poolBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.poolBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.poolBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.poolBindingNavigator.Name = "poolBindingNavigator";
            this.poolBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.poolBindingNavigator.Size = new System.Drawing.Size(755, 25);
            this.poolBindingNavigator.TabIndex = 4;
            this.poolBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panelFinanceBatch
            // 
            this.panelFinanceBatch.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelFinanceBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelFinanceBatch.Controls.Add(lblLoanNo);
            this.panelFinanceBatch.Controls.Add(this.tbLoanNo);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchImport);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchExport);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchSelect);
            this.panelFinanceBatch.Controls.Add(this.tbFinanceLineBalance);
            this.panelFinanceBatch.Controls.Add(lblFinanceLineBalance);
            this.panelFinanceBatch.Controls.Add(this.tbTotalInterest);
            this.panelFinanceBatch.Controls.Add(lblTotalInterest);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchNew);
            this.panelFinanceBatch.Controls.Add(this.btnFactorSelect);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchSave);
            this.panelFinanceBatch.Controls.Add(financeTypeLabel);
            this.panelFinanceBatch.Controls.Add(this.financeTypeComboBoxEx);
            this.panelFinanceBatch.Controls.Add(costRateLabel);
            this.panelFinanceBatch.Controls.Add(this.costRateTextBoxX);
            this.panelFinanceBatch.Controls.Add(factorCodeLabel);
            this.panelFinanceBatch.Controls.Add(this.factorCodeTextBox);
            this.panelFinanceBatch.Controls.Add(financeRateLabel);
            this.panelFinanceBatch.Controls.Add(this.financeRateTextBox);
            this.panelFinanceBatch.Controls.Add(this.financePeriodEndDateTimePicker);
            this.panelFinanceBatch.Controls.Add(financePeriodBeginLabel);
            this.panelFinanceBatch.Controls.Add(this.financePeriodBeginDateTimePicker);
            this.panelFinanceBatch.Controls.Add(financeAmountLabel);
            this.panelFinanceBatch.Controls.Add(this.financeAmountTextBoxX);
            this.panelFinanceBatch.Controls.Add(this.batchCurrencyComboBoxEx);
            this.panelFinanceBatch.Controls.Add(financeBatchNoLabel);
            this.panelFinanceBatch.Controls.Add(this.financeBatchNoTextBox);
            this.panelFinanceBatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFinanceBatch.Location = new System.Drawing.Point(0, 0);
            this.panelFinanceBatch.Name = "panelFinanceBatch";
            this.panelFinanceBatch.Size = new System.Drawing.Size(755, 71);
            this.panelFinanceBatch.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelFinanceBatch.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelFinanceBatch.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelFinanceBatch.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelFinanceBatch.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelFinanceBatch.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelFinanceBatch.Style.GradientAngle = 90;
            this.panelFinanceBatch.TabIndex = 3;
            // 
            // tbLoanNo
            // 
            // 
            // 
            // 
            this.tbLoanNo.Border.Class = "TextBoxBorder";
            this.tbLoanNo.Location = new System.Drawing.Point(260, 3);
            this.tbLoanNo.Name = "tbLoanNo";
            this.tbLoanNo.Size = new System.Drawing.Size(100, 20);
            this.tbLoanNo.TabIndex = 3;
            // 
            // btnFinanceBatchImport
            // 
            this.btnFinanceBatchImport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchImport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchImport.Location = new System.Drawing.Point(767, 35);
            this.btnFinanceBatchImport.Name = "btnFinanceBatchImport";
            this.btnFinanceBatchImport.Size = new System.Drawing.Size(61, 23);
            this.btnFinanceBatchImport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchImport.TabIndex = 29;
            this.btnFinanceBatchImport.Text = "导入批次";
            // 
            // btnFinanceBatchExport
            // 
            this.btnFinanceBatchExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchExport.Location = new System.Drawing.Point(700, 35);
            this.btnFinanceBatchExport.Name = "btnFinanceBatchExport";
            this.btnFinanceBatchExport.Size = new System.Drawing.Size(61, 23);
            this.btnFinanceBatchExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchExport.TabIndex = 20;
            this.btnFinanceBatchExport.Text = "导出批次";
            // 
            // btnFinanceBatchSelect
            // 
            this.btnFinanceBatchSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchSelect.Location = new System.Drawing.Point(834, 6);
            this.btnFinanceBatchSelect.Name = "btnFinanceBatchSelect";
            this.btnFinanceBatchSelect.Size = new System.Drawing.Size(61, 23);
            this.btnFinanceBatchSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchSelect.TabIndex = 27;
            this.btnFinanceBatchSelect.Text = "选择批次";
            // 
            // tbFinanceLineBalance
            // 
            // 
            // 
            // 
            this.tbFinanceLineBalance.Border.Class = "TextBoxBorder";
            this.tbFinanceLineBalance.Location = new System.Drawing.Point(1025, 3);
            this.tbFinanceLineBalance.Name = "tbFinanceLineBalance";
            this.tbFinanceLineBalance.ReadOnly = true;
            this.tbFinanceLineBalance.Size = new System.Drawing.Size(100, 20);
            this.tbFinanceLineBalance.TabIndex = 26;
            // 
            // tbTotalInterest
            // 
            // 
            // 
            // 
            this.tbTotalInterest.Border.Class = "TextBoxBorder";
            this.tbTotalInterest.Location = new System.Drawing.Point(1025, 24);
            this.tbTotalInterest.Name = "tbTotalInterest";
            this.tbTotalInterest.ReadOnly = true;
            this.tbTotalInterest.Size = new System.Drawing.Size(100, 20);
            this.tbTotalInterest.TabIndex = 24;
            // 
            // btnFinanceBatchNew
            // 
            this.btnFinanceBatchNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchNew.Location = new System.Drawing.Point(700, 6);
            this.btnFinanceBatchNew.Name = "btnFinanceBatchNew";
            this.btnFinanceBatchNew.Size = new System.Drawing.Size(61, 23);
            this.btnFinanceBatchNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchNew.TabIndex = 19;
            this.btnFinanceBatchNew.Text = "新建批次";
            // 
            // btnFactorSelect
            // 
            this.btnFactorSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorSelect.Location = new System.Drawing.Point(546, 46);
            this.btnFactorSelect.Name = "btnFactorSelect";
            this.btnFactorSelect.Size = new System.Drawing.Size(28, 23);
            this.btnFactorSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFactorSelect.TabIndex = 18;
            this.btnFactorSelect.Text = "...";
            // 
            // btnFinanceBatchSave
            // 
            this.btnFinanceBatchSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchSave.Location = new System.Drawing.Point(767, 6);
            this.btnFinanceBatchSave.Name = "btnFinanceBatchSave";
            this.btnFinanceBatchSave.Size = new System.Drawing.Size(61, 23);
            this.btnFinanceBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFinanceBatchSave.TabIndex = 19;
            this.btnFinanceBatchSave.Text = "保存批次";
            // 
            // financeTypeComboBoxEx
            // 
            this.financeTypeComboBoxEx.DisplayMember = "Text";
            this.financeTypeComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.financeTypeComboBoxEx.FormattingEnabled = true;
            this.financeTypeComboBoxEx.ItemHeight = 14;
            this.financeTypeComboBoxEx.Items.AddRange(new object[] {
            "预付款",
            "卖方代付",
            "买方代付",
            "银行承兑汇票",
            "商业承兑汇票",
            "国内信用证",
            "国际信用证",
            "其他",
            "未知"});
            this.financeTypeComboBoxEx.Location = new System.Drawing.Point(440, 3);
            this.financeTypeComboBoxEx.Name = "financeTypeComboBoxEx";
            this.financeTypeComboBoxEx.Size = new System.Drawing.Size(100, 20);
            this.financeTypeComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.financeTypeComboBoxEx.TabIndex = 5;
            // 
            // costRateTextBoxX
            // 
            // 
            // 
            // 
            this.costRateTextBoxX.Border.Class = "TextBoxBorder";
            this.costRateTextBoxX.Location = new System.Drawing.Point(260, 26);
            this.costRateTextBoxX.Name = "costRateTextBoxX";
            this.costRateTextBoxX.Size = new System.Drawing.Size(100, 20);
            this.costRateTextBoxX.TabIndex = 9;
            // 
            // factorCodeTextBox
            // 
            // 
            // 
            // 
            this.factorCodeTextBox.Border.Class = "TextBoxBorder";
            this.factorCodeTextBox.Location = new System.Drawing.Point(440, 47);
            this.factorCodeTextBox.Name = "factorCodeTextBox";
            this.factorCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.factorCodeTextBox.TabIndex = 17;
            // 
            // financeRateTextBox
            // 
            // 
            // 
            // 
            this.financeRateTextBox.Border.Class = "TextBoxBorder";
            this.financeRateTextBox.Location = new System.Drawing.Point(80, 25);
            this.financeRateTextBox.Name = "financeRateTextBox";
            this.financeRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeRateTextBox.TabIndex = 7;
            // 
            // financePeriodEndDateTimePicker
            // 
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financePeriodEndDateTimePicker.ButtonDropDown.Visible = true;
            this.financePeriodEndDateTimePicker.ButtonFreeText.Checked = true;
            this.financePeriodEndDateTimePicker.FreeTextEntryMode = true;
            this.financePeriodEndDateTimePicker.Location = new System.Drawing.Point(572, 25);
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financePeriodEndDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            this.financePeriodEndDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.financePeriodEndDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.financePeriodEndDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financePeriodEndDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodEndDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.financePeriodEndDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.financePeriodEndDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financePeriodEndDateTimePicker.Name = "financePeriodEndDateTimePicker";
            this.financePeriodEndDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.financePeriodEndDateTimePicker.TabIndex = 12;
            // 
            // financePeriodBeginDateTimePicker
            // 
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financePeriodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.financePeriodBeginDateTimePicker.ButtonFreeText.Checked = true;
            this.financePeriodBeginDateTimePicker.FreeTextEntryMode = true;
            this.financePeriodBeginDateTimePicker.Location = new System.Drawing.Point(440, 25);
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.Class = "";
            this.financePeriodBeginDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.financePeriodBeginDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.financePeriodBeginDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financePeriodBeginDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.financePeriodBeginDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.financePeriodBeginDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financePeriodBeginDateTimePicker.Name = "financePeriodBeginDateTimePicker";
            this.financePeriodBeginDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.financePeriodBeginDateTimePicker.TabIndex = 11;
            // 
            // financeAmountTextBoxX
            // 
            // 
            // 
            // 
            this.financeAmountTextBoxX.Border.Class = "TextBoxBorder";
            this.financeAmountTextBoxX.Location = new System.Drawing.Point(154, 46);
            this.financeAmountTextBoxX.Name = "financeAmountTextBoxX";
            this.financeAmountTextBoxX.Size = new System.Drawing.Size(100, 20);
            this.financeAmountTextBoxX.TabIndex = 15;
            // 
            // batchCurrencyComboBoxEx
            // 
            this.batchCurrencyComboBoxEx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.batchCurrencyComboBoxEx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.batchCurrencyComboBoxEx.DisplayMember = "Text";
            this.batchCurrencyComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.batchCurrencyComboBoxEx.FormattingEnabled = true;
            this.batchCurrencyComboBoxEx.ItemHeight = 14;
            this.batchCurrencyComboBoxEx.Location = new System.Drawing.Point(80, 46);
            this.batchCurrencyComboBoxEx.Name = "batchCurrencyComboBoxEx";
            this.batchCurrencyComboBoxEx.Size = new System.Drawing.Size(68, 20);
            this.batchCurrencyComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.batchCurrencyComboBoxEx.TabIndex = 14;
            // 
            // financeBatchNoTextBox
            // 
            // 
            // 
            // 
            this.financeBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.financeBatchNoTextBox.Location = new System.Drawing.Point(80, 4);
            this.financeBatchNoTextBox.Name = "financeBatchNoTextBox";
            this.financeBatchNoTextBox.ReadOnly = true;
            this.financeBatchNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.financeBatchNoTextBox.TabIndex = 1;
            // 
            // colCheckBox
            // 
            this.colCheckBox.Frozen = true;
            this.colCheckBox.HeaderText = "";
            this.colCheckBox.Name = "colCheckBox";
            this.colCheckBox.ReadOnly = true;
            this.colCheckBox.Width = 20;
            // 
            // colCaseCode
            // 
            this.colCaseCode.DataPropertyName = "CaseCode";
            this.colCaseCode.Frozen = true;
            this.colCaseCode.HeaderText = "案件编号";
            this.colCaseCode.Name = "colCaseCode";
            this.colCaseCode.ReadOnly = true;
            // 
            // PoolFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.poolBindingNavigator);
            this.Controls.Add(this.panelFinanceBatch);
            this.Name = "PoolFinance";
            this.Size = new System.Drawing.Size(755, 365);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolBindingNavigator)).EndInit();
            this.poolBindingNavigator.ResumeLayout(false);
            this.poolBindingNavigator.PerformLayout();
            this.panelFinanceBatch.ResumeLayout(false);
            this.panelFinanceBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodEndDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvClients;
        private System.Windows.Forms.BindingNavigator poolBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevComponents.DotNetBar.PanelEx panelFinanceBatch;
        private DevComponents.DotNetBar.Controls.TextBoxX tbLoanNo;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchImport;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchExport;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchSelect;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFinanceLineBalance;
        private DevComponents.DotNetBar.Controls.TextBoxX tbTotalInterest;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchNew;
        private DevComponents.DotNetBar.ButtonX btnFactorSelect;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchSave;
        private DevComponents.DotNetBar.Controls.ComboBoxEx financeTypeComboBoxEx;
        private DevComponents.DotNetBar.Controls.TextBoxX costRateTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX factorCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX financeRateTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financePeriodEndDateTimePicker;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financePeriodBeginDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX financeAmountTextBoxX;
        private DevComponents.DotNetBar.Controls.ComboBoxEx batchCurrencyComboBoxEx;
        private DevComponents.DotNetBar.Controls.TextBoxX financeBatchNoTextBox;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseCode;
    }
}

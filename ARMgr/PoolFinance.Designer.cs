namespace CMBC.EasyFactor.ARMgr
{
    partial class PoolFinance
    {
		#region?Fields?(45)?

        private System.Windows.Forms.BindingSource batchBindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx batchCurrencyComboBoxEx;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevComponents.DotNetBar.ButtonX btnFactorSelect;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchNew;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchSave;
        private DevComponents.DotNetBar.ButtonX btnFinanceBatchSelect;
        private System.Windows.Forms.BindingSource casesBindingSource;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.TextBoxX costRateTextBoxX;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCases;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private DevComponents.DotNetBar.Controls.TextBoxX factorCodeTextBox;
        private DevComponents.DotNetBar.Controls.TextBoxX financeAmountTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX financeBatchNoTextBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput financePeriodBeginDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX financeRateTextBox;
        private DevComponents.DotNetBar.Controls.ComboBoxEx financeTypeComboBoxEx;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter;
        private DevComponents.DotNetBar.PanelEx panelFinanceBatch;
        private System.Windows.Forms.BindingNavigator poolBindingNavigator;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator3;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator4;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator5;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator6;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator;
        private DevComponents.DotNetBar.Controls.TextBoxX tbLoanNo;

		#endregion?Fields?

		#region?Methods?(1)?

		//?Protected?Methods?(1)?

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

            if (this._context != null)
            {
                this._context.Dispose();
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
            DevComponents.DotNetBar.LabelX lblLoanNo;
            DevComponents.DotNetBar.LabelX financeTypeLabel;
            DevComponents.DotNetBar.LabelX costRateLabel;
            DevComponents.DotNetBar.LabelX factorCodeLabel;
            DevComponents.DotNetBar.LabelX financeRateLabel;
            DevComponents.DotNetBar.LabelX financePeriodBeginLabel;
            DevComponents.DotNetBar.LabelX financeAmountLabel;
            DevComponents.DotNetBar.LabelX financeBatchNoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoolFinance));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCases = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.btnFinanceBatchSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchNew = new DevComponents.DotNetBar.ButtonX();
            this.btnFactorSelect = new DevComponents.DotNetBar.ButtonX();
            this.btnFinanceBatchSave = new DevComponents.DotNetBar.ButtonX();
            this.financeTypeComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.costRateTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.factorCodeTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financeRateTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.financePeriodBeginDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.financeAmountTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.batchCurrencyComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.financeBatchNoTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.superValidator = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator4 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.requiredFieldValidator3 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator6 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.requiredFieldValidator5 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("必填");
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter = new DevComponents.DotNetBar.Validator.Highlighter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValuedAssignOutstanding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceProportion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanBeFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            lblLoanNo = new DevComponents.DotNetBar.LabelX();
            financeTypeLabel = new DevComponents.DotNetBar.LabelX();
            costRateLabel = new DevComponents.DotNetBar.LabelX();
            factorCodeLabel = new DevComponents.DotNetBar.LabelX();
            financeRateLabel = new DevComponents.DotNetBar.LabelX();
            financePeriodBeginLabel = new DevComponents.DotNetBar.LabelX();
            financeAmountLabel = new DevComponents.DotNetBar.LabelX();
            financeBatchNoLabel = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolBindingNavigator)).BeginInit();
            this.poolBindingNavigator.SuspendLayout();
            this.panelFinanceBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoanNo
            // 
            lblLoanNo.AutoSize = true;
            // 
            // 
            // 
            lblLoanNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            lblLoanNo.Location = new System.Drawing.Point(195, 5);
            lblLoanNo.Name = "lblLoanNo";
            lblLoanNo.Size = new System.Drawing.Size(62, 18);
            lblLoanNo.TabIndex = 2;
            lblLoanNo.Text = "放款编号:";
            // 
            // financeTypeLabel
            // 
            financeTypeLabel.AutoSize = true;
            // 
            // 
            // 
            financeTypeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeTypeLabel.Location = new System.Drawing.Point(375, 4);
            financeTypeLabel.Name = "financeTypeLabel";
            financeTypeLabel.Size = new System.Drawing.Size(62, 18);
            financeTypeLabel.TabIndex = 4;
            financeTypeLabel.Text = "出账方式:";
            // 
            // costRateLabel
            // 
            costRateLabel.AutoSize = true;
            // 
            // 
            // 
            costRateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            costRateLabel.Location = new System.Drawing.Point(195, 25);
            costRateLabel.Name = "costRateLabel";
            costRateLabel.Size = new System.Drawing.Size(62, 18);
            costRateLabel.TabIndex = 8;
            costRateLabel.Text = "成本利率:";
            // 
            // factorCodeLabel
            // 
            factorCodeLabel.AutoSize = true;
            // 
            // 
            // 
            factorCodeLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            factorCodeLabel.Location = new System.Drawing.Point(387, 44);
            factorCodeLabel.Name = "factorCodeLabel";
            factorCodeLabel.Size = new System.Drawing.Size(50, 18);
            factorCodeLabel.TabIndex = 16;
            factorCodeLabel.Text = "代付行:";
            // 
            // financeRateLabel
            // 
            financeRateLabel.AutoSize = true;
            // 
            // 
            // 
            financeRateLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeRateLabel.Location = new System.Drawing.Point(15, 23);
            financeRateLabel.Name = "financeRateLabel";
            financeRateLabel.Size = new System.Drawing.Size(62, 18);
            financeRateLabel.TabIndex = 6;
            financeRateLabel.Text = "融资利率:";
            // 
            // financePeriodBeginLabel
            // 
            financePeriodBeginLabel.AutoSize = true;
            // 
            // 
            // 
            financePeriodBeginLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financePeriodBeginLabel.Location = new System.Drawing.Point(387, 23);
            financePeriodBeginLabel.Name = "financePeriodBeginLabel";
            financePeriodBeginLabel.Size = new System.Drawing.Size(50, 18);
            financePeriodBeginLabel.TabIndex = 10;
            financePeriodBeginLabel.Text = "融资日:";
            // 
            // financeAmountLabel
            // 
            financeAmountLabel.AutoSize = true;
            // 
            // 
            // 
            financeAmountLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeAmountLabel.Location = new System.Drawing.Point(15, 42);
            financeAmountLabel.Name = "financeAmountLabel";
            financeAmountLabel.Size = new System.Drawing.Size(62, 18);
            financeAmountLabel.TabIndex = 13;
            financeAmountLabel.Text = "融资金额:";
            // 
            // financeBatchNoLabel
            // 
            financeBatchNoLabel.AutoSize = true;
            // 
            // 
            // 
            financeBatchNoLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            financeBatchNoLabel.Location = new System.Drawing.Point(15, 5);
            financeBatchNoLabel.Name = "financeBatchNoLabel";
            financeBatchNoLabel.Size = new System.Drawing.Size(62, 18);
            financeBatchNoLabel.TabIndex = 0;
            financeBatchNoLabel.Text = "融资批号:";
            // 
            // dgvCases
            // 
            this.dgvCases.AllowUserToAddRows = false;
            this.dgvCases.AllowUserToDeleteRows = false;
            this.dgvCases.AllowUserToOrderColumns = true;
            this.dgvCases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCaseCode,
            this.colBuyerClient,
            this.colAssignOutstanding,
            this.colValuedAssignOutstanding,
            this.colFinanceProportion,
            this.colCanBeFinanceAmount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCases.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCases.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCases.Location = new System.Drawing.Point(0, 91);
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.ReadOnly = true;
            this.dgvCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCases.Size = new System.Drawing.Size(1075, 246);
            this.dgvCases.TabIndex = 5;
            this.dgvCases.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCasesRowHeaderMouseDoubleClick);
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
            this.poolBindingNavigator.Location = new System.Drawing.Point(0, 66);
            this.poolBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.poolBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.poolBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.poolBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.poolBindingNavigator.Name = "poolBindingNavigator";
            this.poolBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.poolBindingNavigator.Size = new System.Drawing.Size(1075, 25);
            this.poolBindingNavigator.TabIndex = 4;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(32, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
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
            this.panelFinanceBatch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.panelFinanceBatch.Controls.Add(lblLoanNo);
            this.panelFinanceBatch.Controls.Add(this.tbLoanNo);
            this.panelFinanceBatch.Controls.Add(this.btnFinanceBatchSelect);
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
            this.panelFinanceBatch.Controls.Add(financePeriodBeginLabel);
            this.panelFinanceBatch.Controls.Add(this.financePeriodBeginDateTimePicker);
            this.panelFinanceBatch.Controls.Add(financeAmountLabel);
            this.panelFinanceBatch.Controls.Add(this.financeAmountTextBoxX);
            this.panelFinanceBatch.Controls.Add(this.batchCurrencyComboBoxEx);
            this.panelFinanceBatch.Controls.Add(financeBatchNoLabel);
            this.panelFinanceBatch.Controls.Add(this.financeBatchNoTextBox);
            this.panelFinanceBatch.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelFinanceBatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFinanceBatch.Location = new System.Drawing.Point(0, 0);
            this.panelFinanceBatch.Name = "panelFinanceBatch";
            this.panelFinanceBatch.Size = new System.Drawing.Size(1075, 66);
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
            this.tbLoanNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbLoanNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "LoanNo", true));
            this.tbLoanNo.Location = new System.Drawing.Point(260, 3);
            this.tbLoanNo.Name = "tbLoanNo";
            this.tbLoanNo.Size = new System.Drawing.Size(100, 21);
            this.tbLoanNo.TabIndex = 3;
            // 
            // btnFinanceBatchSelect
            // 
            this.btnFinanceBatchSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchSelect.Enabled = false;
            this.btnFinanceBatchSelect.Location = new System.Drawing.Point(834, 6);
            this.btnFinanceBatchSelect.Name = "btnFinanceBatchSelect";
            this.btnFinanceBatchSelect.Size = new System.Drawing.Size(61, 21);
            this.btnFinanceBatchSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFinanceBatchSelect.TabIndex = 27;
            this.btnFinanceBatchSelect.Text = "选择批次";
            this.btnFinanceBatchSelect.Click += new System.EventHandler(this.SelectBatch);
            // 
            // btnFinanceBatchNew
            // 
            this.btnFinanceBatchNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchNew.Location = new System.Drawing.Point(700, 6);
            this.btnFinanceBatchNew.Name = "btnFinanceBatchNew";
            this.btnFinanceBatchNew.Size = new System.Drawing.Size(61, 21);
            this.btnFinanceBatchNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFinanceBatchNew.TabIndex = 19;
            this.btnFinanceBatchNew.Text = "新建批次";
            this.btnFinanceBatchNew.Click += new System.EventHandler(this.NewBatch);
            // 
            // btnFactorSelect
            // 
            this.btnFactorSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFactorSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFactorSelect.Location = new System.Drawing.Point(546, 44);
            this.btnFactorSelect.Name = "btnFactorSelect";
            this.btnFactorSelect.Size = new System.Drawing.Size(28, 21);
            this.btnFactorSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFactorSelect.TabIndex = 18;
            this.btnFactorSelect.Text = "...";
            this.btnFactorSelect.Click += new System.EventHandler(this.SelectFactor);
            // 
            // btnFinanceBatchSave
            // 
            this.btnFinanceBatchSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFinanceBatchSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFinanceBatchSave.Location = new System.Drawing.Point(767, 6);
            this.btnFinanceBatchSave.Name = "btnFinanceBatchSave";
            this.btnFinanceBatchSave.Size = new System.Drawing.Size(61, 21);
            this.btnFinanceBatchSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.btnFinanceBatchSave.TabIndex = 19;
            this.btnFinanceBatchSave.Text = "保存批次";
            this.btnFinanceBatchSave.Click += new System.EventHandler(this.SaveBatch);
            // 
            // financeTypeComboBoxEx
            // 
            this.financeTypeComboBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceType", true));
            this.financeTypeComboBoxEx.DisplayMember = "Text";
            this.financeTypeComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.financeTypeComboBoxEx.FormattingEnabled = true;
            this.financeTypeComboBoxEx.ItemHeight = 14;
            this.financeTypeComboBoxEx.Items.AddRange(new object[] {
            "保理预付款(表内)",
            "卖方代付",
            "买方代付",
            "银行承兑汇票",
            "商业承兑汇票",
            "国内信用证",
            "国际信用证",
            "其他",
            "未知"});
            this.financeTypeComboBoxEx.Location = new System.Drawing.Point(440, 2);
            this.financeTypeComboBoxEx.Name = "financeTypeComboBoxEx";
            this.financeTypeComboBoxEx.Size = new System.Drawing.Size(122, 20);
            this.financeTypeComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.financeTypeComboBoxEx.TabIndex = 5;
            this.superValidator.SetValidator1(this.financeTypeComboBoxEx, this.requiredFieldValidator1);
            // 
            // costRateTextBoxX
            // 
            // 
            // 
            // 
            this.costRateTextBoxX.Border.Class = "TextBoxBorder";
            this.costRateTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.costRateTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "CostRate", true));
            this.costRateTextBoxX.Location = new System.Drawing.Point(260, 24);
            this.costRateTextBoxX.Name = "costRateTextBoxX";
            this.costRateTextBoxX.Size = new System.Drawing.Size(100, 21);
            this.costRateTextBoxX.TabIndex = 9;
            // 
            // factorCodeTextBox
            // 
            // 
            // 
            // 
            this.factorCodeTextBox.Border.Class = "TextBoxBorder";
            this.factorCodeTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.factorCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FactorCode", true));
            this.factorCodeTextBox.Location = new System.Drawing.Point(440, 44);
            this.factorCodeTextBox.Name = "factorCodeTextBox";
            this.factorCodeTextBox.Size = new System.Drawing.Size(100, 21);
            this.factorCodeTextBox.TabIndex = 17;
            // 
            // financeRateTextBox
            // 
            // 
            // 
            // 
            this.financeRateTextBox.Border.Class = "TextBoxBorder";
            this.financeRateTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceRate", true));
            this.financeRateTextBox.Location = new System.Drawing.Point(80, 22);
            this.financeRateTextBox.Name = "financeRateTextBox";
            this.financeRateTextBox.Size = new System.Drawing.Size(100, 21);
            this.financeRateTextBox.TabIndex = 7;
            this.superValidator.SetValidator1(this.financeRateTextBox, this.requiredFieldValidator2);
            // 
            // financePeriodBeginDateTimePicker
            // 
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.financePeriodBeginDateTimePicker.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financePeriodBeginDateTimePicker.ButtonDropDown.Visible = true;
            this.financePeriodBeginDateTimePicker.ButtonFreeText.Checked = true;
            this.financePeriodBeginDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinancePeriodBegin", true));
            this.financePeriodBeginDateTimePicker.FreeTextEntryMode = true;
            this.financePeriodBeginDateTimePicker.IsPopupCalendarOpen = false;
            this.financePeriodBeginDateTimePicker.Location = new System.Drawing.Point(440, 23);
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.financePeriodBeginDateTimePicker.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financePeriodBeginDateTimePicker.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financePeriodBeginDateTimePicker.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.financePeriodBeginDateTimePicker.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.financePeriodBeginDateTimePicker.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.financePeriodBeginDateTimePicker.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financePeriodBeginDateTimePicker.MonthCalendar.TodayButtonVisible = true;
            this.financePeriodBeginDateTimePicker.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.financePeriodBeginDateTimePicker.Name = "financePeriodBeginDateTimePicker";
            this.financePeriodBeginDateTimePicker.Size = new System.Drawing.Size(122, 21);
            this.financePeriodBeginDateTimePicker.TabIndex = 11;
            this.superValidator.SetValidator1(this.financePeriodBeginDateTimePicker, this.requiredFieldValidator3);
            // 
            // financeAmountTextBoxX
            // 
            // 
            // 
            // 
            this.financeAmountTextBoxX.Border.Class = "TextBoxBorder";
            this.financeAmountTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeAmountTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceAmount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.financeAmountTextBoxX.Location = new System.Drawing.Point(155, 44);
            this.financeAmountTextBoxX.Name = "financeAmountTextBoxX";
            this.financeAmountTextBoxX.Size = new System.Drawing.Size(100, 21);
            this.financeAmountTextBoxX.TabIndex = 15;
            this.superValidator.SetValidator1(this.financeAmountTextBoxX, this.requiredFieldValidator6);
            // 
            // batchCurrencyComboBoxEx
            // 
            this.batchCurrencyComboBoxEx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.batchCurrencyComboBoxEx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.batchCurrencyComboBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "BatchCurrency", true));
            this.batchCurrencyComboBoxEx.DisplayMember = "Text";
            this.batchCurrencyComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.batchCurrencyComboBoxEx.FormattingEnabled = true;
            this.batchCurrencyComboBoxEx.ItemHeight = 14;
            this.batchCurrencyComboBoxEx.Location = new System.Drawing.Point(80, 44);
            this.batchCurrencyComboBoxEx.Name = "batchCurrencyComboBoxEx";
            this.batchCurrencyComboBoxEx.Size = new System.Drawing.Size(68, 20);
            this.batchCurrencyComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeMobile2014;
            this.batchCurrencyComboBoxEx.TabIndex = 14;
            this.superValidator.SetValidator1(this.batchCurrencyComboBoxEx, this.requiredFieldValidator5);
            // 
            // financeBatchNoTextBox
            // 
            // 
            // 
            // 
            this.financeBatchNoTextBox.Border.Class = "TextBoxBorder";
            this.financeBatchNoTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.financeBatchNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.batchBindingSource, "FinanceBatchNo", true));
            this.financeBatchNoTextBox.Location = new System.Drawing.Point(80, 2);
            this.financeBatchNoTextBox.Name = "financeBatchNoTextBox";
            this.financeBatchNoTextBox.ReadOnly = true;
            this.financeBatchNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.financeBatchNoTextBox.TabIndex = 1;
            // 
            // superValidator
            // 
            this.superValidator.ContainerControl = this;
            this.superValidator.ErrorProvider = this.errorProvider;
            this.superValidator.Highlighter = this.highlighter;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "必填";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "必填";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.ErrorMessage = "必填";
            this.requiredFieldValidator4.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.financePeriodBeginDateTimePicker;
            this.compareValidator1.ErrorMessage = "终止日期应该大于起始日期";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            this.compareValidator1.Operator = DevComponents.DotNetBar.Validator.eValidationCompareOperator.GreaterThan;
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.ErrorMessage = "必填";
            this.requiredFieldValidator3.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.ErrorMessage = "必填";
            this.requiredFieldValidator6.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.ErrorMessage = "必填";
            this.requiredFieldValidator5.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
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
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CaseCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "案件编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 172;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BuyerClient";
            this.dataGridViewTextBoxColumn2.HeaderText = "买方名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 172;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn3.HeaderText = "账款余额";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 172;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ValuedAssignOutstanding";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn4.HeaderText = "有效账款余额";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 172;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FinanceProportion";
            dataGridViewCellStyle9.Format = "p0";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn5.HeaderText = "预付比例";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 172;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CanBeFinanceAmount";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn6.HeaderText = "可融资金额";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 172;
            // 
            // colCaseCode
            // 
            this.colCaseCode.DataPropertyName = "CaseCode";
            this.colCaseCode.HeaderText = "案件编号";
            this.colCaseCode.Name = "colCaseCode";
            this.colCaseCode.ReadOnly = true;
            // 
            // colBuyerClient
            // 
            this.colBuyerClient.DataPropertyName = "BuyerClient";
            this.colBuyerClient.HeaderText = "买方名称";
            this.colBuyerClient.Name = "colBuyerClient";
            this.colBuyerClient.ReadOnly = true;
            // 
            // colAssignOutstanding
            // 
            this.colAssignOutstanding.DataPropertyName = "AssignOutstanding";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.colAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAssignOutstanding.HeaderText = "账款余额";
            this.colAssignOutstanding.Name = "colAssignOutstanding";
            this.colAssignOutstanding.ReadOnly = true;
            // 
            // colValuedAssignOutstanding
            // 
            this.colValuedAssignOutstanding.DataPropertyName = "ValuedAssignOutstanding";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.colValuedAssignOutstanding.DefaultCellStyle = dataGridViewCellStyle3;
            this.colValuedAssignOutstanding.HeaderText = "有效账款余额";
            this.colValuedAssignOutstanding.Name = "colValuedAssignOutstanding";
            this.colValuedAssignOutstanding.ReadOnly = true;
            // 
            // colFinanceProportion
            // 
            this.colFinanceProportion.DataPropertyName = "FinanceProportion";
            dataGridViewCellStyle4.Format = "p0";
            this.colFinanceProportion.DefaultCellStyle = dataGridViewCellStyle4;
            this.colFinanceProportion.HeaderText = "预付比例";
            this.colFinanceProportion.Name = "colFinanceProportion";
            this.colFinanceProportion.ReadOnly = true;
            // 
            // colCanBeFinanceAmount
            // 
            this.colCanBeFinanceAmount.DataPropertyName = "CanBeFinanceAmount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.colCanBeFinanceAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.colCanBeFinanceAmount.HeaderText = "可融资金额";
            this.colCanBeFinanceAmount.Name = "colCanBeFinanceAmount";
            this.colCanBeFinanceAmount.ReadOnly = true;
            // 
            // batchBindingSource
            // 
            this.batchBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.InvoiceFinanceBatch);
            // 
            // casesBindingSource
            // 
            this.casesBindingSource.DataSource = typeof(CMBC.EasyFactor.DB.dbml.Case);
            // 
            // PoolFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCases);
            this.Controls.Add(this.poolBindingNavigator);
            this.Controls.Add(this.panelFinanceBatch);
            this.Name = "PoolFinance";
            this.Size = new System.Drawing.Size(1075, 337);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poolBindingNavigator)).EndInit();
            this.poolBindingNavigator.ResumeLayout(false);
            this.poolBindingNavigator.PerformLayout();
            this.panelFinanceBatch.ResumeLayout(false);
            this.panelFinanceBatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financePeriodBeginDateTimePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colCaseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValuedAssignOutstanding;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceProportion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanBeFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

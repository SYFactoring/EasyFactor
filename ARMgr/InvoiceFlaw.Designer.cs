namespace CMBC.EasyFactor.ARMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InvoiceFlaw
    {
		#region Fields (18) 

        private DevComponents.DotNetBar.ButtonX btnFlaw;
        private DevComponents.DotNetBar.ButtonX btnFlawClose;
        private DevComponents.DotNetBar.ButtonX btnFlawResolve;
        private DevComponents.DotNetBar.ButtonX btnFlawSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceNo;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvInvoices;
        private System.Windows.Forms.CheckedListBox flawReasonCheckedListBox;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput flawResolveDateDateTimePicker;
        private DevComponents.DotNetBar.Controls.TextBoxX flawResolveUserNameTextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelFlaw;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelFlawResolve;
        private DevComponents.DotNetBar.Controls.CheckBoxX isFlawCheckBox;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFlawReason;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFlawResolveReason;

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
            DevComponents.DotNetBar.LabelX flawResolveReasonLabel;
            DevComponents.DotNetBar.LabelX flawResolveUserNameLabel;
            DevComponents.DotNetBar.LabelX flawResolveDateLabel;
            DevComponents.DotNetBar.LabelX flawReasonLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanelFlawResolve = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnFlawClose = new DevComponents.DotNetBar.ButtonX();
            this.btnFlawSave = new DevComponents.DotNetBar.ButtonX();
            this.btnFlawResolve = new DevComponents.DotNetBar.ButtonX();
            this.tbFlawResolveReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.flawResolveDateDateTimePicker = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.flawResolveUserNameTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelFlaw = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.isFlawCheckBox = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnFlaw = new DevComponents.DotNetBar.ButtonX();
            this.tbFlawReason = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.flawReasonCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.dgvInvoices = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            flawResolveReasonLabel = new DevComponents.DotNetBar.LabelX();
            flawResolveUserNameLabel = new DevComponents.DotNetBar.LabelX();
            flawResolveDateLabel = new DevComponents.DotNetBar.LabelX();
            flawReasonLabel = new DevComponents.DotNetBar.LabelX();
            this.groupPanelFlawResolve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flawResolveDateDateTimePicker)).BeginInit();
            this.groupPanelFlaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
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
            flawResolveReasonLabel.Location = new System.Drawing.Point(23, 35);
            flawResolveReasonLabel.Name = "flawResolveReasonLabel";
            flawResolveReasonLabel.Size = new System.Drawing.Size(59, 16);
            flawResolveReasonLabel.TabIndex = 1;
            flawResolveReasonLabel.Text = "解除原因:";
            // 
            // flawResolveUserNameLabel
            // 
            flawResolveUserNameLabel.AutoSize = true;
            flawResolveUserNameLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            flawResolveUserNameLabel.BackgroundStyle.Class = "";
            flawResolveUserNameLabel.Location = new System.Drawing.Point(271, 85);
            flawResolveUserNameLabel.Name = "flawResolveUserNameLabel";
            flawResolveUserNameLabel.Size = new System.Drawing.Size(47, 16);
            flawResolveUserNameLabel.TabIndex = 5;
            flawResolveUserNameLabel.Text = "经办人:";
            // 
            // flawResolveDateLabel
            // 
            flawResolveDateLabel.AutoSize = true;
            flawResolveDateLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            flawResolveDateLabel.BackgroundStyle.Class = "";
            flawResolveDateLabel.Location = new System.Drawing.Point(106, 86);
            flawResolveDateLabel.Name = "flawResolveDateLabel";
            flawResolveDateLabel.Size = new System.Drawing.Size(47, 16);
            flawResolveDateLabel.TabIndex = 3;
            flawResolveDateLabel.Text = "解除日:";
            // 
            // flawReasonLabel
            // 
            flawReasonLabel.AutoSize = true;
            flawReasonLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            flawReasonLabel.BackgroundStyle.Class = "";
            flawReasonLabel.Location = new System.Drawing.Point(23, 59);
            flawReasonLabel.Name = "flawReasonLabel";
            flawReasonLabel.Size = new System.Drawing.Size(59, 16);
            flawReasonLabel.TabIndex = 1;
            flawReasonLabel.Text = "瑕疵原因:";
            // 
            // groupPanelFlawResolve
            // 
            this.groupPanelFlawResolve.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelFlawResolve.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelFlawResolve.Controls.Add(this.btnFlawClose);
            this.groupPanelFlawResolve.Controls.Add(this.btnFlawSave);
            this.groupPanelFlawResolve.Controls.Add(this.btnFlawResolve);
            this.groupPanelFlawResolve.Controls.Add(flawResolveReasonLabel);
            this.groupPanelFlawResolve.Controls.Add(this.tbFlawResolveReason);
            this.groupPanelFlawResolve.Controls.Add(flawResolveUserNameLabel);
            this.groupPanelFlawResolve.Controls.Add(this.flawResolveDateDateTimePicker);
            this.groupPanelFlawResolve.Controls.Add(this.flawResolveUserNameTextBox);
            this.groupPanelFlawResolve.Controls.Add(flawResolveDateLabel);
            this.groupPanelFlawResolve.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelFlawResolve.Location = new System.Drawing.Point(0, 139);
            this.groupPanelFlawResolve.Name = "groupPanelFlawResolve";
            this.groupPanelFlawResolve.Size = new System.Drawing.Size(577, 144);
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
            this.groupPanelFlawResolve.TabIndex = 3;
            // 
            // btnFlawClose
            // 
            this.btnFlawClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFlawClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFlawClose.Location = new System.Drawing.Point(282, 111);
            this.btnFlawClose.Name = "btnFlawClose";
            this.btnFlawClose.Size = new System.Drawing.Size(75, 23);
            this.btnFlawClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFlawClose.TabIndex = 8;
            this.btnFlawClose.Text = "关闭";
            this.btnFlawClose.Click += new System.EventHandler(this.CloseFlaw);
            // 
            // btnFlawSave
            // 
            this.btnFlawSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFlawSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFlawSave.Location = new System.Drawing.Point(200, 111);
            this.btnFlawSave.Name = "btnFlawSave";
            this.btnFlawSave.Size = new System.Drawing.Size(75, 23);
            this.btnFlawSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFlawSave.TabIndex = 7;
            this.btnFlawSave.Text = "保存";
            this.btnFlawSave.Click += new System.EventHandler(this.SaveFlaw);
            // 
            // btnFlawResolve
            // 
            this.btnFlawResolve.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFlawResolve.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFlawResolve.Location = new System.Drawing.Point(15, 6);
            this.btnFlawResolve.Name = "btnFlawResolve";
            this.btnFlawResolve.Size = new System.Drawing.Size(75, 23);
            this.btnFlawResolve.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFlawResolve.TabIndex = 0;
            this.btnFlawResolve.Text = "瑕疵解除";
            this.btnFlawResolve.Click += new System.EventHandler(this.ResolveFlaw);
            // 
            // tbFlawResolveReason
            // 
            // 
            // 
            // 
            this.tbFlawResolveReason.Border.Class = "TextBoxBorder";
            this.tbFlawResolveReason.Location = new System.Drawing.Point(105, 2);
            this.tbFlawResolveReason.Multiline = true;
            this.tbFlawResolveReason.Name = "tbFlawResolveReason";
            this.tbFlawResolveReason.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbFlawResolveReason.Size = new System.Drawing.Size(434, 79);
            this.tbFlawResolveReason.TabIndex = 2;
            // 
            // flawResolveDateDateTimePicker
            // 
            // 
            // 
            // 
            this.flawResolveDateDateTimePicker.BackgroundStyle.Class = "DateTimeInputBackground";
            this.flawResolveDateDateTimePicker.ButtonDropDown.Visible = true;
            this.flawResolveDateDateTimePicker.Enabled = false;
            this.flawResolveDateDateTimePicker.Location = new System.Drawing.Point(156, 84);
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
            this.flawResolveDateDateTimePicker.TabIndex = 4;
            // 
            // flawResolveUserNameTextBox
            // 
            // 
            // 
            // 
            this.flawResolveUserNameTextBox.Border.Class = "TextBoxBorder";
            this.flawResolveUserNameTextBox.Enabled = false;
            this.flawResolveUserNameTextBox.Location = new System.Drawing.Point(324, 84);
            this.flawResolveUserNameTextBox.Name = "flawResolveUserNameTextBox";
            this.flawResolveUserNameTextBox.Size = new System.Drawing.Size(100, 20);
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
            this.groupPanelFlaw.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelFlaw.Location = new System.Drawing.Point(0, 0);
            this.groupPanelFlaw.Name = "groupPanelFlaw";
            this.groupPanelFlaw.Size = new System.Drawing.Size(577, 139);
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
            this.groupPanelFlaw.TabIndex = 2;
            // 
            // isFlawCheckBox
            // 
            this.isFlawCheckBox.AutoSize = true;
            this.isFlawCheckBox.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.isFlawCheckBox.BackgroundStyle.Class = "";
            this.isFlawCheckBox.Location = new System.Drawing.Point(15, 7);
            this.isFlawCheckBox.Name = "isFlawCheckBox";
            this.isFlawCheckBox.Size = new System.Drawing.Size(76, 16);
            this.isFlawCheckBox.TabIndex = 6;
            this.isFlawCheckBox.Text = "是否瑕疵";
            // 
            // btnFlaw
            // 
            this.btnFlaw.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFlaw.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFlaw.Location = new System.Drawing.Point(15, 29);
            this.btnFlaw.Name = "btnFlaw";
            this.btnFlaw.Size = new System.Drawing.Size(75, 23);
            this.btnFlaw.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
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
            this.tbFlawReason.Enabled = false;
            this.tbFlawReason.Location = new System.Drawing.Point(344, 3);
            this.tbFlawReason.Multiline = true;
            this.tbFlawReason.Name = "tbFlawReason";
            this.tbFlawReason.Size = new System.Drawing.Size(195, 123);
            this.tbFlawReason.TabIndex = 3;
            this.tbFlawReason.WatermarkText = "其他原因";
            // 
            // flawReasonCheckedListBox
            // 
            this.flawReasonCheckedListBox.CheckOnClick = true;
            this.flawReasonCheckedListBox.Enabled = false;
            this.flawReasonCheckedListBox.FormattingEnabled = true;
            this.flawReasonCheckedListBox.Location = new System.Drawing.Point(105, 2);
            this.flawReasonCheckedListBox.Name = "flawReasonCheckedListBox";
            this.flawReasonCheckedListBox.Size = new System.Drawing.Size(233, 124);
            this.flawReasonCheckedListBox.TabIndex = 2;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToOrderColumns = true;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colInvoiceCurrency,
            this.colInvoiceAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvInvoices.Location = new System.Drawing.Point(0, 283);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.Size = new System.Drawing.Size(577, 116);
            this.dgvInvoices.TabIndex = 4;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.DataPropertyName = "InvoiceNo";
            this.colInvoiceNo.HeaderText = "发票号";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.ReadOnly = true;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.DataPropertyName = "InvoiceDate";
            this.colInvoiceDate.HeaderText = "发票日";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.ReadOnly = true;
            // 
            // colInvoiceCurrency
            // 
            this.colInvoiceCurrency.DataPropertyName = "InvoiceCurrency";
            this.colInvoiceCurrency.HeaderText = "发票币别";
            this.colInvoiceCurrency.Name = "colInvoiceCurrency";
            this.colInvoiceCurrency.ReadOnly = true;
            // 
            // colInvoiceAmount
            // 
            this.colInvoiceAmount.DataPropertyName = "InvoiceAmount";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.colInvoiceAmount.DefaultCellStyle = dataGridViewCellStyle1;
            this.colInvoiceAmount.HeaderText = "发票金额";
            this.colInvoiceAmount.Name = "colInvoiceAmount";
            this.colInvoiceAmount.ReadOnly = true;
            // 
            // InvoiceFlaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 399);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.groupPanelFlawResolve);
            this.Controls.Add(this.groupPanelFlaw);
            this.DoubleBuffered = true;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "InvoiceFlaw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "瑕疵处理";
            this.groupPanelFlawResolve.ResumeLayout(false);
            this.groupPanelFlawResolve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flawResolveDateDateTimePicker)).EndInit();
            this.groupPanelFlaw.ResumeLayout(false);
            this.groupPanelFlaw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
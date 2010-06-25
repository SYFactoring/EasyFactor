//-----------------------------------------------------------------------
// <copyright file="DepartmentMgr.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.InfoMgr.DepartmentMgr
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DepartmentMgr
    {
		#region?Fields?(37)?

        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.ButtonX btnReset;
        private System.Windows.Forms.ContextMenuStrip cmuDeptMgr;
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDepts;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diBegin;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diEnd;
        private DevComponents.DotNetBar.LabelX lblCount;
        private DevComponents.DotNetBar.LabelX lblDate;
        private DevComponents.DotNetBar.LabelX lblDepartmentName;
        private DevComponents.DotNetBar.LabelX lblManager;
        private DevComponents.DotNetBar.LabelX lblPManager;
        private System.Windows.Forms.ToolStripMenuItem menuItemDepartmentDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemDepartmentNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemDetail;
        private System.Windows.Forms.ToolStripMenuItem menuItemSelect;
        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.Controls.TextBoxX tbDepartmentName;
        private DevComponents.DotNetBar.Controls.TextBoxX tbManager;
        private DevComponents.DotNetBar.Controls.TextBoxX tbPManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.tbManager = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblManager = new DevComponents.DotNetBar.LabelX();
            this.tbPManager = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPManager = new DevComponents.DotNetBar.LabelX();
            this.lblDate = new DevComponents.DotNetBar.LabelX();
            this.diEnd = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.diBegin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnReset = new DevComponents.DotNetBar.ButtonX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.tbDepartmentName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDepartmentName = new DevComponents.DotNetBar.LabelX();
            this.dgvDepts = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colLocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetInterestIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarginIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuDeptMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemDepartmentNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDepartmentDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepts)).BeginInit();
            this.cmuDeptMgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.tbManager);
            this.panelQuery.Controls.Add(this.lblManager);
            this.panelQuery.Controls.Add(this.tbPManager);
            this.panelQuery.Controls.Add(this.lblPManager);
            this.panelQuery.Controls.Add(this.lblDate);
            this.panelQuery.Controls.Add(this.diEnd);
            this.panelQuery.Controls.Add(this.diBegin);
            this.panelQuery.Controls.Add(this.btnReset);
            this.panelQuery.Controls.Add(this.lblCount);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Controls.Add(this.tbDepartmentName);
            this.panelQuery.Controls.Add(this.lblDepartmentName);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(772, 51);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 0;
            // 
            // tbManager
            // 
            // 
            // 
            // 
            this.tbManager.Border.Class = "TextBoxBorder";
            this.tbManager.Location = new System.Drawing.Point(72, 26);
            this.tbManager.Name = "tbManager";
            this.tbManager.Size = new System.Drawing.Size(100, 20);
            this.tbManager.TabIndex = 3;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            // 
            // 
            // 
            this.lblManager.BackgroundStyle.Class = "";
            this.lblManager.Location = new System.Drawing.Point(3, 27);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(68, 16);
            this.lblManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblManager.TabIndex = 2;
            this.lblManager.Text = "�ֲ�������";
            // 
            // tbPManager
            // 
            // 
            // 
            // 
            this.tbPManager.Border.Class = "TextBoxBorder";
            this.tbPManager.Location = new System.Drawing.Point(72, 3);
            this.tbPManager.Name = "tbPManager";
            this.tbPManager.Size = new System.Drawing.Size(100, 20);
            this.tbPManager.TabIndex = 1;
            // 
            // lblPManager
            // 
            this.lblPManager.AutoSize = true;
            // 
            // 
            // 
            this.lblPManager.BackgroundStyle.Class = "";
            this.lblPManager.Location = new System.Drawing.Point(3, 5);
            this.lblPManager.Name = "lblPManager";
            this.lblPManager.Size = new System.Drawing.Size(68, 16);
            this.lblPManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblPManager.TabIndex = 0;
            this.lblPManager.Text = "�ܲ�������";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.Class = "";
            this.lblDate.Location = new System.Drawing.Point(187, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "��ѯ����";
            // 
            // diEnd
            // 
            // 
            // 
            // 
            this.diEnd.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diEnd.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diEnd.ButtonDropDown.Visible = true;
            this.diEnd.ButtonFreeText.Checked = true;
            this.diEnd.FreeTextEntryMode = true;
            this.diEnd.Location = new System.Drawing.Point(349, 4);
            // 
            // 
            // 
            this.diEnd.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diEnd.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diEnd.MonthCalendar.BackgroundStyle.Class = "";
            this.diEnd.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.diEnd.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diEnd.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diEnd.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diEnd.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diEnd.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diEnd.MonthCalendar.TodayButtonVisible = true;
            this.diEnd.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diEnd.Name = "diEnd";
            this.diEnd.Size = new System.Drawing.Size(100, 20);
            this.diEnd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diEnd.TabIndex = 6;
            // 
            // diBegin
            // 
            // 
            // 
            // 
            this.diBegin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diBegin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diBegin.ButtonDropDown.Visible = true;
            this.diBegin.ButtonFreeText.Checked = true;
            this.diBegin.FreeTextEntryMode = true;
            this.diBegin.Location = new System.Drawing.Point(243, 4);
            // 
            // 
            // 
            this.diBegin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diBegin.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diBegin.MonthCalendar.BackgroundStyle.Class = "";
            this.diBegin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.diBegin.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diBegin.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diBegin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diBegin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diBegin.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diBegin.MonthCalendar.TodayButtonVisible = true;
            this.diBegin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diBegin.Name = "diBegin";
            this.diBegin.Size = new System.Drawing.Size(100, 20);
            this.diBegin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diBegin.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReset.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReset.Location = new System.Drawing.Point(508, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(42, 23);
            this.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "����";
            this.btnReset.Click += new System.EventHandler(this.Reset);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.Location = new System.Drawing.Point(556, 7);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(71, 16);
            this.lblCount.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "��� ����¼";
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(459, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(43, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 9;
            this.btnQuery.Text = "��ѯ";
            this.btnQuery.Click += new System.EventHandler(this.Query);
            // 
            // tbDepartmentName
            // 
            // 
            // 
            // 
            this.tbDepartmentName.Border.Class = "TextBoxBorder";
            this.tbDepartmentName.Location = new System.Drawing.Point(243, 26);
            this.tbDepartmentName.Name = "tbDepartmentName";
            this.tbDepartmentName.Size = new System.Drawing.Size(100, 20);
            this.tbDepartmentName.TabIndex = 8;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            // 
            // 
            // 
            this.lblDepartmentName.BackgroundStyle.Class = "";
            this.lblDepartmentName.Location = new System.Drawing.Point(187, 27);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(56, 16);
            this.lblDepartmentName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lblDepartmentName.TabIndex = 7;
            this.lblDepartmentName.Text = "�ֲ�����";
            // 
            // dgvDepts
            // 
            this.dgvDepts.AllowUserToAddRows = false;
            this.dgvDepts.AllowUserToDeleteRows = false;
            this.dgvDepts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLocationName,
            this.colDepartmentCode,
            this.colDepartmentName,
            this.colDomain,
            this.colPManager,
            this.colAssistant,
            this.colManager,
            this.colContact,
            this.colAssignAmount,
            this.colFinanceAmount,
            this.colCommissionIncome,
            this.colNetInterestIncome,
            this.colMarginIncome,
            this.colTotalIncome});
            this.dgvDepts.ContextMenuStrip = this.cmuDeptMgr;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDepts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDepts.Location = new System.Drawing.Point(0, 51);
            this.dgvDepts.Name = "dgvDepts";
            this.dgvDepts.ReadOnly = true;
            this.dgvDepts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDepts.Size = new System.Drawing.Size(772, 409);
            this.dgvDepts.TabIndex = 0;
            this.dgvDepts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dgvDepts.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvDeptsRowPostPaint);
            // 
            // colLocationName
            // 
            this.colLocationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLocationName.DataPropertyName = "LocationName";
            this.colLocationName.HeaderText = "����";
            this.colLocationName.Name = "colLocationName";
            this.colLocationName.ReadOnly = true;
            // 
            // colDepartmentCode
            // 
            this.colDepartmentCode.DataPropertyName = "DepartmentCode";
            this.colDepartmentCode.HeaderText = "���Ŵ���";
            this.colDepartmentCode.Name = "colDepartmentCode";
            this.colDepartmentCode.ReadOnly = true;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepartmentName.DataPropertyName = "DepartmentName";
            this.colDepartmentName.HeaderText = "��������";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.ReadOnly = true;
            // 
            // colDomain
            // 
            this.colDomain.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDomain.DataPropertyName = "Domain";
            this.colDomain.HeaderText = "��ҵ��";
            this.colDomain.Name = "colDomain";
            this.colDomain.ReadOnly = true;
            // 
            // colPManager
            // 
            this.colPManager.DataPropertyName = "PManager";
            this.colPManager.HeaderText = "��������";
            this.colPManager.Name = "colPManager";
            this.colPManager.ReadOnly = true;
            // 
            // colAssistant
            // 
            this.colAssistant.DataPropertyName = "Assistant";
            this.colAssistant.HeaderText = "��Ʒ��������";
            this.colAssistant.Name = "colAssistant";
            this.colAssistant.ReadOnly = true;
            // 
            // colManager
            // 
            this.colManager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colManager.DataPropertyName = "Manager";
            this.colManager.HeaderText = "�ֲ�������";
            this.colManager.Name = "colManager";
            this.colManager.ReadOnly = true;
            // 
            // colContact
            // 
            this.colContact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContact.DataPropertyName = "Contact_1";
            this.colContact.HeaderText = "�ֲ���ϵ��";
            this.colContact.Name = "colContact";
            this.colContact.ReadOnly = true;
            // 
            // colAssignAmount
            // 
            this.colAssignAmount.DataPropertyName = "AssignAmountByDate";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colAssignAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.colAssignAmount.HeaderText = "ת����";
            this.colAssignAmount.Name = "colAssignAmount";
            this.colAssignAmount.ReadOnly = true;
            this.colAssignAmount.Visible = false;
            // 
            // colFinanceAmount
            // 
            this.colFinanceAmount.DataPropertyName = "FinanceAmountByDate";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.colFinanceAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.colFinanceAmount.HeaderText = "������";
            this.colFinanceAmount.Name = "colFinanceAmount";
            this.colFinanceAmount.ReadOnly = true;
            this.colFinanceAmount.Visible = false;
            // 
            // colCommissionIncome
            // 
            this.colCommissionIncome.DataPropertyName = "CommissionIncomeByDate";
            dataGridViewCellStyle4.Format = "N2";
            this.colCommissionIncome.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCommissionIncome.HeaderText = "���������";
            this.colCommissionIncome.Name = "colCommissionIncome";
            this.colCommissionIncome.ReadOnly = true;
            this.colCommissionIncome.Visible = false;
            // 
            // colNetInterestIncome
            // 
            this.colNetInterestIncome.DataPropertyName = "NetInterestIncomeByDate";
            dataGridViewCellStyle5.Format = "N2";
            this.colNetInterestIncome.DefaultCellStyle = dataGridViewCellStyle5;
            this.colNetInterestIncome.HeaderText = "����Ϣ����";
            this.colNetInterestIncome.Name = "colNetInterestIncome";
            this.colNetInterestIncome.ReadOnly = true;
            this.colNetInterestIncome.Visible = false;
            // 
            // colMarginIncome
            // 
            this.colMarginIncome.DataPropertyName = "MarginIncomeByDate";
            dataGridViewCellStyle6.Format = "N2";
            this.colMarginIncome.DefaultCellStyle = dataGridViewCellStyle6;
            this.colMarginIncome.HeaderText = "������������";
            this.colMarginIncome.Name = "colMarginIncome";
            this.colMarginIncome.ReadOnly = true;
            this.colMarginIncome.Visible = false;
            // 
            // colTotalIncome
            // 
            this.colTotalIncome.DataPropertyName = "TotalIncomeByDate";
            dataGridViewCellStyle7.Format = "N2";
            this.colTotalIncome.DefaultCellStyle = dataGridViewCellStyle7;
            this.colTotalIncome.HeaderText = "������";
            this.colTotalIncome.Name = "colTotalIncome";
            this.colTotalIncome.ReadOnly = true;
            this.colTotalIncome.Visible = false;
            // 
            // cmuDeptMgr
            // 
            this.cmuDeptMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDetail,
            this.menuItemSelect,
            this.toolStripSeparator1,
            this.menuItemDepartmentNew,
            this.menuItemDepartmentDelete});
            this.cmuDeptMgr.Name = "cmuDeptMgr";
            this.cmuDeptMgr.Size = new System.Drawing.Size(123, 98);
            // 
            // menuItemDetail
            // 
            this.menuItemDetail.Name = "menuItemDetail";
            this.menuItemDetail.Size = new System.Drawing.Size(122, 22);
            this.menuItemDetail.Text = "��ϸ��Ϣ";
            this.menuItemDetail.Click += new System.EventHandler(this.Detail);
            // 
            // menuItemSelect
            // 
            this.menuItemSelect.Name = "menuItemSelect";
            this.menuItemSelect.Size = new System.Drawing.Size(122, 22);
            this.menuItemSelect.Text = "ѡ���ֲ�";
            this.menuItemSelect.Click += new System.EventHandler(this.Select);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // menuItemDepartmentNew
            // 
            this.menuItemDepartmentNew.Name = "menuItemDepartmentNew";
            this.menuItemDepartmentNew.Size = new System.Drawing.Size(122, 22);
            this.menuItemDepartmentNew.Text = "�½��ֲ�";
            this.menuItemDepartmentNew.Click += new System.EventHandler(this.NewDepartment);
            // 
            // menuItemDepartmentDelete
            // 
            this.menuItemDepartmentDelete.Name = "menuItemDepartmentDelete";
            this.menuItemDepartmentDelete.Size = new System.Drawing.Size(122, 22);
            this.menuItemDepartmentDelete.Text = "ɾ���ֲ�";
            this.menuItemDepartmentDelete.Click += new System.EventHandler(this.DeleteDepartment);
            // 
            // DepartmentMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDepts);
            this.Controls.Add(this.panelQuery);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "DepartmentMgr";
            this.Size = new System.Drawing.Size(772, 460);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diBegin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepts)).EndInit();
            this.cmuDeptMgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colLocationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDomain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetInterestIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarginIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalIncome;
    }
}

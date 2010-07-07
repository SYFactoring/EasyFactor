namespace CMBC.EasyFactor.InfoMgr.FactorMgr
{
    partial class CommissionReport
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
            this.panelQuery = new DevComponents.DotNetBar.PanelEx();
            this.btnQuery = new DevComponents.DotNetBar.ButtonX();
            this.lblDate = new DevComponents.DotNetBar.LabelX();
            this.diMonth = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.panelQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuery
            // 
            this.panelQuery.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelQuery.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelQuery.Controls.Add(this.lblDate);
            this.panelQuery.Controls.Add(this.diMonth);
            this.panelQuery.Controls.Add(this.btnQuery);
            this.panelQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuery.Location = new System.Drawing.Point(0, 0);
            this.panelQuery.Name = "panelQuery";
            this.panelQuery.Size = new System.Drawing.Size(652, 30);
            this.panelQuery.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelQuery.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelQuery.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelQuery.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelQuery.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelQuery.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelQuery.Style.GradientAngle = 90;
            this.panelQuery.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnQuery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnQuery.Location = new System.Drawing.Point(171, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(67, 23);
            this.btnQuery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "生成报表";
            this.btnQuery.Click += new System.EventHandler(this.StatCommissionReport);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.Class = "";
            this.lblDate.Location = new System.Drawing.Point(3, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 16);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "查询月份";
            // 
            // diMonth
            // 
            // 
            // 
            // 
            this.diMonth.BackgroundStyle.Class = "DateTimeInputBackground";
            this.diMonth.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.diMonth.ButtonDropDown.Visible = true;
            this.diMonth.Location = new System.Drawing.Point(65, 3);
            // 
            // 
            // 
            this.diMonth.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diMonth.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.diMonth.MonthCalendar.BackgroundStyle.Class = "";
            this.diMonth.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.diMonth.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.diMonth.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.diMonth.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.diMonth.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.diMonth.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.diMonth.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.diMonth.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.diMonth.MonthCalendar.DisplayMonth = new System.DateTime(2009, 12, 1, 0, 0, 0, 0);
            this.diMonth.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.diMonth.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.diMonth.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.diMonth.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.diMonth.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.diMonth.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.diMonth.MonthCalendar.TodayButtonVisible = true;
            this.diMonth.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.diMonth.Name = "diMonth";
            this.diMonth.Size = new System.Drawing.Size(100, 20);
            this.diMonth.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.diMonth.TabIndex = 10;
            // 
            // CommissionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelQuery);
            this.Name = "CommissionReport";
            this.Size = new System.Drawing.Size(652, 268);
            this.panelQuery.ResumeLayout(false);
            this.panelQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelQuery;
        private DevComponents.DotNetBar.ButtonX btnQuery;
        private DevComponents.DotNetBar.LabelX lblDate;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput diMonth;
    }
}

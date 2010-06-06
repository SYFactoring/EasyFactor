//-----------------------------------------------------------------------
// <copyright file="ImportForm.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnFileSelect;
        private DevComponents.DotNetBar.ButtonX btnStart;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.LabelX lblFilePath;
        private DevComponents.DotNetBar.LabelX lblProgress;
        private DevComponents.DotNetBar.LabelX lblStatus;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBar;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFilePath;
        private DevComponents.DotNetBar.Controls.TextBoxX tbStatus;
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

            if (this._context != null)
            {
                this._context.Dispose();
            }

            base.Dispose(disposing);
        }
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFilePath = new DevComponents.DotNetBar.LabelX();
            this.lblStatus = new DevComponents.DotNetBar.LabelX();
            this.progressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.lblProgress = new DevComponents.DotNetBar.LabelX();
            this.tbStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbFilePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnFileSelect = new DevComponents.DotNetBar.ButtonX();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblFilePath.BackgroundStyle.Class = "";
            this.lblFilePath.Location = new System.Drawing.Point(12, 12);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(59, 16);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "文件路径:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblStatus.BackgroundStyle.Class = "";
            this.lblStatus.Location = new System.Drawing.Point(37, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(34, 16);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "状态:";
            // 
            // progressBar
            // 
            // 
            // 
            // 
            this.progressBar.BackgroundStyle.Class = "";
            this.progressBar.Location = new System.Drawing.Point(77, 56);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(266, 23);
            this.progressBar.TabIndex = 6;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblProgress.BackgroundStyle.Class = "";
            this.lblProgress.Location = new System.Drawing.Point(12, 56);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(59, 16);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "导入进度:";
            // 
            // tbStatus
            // 
            // 
            // 
            // 
            this.tbStatus.Border.Class = "TextBoxBorder";
            this.tbStatus.Location = new System.Drawing.Point(77, 32);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(266, 20);
            this.tbStatus.TabIndex = 4;
            // 
            // tbFilePath
            // 
            // 
            // 
            // 
            this.tbFilePath.Border.Class = "TextBoxBorder";
            this.tbFilePath.Location = new System.Drawing.Point(77, 8);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(266, 20);
            this.tbFilePath.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Location = new System.Drawing.Point(178, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "开始";
            this.btnStart.Click += new System.EventHandler(this.StartImport);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(268, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "关闭";
            this.btnCancel.Click += new System.EventHandler(this.CancelImport);
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFileSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFileSelect.Location = new System.Drawing.Point(349, 8);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(24, 23);
            this.btnFileSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFileSelect.TabIndex = 2;
            this.btnFileSelect.Text = "...";
            this.btnFileSelect.Click += new System.EventHandler(this.SelectFile);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 112);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblFilePath);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据导入";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
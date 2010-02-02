//-----------------------------------------------------------------------
// <copyright file="ExportForm.Designer.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CMBC.EasyFactor.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ExportForm
    {
        #region Fields (7)

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.ComponentModel.IContainer components = null;
        private DevComponents.DotNetBar.LabelX lblProgress;
        private DevComponents.DotNetBar.LabelX lblStatus;
        private DevComponents.DotNetBar.Controls.ProgressBarX progressBar;
        private DevComponents.DotNetBar.Controls.TextBoxX tbStatus;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.tbStatus = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblProgress = new DevComponents.DotNetBar.LabelX();
            this.progressBar = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.lblStatus = new DevComponents.DotNetBar.LabelX();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.btnFileSelect = new DevComponents.DotNetBar.ButtonX();
            this.tbFilePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblFilePath = new DevComponents.DotNetBar.LabelX();
            this.btnStart = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(268, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "关闭";
            this.btnCancel.Click += new System.EventHandler(this.CancelExport);
            // 
            // tbStatus
            // 
            // 
            // 
            // 
            this.tbStatus.Border.Class = "TextBoxBorder";
            this.tbStatus.Location = new System.Drawing.Point(77, 29);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.Size = new System.Drawing.Size(266, 20);
            this.tbStatus.TabIndex = 13;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblProgress.BackgroundStyle.Class = "";
            this.lblProgress.Location = new System.Drawing.Point(12, 57);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(59, 16);
            this.lblProgress.TabIndex = 14;
            this.lblProgress.Text = "导出进度:";
            // 
            // progressBar
            // 
            // 
            // 
            // 
            this.progressBar.BackgroundStyle.Class = "";
            this.progressBar.Location = new System.Drawing.Point(77, 53);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(266, 23);
            this.progressBar.TabIndex = 15;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblStatus.BackgroundStyle.Class = "";
            this.lblStatus.Location = new System.Drawing.Point(37, 31);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(34, 16);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "状态:";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFileSelect.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFileSelect.Enabled = false;
            this.btnFileSelect.Location = new System.Drawing.Point(349, 3);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(24, 23);
            this.btnFileSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFileSelect.TabIndex = 20;
            this.btnFileSelect.Text = "...";
            this.btnFileSelect.Click += new System.EventHandler(this.SelectFile);
            // 
            // tbFilePath
            // 
            // 
            // 
            // 
            this.tbFilePath.Border.Class = "TextBoxBorder";
            this.tbFilePath.Location = new System.Drawing.Point(77, 3);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.ReadOnly = true;
            this.tbFilePath.Size = new System.Drawing.Size(266, 20);
            this.tbFilePath.TabIndex = 19;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblFilePath.BackgroundStyle.Class = "";
            this.lblFilePath.Location = new System.Drawing.Point(12, 7);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(59, 16);
            this.lblFilePath.TabIndex = 18;
            this.lblFilePath.Text = "文件路径:";
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnStart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnStart.Location = new System.Drawing.Point(187, 82);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnStart.TabIndex = 21;
            this.btnStart.Text = "开始";
            this.btnStart.Click += new System.EventHandler(this.StartExport);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 112);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnFileSelect);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblStatus);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ExportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据导出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnFileSelect;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFilePath;
        private DevComponents.DotNetBar.LabelX lblFilePath;
        private DevComponents.DotNetBar.ButtonX btnStart;
    }
}
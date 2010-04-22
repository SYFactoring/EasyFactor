namespace CMBC.EasyFactor.Help
{
    using System.Windows.Forms;
    using DevComponents.DotNetBar;
    using DevComponents.DotNetBar.Controls;
    using System;

    /// <summary>
    /// Summary description for Confirm.
    /// </summary>
    public class ConfirmForm : DevComponents.DotNetBar.Office2007Form
    {
		#region Fields (8) 

        private AutoUpdater autoUpdater;
        private ButtonX btnYes;
        private ButtonX btnNo;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private LabelX lblInformation;
        private LabelX lblUpdate;
        private TextBoxX latestChangesTextBox;
        private LinkLabel lblSVNStat;

		#endregion Fields 

		#region Constructors (1) 

        public ConfirmForm(AutoUpdater autoUpdater)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            this.autoUpdater = autoUpdater;
        }

		#endregion Constructors 

		#region Methods (5) 

		// Protected Methods (1) 

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
		// Private Methods (4) 

        private void ClickYes(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void ClickNo(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void Confirm_Activated(object sender, System.EventArgs e)
        {
            this.latestChangesTextBox.Text = this.autoUpdater.LatestConfigChanges;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VisitSVNStat(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.lblSVNStat.LinkVisited = true;
                System.Diagnostics.Process.Start("http://homepage.fudan.edu.cn/~yimingliu/EasyFactoring/index.html");
            }
            catch (Exception )
            {
                MessageBoxEx.Show("打开浏览器失败");
            }
        }

		#endregion Methods 



        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInformation = new DevComponents.DotNetBar.LabelX();
            this.lblUpdate = new DevComponents.DotNetBar.LabelX();
            this.latestChangesTextBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnYes = new DevComponents.DotNetBar.ButtonX();
            this.btnNo = new DevComponents.DotNetBar.ButtonX();
            this.lblSVNStat = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblInformation.BackgroundStyle.Class = "";
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(26, 21);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(230, 16);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = "新版本已下载本地，是否执行更新程序？";
            this.lblInformation.WordWrap = true;
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblUpdate.BackgroundStyle.Class = "";
            this.lblUpdate.Location = new System.Drawing.Point(26, 77);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(68, 16);
            this.lblUpdate.TabIndex = 2;
            this.lblUpdate.Text = "最新更新：";
            // 
            // latestChangesTextBox
            // 
            // 
            // 
            // 
            this.latestChangesTextBox.Border.Class = "";
            this.latestChangesTextBox.Location = new System.Drawing.Point(26, 99);
            this.latestChangesTextBox.Multiline = true;
            this.latestChangesTextBox.Name = "latestChangesTextBox";
            this.latestChangesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.latestChangesTextBox.Size = new System.Drawing.Size(221, 74);
            this.latestChangesTextBox.TabIndex = 3;
            // 
            // btnYes
            // 
            this.btnYes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnYes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnYes.Location = new System.Drawing.Point(51, 193);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes";
            this.btnYes.Click += new System.EventHandler(this.ClickYes);
            // 
            // btnNo
            // 
            this.btnNo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNo.Location = new System.Drawing.Point(132, 193);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "No";
            this.btnNo.Click += new System.EventHandler(this.ClickNo);
            // 
            // lblSVNStat
            // 
            this.lblSVNStat.AutoSize = true;
            this.lblSVNStat.Location = new System.Drawing.Point(23, 50);
            this.lblSVNStat.Name = "lblSVNStat";
            this.lblSVNStat.Size = new System.Drawing.Size(79, 13);
            this.lblSVNStat.TabIndex = 1;
            this.lblSVNStat.TabStop = true;
            this.lblSVNStat.Text = "项目进展统计";
            this.lblSVNStat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VisitSVNStat);
            // 
            // ConfirmForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(274, 232);
            this.Controls.Add(this.lblSVNStat);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.latestChangesTextBox);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblInformation);
            this.DoubleBuffered = true;
            this.Name = "ConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "是否确认";
            this.Activated += new System.EventHandler(this.Confirm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}

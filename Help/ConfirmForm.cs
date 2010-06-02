//-----------------------------------------------------------------------
// <copyright file="ConfirmForm.cs" company="Yiming Liu@Fudan">
//     Copyright (c) CMBC. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace CMBC.EasyFactor.Help
{
    /// <summary>
    /// Summary description for Confirm.
    /// </summary>
    public class ConfirmForm : Office2007Form
    {
        private readonly AutoUpdater _autoUpdater;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private ButtonX _btnNo;
        private ButtonX _btnYes;
        private LabelX _lblInformation;
        private LinkLabel _lblSVNStat;
        private WebBrowser _webBrowser;


        public ConfirmForm(AutoUpdater autoUpdater)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            _autoUpdater = autoUpdater;
        }

        //?Private?Methods?(4)?
        private void ClickNo(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void ClickYes(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void Confirm_Activated(object sender, EventArgs e)
        {
            _webBrowser.Navigate(_autoUpdater.AutoUpdateConfig.ChangeLogURL);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _lblInformation = new LabelX();
            _btnYes = new ButtonX();
            _btnNo = new ButtonX();
            _lblSVNStat = new LinkLabel();
            _webBrowser = new WebBrowser();
            SuspendLayout();
            // 
            // lblInformation
            // 
            _lblInformation.AutoSize = true;
            _lblInformation.BackColor = Color.Transparent;
            // 
            // 
            // 
            _lblInformation.BackgroundStyle.Class = "";
            _lblInformation.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((0)));
            _lblInformation.Location = new Point(26, 17);
            _lblInformation.Name = "_lblInformation";
            _lblInformation.Size = new Size(230, 16);
            _lblInformation.TabIndex = 0;
            _lblInformation.Text = @"新版本已下载本地，是否执行更新程序？";
            _lblInformation.WordWrap = true;
            // 
            // btnYes
            // 
            _btnYes.AccessibleRole = AccessibleRole.PushButton;
            _btnYes.Anchor = ((((AnchorStyles.Top | AnchorStyles.Bottom)
                               | AnchorStyles.Left)));
            _btnYes.ColorTable = eButtonColor.OrangeWithBackground;
            _btnYes.Location = new Point(51, 202);
            _btnYes.Name = "_btnYes";
            _btnYes.Size = new Size(75, 23);
            _btnYes.Style = eDotNetBarStyle.StyleManagerControlled;
            _btnYes.TabIndex = 4;
            _btnYes.Text = @"Yes";
            _btnYes.Click += ClickYes;
            // 
            // btnNo
            // 
            _btnNo.AccessibleRole = AccessibleRole.PushButton;
            _btnNo.Anchor = ((((AnchorStyles.Top | AnchorStyles.Bottom)
                              | AnchorStyles.Left)));
            _btnNo.ColorTable = eButtonColor.OrangeWithBackground;
            _btnNo.Location = new Point(132, 202);
            _btnNo.Name = "_btnNo";
            _btnNo.Size = new Size(75, 23);
            _btnNo.Style = eDotNetBarStyle.StyleManagerControlled;
            _btnNo.TabIndex = 5;
            _btnNo.Text = @"No";
            _btnNo.Click += ClickNo;
            // 
            // lblSVNStat
            // 
            _lblSVNStat.AutoSize = true;
            _lblSVNStat.Location = new Point(23, 43);
            _lblSVNStat.Name = "_lblSVNStat";
            _lblSVNStat.Size = new Size(79, 13);
            _lblSVNStat.TabIndex = 1;
            _lblSVNStat.TabStop = true;
            _lblSVNStat.Text = @"项目进展统计";
            _lblSVNStat.LinkClicked += VisitSVNStat;
            // 
            // webBrowser
            // 
            _webBrowser.Anchor = ((((AnchorStyles.Top | AnchorStyles.Bottom)
                                   | AnchorStyles.Left)));
            _webBrowser.Location = new Point(26, 67);
            _webBrowser.MinimumSize = new Size(20, 20);
            _webBrowser.Name = "_webBrowser";
            _webBrowser.Size = new Size(236, 129);
            _webBrowser.TabIndex = 6;
            // 
            // ConfirmForm
            // 
            AutoScaleBaseSize = new Size(5, 13);
            ClientSize = new Size(274, 232);
            Controls.Add(_webBrowser);
            Controls.Add(_lblSVNStat);
            Controls.Add(_btnNo);
            Controls.Add(_btnYes);
            Controls.Add(_lblInformation);
            DoubleBuffered = true;
            Name = "ConfirmForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = @"是否确认";
            Activated += Confirm_Activated;
            ResumeLayout(false);
            PerformLayout();
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
                _lblSVNStat.LinkVisited = true;
                Process.Start("http://homepage.fudan.edu.cn/~yimingliu/EasyFactoring/index.html");
            }
            catch (Exception)
            {
                MessageBoxEx.Show("打开浏览器失败");
            }
        }
    }
}
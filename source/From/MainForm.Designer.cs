
namespace MusicUnblock
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProxyMessage = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.MakeMin = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.UseText = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.PortPlease = new System.Windows.Forms.Label();
            this.PortInput = new System.Windows.Forms.TextBox();
            this.MinIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IconMax = new System.Windows.Forms.ToolStripMenuItem();
            this.IconExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.LinkLabel();
            this.ToSetting = new System.Windows.Forms.LinkLabel();
            this.UseLink = new System.Windows.Forms.LinkLabel();
            this.IconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProxyMessage
            // 
            this.ProxyMessage.Location = new System.Drawing.Point(147, 67);
            this.ProxyMessage.Multiline = true;
            this.ProxyMessage.Name = "ProxyMessage";
            this.ProxyMessage.ReadOnly = true;
            this.ProxyMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ProxyMessage.Size = new System.Drawing.Size(301, 163);
            this.ProxyMessage.TabIndex = 0;
            this.ProxyMessage.TabStop = false;
            this.ProxyMessage.Text = "代理未运行。";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 67);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(123, 52);
            this.Start.TabIndex = 1;
            this.Start.Text = "开启代理";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // MakeMin
            // 
            this.MakeMin.Location = new System.Drawing.Point(12, 122);
            this.MakeMin.Name = "MakeMin";
            this.MakeMin.Size = new System.Drawing.Size(123, 52);
            this.MakeMin.TabIndex = 2;
            this.MakeMin.Text = "最小化到托盘";
            this.MakeMin.UseVisualStyleBackColor = true;
            this.MakeMin.Click += new System.EventHandler(this.MakeMin_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 178);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(123, 52);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UseText
            // 
            this.UseText.Location = new System.Drawing.Point(14, 22);
            this.UseText.Multiline = true;
            this.UseText.Name = "UseText";
            this.UseText.ReadOnly = true;
            this.UseText.Size = new System.Drawing.Size(434, 39);
            this.UseText.TabIndex = 5;
            this.UseText.Visible = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(12, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(187, 15);
            this.Title.TabIndex = 6;
            this.Title.Text = "网易云音乐本地代理解锁器";
            // 
            // PortPlease
            // 
            this.PortPlease.AutoSize = true;
            this.PortPlease.Location = new System.Drawing.Point(15, 34);
            this.PortPlease.Name = "PortPlease";
            this.PortPlease.Size = new System.Drawing.Size(419, 15);
            this.PortPlease.TabIndex = 7;
            this.PortPlease.Text = "未运行，请设置代理端口：         (正常使用默认511即可)";
            // 
            // PortInput
            // 
            this.PortInput.Location = new System.Drawing.Point(207, 29);
            this.PortInput.MaxLength = 5;
            this.PortInput.Name = "PortInput";
            this.PortInput.Size = new System.Drawing.Size(57, 25);
            this.PortInput.TabIndex = 0;
            this.PortInput.TabStop = false;
            this.PortInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortInput.WordWrap = false;
            // 
            // MinIcon
            // 
            this.MinIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MinIcon.BalloonTipText = "网易云音乐解锁代理程序已切换到后台运行，双击托盘图标即可恢复";
            this.MinIcon.BalloonTipTitle = "提示";
            this.MinIcon.ContextMenuStrip = this.IconMenu;
            this.MinIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MinIcon.Icon")));
            this.MinIcon.Text = "网易云音乐解锁代理";
            this.MinIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MinIcon_MouseDoubleClick);
            // 
            // IconMenu
            // 
            this.IconMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.IconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconMax,
            this.IconExit});
            this.IconMenu.Name = "IconMenu";
            this.IconMenu.ShowItemToolTips = false;
            this.IconMenu.Size = new System.Drawing.Size(109, 52);
            // 
            // IconMax
            // 
            this.IconMax.Name = "IconMax";
            this.IconMax.Size = new System.Drawing.Size(108, 24);
            this.IconMax.Text = "显示";
            this.IconMax.Click += new System.EventHandler(this.IconMax_Click);
            // 
            // IconExit
            // 
            this.IconExit.Name = "IconExit";
            this.IconExit.Size = new System.Drawing.Size(108, 24);
            this.IconExit.Text = "退出";
            this.IconExit.Click += new System.EventHandler(this.IconExit_Click);
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(305, 5);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(67, 15);
            this.Info.TabIndex = 8;
            this.Info.TabStop = true;
            this.Info.Text = "版权说明";
            this.Info.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Info_LinkClicked);
            // 
            // ToSetting
            // 
            this.ToSetting.AutoSize = true;
            this.ToSetting.Location = new System.Drawing.Point(378, 5);
            this.ToSetting.Name = "ToSetting";
            this.ToSetting.Size = new System.Drawing.Size(67, 15);
            this.ToSetting.TabIndex = 9;
            this.ToSetting.TabStop = true;
            this.ToSetting.Text = "软件设置";
            this.ToSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToSetting_LinkClicked);
            // 
            // UseLink
            // 
            this.UseLink.AutoSize = true;
            this.UseLink.Location = new System.Drawing.Point(232, 5);
            this.UseLink.Name = "UseLink";
            this.UseLink.Size = new System.Drawing.Size(67, 15);
            this.UseLink.TabIndex = 10;
            this.UseLink.TabStop = true;
            this.UseLink.Text = "图片教程";
            this.UseLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UseLink_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 242);
            this.Controls.Add(this.UseLink);
            this.Controls.Add(this.UseText);
            this.Controls.Add(this.ToSetting);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.PortInput);
            this.Controls.Add(this.PortPlease);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.MakeMin);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.ProxyMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "网易云音乐解锁代理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.IconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ProxyMessage;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button MakeMin;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox UseText;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label PortPlease;
        private System.Windows.Forms.TextBox PortInput;
        private System.Windows.Forms.NotifyIcon MinIcon;
        private System.Windows.Forms.LinkLabel Info;
        private System.Windows.Forms.LinkLabel ToSetting;
        private System.Windows.Forms.ContextMenuStrip IconMenu;
        private System.Windows.Forms.ToolStripMenuItem IconExit;
        private System.Windows.Forms.ToolStripMenuItem IconMax;
        private System.Windows.Forms.LinkLabel UseLink;
    }
}


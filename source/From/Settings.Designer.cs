
namespace MusicUnblock
{
    partial class Settings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Exit = new System.Windows.Forms.Button();
            this.SelfStart = new System.Windows.Forms.CheckBox();
            this.AutoRun = new System.Windows.Forms.CheckBox();
            this.PhoneSetting = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(31, 90);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(122, 32);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "保存";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // SelfStart
            // 
            this.SelfStart.AutoSize = true;
            this.SelfStart.Location = new System.Drawing.Point(5, 12);
            this.SelfStart.Name = "SelfStart";
            this.SelfStart.Size = new System.Drawing.Size(157, 19);
            this.SelfStart.TabIndex = 1;
            this.SelfStart.Text = "开机启动+托盘启动";
            this.SelfStart.UseVisualStyleBackColor = true;
            // 
            // AutoRun
            // 
            this.AutoRun.AutoSize = true;
            this.AutoRun.Location = new System.Drawing.Point(5, 38);
            this.AutoRun.Name = "AutoRun";
            this.AutoRun.Size = new System.Drawing.Size(164, 19);
            this.AutoRun.TabIndex = 2;
            this.AutoRun.Text = "启动后自动开始代理";
            this.AutoRun.UseVisualStyleBackColor = true;
            // 
            // PhoneSetting
            // 
            this.PhoneSetting.AutoSize = true;
            this.PhoneSetting.Location = new System.Drawing.Point(43, 66);
            this.PhoneSetting.Name = "PhoneSetting";
            this.PhoneSetting.Size = new System.Drawing.Size(97, 15);
            this.PhoneSetting.TabIndex = 10;
            this.PhoneSetting.TabStop = true;
            this.PhoneSetting.Text = "手机代理设置";
            this.PhoneSetting.Visible = false;
            this.PhoneSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PhoneSetting_LinkClicked);
            // 
            // Settings
            // 
            this.AcceptButton = this.Exit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 132);
            this.Controls.Add(this.PhoneSetting);
            this.Controls.Add(this.AutoRun);
            this.Controls.Add(this.SelfStart);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox SelfStart;
        private System.Windows.Forms.CheckBox AutoRun;
        private System.Windows.Forms.LinkLabel PhoneSetting;
    }
}
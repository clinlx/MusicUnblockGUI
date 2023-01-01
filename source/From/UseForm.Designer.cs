
namespace MusicUnblock
{
    partial class UseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseForm));
            this.UsePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsePic)).BeginInit();
            this.SuspendLayout();
            // 
            // UsePic
            // 
            this.UsePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UsePic.Image = global::MusicUnblock.Properties.Resources.use;
            this.UsePic.Location = new System.Drawing.Point(0, -1);
            this.UsePic.Name = "UsePic";
            this.UsePic.Size = new System.Drawing.Size(797, 555);
            this.UsePic.TabIndex = 0;
            this.UsePic.TabStop = false;
            // 
            // UseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 555);
            this.Controls.Add(this.UsePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UseForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "图片教程";
            this.Load += new System.EventHandler(this.UseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UsePic;
    }
}
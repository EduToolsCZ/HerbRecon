namespace HerbRecon
{
    partial class MainForm
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lab_status = new System.Windows.Forms.Label();
            this.pic_spinner = new System.Windows.Forms.PictureBox();
            this.lab_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_spinner)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo
            // 
            this.pic_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(0, 0);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(284, 234);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // lab_status
            // 
            this.lab_status.AutoSize = true;
            this.lab_status.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_status.Location = new System.Drawing.Point(36, 244);
            this.lab_status.Name = "lab_status";
            this.lab_status.Size = new System.Drawing.Size(56, 13);
            this.lab_status.TabIndex = 1;
            this.lab_status.Text = "Loading...";
            // 
            // pic_spinner
            // 
            this.pic_spinner.Image = ((System.Drawing.Image)(resources.GetObject("pic_spinner.Image")));
            this.pic_spinner.Location = new System.Drawing.Point(1, 234);
            this.pic_spinner.Name = "pic_spinner";
            this.pic_spinner.Size = new System.Drawing.Size(31, 32);
            this.pic_spinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_spinner.TabIndex = 2;
            this.pic_spinner.TabStop = false;
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lab_title.Location = new System.Drawing.Point(257, 9);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(21, 210);
            this.lab_title.TabIndex = 3;
            this.lab_title.Text = "H\r\ne\r\nr\r\nb\r\n\r\nR\r\ne\r\nc\r\no\r\nn";
            this.lab_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(284, 266);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.pic_spinner);
            this.Controls.Add(this.lab_status);
            this.Controls.Add(this.pic_logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HerbRecon loading";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_spinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lab_status;
        private System.Windows.Forms.PictureBox pic_spinner;
        private System.Windows.Forms.Label lab_title;
    }
}
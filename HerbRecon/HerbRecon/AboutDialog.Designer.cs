namespace HerbRecon
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.but_viewLicense = new System.Windows.Forms.Button();
            this.lab_version = new System.Windows.Forms.Label();
            this.but_visitProject = new System.Windows.Forms.Button();
            this.pic_easter = new System.Windows.Forms.PictureBox();
            this.but_donate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_easter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 208);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // but_viewLicense
            // 
            this.but_viewLicense.Location = new System.Drawing.Point(127, 218);
            this.but_viewLicense.Name = "but_viewLicense";
            this.but_viewLicense.Size = new System.Drawing.Size(98, 23);
            this.but_viewLicense.TabIndex = 2;
            this.but_viewLicense.Text = "View full license";
            this.but_viewLicense.UseVisualStyleBackColor = true;
            this.but_viewLicense.Click += new System.EventHandler(this.but_viewLicense_Click);
            // 
            // lab_version
            // 
            this.lab_version.AutoSize = true;
            this.lab_version.Location = new System.Drawing.Point(12, 9);
            this.lab_version.Name = "lab_version";
            this.lab_version.Size = new System.Drawing.Size(131, 13);
            this.lab_version.TabIndex = 3;
            this.lab_version.Text = "HerbRecon version x.x.x.x";
            // 
            // but_visitProject
            // 
            this.but_visitProject.Location = new System.Drawing.Point(12, 218);
            this.but_visitProject.Name = "but_visitProject";
            this.but_visitProject.Size = new System.Drawing.Size(109, 23);
            this.but_visitProject.TabIndex = 4;
            this.but_visitProject.Text = "Visit the project site";
            this.but_visitProject.UseVisualStyleBackColor = true;
            this.but_visitProject.Click += new System.EventHandler(this.but_visitProject_Click);
            // 
            // pic_easter
            // 
            this.pic_easter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_easter.Image = global::HerbRecon.Properties.Resources.get_out;
            this.pic_easter.InitialImage = global::HerbRecon.Properties.Resources.get_out;
            this.pic_easter.Location = new System.Drawing.Point(276, 223);
            this.pic_easter.Name = "pic_easter";
            this.pic_easter.Size = new System.Drawing.Size(130, 91);
            this.pic_easter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_easter.TabIndex = 1;
            this.pic_easter.TabStop = false;
            this.pic_easter.Click += new System.EventHandler(this.pic_easter_Click);
            // 
            // but_donate
            // 
            this.but_donate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_donate.Location = new System.Drawing.Point(231, 218);
            this.but_donate.Name = "but_donate";
            this.but_donate.Size = new System.Drawing.Size(56, 23);
            this.but_donate.TabIndex = 5;
            this.but_donate.Text = "Donate";
            this.but_donate.UseVisualStyleBackColor = true;
            this.but_donate.Click += new System.EventHandler(this.but_donate_Click);
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 308);
            this.Controls.Add(this.but_donate);
            this.Controls.Add(this.but_visitProject);
            this.Controls.Add(this.lab_version);
            this.Controls.Add(this.but_viewLicense);
            this.Controls.Add(this.pic_easter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "O Aplikaci";
            ((System.ComponentModel.ISupportInitialize)(this.pic_easter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_easter;
        private System.Windows.Forms.Button but_viewLicense;
        private System.Windows.Forms.Label lab_version;
        private System.Windows.Forms.Button but_visitProject;
        private System.Windows.Forms.Button but_donate;
    }
}
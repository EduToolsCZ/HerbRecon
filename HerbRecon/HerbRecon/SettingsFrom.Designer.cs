namespace HerbRecon
{
    partial class SettingsFrom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chck_updateHerbs = new System.Windows.Forms.CheckBox();
            this.but_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.link_issues = new System.Windows.Forms.LinkLabel();
            this.but_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chck_updateHerbs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spuštění";
            // 
            // chck_updateHerbs
            // 
            this.chck_updateHerbs.AutoSize = true;
            this.chck_updateHerbs.Location = new System.Drawing.Point(9, 21);
            this.chck_updateHerbs.Name = "chck_updateHerbs";
            this.chck_updateHerbs.Size = new System.Drawing.Size(153, 17);
            this.chck_updateHerbs.TabIndex = 0;
            this.chck_updateHerbs.Text = "Aktualizovat seznam rostlin";
            this.chck_updateHerbs.UseVisualStyleBackColor = true;
            // 
            // but_ok
            // 
            this.but_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_ok.Location = new System.Drawing.Point(243, 90);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(59, 23);
            this.but_ok.TabIndex = 1;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Více možností bude přidáno v dalších verzích.\r\nPokud máte nápad na nezbytné nasta" +
    "vení,\r\nnapište návrh do ";
            // 
            // link_issues
            // 
            this.link_issues.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.link_issues.AutoSize = true;
            this.link_issues.BackColor = System.Drawing.SystemColors.Control;
            this.link_issues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.link_issues.Location = new System.Drawing.Point(92, 100);
            this.link_issues.Name = "link_issues";
            this.link_issues.Size = new System.Drawing.Size(39, 13);
            this.link_issues.TabIndex = 3;
            this.link_issues.TabStop = true;
            this.link_issues.Text = "issues.";
            this.link_issues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.link_issues.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_issues_LinkClicked);
            // 
            // but_cancel
            // 
            this.but_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_cancel.Location = new System.Drawing.Point(308, 90);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(59, 23);
            this.but_cancel.TabIndex = 4;
            this.but_cancel.Text = "Zrušit";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // SettingsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 125);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.link_issues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsFrom";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nastavení";
            this.Load += new System.EventHandler(this.SettingsFrom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chck_updateHerbs;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_issues;
        private System.Windows.Forms.Button but_cancel;
    }
}
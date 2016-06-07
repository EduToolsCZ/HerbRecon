namespace HerbRecon
{
    partial class MenuForm
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
            this.but_start = new System.Windows.Forms.Button();
            this.but_options = new System.Windows.Forms.Button();
            this.but_about = new System.Windows.Forms.Button();
            this.but_exit = new System.Windows.Forms.Button();
            this.lab_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_start
            // 
            this.but_start.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_start.Location = new System.Drawing.Point(12, 12);
            this.but_start.Name = "but_start";
            this.but_start.Size = new System.Drawing.Size(194, 51);
            this.but_start.TabIndex = 0;
            this.but_start.Text = "Start";
            this.but_start.UseVisualStyleBackColor = true;
            this.but_start.Click += new System.EventHandler(this.but_start_Click);
            // 
            // but_options
            // 
            this.but_options.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_options.Location = new System.Drawing.Point(12, 69);
            this.but_options.Name = "but_options";
            this.but_options.Size = new System.Drawing.Size(194, 51);
            this.but_options.TabIndex = 1;
            this.but_options.Text = "Nastavení";
            this.but_options.UseVisualStyleBackColor = true;
            this.but_options.Click += new System.EventHandler(this.but_options_Click);
            // 
            // but_about
            // 
            this.but_about.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_about.Location = new System.Drawing.Point(12, 126);
            this.but_about.Name = "but_about";
            this.but_about.Size = new System.Drawing.Size(194, 51);
            this.but_about.TabIndex = 2;
            this.but_about.Text = "O aplikaci";
            this.but_about.UseVisualStyleBackColor = true;
            this.but_about.Click += new System.EventHandler(this.but_about_Click);
            // 
            // but_exit
            // 
            this.but_exit.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_exit.Location = new System.Drawing.Point(12, 183);
            this.but_exit.Name = "but_exit";
            this.but_exit.Size = new System.Drawing.Size(194, 51);
            this.but_exit.TabIndex = 3;
            this.but_exit.Text = "Konec";
            this.but_exit.UseVisualStyleBackColor = true;
            this.but_exit.Click += new System.EventHandler(this.but_exit_Click);
            // 
            // lab_title
            // 
            this.lab_title.AutoSize = true;
            this.lab_title.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lab_title.Location = new System.Drawing.Point(213, 18);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(21, 210);
            this.lab_title.TabIndex = 4;
            this.lab_title.Text = "H\r\ne\r\nr\r\nb\r\n\r\nR\r\ne\r\nc\r\no\r\nn";
            this.lab_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 246);
            this.Controls.Add(this.lab_title);
            this.Controls.Add(this.but_exit);
            this.Controls.Add(this.but_about);
            this.Controls.Add(this.but_options);
            this.Controls.Add(this.but_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HerbRecon menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_start;
        private System.Windows.Forms.Button but_options;
        private System.Windows.Forms.Button but_about;
        private System.Windows.Forms.Button but_exit;
        private System.Windows.Forms.Label lab_title;
    }
}
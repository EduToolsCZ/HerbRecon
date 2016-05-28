namespace HerbRecon
{
    partial class TestStartForm
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
            this.but_ok = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.list_notTested = new System.Windows.Forms.ListBox();
            this.list_tested = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_add = new System.Windows.Forms.Button();
            this.but_moveAll = new System.Windows.Forms.Button();
            this.but_remove = new System.Windows.Forms.Button();
            this.but_removeAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_ok
            // 
            this.but_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_ok.Location = new System.Drawing.Point(299, 286);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(75, 23);
            this.but_ok.TabIndex = 0;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_cancel.Location = new System.Drawing.Point(218, 286);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(75, 23);
            this.but_cancel.TabIndex = 1;
            this.but_cancel.Text = "Zrušit";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.but_removeAll);
            this.groupBox1.Controls.Add(this.but_remove);
            this.groupBox1.Controls.Add(this.but_moveAll);
            this.groupBox1.Controls.Add(this.but_add);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.list_tested);
            this.groupBox1.Controls.Add(this.list_notTested);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Výběr rostlin";
            // 
            // list_notTested
            // 
            this.list_notTested.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_notTested.FormattingEnabled = true;
            this.list_notTested.Items.AddRange(new object[] {
            "???"});
            this.list_notTested.Location = new System.Drawing.Point(6, 31);
            this.list_notTested.Name = "list_notTested";
            this.list_notTested.Size = new System.Drawing.Size(152, 212);
            this.list_notTested.TabIndex = 0;
            // 
            // list_tested
            // 
            this.list_tested.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_tested.FormattingEnabled = true;
            this.list_tested.Items.AddRange(new object[] {
            "???"});
            this.list_tested.Location = new System.Drawing.Point(202, 31);
            this.list_tested.Name = "list_tested";
            this.list_tested.Size = new System.Drawing.Size(154, 212);
            this.list_tested.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vynechané";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zkoušené";
            // 
            // but_add
            // 
            this.but_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_add.Location = new System.Drawing.Point(164, 31);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(32, 23);
            this.but_add.TabIndex = 4;
            this.but_add.Text = ">";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_moveAll
            // 
            this.but_moveAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_moveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_moveAll.Location = new System.Drawing.Point(164, 89);
            this.but_moveAll.Name = "but_moveAll";
            this.but_moveAll.Size = new System.Drawing.Size(32, 23);
            this.but_moveAll.TabIndex = 5;
            this.but_moveAll.Text = ">>";
            this.but_moveAll.UseVisualStyleBackColor = true;
            this.but_moveAll.Click += new System.EventHandler(this.but_moveAll_Click);
            // 
            // but_remove
            // 
            this.but_remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_remove.Location = new System.Drawing.Point(164, 60);
            this.but_remove.Name = "but_remove";
            this.but_remove.Size = new System.Drawing.Size(32, 23);
            this.but_remove.TabIndex = 6;
            this.but_remove.Text = "<";
            this.but_remove.UseVisualStyleBackColor = true;
            this.but_remove.Click += new System.EventHandler(this.but_remove_Click);
            // 
            // but_removeAll
            // 
            this.but_removeAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.but_removeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_removeAll.Location = new System.Drawing.Point(164, 118);
            this.but_removeAll.Name = "but_removeAll";
            this.but_removeAll.Size = new System.Drawing.Size(32, 23);
            this.but_removeAll.TabIndex = 7;
            this.but_removeAll.Text = "<<";
            this.but_removeAll.UseVisualStyleBackColor = true;
            this.but_removeAll.Click += new System.EventHandler(this.but_removeAll_Click);
            // 
            // TestStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TestStartForm";
            this.ShowIcon = false;
            this.Text = "Start test";
            this.Load += new System.EventHandler(this.TestStartForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_removeAll;
        private System.Windows.Forms.Button but_remove;
        private System.Windows.Forms.Button but_moveAll;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_tested;
        private System.Windows.Forms.ListBox list_notTested;
    }
}
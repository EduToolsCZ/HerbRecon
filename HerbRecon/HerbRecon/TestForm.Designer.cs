namespace HerbRecon
{
    partial class TestForm
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
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.combo_family = new System.Windows.Forms.ComboBox();
            this.pic_herb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_latinName = new System.Windows.Forms.Label();
            this.lab_wholeName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_herb)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_answer
            // 
            this.txt_answer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_answer.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_answer.Location = new System.Drawing.Point(12, 444);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(760, 50);
            this.txt_answer.TabIndex = 1;
            this.txt_answer.Text = "sedmikráska";
            this.txt_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_answer_KeyDown);
            // 
            // combo_family
            // 
            this.combo_family.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_family.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_family.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_family.Font = new System.Drawing.Font("Arial", 27F);
            this.combo_family.FormattingEnabled = true;
            this.combo_family.Location = new System.Drawing.Point(12, 500);
            this.combo_family.Name = "combo_family";
            this.combo_family.Size = new System.Drawing.Size(469, 49);
            this.combo_family.TabIndex = 2;
            this.combo_family.Text = "hvězdnicovité";
            this.combo_family.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_answer_KeyDown);
            // 
            // pic_herb
            // 
            this.pic_herb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_herb.Location = new System.Drawing.Point(0, 0);
            this.pic_herb.Name = "pic_herb";
            this.pic_herb.Size = new System.Drawing.Size(784, 381);
            this.pic_herb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_herb.TabIndex = 0;
            this.pic_herb.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Po zapsání odpovědi stiskněte ENTER\r\nPo zkontrolování správné odpovědi stiskněte " +
    "také ENTER";
            // 
            // lab_latinName
            // 
            this.lab_latinName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_latinName.AutoSize = true;
            this.lab_latinName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lab_latinName.Location = new System.Drawing.Point(8, 393);
            this.lab_latinName.Name = "lab_latinName";
            this.lab_latinName.Size = new System.Drawing.Size(89, 19);
            this.lab_latinName.TabIndex = 4;
            this.lab_latinName.Text = "Latin name";
            // 
            // lab_wholeName
            // 
            this.lab_wholeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lab_wholeName.AutoSize = true;
            this.lab_wholeName.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_wholeName.Location = new System.Drawing.Point(8, 412);
            this.lab_wholeName.Name = "lab_wholeName";
            this.lab_wholeName.Size = new System.Drawing.Size(174, 19);
            this.lab_wholeName.TabIndex = 5;
            this.lab_wholeName.Text = "sedmikráska chudobka";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lab_wholeName);
            this.Controls.Add(this.lab_latinName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_family);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.pic_herb);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TestForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_answer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_herb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_herb;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.ComboBox combo_family;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_latinName;
        private System.Windows.Forms.Label lab_wholeName;
    }
}
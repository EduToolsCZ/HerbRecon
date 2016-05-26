namespace HerbReconListMaker
{
    partial class HerbChecker
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
            this.picture_herb = new System.Windows.Forms.PictureBox();
            this.txt_genus = new System.Windows.Forms.TextBox();
            this.txt_species = new System.Windows.Forms.TextBox();
            this.txt_family = new System.Windows.Forms.TextBox();
            this.txt_latinName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.but_saveAndNext = new System.Windows.Forms.Button();
            this.but_discardChanges = new System.Windows.Forms.Button();
            this.but_deleteHerb = new System.Windows.Forms.Button();
            this.but_nextImage = new System.Windows.Forms.Button();
            this.but_prevImage = new System.Windows.Forms.Button();
            this.but_removeImage = new System.Windows.Forms.Button();
            this.but_addImage = new System.Windows.Forms.Button();
            this.txt_imageUrl = new System.Windows.Forms.TextBox();
            this.but_saveAndClose = new System.Windows.Forms.Button();
            this.combo_herb = new System.Windows.Forms.ComboBox();
            this.but_goToHerb = new System.Windows.Forms.Button();
            this.but_loadOnlyMissing = new System.Windows.Forms.Button();
            this.but_reloadAll = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_herb)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_herb
            // 
            this.picture_herb.Dock = System.Windows.Forms.DockStyle.Top;
            this.picture_herb.Location = new System.Drawing.Point(0, 0);
            this.picture_herb.Name = "picture_herb";
            this.picture_herb.Size = new System.Drawing.Size(710, 431);
            this.picture_herb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_herb.TabIndex = 0;
            this.picture_herb.TabStop = false;
            // 
            // txt_genus
            // 
            this.txt_genus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_genus.Location = new System.Drawing.Point(73, 462);
            this.txt_genus.Name = "txt_genus";
            this.txt_genus.Size = new System.Drawing.Size(166, 22);
            this.txt_genus.TabIndex = 1;
            // 
            // txt_species
            // 
            this.txt_species.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_species.Location = new System.Drawing.Point(73, 488);
            this.txt_species.Name = "txt_species";
            this.txt_species.Size = new System.Drawing.Size(166, 22);
            this.txt_species.TabIndex = 2;
            // 
            // txt_family
            // 
            this.txt_family.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_family.Location = new System.Drawing.Point(73, 514);
            this.txt_family.Name = "txt_family";
            this.txt_family.Size = new System.Drawing.Size(166, 22);
            this.txt_family.TabIndex = 3;
            // 
            // txt_latinName
            // 
            this.txt_latinName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_latinName.Location = new System.Drawing.Point(73, 540);
            this.txt_latinName.Name = "txt_latinName";
            this.txt_latinName.Size = new System.Drawing.Size(166, 22);
            this.txt_latinName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Genus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Latin Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Family";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Species";
            // 
            // but_saveAndNext
            // 
            this.but_saveAndNext.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_saveAndNext.Location = new System.Drawing.Point(12, 585);
            this.but_saveAndNext.Name = "but_saveAndNext";
            this.but_saveAndNext.Size = new System.Drawing.Size(92, 23);
            this.but_saveAndNext.TabIndex = 5;
            this.but_saveAndNext.Text = "Save and next";
            this.but_saveAndNext.UseVisualStyleBackColor = true;
            this.but_saveAndNext.Click += new System.EventHandler(this.but_saveAndNext_Click);
            // 
            // but_discardChanges
            // 
            this.but_discardChanges.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_discardChanges.Location = new System.Drawing.Point(110, 585);
            this.but_discardChanges.Name = "but_discardChanges";
            this.but_discardChanges.Size = new System.Drawing.Size(105, 23);
            this.but_discardChanges.TabIndex = 0;
            this.but_discardChanges.TabStop = false;
            this.but_discardChanges.Text = "Discard Changes";
            this.but_discardChanges.UseVisualStyleBackColor = true;
            this.but_discardChanges.Click += new System.EventHandler(this.but_discardChanges_Click);
            // 
            // but_deleteHerb
            // 
            this.but_deleteHerb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_deleteHerb.Location = new System.Drawing.Point(221, 585);
            this.but_deleteHerb.Name = "but_deleteHerb";
            this.but_deleteHerb.Size = new System.Drawing.Size(105, 23);
            this.but_deleteHerb.TabIndex = 0;
            this.but_deleteHerb.TabStop = false;
            this.but_deleteHerb.Text = "Delete Herb";
            this.but_deleteHerb.UseVisualStyleBackColor = true;
            this.but_deleteHerb.Click += new System.EventHandler(this.but_deleteHerb_Click);
            // 
            // but_nextImage
            // 
            this.but_nextImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.but_nextImage.Location = new System.Drawing.Point(623, 434);
            this.but_nextImage.Name = "but_nextImage";
            this.but_nextImage.Size = new System.Drawing.Size(75, 55);
            this.but_nextImage.TabIndex = 13;
            this.but_nextImage.TabStop = false;
            this.but_nextImage.Text = ">";
            this.but_nextImage.UseVisualStyleBackColor = true;
            // 
            // but_prevImage
            // 
            this.but_prevImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.but_prevImage.Location = new System.Drawing.Point(542, 434);
            this.but_prevImage.Name = "but_prevImage";
            this.but_prevImage.Size = new System.Drawing.Size(75, 55);
            this.but_prevImage.TabIndex = 14;
            this.but_prevImage.TabStop = false;
            this.but_prevImage.Text = "<";
            this.but_prevImage.UseVisualStyleBackColor = true;
            // 
            // but_removeImage
            // 
            this.but_removeImage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_removeImage.Location = new System.Drawing.Point(431, 434);
            this.but_removeImage.Name = "but_removeImage";
            this.but_removeImage.Size = new System.Drawing.Size(105, 24);
            this.but_removeImage.TabIndex = 15;
            this.but_removeImage.TabStop = false;
            this.but_removeImage.Text = "Remove Image";
            this.but_removeImage.UseVisualStyleBackColor = true;
            this.but_removeImage.Click += new System.EventHandler(this.but_removeImage_Click);
            // 
            // but_addImage
            // 
            this.but_addImage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_addImage.Location = new System.Drawing.Point(320, 434);
            this.but_addImage.Name = "but_addImage";
            this.but_addImage.Size = new System.Drawing.Size(105, 24);
            this.but_addImage.TabIndex = 16;
            this.but_addImage.TabStop = false;
            this.but_addImage.Text = "Add Image";
            this.but_addImage.UseVisualStyleBackColor = true;
            // 
            // txt_imageUrl
            // 
            this.txt_imageUrl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt_imageUrl.Location = new System.Drawing.Point(12, 434);
            this.txt_imageUrl.Name = "txt_imageUrl";
            this.txt_imageUrl.Size = new System.Drawing.Size(302, 22);
            this.txt_imageUrl.TabIndex = 5;
            this.txt_imageUrl.TabStop = false;
            // 
            // but_saveAndClose
            // 
            this.but_saveAndClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.but_saveAndClose.Location = new System.Drawing.Point(586, 585);
            this.but_saveAndClose.Name = "but_saveAndClose";
            this.but_saveAndClose.Size = new System.Drawing.Size(112, 23);
            this.but_saveAndClose.TabIndex = 18;
            this.but_saveAndClose.TabStop = false;
            this.but_saveAndClose.Text = "Save and close";
            this.but_saveAndClose.UseVisualStyleBackColor = true;
            this.but_saveAndClose.Click += new System.EventHandler(this.but_saveAndClose_Click);
            // 
            // combo_herb
            // 
            this.combo_herb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_herb.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.combo_herb.FormattingEnabled = true;
            this.combo_herb.Location = new System.Drawing.Point(351, 585);
            this.combo_herb.Name = "combo_herb";
            this.combo_herb.Size = new System.Drawing.Size(148, 21);
            this.combo_herb.TabIndex = 0;
            this.combo_herb.TabStop = false;
            // 
            // but_goToHerb
            // 
            this.but_goToHerb.Location = new System.Drawing.Point(505, 585);
            this.but_goToHerb.Name = "but_goToHerb";
            this.but_goToHerb.Size = new System.Drawing.Size(75, 23);
            this.but_goToHerb.TabIndex = 21;
            this.but_goToHerb.TabStop = false;
            this.but_goToHerb.Text = "Go to herb";
            this.but_goToHerb.UseVisualStyleBackColor = true;
            this.but_goToHerb.Click += new System.EventHandler(this.but_goToHerb_Click);
            // 
            // but_loadOnlyMissing
            // 
            this.but_loadOnlyMissing.Location = new System.Drawing.Point(586, 556);
            this.but_loadOnlyMissing.Name = "but_loadOnlyMissing";
            this.but_loadOnlyMissing.Size = new System.Drawing.Size(112, 23);
            this.but_loadOnlyMissing.TabIndex = 22;
            this.but_loadOnlyMissing.TabStop = false;
            this.but_loadOnlyMissing.Text = "Load only missing";
            this.but_loadOnlyMissing.UseVisualStyleBackColor = true;
            // 
            // but_reloadAll
            // 
            this.but_reloadAll.Location = new System.Drawing.Point(468, 556);
            this.but_reloadAll.Name = "but_reloadAll";
            this.but_reloadAll.Size = new System.Drawing.Size(112, 23);
            this.but_reloadAll.TabIndex = 23;
            this.but_reloadAll.TabStop = false;
            this.but_reloadAll.Text = "Reload all herbs";
            this.but_reloadAll.UseVisualStyleBackColor = true;
            this.but_reloadAll.Click += new System.EventHandler(this.but_reloadAll_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(425, 469);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(111, 20);
            this.txt_id.TabIndex = 24;
            this.txt_id.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(373, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Herb ID";
            // 
            // HerbChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 620);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.but_reloadAll);
            this.Controls.Add(this.but_loadOnlyMissing);
            this.Controls.Add(this.but_goToHerb);
            this.Controls.Add(this.combo_herb);
            this.Controls.Add(this.but_saveAndClose);
            this.Controls.Add(this.txt_imageUrl);
            this.Controls.Add(this.but_addImage);
            this.Controls.Add(this.but_removeImage);
            this.Controls.Add(this.but_prevImage);
            this.Controls.Add(this.but_nextImage);
            this.Controls.Add(this.but_deleteHerb);
            this.Controls.Add(this.but_discardChanges);
            this.Controls.Add(this.but_saveAndNext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_latinName);
            this.Controls.Add(this.txt_family);
            this.Controls.Add(this.txt_species);
            this.Controls.Add(this.txt_genus);
            this.Controls.Add(this.picture_herb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HerbChecker";
            this.ShowIcon = false;
            this.Text = "Herb Check";
            this.Load += new System.EventHandler(this.HerbChecker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_herb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_herb;
        private System.Windows.Forms.TextBox txt_genus;
        private System.Windows.Forms.TextBox txt_species;
        private System.Windows.Forms.TextBox txt_family;
        private System.Windows.Forms.TextBox txt_latinName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but_saveAndNext;
        private System.Windows.Forms.Button but_discardChanges;
        private System.Windows.Forms.Button but_deleteHerb;
        private System.Windows.Forms.Button but_nextImage;
        private System.Windows.Forms.Button but_prevImage;
        private System.Windows.Forms.Button but_removeImage;
        private System.Windows.Forms.Button but_addImage;
        private System.Windows.Forms.TextBox txt_imageUrl;
        private System.Windows.Forms.Button but_saveAndClose;
        private System.Windows.Forms.ComboBox combo_herb;
        private System.Windows.Forms.Button but_goToHerb;
        private System.Windows.Forms.Button but_loadOnlyMissing;
        private System.Windows.Forms.Button but_reloadAll;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
    }
}
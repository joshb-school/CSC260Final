namespace FinalProjectApp
{
    partial class FinalProjectForm
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.EditItemBtn = new System.Windows.Forms.Button();
            this.DeleteItemBtn = new System.Windows.Forms.Button();
            this.mediaTypesLbl = new System.Windows.Forms.Label();
            this.physicalMediaChk = new System.Windows.Forms.CheckBox();
            this.physicalMediaOtherItemsChk = new System.Windows.Forms.CheckBox();
            this.physicalMediaReadingChk = new System.Windows.Forms.CheckBox();
            this.physicalMediaTableGamesChk = new System.Windows.Forms.CheckBox();
            this.physicalMediaMusicChk = new System.Windows.Forms.CheckBox();
            this.physicalMediaVideoGamesChk = new System.Windows.Forms.CheckBox();
            this.otherItemsChk = new System.Windows.Forms.CheckBox();
            this.digitalMediaChk = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Lucida Console", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(84, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(1000, 47);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "~ Bailee and Josh\'s Media Library ~";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItemButton.Location = new System.Drawing.Point(57, 103);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(70, 34);
            this.AddItemButton.TabIndex = 1;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // EditItemBtn
            // 
            this.EditItemBtn.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditItemBtn.Location = new System.Drawing.Point(133, 103);
            this.EditItemBtn.Name = "EditItemBtn";
            this.EditItemBtn.Size = new System.Drawing.Size(85, 34);
            this.EditItemBtn.TabIndex = 3;
            this.EditItemBtn.Text = "Edit Selected Item";
            this.EditItemBtn.UseVisualStyleBackColor = true;
            this.EditItemBtn.Click += new System.EventHandler(this.EditItemBtn_Click);
            // 
            // DeleteItemBtn
            // 
            this.DeleteItemBtn.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItemBtn.Location = new System.Drawing.Point(224, 103);
            this.DeleteItemBtn.Name = "DeleteItemBtn";
            this.DeleteItemBtn.Size = new System.Drawing.Size(85, 34);
            this.DeleteItemBtn.TabIndex = 4;
            this.DeleteItemBtn.Text = "Delete Selected Item";
            this.DeleteItemBtn.UseVisualStyleBackColor = true;
            this.DeleteItemBtn.Click += new System.EventHandler(this.DeleteItemBtn_Click);
            // 
            // mediaTypesLbl
            // 
            this.mediaTypesLbl.AutoSize = true;
            this.mediaTypesLbl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaTypesLbl.Location = new System.Drawing.Point(977, 103);
            this.mediaTypesLbl.Name = "mediaTypesLbl";
            this.mediaTypesLbl.Size = new System.Drawing.Size(127, 16);
            this.mediaTypesLbl.TabIndex = 6;
            this.mediaTypesLbl.Text = "Media Types:";
            // 
            // physicalMediaChk
            // 
            this.physicalMediaChk.AutoSize = true;
            this.physicalMediaChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalMediaChk.Location = new System.Drawing.Point(980, 131);
            this.physicalMediaChk.Name = "physicalMediaChk";
            this.physicalMediaChk.Size = new System.Drawing.Size(122, 15);
            this.physicalMediaChk.TabIndex = 14;
            this.physicalMediaChk.Text = "Physical Media";
            this.physicalMediaChk.UseVisualStyleBackColor = true;
            // 
            // physicalMediaOtherItemsChk
            // 
            this.physicalMediaOtherItemsChk.AutoSize = true;
            this.physicalMediaOtherItemsChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalMediaOtherItemsChk.Location = new System.Drawing.Point(998, 236);
            this.physicalMediaOtherItemsChk.Name = "physicalMediaOtherItemsChk";
            this.physicalMediaOtherItemsChk.Size = new System.Drawing.Size(59, 15);
            this.physicalMediaOtherItemsChk.TabIndex = 15;
            this.physicalMediaOtherItemsChk.Text = "Other";
            this.physicalMediaOtherItemsChk.UseVisualStyleBackColor = true;
            // 
            // physicalMediaReadingChk
            // 
            this.physicalMediaReadingChk.AutoSize = true;
            this.physicalMediaReadingChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalMediaReadingChk.Location = new System.Drawing.Point(998, 215);
            this.physicalMediaReadingChk.Name = "physicalMediaReadingChk";
            this.physicalMediaReadingChk.Size = new System.Drawing.Size(73, 15);
            this.physicalMediaReadingChk.TabIndex = 16;
            this.physicalMediaReadingChk.Text = "Reading";
            this.physicalMediaReadingChk.UseVisualStyleBackColor = true;
            // 
            // physicalMediaTableGamesChk
            // 
            this.physicalMediaTableGamesChk.AutoSize = true;
            this.physicalMediaTableGamesChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalMediaTableGamesChk.Location = new System.Drawing.Point(998, 194);
            this.physicalMediaTableGamesChk.Name = "physicalMediaTableGamesChk";
            this.physicalMediaTableGamesChk.Size = new System.Drawing.Size(101, 15);
            this.physicalMediaTableGamesChk.TabIndex = 17;
            this.physicalMediaTableGamesChk.Text = "Table Games";
            this.physicalMediaTableGamesChk.UseVisualStyleBackColor = true;
            // 
            // physicalMediaMusicChk
            // 
            this.physicalMediaMusicChk.AutoSize = true;
            this.physicalMediaMusicChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalMediaMusicChk.Location = new System.Drawing.Point(998, 173);
            this.physicalMediaMusicChk.Name = "physicalMediaMusicChk";
            this.physicalMediaMusicChk.Size = new System.Drawing.Size(59, 15);
            this.physicalMediaMusicChk.TabIndex = 18;
            this.physicalMediaMusicChk.Text = "Music";
            this.physicalMediaMusicChk.UseVisualStyleBackColor = true;
            // 
            // physicalMediaVideoGamesChk
            // 
            this.physicalMediaVideoGamesChk.AutoSize = true;
            this.physicalMediaVideoGamesChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalMediaVideoGamesChk.Location = new System.Drawing.Point(998, 152);
            this.physicalMediaVideoGamesChk.Name = "physicalMediaVideoGamesChk";
            this.physicalMediaVideoGamesChk.Size = new System.Drawing.Size(101, 15);
            this.physicalMediaVideoGamesChk.TabIndex = 19;
            this.physicalMediaVideoGamesChk.Text = "Video Games";
            this.physicalMediaVideoGamesChk.UseVisualStyleBackColor = true;
            // 
            // otherItemsChk
            // 
            this.otherItemsChk.AutoSize = true;
            this.otherItemsChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherItemsChk.Location = new System.Drawing.Point(980, 386);
            this.otherItemsChk.Name = "otherItemsChk";
            this.otherItemsChk.Size = new System.Drawing.Size(101, 15);
            this.otherItemsChk.TabIndex = 20;
            this.otherItemsChk.Text = "Other Items";
            this.otherItemsChk.UseVisualStyleBackColor = true;
            // 
            // digitalMediaChk
            // 
            this.digitalMediaChk.AutoSize = true;
            this.digitalMediaChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalMediaChk.Location = new System.Drawing.Point(980, 303);
            this.digitalMediaChk.Name = "digitalMediaChk";
            this.digitalMediaChk.Size = new System.Drawing.Size(115, 15);
            this.digitalMediaChk.TabIndex = 21;
            this.digitalMediaChk.Text = "Digital Media";
            this.digitalMediaChk.UseVisualStyleBackColor = true;
            // 
            // FinalProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 672);
            this.Controls.Add(this.digitalMediaChk);
            this.Controls.Add(this.otherItemsChk);
            this.Controls.Add(this.physicalMediaVideoGamesChk);
            this.Controls.Add(this.physicalMediaMusicChk);
            this.Controls.Add(this.physicalMediaTableGamesChk);
            this.Controls.Add(this.physicalMediaReadingChk);
            this.Controls.Add(this.physicalMediaOtherItemsChk);
            this.Controls.Add(this.physicalMediaChk);
            this.Controls.Add(this.mediaTypesLbl);
            this.Controls.Add(this.DeleteItemBtn);
            this.Controls.Add(this.EditItemBtn);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.mainLabel);
            this.Name = "FinalProjectForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button EditItemBtn;
        private System.Windows.Forms.Button DeleteItemBtn;
        private System.Windows.Forms.Label mediaTypesLbl;
        private System.Windows.Forms.CheckBox physicalMediaChk;
        private System.Windows.Forms.CheckBox physicalMediaOtherItemsChk;
        private System.Windows.Forms.CheckBox physicalMediaReadingChk;
        private System.Windows.Forms.CheckBox physicalMediaTableGamesChk;
        private System.Windows.Forms.CheckBox physicalMediaMusicChk;
        private System.Windows.Forms.CheckBox physicalMediaVideoGamesChk;
        private System.Windows.Forms.CheckBox otherItemsChk;
        private System.Windows.Forms.CheckBox digitalMediaChk;
    }
}


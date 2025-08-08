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
            this.addItemDropdown = new System.Windows.Forms.ComboBox();
            this.addItemSelectLbl = new System.Windows.Forms.Label();
            this.userInputPromptLbl = new System.Windows.Forms.Label();
            this.userInputTxtBox = new System.Windows.Forms.TextBox();
            this.userInputLbl = new System.Windows.Forms.Label();
            this.enterUserInputBtn = new System.Windows.Forms.Button();
            this.physicalMediaWatchingChk = new System.Windows.Forms.CheckBox();
            this.digitalMediaVideoGamesChk = new System.Windows.Forms.CheckBox();
            this.digitalMediaMusicChk = new System.Windows.Forms.CheckBox();
            this.digitalMediaWatchingChk = new System.Windows.Forms.CheckBox();
            this.digitalMediaSoftwareChk = new System.Windows.Forms.CheckBox();
            this.digitalMediaOtherChk = new System.Windows.Forms.CheckBox();
            this.otherMiscChk = new System.Windows.Forms.CheckBox();
            this.otherMediaAccessoriesChk = new System.Windows.Forms.CheckBox();
            this.otherVideoGameAccessoriesChk = new System.Windows.Forms.CheckBox();
            this.otherConsolesAndPlayersChk = new System.Windows.Forms.CheckBox();
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
            this.AddItemButton.Location = new System.Drawing.Point(202, 103);
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
            this.EditItemBtn.Location = new System.Drawing.Point(278, 103);
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
            this.DeleteItemBtn.Location = new System.Drawing.Point(369, 103);
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
            this.mediaTypesLbl.Click += new System.EventHandler(this.mediaTypesLbl_Click);
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
            this.physicalMediaOtherItemsChk.Location = new System.Drawing.Point(998, 257);
            this.physicalMediaOtherItemsChk.Name = "physicalMediaOtherItemsChk";
            this.physicalMediaOtherItemsChk.Size = new System.Drawing.Size(122, 15);
            this.physicalMediaOtherItemsChk.TabIndex = 15;
            this.physicalMediaOtherItemsChk.Text = "Other Physical";
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
            this.physicalMediaMusicChk.Location = new System.Drawing.Point(998, 174);
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
            this.otherItemsChk.Location = new System.Drawing.Point(980, 442);
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
            this.digitalMediaChk.Location = new System.Drawing.Point(980, 295);
            this.digitalMediaChk.Name = "digitalMediaChk";
            this.digitalMediaChk.Size = new System.Drawing.Size(115, 15);
            this.digitalMediaChk.TabIndex = 21;
            this.digitalMediaChk.Text = "Digital Media";
            this.digitalMediaChk.UseVisualStyleBackColor = true;
            // 
            // addItemDropdown
            // 
            this.addItemDropdown.FormattingEnabled = true;
            this.addItemDropdown.Items.AddRange(new object[] {
            "Physical Video Game",
            "Physical Music",
            "Physical Table Game",
            "Physical Reading",
            "Other Physical Media"});
            this.addItemDropdown.Location = new System.Drawing.Point(24, 110);
            this.addItemDropdown.Name = "addItemDropdown";
            this.addItemDropdown.Size = new System.Drawing.Size(171, 21);
            this.addItemDropdown.TabIndex = 22;
            this.addItemDropdown.SelectedIndexChanged += new System.EventHandler(this.addItemDropdown_SelectedIndexChanged);
            // 
            // addItemSelectLbl
            // 
            this.addItemSelectLbl.AutoSize = true;
            this.addItemSelectLbl.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemSelectLbl.Location = new System.Drawing.Point(22, 96);
            this.addItemSelectLbl.Name = "addItemSelectLbl";
            this.addItemSelectLbl.Size = new System.Drawing.Size(173, 11);
            this.addItemSelectLbl.TabIndex = 23;
            this.addItemSelectLbl.Text = "Select Item Type to Add:";
            // 
            // userInputPromptLbl
            // 
            this.userInputPromptLbl.AutoSize = true;
            this.userInputPromptLbl.Location = new System.Drawing.Point(21, 196);
            this.userInputPromptLbl.Name = "userInputPromptLbl";
            this.userInputPromptLbl.Size = new System.Drawing.Size(0, 13);
            this.userInputPromptLbl.TabIndex = 24;
            // 
            // userInputTxtBox
            // 
            this.userInputTxtBox.Location = new System.Drawing.Point(107, 170);
            this.userInputTxtBox.Name = "userInputTxtBox";
            this.userInputTxtBox.Size = new System.Drawing.Size(289, 20);
            this.userInputTxtBox.TabIndex = 25;
            this.userInputTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // userInputLbl
            // 
            this.userInputLbl.AutoSize = true;
            this.userInputLbl.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputLbl.Location = new System.Drawing.Point(22, 174);
            this.userInputLbl.Name = "userInputLbl";
            this.userInputLbl.Size = new System.Drawing.Size(82, 11);
            this.userInputLbl.TabIndex = 27;
            this.userInputLbl.Text = "User Input:";
            this.userInputLbl.Click += new System.EventHandler(this.userItemDetailInputLbl_Click);
            // 
            // enterUserInputBtn
            // 
            this.enterUserInputBtn.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterUserInputBtn.Location = new System.Drawing.Point(402, 168);
            this.enterUserInputBtn.Name = "enterUserInputBtn";
            this.enterUserInputBtn.Size = new System.Drawing.Size(57, 22);
            this.enterUserInputBtn.TabIndex = 28;
            this.enterUserInputBtn.Text = "Enter";
            this.enterUserInputBtn.UseVisualStyleBackColor = true;
            this.enterUserInputBtn.Click += new System.EventHandler(this.enterUserInputBtn_Click);
            // 
            // physicalMediaWatchingChk
            // 
            this.physicalMediaWatchingChk.AutoSize = true;
            this.physicalMediaWatchingChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physicalMediaWatchingChk.Location = new System.Drawing.Point(998, 236);
            this.physicalMediaWatchingChk.Name = "physicalMediaWatchingChk";
            this.physicalMediaWatchingChk.Size = new System.Drawing.Size(80, 15);
            this.physicalMediaWatchingChk.TabIndex = 29;
            this.physicalMediaWatchingChk.Text = "Watching";
            this.physicalMediaWatchingChk.UseVisualStyleBackColor = true;
            // 
            // digitalMediaVideoGamesChk
            // 
            this.digitalMediaVideoGamesChk.AutoSize = true;
            this.digitalMediaVideoGamesChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalMediaVideoGamesChk.Location = new System.Drawing.Point(998, 316);
            this.digitalMediaVideoGamesChk.Name = "digitalMediaVideoGamesChk";
            this.digitalMediaVideoGamesChk.Size = new System.Drawing.Size(101, 15);
            this.digitalMediaVideoGamesChk.TabIndex = 30;
            this.digitalMediaVideoGamesChk.Text = "Video Games";
            this.digitalMediaVideoGamesChk.UseVisualStyleBackColor = true;
            // 
            // digitalMediaMusicChk
            // 
            this.digitalMediaMusicChk.AutoSize = true;
            this.digitalMediaMusicChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalMediaMusicChk.Location = new System.Drawing.Point(998, 337);
            this.digitalMediaMusicChk.Name = "digitalMediaMusicChk";
            this.digitalMediaMusicChk.Size = new System.Drawing.Size(59, 15);
            this.digitalMediaMusicChk.TabIndex = 31;
            this.digitalMediaMusicChk.Text = "Music";
            this.digitalMediaMusicChk.UseVisualStyleBackColor = true;
            // 
            // digitalMediaWatchingChk
            // 
            this.digitalMediaWatchingChk.AutoSize = true;
            this.digitalMediaWatchingChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalMediaWatchingChk.Location = new System.Drawing.Point(998, 358);
            this.digitalMediaWatchingChk.Name = "digitalMediaWatchingChk";
            this.digitalMediaWatchingChk.Size = new System.Drawing.Size(80, 15);
            this.digitalMediaWatchingChk.TabIndex = 32;
            this.digitalMediaWatchingChk.Text = "Watching";
            this.digitalMediaWatchingChk.UseVisualStyleBackColor = true;
            // 
            // digitalMediaSoftwareChk
            // 
            this.digitalMediaSoftwareChk.AutoSize = true;
            this.digitalMediaSoftwareChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalMediaSoftwareChk.Location = new System.Drawing.Point(998, 379);
            this.digitalMediaSoftwareChk.Name = "digitalMediaSoftwareChk";
            this.digitalMediaSoftwareChk.Size = new System.Drawing.Size(80, 15);
            this.digitalMediaSoftwareChk.TabIndex = 33;
            this.digitalMediaSoftwareChk.Text = "Software";
            this.digitalMediaSoftwareChk.UseVisualStyleBackColor = true;
            // 
            // digitalMediaOtherChk
            // 
            this.digitalMediaOtherChk.AutoSize = true;
            this.digitalMediaOtherChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalMediaOtherChk.Location = new System.Drawing.Point(998, 400);
            this.digitalMediaOtherChk.Name = "digitalMediaOtherChk";
            this.digitalMediaOtherChk.Size = new System.Drawing.Size(115, 15);
            this.digitalMediaOtherChk.TabIndex = 34;
            this.digitalMediaOtherChk.Text = "Other Digital";
            this.digitalMediaOtherChk.UseVisualStyleBackColor = true;
            // 
            // otherMiscChk
            // 
            this.otherMiscChk.AutoSize = true;
            this.otherMiscChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherMiscChk.Location = new System.Drawing.Point(998, 526);
            this.otherMiscChk.Name = "otherMiscChk";
            this.otherMiscChk.Size = new System.Drawing.Size(115, 15);
            this.otherMiscChk.TabIndex = 35;
            this.otherMiscChk.Text = "Miscellaneous";
            this.otherMiscChk.UseVisualStyleBackColor = true;
            // 
            // otherMediaAccessoriesChk
            // 
            this.otherMediaAccessoriesChk.AutoSize = true;
            this.otherMediaAccessoriesChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherMediaAccessoriesChk.Location = new System.Drawing.Point(998, 505);
            this.otherMediaAccessoriesChk.Name = "otherMediaAccessoriesChk";
            this.otherMediaAccessoriesChk.Size = new System.Drawing.Size(143, 15);
            this.otherMediaAccessoriesChk.TabIndex = 36;
            this.otherMediaAccessoriesChk.Text = "Media Accessories";
            this.otherMediaAccessoriesChk.UseVisualStyleBackColor = true;
            // 
            // otherVideoGameAccessoriesChk
            // 
            this.otherVideoGameAccessoriesChk.AutoSize = true;
            this.otherVideoGameAccessoriesChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherVideoGameAccessoriesChk.Location = new System.Drawing.Point(998, 484);
            this.otherVideoGameAccessoriesChk.Name = "otherVideoGameAccessoriesChk";
            this.otherVideoGameAccessoriesChk.Size = new System.Drawing.Size(178, 15);
            this.otherVideoGameAccessoriesChk.TabIndex = 37;
            this.otherVideoGameAccessoriesChk.Text = "Video Game Accessories";
            this.otherVideoGameAccessoriesChk.UseVisualStyleBackColor = true;
            // 
            // otherConsolesAndPlayersChk
            // 
            this.otherConsolesAndPlayersChk.AutoSize = true;
            this.otherConsolesAndPlayersChk.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherConsolesAndPlayersChk.Location = new System.Drawing.Point(998, 463);
            this.otherConsolesAndPlayersChk.Name = "otherConsolesAndPlayersChk";
            this.otherConsolesAndPlayersChk.Size = new System.Drawing.Size(164, 15);
            this.otherConsolesAndPlayersChk.TabIndex = 38;
            this.otherConsolesAndPlayersChk.Text = "Consoles and Players";
            this.otherConsolesAndPlayersChk.UseVisualStyleBackColor = true;
            // 
            // FinalProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 672);
            this.Controls.Add(this.otherConsolesAndPlayersChk);
            this.Controls.Add(this.otherVideoGameAccessoriesChk);
            this.Controls.Add(this.otherMediaAccessoriesChk);
            this.Controls.Add(this.otherMiscChk);
            this.Controls.Add(this.digitalMediaOtherChk);
            this.Controls.Add(this.digitalMediaSoftwareChk);
            this.Controls.Add(this.digitalMediaWatchingChk);
            this.Controls.Add(this.digitalMediaMusicChk);
            this.Controls.Add(this.digitalMediaVideoGamesChk);
            this.Controls.Add(this.physicalMediaWatchingChk);
            this.Controls.Add(this.enterUserInputBtn);
            this.Controls.Add(this.userInputLbl);
            this.Controls.Add(this.userInputTxtBox);
            this.Controls.Add(this.userInputPromptLbl);
            this.Controls.Add(this.addItemSelectLbl);
            this.Controls.Add(this.addItemDropdown);
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
            this.Load += new System.EventHandler(this.FinalProjectForm_Load);
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
        private System.Windows.Forms.ComboBox addItemDropdown;
        private System.Windows.Forms.Label addItemSelectLbl;
        private System.Windows.Forms.Label userInputPromptLbl;
        private System.Windows.Forms.TextBox userInputTxtBox;
        private System.Windows.Forms.Label userInputLbl;
        private System.Windows.Forms.Button enterUserInputBtn;
        private System.Windows.Forms.CheckBox physicalMediaWatchingChk;
        private System.Windows.Forms.CheckBox digitalMediaVideoGamesChk;
        private System.Windows.Forms.CheckBox digitalMediaMusicChk;
        private System.Windows.Forms.CheckBox digitalMediaWatchingChk;
        private System.Windows.Forms.CheckBox digitalMediaSoftwareChk;
        private System.Windows.Forms.CheckBox digitalMediaOtherChk;
        private System.Windows.Forms.CheckBox otherMiscChk;
        private System.Windows.Forms.CheckBox otherMediaAccessoriesChk;
        private System.Windows.Forms.CheckBox otherVideoGameAccessoriesChk;
        private System.Windows.Forms.CheckBox otherConsolesAndPlayersChk;
    }
}


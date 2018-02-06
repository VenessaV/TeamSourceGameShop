﻿namespace TeamSourceGameShop
{
    partial class frmGameShop
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
            this.lblSearchGames = new System.Windows.Forms.Label();
            this.txtSearchGames = new System.Windows.Forms.TextBox();
            this.txtGamesList = new System.Windows.Forms.ListBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNumberOfGames = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.btnUpdateGame = new System.Windows.Forms.Button();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearchGames
            // 
            this.lblSearchGames.AutoSize = true;
            this.lblSearchGames.Location = new System.Drawing.Point(25, 32);
            this.lblSearchGames.Name = "lblSearchGames";
            this.lblSearchGames.Size = new System.Drawing.Size(77, 13);
            this.lblSearchGames.TabIndex = 0;
            this.lblSearchGames.Text = "Search Games";
            // 
            // txtSearchGames
            // 
            this.txtSearchGames.Location = new System.Drawing.Point(121, 25);
            this.txtSearchGames.Name = "txtSearchGames";
            this.txtSearchGames.Size = new System.Drawing.Size(196, 20);
            this.txtSearchGames.TabIndex = 1;
            // 
            // txtGamesList
            // 
            this.txtGamesList.FormattingEnabled = true;
            this.txtGamesList.Location = new System.Drawing.Point(28, 91);
            this.txtGamesList.Name = "txtGamesList";
            this.txtGamesList.Size = new System.Drawing.Size(289, 173);
            this.txtGamesList.TabIndex = 2;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(25, 63);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(66, 13);
            this.lblGameName.TabIndex = 3;
            this.lblGameName.Text = "Game Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(118, 63);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblNumberOfGames
            // 
            this.lblNumberOfGames.AutoSize = true;
            this.lblNumberOfGames.Location = new System.Drawing.Point(173, 63);
            this.lblNumberOfGames.Name = "lblNumberOfGames";
            this.lblNumberOfGames.Size = new System.Drawing.Size(63, 13);
            this.lblNumberOfGames.TabIndex = 5;
            this.lblNumberOfGames.Text = "# Of Copies";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(261, 63);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(56, 13);
            this.lblAvailability.TabIndex = 6;
            this.lblAvailability.Text = "Availability";
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(366, 25);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(110, 60);
            this.btnAddGame.TabIndex = 7;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = true;
            // 
            // btnUpdateGame
            // 
            this.btnUpdateGame.Location = new System.Drawing.Point(366, 113);
            this.btnUpdateGame.Name = "btnUpdateGame";
            this.btnUpdateGame.Size = new System.Drawing.Size(110, 61);
            this.btnUpdateGame.TabIndex = 8;
            this.btnUpdateGame.Text = "Update Game";
            this.btnUpdateGame.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Location = new System.Drawing.Point(366, 203);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(110, 61);
            this.btnDeleteGame.TabIndex = 9;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            // 
            // frmGameShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 289);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.btnUpdateGame);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lblNumberOfGames);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txtGamesList);
            this.Controls.Add(this.txtSearchGames);
            this.Controls.Add(this.lblSearchGames);
            this.Name = "frmGameShop";
            this.Text = "Game Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchGames;
        private System.Windows.Forms.TextBox txtSearchGames;
        private System.Windows.Forms.ListBox txtGamesList;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNumberOfGames;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnUpdateGame;
        private System.Windows.Forms.Button btnDeleteGame;
    }
}


﻿namespace MainForm
{
    partial class Datascreen
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
            this.summonerIcon = new System.Windows.Forms.PictureBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.soloIndicator = new System.Windows.Forms.Label();
            this.flexIndicator = new System.Windows.Forms.Label();
            this.soloLabel = new System.Windows.Forms.Label();
            this.flexLabel = new System.Windows.Forms.Label();
            this.soloIcon = new System.Windows.Forms.PictureBox();
            this.flexIcon = new System.Windows.Forms.PictureBox();
            this.soloPanel = new System.Windows.Forms.Panel();
            this.soloWinPLabel = new System.Windows.Forms.Label();
            this.soloWinsLabel = new System.Windows.Forms.Label();
            this.soloLosesLabel = new System.Windows.Forms.Label();
            this.soloLPLabel = new System.Windows.Forms.Label();
            this.flexPanel = new System.Windows.Forms.Panel();
            this.flexWinPLabel = new System.Windows.Forms.Label();
            this.flexLosesLabel = new System.Windows.Forms.Label();
            this.flexWinsLabel = new System.Windows.Forms.Label();
            this.flexLPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.summonerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexIcon)).BeginInit();
            this.soloPanel.SuspendLayout();
            this.flexPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // summonerIcon
            // 
            this.summonerIcon.BackColor = System.Drawing.SystemColors.Desktop;
            this.summonerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.summonerIcon.Location = new System.Drawing.Point(26, 25);
            this.summonerIcon.Name = "summonerIcon";
            this.summonerIcon.Size = new System.Drawing.Size(150, 150);
            this.summonerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.summonerIcon.TabIndex = 0;
            this.summonerIcon.TabStop = false;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.levelLabel.Location = new System.Drawing.Point(21, 178);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(64, 25);
            this.levelLabel.TabIndex = 1;
            this.levelLabel.Text = "1337";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.nameLabel.Location = new System.Drawing.Point(205, 76);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(128, 45);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            // 
            // soloIndicator
            // 
            this.soloIndicator.AutoSize = true;
            this.soloIndicator.BackColor = System.Drawing.Color.Transparent;
            this.soloIndicator.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soloIndicator.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.soloIndicator.Location = new System.Drawing.Point(574, 25);
            this.soloIndicator.Name = "soloIndicator";
            this.soloIndicator.Size = new System.Drawing.Size(101, 23);
            this.soloIndicator.TabIndex = 3;
            this.soloIndicator.Text = "Solo/Duo";
            // 
            // flexIndicator
            // 
            this.flexIndicator.AutoSize = true;
            this.flexIndicator.BackColor = System.Drawing.Color.Transparent;
            this.flexIndicator.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flexIndicator.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.flexIndicator.Location = new System.Drawing.Point(870, 25);
            this.flexIndicator.Name = "flexIndicator";
            this.flexIndicator.Size = new System.Drawing.Size(49, 23);
            this.flexIndicator.TabIndex = 4;
            this.flexIndicator.Text = "Flex";
            // 
            // soloLabel
            // 
            this.soloLabel.AutoSize = true;
            this.soloLabel.BackColor = System.Drawing.Color.Transparent;
            this.soloLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soloLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.soloLabel.Location = new System.Drawing.Point(606, 288);
            this.soloLabel.Name = "soloLabel";
            this.soloLabel.Size = new System.Drawing.Size(69, 23);
            this.soloLabel.TabIndex = 5;
            this.soloLabel.Text = "Iron 4";
            // 
            // flexLabel
            // 
            this.flexLabel.AutoSize = true;
            this.flexLabel.BackColor = System.Drawing.Color.Transparent;
            this.flexLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flexLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.flexLabel.Location = new System.Drawing.Point(870, 288);
            this.flexLabel.Name = "flexLabel";
            this.flexLabel.Size = new System.Drawing.Size(69, 23);
            this.flexLabel.TabIndex = 6;
            this.flexLabel.Text = "Iron 4";
            // 
            // soloIcon
            // 
            this.soloIcon.BackColor = System.Drawing.Color.Transparent;
            this.soloIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.soloIcon.Image = global::MainForm.Properties.Resources.bronze;
            this.soloIcon.Location = new System.Drawing.Point(536, 76);
            this.soloIcon.Name = "soloIcon";
            this.soloIcon.Size = new System.Drawing.Size(200, 200);
            this.soloIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.soloIcon.TabIndex = 7;
            this.soloIcon.TabStop = false;
            this.soloIcon.Click += new System.EventHandler(this.soloIcon_Click);
            // 
            // flexIcon
            // 
            this.flexIcon.BackColor = System.Drawing.Color.Transparent;
            this.flexIcon.Image = global::MainForm.Properties.Resources.challenger;
            this.flexIcon.Location = new System.Drawing.Point(803, 76);
            this.flexIcon.Name = "flexIcon";
            this.flexIcon.Size = new System.Drawing.Size(200, 200);
            this.flexIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.flexIcon.TabIndex = 8;
            this.flexIcon.TabStop = false;
            this.flexIcon.Click += new System.EventHandler(this.flexIcon_Click);
            // 
            // soloPanel
            // 
            this.soloPanel.BackColor = System.Drawing.SystemColors.Control;
            this.soloPanel.Controls.Add(this.soloWinPLabel);
            this.soloPanel.Controls.Add(this.soloWinsLabel);
            this.soloPanel.Controls.Add(this.soloLosesLabel);
            this.soloPanel.Controls.Add(this.soloLPLabel);
            this.soloPanel.Location = new System.Drawing.Point(537, 329);
            this.soloPanel.Name = "soloPanel";
            this.soloPanel.Size = new System.Drawing.Size(200, 150);
            this.soloPanel.TabIndex = 9;
            this.soloPanel.Visible = false;
            // 
            // soloWinPLabel
            // 
            this.soloWinPLabel.AutoSize = true;
            this.soloWinPLabel.BackColor = System.Drawing.Color.Transparent;
            this.soloWinPLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soloWinPLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.soloWinPLabel.Location = new System.Drawing.Point(70, 100);
            this.soloWinPLabel.Name = "soloWinPLabel";
            this.soloWinPLabel.Size = new System.Drawing.Size(41, 18);
            this.soloWinPLabel.TabIndex = 4;
            this.soloWinPLabel.Text = "0 %";
            // 
            // soloWinsLabel
            // 
            this.soloWinsLabel.AutoSize = true;
            this.soloWinsLabel.BackColor = System.Drawing.Color.Transparent;
            this.soloWinsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soloWinsLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.soloWinsLabel.Location = new System.Drawing.Point(38, 61);
            this.soloWinsLabel.Name = "soloWinsLabel";
            this.soloWinsLabel.Size = new System.Drawing.Size(41, 18);
            this.soloWinsLabel.TabIndex = 3;
            this.soloWinsLabel.Text = "0 W";
            // 
            // soloLosesLabel
            // 
            this.soloLosesLabel.AutoSize = true;
            this.soloLosesLabel.BackColor = System.Drawing.Color.Transparent;
            this.soloLosesLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soloLosesLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.soloLosesLabel.Location = new System.Drawing.Point(112, 61);
            this.soloLosesLabel.Name = "soloLosesLabel";
            this.soloLosesLabel.Size = new System.Drawing.Size(33, 18);
            this.soloLosesLabel.TabIndex = 2;
            this.soloLosesLabel.Text = "0 L";
            // 
            // soloLPLabel
            // 
            this.soloLPLabel.AutoSize = true;
            this.soloLPLabel.BackColor = System.Drawing.Color.Transparent;
            this.soloLPLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soloLPLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.soloLPLabel.Location = new System.Drawing.Point(70, 21);
            this.soloLPLabel.Name = "soloLPLabel";
            this.soloLPLabel.Size = new System.Drawing.Size(43, 18);
            this.soloLPLabel.TabIndex = 1;
            this.soloLPLabel.Text = "0 LP";
            // 
            // flexPanel
            // 
            this.flexPanel.Controls.Add(this.flexWinPLabel);
            this.flexPanel.Controls.Add(this.flexLosesLabel);
            this.flexPanel.Controls.Add(this.flexWinsLabel);
            this.flexPanel.Controls.Add(this.flexLPLabel);
            this.flexPanel.Location = new System.Drawing.Point(805, 329);
            this.flexPanel.Name = "flexPanel";
            this.flexPanel.Size = new System.Drawing.Size(200, 150);
            this.flexPanel.TabIndex = 10;
            this.flexPanel.Visible = false;
            // 
            // flexWinPLabel
            // 
            this.flexWinPLabel.AutoSize = true;
            this.flexWinPLabel.BackColor = System.Drawing.Color.Transparent;
            this.flexWinPLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flexWinPLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.flexWinPLabel.Location = new System.Drawing.Point(73, 100);
            this.flexWinPLabel.Name = "flexWinPLabel";
            this.flexWinPLabel.Size = new System.Drawing.Size(41, 18);
            this.flexWinPLabel.TabIndex = 5;
            this.flexWinPLabel.Text = "0 %";
            // 
            // flexLosesLabel
            // 
            this.flexLosesLabel.AutoSize = true;
            this.flexLosesLabel.BackColor = System.Drawing.Color.Transparent;
            this.flexLosesLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flexLosesLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.flexLosesLabel.Location = new System.Drawing.Point(121, 61);
            this.flexLosesLabel.Name = "flexLosesLabel";
            this.flexLosesLabel.Size = new System.Drawing.Size(33, 18);
            this.flexLosesLabel.TabIndex = 5;
            this.flexLosesLabel.Text = "0 L";
            // 
            // flexWinsLabel
            // 
            this.flexWinsLabel.AutoSize = true;
            this.flexWinsLabel.BackColor = System.Drawing.Color.Transparent;
            this.flexWinsLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flexWinsLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.flexWinsLabel.Location = new System.Drawing.Point(29, 61);
            this.flexWinsLabel.Name = "flexWinsLabel";
            this.flexWinsLabel.Size = new System.Drawing.Size(41, 18);
            this.flexWinsLabel.TabIndex = 5;
            this.flexWinsLabel.Text = "0 W";
            // 
            // flexLPLabel
            // 
            this.flexLPLabel.AutoSize = true;
            this.flexLPLabel.BackColor = System.Drawing.Color.Transparent;
            this.flexLPLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flexLPLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.flexLPLabel.Location = new System.Drawing.Point(71, 21);
            this.flexLPLabel.Name = "flexLPLabel";
            this.flexLPLabel.Size = new System.Drawing.Size(43, 18);
            this.flexLPLabel.TabIndex = 0;
            this.flexLPLabel.Text = "0 LP";
            // 
            // Datascreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainForm.Properties.Resources.poro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 601);
            this.Controls.Add(this.flexPanel);
            this.Controls.Add(this.soloPanel);
            this.Controls.Add(this.flexIcon);
            this.Controls.Add(this.soloIcon);
            this.Controls.Add(this.flexLabel);
            this.Controls.Add(this.soloLabel);
            this.Controls.Add(this.flexIndicator);
            this.Controls.Add(this.soloIndicator);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.summonerIcon);
            this.Name = "Datascreen";
            this.Text = "Datascreen";
            ((System.ComponentModel.ISupportInitialize)(this.summonerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soloIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flexIcon)).EndInit();
            this.soloPanel.ResumeLayout(false);
            this.soloPanel.PerformLayout();
            this.flexPanel.ResumeLayout(false);
            this.flexPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox summonerIcon;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label soloIndicator;
        private System.Windows.Forms.Label flexIndicator;
        private System.Windows.Forms.Label soloLabel;
        private System.Windows.Forms.Label flexLabel;
        private System.Windows.Forms.PictureBox soloIcon;
        private System.Windows.Forms.PictureBox flexIcon;
        private System.Windows.Forms.Panel soloPanel;
        private System.Windows.Forms.Label soloLPLabel;
        private System.Windows.Forms.Panel flexPanel;
        private System.Windows.Forms.Label flexLPLabel;
        private System.Windows.Forms.Label soloWinPLabel;
        private System.Windows.Forms.Label soloWinsLabel;
        private System.Windows.Forms.Label soloLosesLabel;
        private System.Windows.Forms.Label flexWinPLabel;
        private System.Windows.Forms.Label flexLosesLabel;
        private System.Windows.Forms.Label flexWinsLabel;
    }
}
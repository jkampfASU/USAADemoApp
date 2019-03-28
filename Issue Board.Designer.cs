﻿namespace USAADemoApp
{
    partial class formIssueBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIssueBoard));
            this.buttonComment = new System.Windows.Forms.Button();
            this.textBoxIssue = new System.Windows.Forms.TextBox();
            this.pictureBoxDownvote = new System.Windows.Forms.PictureBox();
            this.pictureBoxUpvote = new System.Windows.Forms.PictureBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemIssue1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemIssue2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemIssue3 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRedDog = new System.Windows.Forms.Label();
            this.labelSkills = new System.Windows.Forms.Label();
            this.listComment = new System.Windows.Forms.ListBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(331, 217);
            this.buttonComment.Margin = new System.Windows.Forms.Padding(1);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(108, 25);
            this.buttonComment.TabIndex = 0;
            this.buttonComment.Text = "Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // textBoxIssue
            // 
            this.textBoxIssue.Location = new System.Drawing.Point(113, 121);
            this.textBoxIssue.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxIssue.Multiline = true;
            this.textBoxIssue.Name = "textBoxIssue";
            this.textBoxIssue.ReadOnly = true;
            this.textBoxIssue.Size = new System.Drawing.Size(487, 86);
            this.textBoxIssue.TabIndex = 1;
            this.textBoxIssue.Text = resources.GetString("textBoxIssue.Text");
            // 
            // pictureBoxDownvote
            // 
            this.pictureBoxDownvote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDownvote.BackgroundImage")));
            this.pictureBoxDownvote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDownvote.Location = new System.Drawing.Point(73, 128);
            this.pictureBoxDownvote.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxDownvote.Name = "pictureBoxDownvote";
            this.pictureBoxDownvote.Size = new System.Drawing.Size(27, 44);
            this.pictureBoxDownvote.TabIndex = 3;
            this.pictureBoxDownvote.TabStop = false;
            this.pictureBoxDownvote.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxUpvote
            // 
            this.pictureBoxUpvote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUpvote.BackgroundImage")));
            this.pictureBoxUpvote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUpvote.Location = new System.Drawing.Point(21, 128);
            this.pictureBoxUpvote.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxUpvote.Name = "pictureBoxUpvote";
            this.pictureBoxUpvote.Size = new System.Drawing.Size(27, 44);
            this.pictureBoxUpvote.TabIndex = 4;
            this.pictureBoxUpvote.TabStop = false;
            this.pictureBoxUpvote.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(49, 145);
            this.labelCount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(24, 17);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "23";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(19, 18);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 17);
            this.welcomeLabel.TabIndex = 6;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemIssue1,
            this.toolStripMenuItemIssue2,
            this.toolStripMenuItemIssue3});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(811, 26);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemIssue1
            // 
            this.toolStripMenuItemIssue1.Name = "toolStripMenuItemIssue1";
            this.toolStripMenuItemIssue1.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItemIssue1.Text = "Issue 1";
            // 
            // toolStripMenuItemIssue2
            // 
            this.toolStripMenuItemIssue2.Name = "toolStripMenuItemIssue2";
            this.toolStripMenuItemIssue2.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItemIssue2.Text = "Issue 2";
            this.toolStripMenuItemIssue2.Click += new System.EventHandler(this.issue2ToolStripMenuItem_Click);
            // 
            // toolStripMenuItemIssue3
            // 
            this.toolStripMenuItemIssue3.Name = "toolStripMenuItemIssue3";
            this.toolStripMenuItemIssue3.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItemIssue3.Text = "Issue 3";
            // 
            // labelRedDog
            // 
            this.labelRedDog.AutoSize = true;
            this.labelRedDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRedDog.Location = new System.Drawing.Point(21, 39);
            this.labelRedDog.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelRedDog.Name = "labelRedDog";
            this.labelRedDog.Size = new System.Drawing.Size(66, 17);
            this.labelRedDog.TabIndex = 8;
            this.labelRedDog.Text = "RedDog";
            // 
            // labelSkills
            // 
            this.labelSkills.AutoSize = true;
            this.labelSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkills.ForeColor = System.Drawing.Color.Black;
            this.labelSkills.Location = new System.Drawing.Point(19, 63);
            this.labelSkills.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelSkills.Name = "labelSkills";
            this.labelSkills.Size = new System.Drawing.Size(410, 36);
            this.labelSkills.TabIndex = 9;
            this.labelSkills.Text = "No time for skills development";
            this.labelSkills.Click += new System.EventHandler(this.label2_Click);
            // 
            // listComment
            // 
            this.listComment.FormattingEnabled = true;
            this.listComment.ItemHeight = 16;
            this.listComment.Location = new System.Drawing.Point(113, 249);
            this.listComment.Margin = new System.Windows.Forms.Padding(1);
            this.listComment.Name = "listComment";
            this.listComment.Size = new System.Drawing.Size(487, 68);
            this.listComment.TabIndex = 10;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(52, 338);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(1);
            this.webBrowser.MinimumSize = new System.Drawing.Size(8, 9);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(676, 107);
            this.webBrowser.TabIndex = 11;
            this.webBrowser.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            // 
            // formIssueBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 455);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.listComment);
            this.Controls.Add(this.labelSkills);
            this.Controls.Add(this.labelRedDog);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.pictureBoxUpvote);
            this.Controls.Add(this.pictureBoxDownvote);
            this.Controls.Add(this.textBoxIssue);
            this.Controls.Add(this.buttonComment);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "formIssueBoard";
            this.Text = "Issue Board";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.TextBox textBoxIssue;
        private System.Windows.Forms.PictureBox pictureBoxDownvote;
        private System.Windows.Forms.PictureBox pictureBoxUpvote;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIssue1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIssue2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemIssue3;
        private System.Windows.Forms.Label labelRedDog;
        private System.Windows.Forms.Label labelSkills;
        private System.Windows.Forms.ListBox listComment;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}


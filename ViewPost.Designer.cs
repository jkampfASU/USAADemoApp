﻿namespace USAADemoApp
{
    partial class ViewPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPost));
            this.textBoxPostBody = new System.Windows.Forms.TextBox();
            this.pictureBoxDownvote = new System.Windows.Forms.PictureBox();
            this.pictureBoxUpvote = new System.Windows.Forms.PictureBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.labelPostTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPostBody
            // 
            this.textBoxPostBody.Location = new System.Drawing.Point(113, 74);
            this.textBoxPostBody.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxPostBody.Multiline = true;
            this.textBoxPostBody.Name = "textBoxPostBody";
            this.textBoxPostBody.ReadOnly = true;
            this.textBoxPostBody.Size = new System.Drawing.Size(487, 86);
            this.textBoxPostBody.TabIndex = 1;
            this.textBoxPostBody.Text = "Post Body";
            // 
            // pictureBoxDownvote
            // 
            this.pictureBoxDownvote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDownvote.BackgroundImage")));
            this.pictureBoxDownvote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDownvote.Location = new System.Drawing.Point(71, 74);
            this.pictureBoxDownvote.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBoxDownvote.Name = "pictureBoxDownvote";
            this.pictureBoxDownvote.Size = new System.Drawing.Size(27, 44);
            this.pictureBoxDownvote.TabIndex = 3;
            this.pictureBoxDownvote.TabStop = false;
            this.pictureBoxDownvote.Click += new System.EventHandler(this.PictureBoxDownvote_Click);
            // 
            // pictureBoxUpvote
            // 
            this.pictureBoxUpvote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUpvote.BackgroundImage")));
            this.pictureBoxUpvote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUpvote.Location = new System.Drawing.Point(13, 74);
            this.pictureBoxUpvote.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBoxUpvote.Name = "pictureBoxUpvote";
            this.pictureBoxUpvote.Size = new System.Drawing.Size(27, 44);
            this.pictureBoxUpvote.TabIndex = 4;
            this.pictureBoxUpvote.TabStop = false;
            this.pictureBoxUpvote.Click += new System.EventHandler(this.PictureBoxUpvote_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(43, 78);
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
            // labelPostTitle
            // 
            this.labelPostTitle.AutoSize = true;
            this.labelPostTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostTitle.ForeColor = System.Drawing.Color.Black;
            this.labelPostTitle.Location = new System.Drawing.Point(107, 18);
            this.labelPostTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelPostTitle.Name = "labelPostTitle";
            this.labelPostTitle.Size = new System.Drawing.Size(139, 36);
            this.labelPostTitle.TabIndex = 9;
            this.labelPostTitle.Text = "Post Title";
            // 
            // IndividualPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 206);
            this.Controls.Add(this.labelPostTitle);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.pictureBoxUpvote);
            this.Controls.Add(this.pictureBoxDownvote);
            this.Controls.Add(this.textBoxPostBody);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "IndividualPost";
            this.Text = "Post";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownvote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpvote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPostBody;
        private System.Windows.Forms.PictureBox pictureBoxDownvote;
        private System.Windows.Forms.PictureBox pictureBoxUpvote;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label labelPostTitle;
    }
}


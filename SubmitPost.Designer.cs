﻿namespace USAADemoApp
{
    partial class SubmitPost
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
            this.buttonPost = new System.Windows.Forms.Button();
            this.groupBoxFeedbackType = new System.Windows.Forms.GroupBox();
            this.radioButtonSuggestions = new System.Windows.Forms.RadioButton();
            this.radioButtonIssues = new System.Windows.Forms.RadioButton();
            this.radioButtonImplementation = new System.Windows.Forms.RadioButton();
            this.labelPostTitle = new System.Windows.Forms.Label();
            this.textBoxPostTitle = new System.Windows.Forms.TextBox();
            this.labelPostBody = new System.Windows.Forms.Label();
            this.textBoxPostBody = new System.Windows.Forms.TextBox();
            this.groupBoxFeedbackType.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(308, 422);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(100, 28);
            this.buttonPost.TabIndex = 7;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.ButtonPost_Click);
            // 
            // groupBoxFeedbackType
            // 
            this.groupBoxFeedbackType.Controls.Add(this.radioButtonSuggestions);
            this.groupBoxFeedbackType.Controls.Add(this.radioButtonIssues);
            this.groupBoxFeedbackType.Controls.Add(this.radioButtonImplementation);
            this.groupBoxFeedbackType.Location = new System.Drawing.Point(65, 13);
            this.groupBoxFeedbackType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFeedbackType.Name = "groupBoxFeedbackType";
            this.groupBoxFeedbackType.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxFeedbackType.Size = new System.Drawing.Size(165, 122);
            this.groupBoxFeedbackType.TabIndex = 10;
            this.groupBoxFeedbackType.TabStop = false;
            this.groupBoxFeedbackType.Text = "Feedback Type:";
            // 
            // radioButtonSuggestions
            // 
            this.radioButtonSuggestions.AutoSize = true;
            this.radioButtonSuggestions.Location = new System.Drawing.Point(8, 80);
            this.radioButtonSuggestions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSuggestions.Name = "radioButtonSuggestions";
            this.radioButtonSuggestions.Size = new System.Drawing.Size(107, 21);
            this.radioButtonSuggestions.TabIndex = 4;
            this.radioButtonSuggestions.TabStop = true;
            this.radioButtonSuggestions.Text = "Suggestions";
            this.radioButtonSuggestions.UseVisualStyleBackColor = true;
            // 
            // radioButtonIssues
            // 
            this.radioButtonIssues.AutoSize = true;
            this.radioButtonIssues.Location = new System.Drawing.Point(8, 52);
            this.radioButtonIssues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonIssues.Name = "radioButtonIssues";
            this.radioButtonIssues.Size = new System.Drawing.Size(69, 21);
            this.radioButtonIssues.TabIndex = 3;
            this.radioButtonIssues.TabStop = true;
            this.radioButtonIssues.Text = "Issues";
            this.radioButtonIssues.UseVisualStyleBackColor = true;
            // 
            // radioButtonImplementation
            // 
            this.radioButtonImplementation.AutoSize = true;
            this.radioButtonImplementation.Location = new System.Drawing.Point(8, 23);
            this.radioButtonImplementation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonImplementation.Name = "radioButtonImplementation";
            this.radioButtonImplementation.Size = new System.Drawing.Size(124, 21);
            this.radioButtonImplementation.TabIndex = 2;
            this.radioButtonImplementation.TabStop = true;
            this.radioButtonImplementation.Text = "Implementation";
            this.radioButtonImplementation.UseVisualStyleBackColor = true;
            // 
            // labelPostTitle
            // 
            this.labelPostTitle.AutoSize = true;
            this.labelPostTitle.Location = new System.Drawing.Point(13, 156);
            this.labelPostTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostTitle.Name = "labelPostTitle";
            this.labelPostTitle.Size = new System.Drawing.Size(39, 17);
            this.labelPostTitle.TabIndex = 11;
            this.labelPostTitle.Text = "Title:";
            // 
            // textBoxPostTitle
            // 
            this.textBoxPostTitle.Location = new System.Drawing.Point(65, 153);
            this.textBoxPostTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPostTitle.Name = "textBoxPostTitle";
            this.textBoxPostTitle.Size = new System.Drawing.Size(565, 22);
            this.textBoxPostTitle.TabIndex = 5;
            // 
            // labelPostBody
            // 
            this.labelPostBody.AutoSize = true;
            this.labelPostBody.Location = new System.Drawing.Point(13, 208);
            this.labelPostBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostBody.Name = "labelPostBody";
            this.labelPostBody.Size = new System.Drawing.Size(44, 17);
            this.labelPostBody.TabIndex = 12;
            this.labelPostBody.Text = "Body:";
            // 
            // textBoxPostBody
            // 
            this.textBoxPostBody.Location = new System.Drawing.Point(65, 208);
            this.textBoxPostBody.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPostBody.Multiline = true;
            this.textBoxPostBody.Name = "textBoxPostBody";
            this.textBoxPostBody.Size = new System.Drawing.Size(565, 191);
            this.textBoxPostBody.TabIndex = 6;
            // 
            // SubmitPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 470);
            this.Controls.Add(this.textBoxPostBody);
            this.Controls.Add(this.labelPostBody);
            this.Controls.Add(this.labelPostTitle);
            this.Controls.Add(this.textBoxPostTitle);
            this.Controls.Add(this.groupBoxFeedbackType);
            this.Controls.Add(this.buttonPost);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "SubmitPost";
            this.Text = "Submit New Post";
            this.groupBoxFeedbackType.ResumeLayout(false);
            this.groupBoxFeedbackType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.GroupBox groupBoxFeedbackType;
        private System.Windows.Forms.RadioButton radioButtonSuggestions;
        private System.Windows.Forms.RadioButton radioButtonIssues;
        private System.Windows.Forms.RadioButton radioButtonImplementation;
        private System.Windows.Forms.Label labelPostTitle;
        private System.Windows.Forms.TextBox textBoxPostTitle;
        private System.Windows.Forms.Label labelPostBody;
        private System.Windows.Forms.TextBox textBoxPostBody;
    }
}
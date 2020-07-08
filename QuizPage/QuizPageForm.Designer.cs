namespace QuizPage
{
    partial class QuizPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizPageForm));
            this.ChoiceAButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.ImageForQuestionBox = new System.Windows.Forms.PictureBox();
            this.BackgroundBox = new System.Windows.Forms.PictureBox();
            this.ChoiceCButton = new System.Windows.Forms.Button();
            this.ChoiceBButton = new System.Windows.Forms.Button();
            this.ChoiceDButton = new System.Windows.Forms.Button();
            this.QuizProgressLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.CorrectAnswerNotifier = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageForQuestionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoiceAButton
            // 
            this.ChoiceAButton.BackColor = System.Drawing.Color.White;
            this.ChoiceAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceAButton.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceAButton.ForeColor = System.Drawing.Color.Aqua;
            this.ChoiceAButton.Image = ((System.Drawing.Image)(resources.GetObject("ChoiceAButton.Image")));
            this.ChoiceAButton.Location = new System.Drawing.Point(250, 324);
            this.ChoiceAButton.Name = "ChoiceAButton";
            this.ChoiceAButton.Size = new System.Drawing.Size(117, 54);
            this.ChoiceAButton.TabIndex = 1;
            this.ChoiceAButton.Text = "A";
            this.ChoiceAButton.UseVisualStyleBackColor = false;
            this.ChoiceAButton.Click += new System.EventHandler(this.ChoiceAButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.White;
            this.QuestionLabel.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Image = ((System.Drawing.Image)(resources.GetObject("QuestionLabel.Image")));
            this.QuestionLabel.Location = new System.Drawing.Point(263, 9);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(364, 150);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(67, 16);
            this.QuestionLabel.TabIndex = 5;
            this.QuestionLabel.Text = "Question";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ImageForQuestionBox
            // 
            this.ImageForQuestionBox.BackColor = System.Drawing.Color.White;
            this.ImageForQuestionBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageForQuestionBox.Location = new System.Drawing.Point(148, 51);
            this.ImageForQuestionBox.Name = "ImageForQuestionBox";
            this.ImageForQuestionBox.Size = new System.Drawing.Size(467, 267);
            this.ImageForQuestionBox.TabIndex = 9;
            this.ImageForQuestionBox.TabStop = false;
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundBox.Location = new System.Drawing.Point(0, -3);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(788, 441);
            this.BackgroundBox.TabIndex = 10;
            this.BackgroundBox.TabStop = false;
            // 
            // ChoiceCButton
            // 
            this.ChoiceCButton.BackColor = System.Drawing.Color.White;
            this.ChoiceCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceCButton.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceCButton.ForeColor = System.Drawing.Color.Aqua;
            this.ChoiceCButton.Image = ((System.Drawing.Image)(resources.GetObject("ChoiceCButton.Image")));
            this.ChoiceCButton.Location = new System.Drawing.Point(250, 384);
            this.ChoiceCButton.Name = "ChoiceCButton";
            this.ChoiceCButton.Size = new System.Drawing.Size(117, 54);
            this.ChoiceCButton.TabIndex = 11;
            this.ChoiceCButton.Text = "C";
            this.ChoiceCButton.UseVisualStyleBackColor = false;
            this.ChoiceCButton.Click += new System.EventHandler(this.ChoiceCButton_Click);
            // 
            // ChoiceBButton
            // 
            this.ChoiceBButton.BackColor = System.Drawing.Color.White;
            this.ChoiceBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceBButton.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceBButton.ForeColor = System.Drawing.Color.Aqua;
            this.ChoiceBButton.Image = ((System.Drawing.Image)(resources.GetObject("ChoiceBButton.Image")));
            this.ChoiceBButton.Location = new System.Drawing.Point(419, 324);
            this.ChoiceBButton.Name = "ChoiceBButton";
            this.ChoiceBButton.Size = new System.Drawing.Size(117, 54);
            this.ChoiceBButton.TabIndex = 12;
            this.ChoiceBButton.Text = "B";
            this.ChoiceBButton.UseVisualStyleBackColor = false;
            this.ChoiceBButton.Click += new System.EventHandler(this.ChoiceBButton_Click);
            // 
            // ChoiceDButton
            // 
            this.ChoiceDButton.BackColor = System.Drawing.Color.White;
            this.ChoiceDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceDButton.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceDButton.ForeColor = System.Drawing.Color.Aqua;
            this.ChoiceDButton.Image = ((System.Drawing.Image)(resources.GetObject("ChoiceDButton.Image")));
            this.ChoiceDButton.Location = new System.Drawing.Point(419, 384);
            this.ChoiceDButton.Name = "ChoiceDButton";
            this.ChoiceDButton.Size = new System.Drawing.Size(117, 54);
            this.ChoiceDButton.TabIndex = 13;
            this.ChoiceDButton.Text = "Democratic Republic of the Congo";
            this.ChoiceDButton.UseVisualStyleBackColor = false;
            this.ChoiceDButton.Click += new System.EventHandler(this.ChoiceDButton_Click);
            // 
            // QuizProgressLabel
            // 
            this.QuizProgressLabel.AutoSize = true;
            this.QuizProgressLabel.BackColor = System.Drawing.Color.White;
            this.QuizProgressLabel.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizProgressLabel.Image = ((System.Drawing.Image)(resources.GetObject("QuizProgressLabel.Image")));
            this.QuizProgressLabel.Location = new System.Drawing.Point(705, 9);
            this.QuizProgressLabel.MaximumSize = new System.Drawing.Size(364, 150);
            this.QuizProgressLabel.Name = "QuizProgressLabel";
            this.QuizProgressLabel.Size = new System.Drawing.Size(79, 16);
            this.QuizProgressLabel.TabIndex = 14;
            this.QuizProgressLabel.Text = "Question #";
            this.QuizProgressLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(0, 402);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(119, 47);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back to Menu";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.BackColor = System.Drawing.Color.White;
            this.NextQuestionButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("NextQuestionButton.Image")));
            this.NextQuestionButton.Location = new System.Drawing.Point(576, 391);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(98, 47);
            this.NextQuestionButton.TabIndex = 16;
            this.NextQuestionButton.Text = "Next Question";
            this.NextQuestionButton.UseVisualStyleBackColor = false;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // CorrectAnswerNotifier
            // 
            this.CorrectAnswerNotifier.AutoSize = true;
            this.CorrectAnswerNotifier.BackColor = System.Drawing.Color.White;
            this.CorrectAnswerNotifier.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswerNotifier.Image = ((System.Drawing.Image)(resources.GetObject("CorrectAnswerNotifier.Image")));
            this.CorrectAnswerNotifier.Location = new System.Drawing.Point(621, 160);
            this.CorrectAnswerNotifier.MaximumSize = new System.Drawing.Size(175, 150);
            this.CorrectAnswerNotifier.Name = "CorrectAnswerNotifier";
            this.CorrectAnswerNotifier.Size = new System.Drawing.Size(160, 16);
            this.CorrectAnswerNotifier.TabIndex = 17;
            this.CorrectAnswerNotifier.Text = "Correct Answer Notifier";
            this.CorrectAnswerNotifier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CorrectAnswerNotifier.Visible = false;
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.Color.White;
            this.FinishButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Image = ((System.Drawing.Image)(resources.GetObject("FinishButton.Image")));
            this.FinishButton.Location = new System.Drawing.Point(690, 391);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(98, 47);
            this.FinishButton.TabIndex = 18;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Visible = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // QuizPageForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(793, 441);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CorrectAnswerNotifier);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.QuizProgressLabel);
            this.Controls.Add(this.ChoiceDButton);
            this.Controls.Add(this.ChoiceBButton);
            this.Controls.Add(this.ChoiceCButton);
            this.Controls.Add(this.ImageForQuestionBox);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.ChoiceAButton);
            this.Controls.Add(this.BackgroundBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizPageForm";
            this.Text = "GeoSavvy";
            this.Load += new System.EventHandler(this.QuizPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageForQuestionBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChoiceAButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.PictureBox ImageForQuestionBox;
        private System.Windows.Forms.PictureBox BackgroundBox;
        private System.Windows.Forms.Button ChoiceCButton;
        private System.Windows.Forms.Button ChoiceBButton;
        private System.Windows.Forms.Button ChoiceDButton;
        private System.Windows.Forms.Label QuizProgressLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Label CorrectAnswerNotifier;
        private System.Windows.Forms.Button FinishButton;
    }
}


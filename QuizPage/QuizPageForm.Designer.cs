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
            this.MuteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageForQuestionBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChoiceAButton
            // 
            this.ChoiceAButton.BackColor = System.Drawing.Color.White;
            this.ChoiceAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceAButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceAButton.ForeColor = System.Drawing.Color.Aqua;
            this.ChoiceAButton.Image = ((System.Drawing.Image)(resources.GetObject("ChoiceAButton.Image")));
            this.ChoiceAButton.Location = new System.Drawing.Point(517, 542);
            this.ChoiceAButton.Name = "ChoiceAButton";
            this.ChoiceAButton.Size = new System.Drawing.Size(164, 81);
            this.ChoiceAButton.TabIndex = 1;
            this.ChoiceAButton.Text = "A";
            this.ChoiceAButton.UseVisualStyleBackColor = false;
            this.ChoiceAButton.Click += new System.EventHandler(this.ChoiceAButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.BackColor = System.Drawing.Color.White;
            this.QuestionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Image = ((System.Drawing.Image)(resources.GetObject("QuestionLabel.Image")));
            this.QuestionLabel.Location = new System.Drawing.Point(329, 9);
            this.QuestionLabel.MaximumSize = new System.Drawing.Size(364, 150);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(73, 21);
            this.QuestionLabel.TabIndex = 5;
            this.QuestionLabel.Text = "Question";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ImageForQuestionBox
            // 
            this.ImageForQuestionBox.BackColor = System.Drawing.Color.White;
            this.ImageForQuestionBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImageForQuestionBox.Location = new System.Drawing.Point(332, 68);
            this.ImageForQuestionBox.Name = "ImageForQuestionBox";
            this.ImageForQuestionBox.Size = new System.Drawing.Size(300, 200);
            this.ImageForQuestionBox.TabIndex = 9;
            this.ImageForQuestionBox.TabStop = false;
            // 
            // BackgroundBox
            // 
            this.BackgroundBox.BackColor = System.Drawing.Color.Silver;
            this.BackgroundBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundBox.Location = new System.Drawing.Point(0, -2);
            this.BackgroundBox.Name = "BackgroundBox";
            this.BackgroundBox.Size = new System.Drawing.Size(1563, 762);
            this.BackgroundBox.TabIndex = 10;
            this.BackgroundBox.TabStop = false;
            // 
            // ChoiceCButton
            // 
            this.ChoiceCButton.BackColor = System.Drawing.Color.White;
            this.ChoiceCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceCButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceCButton.ForeColor = System.Drawing.Color.Aqua;
            this.ChoiceCButton.Image = ((System.Drawing.Image)(resources.GetObject("ChoiceCButton.Image")));
            this.ChoiceCButton.Location = new System.Drawing.Point(517, 655);
            this.ChoiceCButton.Name = "ChoiceCButton";
            this.ChoiceCButton.Size = new System.Drawing.Size(164, 81);
            this.ChoiceCButton.TabIndex = 11;
            this.ChoiceCButton.Text = "C";
            this.ChoiceCButton.UseVisualStyleBackColor = false;
            this.ChoiceCButton.Click += new System.EventHandler(this.ChoiceCButton_Click);
            // 
            // ChoiceBButton
            // 
            this.ChoiceBButton.BackColor = System.Drawing.Color.White;
            this.ChoiceBButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceBButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceBButton.ForeColor = System.Drawing.Color.Aqua;
            this.ChoiceBButton.Image = ((System.Drawing.Image)(resources.GetObject("ChoiceBButton.Image")));
            this.ChoiceBButton.Location = new System.Drawing.Point(701, 542);
            this.ChoiceBButton.Name = "ChoiceBButton";
            this.ChoiceBButton.Size = new System.Drawing.Size(164, 81);
            this.ChoiceBButton.TabIndex = 12;
            this.ChoiceBButton.Text = "B";
            this.ChoiceBButton.UseVisualStyleBackColor = false;
            this.ChoiceBButton.Click += new System.EventHandler(this.ChoiceBButton_Click);
            // 
            // ChoiceDButton
            // 
            this.ChoiceDButton.BackColor = System.Drawing.Color.White;
            this.ChoiceDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoiceDButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoiceDButton.ForeColor = System.Drawing.Color.Aqua;
            this.ChoiceDButton.Image = ((System.Drawing.Image)(resources.GetObject("ChoiceDButton.Image")));
            this.ChoiceDButton.Location = new System.Drawing.Point(701, 655);
            this.ChoiceDButton.Name = "ChoiceDButton";
            this.ChoiceDButton.Size = new System.Drawing.Size(164, 81);
            this.ChoiceDButton.TabIndex = 13;
            this.ChoiceDButton.Text = "D";
            this.ChoiceDButton.UseVisualStyleBackColor = false;
            this.ChoiceDButton.Click += new System.EventHandler(this.ChoiceDButton_Click);
            // 
            // QuizProgressLabel
            // 
            this.QuizProgressLabel.AutoSize = true;
            this.QuizProgressLabel.BackColor = System.Drawing.Color.White;
            this.QuizProgressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizProgressLabel.Image = ((System.Drawing.Image)(resources.GetObject("QuizProgressLabel.Image")));
            this.QuizProgressLabel.Location = new System.Drawing.Point(1360, 9);
            this.QuizProgressLabel.MaximumSize = new System.Drawing.Size(364, 150);
            this.QuizProgressLabel.Name = "QuizProgressLabel";
            this.QuizProgressLabel.Size = new System.Drawing.Size(88, 21);
            this.QuizProgressLabel.TabIndex = 14;
            this.QuizProgressLabel.Text = "Question #";
            this.QuizProgressLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(5, 662);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(166, 74);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "Back to Menu";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.BackColor = System.Drawing.Color.White;
            this.NextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextQuestionButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("NextQuestionButton.Image")));
            this.NextQuestionButton.Location = new System.Drawing.Point(1038, 672);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(112, 64);
            this.NextQuestionButton.TabIndex = 16;
            this.NextQuestionButton.Text = "Next Question";
            this.NextQuestionButton.UseVisualStyleBackColor = false;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // CorrectAnswerNotifier
            // 
            this.CorrectAnswerNotifier.AutoSize = true;
            this.CorrectAnswerNotifier.BackColor = System.Drawing.Color.White;
            this.CorrectAnswerNotifier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswerNotifier.Image = ((System.Drawing.Image)(resources.GetObject("CorrectAnswerNotifier.Image")));
            this.CorrectAnswerNotifier.Location = new System.Drawing.Point(1087, 252);
            this.CorrectAnswerNotifier.MaximumSize = new System.Drawing.Size(175, 150);
            this.CorrectAnswerNotifier.Name = "CorrectAnswerNotifier";
            this.CorrectAnswerNotifier.Size = new System.Drawing.Size(174, 21);
            this.CorrectAnswerNotifier.TabIndex = 17;
            this.CorrectAnswerNotifier.Text = "Correct Answer Notifier";
            this.CorrectAnswerNotifier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CorrectAnswerNotifier.Visible = false;
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.Color.White;
            this.FinishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.Image = ((System.Drawing.Image)(resources.GetObject("FinishButton.Image")));
            this.FinishButton.Location = new System.Drawing.Point(1182, 672);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(112, 64);
            this.FinishButton.TabIndex = 18;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Visible = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // MuteButton
            // 
            this.MuteButton.BackColor = System.Drawing.Color.Transparent;
            this.MuteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MuteButton.BackgroundImage")));
            this.MuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuteButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuteButton.ForeColor = System.Drawing.Color.Transparent;
            this.MuteButton.Location = new System.Drawing.Point(1437, 705);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(52, 41);
            this.MuteButton.TabIndex = 19;
            this.MuteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MuteButton.UseVisualStyleBackColor = false;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // QuizPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1562, 758);
            this.Controls.Add(this.MuteButton);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Button MuteButton;
    }
}


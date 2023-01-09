
namespace QuizGame
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblQuestion = new System.Windows.Forms.Label();
            this.Ans2 = new System.Windows.Forms.Button();
            this.Ans1 = new System.Windows.Forms.Button();
            this.Ans3 = new System.Windows.Forms.Button();
            this.Ans4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuizGame.Properties.Resources.genshinimpact;
            this.pictureBox1.Location = new System.Drawing.Point(26, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LblQuestion
            // 
            this.LblQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblQuestion.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblQuestion.Location = new System.Drawing.Point(26, 370);
            this.LblQuestion.Name = "LblQuestion";
            this.LblQuestion.Size = new System.Drawing.Size(750, 41);
            this.LblQuestion.TabIndex = 1;
            this.LblQuestion.Text = "Question";
            this.LblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ans2
            // 
            this.Ans2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ans2.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ans2.Location = new System.Drawing.Point(408, 432);
            this.Ans2.Name = "Ans2";
            this.Ans2.Size = new System.Drawing.Size(368, 43);
            this.Ans2.TabIndex = 3;
            this.Ans2.Tag = "2";
            this.Ans2.Text = "Answer 2";
            this.Ans2.UseVisualStyleBackColor = false;
            this.Ans2.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // Ans1
            // 
            this.Ans1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ans1.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ans1.Location = new System.Drawing.Point(26, 432);
            this.Ans1.Name = "Ans1";
            this.Ans1.Size = new System.Drawing.Size(368, 43);
            this.Ans1.TabIndex = 4;
            this.Ans1.Tag = "1";
            this.Ans1.Text = "Answer 1";
            this.Ans1.UseVisualStyleBackColor = false;
            this.Ans1.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // Ans3
            // 
            this.Ans3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ans3.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ans3.Location = new System.Drawing.Point(26, 481);
            this.Ans3.Name = "Ans3";
            this.Ans3.Size = new System.Drawing.Size(368, 43);
            this.Ans3.TabIndex = 5;
            this.Ans3.Tag = "3";
            this.Ans3.Text = "Answer 3";
            this.Ans3.UseVisualStyleBackColor = false;
            this.Ans3.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // Ans4
            // 
            this.Ans4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ans4.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ans4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ans4.Location = new System.Drawing.Point(408, 481);
            this.Ans4.Name = "Ans4";
            this.Ans4.Size = new System.Drawing.Size(368, 43);
            this.Ans4.TabIndex = 6;
            this.Ans4.Tag = "4";
            this.Ans4.Text = "Answer 4";
            this.Ans4.UseVisualStyleBackColor = false;
            this.Ans4.Click += new System.EventHandler(this.CheckAnswerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.Ans4);
            this.Controls.Add(this.Ans3);
            this.Controls.Add(this.Ans1);
            this.Controls.Add(this.Ans2);
            this.Controls.Add(this.LblQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblQuestion;
        private System.Windows.Forms.Button Ans2;
        private System.Windows.Forms.Button Ans1;
        private System.Windows.Forms.Button Ans3;
        private System.Windows.Forms.Button Ans4;
    }
}


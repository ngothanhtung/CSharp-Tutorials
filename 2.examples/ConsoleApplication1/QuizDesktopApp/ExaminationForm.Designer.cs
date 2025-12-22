namespace QuizDesktopApp
{
    partial class ExaminationForm
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
            labelQuestionContent = new Label();
            buttonNext = new Button();
            textBoxAnswer = new TextBox();
            buttonOption1 = new Button();
            buttonOption2 = new Button();
            buttonOption3 = new Button();
            buttonOption4 = new Button();
            SuspendLayout();
            // 
            // labelQuestionContent
            // 
            labelQuestionContent.AutoSize = true;
            labelQuestionContent.Location = new Point(38, 26);
            labelQuestionContent.Name = "labelQuestionContent";
            labelQuestionContent.Size = new Size(113, 15);
            labelQuestionContent.TabIndex = 0;
            labelQuestionContent.Text = "Question Content ...";
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(713, 415);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(75, 23);
            buttonNext.TabIndex = 1;
            buttonNext.Text = "Tiếp tục";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Location = new Point(38, 57);
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(733, 23);
            textBoxAnswer.TabIndex = 2;
            // 
            // buttonOption1
            // 
            buttonOption1.Location = new Point(38, 104);
            buttonOption1.Name = "buttonOption1";
            buttonOption1.Size = new Size(733, 23);
            buttonOption1.TabIndex = 3;
            buttonOption1.Text = "A. ";
            buttonOption1.TextAlign = ContentAlignment.MiddleLeft;
            buttonOption1.UseVisualStyleBackColor = true;
            // 
            // buttonOption2
            // 
            buttonOption2.Location = new Point(38, 133);
            buttonOption2.Name = "buttonOption2";
            buttonOption2.Size = new Size(733, 23);
            buttonOption2.TabIndex = 4;
            buttonOption2.Text = "B. ";
            buttonOption2.TextAlign = ContentAlignment.MiddleLeft;
            buttonOption2.UseVisualStyleBackColor = true;
            // 
            // buttonOption3
            // 
            buttonOption3.Location = new Point(38, 162);
            buttonOption3.Name = "buttonOption3";
            buttonOption3.Size = new Size(733, 23);
            buttonOption3.TabIndex = 5;
            buttonOption3.Text = "C. ";
            buttonOption3.TextAlign = ContentAlignment.MiddleLeft;
            buttonOption3.UseVisualStyleBackColor = true;
            // 
            // buttonOption4
            // 
            buttonOption4.Location = new Point(38, 191);
            buttonOption4.Name = "buttonOption4";
            buttonOption4.Size = new Size(733, 23);
            buttonOption4.TabIndex = 6;
            buttonOption4.Text = "D. ";
            buttonOption4.TextAlign = ContentAlignment.MiddleLeft;
            buttonOption4.UseVisualStyleBackColor = true;
            // 
            // ExaminationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOption4);
            Controls.Add(buttonOption3);
            Controls.Add(buttonOption2);
            Controls.Add(buttonOption1);
            Controls.Add(textBoxAnswer);
            Controls.Add(buttonNext);
            Controls.Add(labelQuestionContent);
            Name = "ExaminationForm";
            Text = "ExaminationForm";
            Load += ExaminationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQuestionContent;
        private Button buttonNext;
        private TextBox textBoxAnswer;
        private Button buttonOption1;
        private Button buttonOption2;
        private Button buttonOption3;
        private Button buttonOption4;
    }
}
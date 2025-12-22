namespace QuizDesktopApp
{
    partial class FillInTheBlankQuestionForm
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
            buttonSave = new Button();
            label2 = new Label();
            textBoxCorrectAnswer = new TextBox();
            label1 = new Label();
            textBoxQuestionContent = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(176, 105);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Tạo mới";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 79);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 8;
            label2.Text = "CorrectAnswer:";
            // 
            // textBoxCorrectAnswer
            // 
            textBoxCorrectAnswer.Location = new Point(176, 76);
            textBoxCorrectAnswer.Name = "textBoxCorrectAnswer";
            textBoxCorrectAnswer.Size = new Size(400, 23);
            textBoxCorrectAnswer.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 50);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 6;
            label1.Text = "Question Content:";
            // 
            // textBoxQuestionContent
            // 
            textBoxQuestionContent.Location = new Point(176, 47);
            textBoxQuestionContent.Name = "textBoxQuestionContent";
            textBoxQuestionContent.Size = new Size(400, 23);
            textBoxQuestionContent.TabIndex = 5;
            // 
            // FillInTheBlankQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSave);
            Controls.Add(label2);
            Controls.Add(textBoxCorrectAnswer);
            Controls.Add(label1);
            Controls.Add(textBoxQuestionContent);
            Name = "FillInTheBlankQuestionForm";
            Text = "FillInTheBlankQuestionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label2;
        private TextBox textBoxCorrectAnswer;
        private Label label1;
        private TextBox textBoxQuestionContent;
    }
}
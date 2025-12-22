namespace QuizDesktopApp
{
    partial class OneChoiceQuestionForm
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
            textBoxCorrectAnswer = new TextBox();
            textBoxQuestionContent = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textBoxOption1 = new TextBox();
            label4 = new Label();
            textBoxOption2 = new TextBox();
            label5 = new Label();
            textBoxOption3 = new TextBox();
            label6 = new Label();
            textBoxOption4 = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(183, 224);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Tạo mới";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxCorrectAnswer
            // 
            textBoxCorrectAnswer.Location = new Point(183, 79);
            textBoxCorrectAnswer.Name = "textBoxCorrectAnswer";
            textBoxCorrectAnswer.Size = new Size(400, 23);
            textBoxCorrectAnswer.TabIndex = 6;
            // 
            // textBoxQuestionContent
            // 
            textBoxQuestionContent.Location = new Point(183, 50);
            textBoxQuestionContent.Name = "textBoxQuestionContent";
            textBoxQuestionContent.Size = new Size(400, 23);
            textBoxQuestionContent.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 82);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 9;
            label2.Text = "CorrectAnswer:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 53);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 8;
            label1.Text = "Question Content:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 111);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 11;
            label3.Text = "Option 1:";
            // 
            // textBoxOption1
            // 
            textBoxOption1.Location = new Point(183, 108);
            textBoxOption1.Name = "textBoxOption1";
            textBoxOption1.Size = new Size(400, 23);
            textBoxOption1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 140);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 13;
            label4.Text = "Option 2:";
            // 
            // textBoxOption2
            // 
            textBoxOption2.Location = new Point(183, 137);
            textBoxOption2.Name = "textBoxOption2";
            textBoxOption2.Size = new Size(400, 23);
            textBoxOption2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 169);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 15;
            label5.Text = "Option 3:";
            // 
            // textBoxOption3
            // 
            textBoxOption3.Location = new Point(183, 166);
            textBoxOption3.Name = "textBoxOption3";
            textBoxOption3.Size = new Size(400, 23);
            textBoxOption3.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 198);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 17;
            label6.Text = "Option 4:";
            // 
            // textBoxOption4
            // 
            textBoxOption4.Location = new Point(183, 195);
            textBoxOption4.Name = "textBoxOption4";
            textBoxOption4.Size = new Size(400, 23);
            textBoxOption4.TabIndex = 16;
            // 
            // OneChoiceQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBoxOption4);
            Controls.Add(label5);
            Controls.Add(textBoxOption3);
            Controls.Add(label4);
            Controls.Add(textBoxOption2);
            Controls.Add(label3);
            Controls.Add(textBoxOption1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(textBoxCorrectAnswer);
            Controls.Add(textBoxQuestionContent);
            Name = "OneChoiceQuestionForm";
            Text = "OneChoiceQuestionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private TextBox textBoxCorrectAnswer;
        private TextBox textBoxQuestionContent;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBoxOption1;
        private Label label4;
        private TextBox textBoxOption2;
        private Label label5;
        private TextBox textBoxOption3;
        private Label label6;
        private TextBox textBoxOption4;
    }
}
namespace QuizDesktopApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOpenOneChoiceQuestionForm = new Button();
            buttonOpenFillInTheBlankQuestionForm = new Button();
            buttonOpenExaminationsForm = new Button();
            SuspendLayout();
            // 
            // buttonOpenOneChoiceQuestionForm
            // 
            buttonOpenOneChoiceQuestionForm.Location = new Point(360, 178);
            buttonOpenOneChoiceQuestionForm.Name = "buttonOpenOneChoiceQuestionForm";
            buttonOpenOneChoiceQuestionForm.Size = new Size(161, 23);
            buttonOpenOneChoiceQuestionForm.TabIndex = 5;
            buttonOpenOneChoiceQuestionForm.Text = "Tạo mới One Choice Question";
            buttonOpenOneChoiceQuestionForm.UseVisualStyleBackColor = true;
            buttonOpenOneChoiceQuestionForm.Click += buttonOpenOneChoiceQuestionForm_Click;
            // 
            // buttonOpenFillInTheBlankQuestionForm
            // 
            buttonOpenFillInTheBlankQuestionForm.Location = new Point(94, 178);
            buttonOpenFillInTheBlankQuestionForm.Name = "buttonOpenFillInTheBlankQuestionForm";
            buttonOpenFillInTheBlankQuestionForm.Size = new Size(260, 23);
            buttonOpenFillInTheBlankQuestionForm.TabIndex = 6;
            buttonOpenFillInTheBlankQuestionForm.Text = "Tạo mới Fill In The Blank Question";
            buttonOpenFillInTheBlankQuestionForm.UseVisualStyleBackColor = true;
            buttonOpenFillInTheBlankQuestionForm.Click += buttonOpenFillInTheBlankQuestionForm_Click;
            // 
            // buttonOpenExaminationsForm
            // 
            buttonOpenExaminationsForm.Location = new Point(202, 113);
            buttonOpenExaminationsForm.Name = "buttonOpenExaminationsForm";
            buttonOpenExaminationsForm.Size = new Size(260, 23);
            buttonOpenExaminationsForm.TabIndex = 7;
            buttonOpenExaminationsForm.Text = "Danh sách kỳ thi";
            buttonOpenExaminationsForm.UseVisualStyleBackColor = true;
            buttonOpenExaminationsForm.Click += buttonOpenExaminationsForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 388);
            Controls.Add(buttonOpenExaminationsForm);
            Controls.Add(buttonOpenFillInTheBlankQuestionForm);
            Controls.Add(buttonOpenOneChoiceQuestionForm);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion
        private Button buttonOpenOneChoiceQuestionForm;
        private Button buttonOpenFillInTheBlankQuestionForm;
        private Button buttonOpenExaminationsForm;
    }
}

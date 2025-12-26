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
            buttonCreateStudent = new Button();
            buttonUpdateStudent = new Button();
            buttonDeleteStudent = new Button();
            buttonGetStudents = new Button();
            buttonCreateBook = new Button();
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
            // buttonCreateStudent
            // 
            buttonCreateStudent.Location = new Point(12, 353);
            buttonCreateStudent.Name = "buttonCreateStudent";
            buttonCreateStudent.Size = new Size(135, 23);
            buttonCreateStudent.TabIndex = 8;
            buttonCreateStudent.Text = "Create Student";
            buttonCreateStudent.UseVisualStyleBackColor = true;
            buttonCreateStudent.Click += buttonCreateStudent_Click;
            // 
            // buttonUpdateStudent
            // 
            buttonUpdateStudent.Location = new Point(153, 353);
            buttonUpdateStudent.Name = "buttonUpdateStudent";
            buttonUpdateStudent.Size = new Size(135, 23);
            buttonUpdateStudent.TabIndex = 9;
            buttonUpdateStudent.Text = "Update Student";
            buttonUpdateStudent.UseVisualStyleBackColor = true;
            buttonUpdateStudent.Click += buttonUpdateStudent_Click;
            // 
            // buttonDeleteStudent
            // 
            buttonDeleteStudent.Location = new Point(294, 353);
            buttonDeleteStudent.Name = "buttonDeleteStudent";
            buttonDeleteStudent.Size = new Size(135, 23);
            buttonDeleteStudent.TabIndex = 10;
            buttonDeleteStudent.Text = "Delete Student";
            buttonDeleteStudent.UseVisualStyleBackColor = true;
            buttonDeleteStudent.Click += buttonDeleteStudent_Click;
            // 
            // buttonGetStudents
            // 
            buttonGetStudents.Location = new Point(435, 353);
            buttonGetStudents.Name = "buttonGetStudents";
            buttonGetStudents.Size = new Size(159, 23);
            buttonGetStudents.TabIndex = 11;
            buttonGetStudents.Text = "Get Students";
            buttonGetStudents.UseVisualStyleBackColor = true;
            buttonGetStudents.Click += buttonGetStudents_Click;
            // 
            // buttonCreateBook
            // 
            buttonCreateBook.Location = new Point(12, 300);
            buttonCreateBook.Name = "buttonCreateBook";
            buttonCreateBook.Size = new Size(135, 23);
            buttonCreateBook.TabIndex = 12;
            buttonCreateBook.Text = "Create Book";
            buttonCreateBook.UseVisualStyleBackColor = true;
            buttonCreateBook.Click += buttonCreateBook_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 388);
            Controls.Add(buttonCreateBook);
            Controls.Add(buttonGetStudents);
            Controls.Add(buttonDeleteStudent);
            Controls.Add(buttonUpdateStudent);
            Controls.Add(buttonCreateStudent);
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
        private Button buttonCreateStudent;
        private Button buttonUpdateStudent;
        private Button buttonDeleteStudent;
        private Button buttonGetStudents;
        private Button buttonCreateBook;
    }
}

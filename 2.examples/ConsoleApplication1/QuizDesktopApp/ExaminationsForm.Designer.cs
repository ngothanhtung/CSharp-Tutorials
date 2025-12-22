namespace QuizDesktopApp
{
    partial class ExaminationsForm
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
            comboBoxExaminations = new ComboBox();
            label1 = new Label();
            buttonSelectExamination = new Button();
            SuspendLayout();
            // 
            // comboBoxExaminations
            // 
            comboBoxExaminations.DisplayMember = "Name";
            comboBoxExaminations.FormattingEnabled = true;
            comboBoxExaminations.Location = new Point(195, 60);
            comboBoxExaminations.Name = "comboBoxExaminations";
            comboBoxExaminations.Size = new Size(495, 23);
            comboBoxExaminations.TabIndex = 0;
            comboBoxExaminations.ValueMember = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 63);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Chọn kỳ thi:";
            // 
            // buttonSelectExamination
            // 
            buttonSelectExamination.Location = new Point(195, 89);
            buttonSelectExamination.Name = "buttonSelectExamination";
            buttonSelectExamination.Size = new Size(75, 23);
            buttonSelectExamination.TabIndex = 2;
            buttonSelectExamination.Text = "Chọn";
            buttonSelectExamination.UseVisualStyleBackColor = true;
            buttonSelectExamination.Click += buttonSelectExamination_Click;
            // 
            // ExaminationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSelectExamination);
            Controls.Add(label1);
            Controls.Add(comboBoxExaminations);
            Name = "ExaminationsForm";
            Text = "ExaminationsForm";
            Load += ExaminationsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxExaminations;
        private Label label1;
        private Button buttonSelectExamination;
    }
}
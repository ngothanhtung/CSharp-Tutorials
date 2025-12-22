using QuizLibrary;

namespace QuizDesktopApp
{
    public partial class FillInTheBlankQuestionForm : Form
    {
        public FillInTheBlankQuestionForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FillInTheBlankQuestion question = new FillInTheBlankQuestion
            {
                QuestionContent = textBoxQuestionContent.Text,
                CorrectAnswer = textBoxCorrectAnswer.Text,
                QuestionType = "FillInTheBlankQuestion"
            };

            question.SaveDataToDatabase();

            MessageBox.Show("Tạo mới thành công!", "Thông báo");

            textBoxQuestionContent.Text = "";
            textBoxCorrectAnswer.Text = "";
        }
    }
}

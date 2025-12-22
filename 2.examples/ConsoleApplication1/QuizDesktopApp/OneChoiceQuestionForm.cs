using QuizLibrary;

namespace QuizDesktopApp
{
    public partial class OneChoiceQuestionForm : Form
    {
        public OneChoiceQuestionForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            OneChoiceQuestion question = new OneChoiceQuestion
            {
                QuestionContent = textBoxQuestionContent.Text,
                CorrectAnswer = textBoxCorrectAnswer.Text,
                Option1 = textBoxOption1.Text,
                Option2 = textBoxOption2.Text,
                Option3 = textBoxOption3.Text,
                Option4 = textBoxOption4.Text,
                QuestionType = "OneChoiceQuestion"
            };

            question.SaveDataToDatabase();


            MessageBox.Show("Tạo mới thành công!", "Thông báo");

            textBoxQuestionContent.Text = "";
            textBoxCorrectAnswer.Text = "";
            textBoxOption1.Text = "";
            textBoxOption2.Text = "";
            textBoxOption3.Text = "";
            textBoxOption4.Text = "";
        }
    }
}

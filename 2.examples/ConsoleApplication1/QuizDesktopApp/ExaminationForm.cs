using QuizLibrary;

namespace QuizDesktopApp
{
    public partial class ExaminationForm : Form
    {
        private int questionIndex = 0;


        private IList<Question> questions = new List<Question>();

        public Guid ExaminationId { get; set; }

        public ExaminationForm()
        {
            InitializeComponent();
        }

        private void ExaminationForm_Load(object sender, EventArgs e)
        {
            this.questions = Examination.GetQuestions(ExaminationId);
            var question = questions[questionIndex];


            labelQuestionContent.Text = question.QuestionContent;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện để chuyển sang câu hỏi tiếp theo
            if (questionIndex < questions.Count)
            {
                questionIndex += 1;
                var question = questions[questionIndex];
                // Kiểm tra loại câu hỏi và hiển thị giao diện tương ứng
                labelQuestionContent.Text = question.QuestionContent;

                if (question.QuestionType == "OneChoiceQuestion")
                {
                    textBoxAnswer.Visible = false;
                    buttonOption1.Visible = true;
                    buttonOption2.Visible = true;
                    buttonOption3.Visible = true;
                    buttonOption4.Visible = true;
                }
                else if (question.QuestionType == "FillInTheBlankQuestion")
                {
                    textBoxAnswer.Visible = true;
                    buttonOption1.Visible = false;
                    buttonOption2.Visible = false;
                    buttonOption3.Visible = false;
                    buttonOption4.Visible = false;
                }
            }
        }
    }
}

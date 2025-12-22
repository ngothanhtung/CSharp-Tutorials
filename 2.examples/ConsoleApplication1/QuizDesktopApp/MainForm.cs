namespace QuizDesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void buttonOpenOneChoiceQuestionForm_Click(object sender, EventArgs e)
        {
            var form = new OneChoiceQuestionForm();
            form.ShowDialog(this);
        }

        private void buttonOpenFillInTheBlankQuestionForm_Click(object sender, EventArgs e)
        {
            var form = new FillInTheBlankQuestionForm();
            form.ShowDialog(this);
        }

        private void buttonOpenExaminationsForm_Click(object sender, EventArgs e)
        {
            var form = new ExaminationsForm();
            form.ShowDialog(this);
        }
    }
}

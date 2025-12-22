using QuizLibrary;

namespace QuizDesktopApp
{
    public partial class ExaminationsForm : Form
    {
        public ExaminationsForm()
        {
            InitializeComponent();
        }

        private void ExaminationsForm_Load(object sender, EventArgs e)
        {

            var examinations = Examination.GetAllExaminations();

            comboBoxExaminations.DataSource = examinations;


        }

        private void buttonSelectExamination_Click(object sender, EventArgs e)
        {
            var examinationId = new Guid(comboBoxExaminations.SelectedValue?.ToString() ?? string.Empty);
            if (examinationId != Guid.Empty)
            {
                var examinationForm = new ExaminationForm();
                examinationForm.ExaminationId = examinationId;
                examinationForm.ShowDialog();
            }
        }
    }
}

using EntityFrameworkQuizLibrary;

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

        private void buttonCreateStudent_Click(object sender, EventArgs e)
        {
            using var context = new QuizContext();

            var student1 = new Student()
            {
                Id = 6,
                Name = "Tom Cruise",
                Age = 58,
                Email = "tomcruise@gmail.com"
            };

            context.Students.Add(student1);

            context.SaveChanges();
        }

        private void buttonUpdateStudent_Click(object sender, EventArgs e)
        {
            using var context = new QuizContext();
            // Lambda expression

            var student = context.Students.First(s => s.Id == 5);
            student.Name = "Peter Pan";
            student.Email = "peter@gmail.com";

            // Sql: Update Students SET Name = 'Peter Pan' WHERE Id = 5

            context.SaveChanges();
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            using var context = new QuizContext();
            var student = context.Students.First(s => s.Id == 2);
            context.Students.Remove(student);
            context.SaveChanges();
        }

        private void buttonGetStudents_Click(object sender, EventArgs e)
        {

            using var context = new QuizContext();
            // Trường hợp chỉ đọc dữ liệu, không cần theo dõi thay đổi
            // var students = context.Students.AsNoTracking().ToList();

            // Trường hợp cần theo dõi thay đổi
            var students = context.Students.Where(s => s.Age >= 30).ToList();
        }

        private void buttonCreateBook_Click(object sender, EventArgs e)
        {
            using var context = new QuizContext();
            var book1 = new Book()
            {
                Id = Guid.NewGuid(),
                Title = "C# Programming",
                Author = "John Doe",
                PublishedYear = 2020
            };

            context.Books.Add(book1);
            context.SaveChanges();
        }
    }
}

using Microsoft.Data.SqlClient;

namespace QuizLibrary
{
    public class Examination
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }


        public static IList<Question> GetQuestions(Guid id)
        {
            var questions = new List<Question>();

            const string connectionString = "server=server.softech.cloud;database=Quiz;user=developer;password=123456789;Encrypt=True;TrustServerCertificate=True;";
            var sqlConnection = new SqlConnection(connectionString);

            try
            {
                const string sql = "SELECT Q.* FROM Questions AS Q INNER JOIN Examinations_Questions AS E ON Q.Id = E.QuestionId WHERE E.ExaminationId = @ExaminationId ORDER BY SortOrder";
                var sqlCommand = new SqlCommand(sql, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@ExaminationId", id);

                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    var questionType = (string)reader["QuestionType"];
                    if (questionType == "OneChoiceQuestion")
                    {
                        var question = new OneChoiceQuestion();
                        question.Id = (Guid)reader["Id"];
                        question.QuestionContent = (string)reader["QuestionContent"];
                        question.CorrectAnswer = (string)reader["CorrectAnswer"];
                        question.Option1 = (string)reader["Option1"];
                        question.Option2 = (string)reader["Option2"];
                        question.Option3 = (string)reader["Option3"];
                        question.Option4 = (string)reader["Option4"];
                        questions.Add(question);

                    }
                    else if (questionType == "FillInTheBlankQuestion")
                    {
                        var question = new FillInTheBlankQuestion();
                        question.Id = (Guid)reader["Id"];
                        question.QuestionContent = (string)reader["QuestionContent"];
                        question.CorrectAnswer = (string)reader["CorrectAnswer"];
                        questions.Add(question);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return new List<Question>(0);
            }
            finally
            {
                sqlConnection.Close();
            }

            return questions;
        }

        public static IList<Examination> GetAllExaminations()
        {
            var examinations = new List<Examination>();

            const string connectionString = "server=server.softech.cloud;database=Quiz;user=developer;password=123456789;Encrypt=True;TrustServerCertificate=True;";
            var sqlConnection = new SqlConnection(connectionString);

            const string sql = "SELECT * FROM Examinations";
            var sqlCommand = new SqlCommand(sql, sqlConnection);

            sqlConnection.Open();
            var reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                var examination = new Examination();
                examination.Id = (Guid)reader["Id"];
                examination.Name = (string)reader["Name"];
                examination.Duration = (int)reader["Duration"];

                examinations.Add(examination);
            }

            sqlConnection.Close();

            return examinations;
        }

        public void Start(Guid id)
        {
            var questions = Examination.GetQuestions(id);

            Console.WriteLine("====================================================================");
            Console.WriteLine("                        Welcome to the Quiz!                       ");
            Console.WriteLine("====================================================================");

            foreach (var question in questions)
            {
                question.Display();
            }
        }
    }
}

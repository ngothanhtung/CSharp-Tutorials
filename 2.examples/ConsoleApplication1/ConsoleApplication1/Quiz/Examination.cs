using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ConsoleApplication1.Quiz
{
    internal class Examination
    {
        public IList<Question> GetQuestions(Guid id)
        {
            var questions = new List<Question>();

            const string connectionString = "server=server.softech.cloud;database=Quiz;user=developer;password=123456789;";
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

        public void Start(Guid id)
        {
            var questions = this.GetQuestions(id);

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

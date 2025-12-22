using Microsoft.Data.SqlClient;

namespace QuizLibrary
{
    public class FillInTheBlankQuestion : Question
    {
        public override bool CheckAnswer(string answer)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine(QuestionContent);
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Let's fill in the blank!");
            System.Console.WriteLine("------------------------------------");
            Console.Write("Please enter your answer: ");
            var answer = Console.ReadLine();
            if (answer == this.CorrectAnswer)
            {
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("Congratulations! Your answer is correct");
                System.Console.WriteLine("------------------------------------");
            }
            else
            {
                System.Console.WriteLine("------------------------------------");
                System.Console.WriteLine("Sorry! Your answer is incorrect");
                System.Console.WriteLine("------------------------------------");
            }
        }

        public override void SaveDataToFile(string filename)
        {
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Question: " + QuestionContent);
            System.Console.WriteLine("------------------------------------");

            using (var writer = new System.IO.StreamWriter(filename))
            {
                writer.WriteLine(this.QuestionContent);
                writer.WriteLine(this.CorrectAnswer);
            }
        }

        public override void LoadDataFromFile(string filename)
        {
            using (var reader = new System.IO.StreamReader(filename))
            {
                this.QuestionContent = reader.ReadLine();
                this.CorrectAnswer = reader.ReadLine();
            }
        }

        public override void SaveDataToDatabase()
        {
            const string connectionString = "server=server.softech.cloud;database=Quiz;user=developer;password=123456789;Encrypt=True;TrustServerCertificate=True;";
            var sqlConnection = new SqlConnection(connectionString);

            const string sql = "INSERT INTO Questions(QuestionContent, CorrectAnswer, QuestionType) VALUES(@QuestionContent, @CorrectAnswer, @QuestionType)";
            var sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@QuestionContent", this.QuestionContent);
            sqlCommand.Parameters.AddWithValue("@CorrectAnswer", this.CorrectAnswer);

            sqlCommand.Parameters.AddWithValue("@QuestionType", "FillInTheBlankQuestion");

            sqlConnection.Open();
            var rowAffected = sqlCommand.ExecuteNonQuery();
            Console.WriteLine("Rows affected: " + rowAffected);

            sqlConnection.Close();
        }

        public override void LoadDataFromDatabase(Guid id)
        {
            const string connectionString = "server=server.softech.cloud;database=Quiz;user=developer;password=123456789;Encrypt=True;TrustServerCertificate=True;";
            var sqlConnection = new SqlConnection(connectionString);

            const string sql = "SELECT * FROM Questions WHERE Id = @Id";
            var sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", id);

            sqlConnection.Open();
            var reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                this.Id = (Guid)reader["Id"];
                this.QuestionContent = (string)reader["QuestionContent"];
                this.CorrectAnswer = (string)reader["CorrectAnswer"];

                this.QuestionType = (string)reader["QuestionType"];
            }

            sqlConnection.Close();
        }
    }
}

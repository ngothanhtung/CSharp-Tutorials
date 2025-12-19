using System;
using System.Data.SqlClient;

namespace ConsoleApplication1.Quiz
{
    internal class OneChoiceQuestion : Question
    {
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }


        public override bool CheckAnswer(string answer)
        {
            return this.CorrectAnswer == answer;
        }

        public override void Display()
        {
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine(QuestionContent);
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("Let's choose a correct answer:");
            System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine("A. " + Option1);
            System.Console.WriteLine("B. " + Option2);
            System.Console.WriteLine("C. " + Option3);
            System.Console.WriteLine("D. " + Option4);
            System.Console.WriteLine("------------------------------------");
            Console.Write("Please enter your option: ");
            var answer = Console.ReadLine();

            if (this.CheckAnswer(answer))
            {
                System.Console.WriteLine("Congratulations! Your answer is correct");
            }
            else
            {
                System.Console.WriteLine("Sorry! Your answer is incorrect");
            }
        }

        public override void SaveDataToFile(string filename)
        {
            using (var writer = new System.IO.StreamWriter(filename))
            {
                writer.WriteLine("OneChoiceQuestion");
                writer.WriteLine(this.QuestionContent);
                writer.WriteLine(this.Option1);
                writer.WriteLine(this.Option2);
                writer.WriteLine(this.Option3);
                writer.WriteLine(this.Option4);
                writer.WriteLine(this.CorrectAnswer);
            }
        }

        public override void LoadDataFromFile(string filename)
        {
            using (var reader = new System.IO.StreamReader(filename))
            {
                var questionType = reader.ReadLine();
                if (questionType != "OneChoiceQuestion")
                {
                    throw new Exception("Question type mismatch");
                }

                this.QuestionContent = reader.ReadLine();
                this.Option1 = reader.ReadLine();
                this.Option2 = reader.ReadLine();
                this.Option3 = reader.ReadLine();
                this.Option4 = reader.ReadLine();
                this.CorrectAnswer = reader.ReadLine();
            }
        }

        public override void SaveDataToDatabase()
        {
            const string connectionString = "server=server.softech.cloud;database=Quiz;user=developer;password=123456789;";
            var sqlConnection = new SqlConnection(connectionString);

            const string sql = "INSERT INTO Questions(QuestionContent, CorrectAnswer, Option1, Option2, Option3, Option4) VALUES(@QuestionContent, @CorrectAnswer, @Option1, @Option2, @Option3, @Option4)";
            var sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@QuestionContent", this.QuestionContent);
            sqlCommand.Parameters.AddWithValue("@CorrectAnswer", this.CorrectAnswer);
            sqlCommand.Parameters.AddWithValue("@Option1", this.Option1);
            sqlCommand.Parameters.AddWithValue("@Option2", this.Option2);
            sqlCommand.Parameters.AddWithValue("@Option3", this.Option3);
            sqlCommand.Parameters.AddWithValue("@Option4", this.Option4);

            sqlCommand.Parameters.AddWithValue("@QuestionType", "OneChoiceQuestion");

            sqlConnection.Open();
            var rowAffected = sqlCommand.ExecuteNonQuery();
            Console.WriteLine("Rows affected: " + rowAffected);

            sqlConnection.Close();
        }

        public override void LoadDataFromDatabase(Guid id)
        {
            const string connectionString = "server=server.softech.cloud;database=Quiz;user=developer;password=123456789;";
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
                this.Option1 = (string)reader["Option1"];
                this.Option2 = (string)reader["Option2"];
                this.Option3 = (string)reader["Option3"];
                this.Option4 = (string)reader["Option4"];

                this.QuestionType = (string)reader["QuestionType"];
            }

            sqlConnection.Close();
        }
    }
}

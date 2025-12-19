using System;

namespace ConsoleApplication1.Quiz
{
    internal class MultipleChoiceQuestion : Question
    {
        public static string QuestionType = "MultipleChoiceQuestion";
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }


        public override bool CheckAnswer(string answer)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine(QuestionContent);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Let's choose a correct answer:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("A. " + Option1);
            Console.WriteLine("B. " + Option2);
            Console.WriteLine("C. " + Option3);
            Console.WriteLine("D. " + Option4);
            Console.WriteLine("------------------------------------");
            Console.Write("Please enter your options: ");
            var answer = Console.ReadLine();

            if (answer == this.CorrectAnswer)
            {
                Console.WriteLine("Congratulations! Your answer is correct");
            }
            else
            {
                Console.WriteLine("Sorry! Your answer is incorrect");
            }
        }

        public override void SaveDataToFile(string filename)
        {
            using (var writer = new System.IO.StreamWriter(filename))
            {
                writer.WriteLine(this.QuestionContent);
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
                if (questionType != MultipleChoiceQuestion.QuestionType)
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
            throw new NotImplementedException();
        }

        public override void LoadDataFromDatabase(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

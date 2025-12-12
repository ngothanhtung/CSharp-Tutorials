using System;

namespace ConsoleApplication1.Quiz
{
    internal class FillInTheBlankQuestion : Question
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
    }
}

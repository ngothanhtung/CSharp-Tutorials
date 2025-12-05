using System;

namespace ConsoleApplication1.Quiz
{
    internal class OneChoiceQuestion : Question
    {
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }


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
                this.QuestionContent = reader.ReadLine();
                this.Option1 = reader.ReadLine();
                this.Option2 = reader.ReadLine();
                this.Option3 = reader.ReadLine();
                this.Option4 = reader.ReadLine();
                this.CorrectAnswer = reader.ReadLine();
            }
        }


    }
}

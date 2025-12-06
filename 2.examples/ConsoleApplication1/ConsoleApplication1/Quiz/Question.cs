namespace ConsoleApplication1.Quiz
{
    internal abstract class Question : IQuestion
    {



        public string QuestionContent { get; set; }

        public string CorrectAnswer
        {
            get;
            set;
        }


        public bool CheckAnswer(string answer)
        {
            return answer.Equals(CorrectAnswer, System.StringComparison.OrdinalIgnoreCase);
        }

        public abstract void Display();

        public abstract void SaveDataToFile(string filename);

        public abstract void LoadDataFromFile(string filename);
    }
}

namespace ConsoleApplication1.Quiz
{
    internal abstract class Question : IQuestion
    {
        public string QuestionContent { get; set; }

        public string CorrectAnswer { get; set; }

        public abstract bool CheckAnswer(string answer);

        public abstract void Display();

        public abstract void SaveDataToFile(string filename);

        public abstract void LoadDataFromFile(string filename);
    }
}

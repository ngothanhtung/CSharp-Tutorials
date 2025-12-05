namespace ConsoleApplication1.Quiz
{
    internal abstract class Question
    {
        public string QuestionContent { get; set; }
        public string CorrectAnswer { get; set; }

        public abstract void Display();

        public abstract void SaveDataToFile(string filename);

        public abstract void LoadDataFromFile(string filename);
    }
}

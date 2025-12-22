namespace QuizLibrary
{
    public abstract class Question : IQuestion
    {
        public Guid Id { get; set; }

        public string QuestionContent { get; set; }

        public string CorrectAnswer { get; set; }

        public string QuestionType { get; set; }


        public abstract bool CheckAnswer(string answer);

        public abstract void Display();

        public abstract void SaveDataToFile(string filename);

        public abstract void LoadDataFromFile(string filename);

        public abstract void SaveDataToDatabase();

        /// <summary>
        /// Nạp dữ liệu câu hỏi từ cơ sở dữ liệu dựa trên ID
        /// </summary>
        /// <param name="id"></param>
        public abstract void LoadDataFromDatabase(System.Guid id);
    }
}

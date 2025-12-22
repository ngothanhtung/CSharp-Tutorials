namespace QuizLibrary
{
    public interface IQuestion
    {
        bool CheckAnswer(string answer);
        void Display();
        void SaveDataToFile(string filename);
        void LoadDataFromFile(string filename);

        void SaveDataToDatabase();
        void LoadDataFromDatabase(Guid id);
    }
}

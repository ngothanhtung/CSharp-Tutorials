using System;

namespace ConsoleApplication1.Quiz
{
    internal interface IQuestion
    {
        bool CheckAnswer(string answer);
        void Display();
        void SaveDataToFile(string filename);
        void LoadDataFromFile(string filename);

        void SaveDataToDatabase();
        void LoadDataFromDatabase(Guid id);
    }
}

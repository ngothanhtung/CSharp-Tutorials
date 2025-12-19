using ConsoleApplication1.Quiz;
using System;
using System.Text;

namespace ConsoleApplication1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // Set console encoding to UTF-8 for proper Vietnamese character display
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            //var s1 = new Student();
            //s1.Id = 1;
            //s1.Name = "John Doe";
            //s1.Score = 10;

            //s1.Display();





            //var t1 = new Teacher();
            //t1.Id = 101;
            //t1.Name = "Mr. Smith";
            //t1.Skill = "Mathematics";
            //t1.Display();


            //int a = 5;
            //int b = 15;

            //s1.Calculate(ref a, ref b);

            //Console.WriteLine("a: " + a);
            //Console.WriteLine("b: " + b);

            //Console.WriteLine("Grade: " + grade);
            //s1.Display1("STUDENT INFORMATION", Student.SchoolName);

            //
            // var s2 = new Student();
            // s2.Id = 2;
            // s2.Name = "Jane Smith";
            // s2.Email = "janesmith@gmail.com";
            // s2.Address = "456 Oak St, Othertown, USA";
            // s2.Age = 19;
            // s2.Score = 9;
            // s2.SaveToTextFile();
            //
            // s2.Display();

            //var ps1 = new PhanSo();
            //ps1.TuSo = 3;
            //ps1.MauSo = 4;

            //ps1.HienThi();

            //var ps2 = new PhanSo();
            //ps2.TuSo = 1;
            //ps2.MauSo = 4;

            //ps2.HienThi();

            //var ps = ps1.Cong(ps2);
            //ps.HienThi();

            //PhanSo psrg = ps.RutGon();
            //psrg.HienThi();


            //BaiTap_Chuong_03_01.Run();
            //BaiTap_Chuong_03_02.Run();
            //BaiTap_Chuong_03_03.Run();
            //BaiTap_Chuong_03_03_02.Run();


            //var q1 = new OneChoiceQuestion();
            //q1.QuestionContent = "Quốc khánh nước Việt Nam là năm nào?";
            //q1.Option1 = "1930";
            //q1.Option2 = "1945";
            //q1.Option3 = "1954";
            //q1.Option4 = "1975";
            //q1.CorrectAnswer = "1945";

            //q1.SaveDataToFile("1.txt");
            //q1.LoadDataFromFile("1.txt");
            //q1.Display();



            //Question q;

            //int index = 1;

            //for (int i = 1; i <= 5; i++)
            //{

            //    if (i % 2 == 0)
            //    {
            //        // Fill in the blank question
            //        q = new FillInTheBlankQuestion();
            //        q.LoadDataFromFile(i + ".txt");
            //        q.Display();
            //    }
            //    else
            //    {
            //        // One choice question
            //        q = new OneChoiceQuestion();
            //        q.LoadDataFromFile(i + ".txt");
            //        q.Display();
            //    }
            //}


            //q = new OneChoiceQuestion(); 
            //q = new FillInTheBlankQuestion();

            //var q2 = new FillInTheBlankQuestion();
            //q2.QuestionContent = "Thủ đô của Việt Nam là ________.";
            //q2.CorrectAnswer = "Hà Nội";
            //q2.SaveDataToFile("2.txt");

            //q2.LoadDataFromFile("2.txt");
            //q2.Display();

            //var q3 = new OneChoiceQuestion
            //{
            //    QuestionContent = "Môn học nào sau đây không phải là môn khoa học tự nhiên?",
            //    Option1 = "Vật lý",
            //    Option2 = "Hóa học",
            //    Option3 = "Sinh học",
            //    Option4 = "Lịch sử",
            //};

            //var gemini = new GeminiService();

            //var result = gemini.Grade("Văn học", "Tác phẩm Lão Hạc của nhà văn nào? A.Tố Hữu, B.Name Cao, C. Xuân Diệu. Và câu trả lời của học sinh là: C", "Giải thích vai trò từng tác giả");

            //Console.WriteLine(result);


            //var question = new OneChoiceQuestion();

            //question.LoadDataFromDatabase(new Guid("ec413690-d9d1-472e-90fa-2de153037456"));
            //question.Display();

            var exam = new Examination();

            exam.Start(new Guid("CA4FE52D-487C-4984-95E5-436E6837A227"));

        }
    }
}
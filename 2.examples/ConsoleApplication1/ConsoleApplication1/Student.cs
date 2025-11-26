using System;

namespace ConsoleApplication1
{
    internal class Student : Person
    {
        public static string SchoolName = "Softech Aptech";


        public Student()
        {

        }

        public Student(int score)
        {
            this.Score = score;
        }

        private int _score;

        /// <summary>
        /// Điểm số với giá trị từ 0 đến 10
        /// </summary>
        /// <example>
        /// s1.Score = 8;
        /// </example>
        /// <code>
        /// s1.Score = 11; // Throws ArgumentOutOfRangeException
        /// </code>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public int Score
        {
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Score must be between 0 and 10.");
                }
                this._score = value;
            }
            get { return this._score; }
        }



        public string GetGrade()
        {
            var grade = "";

            if (this._score >= 8)
            {
                grade = "A";
            }
            else if (this._score >= 6)
            {
                grade = "B";
            }
            else if (this._score >= 4)
            {
                grade = "C";
            }
            else
            {
                grade = "D";
            }

            return grade;
        }

        //public void SaveToTextFile()
        //{
        //    using (var writer = new System.IO.StreamWriter(this._id.ToString() + ".txt"))
        //    {
        //        writer.WriteLine(this._id);
        //        writer.WriteLine(this._name);
        //        writer.WriteLine(this._email);
        //        writer.WriteLine(this._address);
        //        writer.WriteLine(this._age);
        //        writer.WriteLine(this._score);
        //    }
        //}

        //public void LoadFromTextFile()
        //{
        //    using (var reader = new System.IO.StreamReader(this._id.ToString() + ".txt"))
        //    {
        //        this._id = int.Parse(reader.ReadLine());
        //        this._name = reader.ReadLine();
        //        this._email = reader.ReadLine();
        //        this._address = reader.ReadLine();
        //        this._age = int.Parse(reader.ReadLine());
        //        this._score = int.Parse(reader.ReadLine());
        //    }
        //}

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score: " + this._score);
        }


        private void SecrectMethod()
        {
            Console.WriteLine("This is a secret method.");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }


        public void Swap2Number(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public void Calculate(ref int a, ref int b)
        {
            a = 10;
            b = 20;
            Console.WriteLine("Inside Calculate method: a = " + a + ", b = " + b);
        }
    }
}
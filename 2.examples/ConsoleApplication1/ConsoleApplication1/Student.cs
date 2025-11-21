using System;

namespace ConsoleApplication1
{
    public class Student
    {
        private int _id;

        // Encapsulated property for Id
        public int Id
        {
            set { this._id = value; }
            get { return this._id; }
        }


        private string _name;

        public string Name
        {
            set { this._name = value; }
            get { return this._name; }
        }


        private string _email;
        public string Email
        {
            set
            {
                // Check email format (basic check)
                if (!value.Contains("@") || !value.Contains("."))
                {
                    throw new ArgumentException("Invalid email format.");
                }
                this._email = value;
            }
            get { return this._email; }
        }

        private string _address;
        public string Address
        {
            set { this._address = value; }
            get { return this._address; }
        }


        private int _age;

        // Encapsulated property for Age with validation
        public int Age
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative.");
                }
                if (value > 60)
                {
                    throw new ArgumentOutOfRangeException("Age seems invalid.");
                }
                this._age = value;
            }
            get { return this._age; }
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

        public void Display()
        {
            Console.WriteLine("Id: " + this._id);
            Console.WriteLine("Name: " + this._name);
            Console.WriteLine("Email: " + this._email);
            Console.WriteLine("Address: " + this._address);
            Console.WriteLine("Age: " + this._age);

        }

        public void SaveToTextFile()
        {
            using (var writer = new System.IO.StreamWriter(this._id.ToString() + ".txt"))
            {
                writer.WriteLine(this._id);
                writer.WriteLine(this._name);
                writer.WriteLine(this._email);
                writer.WriteLine(this._address);
                writer.WriteLine(this._age);
                writer.WriteLine(this._score);
            }
        }

        public void LoadFromTextFile()
        {
            using (var reader = new System.IO.StreamReader(this._id.ToString() + ".txt"))
            {
                this._id = int.Parse(reader.ReadLine());
                this._name = reader.ReadLine();
                this._email = reader.ReadLine();
                this._address = reader.ReadLine();
                this._age = int.Parse(reader.ReadLine());
                this._score = int.Parse(reader.ReadLine());
            }
        }
    }
}
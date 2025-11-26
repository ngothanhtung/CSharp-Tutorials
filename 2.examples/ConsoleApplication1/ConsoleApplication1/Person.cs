using System;

namespace ConsoleApplication1
{
    internal class Person
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


        public Person()
        {

        }

        public Person(int id)
        {
            this.Id = id;
        }

        public Person(string name)
        {
            this.Name = name;
        }

        protected void Display()
        {
            Console.WriteLine("Id: " + this._id);
            Console.WriteLine("Name: " + this._name);
            Console.WriteLine("Email: " + this._email);
            Console.WriteLine("Address: " + this._address);
            Console.WriteLine("Age: " + this._age);

        }
    }
}

using System;

namespace ConsoleApplication1
{
    internal class Teacher : Person
    {
        public Teacher()
        {

        }

        public Teacher(string name)
        {
            base.Name = name;
        }


        public string Skill { get; set; }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Skill: " + this.Skill);
        }
    }
}

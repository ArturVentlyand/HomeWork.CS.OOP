using System;
using System.Globalization;

namespace HomeWork4
{
    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name
        {
            get { return name; }
        }
        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {

        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age(DateTime BirthYear)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthYear.Year;
            return age;
        }

        public void Input()
        {
            Console.WriteLine("Enter name: ");
            this.name = Console.ReadLine();;
            this.birthYear = inputBirthYear();
        }

        DateTime inputBirthYear()
        {
            DateTime bY; 
            string inputPerson;

            do
            {
                Console.WriteLine("Enter the date of birth dd.mm.yyyy (day.month.year):");
                inputPerson = Console.ReadLine();
            }
            while (!DateTime.TryParseExact(inputPerson, "dd.MM.yyyy", null, DateTimeStyles.None, out bY));

            return bY;
        }

        public string ChangeName(string changedName)
        {
            name = changedName;
            return name;
        }

        public override string ToString()
        {
            return String.Format($"Name: {name}, Age: {Age(BirthYear)}");
        }

        public void Output()
        {
            //string info = this.ToString();
            Console.WriteLine(this.ToString());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            Person person4 = new Person();
            Person person5 = new Person();
            Person person6 = new Person();

            person1.Input();
            person2.Input();
            person3.Input();
            person4.Input();
            person5.Input();
            person6.Input();

            int ageP1 = person1.Age(person1.BirthYear);
            if (16 > ageP1)
                person1.ChangeName("Very Young");

            int ageP2 = person2.Age(person2.BirthYear);
            if (16 > ageP2)
                person2.ChangeName("Very Young");

            int ageP3 = person3.Age(person3.BirthYear);
            if (16 > ageP3)
                person1.ChangeName("Very Young");

            int ageP4 = person4.Age(person4.BirthYear);
            if (16 > ageP4)
                person1.ChangeName("Very Young");

            int ageP5 = person5.Age(person5.BirthYear);
            if (16 > ageP5)
                person1.ChangeName("Very Young");

            int ageP6 = person6.Age(person6.BirthYear);
            if (16 > ageP6)
                person1.ChangeName("Very Young");

            person1.Output();
            person2.Output();
            person3.Output();
            person4.Output();
            person5.Output();
            person6.Output();
        }
    }
}
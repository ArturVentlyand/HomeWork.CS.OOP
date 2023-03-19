using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonName personName = new PersonName();
            PhoneNumber phoneNumber = new PhoneNumber();
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();

            string readPathMainFile = @"C:\Users\ventl\OneDrive\Рабочий стол\Projects\Study.CS.OOP\HomeWork7\HomeWork7\phones.txt";
            string writePathFirstFile = @"C:\Users\ventl\OneDrive\Рабочий стол\Projects\Study.CS.OOP\HomeWork7\HomeWork7\PhonesOnlyNumber.txt";
            string writePathSecondFile = @"C:\Users\ventl\OneDrive\Рабочий стол\Projects\Study.CS.OOP\HomeWork7\HomeWork7\New.txt";

            string inputUser;
            using (StreamReader sr = new StreamReader(readPathMainFile, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] keyvalue = line.Split(" - ");
                    if (keyvalue.Length == 2)
                    {
                        personName.Name = keyvalue[0];
                        phoneNumber.Number = keyvalue[1];

                        PhoneBook.Add(personName.Name, phoneNumber.Number);
                    }
                }

                Console.WriteLine("Phone Book:");
                foreach (var item in PhoneBook.Keys)
                {
                    Console.WriteLine(item);
                }
            }

            using (StreamWriter sw = new StreamWriter(writePathFirstFile, true, System.Text.Encoding.Default))
            {
                foreach (var item in PhoneBook.Values)
                {
                    sw.WriteLine(item);
                }
            }

            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    Console.Write("Enter a name person for gived number: ");
                    inputUser = Console.ReadLine();
                    Console.WriteLine(PhoneBook[inputUser]);

                    tryAgain = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("You entered the name person wrong!");
                    Console.WriteLine("Please try again.");
                    continue;
                }
            }

            using (StreamWriter sw = new StreamWriter(writePathSecondFile, true, System.Text.Encoding.Default))
            {
                foreach (var item in PhoneBook.Values)
                {
                    sw.WriteLine(phoneNumber.ChangeFormatNumber(item));
                }
            }
        }
    }

    internal class PersonName
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
    }

    internal class PhoneNumber
    {
        private string number;
        public string Number { get { return number; } set { number = value; } }

        public string ChangeFormatNumber(string phoneNumber)
        {
            string newFormatNumber = "+38";
            if (number.StartsWith("0"))
            {
                return phoneNumber.Insert(0, newFormatNumber);
            }
            else
                return phoneNumber;
        }
    }
}
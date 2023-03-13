using System;
using System.Collections;
using static System.Formats.Asn1.AsnWriter;

namespace Homework5
{
    interface IDeveloper
    {
        void Create();
        void Destroy();
        void Output();
        string Tool { get; }
        int Xpr { get; set; }
    }


    class Programmer : IDeveloper, IComparable<IDeveloper>
    {
        private string language;
        public int Xpr { get; set; }
        public string Tool 
        {
            get
            {
                return this.language;
            }
        }

        public int CompareTo(IDeveloper other)
        {
            return this.Xpr.CompareTo(other.Xpr);
        }


        public void Create()
        {
            Console.Write("Enter experience: ");
            this.Xpr = int.Parse(Console.ReadLine());
        }

        public void Destroy()
        {
            Console.WriteLine("This Programmer die!");
        }

        public override string ToString()
        {
            return string.Format($"Experience: {this.Xpr}");
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Builder : IDeveloper, IComparable<IDeveloper>
    {
        private string tool;
        public int Xpr { get; set; }
        public string Tool 
        {
            get 
            {
                return this.tool;
            }
        }

        public int CompareTo(IDeveloper other)
        {
            return this.Xpr.CompareTo(other.Xpr);
        }

        public void Create()
        {
            Console.Write("Enter experience: ");
            this.Xpr = int.Parse(Console.ReadLine());
        }

        public void Destroy()
        {
            Console.WriteLine("This Biulder die!");           
        }

        public override string ToString()
        {
            return string.Format($"Experience: {Xpr}");
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> bestDev = new List<IDeveloper>();

            bestDev.Add(new Builder());
            bestDev.Add(new Builder());
            bestDev.Add(new Builder());
            bestDev.Add(new Programmer());
            bestDev.Add(new Programmer());
            bestDev.Add(new Programmer());

            foreach (IDeveloper dev in bestDev)
            {
                dev.Create();
            }

            bestDev.Sort();

            foreach (IDeveloper dev in bestDev)
            {
                dev.Output();
            }

        }
    }
}
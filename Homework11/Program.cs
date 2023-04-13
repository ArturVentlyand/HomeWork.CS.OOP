using Homework11;
using System;

namespace HomeWork11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> marks = new List<int>();

            Student studentHeroAcademy = new Student("Decku", marks);
            Parent mom = new Parent();
            Accountancy accountant = new Accountancy();

            studentHeroAcademy.MarkChange += new MyDel(mom.OnMarkChange);
            studentHeroAcademy.MarkChange += new MyDel(accountant.PayingFellowship);

            studentHeroAcademy.AddMark(2);
            studentHeroAcademy.AddMark(4);
            studentHeroAcademy.AddMark(5);
        }
    }
}
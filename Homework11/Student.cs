using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public delegate void MyDel(int m);
    internal class Student
    {
        public string Name { get; set; }
        public List<int> Marks { get; set; }
        public event MyDel MarkChange;

        public Student(string name, List<int> marks)
        {
            this.Name = name;
            this.Marks = marks;
        }
        public void AddMark(int mark)
        {
            this.Marks.Add(mark);
            if (MarkChange != null)
                MarkChange(mark);
        }

    }
}

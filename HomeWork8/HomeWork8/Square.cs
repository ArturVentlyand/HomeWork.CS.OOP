using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public class Square : Shape, IComparable<Shape>
    {
        private double side;
        public double Side { get => side; set => side = value; }
        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public override double Area()
        {
            return Side * Side;
        }
        public override double Perimeter()
        {
            return Side * 4;
        }

        public override void Display()
        {
            Console.WriteLine($"Name - {Name} \n" +
                              $"Area = {Area()} \n" +
                              $"Perimeter = {Perimeter()}");
        }
        public override void DisplayArea()
        {
            Console.WriteLine($"Area = {Area()}");
        }

        public override int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;
        public double area;
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }

        public virtual double Area(double area)
        {
            return area;
        }

        public virtual double Perimeter(double perimeter)
        {
            return perimeter;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name - {this.Name} \n" +
                              $"Area = {this.area} \n" +
                              $"Perimeter = {this.Perimeter}");
        }
        public virtual void DisplayArea()
        {
            Console.WriteLine($"Area = {this.area}");
        }

        public virtual int CompareTo(Shape other)
        {
            return area.CompareTo(other.area);
        }
    }

    public class Circle : Shape, IComparable<Shape>
    {
        private double radius;
        public double area;
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Area(double radius)
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter(double radius)
        {
            return Math.PI * 2 * radius;
        }

        public override void Display()
        {
            Console.WriteLine($"Name - {this.Name} \n" +
                              $"Area = {this.Area(Radius)} \n" +
                              $"Perimeter = {this.Perimeter(Radius)}");
        }
        public override void DisplayArea()
        {
            Console.WriteLine($"Area = {this.Area(Radius)}");
        }

        public override int CompareTo(Shape other)
        {
            this.area = Area(Radius);
            return this.area.CompareTo(other.area);
        }
    }

    public class Square : Shape, IComparable<Shape>
    {
        private double side;
        public double area;
        public double Side { get; set; }
        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public override double Area(double side)
        {
            return side * side;
        }
        public override double Perimeter(double side)
        {
            return side * 4;
        }

        public override void Display()
        {
            Console.WriteLine($"Name - {this.Name} \n" +
                              $"Area = {this.Area(Side)} \n" +
                              $"Perimeter = {this.Perimeter(Side)}");
        }
        public override void DisplayArea()
        {
            Console.WriteLine($"Area = {this.Area(Side)}");
        }

        public override int CompareTo(Shape other)
        {
            this.area = Area(Side);
            return this.area.CompareTo(other.area);
        }
    }
}

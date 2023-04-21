using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork12
{
    [Serializable]
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Square))]
    public abstract class Shape : IComparable<Shape>
    {
        [XmlElement]
        private string name;
        public string Name { get => name; set => name = value; }

        public Shape() {}
        public Shape(string name)
        {
            Name = name;
        }

        public abstract double Area();

        public abstract double Perimeter();

        public virtual void Display()
        {
            Console.WriteLine($"Name - {Name} \n" +
                              $"Area = {Area()} \n" +
                              $"Perimeter = {Perimeter()}");
        }
        public virtual void DisplayArea()
        {
            Console.WriteLine($"Area = {Area()}");
        }

        public virtual int CompareTo(Shape other)
        {
            return Area().CompareTo(other.Area());
        }

        public void Serialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, this);
            }
        }

        public static Shape Deserialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                return (Shape)formatter.Deserialize(stream);
            }

        }
    }
}

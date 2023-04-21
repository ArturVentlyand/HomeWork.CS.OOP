using System;
using System.Reflection.Metadata;
using System.Xml.Serialization;

namespace HomeWork12 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle("C00", 2));
            shapes.Add(new Circle("C01", 2.5));
            shapes.Add(new Square("S00", 2));
            shapes.Add(new Square("S01", 2.5));

            Circle circle = new Circle("C02", 3);
            circle.Serialize("C:\\Users\\ventl\\OneDrive\\Рабочий стол\\Projects\\Study.CS.OOP\\HomeWork12\\Test.bin");
            Shape.Deserialize("C:\\Users\\ventl\\OneDrive\\Рабочий стол\\Projects\\Study.CS.OOP\\HomeWork12\\Test.bin");
            

            var serializer = new XmlSerializer(typeof(List<Shape>));

            using (var stream = new FileStream("C:\\Users\\ventl\\OneDrive\\Рабочий стол\\Projects\\Study.CS.OOP\\HomeWork12\\XMLFile1.xml", FileMode.Create))
            {
                serializer.Serialize(stream, shapes);
            }
        }
    }
}
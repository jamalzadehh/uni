using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adiniz:");
            string color = Console.ReadLine();
            Console.WriteLine("Yashiniz:");
            int area = byte.Parse(Console.ReadLine());

            Shape shape = new Shape(color, area);


        }

    }
    public class Shape
    {
        string _color;
       
        protected int _area;
        public string Color { get { return _color; } set { _color = value; } }
        public int Area { get { return _area; } set { _area = value; } }

        public Shape(string color)
        {

            _color = color;
           




        }
        public void Printarea()
        {


            Console.WriteLine($"Sahe:{_area} ");
        }
        public void PrintColor()
        {
            Console.WriteLine($"Reng:{_color}");
        }
        public void PrintInfo()
        {
            Console.WriteLine();
        }




    }
    public class Circle:Shape

    {
        public Circle(string color):base(color)
        {

        }
        
        int _radius;
       
        public int radius { get { return _radius; } set { _radius = value; } }

        public void CalculateArea( int Radius)
        {
            _area = _radius * _radius * 3;
            Console.WriteLine($"Area of Circle:{_area}");
        }
    }
    public class Rectangle
    {
        public void Length()
        {

        }
        public void Width()
        {

        }
        public void CalculateArea()
        {

        }
    }
}

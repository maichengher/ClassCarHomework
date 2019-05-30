using System;

namespace ClassCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            car Car1 = new car("Toyota", "Corolla", 2003, "silver");
            Car1.CarName("Gorge");
        }
    }

    public class car 
    {
        public static string _Make { set; get; }
        public static string _Model { set; get; }
        public static int _Year { set; get; }
        public static string _Color { set; get; }

        public car(string make, string model, int year, string color)
        {

            _Make = make;
            _Model = model;
            _Year = year;
            _Color = color;


            Console.WriteLine("Car is created");
            Console.WriteLine("You have a {0}, {1}", make, model);
            Console.WriteLine("The year is {0}", year);
            Console.WriteLine("The color is {0}", color);
        }

        public void CarName(string cName)
        {
            Console.WriteLine("You have been given a name for you car.");
            Console.WriteLine("The name is {0}", cName);

        }

      
    }
}

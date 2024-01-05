using System;

namespace Drive_and_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello driver");
            Car car = new Car();
            car.Refuel(0);
            car.Drive();
        }
    }
}

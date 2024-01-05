using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive_and_car
{
    class Car : IVehiculo
    {
        bool hasGasoline;
        public void Drive()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Since the amount of gasoline is enough, you can drive the car");
        }
        public bool Refuel(int gasolineToRefuel)
        {
            
            if (gasolineToRefuel > 0)
            {
                hasGasoline = true;
                return hasGasoline;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                hasGasoline = false;
                Console.WriteLine("Because you don't have gas, fill it with gas");
                return Refuel(Convert.ToInt32(Console.ReadLine()));
            }            
        }
    }
}

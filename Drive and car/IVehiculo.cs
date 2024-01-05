using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive_and_car
{
    interface IVehiculo
    {
        void Drive();
        bool Refuel(int gasolineTorefuel);
    }
}

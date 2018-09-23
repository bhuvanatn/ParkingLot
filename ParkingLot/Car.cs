using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Car : Vechicle
    {
        public Car()
        {
            spotsNeeded = 1;
            size = VehicleSize.Compact;
        }

        /* Checks if the spot is a Compact or a Large. */
        public override bool canFitinSpot(ParkingSpot spot)
        {
               return true;
        }

    }
}

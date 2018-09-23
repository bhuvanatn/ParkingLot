using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Motorcycle : Vechicle
    {
        public Motorcycle()
        {
            spotsNeeded = 1;
            size = VehicleSize.Motorcycle;
        }
        public override bool canFitinSpot(ParkingSpot spot)
        {
            return true;
        }

    }
}

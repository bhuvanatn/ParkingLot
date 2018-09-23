using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Bus : Vechicle
    {
        public Bus()
        {
            spotsNeeded = 5;
            size = VehicleSize.Large;
        }

        /* Checks if the spot is a Large. Doesn't check
        num of spots */
        public override bool canFitinSpot(ParkingSpot spot)
        {
            return true;
        }

    }
}

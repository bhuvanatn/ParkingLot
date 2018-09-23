using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Car C1 = new Car();
            ParkingSpot PSC1 = new ParkingSpot(Level.Lel2, 3, 25, VehicleSize.Compact);
            PSC1.park(C1);

           /* Bus B1 = new Bus();
            ParkingSpot PSB1 = new ParkingSpot(Level.Lev1, 1, 12, VehicleSize.Large);
            PSB1.park(B1);

            Motorcycle M1 = new Motorcycle();
            ParkingSpot PSM1 = new ParkingSpot(Level.Lev3, 5, 30, VehicleSize.Motorcycle);
            PSM1.park(M1);*/
        }
    }
}

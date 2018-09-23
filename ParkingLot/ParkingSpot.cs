using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public enum Level { Lev1, Lel2, Lev3 }
    public class ParkingSpot 
        {
            private Vechicle vehicle;
            private VehicleSize spotSize;
            private int row;
            private int spotNumber;
            private Level level;

            public ParkingSpot(Level lvl, int r, int n, VehicleSize s)
            {
            level = lvl;
            row = r;
            spotNumber = n;
            spotSize = s;
             }

            public bool isAvailable()
            {
                return vehicle == null;
            }


        /* Park vehicle in this spot. */
        public bool park(Vechicle v) {

        }

            public int getRow()
            {
                return row;
            }
            public int getSpotNumber()
            {
                return spotNumber;
            }

            /* Remove vehicle from spot, and notify
            level that a new spot is available */
            public void removeVehicle() {  }
        }


    
}

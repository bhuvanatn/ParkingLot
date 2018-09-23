using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    // Vehicle and its inherited classes.
    public enum VehicleSize { Motorcycle, Compact, Large }

    public abstract class Vechicle 
    {
      
        protected List<ParkingSpot> parkingSpots =
                       new List<ParkingSpot>();
        protected String licensePlate;
        protected int spotsNeeded;
        protected VehicleSize size;

        public int getSpotsNeeded()
        {
            return spotsNeeded;
        }
        public VehicleSize getSize()
        {
            return size;
        }

        /* Park vehicle in this spot (among others,
            potentially) */
        public void parkinSpot(ParkingSpot s)
        {
            parkingSpots.Add(s);
        }


        /* Remove vehicle from spot, and notify spot
            that it's gone */
        public void clearSpots() { }

        /* Checks if the spot is big enough for the
            vehicle */

        public abstract bool canFitinSpot(ParkingSpot spot);

    }
}

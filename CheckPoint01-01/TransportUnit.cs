﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint01
{
    
    
    public abstract class TransportUnit : ITransportUnit
    {
        public enum KindOfUnit { Baggage, Passenger, Driver, Car, Train, Aircraft };    

        public KindOfUnit kindofunit;
        public int ID { get; set; }
        public string Name { get; set; }

        public TransportUnit()
        {
            if (this is AircraftUnit)
                kindofunit = KindOfUnit.Aircraft;
            else if (this is DriverUnit)
                kindofunit = KindOfUnit.Driver;
            else if (this is CarUnit)
            {
                (this as CarUnit).CarDriver = null;
                kindofunit = KindOfUnit.Car;
            }
            else if (this is TrainUnit)
                kindofunit = KindOfUnit.Train;
            else if (this is PassengerUnit)
                kindofunit = KindOfUnit.Passenger;
            else if (this is BaggageUnit)
                kindofunit = KindOfUnit.Baggage;            
        }
    }
}

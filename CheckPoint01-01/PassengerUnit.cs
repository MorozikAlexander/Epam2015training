﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint01
{
    public class PassengerUnit : ManUnit , IhasBaggage
    {
        

        public double WeightCapacity { get; set; }
        public double VolumeCapacity { get; set; }
        public List<BaggageUnit> Baggage = new List<BaggageUnit>();

        public PassengerUnit()
        {
            Baggage = null;
            WeightCapacity = 50;
            VolumeCapacity = .2;
        }

        /*public bool Load(BaggageUnit item)
        {

        }*/


        public double CurrentWeightValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double CurrentVolumeValue
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool LoadBaggage(BaggageUnit item)
        {
            throw new NotImplementedException();
        }
    }
}
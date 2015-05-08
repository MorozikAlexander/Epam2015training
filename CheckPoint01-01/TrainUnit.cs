﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint01_01
{
    public class TrainUnit : LocomotiveUnit
    {
        public List<LocomotiveUnit> locomotives = new List<LocomotiveUnit>();
        public List<PassengerWagonUnit> passwagons = new List<PassengerWagonUnit>();
        public List<BaggageWagonUnit> baggwagons = new List<BaggageWagonUnit>();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceE.Models
{
    public class FuelWeight
    {
        public int Weight { get; set; }
        public int Distance { get; set; }
        public string LocationName { get; set; }
        public int Fuel { get; set; }

        public FuelWeight(int weight, int distance, string location)
        {
            Weight = weight;
            Distance = distance;
            LocationName = location;
        }


        public void CalcWeight()
        {
            double power = Distance / 3000D;
            double total = Math.Round(Weight * Math.Pow(2.718, power)) - Weight;
            Fuel = (int)total;
        }

    }
}

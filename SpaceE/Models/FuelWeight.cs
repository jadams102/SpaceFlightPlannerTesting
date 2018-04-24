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

        public FuelWeight(int weight, int distance)
        {
            Weight = weight;
            Distance = distance;
        }


        public int CalcWeight()
        {
            double power = Distance / 3000D;
            double total = Math.Round(Weight * Math.Pow(2.718, power)) - Weight;
            int intTotal = (int)total;
            return intTotal;
        }

    }
}

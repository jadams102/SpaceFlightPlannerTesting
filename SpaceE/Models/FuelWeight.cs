using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceE.Models
{
    public class FuelWeight
    {
        public int CalcWeight(int weight, int distance)
        {
            double power = distance / 3000D;
            double total = Math.Round(weight * Math.Pow(2.718, power)) - weight;
            int intTotal = (int)total;
            return intTotal;
        }

    }
}

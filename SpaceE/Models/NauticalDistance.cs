using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceE.Models
{
    public class NauticalDistance
    {
        double latDeg;
        double latMin;
        string latDir;
        double lonDeg;
        double lonMin;
        string lonDir;

        double FindDist()
        {
            double difLatMin;
            double difLonMin;

            if (latDir == "N")
            {
                difLatMin = (Math.Abs(latDeg - 28) * 60 + Math.Abs(latMin - 32));
            }

            else
            {
                difLatMin = (Math.Abs(latDeg + 28) * 60 + Math.Abs(latMin + 32));
            }

            if(lonDir == "W")
            {
                difLonMin = (Math.Abs(lonDeg - 80) * 60 + Math.Abs(lonMin - 34));
            }

            else
            {
                difLonMin = (Math.Abs(lonDeg + 80) * 60 + Math.Abs(lonMin + 34));
            }

            var pythag = (difLatMin * difLatMin) + (difLonMin * difLonMin);
            return Math.Round(Math.Sqrt(pythag));
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceE.Models
{
    public class Planner
    {
        public decimal Hours;
        public decimal Tasks;
        public decimal AstroNumber()
        {
            var workTime = Math.Ceiling(this.Tasks / 4);
            decimal adjHours;

            if (this.Hours > 24)
            {
                adjHours = Math.Ceiling((this.Hours / 24) * 16);
            }
            else if (this.Hours > 16 && this.Hours <= 24)
            {
                adjHours = 16;
            }
            else
            {
                adjHours = this.Hours;
            }
            return Math.Ceiling(workTime / adjHours);
        }
    }
}

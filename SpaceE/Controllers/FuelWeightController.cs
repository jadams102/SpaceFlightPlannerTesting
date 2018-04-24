using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaceE.Models;
using System.Diagnostics;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaceE.Controllers
{
    public class FuelWeightController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<FuelWeight> model = new List<FuelWeight> { };
            return View(model);
        }
    
        [HttpPost]
        public IActionResult Results()
        {
            int rocketWeight = Int32.Parse(Request.Form["Weight"]);
            FuelWeight LA = new FuelWeight(rocketWeight, 1400, "Los Angeles");
            LA.CalcWeight();
            FuelWeight station = new FuelWeight(rocketWeight, 9400, "International Space Station");
            station.CalcWeight();
            FuelWeight moon = new FuelWeight(rocketWeight, 17500, "The Moon");
            moon.CalcWeight();
            FuelWeight mars = new FuelWeight(rocketWeight, 21100, "Mars");
            mars.CalcWeight();



            List<FuelWeight> model = new List<FuelWeight> { LA, station, moon, mars };
            
            return View("Index", model);
        }
       
    }
}

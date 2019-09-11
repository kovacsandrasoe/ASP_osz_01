using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Szamolo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Szamolo(int min, int step, int max)
        {
            List<int> numbers = new List<int>();
            for (int i = min; i <= max; i+= step)
            {

                numbers.Add(i);
            }
            return View("Result", numbers);
        }

        public IActionResult Items()
        {
            return View();
        }

        public IActionResult Greetings()
        {
            return View();
        }

        public IActionResult Sorsolas()
        {
            string tanar = Models.Sorsolo.Sorsol();
            //melyik view-nak és mit?
            //return View("Sorsolas", tanar);
            return View(nameof(Sorsolas), tanar);
        }
    }
}

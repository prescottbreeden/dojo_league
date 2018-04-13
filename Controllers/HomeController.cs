using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojo_league.Models;
using dojo_league.Factories;
using lost_in_the_woods;

namespace dojo_league.Controllers
{
    public class HomeController : Controller
    {
        private readonly DojoFactory dojoFactory;
        private readonly NinjaFactory ninjaFactory;
        public HomeController(DbConnector connect)
        {
            dojoFactory = new DojoFactory();
            ninjaFactory = new NinjaFactory();
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        
    }
}

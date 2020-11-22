using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {

            // create a new Movie object with instance name jungleBook
            //var jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "person");
            //var forrestgump = new Movie("Forrest Gump", 314.23m, "forrest-gump.jpg", "person2");
            //var gladiator = new Movie("Gladiator", 421.23m, "gladiator.jpg", "person3");

            // assign a ViewBag property to the new Movie object
            //ViewBag.JungleBook = jungleBook;
            //ViewBag.Forrestgump = forrestgump;
            //ViewBag.Gladiator = gladiator;
            // return the default view
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //Private variable to pass in data from the form
        private MovieApplicationContext _movieContext { get; set; }

        //Constructor

        public HomeController(ILogger<HomeController> logger, MovieApplicationContext movieUpdate)
        {
            _logger = logger;
            _movieContext = movieUpdate;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Podcasts Page Controller
        public IActionResult MyPodcasts()
        {
            return View();
        }

        //Movie Form Controller
        [HttpGet]
        public IActionResult MovieApplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieApplication(ApplicationResponse ar)
        {
            // Using an if else statement to validate form submission before adding data to SQLite Database
            if (ModelState.IsValid)
            {
                // Make an entry in the database
                _movieContext.Add(ar);
                _movieContext.SaveChanges();
                //Return Page with a confirmation Message
                ViewBag.success = "Record Inserted Successfully!";
                return View();
            }
            
            else
                ViewBag.fail = "There was an error with your form submission. Please Try Again.";
                return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

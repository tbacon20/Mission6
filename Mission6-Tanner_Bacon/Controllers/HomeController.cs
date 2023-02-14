using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_Tanner_Bacon.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_Tanner_Bacon.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Connect db context object
        // This is to get the info from the context file into our controller
        private MovieCollectionContext _movieContext { get; set; }
        
        // MovieCollectionContext added only if the db context object is created above (logger is the only default parameter)
        public HomeController(ILogger<HomeController> logger, MovieCollectionContext movieContext)
        {
            _logger = logger;
            // Set the context by passing it as a parameter
            _movieContext = movieContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(ApplicationResponse res)
        {
            // Now that _movieContext is set, we can add to the db
            _movieContext.Add(res);
            // and save to the db
            _movieContext.SaveChanges();


            // This remains unchanged by the addition of db, allows us to pass the object to the next view
            return View("Submitted", res);
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

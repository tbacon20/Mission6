using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        // Connect db context object
        // This is to get the info from the context file into our controller
        private MovieCollectionContext _movieContext { get; set; }
        
        public HomeController(MovieCollectionContext movieContext)
        {
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
            // This can be used in different views (from the viewbag)
            ViewBag.Categories = _movieContext.Categories.ToList();
            return View(new ApplicationResponse());
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

        [HttpGet]
        public IActionResult MovieList()
        {
            var allMovies = _movieContext.Responses
                .Include(x => x.Category)
                .Where(x => x.Rating != "R")
                .OrderBy(x => x.Category.CategoryName)
                .ToList();

            return View(allMovies);
        }


        // Edit action (U)
        [HttpGet] // For getting a specific record
        public IActionResult Edit (int id)
        {
            ViewBag.Categories = _movieContext.Categories.ToList();

            var movie = _movieContext.Responses.Single(x => x.ApplicationId == id);
            return View("Movies", movie);
        }

        [HttpPost] // For changing the selected and updated specific record
        public IActionResult Edit(ApplicationResponse res)
        {
            // Make sure the model is valid before updating it
            if (ModelState.IsValid)
            { 
                // Update the response
                _movieContext.Update(res);
                // Make the changes permanant
                _movieContext.SaveChanges();

                return RedirectToAction("MovieList");
            }
            else
            {
                ViewBag.Categories = _movieContext.Categories.ToList();
                return View(res);
            }
        }

        // Delete action (D)
        [HttpGet]
        public IActionResult Delete (int id)
        {

            var movie = _movieContext.Responses.Single(x => x.ApplicationId == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse res)
        {
            _movieContext.Responses.Remove(res);
            _movieContext.SaveChanges();
            return RedirectToAction("MovieList");
        }
    }
}

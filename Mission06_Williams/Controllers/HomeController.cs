using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Williams.Models;
using SQLitePCL;
using System.Diagnostics;

namespace Mission06_Williams.Controllers
{
    public class HomeController : Controller
    {   
        //allows access to the database across routes
        private MovieSubmissionContext _context;
        public HomeController(MovieSubmissionContext temp) //constructor
        {
         _context = temp;
        }

        //Home Route
        public IActionResult Index()
        {
            return View();
        }
        //Get to Know Joel Route Page
        public IActionResult GetToKnow()
        {
            return View();
        }
        //Enter a Move Get request for the Route
        [HttpGet]
        public IActionResult EnterMovie()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View("EnterMovie");
        }

        //Enter a Move Get Post for when a form is submitted
        [HttpPost]
        public IActionResult EnterMovie(Movies response)
        {
            _context.Movies.Add(response); //add record to the database
            _context.SaveChanges();
            return View("Confirmation", response);
        }

        public IActionResult MoviesTable()
        {
            var movies = _context.Movies
                .Include(x => x.Category)
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();
            return View("EnterMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movies updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("MoviesTable");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Movies deletingInfo)
        {
            _context.Movies.Remove(deletingInfo);
            _context.SaveChanges();

            return RedirectToAction("MoviesTable");
        }
    }
}

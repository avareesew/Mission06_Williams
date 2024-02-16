using Microsoft.AspNetCore.Mvc;
using Mission06_Williams.Models;
using SQLitePCL;
using System.Diagnostics;

namespace Mission06_Williams.Controllers
{
    public class HomeController : Controller
    {
        private MovieSubmissionContext _context;
        
        public HomeController(MovieSubmissionContext temp) //constructor
        {
         _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EnterMovie()
        {
            return View("EnterMovie");
        }

        [HttpPost]
        public IActionResult EnterMovie(MovieSubmission response)
        {
            _context.MovieSubmissions.Add(response); //add record to the database
            _context.SaveChanges();
            return View("Confirmation", response);
        }

     
    }
}

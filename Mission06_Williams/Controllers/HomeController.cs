using Microsoft.AspNetCore.Mvc;
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
            return View("EnterMovie");
        }

        //Enter a Move Get Post for when a form is submitted
        [HttpPost]
        public IActionResult EnterMovie(MovieSubmission response)
        {
            _context.MovieSubmissions.Add(response); //add record to the database
            _context.SaveChanges();
            return View("Confirmation", response);
        }

     
    }
}

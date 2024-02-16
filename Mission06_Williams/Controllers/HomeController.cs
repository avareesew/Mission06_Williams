using Microsoft.AspNetCore.Mvc;
using Mission06_Williams.Models;
using System.Diagnostics;

namespace Mission06_Williams.Controllers
{
    public class HomeController : Controller
    {
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
        public IActionResult EnterMovie(ApplicationBuilder response)
        {
            return View("Confirmation");
        }

     
    }
}

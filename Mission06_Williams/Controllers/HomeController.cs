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
        public IActionResult EnterMovie()
        {
            return View();
        }

     
    }
}

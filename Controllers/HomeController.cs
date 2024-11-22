using Part3Claims.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Part3Claims.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

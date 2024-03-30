using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Models;
using System.Diagnostics;

namespace OnlineBookstore.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }

        
}

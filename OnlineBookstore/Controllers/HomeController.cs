using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Models;
using System.Diagnostics;

namespace OnlineBookstore.Controllers
{
    public class HomeController : Controller
    {
        private IWaterRepository _repo;

        public HomeController(IWaterRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var projectData = _repo.Projects;

            return View(projectData);
        }


    }
}

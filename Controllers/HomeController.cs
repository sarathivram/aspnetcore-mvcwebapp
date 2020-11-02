using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YOYOTest.Models;
using YOYOTest.Business.Interface;
using Microsoft.AspNetCore.Hosting;

namespace YOYOTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeService _homeService;             
        private readonly IWebHostEnvironment _env;
        public HomeController(ILogger<HomeController> logger, IHomeService homeService, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _homeService = homeService;
            _env = webHostEnvironment;
        }

        public IActionResult Index()
        {
            string path = _env.ContentRootPath;
            var YOYOTestTrack = _homeService.AssignData(path);            
            return PartialView("Index", YOYOTestTrack);
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

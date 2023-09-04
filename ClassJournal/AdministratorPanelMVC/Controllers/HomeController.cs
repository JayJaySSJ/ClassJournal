using AdministratorPanelMVC.Models;
using ClassJournal.AppCore.Interfaces;
using ClassJournal.AppCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdministratorPanelMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserHandler _userHandler;

        public HomeController(ILogger<HomeController> logger, IUserHandler userHandler)
        {
            _logger = logger;
            _userHandler = userHandler;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostLogin([FromBody] LoginCredentials credentials)
        {
            var result = _userHandler.Login(credentials);

            return result.IsSuccess
                ? Json(new { redirectToUrl = Url.Action("MainPage") })
                : Json(new { redirectToUrl = Url.Action("Index") });
        }

        [HttpGet]
        public IActionResult MainPage(/*[FromBody] LoginResult loginResult*/)
        {
            return View(/*loginResult*/);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
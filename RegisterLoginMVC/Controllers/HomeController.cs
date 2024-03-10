using Microsoft.AspNetCore.Mvc;
using RegisterLoginMVC.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace RegisterLoginMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHttpContextAccessor contextAccessor;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Users users)
        {
            HttpContext.Session.SetString("email",users.Email);
            HttpContext.Session.SetString("password", users.Password);
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Users users)
        {
            string email = HttpContext.Session.GetString("email");
            string password = HttpContext.Session.GetString("password");
            if(email==users.Email && password == users.Password)
            {
                ViewBag.Message = "Sucess";
            }
            else
            {
                ViewBag.Message = "Invalid Email or Password";
            }

            return View();
        }
    }
}

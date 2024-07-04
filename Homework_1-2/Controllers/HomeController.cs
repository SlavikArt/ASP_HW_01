using Homework_1_2.Models;
using Homework_1_2.Services.Hash;
using Homework_1_2.Services.OTP;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework_1_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IHashService _hashService;

        private readonly IOtpService _otpService;

        public HomeController(ILogger<HomeController> logger, IHashService hashService, IOtpService otpService)
        {
            _logger = logger;
            _hashService = hashService;
            _otpService = otpService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Intro()
        {
            return View();
        }

        public IActionResult UrlStructure()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Ioc()
        {
            ViewData["hash"] = _hashService.Digest("123");
            ViewData["hashCode"] = _hashService.GetHashCode();
            ViewData["password"] = _otpService.GeneratePassword();
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

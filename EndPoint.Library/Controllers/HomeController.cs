using EndPoint.Library.Models;
using Library.Application.Interfaces.FacadPaterns.HomeFacadPatern;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeFacadPatern _homeFacadPatern;

        public HomeController(ILogger<HomeController> logger, IHomeFacadPatern homeFacadPatern)
        {
            _logger = logger;
            _homeFacadPatern = homeFacadPatern;
        }

        public IActionResult Index()
        {
            ViewBag.Users = _homeFacadPatern.GetRecentUsersService.Execute();
            ViewBag.Books = _homeFacadPatern.GetRecentBooksService.Execute();
            ViewBag.Reservations= _homeFacadPatern.GetRecentReservationsService.Execute();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationTest.Data;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        
        public IActionResult Index()
        {
            if (HttpContext.Session==null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
        
        public IActionResult Notification()
        {
            if (HttpContext.Session == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
        
        public IActionResult AboutUS()
        {
            if (HttpContext.Session == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
        
        public IActionResult AddUser()
        {
            if (HttpContext.Session == null)
            {
                return RedirectToAction("Index", "Login");
            }
        
            
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(user usermodel)
        {
            if (HttpContext.Session == null)
            {
                return RedirectToAction("Index", "Login");
            }
            _context.Add(usermodel);
            _context.SaveChanges();

            return View();
        }


        public IActionResult archive()
        {
            if (HttpContext.Session == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }

        public IActionResult AddAp()
        {
            if (HttpContext.Session == null)
            {
                return RedirectToAction("Index", "Login");
            }
           

            return View();
        }
        public IActionResult users()
        {
            if (HttpContext.Session == null)
            {
                return RedirectToAction("Index", "Login");
            }


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

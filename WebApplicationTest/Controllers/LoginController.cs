using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationTest.Data;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    public class LoginController : Controller
    {

        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var user =  _context.tbl_login.FirstOrDefault(x => x.email == email && x.password == password);

            if (user == null) {
                //TempData["mssg"] = "The username or password is incorrect";
                //ModelState.AddModelError("Password", "Invalid login attempt.");
                return RedirectToAction("Index");
            }

            HttpContext.Session.SetString("username", user.email);
            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
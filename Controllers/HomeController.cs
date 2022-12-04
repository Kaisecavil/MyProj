using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProj.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationContext _appContext;
        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            _appContext =  context;
        }

        [HttpPost]
        public IActionResult Test(string name, string email, int age)
        {
            try
            {
                User user = new User(name, age, email);
                _appContext.Users.Add(user);
                _appContext.SaveChanges();
                return Content($"Succ reg {user.Name}:{user.Age}:{user.Email}");


            }
            catch (Exception e)
            {
                return Content($"oops something goes wrong - {e.Message}");
            }

        }
        [HttpPost]
        public IActionResult FindById(int id)
        {
            try
            {

                var users = _appContext.Set<User>();
                var test = users.ToList<User>();
                User user = users.Find(id);
                ViewData["Name"] = user.Name;
                ViewData["Age"] = user.Age;
                ViewData["Email"] = user.Email;
                return View();


            }
            catch (Exception e)
            {
                return Content($"oops something goes wrong - {e.Message}");
            }

        }
        [HttpGet]
        public IActionResult Test()
        {
           return View();
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
    }
}

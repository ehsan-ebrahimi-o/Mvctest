using Microsoft.AspNetCore.Mvc;
using setion5.Models;
using System.Diagnostics;

namespace setion5.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string GetName()
        {
            return "ehsan";
        }

        public string GetName1(string name)
        {
            return name;
        }

        public string GetName2(string name,string family , int age)
        {
            return name + " " + family + " and age : "  + age;
        }

        public string GetName3(string name, string family, int age)
        {
            return $"{name} {family}   and age: {age} ";
        }

        private string MyPrivate()
        {
            return "MyPrivate Metod ... ";
        }

        public IActionResult GetName4()
        {
            return View();
        }

        public IActionResult GetName5(string name)
        {
            return View("GetName5",name);
        }
    }
}

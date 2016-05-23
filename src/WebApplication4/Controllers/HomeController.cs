using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [Produces("application/xml")]
        public object GetXml()
        {
            return new TestClass { Name = "a", Age = 123 };
        }

        public object GetJson()
        {
            return new TestClass { Name = "a", Age = 123 };
        }

        public class TestClass
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}

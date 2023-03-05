using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //   return "This is my default action...";
        //}
        //
        // GET: /HelloWorld/Welcome/
        //public string Welcome(String name, int numTimes =1)
        //{
        //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }


    }
}
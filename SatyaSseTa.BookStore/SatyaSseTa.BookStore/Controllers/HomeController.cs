using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatyaSseTa.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //var obj = new { Id = 1, Name = "Satya" };

            //return View("AboutUs", obj);
            //return View("../../TempView/SatyaTemp");
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }

    }
}

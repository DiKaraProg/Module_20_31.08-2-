using Microsoft.AspNetCore.Mvc;
using Module_20_MVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module_20_MVC.Controlers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var list = new Worker();
            return View(list);
        }
        public IActionResult Worker(string id)
        {
            var work = new Worker();
            var One_Worker =work.One_Worker(id);
            return View(One_Worker);
        }
    }
}

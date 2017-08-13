using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class MyNewController : Controller
    {
        // GET: MyNew
        [HttpGet]
        public ActionResult First()
            
        {
            Product mehsul = new Product();
            mehsul.id = 1;
            mehsul.name = "Alma";
            mehsul.desc = "yasil alma";
            return View(mehsul);
        }
        [HttpPost]
        public ActionResult Second()
        
        {
            return View();
        }
    }
}
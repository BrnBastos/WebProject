using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebProject.Models;
using System.Web.Mvc;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var projeto = new Projeto();
            return View(projeto);
        }
        [HttpPost]

        public ActionResult Index(Projeto projeto)
        {
            if(ModelState.IsValid)
            {   
                return View("Resultado",projeto);
            }
            return View(projeto);
        }
        public ActionResult Resultado(Projeto projeto)
        {
            return View(projeto);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}

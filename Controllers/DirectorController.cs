using Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Factory.Controllers
{
    public class DirectorController : Controller
    {
        // GET: Director
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowNameDirector()
        {
            ViewBag.name = "Tikva";
            return View();
        }
        public ActionResult ShowDirector()
        {

            return View(showD());
        }

        static Director showD()
        {
            Director director1 = new Director("tikva", "yosef", 1996, 5);
            return director1;
        }
        public ActionResult ShowDirectorsNames()
        {
            string[] arrayOfNames = new string[] { "tikva", "yafit", "eden", "keren", "shay", "yosef" };
            ViewBag.array = arrayOfNames;
            return View();
        }
        public ActionResult ShowDirectors()
        {
            return View(ShowAll());
        }

        static List<Director> ShowAll()
        {
            Director director1 = new Director("tikva", "yosef", 1996, 4);
            Director director2 = new Director("tikva", "yosef", 2000, 6);



            Director[] arrayOfDinrectors = new Director[] { director1, director2 };
            List<Director> list1 = new List<Director>();
            list1.AddRange(arrayOfDinrectors);


            return list1;

        }
    }
}
using Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Factory.Controllers
{
    public class InspectorController : Controller
    {
        // GET: Inspector
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InspectorName()
        {
            ViewBag.name = "keren";
            return View();
        }

        public ActionResult ShowInspector()
        {

            return View(ShowI());
        }

        static Inspector ShowI()
        {
            Inspector inspector1 = new Inspector("tikva","yosef","dsad");
            return inspector1;
        }
        public ActionResult ShowInspectorsNames()
        {
            string[] arrayOfNames = new string[] { "tikva", "yafit", "eden", "keren", "shay", "yosef" };
            ViewBag.array = arrayOfNames;
            return View();
        }
        public ActionResult ShowInspectors()
        {
            return View(ShowAll());
        }

        static List<Inspector> ShowAll()
        {
            Inspector inspector1 = new Inspector("tikva", "yosef", "fxhg");
            Inspector inspector2 = new Inspector("tikva", "yosef", "ddg");
            Inspector inspector3 = new Inspector("tikva", "yosef", "gdj");
            Inspector inspector4 = new Inspector("tikva", "yosef", "gch");
       

            Inspector[] arrayOfInspectors = new Inspector[] { inspector1, inspector2, inspector3, inspector4 };
            List<Inspector> list1 = new List<Inspector>();
            list1.AddRange(arrayOfInspectors);


            return list1;
        }
    }
}
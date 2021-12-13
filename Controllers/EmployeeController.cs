using Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Factory.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowNameEmployee()
        {
            ViewBag.name = "Tikva";
            return View();
        }

       
        public ActionResult ShowEmployee()
        {
            return View(ShowE());
        }
        static Employy ShowE()
        {
            Employy employy1 = new Employy("tikva", "yosef", 1996, 5464786);
            return employy1;
        }



        public ActionResult ShowEmployeesNames()
        {
            string[] arrayOfNames = new string[] { "tikva", "yafit", "eden", "keren", "shay", "yosef" };
            ViewBag.array = arrayOfNames;
            return View();
        }
        public ActionResult ShowEmployees()
        { 
            return View(ShowAll());
        }

        static List<Employy> ShowAll()
        {
            Employy employy1 = new Employy("tikva", "yosef", 1996, 5464786);
            Employy employy2 = new Employy("tikva", "yosef", 1996, 5464786);
            Employy employy3 = new Employy("tikva", "yosef", 1996, 5464786);
            Employy employy4 = new Employy("tikva", "yosef", 1996, 5464786);
            Employy employy5 = new Employy("tikva", "yosef", 1996, 5464786);
            Employy employy6 = new Employy("tikva", "yosef", 1996, 5464786);

            Employy[] arrayOfEmployy = new Employy[] { employy1, employy2, employy3, employy4, employy5, employy6 };
            List<Employy> list1 = new List<Employy>();
            list1.AddRange(arrayOfEmployy);


            return list1;
        }

    }
}
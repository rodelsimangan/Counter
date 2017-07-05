using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Counter.Models;

namespace Counter.Controllers
{
    public class HomeController : Controller
    {
        static readonly ICounterRepository counterRepo = new CounterRepository();
        public ActionResult Index()
        {
            var counter = counterRepo.GetCounter();
            return View(counter);
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

        public ActionResult UpdateCount(Counter.Models.Counter counter)
        {
            if(counter.Count < 10)
            {
                counter.Count += 1;
                counterRepo.UpdateCounter(counter);
            }
           return  RedirectToAction("Index");
        }
    }
}
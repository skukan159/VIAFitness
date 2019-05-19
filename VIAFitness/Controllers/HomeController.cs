using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViaFitnessDataAccess.BusinessLogic;

namespace VIAFitness.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();

        }
    }
}
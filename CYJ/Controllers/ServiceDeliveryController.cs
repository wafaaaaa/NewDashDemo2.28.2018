using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CYJ.Controllers
{
    public class ServiceDeliveryController : Controller
    {
        // GET: ServiceDelivery
        public ActionResult Index()
        {
            return View();
        }
        //Add a goal
        public ActionResult Add()
        {
            return View();
        }

        //View goals
        public ActionResult viewGoals()
        {
            return View();
        }
    }
}
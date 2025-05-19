using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RescueBus.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult SelectServiceView()
        {
            return View();
        }

        public ActionResult ALSView()
        {
            return View();
        }

        public ActionResult BLSView()
        {
            return View();
        }

        public ActionResult AirAmbulanceView()
        {
            return View();
        }

        public ActionResult EMAView()
        {
            return View();
        }

        public ActionResult MUVView()
        {
            return View();
        }

        public ActionResult PatientTransportView()
        {
            return View();
        }
    }
}
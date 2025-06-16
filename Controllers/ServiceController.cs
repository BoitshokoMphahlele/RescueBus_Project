using RescueBus.Models;
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
            string serviceType = "ALS";

            var drivers = DriverRepository.GetDrivers()
                .Where(d => d.servicetype == serviceType)
                .Select(d => new SelectListItem
                {
                    Value = d.Name,
                    Text = d.Name
                }).ToList();

            var vehicles = VehicleRepository.GetVehicles()
                .Where(v => v.Type == serviceType)
                .Select(v => new SelectListItem
                {
                    Value = v.RegistrationId.ToString(),
                    Text = v.RegistrationId.ToString()
                }).ToList();
            ViewBag.Reasons = new SelectList(DriverRepository.Reasons());

            ViewBag.Drivers = drivers;
            ViewBag.Vehicles = vehicles;

            return View();

        }



        public ActionResult BLSView()
        {
            string serviceType = "BLS";

            var drivers = DriverRepository.GetDrivers()
                .Where(d => d.servicetype == serviceType)
                .Select(d => new SelectListItem
                {
                    Value = d.Name,
                    Text = d.Name
                }).ToList();

            var vehicles = VehicleRepository.GetVehicles()
                .Where(v => v.Type == serviceType)
                .Select(v => new SelectListItem
                {
                    Value = v.RegistrationId.ToString(),
                    Text = v.RegistrationId.ToString()
                }).ToList();
            ViewBag.Reasons = new SelectList(DriverRepository.Reasons());

            ViewBag.Drivers = drivers;
            ViewBag.Vehicles = vehicles;

            return View();
        }

        public ActionResult AirAmbulanceView()
        {
            string serviceType = "AAS";

            var drivers = DriverRepository.GetDrivers()
                .Where(d => d.servicetype == serviceType)
                .Select(d => new SelectListItem
                {
                    Value = d.Name,
                    Text = d.Name
                }).ToList();

            var vehicles = VehicleRepository.GetVehicles()
                .Where(v => v.Type == serviceType)
                .Select(v => new SelectListItem
                {
                    Value = v.RegistrationId.ToString(),
                    Text = v.RegistrationId.ToString()
                }).ToList();
            ViewBag.Reasons = new SelectList(DriverRepository.Reasons());

            ViewBag.Drivers = drivers;
            ViewBag.Vehicles = vehicles;

            return View();

        }

        public ActionResult EMAView()
        {
            string serviceType = "EMA";

            var drivers = DriverRepository.GetDrivers()
                .Where(d => d.servicetype == serviceType)
                .Select(d => new SelectListItem
                {
                    Value = d.Name,
                    Text = d.Name
                }).ToList();

            var vehicles = VehicleRepository.GetVehicles()
                .Where(v => v.Type == serviceType)
                .Select(v => new SelectListItem
                {
                    Value = v.RegistrationId.ToString(),
                    Text = v.RegistrationId.ToString()
                }).ToList();
            ViewBag.Reasons = new SelectList(DriverRepository.Reasons());

            ViewBag.Drivers = drivers;
            ViewBag.Vehicles = vehicles;

            return View();
        }

        public ActionResult MUVView()
        {
            string serviceType = "MUV";

            var drivers = DriverRepository.GetDrivers()
                .Where(d => d.servicetype == serviceType)
                .Select(d => new SelectListItem
                {
                    Value = d.Name,
                    Text = d.Name
                }).ToList();

            var vehicles = VehicleRepository.GetVehicles()
                .Where(v => v.Type == serviceType)
                .Select(v => new SelectListItem
                {
                    Value = v.RegistrationId.ToString(),
                    Text = v.RegistrationId.ToString()
                }).ToList();
            ViewBag.Reasons = new SelectList(DriverRepository.Reasons());

            ViewBag.Drivers = drivers;
            ViewBag.Vehicles = vehicles;

            return View();
        }

        public ActionResult PatientTransportView()
        {
            string serviceType = "PatientTransport";

            var drivers = DriverRepository.GetDrivers()
                .Where(d => d.servicetype == serviceType)
                .Select(d => new SelectListItem
                {
                    Value = d.Name,
                    Text = d.Name
                }).ToList();

            var vehicles = VehicleRepository.GetVehicles()
                .Where(v => v.Type == serviceType)
                .Select(v => new SelectListItem
                {
                    Value = v.RegistrationId.ToString(),
                    Text = v.RegistrationId.ToString()
                }).ToList();
            ViewBag.Reasons = new SelectList(DriverRepository.Reasons());

            ViewBag.Drivers = drivers;
            ViewBag.Vehicles = vehicles;

            return View();
        }

    }
}
using RescueBus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RescueBus.Controllers
{
    public class ManageController : Controller
    {
        // GET: Manage
        public ActionResult ManageView()
        {
            var model = new ManageViewModel
            {
                Drivers = DriverRepository.GetAll(),
                Vehicles = VehicleRepository.GetAll()
            };

            return View(model);


        }
        public ActionResult CreateDriverView()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDriverView(Driver driver)
        {
            if (ModelState.IsValid)
            {
                DriverRepository.Add(driver);

                return RedirectToAction("ManageView");
            }

            return View(driver);
        }

        public ActionResult AddVehicleView()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddVehicleView(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                VehicleRepository.Add(vehicle);

                return RedirectToAction("ManageView");
            }

            return View(vehicle);
        }
        public ActionResult EditDriverView(int id)
        {
            var driver = DriverRepository.GetAll().FirstOrDefault(d => d.Id == id);
            if (driver == null)
            {
                return HttpNotFound();
            }

            return View(driver);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDriverView(Driver updatedDriver)
        {
            var driver = DriverRepository.GetAll().FirstOrDefault(d => d.Id == updatedDriver.Id);
            if (driver != null)
            {
                driver.Name = updatedDriver.Name;
                driver.PhoneNumber = updatedDriver.PhoneNumber;
                driver.servicetype = updatedDriver.servicetype;
                driver.imagepath = updatedDriver.imagepath;
            }

            return RedirectToAction("ManageView");
        }
        public ActionResult EditVehicleView(int id)
        {
            var vehicle = VehicleRepository.GetAll().FirstOrDefault(v => v.RegistrationId == id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }

            return View(vehicle);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditVehicleView(Vehicle updatedVehicle)
        {
            var vehicle = VehicleRepository.GetAll().FirstOrDefault(v => v.RegistrationId == updatedVehicle.RegistrationId);
            if (vehicle != null)
            {
                
                vehicle.Type = updatedVehicle.Type;
                vehicle.imagepath = updatedVehicle.imagepath;
            }

            return RedirectToAction("ManageView");
        }

       

    }
}
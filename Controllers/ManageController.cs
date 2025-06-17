using RescueBus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.IO;

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

        public FileResult DownloadFile(string fileName)
        {
            string path = Server.MapPath("~/Documents/") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);
            return File(bytes, "application/octet-stream", fileName);
        }

        public ActionResult ExportVehiclesToFile()
        {
            var vehicles = VehicleRepository.GetAll();

            // Construct the text content
            var lines = new List<string> { "Vehicle RegistrationID - Type" };
            lines.AddRange(vehicles.Select(v => $"{v.RegistrationId} - {v.Type}"));

            // Set file path and name
            string fileName = "Vehicles.txt";
            string directoryPath = Server.MapPath("~/Documents/");
            string fullPath = Path.Combine(directoryPath, fileName);

            // Ensure directory exists
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Write to file
            System.IO.File.WriteAllLines(fullPath, lines);

            // Redirect to the FileController for download
            return RedirectToAction("DownloadFile", "Manage", new { fileName = fileName });
        }



    }
}
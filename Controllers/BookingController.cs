using RescueBus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RescueBus.Controllers
{
    public class BookingController : Controller
    {
        
        [HttpPost]
        public ActionResult ALSView(Booking booking)
        {
            booking.servicetype = "ALS";  
            booking.BookingID = Guid.NewGuid().ToString();
            booking.bookingDate = DateTime.Now;

            var driver = DriverRepository.GetDrivers().FirstOrDefault(d => d.servicetype == "ALS");
            var vehicle = VehicleRepository.GetVehicles().FirstOrDefault(v => v.Type == "ALS");

            if (driver != null)
            {
                booking.Driver = driver.Name;
                booking.Phone = driver.PhoneNumber;
                booking.DriverImagePath = driver.imagepath;
            }

            if (vehicle != null)
            {
                booking.Vehicle = vehicle.RegistrationId.ToString();
                booking.VehicleImagePath = vehicle.imagepath;
            }

            return View("BookingConfirmedView", booking);
        }
        [HttpPost]
        public ActionResult BLSView(Booking booking)
        {
            booking.servicetype = "BLS";
            booking.BookingID = Guid.NewGuid().ToString();
            booking.bookingDate = DateTime.Now;

            var driver = DriverRepository.GetDrivers().FirstOrDefault(d => d.servicetype == "BLS");
            var vehicle = VehicleRepository.GetVehicles().FirstOrDefault(v => v.Type == "BLS");

            if (driver != null)
            {
                booking.Driver = driver.Name;
                booking.Phone = driver.PhoneNumber;
                booking.DriverImagePath = driver.imagepath;
            }

            if (vehicle != null)
            {
                booking.Vehicle = vehicle.RegistrationId.ToString();
                booking.VehicleImagePath = vehicle.imagepath;
            }

            return View("BookingConfirmedView", booking);
        }
        [HttpPost]
        public ActionResult MUVView(Booking booking)
        {
            booking.servicetype = "MUV";
            booking.BookingID = Guid.NewGuid().ToString();
            booking.bookingDate = DateTime.Now;

            var driver = DriverRepository.GetDrivers().FirstOrDefault(d => d.servicetype == "MUV");
            var vehicle = VehicleRepository.GetVehicles().FirstOrDefault(v => v.Type == "MUV");

            if (driver != null)
            {
                booking.Driver = driver.Name;
                booking.Phone = driver.PhoneNumber;
                booking.DriverImagePath = driver.imagepath;
            }

            if (vehicle != null)
            {
                booking.Vehicle = vehicle.RegistrationId.ToString();
                booking.VehicleImagePath = vehicle.imagepath;
            }

            return View("BookingConfirmedView", booking);
        }
        [HttpPost]
        public ActionResult PatientTransportView(Booking booking)
        {
            booking.servicetype = "PatientTransport";
            booking.BookingID = Guid.NewGuid().ToString();
            booking.bookingDate = DateTime.Now;

            var driver = DriverRepository.GetDrivers().FirstOrDefault(d => d.servicetype == "PatientTransport");
            var vehicle = VehicleRepository.GetVehicles().FirstOrDefault(v => v.Type == "PatientTransport");

            if (driver != null)
            {
                booking.Driver = driver.Name;
                booking.Phone = driver.PhoneNumber;
                booking.DriverImagePath = driver.imagepath;
            }

            if (vehicle != null)
            {
                booking.Vehicle = vehicle.RegistrationId.ToString();
                booking.VehicleImagePath = vehicle.imagepath;
            }

            return View("BookingConfirmedView", booking);
        }
        [HttpPost]
        public ActionResult AirAmbulanceView(Booking booking)
        {
            booking.servicetype = "AAS";
            booking.BookingID = Guid.NewGuid().ToString();
            booking.bookingDate = DateTime.Now;

            var driver = DriverRepository.GetDrivers().FirstOrDefault(d => d.servicetype == "AAS");
            var vehicle = VehicleRepository.GetVehicles().FirstOrDefault(v => v.Type == "AAS");

            if (driver != null)
            {
                booking.Driver = driver.Name;
                booking.Phone = driver.PhoneNumber;
                booking.DriverImagePath = driver.imagepath;
            }

            if (vehicle != null)
            {
                booking.Vehicle = vehicle.RegistrationId.ToString();
                booking.VehicleImagePath = vehicle.imagepath;
            }

            return View("BookingConfirmedView", booking);
        }
        [HttpPost]
        public ActionResult EMAView(Booking booking)
        {
            booking.servicetype = "EMA";
            booking.BookingID = Guid.NewGuid().ToString();
            booking.bookingDate = DateTime.Now;

            var driver = DriverRepository.GetDrivers().FirstOrDefault(d => d.servicetype == "EMA");
            var vehicle = VehicleRepository.GetVehicles().FirstOrDefault(v => v.Type == "EMA");

            if (driver != null)
            {
                booking.Driver = driver.Name;
                booking.Phone = driver.PhoneNumber;
                booking.DriverImagePath = driver.imagepath;
            }

            if (vehicle != null)
            {
                booking.Vehicle = vehicle.RegistrationId.ToString();
                booking.VehicleImagePath = vehicle.imagepath;
            }

            return View("BookingConfirmedView", booking);
        }
        [HttpGet]
        public ActionResult SOSBooking()
        {
            var drivers = DriverRepository.GetDrivers();
            var vehicles = VehicleRepository.GetVehicles();

            var sosDriver = drivers.FirstOrDefault(d => d.servicetype == "SOS");
            if (sosDriver == null)
            {
                sosDriver = new Driver { Name = "Unassigned", PhoneNumber = "Unknown" };
            }

            var sosVehicle = vehicles.FirstOrDefault(v => v.Type == "SOS");
            if (sosVehicle == null)
            {
                sosVehicle = new Vehicle { RegistrationId = 0, Type = "Ambulance" };
            }

            var booking = new Booking
            {
                BookingID = Guid.NewGuid().ToString(),
                bookingDate = DateTime.Now,
                PickUpTime = DateTime.Now,
                Address = "Emergency Location Not Provided",
                Driver = sosDriver.Name,
                Phone = sosDriver.PhoneNumber,
                servicetype = "SOS",
                Vehicle = sosVehicle.RegistrationId.ToString()
            };

            return View("BookingConfirmedView", booking);
        }

        public ActionResult RideHistoryView()
        {
            return View();
        }
        public ActionResult BookingConfirmedView()
        {
            return View();
        }
        public ActionResult BookingConfirmed(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return RedirectToAction("RideHistoryView"); // or any fallback
            }

            ViewBag.BookingId = id; // pass to JS if needed
            ViewBag.Title = "Booking Confirmed";

            return View();
        }
    }
}
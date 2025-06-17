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

            return View("BookingConfirmedView", booking);
        }
        [HttpPost]
        public ActionResult BLSView(Booking booking)
        {
            booking.servicetype = "BLS";
            booking.BookingID = Guid.NewGuid().ToString();
            booking.bookingDate = DateTime.Now;

            return View("BookingConfirmedView", booking);
        }
        [HttpPost]
        public ActionResult MUVView(Booking booking)
        {
            booking.servicetype = "MUV";
            booking.BookingID = Guid.NewGuid().ToString();
            booking.bookingDate = DateTime.Now;

            return View("BookingConfirmedView", booking);
        }
        [HttpPost]
        public ActionResult PatientTransportView(Booking booking)
        {
            booking.servicetype = "PatientTransport";
            booking.BookingID = Guid.NewGuid().ToString();
            booking.bookingDate = DateTime.Now;

            return View("BookingConfirmedView", booking);
        }
        [HttpPost]
        public ActionResult AirAmbulanceView(Booking booking)
        {
            booking.servicetype = "AAS";
            booking.BookingID = Guid.NewGuid().ToString();
            booking.bookingDate = DateTime.Now;

            return View("BookingConfirmedView", booking);
        }
        [HttpPost]
        public ActionResult EMAView(Booking booking)
        {
            booking.servicetype = "EMA";
            booking.BookingID = Guid.NewGuid().ToString();
            booking.bookingDate = DateTime.Now;

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
    }
}
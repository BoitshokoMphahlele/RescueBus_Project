using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class Booking
    {
        public string BookingID { get; set; }
        public string servicetype { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public DateTime PickUpTime { get; set; }
        public DateTime bookingDate { get; set; }
        public  string Reason { get; set; }
        public  string Vehicle { get; set; }
        public string Driver { get; set; }
        public string Address { get; set; }

        //Constructor
        public Booking()
        {
           
        }
        
        
        
        
        
    }
    
}
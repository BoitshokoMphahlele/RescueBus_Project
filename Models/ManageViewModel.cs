using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class ManageViewModel
    {
        public List<Driver> Drivers { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class VehicleRepository
    {
        public static List<Vehicle> GetVehicles()
        {
            return new List<Vehicle> 
            {
                new Vehicle{RegistrationId = 1080,Type = "ALS"},
                new Vehicle{RegistrationId = 1081,Type = "ALS"},
                new Vehicle{RegistrationId = 1083,Type = "BLS"},
                new Vehicle{RegistrationId = 1084,Type = "BLS"},
                new Vehicle{RegistrationId = 1085,Type = "MUV"},
                new Vehicle{RegistrationId = 1082,Type = "MUV"},
                new Vehicle{RegistrationId = 1086,Type = "EMA"},
                new Vehicle{RegistrationId = 1087,Type = "EMA"},
                new Vehicle{RegistrationId = 1088,Type = "EMA"},
                new Vehicle{RegistrationId = 1089,Type = "PatientTransport"},
                new Vehicle{RegistrationId = 1090,Type = "PatientTransport"},
                new Vehicle{RegistrationId = 1091,Type = "AAS"},
                new Vehicle{RegistrationId = 1092,Type = "AAS"},
            };
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class VehicleRepository
    {
        public static List<Vehicle>vehicles = new List<Vehicle> 
        {
                new Vehicle{ imagepath = "/Content/Images/Ambulance1.png" ,RegistrationId = 1080,Type = "ALS"},
                new Vehicle{ imagepath = "/Content/Images/Ambulance2.jpeg" ,RegistrationId = 1081,Type = "ALS"},
                new Vehicle{ imagepath = "/Content/Images/Ambulance3.png" ,RegistrationId = 1083,Type = "SOS"},
                new Vehicle{imagepath = "/Content/Images/Ambulance4.png", RegistrationId = 1084,Type = "BLS"},
                new Vehicle{imagepath = "/Content/Images/Ambulance5.png", RegistrationId = 1085,Type = "MUV"},
                new Vehicle{imagepath = "/Content/Images/Ambulance6.png", RegistrationId = 1082,Type = "SOS"},
                new Vehicle{imagepath = "/Content/Images/Ambulance7.png", RegistrationId = 1087,Type = "EMA"},
                new Vehicle{imagepath = "/Content/Images/Ambulance8.jpeg", RegistrationId = 1088,Type = "EMA"},
                new Vehicle{imagepath = "/Content/Images/Ambulance9.png", RegistrationId = 1089,Type = "PatientTransport"}, 
                new Vehicle{imagepath = "/Content/Images/Ambulance10.png", RegistrationId = 1092,Type = "AAS"},
        };
        public static List<Vehicle> GetVehicles()
        {
            return new List<Vehicle> 
            {
                new Vehicle{imagepath = "/Content/Images/Ambulance1.png", RegistrationId = 1080,Type = "ALS"},
                new Vehicle{imagepath = "/Content/Images/Ambulance2.jpeg", RegistrationId = 1081,Type = "ALS"},
                new Vehicle{imagepath = "/Content/Images/Ambulance3.png", RegistrationId = 1083,Type = "SOS"},
                new Vehicle{imagepath = "/Content/Images/Ambulance4.png", RegistrationId = 1084,Type = "BLS"},
                new Vehicle{imagepath = "/Content/Images/Ambulance5.png", RegistrationId = 1085,Type = "MUV"},
                new Vehicle{imagepath = "/Content/Images/Ambulance6.png", RegistrationId = 1082,Type = "SOS"},
                new Vehicle{imagepath = "/Content/Images/Ambulance7.png", RegistrationId = 1087,Type = "EMA"},
                new Vehicle{imagepath = "/Content/Images/Ambulance8.jpeg", RegistrationId = 1088,Type = "EMA"},
                new Vehicle{imagepath = "/Content/Images/Ambulance9.png", RegistrationId = 1089,Type = "PatientTransport"},
                new Vehicle{ imagepath = "/Content/Images/Ambulance10.png" ,RegistrationId = 1092,Type = "AAS"},
            };
        }
        public static List<Vehicle> GetAll()
        {
            return vehicles;
        }
        public static void Add(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
    }
}
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class DriverRepository
    {
        public static List<Driver> GetDrivers()
        {
           return new List<Driver> 
           {
               new Driver { Id = 1,Name = "Alice Smith",PhoneNumber = "0712345678", servicetype = "ALS" },
               new Driver { Id= 2,Name = "Jack Mason",PhoneNumber = "0823334567", servicetype = "ALS" },
               new Driver { Id= 3,Name = "Alice",PhoneNumber = "0712345678", servicetype = "BLS" },
               new Driver { Id = 4,Name = "Alice",PhoneNumber = "0712345678", servicetype = "BLS" },
               new Driver { Id = 5,Name = "Alice",PhoneNumber = "0712345678", servicetype = "MUV" },
               new Driver { Id = 6,Name = "Alice",PhoneNumber = "0712345678", servicetype = "MUV" },
               new Driver { Id = 7,Name = "Alice",PhoneNumber = "0712345678", servicetype = "EMA" },
               new Driver { Id = 8,Name = "Alice",PhoneNumber = "0712345678", servicetype = "EMA" },
               new Driver { Id = 9,Name = "Alice",PhoneNumber = "0712345678", servicetype = "PatientTransport" },
               new Driver { Id = 10,Name = "Alice",PhoneNumber = "0712345678", servicetype = "PatientTransport" },
               new Driver { Id = 11,Name = "Alice",PhoneNumber = "0712345678", servicetype = "AAS" },
               new Driver { Id = 12,Name = "Alice",PhoneNumber = "0712345678", servicetype = "AAS" },
           };
        }

        public static List<string> Reasons() 
        {
            return new List<string>
            {
                "Allergy","Chest Pain","Severe Bleeding","Difficulty Breathing"
            };
        }


    }



}
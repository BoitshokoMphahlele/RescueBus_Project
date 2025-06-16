using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class DriverRepository
    {
        public static List<Driver>drivers = new List<Driver> 
        {
             new Driver { imagepath = "/Content/Images/Person1.png" ,Id = 1,Name = "Alice Smith",PhoneNumber = "0712345678", servicetype = "ALS" },
               new Driver { imagepath = "/Content/Images/Person2.jpeg" ,Id= 2,Name = "Jack Mason",PhoneNumber = "0823334567", servicetype = "ALS" },
               new Driver { imagepath = "/Content/Images/Person3.png" ,Id= 3,Name = "Alice",PhoneNumber = "0712345678", servicetype = "BLS" },
               new Driver { imagepath = "/Content/Images/Person4.png" ,Id = 4,Name = "Alice",PhoneNumber = "0712345678", servicetype = "BLS" },
               new Driver { imagepath = "/Content/Images/Person5.png" ,Id = 5,Name = "Alice",PhoneNumber = "0712345678", servicetype = "MUV" },
               new Driver { imagepath = "/Content/Images/Person6.png" ,Id = 7,Name = "Alice",PhoneNumber = "0712345678", servicetype = "EMA" },
               new Driver { imagepath = "/Content/Images/Person7.png" ,Id = 8,Name = "Alice",PhoneNumber = "0712345678", servicetype = "EMA" },
               new Driver { imagepath = "/Content/Images/Person8.png" ,Id = 10,Name = "Alice",PhoneNumber = "0712345678", servicetype = "PatientTransport" },
               new Driver { imagepath = "/Content/Images/Person9.png" ,Id = 11,Name = "Alice",PhoneNumber = "0712345678", servicetype = "AAS" },
               new Driver { imagepath = "/Content/Images/Person10.png" ,Id = 12,Name = "Alice",PhoneNumber = "0712345678", servicetype = "AAS" },
        };
        public static List<Driver> GetDrivers()
        {
           return new List<Driver> 
           {
               new Driver { imagepath = "/Content/Images/Person1.png" ,Id = 1,Name = "Alice Smith",PhoneNumber = "0712345678", servicetype = "ALS" },
               new Driver { imagepath = "/Content/Images/Person2.jpeg" ,Id= 2,Name = "Jack Mason",PhoneNumber = "0823334567", servicetype = "ALS" },
               new Driver { imagepath = "/Content/Images/Person3.png" ,Id= 3,Name = "Alice",PhoneNumber = "0712345678", servicetype = "BLS" },
               new Driver { imagepath = "/Content/Images/Person4.png" ,Id = 4,Name = "Alice",PhoneNumber = "0712345678", servicetype = "BLS" },
               new Driver { imagepath = "/Content/Images/Person5.png" ,Id = 5,Name = "Alice",PhoneNumber = "0712345678", servicetype = "MUV" },
               new Driver { imagepath = "/Content/Images/Person6.png" ,Id = 7,Name = "Alice",PhoneNumber = "0712345678", servicetype = "EMA" },
               new Driver { imagepath = "/Content/Images/Person7.png" ,Id = 8,Name = "Alice",PhoneNumber = "0712345678", servicetype = "EMA" },
               new Driver { imagepath = "/Content/Images/Person8.png" ,Id = 10,Name = "Alice",PhoneNumber = "0712345678", servicetype = "PatientTransport" },
               new Driver { imagepath = "/Content/Images/Person9.png" ,Id = 11,Name = "Alice",PhoneNumber = "0712345678", servicetype = "AAS" },
               new Driver { imagepath = "/Content/Images/Person10.png" ,Id = 12,Name = "Alice",PhoneNumber = "0712345678", servicetype = "AAS" },
           };

        }

        public static List<string> Reasons() 
        {
            return new List<string>
            {
                "Allergy","Chest Pain","Severe Bleeding","Difficulty Breathing"
            };
        }
        public static List<Driver> GetAll()
        {
            return drivers;
        }
        public static void Add(Driver driver)
        {
            drivers.Add(driver);
        }



    }



}
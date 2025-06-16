using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace RescueBus.Models
{
    public class Person
    {
        public int Id { get; set; }
        private string _Name;
        private string _PhoneNumber;
      

        //Constructor
        public Person(string Name, string PhoneNumber, string Address)
        {
            _Name = Name;
            _PhoneNumber = PhoneNumber;
            
        }

        public Person() { }

        //Properties
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        
    }
    public class Client : Person
    {
        public string _address;
        public Client() { }

        public Client(string Address) {
            _address = Address;
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
    }
    public class Driver:Person
    {
        public string servicetype {  get; set; }
        public Driver() { }
    }
}
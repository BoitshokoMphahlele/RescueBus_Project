using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class Client
    {
        private string _Name;
        private string _PhoneNumber;
        private string _Address;

        //Constructor
        public Client(string Name, string PhoneNumber, string Address)
        {
            _Name = Name;
            _PhoneNumber = PhoneNumber;
            _Address = Address;
        }

        //Properties
        public string CName
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
    }
}
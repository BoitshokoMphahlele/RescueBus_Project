using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RescueBus.Models
{
    public class Booking
    {
        private string _ClientName;
        private string _ClientPhone;
        private string _ClientAddress;
        private string _Driver;
        private string _Vehicle;
        private string _Reason;
        private string _PickUpTime;

        //Constructor
        public Booking()
        {
            string ClientName = _ClientName;
            string ClientPhone = _ClientPhone;
            string ClientAddress = _ClientAddress;
            string Driver = _Driver;
            string Vehicle = _Vehicle;
            string reason = _Reason;
            string pickUpTime = _PickUpTime;
          
        }

        //Properties
        public string ClientName
        {
            get { return _ClientName; }
            set { _ClientName = value; }
        }
        public string ClientPhone
        {
            get { return _ClientPhone; }
            set { _ClientPhone = value; }
        }
        public string ClientAddress
        {
            get { return _ClientAddress; }
            set { _ClientAddress = value; }
        }
        public string Driver
        {
            get { return _Driver; }
            set { _Driver = value; }
        }
        public string Vehicle
        {
            get { return _Vehicle; }
            set { _Vehicle = value; }
        }
        public string reason
        {
            get { return _Reason; }
            set { _Reason = value; }
        }
        public string PickUpTime
        {
            get { return _PickUpTime; }
            set { _PickUpTime = value; }
        }
    }
}
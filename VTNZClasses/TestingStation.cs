using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VTNZClasses
{
    public abstract class TestingStation
    {
        protected string z_strAddress;
        protected string z_strHours;
        protected string z_strName;

        public TestingStation(string name, string address, string hours)
        {
            z_strName = name;
            z_strAddress = address;
            z_strHours = hours;    
        }

        public string StationName
        {
            get => z_strName;
            set => z_strName = value;
        }

        public string StationAddress
        {
            get => z_strAddress;
            set => z_strAddress = value;
        }

        public string StationHours
        {
            get => z_strHours;
            set => z_strHours = value;
        }

        public abstract string printDetails();
    }    
}
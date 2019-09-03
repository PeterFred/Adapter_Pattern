using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VTNZClasses
{
    public class VTNZ : TestingStation
    {
        private string _eMail;
        private List<IService> _serviceList;

        public VTNZ(string address, string hours, string name, string email) : base(address, hours, name)
        {
            _serviceList = new List<IService>();
            _eMail = email;
        }

        public string Email
        {
            get => _eMail;
            set => _eMail = value;
        }

        public List<IService> ServiceList
        {
            get => _serviceList;
        }

        public void addService(IService service)
        {
            
            _serviceList.Add(service);
        }

        public override string printDetails()
        {
            return base.StationName + Environment.NewLine +
                base.StationAddress + Environment.NewLine +
                base.StationHours + Environment.NewLine +
                Email;                
        }
    }
}
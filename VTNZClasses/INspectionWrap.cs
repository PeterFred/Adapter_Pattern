using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VTNZClasses
{
    public class InspectionWrap : IService
    {
        private CarInspection _carInspection;

        public InspectionWrap(decimal price,string name)
        {
            _carInspection = new CarInspection(price, name);
        }

        decimal IService.ServicePrice { get => _carInspection.CarServicePrice;
            set => _carInspection.CarServicePrice = value; }

        string IService.ServiceType { get => _carInspection.CarServiceType;
            set => _carInspection.CarServiceType = value;  }

        string IService.ServiceDetails {
            get { return _carInspection.CarServiceType + " " + _carInspection.CarServicePrice.ToString("C"); } }
    }
}
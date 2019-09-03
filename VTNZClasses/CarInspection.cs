using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VTNZClasses
{
    public class CarInspection
    {
        private decimal _price;
        private string _type;

        public CarInspection(decimal price, string type)
        {
            _price = price;
            _type = type;
        }

        public decimal CarServicePrice
        {
            get => _price;
            set => _price = value;
        }

        public string CarServiceType
        {
            get => _type;
            set => _type = value;
        }
    }
}
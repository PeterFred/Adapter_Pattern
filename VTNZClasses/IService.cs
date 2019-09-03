using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VTNZClasses
{
    public interface IService
    {

        decimal ServicePrice { get; set; }

        string ServiceType { get; set; }

        string ServiceDetails { get; }

    }
}
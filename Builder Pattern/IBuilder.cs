using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    interface IBuilder
    {
        void SetType();
        void SetColor();
        void SetEngine();
        void SetModel();
        void SetTopSpeed();
        void SetAccessories();
        Vehicle GetVehicle();
    }
}

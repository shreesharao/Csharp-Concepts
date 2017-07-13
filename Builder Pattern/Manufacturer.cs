using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    class Manufacturer
    {
        private IBuilder builder;
        public void Manufacture(IBuilder builder)
        {
            this.builder = builder;

            this.builder.SetType();
            this.builder.SetColor();
            this.builder.SetEngine();
            this.builder.SetModel();
            this.builder.SetTopSpeed();
            this.builder.SetAccessories();

        }
        public Vehicle GetVehicle()
        {
            return this.builder.GetVehicle();
        }
    }
}

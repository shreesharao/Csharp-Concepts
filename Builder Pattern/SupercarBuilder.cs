using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    class SupercarBuilder:IBuilder
    {
        private Vehicle _superCar = new Vehicle();

        public void SetType()
        {
            _superCar.Type = "Super Car";
        }

        public void SetColor()
        {
            _superCar.Color = "Red";
        }

        public void SetEngine()
        {
            _superCar.Engine = "40 stroke";
        }

        public void SetModel()
        {
            _superCar.Model = "2017";
        }

        public void SetTopSpeed()
        {
            _superCar.TopSpeed = 2000;
        }

        public void SetAccessories()
        {
            _superCar.accessories.Add("sterio");
            _superCar.accessories.Add("seat");
        }

        public Vehicle GetVehicle()
        {
            return _superCar;
        }
    }
}

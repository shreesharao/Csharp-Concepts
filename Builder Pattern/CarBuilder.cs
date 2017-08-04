using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    class CarBuilder:IBuilder
    {
        private Vehicle _car = new Vehicle();

        public void SetType()
        {
            _car.Type = "Car";
        }

        public void SetColor()
        {
            _car.Color = "Red";
        }

        public void SetEngine()
        {
            _car.Engine = "4 stroke";
        }

        public void SetModel()
        {
            _car.Model = "2017";
        }

        public void SetTopSpeed()
        {
            _car.TopSpeed = 200;
        }

        public void SetAccessories()
        {
            _car.accessories.Add("sterio");
        }

        public Vehicle GetVehicle()
        {
            return _car;
        }
    }
}

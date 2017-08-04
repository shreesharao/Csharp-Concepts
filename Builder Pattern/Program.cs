using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
           new Client().Entry();
            Console.Read();
        }
    }

    class Client
    {
        Manufacturer objManufacturer =null;

        public void Entry()
        {
            objManufacturer = new Manufacturer();
            objManufacturer.Manufacture(new CarBuilder());
            var car = objManufacturer.GetVehicle();
            car.GetInfo();
            AddCharacter('*', 20);

            objManufacturer.Manufacture(new SupercarBuilder());
            Vehicle objVehicle = objManufacturer.GetVehicle();
            var superCar = objManufacturer.GetVehicle();
            superCar.GetInfo();
            AddCharacter('*', 20);
        }

        public void AddCharacter(char ch,int count)
        {
            Console.WriteLine(new string(ch, count));
        }
    }
}

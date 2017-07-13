using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
   public class Vehicle
    {
       public string Type { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public long TopSpeed { get; set; }
        public List<string> accessories { get; set; }

        public Vehicle()
        {
            accessories = new List<string>();
        }

       public void GetInfo()
        {
            Console.WriteLine("Vehicle Type:" + this.Type);
            Console.WriteLine("Color:"+this.Color);
            Console.WriteLine("Model:"+this.Model);
            Console.WriteLine("Engine:"+this.Engine);
            Console.WriteLine("TopSpeed:"+this.TopSpeed);
            Console.WriteLine("accessories:");
            foreach (var item in this.accessories)
            {
                Console.WriteLine("\t"+item);
            }
        }
    }
}

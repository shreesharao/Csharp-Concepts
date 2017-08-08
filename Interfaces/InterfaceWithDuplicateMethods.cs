using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    class MainClass
    {
        public void GetInfo()
        {
            I1 I1Obj = new InterfaceWithDuplicateMethods();
            I1Obj.GetInfo();

            I2 I2Obj = new InterfaceWithDuplicateMethods();
            I2Obj.GetInfo();
        }
    }


    class InterfaceWithDuplicateMethods:I1,I2
    {
        public void GetInfo()
        {
            Console.WriteLine("duplicated method");
        }
    }

    interface I1
    {
        void GetInfo();
    }

    interface I2
    {
        void GetInfo();
    }
}

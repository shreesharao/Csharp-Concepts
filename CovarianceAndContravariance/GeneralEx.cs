using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    interface IGeneralEx
    {

    }
    class GeneralEx1:IGeneralEx
    {
        public int i = 0;
        public void Print()
        {
            Console.WriteLine(i);
        }
    }


    class GeneralEx2:GeneralEx1
    {
        public new void Print()
        {
            Console.WriteLine(i);
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class InterfaceQuestion : IBoth
    {
        public void Display(IBoth a)
        {
            Console.WriteLine(a.MyProperty);  //we get error here.
        }

        public int MyProperty
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    public interface IGet
    {

        int MyProperty
        {
            get;

        }

    }

   public interface ISet
    {

        int MyProperty   //interface can not have definition.only declaration
        {
            set;
            
        }

    }

    public interface IBoth : IGet, ISet
    {
        new int MyProperty { get; set; }
    }
}


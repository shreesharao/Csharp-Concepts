using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceAndContravariance
{
    class Program
    {
        //covariance is supported in Delegates return type
        delegate GeneralEx1 Ex1Delegate();


        //Contravariance is supported in parameters. 
        delegate void Ex2Delegate(GeneralEx2 ex);

        static void Main(string[] args)
        {
            GeneralEx1 obg = new GeneralEx2(); //covariance
            // GeneralEx2 obj2 = new GeneralEx1();  //this is not possible

            //covariance is supported in arrays
            GeneralEx1[] array = new GeneralEx2[100];

            Ex1Delegate ex1Delegate = method;
            //....

            //Contravariance is supported in parameters. 
            Ex2Delegate ex2 = method2;

            //GeneralEx1 objEx1 = null;
            //method3(objEx1); //contravariance in normal method parameters not possible
            GeneralEx2 objEx2 = null;
            method4(objEx2);

            //covariance in Generics
            IEnumerable<object> GenericArray = new List<string>();
        }

        static GeneralEx2 method()
        {
            return new GeneralEx2();
        }

        static GeneralEx1 metho4()
        {
            return new GeneralEx2();
        }

        static void method2(GeneralEx1 ex1)
        {

        }

        static void method3(GeneralEx2 ex2)
        {

        }
        static void method4(IGeneralEx iex)
        {

        }
    }
}

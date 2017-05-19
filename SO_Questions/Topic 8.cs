using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    class Topic_8
    {
        public void Entry()
        {
            try
            {
                //int i3 = 2147483647 + 10; //this results in compile time error

                int eleven = 11;
                int i2 = 2147483647 + eleven;  //this will not throw exception though it exceeds integer limit.this results in -2147483638 

                checked  //when we keep the code inside checked block it throws overflow exception.
                {
                    int ten = 10;
                    int i1 = 2147483647 + ten;
                }

                unchecked //unchecked block prevents overflow checking
                {
                    int ten = 10;
                    int i1 = 2147483647 + ten;
                }

            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

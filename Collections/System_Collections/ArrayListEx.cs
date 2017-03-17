using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections
{
    class ArrayListEx
    {
        ArrayList objArrayList = new ArrayList();
        public void Entry()
        {
            Console.WriteLine(objArrayList.Capacity);
            objArrayList.Add(1);        //integer
            objArrayList.Add(1.12);     //double
            objArrayList.Add("string"); //string
            foreach (var item in objArrayList) //here if we use int or string instead of var we can get RunTime exception
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

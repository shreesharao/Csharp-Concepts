using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections.Generic
{
    class ListEx
    {
        List<char> objList = new List<char>();

        public void Entry()
        {
            objList.Add('s');
            objList.Add('s');
            objList.Add('r');

            Console.WriteLine(objList.Last());//returns last element
            Console.WriteLine(objList[1]); //indexing is possible
            foreach (var item in objList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

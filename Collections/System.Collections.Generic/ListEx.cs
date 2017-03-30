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
            foreach (var item in objList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

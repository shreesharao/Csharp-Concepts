using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.System.Collections
{
    class BitArrayEx
    {
        BitArray objBitArray = new BitArray(5,false);

        public void Entry()
        {
            objBitArray.Not();
            Console.WriteLine(objBitArray.Get(3));
        }
    }
}

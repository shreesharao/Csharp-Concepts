using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection
{
    public sealed class SampleClass : IDisposable
    {
        public void Dispose()
        {
            // get rid of managed resources, call Dispose on member variables...
        }
    }
}

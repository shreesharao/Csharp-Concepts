using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection
{
    public class BaseSampleClass : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // get rid of managed resources
            }
            // get rid of unmanaged resources
        }

        // only if you use unmanaged resources directly in BaseSampleClass
        //~BaseSampleClass()
        //{
        //    Dispose(false);
        //}
    }
}

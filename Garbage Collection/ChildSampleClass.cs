using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collection
{
    class ChildSampleClass : BaseSampleClass
    {
        private IntPtr m_Handle;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // get rid of managed resources
            }
            //ReleaseHandle(m_Handle);

            base.Dispose(disposing);
        }

        ~ChildSampleClass()
        {
            Dispose(false);
        }
    }
}

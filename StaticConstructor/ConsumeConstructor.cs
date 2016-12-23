using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class ConsumeConstructor
    {
        Program p;

        public void InstanceInitialize()
        {
            p = new Program();
        }

        public void StaticInitialize()
        {
            p = new Program();
        }

    }
}

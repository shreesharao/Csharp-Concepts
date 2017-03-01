using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class EventsEx
    {
        public static void Write()
        {
            Publisher.Assign();
            //  Publisher.WriteEvent +=null; this wont affect our event
            
            Publisher.OnWriteEvent();
        }
    }

}

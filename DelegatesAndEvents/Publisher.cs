using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Publisher
    {
        public delegate void WriteHandler();

        public static event WriteHandler _writeEvent;

        public static event WriteHandler WriteEvent
        {
            add { _writeEvent += value; }
            remove { _writeEvent -= value; }
        }


        public static void Assign()
        {
            WriteEvent += Subscriber.WriteInt;
            WriteEvent += Subscriber.WriteString;
        }

        public static void OnWriteEvent()
        {
            _writeEvent();
        }
    }
}

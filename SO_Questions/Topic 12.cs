using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    class Topic_12
    {
        //const TimeSpan cTime = new TimeSpan();   //The type 'System.TimeSpan' cannot be declared const

        readonly TimeSpan roTime = new TimeSpan();

        public Topic_12()
        {
            roTime = new TimeSpan(1000);
        }
        public void Entry()
        {
           
            //roTime = new TimeSpan(2000);  //A readonly field cannot be assigned to (except in a constructor or a variable initializer
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    class Topic_5
    {
        public void Entry()
        {
            Topic_4 obj = new Topic_4();
            Console.WriteLine(obj.GetType());
            Console.WriteLine(typeof(Topic_5));
        }
    }
}

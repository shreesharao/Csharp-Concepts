using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_store
{
    class Topic_4
    {
        int num = 0;

        public void Entry()
        {
            var type = num; //just to suppress warnings that 'num' is assigned but not used.not related to this topic
            string str = "test";
            string str1 = "test";
            string str3 = "test1".Substring(0, 4);
            object str4 = str3;

            Console.WriteLine(str == str1);
            Console.WriteLine(str.Equals(str1));

            Console.WriteLine(str == str3);
            Console.WriteLine(str.Equals(str3));

            Console.WriteLine(str == str4);
            Console.WriteLine(str.Equals(str4));

            Topic_4 obj = new Topic_4();
            obj.num = 15;

            Topic_4 obj1 = obj;
            obj1.num = 16;
            //Topic_4 obj1 = new Topic_4();
            //obj1.num = 15;  //belwo methods return false in this case as the reference is different

            Console.WriteLine(obj == obj1);
            Console.WriteLine(obj.Equals(obj1));
            Console.WriteLine(object.ReferenceEquals(obj, obj1));


        }
    }
}

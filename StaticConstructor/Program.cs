using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Program
    {
        int _x;
        static int _y;
        public Program()
        {
            _x = 0;
        }
        public Program(int pi)
        {

        }
        static Program()
        {
            _y = 0;
        }
        static void Main(string[] args)
        {
            ConsumeConstructor obj = new ConsumeConstructor();
            obj.InstanceInitialize();

            //Process p = Process.GetCurrentProcess();
            //Console.WriteLine(p.ProcessName);
            //Console.WriteLine(p.MachineName);
            //Console.WriteLine((p.PrivateMemorySize64/1024)/1024);
            //Console.Read();
        }
    }

}

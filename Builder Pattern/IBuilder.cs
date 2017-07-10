using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    interface IBuilder
    {
        void BuildPart1();
        void BuildPart2();
        void BuildPart3();
        Product GetProduct();
    }
}

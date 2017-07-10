using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    class Director
    {
        public void Construct(IBuilder IBuilder)
        {
            IBuilder.BuildPart1();
            IBuilder.BuildPart2();
            IBuilder.BuildPart3();
        }
    }
}

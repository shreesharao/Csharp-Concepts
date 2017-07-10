using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    class ConcreteBuilder:IBuilder
    {
        private Product _product = new Product();
        public void BuildPart1()
        {
            _product.Part1 = "Part1";
        }

        public void BuildPart2()
        {
            _product.Part2 = "Part2";
        }

        public void BuildPart3()
        {
            _product.Part3 = "Part3";
        }

        public Product GetProduct()
        {
            return _product;
        }
    }
}

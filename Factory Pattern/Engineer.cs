using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Pattern
{
    class Engineer:IProfessional
    {
        public string GetProfession()
        {
            return "Engineer";
        }
    }
}

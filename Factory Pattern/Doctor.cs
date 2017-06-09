using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Pattern
{
    class Doctor:IProfessional
    {
        public string GetProfession()
        {
            return "Doctor";
        }
    }
}

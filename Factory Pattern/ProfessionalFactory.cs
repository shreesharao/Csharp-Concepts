using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Pattern
{
    class ProfessionalFactory
    {
        /// <summary>
        /// Returns an instanse of the profession requested
        /// </summary>
        /// <param name="ProfessionalType"></param>
        /// <returns></returns>
        public static IProfessional GetProfessional(string ProfessionalType)
        {
            IProfessional professional = null;

            var professionalObject = Activator.CreateInstance(Type.GetType(ProfessionalType));
            professional = professionalObject as IProfessional;

            return professional;
        }
    }
}

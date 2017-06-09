using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whom do you want to hire? Doctor or Engineer");
            var option = Console.ReadLine();

            var type = GetProfessionalType(option);
            IProfessional professional = ProfessionalFactory.GetProfessional(type);

            Console.WriteLine("Whom did i hire? " + professional.GetProfession());

            Console.ReadLine();
        }

        private static string GetProfessionalType(string professionName)
        {
            var type = "";
            switch (professionName)
            {
                case "Doctor":
                    type = "Factory_Pattern.Doctor";
                    break;

                case "Engineer":
                    type = "Factory_Pattern.Engineer";
                    break;

                default:
                    type = "Factory_Pattern.Engineer";
                    break;
            }
            return type;
        }
    }
}

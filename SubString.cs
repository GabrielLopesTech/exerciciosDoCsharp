using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SubString
    {
        public static void Main(string[] args)
        {
            // Nome completo
            string name = "Gabriel Lopes dos Santos";

            // Location of the letter L
            int charPos = name.IndexOf("L");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);
        }
    }
}

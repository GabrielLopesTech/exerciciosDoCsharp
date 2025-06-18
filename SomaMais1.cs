using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SomaMais1
    {
        public static void Main(string[] args)
        {
            int i = 1;
            int numero = 0;
            while (i < 101)
            {
                numero += i;
                i++;
            }
            Console.WriteLine("O total da soma é:" + numero);
        }
    }
}

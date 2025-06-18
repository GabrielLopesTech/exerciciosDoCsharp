using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SomaDosNumerosParesAte500
    {
        public static void Main(string[] args)
        {
            int i = 1;
            int numero = 0;
            while (i < 501)
            {
                numero += i;
                i+= 2;
            }
            Console.WriteLine("O total da soma dos numeros pares é:" + numero);
        }
    }
}

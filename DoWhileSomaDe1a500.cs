using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class DoWhileSomaDe1a500
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somatório dos numeros pares de 1 até 500");
            int i = 1, totalSoma = 0;


            do
            {
                if (i % 2 == 0)
                {
                    totalSoma += i;
                }
                i++;
            }

            while (i <= 500);

            Console.WriteLine($"A soma total é:" + totalSoma);

        }
    }
}

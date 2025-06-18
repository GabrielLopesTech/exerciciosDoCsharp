using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class TreinoArrayCSharp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite ");
            int[] numero = { 0, 5, 10, 15, 20, 30 };
            int totalSoma = 0;

            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine($"Número: {numero[i]}");

                totalSoma += numero[i];
                
                Console.WriteLine($"Soma dos números: {totalSoma}");
            }

            
        }
    }
}

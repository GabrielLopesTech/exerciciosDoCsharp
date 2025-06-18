using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MethodComReturn
    {
        static int Somar(int x)
        {
            return x + 5;
        }

        public static void Main(string[] args)
        {
            int resultado = Somar(10);
            Console.WriteLine($"O resultado da soma é: {resultado}");
        }
    }
}

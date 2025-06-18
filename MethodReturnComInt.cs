using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MethodReturnComInt
    {
        static int Somar(int x, int y)
        {
            return x + y;
        }

        public static void Main(string[]args)
        {
            Somar(10, 20);
            int resultado = Somar(10, 20);
            Console.WriteLine(resultado);
        }
    }
}

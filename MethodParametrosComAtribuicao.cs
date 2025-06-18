using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MethodParametrosComAtribuicao
    {
        static int Somar(int x, int y = 5)
        {
            return x + y;
        }

        public static void Main(string[] args)
        {
            int resultado = Somar(10); // y recebe o valor padrão de 5
            Console.WriteLine(resultado);
        }
    }
}

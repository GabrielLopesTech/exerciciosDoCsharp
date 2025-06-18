using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Divisao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Divisão de valores!");

            Console.WriteLine("Digite o primeiro valor:");
            int numero = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int outroNumero = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("O resultado da divisão é: " + (numero / outroNumero));
        }
    }
}

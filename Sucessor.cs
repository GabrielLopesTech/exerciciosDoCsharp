using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Sucessor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este algoritmo irá indicar o sucessor de um número");

            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("O sucessor do seu número é: " + (numero + 1));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Antecessor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Este algoritmo irá indicar o antecessor de um número");

            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("O antecessor do seu número é: " + (numero - 1));
        }
    }
}

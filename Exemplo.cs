using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Exemplo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("IfElse");

            int idade;

            Console.WriteLine("Indique sua idade:");
            idade = Convert.ToInt16(Console.ReadLine());

            if (idade < 16)
            {
                Console.WriteLine("Você não pode votar");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Você tem a opção de votar!");
            }
            else 
            {
                Console.WriteLine("É obrigado a votar!");
            }
        }
    }
}

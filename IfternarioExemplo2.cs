using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class IfternarioExemplo2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplo If Ternario");
            Console.WriteLine("Verificar se a idade com If Ternario");
            int idade = Convert.ToInt16(Console.ReadLine());


            string verificar = (idade < 16) ? "Não pode votar." : (idade < 18) ? "Voto opcional" : "Voto obrigatorio";

            Console.WriteLine(verificar);
        }
    }
}

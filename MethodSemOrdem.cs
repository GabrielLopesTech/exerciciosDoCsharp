using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MethodSemOrdem
    {
        static void Crianca(string crianca1, string crianca2, string crianca3)
        {
            Console.WriteLine($"A criança mais jovem é {crianca2}");
        }

        public static void Main(string[] args)
        {
            // Chamada do método com os parâmetros na ordem correta
           
            // Chamada do método com os parâmetros fora de ordem
            Crianca(crianca3: "Maria", crianca1: "Ana", crianca2: "João");
        }
    }
}

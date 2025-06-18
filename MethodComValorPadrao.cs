using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MethodComValorPadrao
    {
        static void ExibirMensagem(string pais = "Brasil")
        {
            Console.WriteLine($"Eu sou do {pais}");
        }

        public static void Main(string[] args)
        {
            ExibirMensagem(); // Chamada sem argumento, usa o valor padrão "Brasil"
            ExibirMensagem("Argentina"); // Chamada com argumento, substitui o valor padrão
            ExibirMensagem("Alemanha"); // Chamada com outro argumento
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MethodsComDiversosParametros
    {
        static void ExibirMensagem(string nome,string sobrenome , int idade )
        {
            Console.WriteLine($"Meu nome é: {nome} Sobrenome: {sobrenome}, e tenho: {idade} anos de idade");
        }

        public static void Main(string[] args)
        {
            ExibirMensagem("Gabriel", "Santos", 18);
            ExibirMensagem("Mari", "Santos", 20);
            ExibirMensagem("Jailson", "Santos", 50);
            ExibirMensagem("Ana", "Santos", 22);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Exemplo02Method
    {
        static void Methods(string nome)
        {
            Console.WriteLine(nome + "Santos");
        }

        public static void Main(string[] args)
        {
            Methods("Gabriel ");
            Methods("Mari ");
            Methods("Jailson ");
            Methods("Ana ");
        }
    }
}

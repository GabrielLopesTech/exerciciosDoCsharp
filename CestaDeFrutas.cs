using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class CestaDeFrutas
    {
        public static void Main(string[] args)
        {
            Fruta frutas = new Fruta();
            Console.WriteLine(frutas.nome);
            Console.WriteLine(frutas.cor);
            Console.WriteLine(frutas.preco);
            Console.WriteLine(frutas.quantidade);


        }   
    }
}

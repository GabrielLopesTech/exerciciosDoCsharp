using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class TabuadaDeUmNumero
    {
        public static void Main(string[] args)
        {   int i = 0;
            Console.WriteLine("Digite um número para a tabuada desejada");
            int numero = Convert.ToInt32(Console.ReadLine());
            while (i < 11) 
            {
                Console.WriteLine((numero)+"x"+(i)+ "=" + (numero * i));
                i++;
            }
        }
    }
}

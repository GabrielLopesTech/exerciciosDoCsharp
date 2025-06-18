using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ArraySort
    {
        public static void Main(string[] args)
        {
            string[] carro = { "Volvo", "BMW", "Volkswagen", "Hyundai" };
            Array.Sort(carro);
            foreach(string marca in carro)
            {
                Console.WriteLine(marca);
            }

            
            Array.Sort(carro);
            Array.Reverse(carro);
            foreach (string marca in carro)
            {
                Console.WriteLine(marca);
            }
        }
    }
}

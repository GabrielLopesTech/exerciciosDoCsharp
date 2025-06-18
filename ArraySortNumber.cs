using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ArraySortNumber
    {
        public static void Main(string[] args)
        {
            int[] numero = { 5, 1, 8, 9 };
            Array.Sort(numero);
            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");

            Array.Sort(numero);
            Array.Reverse(numero);
            foreach (int i in numero)
            {
                Console.WriteLine(i);
            }
        }
    }
}

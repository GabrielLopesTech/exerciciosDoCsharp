using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SystemLinq
    {
        public static void Main(string[] args)
        {
            int[] numero = { 5, 1, 8, 9 };

            Console.WriteLine(numero.Max() + "\n");
            Console.WriteLine(numero.Min() + "\n");
            Console.WriteLine(numero.Sum() / numero.Length + "\n");
            Console.WriteLine(numero.Average() + "\n");
        }
    }
}

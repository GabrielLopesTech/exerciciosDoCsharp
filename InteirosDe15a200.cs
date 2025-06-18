using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class InteirosDe15a200
    {
        public static void Main(string[] args)
        {
            int i = 15;
            do
            {
                Console.WriteLine((i) +"=" +(Math.Pow(i, 2)));
                i++;
            }
            while (i < 201);
        }
    }
}

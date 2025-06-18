using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ForEach
    {
        public static void Main(string[] args)
        {
            int[,] number = { { 1, 4, 2 }, { 3, 6, 8 } };
            
            // Using foreach to iterate through the 2D array
            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
        }
    }
}

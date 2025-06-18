using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class DoWhileSomaPares
    {
        public static void Main(string[] args)
        {
            int i = 0;
            do
            {
                
                i+=2;
            }
            while (i < 501);
            Console.WriteLine("O resultado das somas é:"+i);
        }
    }
}

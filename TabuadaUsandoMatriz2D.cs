using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class TabuadaUsandoMatriz2D
    { 
       public static void Main(string[] args)
        {
            Console.WriteLine("Tabuada usando Matriz 2D\n\n");                
            int[,] tabuada = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    Console.Write($"{ tabuada[i, j] = (i + 1) * (j + 1),12}");
                }
            }
            //for (int tabu = 0; tabu < 10; tabu++)
            //{
            //    Console.Write($"Tabuada do {tabu + 1}: ");
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write($"{tabuada[tabu, j],4}");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}

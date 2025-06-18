using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class SobrecargaComVariaveis
    {
        static int MetodoSoma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        static float MetodoSoma(float numero1, float numero2)
        {
            return numero1 + numero2;
        } 
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            double numero3 = Convert.ToDouble(numero1);

            Console.WriteLine("Digite o segundo número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            double numero4 = Convert.ToDouble(numero2);

            Console.WriteLine($"Resultado da soma com inteiros: {MetodoSoma(numero1, numero2)}");
            Console.WriteLine($"Resultado da soma com flutuantes: {MetodoSoma((float)numero3, (float)numero4)}");
        }
    }
}

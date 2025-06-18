using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MethodDiferentesComMesmoResultado
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
            
            Console.WriteLine($"Resultado da soma com inteiros: {MetodoSoma(10, 20)}");
     
            Console.WriteLine($"Resultado da soma com flutuantes: {MetodoSoma(10.5f, 20.3f)}");
        }
    }
}

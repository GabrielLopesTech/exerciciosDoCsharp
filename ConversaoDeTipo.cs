using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ConversaoDeTipo
    {
        public static void Main(string[] args)
        {
            //// Conversão implícita
            //int numeroInteiro = 10;
            //double numeroDouble = numeroInteiro; // int para double
            // Conversão explícita
            //double numeroDecimal = 9.78;
            //int numeroConvertido = (int)numeroDecimal; // double para int
            // Exibindo os resultados
            //Console.WriteLine("Número inteiro: " + numeroInteiro);
            //Console.WriteLine("Número convertido para double: " + numeroDouble);
            //Console.WriteLine("Número decimal: " + numeroDecimal);
            //Console.WriteLine("Número convertido para int: " + numeroConvertido);

            int inteiro = 10;
            double real = 5.5;
            bool booleano = true;

            Console.WriteLine(Convert.ToString(inteiro)); // Converte int para string
            Console.WriteLine(Convert.ToDouble(inteiro)); // Converte int para double
            Console.WriteLine(Convert.ToInt32(real)); // Converte double para string
            Console.WriteLine(Convert.ToString(booleano)); // Converte bool para string
        }
    }
}

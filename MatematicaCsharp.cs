using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class MatematicaCsharp
    {
        public static void Main(string[] args)
        {
            //Math.Max mostra o maior valor que está entre dois valores digitados (x,y)
            Console.WriteLine(Math.Max(5,10));

            //Math.Min mostra o menor valor que está entre dois valores digitados (x,y)
            Console.WriteLine(Math.Min(5,10));

            //Math.Pow calcula a potenciação de um número (base, expoente)
            Console.WriteLine(Math.Pow(2,3)); // 2 elevado a 3

            //Math.Sqrt calcula a raiz quadrada de um número
            Console.WriteLine(Math.Sqrt(16)); // raiz quadrada de 16

            //Math.Abs retorna o valor absoluto de um número (sem sinal negativo)
            Console.WriteLine(Math.Abs(-10)); // retorna 10

            //Math.Round arredonda um número para o inteiro mais próximo
            Console.WriteLine(Math.Round(3.6)); // arredonda para 4

            Console.WriteLine(Math.Round(3.4)); // arredonda para 3

            //Math.Ceiling arredonda um número para cima, para o inteiro mais próximo
            Console.WriteLine(Math.Ceiling(3.2)); // arredonda para 4

            //Math.Floor arredonda um número para baixo, para o inteiro mais próximo
            Console.WriteLine(Math.Floor(3.8)); // arredonda para 3

            //Math.Sin calcula o seno de um ângulo em radianos
            Console.WriteLine(Math.Sin(Math.PI / 2)); // seno de 90 graus (PI/2 radianos)

            //Math.Cos calcula o cosseno de um ângulo em radianos
            Console.WriteLine(Math.Cos(0)); // cosseno de 0 graus (0 radianos)

            //Math.Tan calcula a tangente de um ângulo em radianos
            Console.WriteLine(Math.Tan(Math.PI / 4)); // tangente de 45 graus (PI/4 radianos)

            //Math.Log calcula o logaritmo natural de um número
            Console.WriteLine(Math.Log(Math.E)); // logaritmo natural de e (base e)

            //Math.Exp calcula a exponencial de um número (e elevado a um número)
            Console.WriteLine(Math.Exp(1)); // e elevado a 1 (aproximadamente 2.71828)
            Console.WriteLine(Math.Exp(2));
            // e elevado a 2 (aproximadamente 7.38906)

            //Math.PI retorna o valor de pi (aproximadamente 3.14159)
            Console.WriteLine(Math.PI); // valor de pi

            //Math.E retorna o valor de e (aproximadamente 2.71828)
            Console.WriteLine(Math.E); // valor de e
            Console.WriteLine(Math.E);

            //Math.Sign retorna o sinal de um número (-1 para negativo, 0 para zero, 1 para positivo)
            Console.WriteLine(Math.Sign(-5)); // retorna -1 (negativo)
            Console.WriteLine(Math.Sign(0)); // retorna 0 (zero)
            Console.WriteLine(Math.Sign(5)); // retorna 1 (positivo)

            //Math.Truncate remove a parte decimal de um número, retornando apenas a parte inteira
            Console.WriteLine(Math.Truncate(3.9)); // retorna 3
            Console.WriteLine(Math.Truncate(-3.9)); // retorna -3 (parte inteira negativa)

            Console.WriteLine(Math.Truncate(3.1)); // retorna 3
            Console.WriteLine(Math.Truncate(-3.1)); // retorna -3 (parte inteira negativa)

            //Math.Clamp limita um valor dentro de um intervalo especificado (valor, mínimo, máximo)

            Console.WriteLine(Math.Clamp(5, 1, 10)); // retorna 5 (dentro do intervalo)
            Console.WriteLine(Math.Clamp(0, 1, 10)); // retorna 1 (abaixo do mínimo)
            Console.WriteLine(Math.Clamp(15, 1, 10)); // retorna 10 (acima do máximo)
            Console.WriteLine(Math.Clamp(5, 5, 10)); // retorna 5 (igual ao mínimo)
            Console.WriteLine(Math.Clamp(10, 1, 10)); // retorna 10 (igual ao máximo)



        }
    }
}

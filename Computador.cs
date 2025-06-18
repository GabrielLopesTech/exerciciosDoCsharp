using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Computador
    {
        string ram = "16GB RAM";
        string monitor= "24 polegadas";
        string processador = "AMD Rayzen 5200";
        int hd = 512;
        int ssd = 256;
        int preco = 5000;

        public static void Main(string[] args)
        {
            Computador computador = new Computador();
            Console.WriteLine($"O computador tem: {computador.ram}");
            Console.WriteLine($"O computador tem: {computador.monitor}");
            Console.WriteLine($"O computador tem: {computador.processador}");
            Console.WriteLine($"O computador tem: {computador.hd}GB de HD");
            Console.WriteLine($"O computador tem: {computador.ssd}GB de SSD");
            Console.WriteLine($"O preço do computador é: R${computador.preco}");
        }
    }
}

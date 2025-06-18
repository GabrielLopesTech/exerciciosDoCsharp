using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Professor2
    { 
        string nacionalidade = "Brasileira";
        string nome = "Jailson Costa";
        string estado = "São Paulo";
        public static void Main(string[] args)
        {
            Professor2 professor = new Professor2();
            Console.WriteLine($"A nacionalidade do professor é: {professor.nacionalidade};\nO nome do professor é: {professor.nome};\nO estado do professor é: {professor.estado}");

           
            Professor2 professora = new Professor2();
            professora.nome = "Aurora Seles";
            Console.WriteLine($"A nacionalidade do professor é: {professora.nacionalidade};\nO nome do professor é: {professora.nome};\nO estado da professora é: {professora.estado}");
            
        }
    }
}

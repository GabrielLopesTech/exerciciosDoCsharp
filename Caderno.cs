using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class Caderno
    {
        string corCaderno = "azul";
        int paginas = 200;

        public void MensagemLivro()
        {
            Caderno caderno = new Caderno();

            Console.WriteLine($"Caderno de cor {caderno.corCaderno} e {caderno.paginas} páginas.");
        }
        public static void Main(string[] args)
        {
            Caderno cadernoLopes = new Caderno();
            cadernoLopes.MensagemLivro();
        }
    }
}

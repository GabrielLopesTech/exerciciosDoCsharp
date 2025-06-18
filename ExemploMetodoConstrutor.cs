using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExerciciosLogica
{
    internal class ExemploMetodoConstrutor
    {
        public string model;

        public ExemploMetodoConstrutor()
        {
            model = "Opala 6 CC";
        }

        public static void Main(string[] args)
        {
            ExemploMetodoConstrutor Ford = new ExemploMetodoConstrutor();
            Console.WriteLine(Ford.model);

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLogica
{
    internal class ExemploParametrosMetodoConstrutor
    {
        public string model;

        public ExemploParametrosMetodoConstrutor(string modelName)
        {
            model = modelName;
        }

        public static void Main(string[] args)
        {
            ExemploParametrosMetodoConstrutor Ford = new ExemploParametrosMetodoConstrutor("Mustang");
            Console.WriteLine(Ford.model);
        }
    }
}

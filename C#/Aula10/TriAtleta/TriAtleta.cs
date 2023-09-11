using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriAtleta
{
    internal class TriAtleta : Pessoa, ICiclista, ICorredor, INadador
    {
        public TriAtleta(string nome) : base(nome)
        {

        }

        public void Aquecer()
        {
            Console.WriteLine("Aquecendo...");
        }

        public void Correr()
        {
            Console.WriteLine("Correndo...");
        }

        public void Nadar()
        {
            Console.WriteLine("Nadando...");
        }

        public void Pedalar()
        {
            Console.WriteLine("Pedalando...");
        }
    }
}

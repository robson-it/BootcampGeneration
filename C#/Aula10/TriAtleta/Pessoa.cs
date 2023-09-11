using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriAtleta
{
    public abstract class Pessoa
    {
        string nome = string.Empty;

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public void setNome(string nome) {this.nome = nome; }
        public string getNome() { return this.nome;}
        public void Cansou()
        {
            Console.WriteLine("Cansou...");
        }

    }
}

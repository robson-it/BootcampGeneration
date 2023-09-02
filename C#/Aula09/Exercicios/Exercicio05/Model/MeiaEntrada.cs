using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05.Model
{
    internal class MeiaEntrada : Ingresso
    {
        bool estudante;

        public MeiaEntrada(int codigoIngresso, string atracao, int quantidadePorLote, int quantidadeDeLotes, string dataAtracao, decimal preco, bool estudante) 
            : base(codigoIngresso, atracao, quantidadePorLote, quantidadeDeLotes, dataAtracao, preco)
        {
            this.estudante = estudante;
        }

        public void setEstudante(bool estudante) { this.estudante = estudante; }
        public bool getEstudante() { return estudante; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"    Estudante?: {((getEstudante())?"Sim":"Não")}                                 ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
        }
    }
}

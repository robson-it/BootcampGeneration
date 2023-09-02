using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05.Model
{
    internal class Vip : Ingresso
    {
        bool openBar;

        public Vip(int codigoIngresso, string atracao, int quantidadePorLote, int quantidadeDeLotes, string dataAtracao, decimal preco, bool openBar)
            : base(codigoIngresso, atracao, quantidadePorLote, quantidadeDeLotes, dataAtracao, preco)
        {
            this.openBar = openBar;
        }

        public void setOpenBar(bool openBar) { this.openBar = openBar; }
        public bool getOpenBar() { return openBar; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"    OpenBar?: {((getOpenBar()) ? "Sim" : "Não")}                                 ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
        }
    }
}

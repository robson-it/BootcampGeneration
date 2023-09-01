using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Model
{
    internal class VideoGame : Produto
    {

        string fabricante;

        public VideoGame(int codigoProduto, string nomeProduto, int quantidadeEstoque, string categoria, int mesesGarantia, string fabricante)
            : base(codigoProduto, nomeProduto, quantidadeEstoque, categoria, mesesGarantia)
        {
            this.fabricante = fabricante;
        }

        public void setFabricante(string fabricante) { this.fabricante = fabricante; }
        public string getFabricante() { return fabricante; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"    Fabricante: {getFabricante()}                                                ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
        }

    }
}

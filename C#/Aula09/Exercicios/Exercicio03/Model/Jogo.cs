using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Model
{
    internal class Jogo : Produto
    {

        string produtora;

        public Jogo(int codigoProduto, string nomeProduto, int quantidadeEstoque, string categoria, int mesesGarantia, string produtora) 
            : base(codigoProduto, nomeProduto, quantidadeEstoque, categoria, mesesGarantia)
        {
            this.produtora = produtora;
        }

        public void setProdutora(string produtora) { this.produtora = produtora; }
        public string getProdutora() { return produtora; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"    Produtora: {getProdutora()}                                                  ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
        }
    }
}

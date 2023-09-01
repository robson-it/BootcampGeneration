using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.Model
{
    internal class Perfumaria : Farmacia
    {

        string aromaProduto;
        public Perfumaria(int codigoProduto, string nomeProduto, int quantidadeEstoque, bool generico, string validade, string aromaProduto) 
            : base(codigoProduto, nomeProduto, quantidadeEstoque, generico, validade)
        {
            this.aromaProduto = aromaProduto;
        }

        public void setAromaProduto(string aromaProduto) { this.aromaProduto = aromaProduto; }
        public string getAromaProduto() { return aromaProduto; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"    Aroma do produto: {getAromaProduto()}                                        ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
        }
    }
}

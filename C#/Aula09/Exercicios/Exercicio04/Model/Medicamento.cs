using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.Model
{
    internal class Medicamento : Farmacia
    {

        string tarjaColorida;

        public Medicamento(int codigoProduto, string nomeProduto, int quantidadeEstoque, bool generico, string validade, string tarjaColorida)
            : base(codigoProduto, nomeProduto, quantidadeEstoque, generico, validade)
        {
            this.tarjaColorida = tarjaColorida;
        }

        public void setTarjaColorida(string tarjaColorida) { this.tarjaColorida = tarjaColorida; }
        public string getTarjaColorida() { return tarjaColorida; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"    Cor da tarja: {getTarjaColorida()}                                           ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
        }

    }
}

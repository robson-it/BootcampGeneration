using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.Model
{
    public class Farmacia
    {

        private int codigoProduto;
        private string nomeProduto = string.Empty;
        private int quantidadeEstoque;
        private bool generico;
        private string validade;

        public Farmacia(int codigoProduto, string nomeProduto, int quantidadeEstoque, bool generico, string validade)
        {
            this.codigoProduto = codigoProduto;
            this.nomeProduto = nomeProduto;
            this.quantidadeEstoque = quantidadeEstoque;
            this.generico = generico;
            this.validade = validade;
        }


        public int getCodigoProduto() { return codigoProduto; }
        public string getNomeProduto() { return nomeProduto; }
        public int getQuantidadeEstoque() { return quantidadeEstoque; }
        public bool getGenerico() { return generico; }
        public string getValidade() { return validade; }

        public void setId(int codigoProduto) { this.codigoProduto = codigoProduto; }
        public void setNome(string nomeProduto) { this.nomeProduto = nomeProduto; }
        public void setQuantidadeEstoque(int quantidadeEstoque) { this.quantidadeEstoque = quantidadeEstoque; }
        public void setGenerico(bool generico) { this.generico = generico; }
        public void setValidade(string validade) { this.validade = validade; }

        public void Visualizar()
        {

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                ::Dados do produto::                              ");
            Console.WriteLine($"                                                                                 ");
            Console.WriteLine($"    Código do produto: {getCodigoProduto()}                                      ");
            Console.WriteLine($"    Nome do produto: {getNomeProduto()}                                          ");
            Console.WriteLine($"    Quantidade em estoque: {getQuantidadeEstoque()} itens                        ");
            Console.WriteLine( "    Este produto é um genérico?: " + ((getGenerico()) ? "Sim" : "Não")+"        ");
            Console.WriteLine($"    Validade: {getValidade()}                                                    ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();

        }

    }
}

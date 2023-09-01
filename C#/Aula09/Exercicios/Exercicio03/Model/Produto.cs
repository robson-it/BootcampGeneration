using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Model
{
    public class Produto
    {

        private int codigoProduto;
        private string nomeProduto = string.Empty;
        private int quantidadeEstoque;
        private string categoria = string.Empty;
        private int mesesGarantia;

        public Produto(int codigoProduto, string nomeProduto, int quantidadeEstoque, string categoria, int mesesGarantia)
        {
            this.codigoProduto = codigoProduto;
            this.nomeProduto = nomeProduto;
            this.quantidadeEstoque = quantidadeEstoque;
            this.categoria = categoria;
            this.mesesGarantia = mesesGarantia;
        }


        public int getCodigoProduto() { return codigoProduto; }
        public string getNomeProduto() { return nomeProduto; }
        public int getQuantidadeEstoque() { return quantidadeEstoque; }
        public string getCategoria() { return categoria; }
        public int getMesesGarantia() { return mesesGarantia; }

        public void setId(int codigoProduto) { this.codigoProduto = codigoProduto; }
        public void setNome(string nomeProduto) { this.nomeProduto = nomeProduto; }
        public void setQuantidadeEstoque(int quantidadeEstoque) { this.quantidadeEstoque = quantidadeEstoque; }
        public void setCategoria(string categoria) { this.categoria = categoria; }
        public void setMesesGarantia(int mesesGarantia) { this.mesesGarantia = mesesGarantia; }

        public virtual void Visualizar()
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
            Console.WriteLine($"    Categoria do produto: {getCategoria()}                                       ");
            Console.WriteLine($"    Garantia em meses: {getMesesGarantia()} meses                                ");
            

        }

    }
}

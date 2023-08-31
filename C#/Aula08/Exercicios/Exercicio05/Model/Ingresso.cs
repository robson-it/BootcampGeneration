using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05.Model
{
    public class Ingresso
    {

        private int codigoIngresso;
        private string atracao = string.Empty;
        private int quantidadePorLote;
        private int quantidadeDeLotes;
        private string dataAtracao;
        private decimal preco;

        public Ingresso(int codigoIngresso, string atracao, int quantidadePorLote, int quantidadeDeLotes, string dataAtracao, decimal preco)
        {
            this.codigoIngresso = codigoIngresso;
            this.atracao = atracao;
            this.quantidadePorLote = quantidadePorLote;
            this.quantidadeDeLotes = quantidadeDeLotes;
            this.dataAtracao = dataAtracao;
            this.preco = preco;
        }


        public int getCodigoIngresso() { return codigoIngresso; }
        public string getAtracao() { return atracao; }
        public int getQuantidadePorLote() { return quantidadePorLote; }
        public int getQuantidadeDeLotes() { return quantidadeDeLotes; }
        public string getDataAtracao() { return dataAtracao; }
        public decimal getPreco() { return preco; }

        public void setCodigoIngresso(int codigoIngresso) { this.codigoIngresso = codigoIngresso; }
        public void setAtracao(string atracao) { this.atracao = atracao; }
        public void setQuantidadePorLotes(int quantidadePorLote) { this.quantidadePorLote = quantidadePorLote; }
        public void setQuantidadeDeLotes(int quantidadeDeLotes) { this.quantidadeDeLotes = quantidadeDeLotes; }
        public void setDataAtracao(string dataAtracao) { this.dataAtracao = dataAtracao; }
        public void setPreco(decimal preco) { this.preco = preco; }

        public void Visualizar()
        {

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                ::Dados do produto::                              ");
            Console.WriteLine($"                                                                                 ");
            Console.WriteLine($"    Código do ingresso: {getCodigoIngresso()}                                    ");
            Console.WriteLine($"    Nome da atração: {getAtracao()} - Super Atração                              ");
            Console.WriteLine($"    Quantidade de ingressos por lote: {getQuantidadePorLote()} Ingressos         ");
            Console.WriteLine($"    Quantidade de lotes: {getQuantidadeDeLotes()} Lotes                          ");
            Console.WriteLine($"    Data da atração: {getDataAtracao()}                                          ");
            Console.WriteLine($"    Valor do ingresso (unitário): {getPreco().ToString("C")}                     ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();

        }

    }
}

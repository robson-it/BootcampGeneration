using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06.Model
{
    internal class Curso
    {

        private int codigoCurso;
        private string nomeCurso = string.Empty;
        private string instrutor;
        private string descricao;
        private List<string> modulos;
        private decimal preco;

        public Curso(int codigoIngresso, string nomeCurso, string instrutor, string descricao, List<string> modulos, decimal preco)
        {
            this.codigoCurso = codigoIngresso;
            this.nomeCurso = nomeCurso;
            this.instrutor = instrutor;
            this.descricao = descricao;
            this.modulos = modulos;
            this.preco = preco;
        }


        public int getCodigoCurso() { return codigoCurso; }
        public string getNomeCurso() { return nomeCurso; }
        public string getInstrutor() { return instrutor; }
        public string getDescricao() { return descricao; }
        public string getModulos() { return String.Join(',',modulos); }
        public decimal getPreco() { return preco; }

        public void setCodigoCurso(int codigoCurso) { this.codigoCurso = codigoCurso; }
        public void setNomeCurso(string nomeCurso) { this.nomeCurso = nomeCurso; }
        public void setInstrutor(string instrutor) { this.instrutor = instrutor; }
        public void setDescricao(string descricao) { this.descricao = descricao; }
        public void setModulos(List<string> modulos) { this.modulos = modulos; }
        public void setPreco(decimal preco) { this.preco = preco; }

        public void Visualizar()
        {

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                 ::Dados do Curso::                               ");
            Console.WriteLine($"                                                                                 ");
            Console.WriteLine($"    Código do curso: {getCodigoCurso()}                                          ");
            Console.WriteLine($"    Nome do curso: {getNomeCurso()}                                              ");
            Console.WriteLine($"    Ministrado por: {getInstrutor()}                                             ");
            Console.WriteLine($"    Descrição: {getDescricao()}                                                  ");
            Console.WriteLine($"    Módulos: {getModulos()}                                                      ");
            Console.WriteLine($"    Valor do curso: {getPreco().ToString("C")}                                   ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();

        }

    }
}

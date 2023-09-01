using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Model
{
    internal class Vendedor : Funcionario
    {
        private int porcentagemComissao;

        public Vendedor(int id, string nome, int idade, string departamento, string cargo, int porcentagemComissao) : base(id, nome, idade, departamento, cargo)
        {
            this.porcentagemComissao = porcentagemComissao;
        }

        public void setPorcentagemComissao(int porcentagemComissao) { this.porcentagemComissao = porcentagemComissao; }
        public int getPorcentagemComissao() { return porcentagemComissao; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"    Porcentagem de comissão: {getPorcentagemComissao()}%                         ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
            
        }
    }
}

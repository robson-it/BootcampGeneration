using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Model
{
    internal class Gerente : Funcionario
    {
        decimal bonificacaoMensal;

        public Gerente(int id, string nome, int idade, string departamento, string cargo, decimal bonificacaoMensal) : base(id, nome, idade, departamento, cargo)
        {
            this.bonificacaoMensal = bonificacaoMensal;
        }

        public void setBonificacaoMensal(int bonificacaoMensal) { this.bonificacaoMensal = bonificacaoMensal; }
        public decimal getBonificacaoMensal() { return bonificacaoMensal; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"    Bonificação mensal: {getBonificacaoMensal().ToString("C")}                   ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    public class PessoaFisica : Cliente
    {
        string cpf = string.Empty;
        public PessoaFisica(int id, string nome, int idade, string naturalidade, string cidadeEstadoAtual, string cpf) 
            : base(id, nome, idade, naturalidade, cidadeEstadoAtual)
        {
            this.cpf = cpf;
        }

        public string getCpf() { return cpf; }
        public void setCpf(string cpf) { this.cpf = cpf; }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"    Tipo de cliente: Pessoa Física                                               ");
            Console.WriteLine($"    CPF: {getCpf()}                                                              ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }


    }
}

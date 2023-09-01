using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    public class PessoaJuridica : Cliente
    {
        string cnpj = string.Empty;
        public PessoaJuridica(int id, string nome, int idade, string naturalidade, string cidadeEstadoAtual, string cnpj) 
            : base(id, nome, idade, naturalidade, cidadeEstadoAtual)
        {
            this.cnpj = cnpj;
        }


        public string getCnpj (){  return cnpj; }
        public void setCnpj (string cnpj){ this.cnpj = cnpj; }

        public override void Visualizar() {
            base.Visualizar();
            Console.WriteLine($"    Tipo de cliente: Pessoa Júridica                                             ");
            Console.WriteLine($"    CNPJ: {getCnpj()}                                                            ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
        }
    }
}

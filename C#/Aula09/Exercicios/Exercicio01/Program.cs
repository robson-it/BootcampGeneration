using Exercicio01.Model;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente01 = new Cliente (33, "Robson Alves Rocha", 29, "Viçosa - MG", "Suzano - SP");
            Cliente cliente02 = new Cliente(777, "Sophia Winston", 33, "Campos do Jordão - SP", "Florianópolis - SC");

            cliente01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            cliente02.Visualizar();
            Console.WriteLine("--------------------------------------HERANÇA-------------------------------------");


            PessoaFisica pessoaFisica01 = new PessoaFisica(33, "Robson Alves Rocha", 29, "Viçosa - MG", "Suzano - SP", "258.258.369-30");
            PessoaFisica pessoaFisica02 = new PessoaFisica(777, "Sophia Winston", 33, "Campos do Jordão - SP", "Florianópolis - SC", "951.753.258-97");

            PessoaJuridica pessoaJuridica01 = new PessoaJuridica(33, "Robson Alves Rocha", 29, "Viçosa - MG", "Suzano - SP", "42.513.740/0001-71");
            PessoaJuridica pessoaJuridica02 = new PessoaJuridica(777, "Sophia Winston", 33, "Campos do Jordão - SP", "Florianópolis - SC", "92.431.791/0001-22");

            pessoaFisica01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            pessoaFisica02.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            pessoaJuridica01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            pessoaJuridica02.Visualizar();


        }
    }
}
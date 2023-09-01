using Exercicio02.Model;
namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario01 = new Funcionario(33, "Robson Alves Rocha", 29, "Planejamento e Estratégia", "CEO");
            Funcionario funcionario02 = new Funcionario(777, "Sophia Winston", 33, "Tecnologia da Informação", "Desenvolvedora Dot.Net SR");

            Gerente gerente01 = new Gerente(11, "Robson Alves Rocha", 29, "Planejamento e Estratégia", "Gerente", 3000M);
            Gerente gerente02 = new Gerente(22, "Erivelton Martins Silva", 33, "Comercial - Vendas", "Gerente", 2000M);

            Vendedor vendedor01 = new Vendedor(44, "Sophia Winston", 22, "Comercial", "Vendedor", 10);
            Vendedor vendedor02 = new Vendedor(77, "Julia Winston", 44, "Pós-Vendas", "Vendedor", 15);


            funcionario01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            funcionario02.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            gerente01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            vendedor01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            gerente02.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            vendedor02.Visualizar();
        }
    }
}
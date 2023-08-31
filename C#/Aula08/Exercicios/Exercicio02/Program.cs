using Exercicio02.Model;
namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario01 = new Funcionario(33, "Robson Alves Rocha", 29, "Planejamento e Estratégia", "CEO");
            Funcionario funcionario02 = new Funcionario(777, "Sophia Winston", 33, "Tecnologia da Informação", "Desenvolvedora Dot.Net SR");

            funcionario01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            funcionario02.Visualizar();
        }
    }
}
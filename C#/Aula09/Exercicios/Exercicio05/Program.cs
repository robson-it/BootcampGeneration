using Exercicio05.Model;
namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingresso ingresso01 = new Ingresso(33, "Show Charlie Brown JR", 10000, 10, "02/02/2024", 150.00M);
            Ingresso ingresso02 = new Ingresso(77, "Show Bob Marley e The Wailers", 20000, 10, "11/11/2026", 200.00M);

            MeiaEntrada ingressoEstudante01 = new MeiaEntrada(33, "Show Charlie Brown JR", 10000, 10, "02/02/2024", 75.00M, true);
            MeiaEntrada ingressoEstudante02 = new MeiaEntrada(77, "Show Bob Marley e The Wailers", 20000, 10, "11/11/2026", 100.00M, true);

            Vip ingressoVip01 = new Vip(11, "Show Charlie Brown JR", 10000, 10, "02/02/2024", 350.00M, true);
            Vip ingressoVip02 = new Vip(22, "Show Bob Marley e The Wailers", 20000, 10, "11/11/2026", 300.00M, false);

            ingresso01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            ingresso02.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            ingressoEstudante01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            ingressoEstudante02.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            ingressoVip01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            ingressoVip02.Visualizar();
        }
    }
}
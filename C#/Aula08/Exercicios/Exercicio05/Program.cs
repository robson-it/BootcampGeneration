using Exercicio05.Model;
namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingresso ingresso01 = new Ingresso(33, "Show Charlie Brown JR", 10000, 10, "02/02/2024", 150.00M);
            Ingresso ingresso02 = new Ingresso(77, "Show Bob Marley e The Wailers", 20000, 10, "11/11/2026", 200.00M);

            ingresso01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            ingresso02.Visualizar();
        }
    }
}
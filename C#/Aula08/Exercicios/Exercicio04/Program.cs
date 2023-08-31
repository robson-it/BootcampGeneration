using Exercicio04.Model;
namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farmacia produto01 = new Farmacia(33, "Pomada modeladora para cabelos", 77, true, "02/02/2024");
            Farmacia produto02 = new Farmacia(77, "Protetor solar FPS30", 33, false, "11/11/2026");

            produto01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            produto02.Visualizar();
        }
    }
    
}
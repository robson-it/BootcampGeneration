using Exercicio03.Model;
namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto01 = new Produto(33, "Joystick Dualshock 4", 77, "Acessórios", 3);
            Produto produto02 = new Produto(77, "X-BOX SERIES X", 33, "Consoles", 12);

            produto01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            produto02.Visualizar();
        }
    }
}
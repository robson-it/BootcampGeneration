using Exercicio03.Model;
namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto01 = new Produto(33, "Joystick Dualshock 4", 77, "Acessórios", 3);
            Produto produto02 = new Produto(77, "X-BOX SERIES X", 33, "Consoles", 12);

            Jogo jogo01 = new Jogo(33, "It Takes Two", 33, "Games", 3, "Hazelight Studios");
            Jogo jogo02 = new Jogo(22, "Need For Speed", 77, "Games", 3, "EA Games");

            VideoGame videoGame01 = new VideoGame(77, "X-BOX SERIES X", 77, "Consoles", 12, "Microsoft");
            VideoGame videoGame02 = new VideoGame(11, "PlayStation 5", 33, "Consoles", 12, "Sony");

            produto01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            produto02.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            jogo01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            jogo02.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            videoGame01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            videoGame02.Visualizar();
        }
    }
}
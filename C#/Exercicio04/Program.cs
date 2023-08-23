using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, numero3, numero4, diferenca;

            Console.WriteLine("Digite o numero1: ");
            numero1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o numero2: ");
            numero2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o numero3: ");
            numero3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o numero4: ");
            numero4 = Convert.ToSingle(Console.ReadLine());

            diferenca = (numero1 * numero2) - (numero3 * numero4);

            Console.WriteLine($"Média final: {diferenca}");
        }
    }
}
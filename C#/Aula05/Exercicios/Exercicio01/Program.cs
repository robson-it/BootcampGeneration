using System.Collections.Immutable;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerosNaoOrdenados = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int numeroProcurado, posicaoElementoProcurado;

            Console.WriteLine("Digite o número que você deseja encontrar: ");
            numeroProcurado = Convert.ToInt32(Console.ReadLine());

            Array.Sort(numerosNaoOrdenados);

            posicaoElementoProcurado = Array.BinarySearch(numerosNaoOrdenados, numeroProcurado);

            Console.WriteLine((posicaoElementoProcurado>=0) ? $"O número {numeroProcurado} está localizado na posição: {posicaoElementoProcurado}" : $"O número {numeroProcurado} não foi encontrado!");
        }
    }
}
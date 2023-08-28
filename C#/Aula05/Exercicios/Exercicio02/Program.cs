namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerosInteiros = new int[10];
            float media, somaElementosVetor = 0;

            Console.WriteLine("Digite 10 números inteiros, sendo um por vez: ");

            for (int indice = 0; indice < 10; indice ++)
            {
                numerosInteiros[indice] = Convert.ToInt32(Console.ReadLine());
                somaElementosVetor += numerosInteiros[indice];
            }

            Console.WriteLine("\nElementos nos índices ímpares: ");
            for (int indice = 0; indice < 10; indice++)
            {
                if (indice == 1 || indice % 2 != 0) {
                    Console.Write(numerosInteiros[indice] + " ");
                }
            }

            Console.WriteLine("\n\nElementos pares: ");
            for (int indice = 0; indice < 10; indice++)
            {
                if (numerosInteiros[indice] % 2 == 0)
                {
                    Console.Write(numerosInteiros[indice]+" ");
                }
            }

            Console.WriteLine($"\n\nSoma: {somaElementosVetor}");

            media = somaElementosVetor / numerosInteiros.Length;

            Console.WriteLine("\nMédia: {0:F2}", media);
        }
    }
}
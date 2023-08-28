namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizNumerosInteiros = new int[3, 3];
            int somaElementosDiagPrincipal = 0, somaElementosDiagSecundaria = 0;

            Console.WriteLine("Digite 9 números inteiros, sendo um por vez: ");

            for (int indiceLinha = 0; indiceLinha < 3; indiceLinha++) { 
                for (int indiceColuna = 0; indiceColuna < 3 ; indiceColuna++) {
                    matrizNumerosInteiros[indiceLinha, indiceColuna] = Convert.ToInt32(Console.ReadLine()); 
                }
            }


            Console.WriteLine("\nElementos da diagonal principal: ");
            for (int indiceLinha = 0; indiceLinha < 3; indiceLinha++)
            {
                Console.Write($"{matrizNumerosInteiros[indiceLinha, indiceLinha]} ");
                somaElementosDiagPrincipal += matrizNumerosInteiros[indiceLinha, indiceLinha];
            }

            Console.WriteLine("\n\nElementos da diagonal secundaria: ");
            for (int indiceLinha = 0; indiceLinha < 3 ; indiceLinha++)
            {
                Console.Write($"{matrizNumerosInteiros[indiceLinha, matrizNumerosInteiros.GetLength(1)] -1 - indiceLinha} ");
                somaElementosDiagSecundaria += matrizNumerosInteiros[indiceLinha, matrizNumerosInteiros.GetLength(1)] - 1 - indiceLinha];
                
            }

            Console.WriteLine($"\n\nSoma dos Elementos da Diagonal Principal: {somaElementosDiagPrincipal}\n");

            Console.WriteLine($"Soma dos Elementos da Diagonal Secundária: {somaElementosDiagSecundaria}\n");

        }
    }
}
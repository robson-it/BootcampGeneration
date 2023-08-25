namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDigitado, somaNumerosPositivos = 0;

            do
            {
                Console.WriteLine("Digite um número: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
                somaNumerosPositivos += (numeroDigitado > 0) ? numeroDigitado : 0;
            } while (numeroDigitado != 0);

            Console.WriteLine($"A soma dos números positivos é: {somaNumerosPositivos}");
        }
    }
}
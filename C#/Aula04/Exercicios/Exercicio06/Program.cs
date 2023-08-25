namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numeroDigitado, mediaNumerosDigitados = 0;
            int contador = 0;

            do
            {
                Console.WriteLine("Digite um número: ");
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
                if (numeroDigitado % 3 == 0 && numeroDigitado != 0)
                {
                    mediaNumerosDigitados += numeroDigitado;
                    contador++;
                }
            } while (numeroDigitado != 0);

            mediaNumerosDigitados = mediaNumerosDigitados / contador;
            Console.WriteLine($"A media de todos os números múltiplos de 3 é: {mediaNumerosDigitados.ToString("F2")}");
        }
    }
}
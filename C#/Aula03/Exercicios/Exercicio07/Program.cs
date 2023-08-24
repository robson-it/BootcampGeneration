namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero01, numero02, operacaoMatematica;

            Console.WriteLine("Digite o 1° número: ");
            numero01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 2° número: ");
            numero02 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operação: ");
            operacaoMatematica = Convert.ToInt32(Console.ReadLine());

            switch (operacaoMatematica)
            {
                case 1:
                    Console.WriteLine("{0:F} + {1:F} = {2:F}", numero01, numero02, numero01 + numero02);
                    break;
                case 2:
                    Console.WriteLine("{0:F} - {1:F} = {2:F}", numero01, numero02, numero01 - numero02);
                    break;
                case 3:
                    Console.WriteLine("{0:F} * {1:F} = {2:F}", numero01, numero02, numero01 * numero02);
                    break;
                case 4:
                    Console.WriteLine((numero02!= 0) ? $"{numero01.ToString("F1")} / {numero02.ToString("F1")} = {(numero01 / numero02).ToString("F1")}" : "Divisão por 0 (Zero) não existe!");
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }
        }
    }
}
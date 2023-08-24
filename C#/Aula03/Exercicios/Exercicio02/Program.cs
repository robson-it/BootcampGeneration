namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero != 0)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine((numero < 0) ? $"O Número {numero} é par e negativo!" : $"O Número {numero} é par e positivo!");
                }
                else
                {
                    Console.WriteLine((numero < 0) ? $"O Número {numero} é ímpar e negativo!" : $"O Número {numero} é Ímpar e positivo!");
                }
            }
            else {
                Console.WriteLine($"O número {numero} é par e neutro!");
            }
        }
    }
}
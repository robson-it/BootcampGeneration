namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1A, numero2B, numero3C;

            Console.WriteLine("Digite o primeiro número A: ");
            numero1A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número B: ");
            numero2B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número C: ");
            numero3C = Convert.ToInt32(Console.ReadLine());

            if((numero1A + numero2B) > numero3C)
            {
                Console.WriteLine($"{numero1A} + {numero2B} = {numero1A + numero2B} > {numero3C}");
                Console.WriteLine("A Soma de A + B é Maior do que C");
            }
            else if ((numero1A + numero2B) < numero3C)
            {
                Console.WriteLine($"{numero1A} + {numero2B} = {numero1A + numero2B} < {numero3C}");
                Console.WriteLine("A Soma de A + B é Menor do que C");
            }
            else
            {
                Console.WriteLine($"{numero1A} + {numero2B} = {numero1A + numero2B} = {numero3C}");
                Console.WriteLine("A Soma de A + B é Igual do que C");
            }
        }
    }
}
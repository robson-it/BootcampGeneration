namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero01, numero02;

            Console.WriteLine("Digite o primeiro número: ");
            numero01 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero02 = Convert.ToInt32(Console.ReadLine());

            if (numero01 < numero02) { 
                for(int contador = numero01; contador<=numero02; contador++)
                {
                    if(contador%3 == 0 && contador%5 == 0)
                    {
                        Console.WriteLine($"{contador} é múltiplo de 3 e 5");
                    }
                }
            }
            else
            {
                Console.WriteLine("Intervalo inválido!");
            }
        }
    }
}
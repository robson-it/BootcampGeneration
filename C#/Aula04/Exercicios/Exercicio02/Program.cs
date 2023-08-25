namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEntrada, numerosPares = 0, numerosImpares = 0;

            for (int contador = 0; contador < 10; contador++) {
                Console.WriteLine($"Digite o {contador + 1}° número: ");
                numeroEntrada = Convert.ToInt32(Console.ReadLine());
                if (numeroEntrada % 2 == 0) {
                    numerosPares += 1;
                }
                else
                {
                    numerosImpares += 1;
                }
            }

            Console.WriteLine($"Total de números pares: {numerosPares}\n");
            Console.WriteLine($"Total de números ímpares: {numerosImpares}");

        }

        
    }
}
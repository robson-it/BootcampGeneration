using System.Dynamic;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, contador;

            Console.WriteLine("Digite o número da tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (contador = 1; contador <= 10; contador++) { 
                Console.WriteLine($"{numero} * {contador} = {numero * contador}");
            }

            contador = 1;

            while (contador <= 10) {
                Console.WriteLine($"{numero} * {contador} = {numero * contador}");
                contador++;
            }

            contador = 1;

            do
            {
                Console.WriteLine($"{numero} * {contador} = {numero * contador}");
                contador++;
            } while (contador <= 10);
        }
    }
}
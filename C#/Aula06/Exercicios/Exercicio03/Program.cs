namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hashDeNumerosInteiros = new HashSet<int>();

            Console.WriteLine("Digite 10 números inteiros, sendo 1 por vez: ");

            for (int indice = 0; indice < 10; indice ++) 
            {
                hashDeNumerosInteiros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Listar dados do HashSet: ");
            foreach (var numero in hashDeNumerosInteiros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
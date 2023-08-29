namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hashDeNumerosInteiros = new HashSet<int> { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int numeroBuscado;
            bool numeroEncontrado = false;

            Console.WriteLine("Digite o número que você deseja encontrar: ");
            numeroBuscado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((hashDeNumerosInteiros.Contains(numeroBuscado)) ? $"O número {numeroBuscado} foi encontrado!" : $"O número {numeroBuscado} não foi encontrado!");

            

            foreach (var numero in hashDeNumerosInteiros)
            {
                if(numero == numeroBuscado)
                {
                    numeroEncontrado = true;
                }
            }

            Console.WriteLine((numeroEncontrado)?$"O número {numeroBuscado} foi encontrado!" : $"O número {numeroBuscado} não foi encontrado!");
            

        }
    }
}
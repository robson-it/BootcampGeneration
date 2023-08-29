namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaDeCores = new List<string>();

            Console.WriteLine("Digite o nome de 5 cores, sendo uma por vez: ");
            for(int indice = 0; indice < 5; indice++)
            {
                listaDeCores.Add(Console.ReadLine());
            }

            Console.WriteLine("Listar todas as cores: ");
            foreach (var cor in listaDeCores) {
                Console.WriteLine(cor);
            }

            listaDeCores.Sort();

            Console.WriteLine("Cores ordenadas: ");
            foreach (var cor in listaDeCores)
            {
                Console.WriteLine(cor);
            }

        }
    }
}
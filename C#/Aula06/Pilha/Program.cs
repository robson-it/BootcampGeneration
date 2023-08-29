namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilhaNomes = new Stack<string>();

            pilhaNomes.Push("Breno");
            pilhaNomes.Push("Eduardo");
            pilhaNomes.Push("Julia");
            pilhaNomes.Push("Leonardo Machado");
            pilhaNomes.Push("Gaspar");

            pilhaNomes.Pop();

            foreach (var nome in pilhaNomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nQuem é o primeiro da Pilha?");
            Console.WriteLine(pilhaNomes.Peek());

            Console.WriteLine("\nO Gaspar entrou na Pilha?");
            Console.WriteLine(pilhaNomes.Contains("Gaspar"));

            Console.WriteLine("\nQuantas pessoas há na Pilha?");
            Console.WriteLine(pilhaNomes.Count());
        }
    }
}
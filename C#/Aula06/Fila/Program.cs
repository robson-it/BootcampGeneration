namespace Fila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaNomes = new Queue<string>();

            filaNomes.Enqueue("Breno");
            filaNomes.Enqueue("Eduardo");
            filaNomes.Enqueue("Julia");
            filaNomes.Enqueue("Leonardo Machado");
            filaNomes.Enqueue("Gaspar");

            filaNomes.Dequeue();
            
            foreach(var nome in filaNomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nQuem é o primeiro da fila?");
            Console.WriteLine(filaNomes.Peek());

            Console.WriteLine("\nO Gaspar entrou na fila?");
            Console.WriteLine(filaNomes.Contains("Gaspar"));

            Console.WriteLine("\nQuantas pessoas há na fila?");
            Console.WriteLine(filaNomes.Count());

        }
    }
}
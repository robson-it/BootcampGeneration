namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            foreach (double nota in notas) {
                Console.WriteLine("{0:F1}",nota);
            }

            Console.WriteLine("\nPosição da nota 4.0: ");
            Console.WriteLine(notas.IndexOf(4.0));

            Console.WriteLine("\nA nota 4.0 existe? ");
            Console.WriteLine(notas.Contains(4.0));

            notas.Remove(10.0);

            foreach (double nota in notas)
            {
                Console.WriteLine("\n{0:F1}", nota);
            }

            Console.WriteLine("\nPosição da nota 10.0: ");
            Console.WriteLine(notas.IndexOf(10.0));

            Console.WriteLine("\nTamanho da lista: ");
            Console.WriteLine(notas.Count);

            notas.Sort();

            Console.WriteLine("\nLista ordenada: ");
            foreach (double nota in notas)
            {
                Console.WriteLine("\n{0:F1}", nota);
            };

            notas.Reverse();
            Console.WriteLine("\nLista ordenada decrescente: ");
            foreach (double nota in notas)
            {
                Console.WriteLine("\n{0:F1}", nota);
            };

            for(int indice = 0; indice < notas.Count; indice++)
            {
                Console.WriteLine("\n" + notas[indice]);
            }

            notas.Add(7.0);
            notas.Add(7.0);
            notas.Add(7.0);

            foreach (var nota in notas)
            {
                Console.WriteLine("\n{0:F1}", notas.IndexOf(nota));
            };
        }
    }
}
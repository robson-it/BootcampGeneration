namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNomes = new HashSet<string>() {"Robson", "Allan", "João", "Ingrid", "Shomara", "Robson", "Allan" };

            foreach(var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            setNomes.Add("Samantha");
            setNomes.Add("Samantha");
            setNomes.Add("Samantha");
            setNomes.Add(null);
            setNomes.Add("Júlia");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }


            Console.WriteLine("O nome Júlia existe?");
            Console.WriteLine(setNomes.Contains("Júlia"));

            setNomes.Remove("João");

            Console.WriteLine("O nome João existe?");
            Console.WriteLine(setNomes.Contains("João"));

            List<string> hashList = setNomes.ToList();

        }
    }
}
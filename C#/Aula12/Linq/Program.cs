namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> nomes = new List<string>() {"Robson",
                                                     "Robson",
                                                     "João", 
                                                     "Breno",
                                                     "Breno",
                                                     "Júlia", 
                                                     "Samantha", 
                                                     "Vitor", 
                                                     "Victor", 
                                                     "Mateus", 
                                                     "Matheus" };

            var numerosAoCubo = numeros.Select(numero => Math.Pow(numero, 3));

            Console.WriteLine("Números elevados ao cubo: " + string.Join(", ", numerosAoCubo));

            numerosAoCubo.ToList().ForEach(numero => Console.WriteLine(numero));

            var numerosImpares = from numero in numeros
                                 where numero % 2 != 0
                                 orderby numero descending
                                 select (numero);

            Console.WriteLine("Números ímpares: " + string.Join(", ", numerosImpares));

            numerosImpares.ToList().ForEach(numero => Console.WriteLine(numero));

            var nomesIniciamComMV = from nome in nomes
                                    where nome.StartsWith("V") || nome.StartsWith("M")
                                    select (nome);

            Console.WriteLine("Nomes que iniciam com M ou V: " + string.Join(", ", nomesIniciamComMV));

            nomesIniciamComMV.ToList().ForEach(nome => Console.WriteLine(nome));

            var nomesContemC = from nome in nomes
                                    where nome.ToUpper().Contains("C")
                                    select (nome);

            Console.WriteLine("Nomes que contém a letra C: " + string.Join(", ", nomesContemC));

            nomesContemC.ToList().ForEach(nome => Console.WriteLine(nome));


            var nomesDistintos = (from nome in nomes
                               .Distinct()
                               select (nome)).ToList();

            Console.WriteLine("Nomes distintos: " + string.Join(", ", nomesDistintos));
            nomesDistintos.ForEach(nome => Console.WriteLine(nome));


            var contarRobsons = nomes.Count(nome => nome.Contains("Robson"));

            Console.WriteLine("Quantos vezes o nome Robson aparece na lista? " + string.Join(", ", contarRobsons));


            var primeiroRobson = nomes.First(nome => nome.Contains("Robson"));

            Console.WriteLine("Primeiro robson da lista: " + string.Join(", ", primeiroRobson));

        }
    }
}
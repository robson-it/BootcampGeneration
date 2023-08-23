namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, nota4, media;

            Console.WriteLine("Digite a nota1: ");
            nota1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a nota2: ");
            nota2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a nota3: ");
            nota3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a nota4: ");
            nota4 = Convert.ToSingle(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine($"Média final: {Math.Round(media,1)}");
        }
    }
}
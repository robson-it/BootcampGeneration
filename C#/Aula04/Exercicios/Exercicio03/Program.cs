namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, menorQueVinteUm = 0, maiorQueCinquenta = 0;

            while (idade >= 0) {
                Console.WriteLine("Digite um idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade < 21) {
                    menorQueVinteUm++;
                }else if (idade > 50)
                {
                    maiorQueCinquenta++;
                } 
            }

            Console.WriteLine($"Total de pessoas menores de 21 anos: {menorQueVinteUm}\n");
            Console.WriteLine($"Total de pessoas maiores de 50 anos: {maiorQueCinquenta}");
        }
    }
}
namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int idade;
            bool primeiraDoacao;
            bool apto;

            Console.WriteLine("Digite o Nome do doador: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do doador: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Primeira doação de sangue? ");
            primeiraDoacao = Convert.ToBoolean(Console.ReadLine());

            apto = (idade > 18 && idade < 70) ? true : false;
            if (idade > 59 && idade < 70 && primeiraDoacao) { 
                apto = false;
            }
            Console.WriteLine((apto) ? $"{nome} está apto para doar sangue!" : $"{nome} não está apto para doar sangue!");

        }
    }
}
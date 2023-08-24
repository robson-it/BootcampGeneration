namespace PlanoDeSaude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int idade;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome}! Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 0 && idade <= 10)
            {
                Console.WriteLine("A mensalidade do plano de saúde é R$ 100,00");
            }
            else if (idade >= 11 && idade <= 29)
            {
                Console.WriteLine("A mensalidade do plano de saúde é: R$ 200,00");
            }
            else if (idade >= 30 && idade <= 45)
            {
                Console.WriteLine("A mensalidade do plano de saúde é: R$ 300,00");
            }
            else if (idade >= 46 && idade <= 59)
            {
                Console.WriteLine("A mensalidade do plano de saúde é: R$ 500,00");
            }
            else if (idade >= 60 && idade <= 65)
            {
                Console.WriteLine("A mensalidade do plano de saúde é: R$ 600,00");
            }
            else if (idade > 65) {
                Console.WriteLine("A mensalidade do plano de saúde é: R$ 1000,00");
            }



        }
    }
}
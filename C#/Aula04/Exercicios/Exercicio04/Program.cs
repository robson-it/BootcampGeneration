namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  idade, idadeAcumulada = 0, identidadeGenero, pessoaDesenvolvedora, contador = 0, 
                devsBackEnd =0, devsMCisTransFront =0, devsHCisTransMobile = 0, devsNBFullStack = 0;

            string condicao = "S";

            Console.WriteLine("Deseja responder a pesquisa? (S/N)");
            condicao = Console.ReadLine().ToUpper();

            while (condicao.Equals("S"))
            {
                Console.WriteLine("Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Identidade de gênero: ");
                identidadeGenero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pessoa desenvolvedora: ");
                pessoaDesenvolvedora = Convert.ToInt32(Console.ReadLine());

                idadeAcumulada += idade;
                contador += 1;

                if(pessoaDesenvolvedora == 1)
                {
                    devsBackEnd += 1;
                }

                if((identidadeGenero == 1 || identidadeGenero == 4) && pessoaDesenvolvedora == 2)
                {
                    devsMCisTransFront += 1;
                }

                if ((identidadeGenero == 2 || identidadeGenero == 5) && pessoaDesenvolvedora == 3 && idade > 40)
                {
                    devsHCisTransMobile += 1;
                }

                if(identidadeGenero == 3 && pessoaDesenvolvedora == 4 && idade < 30)
                {
                    devsNBFullStack += 1;
                }

                Console.WriteLine("Deseja responder a pesquisa novamente? (S/N)");
                condicao = Console.ReadLine().ToUpper();

            }

            Console.WriteLine($"Total de pessoas desenvolvedoras backend: {devsBackEnd}");
            Console.WriteLine($"Total de mulher cis e trans desenvolvedoras frontend: {devsMCisTransFront}");
            Console.WriteLine($"Total de homens cis e trans desenvolvedores mobile maiores de 40 anos: {devsHCisTransMobile}");
            Console.WriteLine($"Total de pessoas não binárias desenvolvedoras fullstack menores de 30 anos {devsNBFullStack}");
            Console.WriteLine($"O número total de pessoas que responderam a pesquisa: {contador}");
            Console.WriteLine($"A média de idade das pessoas que responderam a pesquisa é: {(idadeAcumulada / contador).ToString("F2")}");

        }
    }
}
namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> livros = new Stack<string>();
            int opcao;

            do
            {
                Console.WriteLine("" +
                   "\n\n**************************************************************************\n\n" +
                   "1 - Adicionar um novo livro na pilha\n" +
                   "2 - Listar todos os livros da Pilha\n" +
                   "3 - Retirar um livro da pilha\n" +
                   "0 - Sair" +
                   "\n\n**************************************************************************");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do livro: ");
                        livros.Push(Console.ReadLine());
                        if (livros.Count > 0)
                        {
                            Console.WriteLine("\nPilha: \n");
                            foreach (var livro in livros)
                            {
                                Console.WriteLine(livro);
                            }
                        }
                        Console.WriteLine("\nLivro adicionado!");
                        break;
                    case 2:
                        if (livros.Count > 0)
                        {
                            Console.WriteLine("Lista de livros na pilha: ");
                            foreach (var livro in livros)
                            {
                                Console.WriteLine(livro);
                            }
                        }
                        else
                        {
                            Console.WriteLine("A pilha está vazia!");
                        }
                        break;
                    case 3:
                        if (livros.Count > 0)
                        {
                            livros.Pop();
                            if (livros.Count > 0)
                            {
                                Console.WriteLine("\nPilha: \n");
                                foreach (var livro in livros)
                                {
                                    Console.WriteLine(livro);
                                }
                            }
                            Console.WriteLine("\nUm livro foi retirado da pilha!");
                        }
                        else
                        {
                            Console.WriteLine("\nA pilha está vazia!");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Programa finalizado!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
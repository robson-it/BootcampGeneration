namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoProduto, quantidadeComprada;

            Console.WriteLine("Código do produto: ");
            codigoProduto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade: ");
            quantidadeComprada = Convert.ToInt32(Console.ReadLine());

            switch(codigoProduto)
            {
                case 1:
                    Console.WriteLine("Produto: Cachorro Quente");
                    Console.WriteLine("Valor Total: R$ {0:F2}", quantidadeComprada * 10);
                    break;
                case 2:
                    Console.WriteLine("Produto: X -- Salada");
                    Console.WriteLine("Valor Total: R$ {0:F2}", quantidadeComprada * 15);
                    break;
                case 3:
                    Console.WriteLine("Produto: X -- Bacon");
                    Console.WriteLine("Valor Total: R$ {0:F2}", quantidadeComprada * 18);
                    break;
                case 4:
                    Console.WriteLine("Produto: Bauru");
                    Console.WriteLine("Valor Total: R$ {0:F2}", quantidadeComprada * 12);
                    break;
                case 5:
                    Console.WriteLine("Produto: Refrigerante");
                    Console.WriteLine("Valor Total: R$ {0:F2}", quantidadeComprada * 8);
                    break;
                case 6:
                    Console.WriteLine("Produto: Suco de laranja");
                    Console.WriteLine("Valor Total: R$ {0:F2}", quantidadeComprada * 13);
                    break;
                default:
                    Console.WriteLine("Código do produto inválido");
                    break;
            }          

        }
    }
}
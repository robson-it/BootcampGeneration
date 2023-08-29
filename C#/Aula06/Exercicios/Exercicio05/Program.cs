using System.Data;
using System.Net.Http.Json;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clientes = new Queue<string>();
            int opcao;
            
            do
            {
                Console.WriteLine("" +
                   "\n\n**************************************************************************\n\n"+
                   "1 - Adicionar cliente na fila\n"+
                   "2 - Listar todos os clientes\n" +
                   "3 - Retirar cliente da fila\n" +
                   "0 - Sair" +
                   "\n\n**************************************************************************");
                opcao = Convert.ToInt32(Console.ReadLine());
               
                Console.Clear();

                switch(opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do cliente: ");
                        clientes.Enqueue(Console.ReadLine());
                        if (clientes.Count > 0)
                        {
                            Console.WriteLine("\nFila: \n");
                            foreach (var cliente in clientes)
                            {
                                Console.WriteLine(cliente);
                            }
                        }
                        Console.WriteLine("\nCliente adicionado!");
                        break;
                    case 2:
                        if(clientes.Count > 0)
                        {
                            Console.WriteLine("Lista de clientes na fila: ");
                            foreach(var cliente in clientes)
                            {
                                Console.WriteLine(cliente);
                            }
                        }
                        else
                        {
                            Console.WriteLine("A fila está vazia!");
                        }
                        break;
                    case 3:
                        if (clientes.Count > 0)
                        {
                            clientes.Dequeue();
                            if (clientes.Count > 0)
                            {
                                Console.WriteLine("\nFila: \n");
                                foreach (var cliente in clientes)
                                {
                                    Console.WriteLine(cliente);
                                }
                            }
                            Console.WriteLine("\nO cliente foi chamado!");
                        }
                        else
                        {
                            Console.WriteLine("\nA fila está vazia!");
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
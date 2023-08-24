namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? caracteristica;

            Console.WriteLine("O ser vivo escolhido é vertebrado ou invertebrado? : ");
            caracteristica = Console.ReadLine();

            if (Equals("vertebrado", caracteristica.ToLower()))
            {
                Console.WriteLine("O ser vivo escolhido é uma ave ou mamífero? : ");
                caracteristica = Console.ReadLine();
                if (Equals("ave", caracteristica.ToLower()))
                {
                    Console.WriteLine("O ser vivo escolhido é carnívoro ou onívoro? : ");
                    caracteristica = Console.ReadLine();

                    if (Equals("carnívoro", caracteristica.ToLower()))
                    {
                        Console.WriteLine("Águia");
                    }
                    else if (Equals("onívoro", caracteristica.ToLower()))
                    {
                        Console.WriteLine("Pomba");
                    }
                }
                else if (Equals("mamífero", caracteristica.ToLower()))
                {
                    Console.WriteLine("O ser vivo escolhido é onívoro ou herbívoro? : ");
                    caracteristica = Console.ReadLine();

                    if (Equals("onívoro", caracteristica.ToLower()))
                    {
                        Console.WriteLine("Homem");
                    }
                    else if (Equals("herbívoro", caracteristica.ToLower()))
                    {
                        Console.WriteLine("Vaca");
                    }

                }

            }
            else if (Equals("invertebrado", caracteristica.ToLower()))
            {
                Console.WriteLine("O ser vivo escolhido é um inseto ou um anelídeo? : ");
                caracteristica = Console.ReadLine();
                if (Equals("inseto", caracteristica.ToLower()))
                {
                    Console.WriteLine("O ser vivo escolhido é um hematófago ou um herbívoro? : ");
                    caracteristica = Console.ReadLine();

                    if (Equals("hematófago", caracteristica.ToLower()))
                    {
                        Console.WriteLine("Pulga");
                    }
                    else if (Equals("herbívoro", caracteristica.ToLower()))
                    {
                        Console.WriteLine("Lagarta");
                    }
                }
                else if (Equals("anelídeo", caracteristica.ToLower()))
                {
                    Console.WriteLine("O ser vivo escolhido é um hematófago ou um onívoro? : ");
                    caracteristica = Console.ReadLine();

                    if (Equals("hematófago", caracteristica.ToLower()))
                    {
                        Console.WriteLine("Sanguessuga");
                    }
                    else if (Equals("onívoro", caracteristica.ToLower()))
                    {
                        Console.WriteLine("Minhoca");
                    }

                }


            }
        }
    }
}
namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaDeNumerosInteiros = new List<int> {2,5,1,3,4,9,7,8,10,6};
            int numeroBuscado, indice = 0;
            bool indiceLocalizado = false;

            Console.WriteLine("Digite o número que você deseja encontrar: ");
            numeroBuscado = Convert.ToInt32(Console.ReadLine());

            listaDeNumerosInteiros.Sort();

            if (listaDeNumerosInteiros.IndexOf(numeroBuscado) >= 0) {
                Console.WriteLine($"O número {numeroBuscado} está localizado na posição: {listaDeNumerosInteiros.IndexOf(numeroBuscado)}");
            }
            else
            {
                Console.WriteLine($"O número {numeroBuscado} não foi encontrado!");
            };

            for (int indiceFor = 0; indiceFor < listaDeNumerosInteiros.Count; indiceFor++ )
            {
                if (listaDeNumerosInteiros[indiceFor] == numeroBuscado)
                {
                    indiceLocalizado = true;
                    indice = indiceFor;
                    break;
                }
  
            }

            if (indiceLocalizado)
            {
                Console.WriteLine($"O número {numeroBuscado} está localizado na posição: {indice}");
            }
            else 
            {
                Console.WriteLine($"O número {numeroBuscado} não foi encontrado!");
            }

        }
    }
}
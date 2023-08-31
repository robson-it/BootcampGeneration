using Exercicio01.Model;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente01 = new Cliente (33, "Robson Alves Rocha", 29, "Viçosa - MG", "Suzano - SP");
            Cliente cliente02 = new Cliente(777, "Sophia Winston", 33, "Campos do Jordão - SP", "Florianópolis - SC");

            cliente01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            cliente02.Visualizar();
        }
    }
}
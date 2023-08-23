using System.Globalization;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto, adicionalNoturno, horasExtras, descontos, salarioLiquido;

            Console.WriteLine("Digite o valor do salário bruto: ");
            salarioBruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor do adicional noturno: ");
            adicionalNoturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor das horas extras: ");
            horasExtras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor dos descontos: ");
            descontos = Convert.ToSingle(Console.ReadLine());

            salarioLiquido = salarioBruto + adicionalNoturno + (horasExtras *5) - descontos;

            Console.WriteLine("Novo Salário: {0:F2}", salarioLiquido);
        }
    }
}
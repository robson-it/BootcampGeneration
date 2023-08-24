namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operacaoBancaria;
            float saldoDaConta = 1000F, valorEntrada;

            Console.WriteLine("Digite o código da operação: ");
            operacaoBancaria = Convert.ToInt32(Console.ReadLine());
                       
            switch (operacaoBancaria)
            {
                case 1:
                    Console.WriteLine(" Operação - Saldo \n\n Saldo: R$ {0:F2}", saldoDaConta);
                    break;
                case 2:
                    Console.WriteLine("Digite o valor que deseja sacar: ");
                    valorEntrada = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine((saldoDaConta >= valorEntrada) ? $" Operação - Saque \n\n Novo Saldo: R$ {(saldoDaConta- valorEntrada).ToString("F2")}":"Saldo Insuficiente!");
                    break;
                case 3:
                    Console.WriteLine("Digite o valor que deseja depositar: ");
                    valorEntrada = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine($" Operação - Depósito \n\n Novo Saldo: R$ {(saldoDaConta + valorEntrada).ToString("F2")}");
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }
        }
    }
}
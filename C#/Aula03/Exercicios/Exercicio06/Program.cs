namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nomeColaborador;
            int codigoCargo;
            float salario;

            Console.WriteLine("Nome do colaborador: ");
            nomeColaborador = Console.ReadLine();

            Console.WriteLine("Cargo: ");
            codigoCargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (codigoCargo)
            {
                case 1:
                    Console.WriteLine($"Nome do colaborador: {nomeColaborador} \n Cargo: Gerente \n Salário: {salario + (salario * 0.1F)}");
                    break;
                case 2:
                    Console.WriteLine($"Nome do colaborador: {nomeColaborador} \n Cargo: Vendedor \n Salário: {salario + (salario * 0.07F)}");
                    break;
                case 3:
                    Console.WriteLine($"Nome do colaborador: {nomeColaborador} \n Cargo: Supervisor \n Salário: {salario + (salario * 0.09F)}");
                    break;
                case 4:
                    Console.WriteLine($"Nome do colaborador: {nomeColaborador} \n Cargo: Motorista \n Salário: {salario + (salario * 0.06F)}");
                    break;
                case 5:
                    Console.WriteLine($"Nome do colaborador: {nomeColaborador} \n Cargo: Estoquista \n Salário: {salario + (salario * 0.05F)}");
                    break;
                case 6:
                    Console.WriteLine($"Nome do colaborador: {nomeColaborador} \n Cargo: Técnico de TI \n Salário: {salario + (salario * 0.08F)}");
                    break;
                default:
                    Console.WriteLine("Código do cargo inválido");
                    break;
            }

        }
    }
    
}
namespace RH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            float salario, reajuste;
            int cargo;

            Console.WriteLine("Digite o nome do funcionário: ");
            nome = Console.ReadLine();
            Console.WriteLine($"Digite o código do cargo do funcionário {nome}: ");
            cargo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Digite o seu salário do funcionário {nome}: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo) {
                case 1:
                    reajuste = (salario * 7) / 100;
                    break;

                case 2:
                    reajuste = (salario * 9) / 100;
                    break;

                case 3:
                    reajuste = (salario * 5) / 100;
                    break;

                default:
                    reajuste = (salario * 12) / 100;
                    break;
            }

            Console.WriteLine($"O salário reajustado é R$ {salario + reajuste}");
        
        }
    }
}
namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*********************************************************
             * Robson Alves Rocha - Bootcamp Generation (Aula 02 C#) *
             ********************************************************/

            //Declara duas variáveis do tipo float
            float numero1, numero2;

            //Escreve a mensagem na tela
            Console.WriteLine("Digite o primeiro número: ");
            //Realiza a leitura do primeiro número convertendo de string para float
            numero1 = Convert.ToSingle(Console.ReadLine());

            //Escreve a mensagem na tela
            Console.WriteLine("Digite o segundo número: ");
            //Realiza a leitura do segundo número convertendo de string para float
            numero2 = Convert.ToSingle(Console.ReadLine());

            //Exibe a soma das variáveis numero1 e numero2
            Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));

            //Exibe a subtração das variáveis numero1 e numero2
            Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));

            //Exibe a múltiplicação das variáveis numero1 e numero2
            Console.WriteLine($"{numero1} * {numero2} = " + (numero1 * numero2));

            //Exibe a divisão das variáveis numero1 e numero2
            Console.WriteLine($"{numero1} / {numero2} = " + (numero1 / numero2).ToString("F2"));

            //Exibe a exponenciação das variáveis numero1 e numero2
            Console.WriteLine($"{numero1} ^ {numero2} = " + Math.Pow(numero1, numero2));

            //Exibe a raiz quadrada da variável numero1
            Console.WriteLine($"A raiz quadrada de {numero1} é: " + Math.Sqrt(numero1));
        }
    }
}
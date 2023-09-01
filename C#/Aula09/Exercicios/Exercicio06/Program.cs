using Exercicio06.Model;
namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso curso01 = new Curso(
                                        33, 
                                        "C#", 
                                        "Rafael Queiroz", 
                                        "Curso introdutório de C#", 
                                        "Lógica de Programação, POO, Estrutura de Dados".Split(',').ToList(),
                                        200.00M
                                    );

            Curso curso02 = new Curso(
                                        77,
                                        "SQL",
                                        "Jacque Hernandes",
                                        "Introdução ao SQL com SqlServer 2019",
                                        "DDL, DML, DQL, DCL".Split(',').ToList(),
                                        200.00M
                                    );

            curso01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            curso02.Visualizar();
 
        }
    }
}
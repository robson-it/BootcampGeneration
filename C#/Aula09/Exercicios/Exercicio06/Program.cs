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

            CursoLivre cursoLivre01 = new CursoLivre(
                                        33,
                                        "C#",
                                        "Rafael Queiroz",
                                        "Curso introdutório de C#",
                                        "Lógica de Programação, POO, Estrutura de Dados".Split(',').ToList(),
                                        200.00M,
                                        true
                                    );

            CursoLivre cursoLivre02 = new CursoLivre(
                                        77,
                                        "SQL",
                                        "Jacque Hernandes",
                                        "Introdução ao SQL com SqlServer 2019",
                                        "DDL, DML, DQL, DCL".Split(',').ToList(),
                                        200.00M,
                                        false
                                    );

            Especializacao especializacao01 = new Especializacao(
                                        33,
                                        "C#",
                                        "Rafael Queiroz",
                                        "Engenharia de Software",
                                        "Lógica de Programação, POO, Estrutura de Dados".Split(',').ToList(),
                                        20000.00M,
                                        "Rafael Queiroz"
                                    );

            Especializacao especializacao02 = new Especializacao(
                                        77,
                                        "SQL",
                                        "Jacque Hernandes",
                                        "Engenharia e Administração de Banco de Dados",
                                        "DDL, DML, DQL, DCL".Split(',').ToList(),
                                        25000.00M,
                                        "Jacque Hernandes"
                                    );

            curso01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            curso02.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            cursoLivre01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            cursoLivre02.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            especializacao01.Visualizar();
            Console.WriteLine("----------------------------------------------------------------------------------");
            especializacao02.Visualizar();

        }
    }
}
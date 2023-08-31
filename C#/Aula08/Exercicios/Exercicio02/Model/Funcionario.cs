using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Model
{
    public class Funcionario
    {

        private int id;
        private string nome = string.Empty;
        private int idade;
        private string departamento = string.Empty;
        private string cargo = string.Empty;

        public Funcionario(int id, string nome, int idade, string departamento, string cargo)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.departamento = departamento;
            this.cargo = cargo;
        }


        public int getId() { return id; }
        public string getNome() { return nome; }
        public int getIdade() { return idade; }
        public string getDepartamento() { return departamento; }
        public string getCargo() { return cargo; }

        public void setId(int id) { this.id = id; }
        public void setNome(string nome) { this.nome = nome; }
        public void setIdade(int idade) { this.idade = idade; }
        public void setDepartamento(string naturalidade) { this.departamento = naturalidade; }
        public void setCargo(string cidadeEstadoAtual) { this.cargo = cidadeEstadoAtual; }

        public void Visualizar()
        {

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                ::Dados do colaborador::                          ");
            Console.WriteLine($"                                                                                 ");
            Console.WriteLine($"    Identificador: {getId()}                                                     ");
            Console.WriteLine($"    Nome do colaborador: {getNome()}                                             ");
            Console.WriteLine($"    Idade: {getIdade()}                                                          ");
            Console.WriteLine($"    Departamento: {getDepartamento()}                                            ");
            Console.WriteLine($"    Cargo exercido: {getCargo()}                                                 ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Model
{
    public class Cliente
    {
        private int id;
        private string nome = string.Empty;
        private int idade;
        private string naturalidade = string.Empty;
        private string cidadeEstadoAtual = string.Empty;

        public Cliente(int id, string nome, int idade, string naturalidade, string cidadeEstadoAtual)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.naturalidade = naturalidade;
            this.cidadeEstadoAtual = cidadeEstadoAtual;
        }


        public int getId() { return id; }   
        public string getNome() {  return nome; }
        public int getIdade() { return idade;} 
        public string getNaturalidade() {  return naturalidade;}
        public string getCidadeEstadoAtual() { return cidadeEstadoAtual; }

        public void setId(int id) { this.id = id; }
        public void setNome(string nome) { this.nome = nome; }
        public void setIdade(int idade) { this.idade = idade; }
        public void setNaturalidade(string naturalidade) { this.naturalidade = naturalidade; }
        public void setCidadeEstadoAtual(string cidadeEstadoAtual) { this.cidadeEstadoAtual = cidadeEstadoAtual; }

        public virtual void Visualizar() {

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                ::Dados do cliente::                              ");
            Console.WriteLine($"                                                                                 ");
            Console.WriteLine($"    Identificador: {getId()}                                                     ");
            Console.WriteLine($"    Nome do cliente: {getNome()}                                                 ");
            Console.WriteLine($"    Idade: {getIdade()}                                                          ");
            Console.WriteLine($"    Naturalidade: {getNaturalidade()}                                            ");
            Console.WriteLine($"    Cidade/Estado atual: {getCidadeEstadoAtual()}                                ");
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06.Model
{
    internal class Especializacao : Curso
    {
        string coordenadorCurso;

        public Especializacao(int codigoIngresso, string nomeCurso, string instrutor, string descricao, List<string> modulos, decimal preco, string coordenadorCurso) 
            : base(codigoIngresso, nomeCurso, instrutor, descricao, modulos, preco)
        {
            this.coordenadorCurso = coordenadorCurso;
        }

        public void setCoordenadorCurso(string coordenadorCurso) { this.coordenadorCurso = coordenadorCurso; }
        public string getCoordenadorCurso() { return this.coordenadorCurso; }

        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine($"    Coordenador do curso: {getCoordenadorCurso()}                                ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06.Model
{
    internal class CursoLivre : Curso
    {
        bool acessoVitalicio;

        public CursoLivre(int codigoIngresso, string nomeCurso, string instrutor, string descricao, List<string> modulos, decimal preco, bool acessoVitalicio)
            : base(codigoIngresso, nomeCurso, instrutor, descricao, modulos, preco)
        {
            this.acessoVitalicio = acessoVitalicio;
        }

        public void setAcessoVitalicio(bool acessoVitalicio) { this.acessoVitalicio = acessoVitalicio; }
        public bool getAcessoVitalicio() { return this.acessoVitalicio; }

        public override void Visualizar()
        {

            base.Visualizar();
            Console.WriteLine($"    Acesso vitalício?: {((getAcessoVitalicio())? "Sim" : "Não")}                 ");
            Console.WriteLine("                                                                                  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("                                                                                  ");
            Console.ResetColor();


        }

    }
}

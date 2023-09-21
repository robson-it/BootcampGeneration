using Microsoft.AspNetCore.Mvc;

namespace Exercicio01.Controllers
{
    [Route("~/")]
    [ApiController]
    public class Exercicio01Controller
    {

        [HttpGet]
        public string HelloWorld()
        {
            string helloWorld = """
                **********************************************************************
                -----------------------------Hello World------------------------------
                **********************************************************************
                """;
            return helloWorld;
        }

        [HttpGet("/bsm")]
        public string Bsms()
        {

            string bsms = """
                **********************************************************************
                --------------------------------Bsm's---------------------------------
                -Orientação ao detalhe
                -Orientação ao futuro
                -Mentalidade de crescimento
                -Comunicação
                -Persistência
                -Responsabilidade pessoal
                -Proatividade
                -Trabalho em equipe
                ----------------------------------------------------------------------
                **********************************************************************
                """;
            return bsms;
        }

        [HttpGet("/objetivos")]
        public string Objetivos()
        {

            string objetivos = """
                **********************************************************************
                ------------------------------Objetivos------------------------------
                -Aprender sobre Sql
                -Aprender sobre Asp Net com o modelo MVC
                -Desenvolver Soft Skill durante os trabalhos em grupo
                ---------------------------------------------------------------------
                **********************************************************************
                """;
            return objetivos;
        }

    }
}

using AplicativoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicativoWeb.Controllers;


public class CursoController:Controller{
    public IActionResult Index(){
        Curso c1 = new Curso();
        c1.Descricao = "Primeiros passos no ASP NET Core";
        c1.TituloInterno = "Desenvolvedor C#";
        c1.TituloMarketing = "Crie aplicativos multiplataformas";

        ViewData["desc"] = c1.Descricao;
        ViewData["TitInt"] = c1.TituloInterno;
        ViewData["TitMark"] = c1.TituloMarketing;
        return View();
    }

}
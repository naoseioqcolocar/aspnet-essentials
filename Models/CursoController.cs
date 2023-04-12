using AplicativoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicativoWeb.Controllers;


public class CursoController:Controller{
    public IActionResult Index(){
        Curso c1 = new Curso();
        c1.Descricao = "Primeiros passos no ASP NET Core";
        c1.TituloInterno = "Desenvolvedor C#";
        c1.TituloMarketing = "Crie aplicativos multiplataformas";

        int c;
        for(c=0; c<10; c++){
            c=(c+1)/2;
        }
        ViewData["valorc"] = c;

        ViewData["desc"] = c1.Descricao;
        ViewData["TitInt"] = c1.TituloInterno;
        ViewData["TitMark"] = c1.TituloMarketing;
        return View();
    }

}
using AplicativoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicativoWeb.Controllers;


public class CursoController:Controller{
    public IActionResult Index(){
        Curso c1 = new Curso();
        c1.Descricao = "Primeiros passos no ASP NET Core";
        c1.TituloInterno = "Desenvolvedor C#";
        c1.TituloMarketing = "Crie aplicativos multiplataformas";

        ViewData["curso"]=c1;
        return View();
    }

    public IActionResult Create(){
        ViewData ["titulo"] = "Cadastro de Cursos";
        ViewBag.DataHora = DateTime.Now;
        return View();
    }

}
using Microsoft.AspNetCore.Mvc;

namespace GerenciaTarefa.Controllers;

public class TarefaController:Controller{
    public IActionResult Index(){
        ViewData["Cabecalho"] = "Tarefa Diária"; //Primeiro o apelido e depois a descrição
        ViewData["Titulo"] = "Planejar Aula Senai";
        ViewData["Descricao"] = "Criar nova PEUC";
        return View();
    }    

}
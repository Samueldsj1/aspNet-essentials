using Microsoft.AspNetCore.Mvc;

namespace gerenciaTarefas.Controllers;

public class TarefaController:Controller{
    public IActionResult Index(){
        ViewData["Cabecalho"] = "Tarefa Diaria";
        ViewData["Titulo"] = "Planejar Aula";
        ViewData["Descricao"] = "Criar nova PEUC";
        return View ();
    }

}
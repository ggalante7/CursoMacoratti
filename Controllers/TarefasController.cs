using Microsoft.AspNetCore.Mvc;
using Tarefas.Services;
using System;

namespace Tarefas.Controllers
{
    public class TarefasController : Controller
    {
        ITarefaItemService _tarefaService;
        public TarefasController(ITarefaItemService tarefaService)
            {
                _tarefaService = tarefaService;
            }
        //Lista de tarefas
        public IActionResult Index()
        { 
            //Obter itens da tarefa
            var tarefas = _tarefaService.GetItemAsync();

            return View(tarefas);
        }
    }
}
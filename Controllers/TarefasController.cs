using Microsoft.AspNetCore.Mvc;
using Tarefas.Services;
using System;
using System.Threading.Tasks;
using Tarefas.Models;

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
        public async Task<IActionResult> Index()
        { 
            //Obter itens da tarefa
            var tarefas = await _tarefaService.GetItemAsync();
            
            var model = new TarefaViewModel();
            {
                model.TarefaItens = tarefas;
            }
            return View(model);
        }
    }
}
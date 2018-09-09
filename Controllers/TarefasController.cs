using Microsoft.AspNetCore.Mvc;

namespace Tarefas
{
    public class TarefasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
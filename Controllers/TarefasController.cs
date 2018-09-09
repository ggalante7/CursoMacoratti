using Microsoft.AspNetCore.Mvc;

namespace Tarefas.Controllers
{
    public class TarefasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
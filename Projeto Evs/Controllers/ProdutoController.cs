using Microsoft.AspNetCore.Mvc;

namespace Projeto_Evs.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

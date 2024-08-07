using Microsoft.AspNetCore.Mvc;

namespace primeiroprojetoMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

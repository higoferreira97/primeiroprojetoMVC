using Microsoft.AspNetCore.Mvc;
using primeiroprojetoMVC.Data.Repositorio;
using primeiroprojetoMVC.Data.Repositorio.Interfaces;

namespace primeiroprojetoMVC.Controllers
{
    public class AlunoController : Controller
        
    {
        private readonly IAlunoRepositorio _alunorepositorio;

        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunorepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            var aluno = _alunorepositorio.BuscarAluno();
            return View(aluno);
        }
    }

   
}

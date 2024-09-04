using Microsoft.AspNetCore.Mvc;
using primeiroprojetoMVC.Data.Repositorio;
using primeiroprojetoMVC.Data.Repositorio.Interfaces;
using primeiroprojetoMVC.Models;

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

        public IActionResult AdicionarAluno() 
        {
            return View();
        }

        public IActionResult InserirAluno(Aluno aluno)
        {
            try
            {
                _alunorepositorio.InserirAluno(aluno);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }

    }

   
}

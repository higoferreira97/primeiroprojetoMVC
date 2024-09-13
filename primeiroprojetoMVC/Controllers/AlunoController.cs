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

        public IActionResult Editar(int id)
        {
            var aluno = _alunorepositorio.BuscarId(id);
            return View(aluno);
        }

        public IActionResult EditarAluno(Aluno aluno) 
        {
            _alunorepositorio.EditarAluno(aluno);
            return RedirectToAction("Index");
        }
        
       

        public IActionResult ApagarAluno(Aluno aluno) 
        {
            _alunorepositorio.ApagarAluno(aluno);
            return RedirectToAction("Index");
        }

    }






    
   
}

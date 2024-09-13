﻿using Microsoft.AspNetCore.Mvc;
using primeiroprojetoMVC.Data.Repositorio;
using primeiroprojetoMVC.Data.Repositorio.Interfaces;
using primeiroprojetoMVC.Models;

namespace primeiroprojetoMVC.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorRepositorio _professorrepositorio;

        public ProfessorController(IProfessorRepositorio professorrepositorio)
        {
            _professorrepositorio = professorrepositorio;

        }
        public IActionResult Index()
        {
            var professor = _professorrepositorio.BuscarProfessor();
            return View(professor);
        }

        public IActionResult AdicionarProfessor()
        {
            return View();
        }

        public IActionResult InserirProfessor(Professor professor)
        {
            try
            {
                _professorrepositorio.InserirProfessor(professor);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var professor = _professorrepositorio.BuscarIdProfessor(id);
            return View(professor);
        }

        public IActionResult EditarProfessor(Professor professor)
        {
            _professorrepositorio.EditarProfessor(professor);
            return RedirectToAction("Index");
        }

        public IActionResult ApagarProfessor(Professor professor)
        {

            _professorrepositorio.ApagarProfessor(professor);
            return RedirectToAction("Index");
        }
    }
        
}

using primeiroprojetoMVC.Models;

namespace primeiroprojetoMVC.Data.Repositorio.Interfaces
{
    public interface IProfessorRepositorio
    {

        List<Professor> BuscarProfessor();

        void InserirProfessor(Professor professor);

        Professor BuscarIdProfessor(int id);

        void EditarProfessor(Professor professor);

        void ApagarProfessor(Professor professor);
    }
}

using primeiroprojetoMVC.Models;

namespace primeiroprojetoMVC.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        //string? BuscarAluno();
        List<Aluno> BuscarAluno();
        //string? BuscarAlunos();
    }
}

//Usei no senac
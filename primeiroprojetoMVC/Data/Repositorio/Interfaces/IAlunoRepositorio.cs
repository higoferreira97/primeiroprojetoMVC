using primeiroprojetoMVC.Models;

namespace primeiroprojetoMVC.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        
        List<Aluno> BuscarAluno();

        void InserirAluno(Aluno aluno);


    }
}

//Usei no senac


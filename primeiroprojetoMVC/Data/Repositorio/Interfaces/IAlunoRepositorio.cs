using primeiroprojetoMVC.Models;

namespace primeiroprojetoMVC.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio
    {
        
        List<Aluno> BuscarAluno();

        void InserirAluno(Aluno aluno);

        Aluno BuscarId(int id);

        void EditarAluno(Aluno aluno);


        void ApagarAluno(Aluno aluno);





    }
}

//Usei no senac


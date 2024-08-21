using primeiroprojetoMVC.Data.Repositorio.Interfaces;
using primeiroprojetoMVC.Models;

namespace primeiroprojetoMVC.Data.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public AlunoRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Aluno> BuscarAluno()
        {
            return _bancoContexto.Aluno.ToList();
        }
    }
}

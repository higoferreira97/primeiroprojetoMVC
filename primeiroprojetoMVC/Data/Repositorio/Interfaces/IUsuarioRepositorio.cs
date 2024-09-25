using primeiroprojetoMVC.Models;

namespace primeiroprojetoMVC.Data.Repositorio.Interfaces
{
    public interface IUsuarioRepositorio
    {

       Usuario Login(string email, string senha);
        
    }
}




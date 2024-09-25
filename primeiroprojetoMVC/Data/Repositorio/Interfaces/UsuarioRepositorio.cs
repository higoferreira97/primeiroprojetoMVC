using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using primeiroprojetoMVC.Data.Repositorio.Interfaces;
using primeiroprojetoMVC.Models;
using System.Web.Mvc;


namespace primeiroprojetoMVC.Data.Repositorio.Interfaces
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly BancoContexto _bancoContexto;

        public UsuarioRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public Usuario Login(string email, string senha)
        {
            
           return  _bancoContexto.UsuarioTeste.SingleOrDefault(x => x.Email == email && x.Senha == senha);
           
        }
    }
}

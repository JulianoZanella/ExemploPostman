using ExemploPostman.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExemploPostman.Repositorios
{
    public static class UsuarioRepositorio
    {
        public static Usuario Get(string login, string senha)
        {
            var usuarios = new List<Usuario>
            {
                new Usuario{Id = 1, Login = "Teste", Senha = "123456"},
                new Usuario{Id = 1, Login = "Teste1", Senha = "234567"},
                new Usuario{Id = 1, Login = "Teste2", Senha = "345678"},
            };

            return usuarios.FirstOrDefault(usuario => usuario.Login?.ToLower() == login?.ToLower() && usuario.Senha == senha);
        }
    }
}

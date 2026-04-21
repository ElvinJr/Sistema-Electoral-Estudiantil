using System;
using Conexion;
using Conexion.Repositories;
using Recursos;

namespace Logica
{
    public class UserService
    {
        private readonly UserRepository _userRepo;

        public UserService(Servidor servidor)
        {
            _userRepo = new UserRepository(servidor);
        }

        public Usuario Login(string matricula)
        {
            return _userRepo.GetByMatricula(matricula);
        }

        public int RegistrarUsuario(Usuario usuario)
        {
            return _userRepo.Create(usuario);
        }
    }
}

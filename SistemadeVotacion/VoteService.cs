using System;
using Conexion;
using Conexion.Repositories;

namespace Logica
{
    public class VoteService
    {
        private readonly VoteRepository _voteRepo;

        public VoteService(Servidor servidor)
        {
            _voteRepo = new VoteRepository(servidor);
        }

        public int RegistrarVoto(int usuarioId, int? planchaId)
        {
            return _voteRepo.RegisterVote(usuarioId, planchaId);
        }

        public int ContarVotosUsuario(int usuarioId)
        {
            return _voteRepo.CountVotesByUser(usuarioId);
        }
    }
}

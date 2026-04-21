using System;
using Conexion;
using Conexion.Repositories;
using Recursos;

namespace Logica
{
    public class PlanchaService
    {
        private readonly PlanchaRepository _planchaRepo;

        public PlanchaService(Servidor servidor)
        {
            _planchaRepo = new PlanchaRepository(servidor);
        }

        public Plancha ObtenerPlancha(int planchaId)
        {
            return _planchaRepo.GetById(planchaId);
        }

        public int RegistrarPlancha(Plancha plancha)
        {
            return _planchaRepo.Create(plancha);
        }
    }
}

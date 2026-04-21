using System;
using Conexion;
using Conexion.Repositories;

namespace Logica
{
    public class ReporteService
    {
        private readonly ReporteRepository _reporteRepo;

        public ReporteService(Servidor servidor)
        {
            _reporteRepo = new ReporteRepository(servidor);
        }

        public object ObtenerEstadisticas()
        {
            return _reporteRepo.GetEstadisticas();
        }
    }
}
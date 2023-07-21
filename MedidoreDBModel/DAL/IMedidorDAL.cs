using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoreDBModel.DAL
{
    public interface IMedidorDAL
    {
        void InsertarMedidor(Medidor medidor);
        Medidor ObtenerMedidorPorNumeroSerie(int numeroSerie);
        List<Medidor> ObtenerTodosLosMedidores();
    }
}
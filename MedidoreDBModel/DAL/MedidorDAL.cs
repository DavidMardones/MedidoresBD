using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoreDBModel.DAL
{
    public class MedidorDAL : IMedidorDAL
    {
        private readonly MEDIDORDBEntities dbContext;

        public MedidorDAL()
        {
            dbContext = new MEDIDORDBEntities();
        }

        public void InsertarMedidor(Medidor medidor)
        {
            dbContext.Medidors.Add(new Medidor { numeroSerie = medidor.numeroSerie, tipo = medidor.tipo });
            dbContext.SaveChanges();
        }

        public Medidor ObtenerMedidorPorNumeroSerie(int numeroSerie)
        {
            return dbContext.Medidors.FirstOrDefault(m => m.numeroSerie == numeroSerie);
        }

        public List<Medidor> ObtenerTodosLosMedidores()
        {
            return dbContext.Medidors.ToList();
        }
    }
}
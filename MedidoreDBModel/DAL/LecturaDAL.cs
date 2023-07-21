using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoreDBModel.DAL
{
    public class LecturaDAL : ILecturaDAL
    {
        private readonly MEDIDORDBEntities dbContext;

        public LecturaDAL()
        {
            dbContext = new MEDIDORDBEntities();
        }

        public void InsertarLectura(Lectura lectura)
        {
            dbContext.Lecturas.Add(lectura);
            dbContext.SaveChanges();
        }

        public List<Lectura> ObtenerLecturasPorNumeroSerie(string numeroSerie)
        {
            if (!int.TryParse(numeroSerie, out int numeroSerieInt))
            {
                return new List<Lectura>();
            }

            return dbContext.Lecturas.Where(l => l.numeroSerie == numeroSerieInt).ToList();
        }
    }
}
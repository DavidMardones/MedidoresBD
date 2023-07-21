using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoreDBModel.DAL
{
    public interface ILecturaDAL
    {
        void InsertarLectura(Lectura lectura);
        List<Lectura> ObtenerLecturasPorNumeroSerie(string numeroSerie);
    }

}
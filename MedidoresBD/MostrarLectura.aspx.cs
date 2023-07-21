using MedidoreDBModel.DAL;
using MedidoreDBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresBD
{
    public partial class MostrarLectura : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            string numeroSerie = "123"; // Puedes obtener este valor desde la URL o cualquier otra fuente

            LecturaDAL lecturaDAL = new LecturaDAL();
            List<Lectura> lecturas = lecturaDAL.ObtenerLecturasPorNumeroSerie(numeroSerie);

            gridLecturas.DataSource = lecturas;
            gridLecturas.DataBind();
        }
    }
}
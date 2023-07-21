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
    public partial class MostrarMedidor : Page
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
            MedidorDAL medidorDAL = new MedidorDAL();
            List<Medidor> medidores = medidorDAL.ObtenerTodosLosMedidores();

            gridMedidores.DataSource = medidores;
            gridMedidores.DataBind();
        }
    }
}
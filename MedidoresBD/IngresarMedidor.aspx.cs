using MedidoreDBModel;
using MedidoreDBModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresBD
{
    public partial class IngresarMedidor : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumeroSerie.Text, out int numeroSerie))
            {
                string tipo = ddlTipo.SelectedValue;

                Medidor medidor = new Medidor { numeroSerie = numeroSerie, tipo = tipo };

                MedidorDAL medidorDAL = new MedidorDAL();
                medidorDAL.InsertarMedidor(medidor);

                Response.Redirect("MostrarMedidor.aspx");
            }
            else
            {
            }
        }
    }
}
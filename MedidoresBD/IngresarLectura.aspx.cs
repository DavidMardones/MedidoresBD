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
    public partial class IngresarLectura : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumeroSerie.Text, out int numeroSerie))
            {
                DateTime fecha = DateTime.Parse(txtFecha.Text);
                TimeSpan hora = TimeSpan.Parse(txtHora.Text);
                decimal valorConsumo = decimal.Parse(txtValorConsumo.Text);

                Lectura lectura = new Lectura
                {
                    numeroSerie = numeroSerie,
                    fecha = fecha,
                    hora = hora,
                    valorConsumo = valorConsumo
                };

                LecturaDAL lecturaDAL = new LecturaDAL();
                lecturaDAL.InsertarLectura(lectura);

                Response.Redirect("MostrarLectura.aspx");
            }
            else
            {

            }
        }
    }
}
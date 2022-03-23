using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ws_Cliente
{
    public partial class Libro : System.Web.UI.Page
    {
        
        srTitulo.wsTituloSoapClient servicio = new srTitulo.wsTituloSoapClient();
        srEditorial2.wsEditorialSoapClient servicio2 = new srEditorial2.wsEditorialSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            //listar los datos cuando la pagina cargue
            GridView1.DataSource = servicio.Listar().Tables[0];
            GridView1.DataBind();

            GridView2.DataSource = servicio2.Listar().Tables[0];
            GridView2.DataBind();


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = servicio.Buscar(txtCriterio.Text, txtCampo.Text).Tables[0];
            GridView1.DataBind();
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            string[] msj = servicio.Agregar(txtIdlibro.Text, txtLibro.Text, txtTypo.Text, txtIdeditorial.Text, txtPrecio.Text, txtAdvance.Text, txtCalificacion.Text, txtVentas.Text, txtVentas.Text,txtFechadepub.Text);
            Response.Write("<scrip>alert('" + msj[0] + " : " + msj[1] + "');</script>");
            Listar();
        }

        private void Listar()
        {
            GridView1.DataSource = servicio.Listar().Tables[0];
            GridView1.DataBind();
        }

        protected void btnActualizarLibro_Click(object sender, EventArgs e)
        {
            string[] msj = servicio.Actualizar(txtIdlibro.Text, txtLibro.Text, txtTypo.Text, txtIdeditorial.Text, txtPrecio.Text, txtAdvance.Text, txtCalificacion.Text, txtVentas.Text, txtVentas.Text, txtFechadepub.Text);
            Response.Write("<scrip>alert('" + msj[0] + " : " + msj[1] + "');</script>");
            Listar();
        }
    }
}
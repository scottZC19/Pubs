using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace ws_Cliente
{
    public partial class autor2 : System.Web.UI.Page
    {
        srAutor.wsAutorSoapClient servicio = new srAutor.wsAutorSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = servicio.Listar().Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = servicio.Buscar(txtCriterio.Text, txtCampo.Text).Tables[0];
            GridView1.DataBind();

        }

        

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            string[] msj = servicio.Agregar(txtId.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, txtCiudad.Text, txtEstado.Text, txtCodigoPostal.Text, txtContrato.MaxLength);
            Response.Write("<scrip>alert('" + msj[0] + " : " + msj[1] + "');</script>");
            Listar();
        }

        private void Listar()
        {
            GridView1.DataSource = servicio.Listar().Tables[0];
            GridView1.DataBind();
        }

        protected void btnActualizarAutor_Click(object sender, EventArgs e)
        {
            string[] msj = servicio.Actualizar(txtId.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, txtCiudad.Text, txtEstado.Text, txtCodigoPostal.Text, txtContrato.MaxLength);
            Response.Write("<scrip>alert('" + msj[0] + " : " + msj[1] + "');</script>");
            Listar();
        }

        protected void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
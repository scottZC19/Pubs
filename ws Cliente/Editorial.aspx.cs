using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ws_Cliente
{


    public partial class Editorial : System.Web.UI.Page
    {
        srEditorial2.wsEditorialSoapClient servicio = new srEditorial2.wsEditorialSoapClient();
        
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

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string[] msj = servicio.Agregar(txtIdeditorial.Text, txtnombreeditorial.Text, txtciudad.Text, txtestado.Text, txtpais.Text);
            Response.Write("<scrip>alert('" + msj[0] + " : " + msj[1] + "');</script>");
            Listar();
        }

        private void Listar()
        {
            GridView1.DataSource = servicio.Listar().Tables[0];
            GridView1.DataBind();
        }

        protected void btnActualizareditorial_Click(object sender, EventArgs e)
        {
            string[] msj = servicio.Actualizar(txtIdeditorial.Text, txtnombreeditorial.Text, txtciudad.Text, txtestado.Text, txtpais.Text);
            Response.Write("<scrip>alert('" + msj[0] + " : " + msj[1] + "');</script>");
            Listar();
        }
    }
}
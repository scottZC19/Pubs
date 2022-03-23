using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Capa_Negocio;
using System.Data;
using Capa_Entidad;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de wsAutor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsAutor : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar autor")]
        public DataSet Listar()
        {
            AutorBL autor = new AutorBL();
            return autor.Listar();
        }

        [WebMethod(Description = "agreagr autor")]

        public string[] Agregar(string Codigo, string Nombre, string Apellidos, string Telefono, string Direccion, string Ciudad, string Estado, string Zip, int Contrato)
        {
            AutorBL autorBL = new AutorBL();
            Autor autor = new Autor();
            autor.IdAutor1 = Codigo;
            autor.NombreAutor1 = Nombre;
            autor.ApellidoAutor1 = Apellidos;
            autor.TelefonoAutor1 = Telefono;
            autor.DireccionAutor1 = Direccion;
            autor.CiudadAutor1 = Ciudad;
            autor.EstadoAutor1 = Estado;
            autor.Zip = Zip;
            autor.Contrato = Contrato;
            string[] valores = new string[2];
            valores[0] = autorBL.Agregar(autor).ToString();
            valores[1] = autorBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "actualizar autor")]

        public string[] Actualizar(string Codigo, string Nombre, string Apellidos, string Telefono, string Direccion, string Ciudad, string Estado, string Zip, int Contrato)
        {
            AutorBL autorBL = new AutorBL();
            Autor autor = new Autor();
            autor.IdAutor1 = Codigo;
            autor.NombreAutor1 = Nombre;
            autor.ApellidoAutor1 = Apellidos;
            autor.TelefonoAutor1 = Telefono;
            autor.DireccionAutor1 = Direccion;
            autor.CiudadAutor1 = Ciudad;
            autor.EstadoAutor1 = Estado;
            autor.Zip = Zip;
            autor.Contrato = Contrato;
            string[] valores = new string[2];
            valores[0] = autorBL.Actualizar(autor).ToString();
            valores[1] = autorBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar autor")]

        public DataSet Buscar(string texto, string criterio)
        {
            AutorBL autor = new AutorBL();
            return autor.Buscar(texto, criterio);
        }

        

    }
}

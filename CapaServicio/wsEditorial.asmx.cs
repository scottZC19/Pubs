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
    /// Descripción breve de wsEditorial
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsEditorial : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Editorial")]
        public DataSet Listar()
        {
            EditorialBL editorial = new EditorialBL();
            return editorial.Listar();
        }

        [WebMethod(Description = "buscar editorial")]
        public DataSet Buscar(string texto, string criterio)
        {
            EditorialBL editorial = new EditorialBL();
            return editorial.Buscar(texto, criterio);
        }

        [WebMethod(Description = "agregar editorial")]
        public string[] Agregar(string IdEditorial, string NombreEditorial, string Ciudad, string Estado, string Pais)
        {
            EditorialBL editorialBl = new EditorialBL();
            Editorial editorial = new Editorial();
            editorial.IdEditorial1 = IdEditorial;
            editorial.NombreEditorial1 = NombreEditorial;
            editorial.Ciudad1 = Ciudad;
            editorial.Estado1 = Estado;
            editorial.Pais1 = Pais;
            
            string[] valores = new string[2];
            valores[0] = editorialBl.Agregar(editorial).ToString();
            valores[1] = editorialBl.Mensaje;
            return valores;
        }
        [WebMethod(Description ="Actualizar editorial")]

        public string[] Actualizar(string IdEditorial, string NombreEditorial, string Ciudad, string Estado, string Pais)
        {
            EditorialBL editorialBl = new EditorialBL();
            Editorial editorial = new Editorial();
            editorial.IdEditorial1 = IdEditorial;
            editorial.NombreEditorial1 = NombreEditorial;
            editorial.Ciudad1 = Ciudad;
            editorial.Estado1 = Estado;
            editorial.Pais1 = Pais;

            string[] valores = new string[2];
            valores[0] = editorialBl.Actualizar(editorial).ToString();
            valores[1] = editorialBl.Mensaje;
            return valores;
        }

    }
}

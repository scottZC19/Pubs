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
    /// Descripción breve de wsTitulo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsTitulo : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar libros")]
        public DataSet Listar()
        {
            TituloBL autor = new TituloBL();
            return autor.Listar();
        }

        [WebMethod(Description = "agreagr libros")]

        public string[] Agregar(string IdLibro, string Titulo, string Tipo, string IdEditorial, string Precio, string Advance, string Royalty, 
            string Ytdsales, string Notas, string Fechadepublicacion  )
        {
            TituloBL tituloBL = new TituloBL();
            Titulo titulo = new Titulo();
            titulo.IdTitulo = IdLibro;
            titulo.TituloLibro1 = Titulo;
            titulo.Tipo1 = Tipo;
            titulo.IdEditorial1 = IdEditorial;
            titulo.Precio1 = Precio;
            titulo.Advance1 = Advance;
            titulo.Royalty1 = Royalty;
            titulo.YtdSales1 = Ytdsales;
            titulo.Notas1 = Notas;
            titulo.FechaPublicacion1 = Fechadepublicacion;

            string[] valores = new string[2];
            valores[0] = tituloBL.Agregar(titulo).ToString();
            valores[1] = tituloBL.Mensaje;
            return valores;



        }


        [WebMethod(Description = "buscar Libro")]
        public DataSet Buscar(string texto, string criterio)
        {
            TituloBL libro = new TituloBL();
            return libro.Buscar(texto, criterio);
        }


        [WebMethod(Description = "actualizar Libro")]
        public string[] Actualizar(string IdLibro, string Titulo, string Tipo, string IdEditorial, string Precio, string Advance, string Royalty,
            string Ytdsales, string Notas, string Fechadepublicacion)
        {
            TituloBL tituloBL = new TituloBL();
            Titulo titulo = new Titulo();
            titulo.IdTitulo = IdLibro;
            titulo.TituloLibro1 = Titulo;
            titulo.Tipo1 = Tipo;
            titulo.IdEditorial1 = IdEditorial;
            titulo.Precio1 = Precio;
            titulo.Advance1 = Advance;
            titulo.Royalty1 = Royalty;
            titulo.YtdSales1 = Ytdsales;
            titulo.Notas1 = Notas;
            titulo.FechaPublicacion1 = Fechadepublicacion;

            string[] valores = new string[2];
            valores[0] = tituloBL.Actualizar(titulo).ToString();
            valores[1] = tituloBL.Mensaje;
            return valores;


        }
    }
}

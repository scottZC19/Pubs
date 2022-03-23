using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;
using Capa_Entidad;
using CapaDato;
namespace Capa_Negocio
{
    public class TituloBL: Interface.ITitulo
    {

        private string mensaje;
        //propiedad de solo lectura
        public string Mensaje
        {
            get { return mensaje; }
        }
        //utilizar los archivos cs de la capa de datos
        Datos datos = new DatosSQL();

        public bool Actualizar(Titulo titulo)
        {
            DataRow fila = datos.TraerDataRow("spActualizarLibro", titulo.IdTitulo, titulo.TituloLibro1, titulo.Tipo1, titulo.IdEditorial1, titulo.Precio1, titulo.Advance1, titulo.Royalty1, titulo.YtdSales1, titulo.Notas1, titulo.FechaPublicacion1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Titulo titulo)
        {
            DataRow fila = datos.TraerDataRow("spAgregarLibro", titulo.IdTitulo, titulo.TituloLibro1, titulo.Tipo1, titulo.IdEditorial1, titulo.Precio1, titulo.Advance1, titulo.Royalty1, titulo.YtdSales1, titulo.Notas1, titulo.FechaPublicacion1 );
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarLibro", texto, criterio);
        }

        public bool Eliminar(string idtitulo)
        {
            throw new System.NotImplementedException();
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarLibro");
        }
    }
}

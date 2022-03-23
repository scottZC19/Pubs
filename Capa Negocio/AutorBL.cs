using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using CapaDato;
namespace Capa_Negocio
{
    public class AutorBL: Interface.IAutor
    {
        // atributo quedevuelve el mensaje del PA

        private string mensaje;
        //propiedad de solo lectura
        public string Mensaje
        {
            get { return mensaje; }
        }

        Datos datos = new DatosSQL();


        public bool Actualizar(Autor autor)
        {
            DataRow fila = datos.TraerDataRow("spActualizarAutor", autor.IdAutor1, autor.NombreAutor1, autor.ApellidoAutor1, autor.TelefonoAutor1, autor.DireccionAutor1, autor.CiudadAutor1, autor.EstadoAutor1, autor.Zip, autor.Contrato);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Autor autor)
        {
            DataRow fila = datos.TraerDataRow("spAgregarAutor", autor.IdAutor1, autor.NombreAutor1, autor.ApellidoAutor1, autor.TelefonoAutor1, autor.DireccionAutor1, autor.CiudadAutor1, autor.EstadoAutor1, autor.Zip, autor.Contrato);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarAutor", texto, criterio);
        }

        public bool Eliminar(string idautor)
        {
            DataRow fila = datos.TraerDataRow("spEliminarAutor", idautor);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarAutor");
        }
    }
}

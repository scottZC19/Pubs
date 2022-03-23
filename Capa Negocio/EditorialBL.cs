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
    public class EditorialBL : Interface.IEditorial
    {

        private string mensaje;
        //propiedad de solo lectura
        public string Mensaje
        {
            get { return mensaje; }
        }

       


        //utilizar los archivos cs de la capa de datos
        Datos datos = new DatosSQL();


        public bool Actualizar(Editorial editorial)
        {
            DataRow fila = datos.TraerDataRow("spActualizarEditorial", editorial.IdEditorial1, editorial.NombreEditorial1, editorial.Ciudad1, editorial.Estado1, editorial.Pais1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Editorial editorial)
        {
            DataRow fila = datos.TraerDataRow("spAgregarEditorial", editorial.IdEditorial1, editorial.NombreEditorial1, editorial.Ciudad1, editorial.Estado1, editorial.Pais1);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarEditorial", texto, criterio);
        }

        public bool Eliminar(string ideditorial)
        {
            throw new NotImplementedException();
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarEditorial2");
        }
    }
}

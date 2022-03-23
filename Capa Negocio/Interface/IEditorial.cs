using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using Capa_Entidad;


namespace Capa_Negocio.Interface
{
    internal interface IEditorial
    {

        DataSet Listar();
        bool Agregar(Editorial editorial);
        bool Eliminar(string ideditorial);
        bool Actualizar(Editorial editorial);
        DataSet Buscar(string texto, string criterio);


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using Capa_Entidad;


namespace Capa_Negocio.Interface
{
    internal interface IAutor
    {
        //declara metodos comunes 
        DataSet Listar();
        bool Agregar(Autor autor);
        bool Eliminar(string idautor);
        bool Actualizar(Autor autor);
        DataSet Buscar(string texto, string criterio);
    }
}

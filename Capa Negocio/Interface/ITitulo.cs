using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Entidad;
namespace Capa_Negocio.Interface
{
    internal interface ITitulo
    {

        DataSet Listar();
        bool Agregar(Titulo titulo);
        bool Eliminar(string idtitulo);
        bool Actualizar(Titulo titulo);
        DataSet Buscar(string texto, string criterio);

    }
}

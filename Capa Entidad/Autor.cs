using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Autor
    {

        private string IdAutor;
        private string NombreAutor;
        private string ApellidoAutor;
        private string TelefonoAutor;
        private string DireccionAutor;
        private string CiudadAutor;
        private string EstadoAutor;
        private string zip;
        private int contrato;

        public string IdAutor1 { get => IdAutor; set => IdAutor = value; }
        public string NombreAutor1 { get => NombreAutor; set => NombreAutor = value; }
        public string ApellidoAutor1 { get => ApellidoAutor; set => ApellidoAutor = value; }
        public string TelefonoAutor1 { get => TelefonoAutor; set => TelefonoAutor = value; }
        public string DireccionAutor1 { get => DireccionAutor; set => DireccionAutor = value; }
        public string CiudadAutor1 { get => CiudadAutor; set => CiudadAutor = value; }
        public string EstadoAutor1 { get => EstadoAutor; set => EstadoAutor = value; }
        public string Zip { get => zip; set => zip = value; }
        public int Contrato { get => contrato; set => contrato = value; }
    }
}

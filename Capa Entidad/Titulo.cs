using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Titulo
    {

        private string idTitulo;
        private string TituloLibro;
        private string Tipo;
        private string IdEditorial;
        private string Precio;
        private string Advance;
        private string Royalty;
        private string YtdSales;
        private string Notas;
        private string FechaPublicacion;



        public string IdTitulo { get => idTitulo; set => idTitulo = value; }
        public string TituloLibro1 { get => TituloLibro; set => TituloLibro = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string IdEditorial1 { get => IdEditorial; set => IdEditorial = value; }
        public string Precio1 { get => Precio; set => Precio = value; }
        public string Notas1 { get => Notas; set => Notas = value; }
        public string FechaPublicacion1 { get => FechaPublicacion; set => FechaPublicacion = value; }
        public string Advance1 { get => Advance; set => Advance = value; }
        public string Royalty1 { get => Royalty; set => Royalty = value; }
        public string YtdSales1 { get => YtdSales; set => YtdSales = value; }
    }
}

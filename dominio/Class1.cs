using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace dominio
{
    public class Class1
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }

        public decimal Precio { get; set; }

        public string UrlImagen { get; set; }

        public List<string> Imagenes { get; set; }

    }
}

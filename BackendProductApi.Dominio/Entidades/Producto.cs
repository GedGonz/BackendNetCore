using System;
using System.Collections.Generic;
using System.Text;

namespace BackendProductApi.Dominio.Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
    }
}

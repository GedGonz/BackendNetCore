
using BackendProductApi.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackendProductApi.Dominio.Contratos
{
    public interface IProductoRepositorio
    {
        public Task<List<Producto>> obtenerListProducto();
        public Task<Producto> obtenerProducto(int id);

        public Task guardarProducto(Producto producto);
        public Task actualizarProducto(Producto producto);
        public Task eliminarProducto(int id);
    }
}

using BackendProductApi.Aplicacion.EntidadesDto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackendProductApi.Aplicacion.Contratos
{
    public interface IProductoAplicacionServicio
    {
        public Task<List<ProductoDto>> obtenerListProducto();
        public Task<ProductoDto> obtenerProducto(int id);

        public Task guardarProducto(ProductoDto producto);
        public Task actualizarProducto(ProductoDto producto);
        public Task eliminarProducto(int id);
    }
}

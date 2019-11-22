using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BackendProductApi.Dominio.Contratos;
using BackendProductApi.Infraestructura.Contexto;
using BackendProductApi.Dominio.Entidades;

namespace BackendProductApi.Infraestructura.Repositorio
{
    public class ProductoRepositorio : IProductoRepositorio
    {
        private ProductoContexto productocontexto;
        public ProductoRepositorio(ProductoContexto productocontexto)
        {
            this.productocontexto = productocontexto;
        }

        public Task actualizarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public Task eliminarProducto(int id)
        {
            throw new NotImplementedException();
        }

        public Task guardarProducto(Producto producto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Producto>> obtenerListProducto()
        {
            var ListaProducto = await Task.Factory.StartNew( ()  =>
            {
                return  productocontexto.Producto.ToList();
            });

            return ListaProducto;


        }

        public Task<Producto> obtenerProducto(int id)
        {
            throw new NotImplementedException();
        }
    }
}

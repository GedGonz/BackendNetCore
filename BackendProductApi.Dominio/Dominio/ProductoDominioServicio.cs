
using BackendProductApi.Dominio.Contratos;
using BackendProductApi.Dominio.Entidades;
using BackendProductApi.Dominio.Servicio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackendProductApi.Dominio.Dominio
{
    public class ProductoDominioServicio : IProductoDominioServicio
    {
        private readonly IProductoRepositorio productoRepositorio;
        public ProductoDominioServicio(IProductoRepositorio productoRepositorio)
        {
            this.productoRepositorio = productoRepositorio;
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
            return await productoRepositorio.obtenerListProducto();
        }

        public Task<Producto> obtenerProducto(int id)
        {
            throw new NotImplementedException();
        }
    }
}

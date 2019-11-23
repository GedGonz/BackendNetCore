
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
        public async Task actualizarProducto(Producto producto)
        {
            await productoRepositorio.actualizarProducto(producto);
        }

        public async Task eliminarProducto(int id)
        {
            await productoRepositorio.eliminarProducto(id);
        }

        public async Task guardarProducto(Producto producto)
        {
            await productoRepositorio.guardarProducto(producto);
        }

        public async Task<List<Producto>> obtenerListProducto()
        {
            return await productoRepositorio.obtenerListProducto();
        }

        public async Task<Producto> obtenerProducto(int id)
        {
            return await productoRepositorio.obtenerProducto(id);
        }
    }
}

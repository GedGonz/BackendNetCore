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

        public async Task actualizarProducto(Producto producto)
        {
            var _producto = await obtenerProducto(producto.ProductoId);
            if (_producto!=null) 
            {
                _producto.Nombre = producto.Nombre;
                _producto.Descripcion = producto.Descripcion;
                _producto.Categoria = producto.Categoria;
                _producto.Precio = producto.Precio;
                _producto.Imagen = producto.Imagen;

                productocontexto.Update(_producto);

                productocontexto.SaveChanges();
            }
            
        }

        public async  Task eliminarProducto(int id)
        {
            var producto = await obtenerProducto(id);

            if (producto != null)
            {
                productocontexto.Remove(producto);
                productocontexto.SaveChanges();
            }
        }

        public async Task guardarProducto(Producto producto)
        {
            await productocontexto.AddAsync(producto);
            productocontexto.SaveChanges();
        }

        public async Task<List<Producto>> obtenerListProducto()
        {
            var ListaProducto = await Task.Factory.StartNew( ()  =>
            {
                return  productocontexto.Producto.ToList();
            });

            return ListaProducto;


        }

        public async Task<Producto> obtenerProducto(int id)
        {
            return await productocontexto.Producto.FindAsync(id);
        }
    }
}

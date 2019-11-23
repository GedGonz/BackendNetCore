using AutoMapper;
using BackendProductApi.Aplicacion.Contratos;
using BackendProductApi.Aplicacion.EntidadesDto;
using BackendProductApi.Dominio.Entidades;
using BackendProductApi.Dominio.Servicio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BackendProductApi.Aplicacion.Servicios
{
    public class ProductoAplicacionServicio : IProductoAplicacionServicio
    {
        private readonly IProductoDominioServicio productoDominioServicio;
        private readonly IMapper _mapper;
        public ProductoAplicacionServicio(IProductoDominioServicio productoDominioServicio,IMapper _mapper)
        {
            this.productoDominioServicio = productoDominioServicio;
            this._mapper = _mapper;
        }
        public async Task actualizarProducto(ProductoDto productodto)
        {
            var _producto = _mapper.Map<Producto>(productodto);

            await productoDominioServicio.actualizarProducto(_producto);

        }

        public async Task eliminarProducto(int id)
        {

            await productoDominioServicio.eliminarProducto(id);
        }

        public async Task guardarProducto(ProductoDto productodto)
        {
            var _producto = _mapper.Map<Producto>(productodto);

            await productoDominioServicio.guardarProducto(_producto);
        }

        public async Task<List<ProductoDto>> obtenerListProducto()
        {
            var productos = await productoDominioServicio.obtenerListProducto();
            var productosdto = _mapper.Map<List<ProductoDto>>(productos);

            return productosdto;
        }

        public async Task<ProductoDto> obtenerProducto(int id)
        {

            var produto=  await productoDominioServicio.obtenerProducto(id);
            var productosdto = _mapper.Map<ProductoDto>(produto);

            return productosdto;
        }
    }
}

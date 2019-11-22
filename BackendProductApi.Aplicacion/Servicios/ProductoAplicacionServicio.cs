using AutoMapper;
using BackendProductApi.Aplicacion.Contratos;
using BackendProductApi.Aplicacion.EntidadesDto;
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
        public Task actualizarProducto(ProductoDto producto)
        {
            throw new NotImplementedException();
        }

        public Task eliminarProducto(int id)
        {
            throw new NotImplementedException();
        }

        public Task guardarProducto(ProductoDto producto)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductoDto>> obtenerListProducto()
        {
            var productos = await productoDominioServicio.obtenerListProducto();
            var productosdto = _mapper.Map<List<ProductoDto>>(productos);

            return productosdto;
        }

        public Task<ProductoDto> obtenerProducto(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProductApi.Aplicacion.Contratos;
using BackendProductApi.Aplicacion.EntidadesDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly IProductoAplicacionServicio productoAplicacionServicio;

        public ProductoController(IProductoAplicacionServicio productoAplicacionServicio)
        {
            this.productoAplicacionServicio = productoAplicacionServicio;
        }
        // GET: api/Producto
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await productoAplicacionServicio.obtenerListProducto();

            return Ok(result);
        }

        // GET: api/Producto/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await productoAplicacionServicio.obtenerProducto(id);

            if(result==null) 
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST: api/Producto
        [HttpPost]
        public async Task Post([FromBody] ProductoDto producto)
        {
            await productoAplicacionServicio.guardarProducto(producto);
        }

        // PUT: api/Producto/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody]  ProductoDto product)
        {
            await productoAplicacionServicio.actualizarProducto(product);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await productoAplicacionServicio.eliminarProducto(id);
        }
    }
}

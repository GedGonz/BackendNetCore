using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProductApi.Aplicacion.Contratos;
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

            return Json(result);
        }

        // GET: api/Producto/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Producto
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Producto/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

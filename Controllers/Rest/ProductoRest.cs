using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using app2game.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app2game.Controllers.Rest
{

    [ApiController]
    [Route("api/producto")]
    public class ProductoRest : ControllerBase
    {
        private readonly ILogger<ProductoRest> _logger;

        public ProductoRest(ILogger<ProductoRest> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Producto>>> GetProductos(){
            var productos = new List<Producto>();
            _logger.LogInformation("GetProductos{0}", productos);
            return Ok(productos);
        }
  
    }
}
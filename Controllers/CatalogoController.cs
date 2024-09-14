using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app2game.Data;
using System.Dynamic;

namespace app2game.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ILogger<CatalogoController> _logger;
         private readonly ApplicationDbContext _context;

        public CatalogoController(ILogger<CatalogoController> logger,
                ApplicationDbContext context)
        {
            _logger = logger;
             _context = context;
        }

        public IActionResult Index()
        {
            var categorias = from o in _context.DataCategoria select o;
            var catalogos = from o in _context.DataProducto select o;
            dynamic model = new ExpandoObject();
            model.itemCategorias = categorias;
            model.itemCatalogos = catalogos;
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
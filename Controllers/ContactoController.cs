using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app2game.Data;
using app2game.Models;
using app2game.ViewModel;

namespace app2game.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context;

        public ContactoController(ILogger<ContactoController> logger,ApplicationDbContext context)
        {
            _logger = logger;
             _context = context;
        }

        public IActionResult Index()
        {
            var miscontactos = from o in _context.DataContacto select o;
            _logger.LogDebug("contactos {miscontactos}", miscontactos);
            var viewModel = new ContactoViewModel{
                FormContacto = new Contacto(),
                ListContacto = miscontactos
            };
             _logger.LogDebug("viewModel {viewModel}", viewModel);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Enviar(ContactoViewModel viewModel)
        {
            _logger.LogDebug("Ingreso a Enviar Mensaje");
            
            var contacto = new Contacto
            {
                Name = viewModel.FormContacto.Name,
                Email = viewModel.FormContacto.Email,
                Message = viewModel.FormContacto.Message
            };

            _context.Add(contacto);
            _context.SaveChanges();

            ViewData["Message"] = "Se registro el contacto";            
            
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
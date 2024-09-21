using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using app2game.Models;

namespace app2game.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var cookieOptions = new CookieOptions
        {
            Expires = DateTime.UtcNow.AddMinutes(30), // Duración de la cookie: 30 minutos
            HttpOnly = true, // La cookie solo puede ser accedida mediante HTTP, no vía JavaScript
            Secure = true, // La cookie solo se enviará a través de conexiones HTTPS
            SameSite = SameSiteMode.Strict // Evita que la cookie sea enviada en solicitudes cross-site
        };
        Response.Cookies.Append("MyCookieApp", "app2game", cookieOptions);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

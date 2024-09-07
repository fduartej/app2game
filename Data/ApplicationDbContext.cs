using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace app2game.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<app2game.Models.Cliente> DataCliente {get; set; }

    public DbSet<app2game.Models.Contacto> DataContacto {get; set; }

 
}

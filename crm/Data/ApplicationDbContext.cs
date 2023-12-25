using crm.Models;
using crm.Models.Clientes;
using crm.Models.Usuario;
using Microsoft.EntityFrameworkCore;

namespace crm.Data;

public class ApplicationDbContext : DbContext
{
    //Instanciar y heredar las clases del consturctor para heredar
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    //Agrega los modelos
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<DatosContacto> DatosContacto { get; set; }
    
    
}
using System.ComponentModel.DataAnnotations;

namespace crm.Models.Usuario;

public class Usuario
{
    [Key]
    public int UsuarioId { get; set; }
    
    public string Nombre { get; set; }
    
    public string Apellido { get; set; }
    
    public string Correo { get; set; }
    
    public string Password { get; set; }
    
    public string Telefono { get; set; }
    
    public string UserName { get; set; }
    
    public bool EsAdmin { get; set; }
    
    public DateTime FechaCreacionUsuario { get; set; }
    
}
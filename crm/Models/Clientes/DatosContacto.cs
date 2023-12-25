using System.ComponentModel.DataAnnotations;

namespace crm.Models.Clientes;

public class DatosContacto
{
    [Key]
    public int DatosContactoId { get; set; }
    
    public int ClienteId { get; set; }
    
    public string Correo { get; set; }
    
    public string Telefono { get; set; }
    
    public string Direccion { get; set; }
    
    public string Ciudad { get; set; }
    
    public string Estado { get; set; }
    
    public int CodigoPostal { get; set; }
    
    public DateTime FechaActualizacionDatosContacto { get; set; }
    
}
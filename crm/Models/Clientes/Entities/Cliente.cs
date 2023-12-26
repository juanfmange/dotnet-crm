using System;
using System.Collections.Generic;

namespace crm.Models.Clientes.Entities;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public int? UsuarioId { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public DateTime? FechaDeAlta { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public bool? EsFrecuente { get; set; }

    public int? DatosContactoId { get; set; }
}

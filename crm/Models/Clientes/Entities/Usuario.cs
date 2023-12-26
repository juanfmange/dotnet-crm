using System;
using System.Collections.Generic;

namespace crm.Models.Clientes.Entities;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public bool EsAdmin { get; set; }

    public DateTime FechaCreacionUsuario { get; set; }
}

using System;
using System.Collections.Generic;

namespace DI05_Modelo.Modelos;

public partial class Empleado
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Dni { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Puesto { get; set; } = null!;

    public virtual ICollection<AplicacionTratamiento> AplicacionTratamientos { get; } = new List<AplicacionTratamiento>();
}

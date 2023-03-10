using System;
using System.Collections.Generic;

namespace DI05_Modelo.Modelos;

public partial class Cita
{
    public int Id { get; set; }

    public DateTime Fecha { get; set; }

    public TimeSpan Hora { get; set; }

    public string FormaPago { get; set; } = null!;

    public int IdAplicaciontratamiento { get; set; }

    public string? Observaciones { get; set; }

    public virtual AplicacionTratamiento IdAplicaciontratamientoNavigation { get; set; } = null!;
}

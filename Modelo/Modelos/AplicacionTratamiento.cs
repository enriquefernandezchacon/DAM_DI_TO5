using System;
using System.Collections.Generic;

namespace DI05_Modelo.Modelos;

public partial class AplicacionTratamiento
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdTratamiento { get; set; }

    public int IdTrabajador { get; set; }

    public int Coste { get; set; }

    public virtual ICollection<Cita> Cita { get; } = new List<Cita>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empleado IdTrabajadorNavigation { get; set; } = null!;

    public virtual Tratamiento IdTratamientoNavigation { get; set; } = null!;
}

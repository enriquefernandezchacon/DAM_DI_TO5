using System;
using System.Collections.Generic;

namespace DI05_Modelo.Modelos;

public partial class Tratamiento
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Precio { get; set; }
}

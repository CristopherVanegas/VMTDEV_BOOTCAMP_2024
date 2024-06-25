using System;
using System.Collections.Generic;

namespace ORM.Models;

public partial class Categorium
{
    public double? CategId { get; set; }

    public string? CategNombre { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaHoraReg { get; set; }
}

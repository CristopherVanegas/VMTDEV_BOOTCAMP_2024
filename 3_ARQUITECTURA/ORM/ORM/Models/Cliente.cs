﻿using System;
using System.Collections.Generic;

namespace ORM.Models;

public partial class Cliente
{
    public double? ClienteId { get; set; }

    public string? ClienteNombre { get; set; }

    public double? Cedula { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaHoraReg { get; set; }
}

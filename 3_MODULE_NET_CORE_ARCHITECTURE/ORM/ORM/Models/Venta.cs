﻿using System;
using System.Collections.Generic;

namespace ORM.Models;

public partial class Venta
{
    public double IdFactura { get; set; }

    public string? NumFact { get; set; }

    public DateTime? FechaHora { get; set; }

    public double? ClienteId { get; set; }

    public double ProductoId { get; set; }

    public double? ModeloId { get; set; }

    public double? CategId { get; set; }

    public double? MarcaId { get; set; }

    public double? SucursalId { get; set; }

    public string? CajaId { get; set; }

    public string? VendedorId { get; set; }

    public double? Precio { get; set; }

    public double? Unidades { get; set; }

    public int? Estado { get; set; }
}

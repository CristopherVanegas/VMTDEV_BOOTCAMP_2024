using System;
using System.Collections.Generic;

namespace ORM.Models;

public partial class Vendedor
{
    public int VendedorId { get; set; }

    public string? VendedorDescripcion { get; set; }

    public string? Estado { get; set; }
}

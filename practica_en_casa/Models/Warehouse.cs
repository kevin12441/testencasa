using System;
using System.Collections.Generic;

namespace practica_en_casa.Models;

public partial class Warehouse
{
    public int Id { get; set; }

    public string WarehouseName { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

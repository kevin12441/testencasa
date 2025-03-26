﻿using System;
using System.Collections.Generic;

namespace practica_en_casa.Models;

public partial class Brand
{
    public int Id { get; set; }

    public string BrandName { get; set; } = null!;

    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

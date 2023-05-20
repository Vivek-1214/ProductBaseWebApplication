using System;
using System.Collections.Generic;

namespace ProductBaseWebApplication.DAL;

public partial class ProductList
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Color { get; set; }

    public int? Prices { get; set; }
}

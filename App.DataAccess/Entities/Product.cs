using System;
using System.Collections.Generic;

namespace App.DataAccess.Entities;

public partial class Product
{
    public Guid ProductId { get; set; }

    public string? ProductName { get; set; }
}

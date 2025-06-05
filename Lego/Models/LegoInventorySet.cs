using System;
using System.Collections.Generic;

namespace Lego.Models;

public partial class LegoInventorySet
{
    public int InventoryId { get; set; }

    public string SetNum { get; set; } = null!;

    public int Quantity { get; set; }
}

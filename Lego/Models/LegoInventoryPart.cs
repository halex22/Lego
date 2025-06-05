using System;
using System.Collections.Generic;
using System.Drawing;

namespace Lego.Models;

public partial class LegoInventoryPart
{
    public int InventoryId { get; set; }

    public string PartNum { get; set; } = null!;

    public int ColorId { get; set; }
    public LegoColor Color { get; set; }

    public int Quantity { get; set; }

    public bool IsSpare { get; set; }
}

using System;
using System.Collections.Generic;

namespace Lego.Models;

public partial class LegoInventory
{
    public int Id { get; set; }

    public int Version { get; set; }

    public string SetNum { get; set; } = null!;
}

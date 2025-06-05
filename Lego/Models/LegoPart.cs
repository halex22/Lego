using System;
using System.Collections.Generic;

namespace Lego.Models;

public partial class LegoPart
{
    public string PartNum { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int PartCatId { get; set; }
}

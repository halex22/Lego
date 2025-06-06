using System;
using System.Collections.Generic;

namespace Lego.model;

public partial class LegoPartCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<LegoPart> LegoParts { get; set; } = new List<LegoPart>();
}

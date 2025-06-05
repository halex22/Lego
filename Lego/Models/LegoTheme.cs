using System;
using System.Collections.Generic;

namespace Lego.Models;

public partial class LegoTheme
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? ParentId { get; set; }
}

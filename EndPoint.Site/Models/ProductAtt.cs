using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class ProductAtt
{
    public int ProductAttId { get; set; }

    public int? ProductId { get; set; }

    public int? AttId { get; set; }

    public string? Value { get; set; }

    public virtual Att? Att { get; set; }

    public virtual Product? Product { get; set; }
}

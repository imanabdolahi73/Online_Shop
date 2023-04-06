using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class Color
{
    public int ColorId { get; set; }

    public string? Title { get; set; }

    public string? CategoryTitle { get; set; }

    public string? ColorCode { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}

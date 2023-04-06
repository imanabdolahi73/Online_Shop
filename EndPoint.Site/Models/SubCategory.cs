using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class SubCategory
{
    public int SubCategoryId { get; set; }

    public int? CategoryId { get; set; }

    public string? Title { get; set; }

    public int? Visible { get; set; }

    public string? PhotoAddress { get; set; }

    public virtual ICollection<Att> Atts { get; } = new List<Att>();

    public virtual Category? Category { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}

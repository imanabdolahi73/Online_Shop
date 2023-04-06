using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class Att
{
    public int AttId { get; set; }

    public string? Title { get; set; }

    public int? SubCategoryId { get; set; }

    public virtual ICollection<ProductAtt> ProductAtts { get; } = new List<ProductAtt>();

    public virtual SubCategory? SubCategory { get; set; }
}

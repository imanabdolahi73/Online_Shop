using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? Title { get; set; }

    public int? Visible { get; set; }

    public string? PhotoAddress { get; set; }

    public virtual ICollection<SubCategory> SubCategories { get; } = new List<SubCategory>();
}

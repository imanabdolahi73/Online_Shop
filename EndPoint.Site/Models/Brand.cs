using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    public string? Title { get; set; }

    public int? CountryId { get; set; }

    public virtual Country? Country { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}

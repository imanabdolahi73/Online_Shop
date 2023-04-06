using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public Guid? OrderHeaderId { get; set; }

    public int? ProductId { get; set; }

    public string? Title { get; set; }

    public int? Price { get; set; }

    public int? DiscountPercent { get; set; }

    public int? FinalPrice { get; set; }

    public int? Number { get; set; }

    public long? TotalPrice { get; set; }

    public virtual OrderHeader? OrderHeader { get; set; }

    public virtual Product? Product { get; set; }
}

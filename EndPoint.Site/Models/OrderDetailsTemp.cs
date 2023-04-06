using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class OrderDetailsTemp
{
    public int OrderDetailId { get; set; }

    public Guid? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public string? Title { get; set; }

    public int? Price { get; set; }

    public int? DiscountPercent { get; set; }

    public int? FinalPrice { get; set; }

    public int? Number { get; set; }

    public long? TotalPrice { get; set; }
}

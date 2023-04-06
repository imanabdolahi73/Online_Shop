using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class Favourite
{
    public int FavouriteId { get; set; }

    public int? ProductId { get; set; }

    public Guid? CustomerId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}

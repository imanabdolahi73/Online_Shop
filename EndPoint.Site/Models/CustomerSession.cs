using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class CustomerSession
{
    public Guid SessionId { get; set; }

    public Guid? CustomerId { get; set; }

    public DateTime? LoginDateTime { get; set; }

    public DateTime? ExpieryDateTime { get; set; }

    public virtual Customer? Customer { get; set; }
}

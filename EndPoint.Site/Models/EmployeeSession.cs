using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class EmployeeSession
{
    public Guid SessionId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? LoginDateTime { get; set; }

    public DateTime? ExpieryDateTime { get; set; }

    public virtual Employee? Employee { get; set; }
}

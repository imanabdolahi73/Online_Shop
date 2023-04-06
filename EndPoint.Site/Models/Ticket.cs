using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class Ticket
{
    public int TicketId { get; set; }

    public Guid? CustomerId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? DateTime { get; set; }

    public string? Subject { get; set; }

    public string? Status { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<Message> Messages { get; } = new List<Message>();
}

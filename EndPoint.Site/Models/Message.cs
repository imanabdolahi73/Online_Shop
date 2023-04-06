using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class Message
{
    public int MessageId { get; set; }

    public int? TicketId { get; set; }

    public string? Text { get; set; }

    public DateTime? DateTime { get; set; }

    public int? ReadType { get; set; }

    public string? Type { get; set; }

    public virtual Ticket? Ticket { get; set; }
}

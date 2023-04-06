using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Post { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public int? Visible { get; set; }

    public string? ProfilePhotoAddress { get; set; }

    public virtual ICollection<EmployeeSession> EmployeeSessions { get; } = new List<EmployeeSession>();

    public virtual ICollection<OrderHeader> OrderHeaders { get; } = new List<OrderHeader>();

    public virtual ICollection<Ticket> Tickets { get; } = new List<Ticket>();
}

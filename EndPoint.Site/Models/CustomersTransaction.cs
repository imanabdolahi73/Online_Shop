using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class CustomersTransaction
{
    public int TransactionId { get; set; }

    public string? Type { get; set; }

    public string? Title { get; set; }

    public int? EmployeeId { get; set; }

    public Guid? CustomerId { get; set; }

    public DateTime? DateTime { get; set; }

    public long? Amount { get; set; }

    public string? Status { get; set; }

    public long? BalanceInLine { get; set; }

    public virtual Customer? Customer { get; set; }
}

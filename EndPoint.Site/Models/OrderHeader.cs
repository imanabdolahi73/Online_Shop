using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class OrderHeader
{
    public Guid OrderHeaderId { get; set; }

    public Guid? CustomerId { get; set; }

    public int? EmployeeId { get; set; }

    public DateTime? DateTime { get; set; }

    public DateTime? ConfirmAccountantTime { get; set; }

    public int? ConfirmAccountant { get; set; }

    public DateTime? ConfirmOrderTime { get; set; }

    public int? ConfirmOrder { get; set; }

    public DateTime? ConfirmDeliveryTime { get; set; }

    public int? ConfirmDelivery { get; set; }

    public int OrderNumber { get; set; }

    public long? TotalPrice { get; set; }

    public int? DeliveryTime { get; set; }

    public string? DeliveryType { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
}

using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class StarGrade
{
    public int StarGradeId { get; set; }

    public int? ProductId { get; set; }

    public Guid? CustomerId { get; set; }

    public int? StarGrade1 { get; set; }

    public string? StarGradeView { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}

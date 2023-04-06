using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class Survey
{
    public int SurveyId { get; set; }

    public Guid? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public string? Text { get; set; }

    public DateTime? DateTime { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}

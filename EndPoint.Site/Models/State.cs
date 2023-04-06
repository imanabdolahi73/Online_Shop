using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EndPoint.Site.Models;

public partial class State
{
    [DisplayName("کد استان")]
    public int StateId { get; set; }

    [DisplayName("کد کشور")]
    public int CountryId { get; set; }

    [DisplayName("نام استان")]
    public string Name { get; set; } = null!;

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();
}

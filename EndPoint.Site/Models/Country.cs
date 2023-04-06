using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public string? CountryPhotoAddress { get; set; }

    public virtual ICollection<Brand> Brands { get; } = new List<Brand>();

    public virtual ICollection<State> States { get; } = new List<State>();
}

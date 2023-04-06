using System;
using System.Collections.Generic;

namespace EndPoint.Site.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? Title { get; set; }

    public int? SubCategoryId { get; set; }

    public long? Price { get; set; }

    public int? DiscountPercent { get; set; }

    public long? FinalPrice { get; set; }

    public int? BrandId { get; set; }

    public int? ColorId { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public int? Available { get; set; }

    public int? Visible { get; set; }

    public int? StarGrade { get; set; }

    public string? StarGradeView { get; set; }

    public int? Rank { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Color? Color { get; set; }

    public virtual ICollection<Favourite> Favourites { get; } = new List<Favourite>();

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

    public virtual ICollection<ProductAtt> ProductAtts { get; } = new List<ProductAtt>();

    public virtual ICollection<StarGrade> StarGrades { get; } = new List<StarGrade>();

    public virtual SubCategory? SubCategory { get; set; }

    public virtual ICollection<Survey> Surveys { get; } = new List<Survey>();
}

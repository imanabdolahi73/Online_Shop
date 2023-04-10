using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EndPoint.Site.Models;

public partial class Category
{
    [DisplayName("کد دسته بندی")]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "لطفا عنوان را به درستی وارد کنید")]
    [DisplayName("عنوان")]
    public string? Title { get; set; }

    [DisplayName("نمایش")]
    public int? Visible { get; set; }

    [DisplayName("آدرس عکس")]
    public string? PhotoAddress { get; set; }

    public virtual ICollection<SubCategory> SubCategories { get; } = new List<SubCategory>();
}

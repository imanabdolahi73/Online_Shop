using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EndPoint.Site.Models;

public partial class Customer
{
    [DisplayName("کد مشتری")]
    public Guid CustomerId { get; set; }

    [DisplayName("نام")]
    public string? FirstName { get; set; }

    [DisplayName("نام خانوادگی")]
    public string? LastName { get; set; }

    [DisplayName("موبایل")]
    public string? Phone { get; set; }

    [DisplayName("ایمیل")]
    public string? Email { get; set; }

    [DisplayName("آدرس")]
    public string? Address { get; set; }

    [DisplayName("جنسیت")]
    public string? Gender { get; set; }

    [DisplayName("استار گرید")]
    public int? StarGrade { get; set; }

    [DisplayName("وضعیت")]
    public string? Status { get; set; }

    [DisplayName("مانده حساب")]
    public long? Balance { get; set; }

    [DisplayName("آدرس عکس")]
    public string? ProfilePhotoAddress { get; set; }

    [DisplayName("نام کاربری")]
    public string? UserName { get; set; }

    [DisplayName("گذرواژه")]
    public string? Password { get; set; }

    [DisplayName("نمایش")]
    public int? Visible { get; set; }

    [DisplayName("کد استان")]
    public int? StateId { get; set; }

    public virtual ICollection<CustomerSession> CustomerSessions { get; } = new List<CustomerSession>();

    public virtual ICollection<CustomersTransaction> CustomersTransactions { get; } = new List<CustomersTransaction>();

    public virtual ICollection<Favourite> Favourites { get; } = new List<Favourite>();

    public virtual ICollection<OrderHeader> OrderHeaders { get; } = new List<OrderHeader>();

    public virtual ICollection<StarGrade> StarGrades { get; } = new List<StarGrade>();

    public virtual State? State { get; set; }

    public virtual ICollection<Survey> Surveys { get; } = new List<Survey>();

    public virtual ICollection<Ticket> Tickets { get; } = new List<Ticket>();
}

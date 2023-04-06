using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EndPoint.Site.Models;

public partial class WebShopDbContext : DbContext
{
    public WebShopDbContext()
    {
    }

    public WebShopDbContext(DbContextOptions<WebShopDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Att> Atts { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Color> Colors { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerSession> CustomerSessions { get; set; }

    public virtual DbSet<CustomersTransaction> CustomersTransactions { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeSession> EmployeeSessions { get; set; }

    public virtual DbSet<Favourite> Favourites { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderDetailsExpire> OrderDetailsExpires { get; set; }

    public virtual DbSet<OrderDetailsTemp> OrderDetailsTemps { get; set; }

    public virtual DbSet<OrderHeader> OrderHeaders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAtt> ProductAtts { get; set; }

    public virtual DbSet<StarGrade> StarGrades { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<SubCategory> SubCategories { get; set; }

    public virtual DbSet<Survey> Surveys { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-IQ90JPA;Database=Web_ShopDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Att>(entity =>
        {
            entity.Property(e => e.AttId).HasColumnName("AttID");
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

            entity.HasOne(d => d.SubCategory).WithMany(p => p.Atts)
                .HasForeignKey(d => d.SubCategoryId)
                .HasConstraintName("FK_Atts_SubCategories");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");

            entity.HasOne(d => d.Country).WithMany(p => p.Brands)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Brands_Countries");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
        });

        modelBuilder.Entity<Color>(entity =>
        {
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Countrie__10D160BF4CBF777F");

            entity.Property(e => e.CountryId)
                .ValueGeneratedNever()
                .HasColumnName("CountryID");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerID");
            entity.Property(e => e.StateId).HasColumnName("StateID");

            entity.HasOne(d => d.State).WithMany(p => p.Customers)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_Customers_States");
        });

        modelBuilder.Entity<CustomerSession>(entity =>
        {
            entity.HasKey(e => e.SessionId);

            entity.Property(e => e.SessionId)
                .ValueGeneratedNever()
                .HasColumnName("SessionID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ExpieryDateTime).HasColumnType("datetime");
            entity.Property(e => e.LoginDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerSessions)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CustomerSessions_Customers");
        });

        modelBuilder.Entity<CustomersTransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId);

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomersTransactions)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_CustomersTransactions_Customers");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
        });

        modelBuilder.Entity<EmployeeSession>(entity =>
        {
            entity.HasKey(e => e.SessionId);

            entity.Property(e => e.SessionId)
                .ValueGeneratedNever()
                .HasColumnName("SessionID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.ExpieryDateTime).HasColumnType("datetime");
            entity.Property(e => e.LoginDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeSessions)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_EmployeeSessions_Employees");
        });

        modelBuilder.Entity<Favourite>(entity =>
        {
            entity.Property(e => e.FavouriteId).HasColumnName("FavouriteID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Favourites)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Favourites_Customers");

            entity.HasOne(d => d.Product).WithMany(p => p.Favourites)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Favourites_Products");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.Ticket).WithMany(p => p.Messages)
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK_Messages_Tickets");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
            entity.Property(e => e.OrderHeaderId).HasColumnName("OrderHeaderID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.OrderHeader).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderHeaderId)
                .HasConstraintName("FK_OrderDetails_OrderHeaders");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_OrderDetails_Products");
        });

        modelBuilder.Entity<OrderDetailsExpire>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId);

            entity.ToTable("OrderDetailsExpire");

            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<OrderDetailsTemp>(entity =>
        {
            entity.HasKey(e => e.OrderDetailId);

            entity.ToTable("OrderDetailsTemp");

            entity.Property(e => e.OrderDetailId).HasColumnName("OrderDetailID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<OrderHeader>(entity =>
        {
            entity.Property(e => e.OrderHeaderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderHeaderID");
            entity.Property(e => e.ConfirmAccountantTime).HasColumnType("datetime");
            entity.Property(e => e.ConfirmDeliveryTime).HasColumnType("datetime");
            entity.Property(e => e.ConfirmOrderTime).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.OrderNumber).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Customer).WithMany(p => p.OrderHeaders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_OrderHeaders_Customers");

            entity.HasOne(d => d.Employee).WithMany(p => p.OrderHeaders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_OrderHeaders_Employees");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.ColorId).HasColumnName("ColorID");
            entity.Property(e => e.ReleaseDate).HasColumnType("datetime");
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");

            entity.HasOne(d => d.Brand).WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_Products_Brands");

            entity.HasOne(d => d.Color).WithMany(p => p.Products)
                .HasForeignKey(d => d.ColorId)
                .HasConstraintName("FK_Products_Colors");

            entity.HasOne(d => d.SubCategory).WithMany(p => p.Products)
                .HasForeignKey(d => d.SubCategoryId)
                .HasConstraintName("FK_Products_SubCategories");
        });

        modelBuilder.Entity<ProductAtt>(entity =>
        {
            entity.Property(e => e.ProductAttId).HasColumnName("ProductAttID");
            entity.Property(e => e.AttId).HasColumnName("AttID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Att).WithMany(p => p.ProductAtts)
                .HasForeignKey(d => d.AttId)
                .HasConstraintName("FK_ProductAtts_Atts");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductAtts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductAtts_Products");
        });

        modelBuilder.Entity<StarGrade>(entity =>
        {
            entity.Property(e => e.StarGradeId).HasColumnName("StarGradeID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.StarGrade1).HasColumnName("StarGrade");

            entity.HasOne(d => d.Customer).WithMany(p => p.StarGrades)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_StarGrades_Customers");

            entity.HasOne(d => d.Product).WithMany(p => p.StarGrades)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_StarGrades_Products");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__States__C3BA3B5A9F1DDDB2");

            entity.Property(e => e.StateId)
                .ValueGeneratedNever()
                .HasColumnName("StateID");
            entity.Property(e => e.CountryId).HasColumnName("CountryID");
            entity.Property(e => e.Name).HasMaxLength(128);

            entity.HasOne(d => d.Country).WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_States_Countries");
        });

        modelBuilder.Entity<SubCategory>(entity =>
        {
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

            entity.HasOne(d => d.Category).WithMany(p => p.SubCategories)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_SubCategories_Categories");
        });

        modelBuilder.Entity<Survey>(entity =>
        {
            entity.ToTable("Survey");

            entity.Property(e => e.SurveyId).HasColumnName("SurveyID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Surveys)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Survey_Customers");

            entity.HasOne(d => d.Product).WithMany(p => p.Surveys)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Survey_Products");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.HasOne(d => d.Customer).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK_Tickets_Customers");

            entity.HasOne(d => d.Employee).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Tickets_Employees");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

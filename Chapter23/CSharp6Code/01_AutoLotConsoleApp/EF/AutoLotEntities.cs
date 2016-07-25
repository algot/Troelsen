namespace _01_AutoLotConsoleApp.EF
{
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  public partial class AutoLotEntities : DbContext
  {
    public AutoLotEntities()
        : base("name=AutoLotConnection")
    {
    }

    public virtual DbSet<CreditRisk> CreditRisks { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Car> Cars { get; set; }
    public virtual DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<CreditRisk>()
          .Property(e => e.FirstName)
          .IsUnicode(false);

      modelBuilder.Entity<CreditRisk>()
          .Property(e => e.LastName)
          .IsUnicode(false);

      modelBuilder.Entity<Customer>()
          .Property(e => e.FirstName)
          .IsUnicode(false);

      modelBuilder.Entity<Customer>()
          .Property(e => e.LastName)
          .IsUnicode(false);

      modelBuilder.Entity<Customer>()
          .HasMany(e => e.Orders)
          .WithRequired(e => e.Customer)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Car>()
          .Property(e => e.Make)
          .IsUnicode(false);

      modelBuilder.Entity<Car>()
          .Property(e => e.Color)
          .IsUnicode(false);

      modelBuilder.Entity<Car>()
          .Property(e => e.CarNickName)
          .IsFixedLength();

      modelBuilder.Entity<Car>()
          .HasMany(e => e.Orders)
          .WithRequired(e => e.Car)
          .WillCascadeOnDelete(false);
    }
  }
}

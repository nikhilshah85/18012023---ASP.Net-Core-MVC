using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace shoppingAPP_MVC_EFCore.Models.EF;

public partial class ShoppingDbContext : DbContext
{
    public ShoppingDbContext()
    {
    }

    public ShoppingDbContext(DbContextOptions<ShoppingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;database=shoppingDB;integrated security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OId).HasName("PK__Orders__C2FECB3B1ECFAF5F");

            entity.Property(e => e.OId)
                .ValueGeneratedNever()
                .HasColumnName("oId");
            entity.Property(e => e.OAmount).HasColumnName("oAmount");
            entity.Property(e => e.ODate)
                .HasColumnType("date")
                .HasColumnName("oDate");
            entity.Property(e => e.OPid).HasColumnName("oPID");
            entity.Property(e => e.OStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("oStatus");

            entity.HasOne(d => d.OP).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OPid)
                .HasConstraintName("fk_oPID");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("PK__products__DD36D562F9231A4C");

            entity.ToTable("products");

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("pId");
            entity.Property(e => e.PCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pCategory");
            entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");
            entity.Property(e => e.PMinimumOrderQty).HasColumnName("pMinimumOrderQty");
            entity.Property(e => e.PName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pName");
            entity.Property(e => e.PPrice).HasColumnName("pPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

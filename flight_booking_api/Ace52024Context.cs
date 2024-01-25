using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace flightmvc.Models;

public partial class Ace52024Context : DbContext
{
    public Ace52024Context()
    {
    }

    public Ace52024Context(DbContextOptions<Ace52024Context> options)
        : base(options)
    {
    }

    

    public virtual DbSet<BookingIvy> BookingIvies { get; set; }

    
    public virtual DbSet<CustomerIvy> CustomerIvies { get; set; }

   
    public virtual DbSet<FlightsIvy> FlightsIvies { get; set; }

    
    public virtual DbSet<IvyUser> IvyUsers { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DEVSQL.Corp.local;Database=ACE 5- 2024;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        

        modelBuilder.Entity<BookingIvy>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__BookingI__73951AED1E7E9383");

            entity.ToTable("BookingIvy");

            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.Destination)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Source)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TotalCost).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Customer).WithMany(p => p.BookingIvies)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__BookingIv__Custo__12E8C319");

            entity.HasOne(d => d.Flight).WithMany(p => p.BookingIvies)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK__BookingIv__Fligh__11F49EE0");
        });

       

        modelBuilder.Entity<CustomerIvy>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D8FC176181");

            entity.ToTable("CustomerIvy");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        

        modelBuilder.Entity<FlightsIvy>(entity =>
        {
            entity.HasKey(e => e.FlightId).HasName("PK__FlightsI__8A9E14EEE5DD4198");

            entity.ToTable("FlightsIvy");

            entity.Property(e => e.FlightId).ValueGeneratedNever();
            entity.Property(e => e.Destination)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FlightName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

       
        modelBuilder.Entity<IvyUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IvyUser__3214EC07998AFC08");

            entity.ToTable("IvyUser");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

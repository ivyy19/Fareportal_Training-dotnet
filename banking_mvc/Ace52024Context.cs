using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace mvcfirst.Models;

public partial class Ace52024Context : DbContext
{
    public Ace52024Context()
    {
    }

    public Ace52024Context(DbContextOptions<Ace52024Context> options)
        : base(options)
    {
    }

    
    public virtual DbSet<Sbaccountivy> Sbaccountivies { get; set; }

    

    public virtual DbSet<Sbtransactionsivy> Sbtransactionsivies { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DEVSQL.Corp.local;Database=ACE 5- 2024;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        

        modelBuilder.Entity<Sbaccountivy>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__SBAccoun__BE2ACD6E2498FE1A");

            entity.ToTable("SBAccountivy");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        

        modelBuilder.Entity<Sbtransactionsivy>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__SBTransa__55433A6B6B7B7F8E");

            entity.ToTable("SBTransactionsivy");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.Sbtransactionsivies)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("FK__SBTransac__Accou__6AEFE058");
        });

       

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

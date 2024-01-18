using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace mymvc.Models;

public partial class Ace52024Context : DbContext
{
    public Ace52024Context()
    {
    }

    public Ace52024Context(DbContextOptions<Ace52024Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AditiBookingDetail> AditiBookingDetails { get; set; }

    public virtual DbSet<AditiCustomer> AditiCustomers { get; set; }

    public virtual DbSet<AditiFlight> AditiFlights { get; set; }

    public virtual DbSet<AditiLogin> AditiLogins { get; set; }

    public virtual DbSet<AditiRegister> AditiRegisters { get; set; }

    public virtual DbSet<AditiSbaccount> AditiSbaccounts { get; set; }

    public virtual DbSet<AditiSbtransaction> AditiSbtransactions { get; set; }

    public virtual DbSet<Anushkasbaccount> Anushkasbaccounts { get; set; }

    public virtual DbSet<Aryan> Aryans { get; set; }

    public virtual DbSet<AryanSbaccount> AryanSbaccounts { get; set; }

    public virtual DbSet<AryanSbtransaction> AryanSbtransactions { get; set; }

    public virtual DbSet<AryanUser> AryanUsers { get; set; }

    public virtual DbSet<Avika> Avikas { get; set; }

    public virtual DbSet<BhaveshSbaccount> BhaveshSbaccounts { get; set; }

    public virtual DbSet<BhaveshSbtransaction> BhaveshSbtransactions { get; set; }

    public virtual DbSet<BookingDetailsVai> BookingDetailsVais { get; set; }

    public virtual DbSet<CustomersVai> CustomersVais { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employeetable> Employeetables { get; set; }

    public virtual DbSet<FlightsVai> FlightsVais { get; set; }

    public virtual DbSet<Fpstudent> Fpstudents { get; set; }

    public virtual DbSet<Harshit> Harshits { get; set; }

    public virtual DbSet<Hetal> Hetals { get; set; }

    public virtual DbSet<HetalBooking> HetalBookings { get; set; }

    public virtual DbSet<HetalCustomer> HetalCustomers { get; set; }

    public virtual DbSet<HetalFlight> HetalFlights { get; set; }

    public virtual DbSet<HetalSbaccount> HetalSbaccounts { get; set; }

    public virtual DbSet<HetalSbtransaction> HetalSbtransactions { get; set; }

    public virtual DbSet<HetalUsertbl> HetalUsertbls { get; set; }

    public virtual DbSet<Ivy> Ivies { get; set; }

    public virtual DbSet<Jayendra> Jayendras { get; set; }

    public virtual DbSet<Jivanshu> Jivanshus { get; set; }

    public virtual DbSet<Kartik> Kartiks { get; set; }

    public virtual DbSet<KartikSbaccount> KartikSbaccounts { get; set; }

    public virtual DbSet<KartikSbtransaction> KartikSbtransactions { get; set; }

    public virtual DbSet<Krina> Krinas { get; set; }

    public virtual DbSet<KrinaSbaccount> KrinaSbaccounts { get; set; }

    public virtual DbSet<KrinaSbtransaction> KrinaSbtransactions { get; set; }

    public virtual DbSet<KrinaUserTable> KrinaUserTables { get; set; }

    public virtual DbSet<KritikaA> KritikaAs { get; set; }

    public virtual DbSet<KritikaBooking> KritikaBookings { get; set; }

    public virtual DbSet<KritikaCustomer> KritikaCustomers { get; set; }

    public virtual DbSet<KritikaFlight> KritikaFlights { get; set; }

    public virtual DbSet<KritikaSbaccount> KritikaSbaccounts { get; set; }

    public virtual DbSet<KritikaSbtransaction> KritikaSbtransactions { get; set; }

    public virtual DbSet<KritikaUser> KritikaUsers { get; set; }

    public virtual DbSet<Kush> Kushes { get; set; }

    public virtual DbSet<KushSba> KushSbas { get; set; }

    public virtual DbSet<KushSbt> KushSbts { get; set; }

    public virtual DbSet<LoginJivanshu> LoginJivanshus { get; set; }

    public virtual DbSet<Muskan> Muskans { get; set; }

    public virtual DbSet<Pragati> Pragatis { get; set; }

    public virtual DbSet<PragatiEmp> PragatiEmps { get; set; }

    public virtual DbSet<PragatiSbaccount> PragatiSbaccounts { get; set; }

    public virtual DbSet<PragatiSbtransaction> PragatiSbtransactions { get; set; }

    public virtual DbSet<PragatiUsertbl> PragatiUsertbls { get; set; }

    public virtual DbSet<Prerna> Prernas { get; set; }

    public virtual DbSet<PrernaNew> PrernaNews { get; set; }

    public virtual DbSet<PrernaSbaccount> PrernaSbaccounts { get; set; }

    public virtual DbSet<PrernaSbtransaction> PrernaSbtransactions { get; set; }

    public virtual DbSet<PrernaSingh> PrernaSinghs { get; set; }

    public virtual DbSet<PriyankaSbaccount> PriyankaSbaccounts { get; set; }

    public virtual DbSet<PriyankaSbtransaction> PriyankaSbtransactions { get; set; }

    public virtual DbSet<SanchitSbaccount> SanchitSbaccounts { get; set; }

    public virtual DbSet<SanchitSbtransaction> SanchitSbtransactions { get; set; }

    public virtual DbSet<SanchitUsertbl> SanchitUsertbls { get; set; }

    public virtual DbSet<Sandhya> Sandhyas { get; set; }

    public virtual DbSet<SandhyaSbaccount> SandhyaSbaccounts { get; set; }

    public virtual DbSet<SandhyaSbtransaction> SandhyaSbtransactions { get; set; }

    public virtual DbSet<SandhyasSbaccount> SandhyasSbaccounts { get; set; }

    public virtual DbSet<Sanskriti> Sanskritis { get; set; }

    public virtual DbSet<SanskritiSbaccount> SanskritiSbaccounts { get; set; }

    public virtual DbSet<SanskritiSbtransaction> SanskritiSbtransactions { get; set; }

    public virtual DbSet<SanskritiUserTable> SanskritiUserTables { get; set; }

    public virtual DbSet<SbAccountv> SbAccountvs { get; set; }

    public virtual DbSet<SbTransactionv> SbTransactionvs { get; set; }

    public virtual DbSet<SbaccAvi> SbaccAvis { get; set; }

    public virtual DbSet<SbaccountJay> SbaccountJays { get; set; }

    public virtual DbSet<SbaccountJivanshu> SbaccountJivanshus { get; set; }

    public virtual DbSet<SbaccountM> SbaccountMs { get; set; }

    public virtual DbSet<Sbaccountivy> Sbaccountivies { get; set; }

    public virtual DbSet<SbtransacAvi> SbtransacAvis { get; set; }

    public virtual DbSet<Sbtransaction> Sbtransactions { get; set; }

    public virtual DbSet<SbtransactionJay> SbtransactionJays { get; set; }

    public virtual DbSet<SbtransactionM> SbtransactionMs { get; set; }

    public virtual DbSet<SbtransactionsJivanshu> SbtransactionsJivanshus { get; set; }

    public virtual DbSet<Sbtransactionsivy> Sbtransactionsivies { get; set; }

    public virtual DbSet<Shivya> Shivyas { get; set; }

    public virtual DbSet<Stud> Studs { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Student007> Student007s { get; set; }

    public virtual DbSet<Student1> Students1 { get; set; }

    public virtual DbSet<Student27> Student27s { get; set; }

    public virtual DbSet<Studentss> Studentsses { get; set; }

    public virtual DbSet<Studenttt> Studenttts { get; set; }

    public virtual DbSet<Studentttt> Studentttts { get; set; }

    public virtual DbSet<Suhasini> Suhasinis { get; set; }

    public virtual DbSet<SuhasiniSbaccount> SuhasiniSbaccounts { get; set; }

    public virtual DbSet<SuhasiniSbtransaction> SuhasiniSbtransactions { get; set; }

    public virtual DbSet<Suhasininew> Suhasininews { get; set; }

    public virtual DbSet<Suhasinitable> Suhasinitables { get; set; }

    public virtual DbSet<Suhasiniusertbl> Suhasiniusertbls { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserTable> UserTables { get; set; }

    public virtual DbSet<UserVai> UserVais { get; set; }

    public virtual DbSet<Usertbl> Usertbls { get; set; }

    public virtual DbSet<UsertblIvy> UsertblIvies { get; set; }

    public virtual DbSet<UsertblJay> UsertblJays { get; set; }

    public virtual DbSet<UsertblKartik> UsertblKartiks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DEVSQL.Corp.local;Database=ACE 5- 2024;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AditiBookingDetail>(entity =>
        {
            entity.HasKey(e => e.FlightId).HasName("PK__AditiBoo__8A9E14EE05872DF5");

            entity.Property(e => e.BookingDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AditiCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__AditiCus__A4AE64D81DEAA674");

            entity.ToTable("AditiCustomer");

            entity.Property(e => e.CustomerLocation)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AditiFlight>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Destination)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FlightId).ValueGeneratedOnAdd();
            entity.Property(e => e.FlightName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AditiLogin>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK__AditiLog__C9F284574DAB2E24");

            entity.ToTable("AditiLogin");

            entity.Property(e => e.UserName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AditiRegister>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK__AditiReg__C9F28457ADD5E07B");

            entity.ToTable("AditiRegister");

            entity.Property(e => e.UserName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UserEmail)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AditiSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__AditiSBA__BE2ACD6EA72C7783");

            entity.ToTable("AditiSBAccount");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CustomerAdress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AditiSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__AditiSBT__55433A6B27AA90FF");

            entity.ToTable("AditiSBTransaction");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Anushkasbaccount>(entity =>
        {
            entity.HasKey(e => e.Accnum).HasName("PK__Anushkas__454A552C3FD2D95D");

            entity.Property(e => e.Accnum).ValueGeneratedNever();
            entity.Property(e => e.Yourname)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Aryan>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__aryan__DDDFDD36A8A3380C");

            entity.ToTable("aryan");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<AryanSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__AryanSBA__BE2ACD6EFE99BFC6");

            entity.ToTable("AryanSBAccount");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AryanSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__AryanSBT__55433A6B71704635");

            entity.ToTable("AryanSBTransaction");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.AryanSbtransactions)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("FK__AryanSBTr__Accou__29221CFB");
        });

        modelBuilder.Entity<AryanUser>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Avika>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__avika__DDDFDD36C4D1AF1A");

            entity.ToTable("avika");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<BhaveshSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__Bhavesh___BE2ACD6ED88BC83B");

            entity.ToTable("Bhavesh_SBAccount");

            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BhaveshSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Bhavesh___55433A6BB815F1BA");

            entity.ToTable("Bhavesh_SBTransaction");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.BhaveshSbtransactions)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("FK__Bhavesh_S__Accou__7EF6D905");
        });

        modelBuilder.Entity<BookingDetailsVai>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__BookingD__73951AED67745464");

            entity.ToTable("BookingDetailsVai");

            entity.Property(e => e.BookingId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FlightId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Customer).WithMany(p => p.BookingDetailsVais)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__BookingDe__Custo__6319B466");

            entity.HasOne(d => d.Flight).WithMany(p => p.BookingDetailsVais)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("FK__BookingDe__Fligh__6225902D");
        });

        modelBuilder.Entity<CustomersVai>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D8F96D97FB");

            entity.ToTable("CustomersVai");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CustName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Loaction)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__employee__DDDFDD361B1D6E6A");

            entity.ToTable("employee");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Employeetable>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__Employee__C1971B53BF967D13");

            entity.ToTable("Employeetable");

            entity.Property(e => e.Eid).ValueGeneratedNever();
            entity.Property(e => e.Ename)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<FlightsVai>(entity =>
        {
            entity.HasKey(e => e.FlightId).HasName("PK__FlightsV__8A9E14EE1BBE23EC");

            entity.ToTable("FlightsVai");

            entity.Property(e => e.FlightId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dest)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Fname)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Src)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Fpstudent>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Fpstuden__DDDFDD363121B9DB");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Harshit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__harshit__3213E83FAA22F92F");

            entity.ToTable("harshit");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("first_name");
        });

        modelBuilder.Entity<Hetal>(entity =>
        {
            entity.HasKey(e => e.Sid);

            entity.ToTable("Hetal");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("SID");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("name");
        });

        modelBuilder.Entity<HetalBooking>(entity =>
        {
            entity.HasKey(e => e.BookingId);

            entity.Property(e => e.BookingId).HasColumnName("BookingID");
            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.FlightId).HasColumnName("FlightID");

            entity.HasOne(d => d.Customer).WithMany(p => p.HetalBookings)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HetalBookings_HetalCustomers");

            entity.HasOne(d => d.Flight).WithMany(p => p.HetalBookings)
                .HasForeignKey(d => d.FlightId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HetalBookings_HetalFlights");
        });

        modelBuilder.Entity<HetalCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId);

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName).HasMaxLength(50);
            entity.Property(e => e.Location).HasMaxLength(50);
        });

        modelBuilder.Entity<HetalFlight>(entity =>
        {
            entity.HasKey(e => e.FlightId);

            entity.Property(e => e.FlightId).HasColumnName("FlightID");
            entity.Property(e => e.Airline).HasMaxLength(30);
            entity.Property(e => e.Destination).HasMaxLength(50);
            entity.Property(e => e.FlightName).HasMaxLength(15);
            entity.Property(e => e.Source).HasMaxLength(50);
        });

        modelBuilder.Entity<HetalSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNo);

            entity.ToTable("HetalSBAccount");

            entity.Property(e => e.CustomerAddress).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(50);
        });

        modelBuilder.Entity<HetalSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId);

            entity.ToTable("HetalSBTransaction");

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionType).HasMaxLength(15);
        });

        modelBuilder.Entity<HetalUsertbl>(entity =>
        {
            entity.HasKey(e => e.Email);

            entity.ToTable("HetalUsertbl");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Ivy>(entity =>
        {
            entity.HasKey(e => e.Siiid).HasName("PK__studentt__3DBE29A1E0962EC7");

            entity.ToTable("ivy");

            entity.Property(e => e.Siiid)
                .ValueGeneratedNever()
                .HasColumnName("siiid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Jayendra>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Jayendra__AA2FFBE5513A081B");

            entity.ToTable("Jayendra");

            entity.Property(e => e.PersonId).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Jivanshu>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__jivanshu__D9509F6DF8E8E366");

            entity.ToTable("jivanshu");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.Doj).HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ename");
        });

        modelBuilder.Entity<Kartik>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__kartik__CA195950483E7AEB");

            entity.ToTable("kartik");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("SId");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("dob");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SName");
        });

        modelBuilder.Entity<KartikSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__KartikSB__BE2ACD6E20127B65");

            entity.ToTable("KartikSBAccount");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KartikSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__KartikSB__55433A6BD3049A65");

            entity.ToTable("KartikSBTransaction");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.KartikSbtransactions)
                .HasForeignKey(d => d.AccountNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__KartikSBT__Accou__12FDD1B2");
        });

        modelBuilder.Entity<Krina>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Krina__DDDFDD36EAC230E4");

            entity.ToTable("Krina");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<KrinaSbaccount>(entity =>
        {
            entity.HasKey(e => e.Accno).HasName("PK__Krina_SB__A472931D58519352");

            entity.ToTable("Krina_SBAccount");

            entity.Property(e => e.Accno)
                .ValueGeneratedNever()
                .HasColumnName("accno");
            entity.Property(e => e.Cname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cname");
            entity.Property(e => e.CurrAddr)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("curr_addr");
            entity.Property(e => e.CurrBal).HasColumnName("curr_bal");
        });

        modelBuilder.Entity<KrinaSbtransaction>(entity =>
        {
            entity.HasKey(e => e.Transid).HasName("PK__Krina_SB__DB1F6ABF0D13ADE4");

            entity.ToTable("Krina_SBTransaction");

            entity.Property(e => e.Transid)
                .ValueGeneratedNever()
                .HasColumnName("transid");
            entity.Property(e => e.Accno).HasColumnName("accno");
            entity.Property(e => e.Amt).HasColumnName("amt");
            entity.Property(e => e.Transdate)
                .HasColumnType("datetime")
                .HasColumnName("transdate");
            entity.Property(e => e.Tt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("tt");

            entity.HasOne(d => d.AccnoNavigation).WithMany(p => p.KrinaSbtransactions)
                .HasForeignKey(d => d.Accno)
                .HasConstraintName("FK__Krina_SBT__accno__41EDCAC5");
        });

        modelBuilder.Entity<KrinaUserTable>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__KrinaUse__AB6E61654567544B");

            entity.ToTable("KrinaUserTable");

            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<KritikaA>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__KritikaA__AF2DBA792D46F755");

            entity.ToTable("KritikaA");

            entity.Property(e => e.EmpId)
                .ValueGeneratedNever()
                .HasColumnName("EmpID");
            entity.Property(e => e.Edept)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EDept");
            entity.Property(e => e.Edoj).HasColumnName("EDoj");
            entity.Property(e => e.Ename)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("EName");
        });

        modelBuilder.Entity<KritikaBooking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__KritikaB__73951AEDAFEFA917");

            entity.Property(e => e.BookingDate).HasColumnType("datetime");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.Customer).WithMany(p => p.KritikaBookings)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("fkc");

            entity.HasOne(d => d.Flight).WithMany(p => p.KritikaBookings)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("fkf");
        });

        modelBuilder.Entity<KritikaCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__KritikaC__A4AE64D8A5D20039");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Loc)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KritikaFlight>(entity =>
        {
            entity.HasKey(e => e.FlightId).HasName("PK__KritikaF__8A9E14EE9DB2982D");

            entity.Property(e => e.Airline)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Destination)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.FlightName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Source)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KritikaSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__KritikaS__BE2ACD6ED7EFCB04");

            entity.ToTable("KritikaSBAccount");

            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KritikaSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__KritikaS__55433A6B01EC6595");

            entity.ToTable("KritikaSBTransaction");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.Transactiontype)
                .HasMaxLength(15)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.KritikaSbtransactions)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("fka");
        });

        modelBuilder.Entity<KritikaUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__KritikaU__1788CC4C960409D9");

            entity.ToTable("KritikaUser");

            entity.Property(e => e.UserEmail)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UserPassword)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Kush>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__kush__DDDFDD36992B3749");

            entity.ToTable("kush");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<KushSba>(entity =>
        {
            entity.HasKey(e => e.AccNo).HasName("PK__kushSBA__A47197055F427832");

            entity.ToTable("kushSBA");

            entity.Property(e => e.AccNo)
                .ValueGeneratedNever()
                .HasColumnName("accNo");
            entity.Property(e => e.CurrBal).HasColumnName("currBal");
            entity.Property(e => e.CustAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("custAddress");
            entity.Property(e => e.CustName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("custName");
        });

        modelBuilder.Entity<KushSbt>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__kushSBT__DB107FA77FCD876C");

            entity.ToTable("kushSBT");

            entity.Property(e => e.TransId)
                .ValueGeneratedNever()
                .HasColumnName("transId");
            entity.Property(e => e.Accno).HasColumnName("accno");
            entity.Property(e => e.TransDate).HasColumnName("transDate");
            entity.Property(e => e.TransType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("transType");
        });

        modelBuilder.Entity<LoginJivanshu>(entity =>
        {
            entity.HasKey(e => e.EmailAddress).HasName("PK__LoginJiv__20C6DFF46B440FB4");

            entity.ToTable("LoginJivanshu");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.Passsword)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("passsword");
        });

        modelBuilder.Entity<Muskan>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__muskan__D9509F6DAD5D1BEC");

            entity.ToTable("muskan");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.Doj).HasColumnName("doj");
            entity.Property(e => e.Ename)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Pragati>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__pragati__DDDFDD36539475D8");

            entity.ToTable("pragati");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<PragatiEmp>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__pragatiE__D9509F6D677ECB20");

            entity.ToTable("pragatiEmps");

            entity.Property(e => e.Eid)
                .ValueGeneratedNever()
                .HasColumnName("eid");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ename");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<PragatiSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__pragatiS__BE2ACD6E49144D7C");

            entity.ToTable("pragatiSBAccount");

            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PragatiSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__pragatiS__55433A6B89FC3BA5");

            entity.ToTable("pragatiSBTransaction");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.PragatiSbtransactions)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("FK__pragatiSB__Accou__5006DFF2");
        });

        modelBuilder.Entity<PragatiUsertbl>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__pragatiU__A9D105353367834A");

            entity.ToTable("pragatiUsertbl");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Prerna>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Prerna__DDDFDD36204B8DCB");

            entity.ToTable("Prerna");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Salary).HasColumnName("salary");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<PrernaNew>(entity =>
        {
            entity.HasKey(e => e.Studentid);

            entity.ToTable("Prerna_New");

            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.StudentName)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("Student_name");
            entity.Property(e => e.Subject)
                .HasMaxLength(25)
                .IsFixedLength();
        });

        modelBuilder.Entity<PrernaSbaccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PrernaSBAccount");

            entity.Property(e => e.Accno).HasColumnName("accno");
            entity.Property(e => e.Cname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cname");
            entity.Property(e => e.CurrAddress)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("curr_address");
            entity.Property(e => e.CurrBalance)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("curr_balance");
        });

        modelBuilder.Entity<PrernaSbtransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PrernaSBTransactions");

            entity.Property(e => e.Accno).HasColumnName("accno");
            entity.Property(e => e.Amt)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("amt");
            entity.Property(e => e.Transdate).HasColumnName("transdate");
            entity.Property(e => e.Transid).HasColumnName("transid");
            entity.Property(e => e.Transtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("transtype");
        });

        modelBuilder.Entity<PrernaSingh>(entity =>
        {
            entity.HasKey(e => e.SId);

            entity.ToTable("Prerna_Singh");

            entity.Property(e => e.SId).HasColumnName("S_id");
            entity.Property(e => e.SDob).HasColumnName("S_DOB");
            entity.Property(e => e.SName)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("S_name");
            entity.Property(e => e.SSalary).HasColumnName("S_Salary");
            entity.Property(e => e.SSubject)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("S_subject");
        });

        modelBuilder.Entity<PriyankaSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__Priyanka__BE2ACD6E0DCCC692");

            entity.ToTable("PriyankaSBAccount");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PriyankaSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Priyanka__55433A6B0231BAB5");

            entity.ToTable("PriyankaSBTransaction");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.PriyankaSbtransactions)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("FK__PriyankaS__Accou__70A8B9AE");
        });

        modelBuilder.Entity<SanchitSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__sanchitS__BE2ACD6EBB05DA28");

            entity.ToTable("sanchitSBAccount");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SanchitSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__sanchitS__55433A6B258A1B94");

            entity.ToTable("sanchitSBTransaction");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.TransactionType)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SanchitUsertbl>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__SanchitU__A9D105350B9A0BD5");

            entity.ToTable("SanchitUsertbl");

            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sandhya>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Sandhya__DDDFDD36D4582238");

            entity.ToTable("Sandhya");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<SandhyaSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK_SandhyaSBAccount_AccountNumber");

            entity.ToTable("SandhyaSBAccount");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CurrentBalance)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SandhyaSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK_SandhyaSBTransaction_Transactionid");

            entity.ToTable("SandhyaSBTransaction");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.SandhyaSbtransactions)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("FK_SBTransaction_SandhyasSBAccount");
        });

        modelBuilder.Entity<SandhyasSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK_SandhyasSBAccount_Accountnumber");

            entity.ToTable("SandhyasSBAccount");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Sanskriti>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__sanskrit__DDDFDD365FAABCAC");

            entity.ToTable("sanskriti");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<SanskritiSbaccount>(entity =>
        {
            entity.HasKey(e => e.Accno).HasName("PK__SBAccoun__A472931DE837D7A2");

            entity.ToTable("sanskriti_SBAccount");

            entity.Property(e => e.Accno)
                .ValueGeneratedNever()
                .HasColumnName("accno");
            entity.Property(e => e.Cname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cname");
            entity.Property(e => e.CurrAddress)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("curr_address");
            entity.Property(e => e.CurrBalance)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("curr_balance");
        });

        modelBuilder.Entity<SanskritiSbtransaction>(entity =>
        {
            entity.HasKey(e => e.Transid).HasName("PK__SBTransa__DB1F6ABFB65C131A");

            entity.ToTable("sanskriti_SBTransactions");

            entity.Property(e => e.Transid)
                .ValueGeneratedNever()
                .HasColumnName("transid");
            entity.Property(e => e.Accno).HasColumnName("accno");
            entity.Property(e => e.Amt)
                .HasColumnType("decimal(10, 5)")
                .HasColumnName("amt");
            entity.Property(e => e.Transdate).HasColumnName("transdate");
            entity.Property(e => e.Transtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("transtype");

            entity.HasOne(d => d.AccnoNavigation).WithMany(p => p.SanskritiSbtransactions)
                .HasForeignKey(d => d.Accno)
                .HasConstraintName("FK__SBTransac__accno__30C33EC3");
        });

        modelBuilder.Entity<SanskritiUserTable>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__UserDeta__AB6E6165B82B3C68");

            entity.ToTable("sanskriti_UserTable");

            entity.Property(e => e.Email)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Pword)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pword");
            entity.Property(e => e.Uname)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("uname");
        });

        modelBuilder.Entity<SbAccountv>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__SbAccoun__BE2ACD6E3C187E2F");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SbTransactionv>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__SbTransa__55433A6B1F2EEFE1");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.TransactionType)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.SbTransactionvs)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("FK__SbTransac__Accou__44CA3770");
        });

        modelBuilder.Entity<SbaccAvi>(entity =>
        {
            entity.HasKey(e => e.Accnum).HasName("PK__SBAccAvi__E87AAAD1C52485C1");

            entity.ToTable("SBAccAvi");

            entity.Property(e => e.Accnum)
                .ValueGeneratedNever()
                .HasColumnName("accnum");
            entity.Property(e => e.Currbal)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("currbal");
            entity.Property(e => e.Custadd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("custadd");
            entity.Property(e => e.Custname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("custname");
        });

        modelBuilder.Entity<SbaccountJay>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__SBAccoun__BE2ACD6E03996350");

            entity.ToTable("SBAccountJay");

            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SbaccountJivanshu>(entity =>
        {
            entity.HasKey(e => e.Accountnumber).HasName("PK__SBAccoun__01565FCBA0B90134");

            entity.ToTable("SBAccountJivanshu");

            entity.Property(e => e.Accountnumber).ValueGeneratedNever();
            entity.Property(e => e.Currentbalance).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Customeraddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Customername)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SbaccountM>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__SBAccoun__BE2ACD6EF2F6C82C");

            entity.ToTable("SBAccount_m");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(22)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(22)
                .IsUnicode(false);
        });

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

        modelBuilder.Entity<SbtransacAvi>(entity =>
        {
            entity.HasKey(e => e.Transacid).HasName("PK__SBTransa__5F28D08238F200A3");

            entity.ToTable("SBTransacAvi");

            entity.Property(e => e.Transacid).HasColumnName("transacid");
            entity.Property(e => e.Accnumber).HasColumnName("accnumber");
            entity.Property(e => e.Amount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("amount");
            entity.Property(e => e.Transacdate)
                .HasColumnType("datetime")
                .HasColumnName("transacdate");
            entity.Property(e => e.Transactype)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("transactype");

            entity.HasOne(d => d.AccnumberNavigation).WithMany(p => p.SbtransacAvis)
                .HasForeignKey(d => d.Accnumber)
                .HasConstraintName("FK__SBTransac__accnu__28ED12D1");
        });

        modelBuilder.Entity<Sbtransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SBtransaction");

            entity.Property(e => e.AccountNo).HasColumnName("account_no");
            entity.Property(e => e.CurrentBalance).HasColumnName("current_balance");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("customer_address");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("customer_name");
        });

        modelBuilder.Entity<SbtransactionJay>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__SBTransa__55433A6B33440E61");

            entity.ToTable("SBTransactionJay");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrancationType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.SbtransactionJays)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("fk");
        });

        modelBuilder.Entity<SbtransactionM>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__SBTransa__55433A6B7745C23A");

            entity.ToTable("SBTransaction_m");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.SbtransactionMs)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("FK__SBTransac__Accou__2334397B");
        });

        modelBuilder.Entity<SbtransactionsJivanshu>(entity =>
        {
            entity.HasKey(e => e.Transactionsid).HasName("PK__SBTransa__B873AF62B3853943");

            entity.ToTable("SBTransactionsJivanshu");

            entity.Property(e => e.Transactionsid).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Transactiondate).HasColumnType("datetime");
            entity.Property(e => e.Transactiontype)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountnumberNavigation).WithMany(p => p.SbtransactionsJivanshus)
                .HasForeignKey(d => d.Accountnumber)
                .HasConstraintName("FK__SBTransac__Accou__3E1D39E1");
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

        modelBuilder.Entity<Shivya>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__Shivya__DDDFDD363E4C0512");

            entity.ToTable("Shivya");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Stud>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__stud__DDDFDD3692EC07E2");

            entity.ToTable("stud");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__student__DDDFDD3626AAB5A7");

            entity.ToTable("student");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Student007>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__student0__DDDFDD36718934E4");

            entity.ToTable("student007");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Student1>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__students__DDDFDD3690BE49A9");

            entity.ToTable("students");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Student27>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__student2__DDDFDD3652D91A1D");

            entity.ToTable("student27");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Studentss>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__students__DDDFDD36E67FC708");

            entity.ToTable("studentss");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Studenttt>(entity =>
        {
            entity.HasKey(e => e.Sid).HasName("PK__studentt__DDDFDD36046BBB59");

            entity.ToTable("studenttt");

            entity.Property(e => e.Sid)
                .ValueGeneratedNever()
                .HasColumnName("sid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Studentttt>(entity =>
        {
            entity.HasKey(e => e.Siiid).HasName("PK__studentt__3DBE29A1BBC3441F");

            entity.ToTable("studentttt");

            entity.Property(e => e.Siiid)
                .ValueGeneratedNever()
                .HasColumnName("siiid");
            entity.Property(e => e.Dob).HasColumnName("dob");
            entity.Property(e => e.Marks).HasColumnName("marks");
            entity.Property(e => e.Sname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sname");
        });

        modelBuilder.Entity<Suhasini>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK__Suhasini__AF4CE865B4F45413");

            entity.ToTable("Suhasini");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Empname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empname");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<SuhasiniSbaccount>(entity =>
        {
            entity.HasKey(e => e.AccountNumber).HasName("PK__Suhasini__BE2ACD6EB75B66D3");

            entity.ToTable("Suhasini_SBAccount");

            entity.Property(e => e.AccountNumber).ValueGeneratedNever();
            entity.Property(e => e.CurrentBalance).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CustomerAddress)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SuhasiniSbtransaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Suhasini__55433A6B3801BD95");

            entity.ToTable("Suhasini_SBTransaction");

            entity.Property(e => e.TransactionId).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionType)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNumberNavigation).WithMany(p => p.SuhasiniSbtransactions)
                .HasForeignKey(d => d.AccountNumber)
                .HasConstraintName("FK__Suhasini___Accou__59C55456");
        });

        modelBuilder.Entity<Suhasininew>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK__Suhasini__AF4CE865B5D05F55");

            entity.ToTable("Suhasininew");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Empname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empname");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Suhasinitable>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK__Suhasini__AF4CE865DE4625E0");

            entity.ToTable("Suhasinitable");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Empname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("empname");
            entity.Property(e => e.Salary).HasColumnName("salary");
        });

        modelBuilder.Entity<Suhasiniusertbl>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__suhasini__AB6E6165AD115E70");

            entity.ToTable("suhasiniusertbl");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Pw)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pw");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("users");

            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<UserTable>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__UserTabl__A9D10535637D568A");

            entity.ToTable("UserTable");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserVai>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__UserVai__A9D1053584A2DC17");

            entity.ToTable("UserVai");

            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Pass)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usertbl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("usertbls");

            entity.Property(e => e.Email)
                .HasMaxLength(44)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(22)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsertblIvy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UsertblIvy");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsertblJay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UsertblJ__3213E83FD58D334A");

            entity.ToTable("UsertblJay");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
        });

        modelBuilder.Entity<UsertblKartik>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__usertblK__A9D10535D0A5182A");

            entity.ToTable("usertblKartik");

            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

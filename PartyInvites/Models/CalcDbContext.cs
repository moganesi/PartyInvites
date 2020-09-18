using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PartyInvites.Models
{
    public partial class CalcDbContext : DbContext
    {
        public CalcDbContext()
        {
        }

        public CalcDbContext(DbContextOptions<CalcDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Calculations> Calculations { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CalcDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<City>(entity =>
            //{
            //    entity.Property(e => e.CityId)
            //        .HasColumnName("city_Id")
            //        .HasViewColumnName("city_Id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.CountryId)
            //        .HasColumnName("country_id")
            //        .HasViewColumnName("country_id")
            //        .HasMaxLength(10)
            //        .IsFixedLength();

            //    entity.Property(e => e.Lat)
            //        .HasColumnName("lat")
            //        .HasViewColumnName("lat")
            //        .HasColumnType("decimal(7, 4)");

            //    entity.Property(e => e.Lon)
            //        .HasColumnName("lon")
            //        .HasViewColumnName("lon")
            //        .HasColumnType("decimal(7, 4)");

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasViewColumnName("name")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.NameAscii)
            //        .HasColumnName("name_ascii")
            //        .HasViewColumnName("name_ascii")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<Country>(entity =>
            //{
            //    entity.Property(e => e.CountryId)
            //        .HasColumnName("country_Id")
            //        .HasViewColumnName("country_Id")
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Iso2)
            //        .HasColumnName("iso2")
            //        .HasViewColumnName("iso2")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Iso3)
            //        .HasColumnName("iso3")
            //        .HasViewColumnName("iso3")
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Name)
            //        .HasColumnName("name")
            //        .HasViewColumnName("name")
            //        .HasMaxLength(50);
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

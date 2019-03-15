using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ERMS.Models
{
    public partial class ERMSContext : DbContext
    {
        public ERMSContext()
        {
        }

        public ERMSContext(DbContextOptions<ERMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCities> TbCities { get; set; }
        public virtual DbSet<TbEmployee> TbEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=HAMAOUI;Database=ERMS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<TbCities>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK__tbCities__F2D21A966F9FD2FD");

                entity.ToTable("tbCities");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__tbEmploy__7AD04FF18601CBF2");

                entity.ToTable("tbEmployee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Departement)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tareabd.Models
{
    public partial class EscuelaContext : DbContext
    {
        public virtual DbSet<Persona> Persona { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=Escuela;user=root;pwd=;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona);

                entity.ToTable("persona");

                entity.HasIndex(e => e.Rfc)
                    .HasName("rfc")
                    .IsUnique();

                entity.Property(e => e.IdPersona)
                    .HasColumnName("idPersona")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ApellidoMaterno)
                    .HasColumnName("apellido_materno")
                    .HasMaxLength(100);

                entity.Property(e => e.ApellidoPaterno)
                    .HasColumnName("apellido_paterno")
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100);

                entity.Property(e => e.Rfc)
                    .HasColumnName("rfc")
                    .HasMaxLength(100);
            });
        }
    }
}

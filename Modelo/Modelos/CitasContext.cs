using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DI05_Modelo.Modelos;

public partial class CitasContext : DbContext
{
    public CitasContext()
    {
    }

    public CitasContext(DbContextOptions<CitasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AplicacionTratamiento> AplicacionTratamientos { get; set; }

    public virtual DbSet<Cita> Citas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Tratamiento> Tratamientos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=citas;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AplicacionTratamiento>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdTrabajador).HasColumnName("id_trabajador");
            entity.Property(e => e.IdTratamiento).HasColumnName("id_tratamiento");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.AplicacionTratamientos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionTratamientos_Clientes");

            entity.HasOne(d => d.IdTrabajadorNavigation).WithMany(p => p.AplicacionTratamientos)
                .HasForeignKey(d => d.IdTrabajador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionTratamientos_Empleados");

            entity.HasOne(d => d.IdTratamientoNavigation).WithMany(p => p.AplicacionTratamientos)
                .HasForeignKey(d => d.IdTratamiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AplicacionTratamientos_Tratamientos");
        });

        modelBuilder.Entity<Cita>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.FormaPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("forma_pago");
            entity.Property(e => e.Hora).HasColumnName("hora");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdTratamiento).HasColumnName("id_tratamiento");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("observaciones");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Citas_Clientes");

            entity.HasOne(d => d.IdTratamientoNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdTratamiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Citas_Tratamientos");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Dni)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Puesto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("puesto");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Tratamiento>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.Tipo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("tipo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

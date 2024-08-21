using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Reflection.Emit;
namespace CDatos.Contexts
{
    public partial class KeProyectoContext : DbContext
    {
        public KeProyectoContext()
        {
        }

        public KeProyectoContext(DbContextOptions<KeProyectoContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<OrdenDeVenta> OrdenDeVenta { get; set; }
        public virtual DbSet<OrdenDeCompra> OrdenDeCompra { get; set; }
        public virtual DbSet<OrdenDeCompra_Producto> OrdenDeCompra_Producto { get; set; }
        public virtual DbSet<OrdenDeVenta_Producto> OrdenDeVenta_Producto { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Distribuidor> Distribuidor { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=KeProyecto2024;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_PROVINCIA");

                entity.HasMany(e => e.Ciudades)        // Relacion 1:n Provincia-Ciudad #
                .WithOne(e => e.Provincia)
                .HasForeignKey("IdProvincia")
                .IsRequired();
            });

            modelBuilder.Entity<Ciudad>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_CIUDAD");

                entity.HasMany(e => e.Personas)        // Relacion 1:n Ciudad-Persona #
                .WithOne(e => e.Ciudad)
                .HasForeignKey("IdCiudad")
                .IsRequired();

                entity.HasMany(e => e.Distribuidores)        // Relacion 1:n Ciudad-Distribuidor #
                .WithOne(e => e.Ciudad)
                .HasForeignKey("IdCiudad")
                .IsRequired();

                entity.HasMany(e => e.Proveedores)        // Relacion 1:n Ciudad-Proveedoer #
                .WithOne(e => e.Ciudad)
                .HasForeignKey("IdCiudad")
                .IsRequired();
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_PERSONA");
                entity.HasOne(e => e.Cliente)       // Relacion 1:1 Persona-Cliente #
                    .WithOne(e => e.Persona)
                    .HasForeignKey<Cliente>("IdPersona")
                    .IsRequired(false);
                entity.HasOne(e => e.Empleado)      // Relacion 1:1 Persona-Empleado  #
                    .WithOne(e => e.Persona)
                    .HasForeignKey<Empleado>("IdPersona")
                    .IsRequired(false);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_EMPLEADO");

                entity.HasMany(e => e.OrdenesDeVenta)        // Relacion 1:n Empleado-OrdenDeVenta #
                .WithOne(e => e.Empleado)
                .HasForeignKey("IdEmpleado")
                .IsRequired();

                entity.HasMany(e => e.OrdenesDeCompra)        // Relacion 1:n Empleado-OrdenesDeCompra  #
                .WithOne(e => e.Empleado)
                .HasForeignKey("IdEmpleado")
                .IsRequired();
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_SECTOR");

                entity.HasMany(e => e.Empleados)        // Relacion 1:n Sector-Empleado #

                .WithOne(e => e.Sector)
                .HasForeignKey("IdSector")
                .IsRequired();
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_CLIENTE");
                entity.HasMany(e => e.OrdenesDeVenta)        // Relacion 1:n Cliente-OrdenesDeVenta #
                .WithOne(e => e.Cliente)
                .HasForeignKey("IdCliente")
                .IsRequired();
            });

            modelBuilder.Entity<OrdenDeVenta>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_ORDEN_DE_VENTA");
            });

            modelBuilder.Entity<OrdenDeCompra>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_ORDEN_DE_COMPRA");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_FACTURA");

                entity.HasOne(e => e.OrdenDeVenta)       // Relacion 1:1 Factura-OrdenDeVenta #
                    .WithOne(e => e.Factura)
                    .HasForeignKey<OrdenDeVenta>("IdFactura")
                    .IsRequired(false);

                entity.HasOne(e => e.OrdenDeCompra)      // Relacion 1:1 Factura-OrdenDeCompra #
                    .WithOne(e => e.Factura)
                    .HasForeignKey<OrdenDeCompra>("IdFactura")
                    .IsRequired(false);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Id)
                .HasName("PK_ID_PRODUCTO");

                entity.HasMany(e => e.OrdenesDeCompra)
                      .WithMany(e => e.Productos)
                      .UsingEntity<OrdenDeCompra_Producto>(
                        l => l.HasOne<OrdenDeCompra>().WithMany().HasForeignKey(e => e.IdOrdenDeCompra),
                        r => r.HasOne<Producto>().WithMany().HasForeignKey(e => e.IdProducto)); // Relacion n:n entre Producto y OrdenDeCompra *

            });

            modelBuilder.Entity<OrdenDeVenta_Producto>()
                .HasKey(op => op.Id);

            modelBuilder.Entity<OrdenDeVenta_Producto>()
                .HasOne(op => op.OrdenDeVenta)
                .WithMany(ov => ov.OrdenDeVenta_Productos)
                .HasForeignKey(op => op.IdOrdenDeVenta)
                .OnDelete(DeleteBehavior.Restrict); // Evita cascadas en esta relación

            modelBuilder.Entity<OrdenDeVenta_Producto>()
                .HasOne(op => op.Producto)
                .WithMany(p => p.OrdenDeVenta_Productos)
                .HasForeignKey(op => op.IdProducto)
                .OnDelete(DeleteBehavior.Restrict); // Evita cascadas en esta relación

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_PROVEEDOR");

                entity.HasMany(e => e.Productos)        // Relacion 1:n Proveedor-Producto #
                .WithOne(e => e.Proveedor)
                .HasForeignKey("IdProveedor")
                .IsRequired();
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_CATEGORIA");

                entity.HasMany(e => e.Productos)        // Relacion 1:n Categoria-Productos #
                .WithOne(e => e.Categoria)
                .HasForeignKey("IdCategoria")
                .IsRequired();
            });

            modelBuilder.Entity<Distribuidor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_DISTRIBUIDOR");

                entity.HasMany(e => e.OrdenesDeVenta)        // Relacion 1:n Distribuidor-OrdenDeVenta #
                .WithOne(e => e.Distribuidor)
                .HasForeignKey("IdDistribuidor")
                .IsRequired();
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ID_ESTADO");

                entity.HasMany(e => e.OrdenesDeVentas)        // Relacion 1:n Estado-OrdenesDeVentas #
                .WithOne(e => e.Estado)
                .HasForeignKey("IdEstado")
                .IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

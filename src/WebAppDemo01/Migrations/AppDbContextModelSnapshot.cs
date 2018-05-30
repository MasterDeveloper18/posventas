using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAppDemo01.models;

namespace WebAppDemo01.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAppDemo01.models.CatProductos", b =>
                {
                    b.Property<int>("CodigoCatProducto")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescripcionCatProducto");

                    b.Property<string>("NombreCatProducto");

                    b.HasKey("CodigoCatProducto");

                    b.ToTable("CategoriasProductos");
                });

            modelBuilder.Entity("WebAppDemo01.models.CatUsuarios", b =>
                {
                    b.Property<int>("CodigoCatUo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescripcionCatUo");

                    b.Property<string>("NombreCatUo");

                    b.HasKey("CodigoCatUo");

                    b.ToTable("CategoriasUsuarios");
                });

            modelBuilder.Entity("WebAppDemo01.models.Clientes", b =>
                {
                    b.Property<int>("CodigoClientes")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApellidoClientes");

                    b.Property<int?>("ClientesDetalleCodigoCliDetalle");

                    b.Property<string>("Direccion");

                    b.Property<string>("Email");

                    b.Property<string>("FechaNacimiento");

                    b.Property<string>("Imagenes");

                    b.Property<string>("NombreClientes");

                    b.Property<int>("NumDocumento");

                    b.Property<string>("Sexo");

                    b.Property<int>("Telefono");

                    b.Property<string>("TipoDocumento");

                    b.HasKey("CodigoClientes");

                    b.HasIndex("ClientesDetalleCodigoCliDetalle");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("WebAppDemo01.models.ClientesDetalle", b =>
                {
                    b.Property<int>("CodigoCliDetalle")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DetalleCliente");

                    b.Property<string>("NombreCliDetalle");

                    b.Property<string>("TipoCliente");

                    b.HasKey("CodigoCliDetalle");

                    b.ToTable("ClientesDetalle");
                });

            modelBuilder.Entity("WebAppDemo01.models.Productos", b =>
                {
                    b.Property<int>("CodigoProducto")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CatProductosCodigoCatProducto");

                    b.Property<string>("DescripProducto");

                    b.Property<bool>("EstadoProducto");

                    b.Property<string>("ImagenURL");

                    b.Property<string>("NombreProducto");

                    b.Property<decimal>("PreCostoProducto");

                    b.Property<decimal>("PreVentaProducto");

                    b.Property<bool>("ProductoEnExistencia");

                    b.Property<bool>("ProductoEnOferta");

                    b.HasKey("CodigoProducto");

                    b.HasIndex("CatProductosCodigoCatProducto");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("WebAppDemo01.models.Proveedores", b =>
                {
                    b.Property<int>("CodigoProveedores")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CargoContacto");

                    b.Property<string>("Direccion");

                    b.Property<string>("Email");

                    b.Property<string>("ImagenURL");

                    b.Property<string>("NombreContacto");

                    b.Property<string>("NombreProveedor");

                    b.Property<string>("Notas");

                    b.Property<bool>("ProveedoresInactivos");

                    b.Property<int>("Telefono");

                    b.HasKey("CodigoProveedores");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("WebAppDemo01.models.Usuarios", b =>
                {
                    b.Property<int>("CodigoUsuario")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApellidoUsuario");

                    b.Property<int?>("CatUsuariosCodigoCatUo");

                    b.Property<string>("Contraseña");

                    b.Property<string>("ImagenUsuarioURL");

                    b.Property<bool>("ListaNegra");

                    b.Property<string>("NombreUsuario");

                    b.Property<string>("UserName");

                    b.Property<bool>("UsuariosInactivos");

                    b.Property<string>("fechacreacion");

                    b.HasKey("CodigoUsuario");

                    b.HasIndex("CatUsuariosCodigoCatUo");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("WebAppDemo01.models.Clientes", b =>
                {
                    b.HasOne("WebAppDemo01.models.ClientesDetalle", "ClientesDetalle")
                        .WithMany("Clientes")
                        .HasForeignKey("ClientesDetalleCodigoCliDetalle");
                });

            modelBuilder.Entity("WebAppDemo01.models.Productos", b =>
                {
                    b.HasOne("WebAppDemo01.models.CatProductos", "CatProductos")
                        .WithMany("Productos")
                        .HasForeignKey("CatProductosCodigoCatProducto");
                });

            modelBuilder.Entity("WebAppDemo01.models.Usuarios", b =>
                {
                    b.HasOne("WebAppDemo01.models.CatUsuarios", "CatUsuarios")
                        .WithMany("Usuarios")
                        .HasForeignKey("CatUsuariosCodigoCatUo");
                });
        }
    }
}

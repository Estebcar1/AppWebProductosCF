﻿// <auto-generated />
using System;
using AppWebProductosCF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppWebProductosCF.Migrations
{
    [DbContext(typeof(AppWebProductosCFContext))]
    [Migration("20190905142550_categoria")]
    partial class categoria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppWebProductosCF.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255);

                    b.Property<bool?>("Estado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("CategoriaID");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("AppWebProductosCF.Models.Producto", b =>
                {
                    b.Property<int>("ProductoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaID");

                    b.Property<string>("Codigo")
                        .HasMaxLength(64);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255);

                    b.Property<bool?>("Estado");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Precio_venta");

                    b.Property<int>("Stock");

                    b.HasKey("ProductoID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("AppWebProductosCF.Models.Producto", b =>
                {
                    b.HasOne("AppWebProductosCF.Models.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
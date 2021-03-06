﻿// <auto-generated />
using System;
using ExemplosPadrõesProjeto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExemplosPadroesProjeto.Migrations
{
    [DbContext(typeof(ResidenciaContext))]
    [Migration("20190410193759_Gotico")]
    partial class Gotico
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Casa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Estilo");

                    b.HasKey("Id");

                    b.ToTable("Casas");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.Movel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CasaId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Modelo");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.HasIndex("CasaId");

                    b.ToTable("Moveis");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Movel");
                });

            modelBuilder.Entity("ExemplosPadroesProjeto.Models.Moveis.Barroco.ArmarioBarroco", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("ArmarioBarroco");

                    b.HasDiscriminator().HasValue("ArmarioBarroco");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.Barroco.CadeiraBarroca", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("CadeiraBarroca");

                    b.HasDiscriminator().HasValue("CadeiraBarroca");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.Barroco.MesaBarroca", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("MesaBarroca");

                    b.HasDiscriminator().HasValue("MesaBarroca");
                });

            modelBuilder.Entity("ExemplosPadroesProjeto.Models.Moveis.Barroco.SofaBarroco", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("SofaBarroco");

                    b.HasDiscriminator().HasValue("SofaBarroco");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.CadeiraFuturista", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("CadeiraFuturista");

                    b.HasDiscriminator().HasValue("CadeiraFuturista");
                });

            modelBuilder.Entity("ExemplosPadroesProjeto.Models.Moveis.Futurista.ArmarioFuturista", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("ArmarioFuturista");

                    b.HasDiscriminator().HasValue("ArmarioFuturista");
                });

            modelBuilder.Entity("ExemplosPadroesProjeto.Models.Moveis.Futurista.SofaFuturista", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("SofaFuturista");

                    b.HasDiscriminator().HasValue("SofaFuturista");
                });

            modelBuilder.Entity("ExemplosPadroesProjeto.Models.Moveis.Gotico.ArmarioGotico", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("ArmarioGotico");

                    b.HasDiscriminator().HasValue("ArmarioGotico");
                });

            modelBuilder.Entity("ExemplosPadroesProjeto.Models.Moveis.Gotico.CadeiraGotica", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("CadeiraGotica");

                    b.HasDiscriminator().HasValue("CadeiraGotica");
                });

            modelBuilder.Entity("ExemplosPadroesProjeto.Models.Moveis.Gotico.MesaGotica", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("MesaGotica");

                    b.HasDiscriminator().HasValue("MesaGotica");
                });

            modelBuilder.Entity("ExemplosPadroesProjeto.Models.Moveis.Gotico.SofaGotico", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("SofaGotico");

                    b.HasDiscriminator().HasValue("SofaGotico");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.MesaFuturista", b =>
                {
                    b.HasBaseType("ExemplosPadrõesProjeto.Models.Moveis.Movel");


                    b.ToTable("MesaFuturista");

                    b.HasDiscriminator().HasValue("MesaFuturista");
                });

            modelBuilder.Entity("ExemplosPadrõesProjeto.Models.Moveis.Movel", b =>
                {
                    b.HasOne("ExemplosPadrõesProjeto.Models.Casa")
                        .WithMany("Moveis")
                        .HasForeignKey("CasaId");
                });
#pragma warning restore 612, 618
        }
    }
}

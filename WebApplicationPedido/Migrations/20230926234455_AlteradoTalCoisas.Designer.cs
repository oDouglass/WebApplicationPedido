﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pedido.Data;

#nullable disable

namespace WebApplicationPedido.Migrations
{
    [DbContext(typeof(PedidoDbContext))]
    [Migration("20230926234455_AlteradoTalCoisas")]
    partial class AlteradoTalCoisas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Pedido.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacoes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Pedido.Models.Condimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Quantidade")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Condimento");
                });

            modelBuilder.Entity("Pedido.Models.Desconto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Desconto");
                });

            modelBuilder.Entity("Pedido.Models.Garcom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cracha")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Garcom");
                });

            modelBuilder.Entity("Pedido.Models.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Capacidade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Disponibilidade")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Mesa");
                });

            modelBuilder.Entity("Pedido.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Formadepagamento")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("Pedido.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacao")
                        .HasColumnType("TEXT");

                    b.Property<float>("PrecoTotal")
                        .HasColumnType("REAL");

                    b.Property<float>("PrecoUnit")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Pedido.Models.Taxa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tipo")
                        .HasColumnType("TEXT");

                    b.Property<float>("Valor")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Taxa");
                });

            modelBuilder.Entity("Pedido.Models.Condimento", b =>
                {
                    b.HasOne("Pedido.Models.Produto", null)
                        .WithMany("Condimento")
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("Pedido.Models.Produto", b =>
                {
                    b.Navigation("Condimento");
                });
#pragma warning restore 612, 618
        }
    }
}

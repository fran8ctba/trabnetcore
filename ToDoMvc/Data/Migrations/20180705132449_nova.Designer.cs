﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoMvc.Data;

namespace ToDoMvc.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180705132449_nova")]
    partial class nova
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ToDoMvc.Models.AccountViewModels.RegisterViewModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("CPF")
                        .HasMaxLength(11);

                    b.Property<string>("ConfirmPassword");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Endereco")
                        .HasMaxLength(200);

                    b.Property<bool>("Gerente");

                    b.Property<long?>("LojaId");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Sexo")
                        .HasMaxLength(100);

                    b.Property<long?>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("LojaId");

                    b.ToTable("RegisterViewModel");
                });

            modelBuilder.Entity("ToDoMvc.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<long?>("CPF")
                        .HasMaxLength(11);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Endereco")
                        .HasMaxLength(200);

                    b.Property<bool>("Gerente");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<long?>("LojaId");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Sexo")
                        .HasMaxLength(100);

                    b.Property<long?>("Telefone");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("LojaId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ToDoMvc.Models.Cliente", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CPF");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<long>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ToDoMvc.Models.Fornecedor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CNPJ");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<long>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("ToDoMvc.Models.Loja", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CNPJ");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<long>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Lojas");
                });

            modelBuilder.Entity("ToDoMvc.Models.Marca", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("ToDoMvc.Models.Produto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescricaoProduto");

                    b.Property<long>("FornecedorId");

                    b.Property<string>("MarcaId");

                    b.Property<long?>("MarcaId1");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<long>("SetorId");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("MarcaId1");

                    b.HasIndex("SetorId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ToDoMvc.Models.Produto_Venda", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ProdutoId");

                    b.Property<long>("QuantidadeProduto");

                    b.Property<decimal>("ValorUnitario");

                    b.Property<long>("VendaId");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("Produtos_Vendas");
                });

            modelBuilder.Entity("ToDoMvc.Models.Setor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("ToDoMvc.Models.Venda", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("ClienteId");

                    b.Property<DateTime>("DataVenda");

                    b.Property<string>("DescricaoVenda");

                    b.Property<bool>("Fechado");

                    b.Property<string>("FormaPagamento");

                    b.Property<string>("FuncionarioId");

                    b.Property<long?>("ProdutoId");

                    b.Property<decimal>("ValorTotal");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ToDoMvc.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ToDoMvc.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ToDoMvc.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ToDoMvc.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ToDoMvc.Models.AccountViewModels.RegisterViewModel", b =>
                {
                    b.HasOne("ToDoMvc.Models.Loja", "Loja")
                        .WithMany()
                        .HasForeignKey("LojaId");
                });

            modelBuilder.Entity("ToDoMvc.Models.ApplicationUser", b =>
                {
                    b.HasOne("ToDoMvc.Models.Loja", "Loja")
                        .WithMany()
                        .HasForeignKey("LojaId");
                });

            modelBuilder.Entity("ToDoMvc.Models.Produto", b =>
                {
                    b.HasOne("ToDoMvc.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ToDoMvc.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId1");

                    b.HasOne("ToDoMvc.Models.Setor", "Setor")
                        .WithMany()
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ToDoMvc.Models.Produto_Venda", b =>
                {
                    b.HasOne("ToDoMvc.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ToDoMvc.Models.Venda", "Venda")
                        .WithMany()
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ToDoMvc.Models.Venda", b =>
                {
                    b.HasOne("ToDoMvc.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ToDoMvc.Models.Produto")
                        .WithMany("Vendas")
                        .HasForeignKey("ProdutoId");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using CoreUI.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CoreUI.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180613140401_Imagem")]
    partial class Imagem
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreUI.Web.Models.Almoxarifado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("Cod_Almoxarifado")
                        .HasMaxLength(255);

                    b.Property<byte[]>("Imagem")
                        .HasColumnName("ImagemAlmoxarifado");

                    b.Property<int>("LocalizacaoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome_Almoxarifado")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("LocalizacaoId");

                    b.ToTable("AlmoxarifadoTables");
                });

            modelBuilder.Entity("CoreUI.Web.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CoreUI.Web.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EstadoId");

                    b.Property<string>("NomeCidade")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("CoreUI.Web.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CNAE");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("CRT");

                    b.Property<string>("InscricaoEstadual")
                        .HasMaxLength(255);

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(255);

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("CoreUI.Web.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoEstado")
                        .HasMaxLength(255);

                    b.Property<string>("NomeEstado")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("PaisId");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("CoreUI.Web.Models.Fabricante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmpresaId");

                    b.Property<string>("NomeFabricante")
                        .IsRequired()
                        .HasColumnName("Manufacturer")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("ManufacturerTables");
                });

            modelBuilder.Entity("CoreUI.Web.Models.IdentificacaoSistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DominioMobile")
                        .HasColumnName("Dominio_Mobile")
                        .HasMaxLength(255);

                    b.Property<string>("DominioPrincipal")
                        .IsRequired()
                        .HasColumnName("Dominio_Principal")
                        .HasMaxLength(255);

                    b.Property<string>("EnderecoIntegracoes")
                        .HasColumnName("Endereço_Integracoes")
                        .HasMaxLength(255);

                    b.Property<string>("IDSistema")
                        .IsRequired()
                        .HasColumnName("ID_Sistema")
                        .HasMaxLength(255);

                    b.Property<byte[]>("ImagemPadrao")
                        .HasColumnName("Imagem_Padrao");

                    b.Property<int>("LocalizacaoId");

                    b.Property<byte[]>("LogoMobile")
                        .HasColumnName("Logo_MOBILE");

                    b.Property<byte[]>("LogoWeb")
                        .HasColumnName("Logo_WEB");

                    b.Property<string>("Versao")
                        .HasColumnName("Versao_App")
                        .HasMaxLength(255);

                    b.Property<string>("loginAD")
                        .HasColumnName("login_AD")
                        .HasMaxLength(255);

                    b.Property<string>("senhaAD")
                        .HasColumnName("senha_AD")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("LocalizacaoId");

                    b.ToTable("IDs_Sistemas");
                });

            modelBuilder.Entity("CoreUI.Web.Models.Localizacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .HasColumnName("Bairro_Local")
                        .HasMaxLength(255);

                    b.Property<string>("CEP")
                        .HasColumnName("CEP_Local")
                        .HasMaxLength(255);

                    b.Property<int>("CidadeId");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("Codigo_Local")
                        .HasMaxLength(255);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao_Local")
                        .HasMaxLength(255);

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnName("Endereco_Local")
                        .HasMaxLength(255);

                    b.Property<int>("EstadoId");

                    b.Property<byte[]>("Imagem")
                        .HasColumnName("Imagem_Local");

                    b.Property<float>("Latitude")
                        .HasColumnName("Latitude_Local");

                    b.Property<float>("Longitude")
                        .HasColumnName("Longitude_Local");

                    b.Property<string>("MapData")
                        .HasColumnName("MapData")
                        .HasMaxLength(255);

                    b.Property<int>("PaisId");

                    b.Property<byte[]>("Planta")
                        .HasColumnName("Planta_Local");

                    b.Property<string>("RaioLocalizacao")
                        .HasColumnName("Raio_LocalizacaoGPS")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("PaisId");

                    b.ToTable("CadastroLocalTable");
                });

            modelBuilder.Entity("CoreUI.Web.Models.LogSistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DataHoraEvento");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("LogSistema");
                });

            modelBuilder.Entity("CoreUI.Web.Models.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbreviacaoPais")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<byte[]>("Imagem");

                    b.Property<string>("NomePais")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("CoreUI.Web.Models.Posicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlmoxarifadoId");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnName("Cod_Posicao")
                        .HasMaxLength(255);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Desc_Posicao")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AlmoxarifadoId");

                    b.ToTable("PosicaoTables");
                });

            modelBuilder.Entity("CoreUI.Web.Models.SetorProprietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("EmpresaId");

                    b.Property<string>("Gestor")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("SetorProprietarios");
                });

            modelBuilder.Entity("CoreUI.Web.Models.TAGIDPosicao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnName("Descricao_Posicao")
                        .HasMaxLength(255);

                    b.Property<int>("PosicaoId");

                    b.Property<string>("TAGID")
                        .IsRequired()
                        .HasColumnName("TAGID_Posicao")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PosicaoId");

                    b.ToTable("TAGIDPosicaoTables");
                });

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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

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

            modelBuilder.Entity("CoreUI.Web.Models.Almoxarifado", b =>
                {
                    b.HasOne("CoreUI.Web.Models.Localizacao", "Localizacao")
                        .WithMany()
                        .HasForeignKey("LocalizacaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreUI.Web.Models.Cidade", b =>
                {
                    b.HasOne("CoreUI.Web.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreUI.Web.Models.Estado", b =>
                {
                    b.HasOne("CoreUI.Web.Models.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreUI.Web.Models.Fabricante", b =>
                {
                    b.HasOne("CoreUI.Web.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreUI.Web.Models.IdentificacaoSistema", b =>
                {
                    b.HasOne("CoreUI.Web.Models.Localizacao", "Localizacao")
                        .WithMany()
                        .HasForeignKey("LocalizacaoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreUI.Web.Models.Localizacao", b =>
                {
                    b.HasOne("CoreUI.Web.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoreUI.Web.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoreUI.Web.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoreUI.Web.Models.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CoreUI.Web.Models.Posicao", b =>
                {
                    b.HasOne("CoreUI.Web.Models.Almoxarifado", "Almoxarifado")
                        .WithMany()
                        .HasForeignKey("AlmoxarifadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreUI.Web.Models.SetorProprietario", b =>
                {
                    b.HasOne("CoreUI.Web.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreUI.Web.Models.TAGIDPosicao", b =>
                {
                    b.HasOne("CoreUI.Web.Models.Posicao", "Posicao")
                        .WithMany()
                        .HasForeignKey("PosicaoId")
                        .OnDelete(DeleteBehavior.Cascade);
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
                    b.HasOne("CoreUI.Web.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CoreUI.Web.Models.ApplicationUser")
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

                    b.HasOne("CoreUI.Web.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CoreUI.Web.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
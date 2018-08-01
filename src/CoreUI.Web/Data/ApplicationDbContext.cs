using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CoreUI.Web.Models;

namespace CoreUI.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LogSistema> LogSistema { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Localizacao> Localizacoes { get; set; }
        public DbSet<SetorProprietario> SetorProprietarios { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
        public DbSet<Almoxarifado> Almoxarifados { get; set; }
        public DbSet<Posicao> Posicoes { get; set; }
        public DbSet<TAGIDPosicao> TAGIDsPosicao { get; set; }
        public DbSet<IdentificacaoSistema> IdentificacaoSistemas { get; set; }
        public DbSet<Documentacao> Documentacoes { get; set; }
        
        //Parametros-Email
        public DbSet<CategoriaEmail> CategoriaEmails { get; set; }
        public DbSet<SendEmail> SendEmails { get; set; }
        
        //Parametros-Corporativos
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Permissao> Permissoes { get; set; }
        public DbSet<PermissaoUsuario> PermissoesUsuario { get; set; }
        public DbSet<PermissaoHabilitacao> PermissoesHabilitacao { get; set; }
        public DbSet<Requisicao> Requisicoes { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }

        //Parametros-Equipamentos
        public DbSet<TAGIDEquipment> TAGIDEquipamentos { get; set; }
        public DbSet<GPSIDEquipment> GPSIDEquipamentos { get; set; }
        public DbSet<ModeloEquipamentos> ModelosEquipamentos { get; set; }
        public DbSet<CategoriaEquipamentos> CategoriaEquipamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Localizacao>()
                .HasOne(l => l.Cidade)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Localizacao>()
                .HasOne(l => l.Estado)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Localizacao>()
                .HasOne(l => l.Pais)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Localizacao>()
                .HasOne(l => l.Empresa)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Grupo>()
                .HasOne(a => a.PermissaoUsuario)
                .WithOne(b => b.Grupo)
                .HasForeignKey<PermissaoUsuario>(b => b.GrupoId);

            builder.Entity<PermissaoHabilitacao>()
                .HasOne(l => l.SetorProprietario)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
            
        }
    }
}

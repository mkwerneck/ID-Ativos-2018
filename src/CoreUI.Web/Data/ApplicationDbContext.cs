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

            base.OnModelCreating(builder);
            
        }
    }
}

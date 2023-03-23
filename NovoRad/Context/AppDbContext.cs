using Microsoft.EntityFrameworkCore;
using NovoRad.Migrations;
using NovoRad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoRad.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Ocorrencia> Ocorrencia { get; set; }
        public DbSet<Responsavel> Responsavel { get; set; }
        public DbSet<Ambiente> Ambiente { get; set; }
        public DbSet<AreaDemandante> AreaDemandante { get; set; }
        public DbSet<Classificacao> Classificacao { get; set; }
        public DbSet<Prioridade> Prioridade { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Seguimento> Seguimento { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<Funcionalidade> Funcionalidade { get; set; }
        public DbSet<Regional> Regional { get; set; }
        public DbSet<UsuarioFuncionalidade> UsuarioFuncionalidade { get; set; }
        public DbSet<Historico> Historico { get; set; }
        public DbSet<Envolvido> Envolvido { get; set; }
        public DbSet<AcaoTomada> AcaoTomada { get; set; }
        public DbSet<TipoEnvolvimento> TipoEnvolvimento { get; set; }
        public DbSet<MedidaDisciplinar> MedidaDisciplinar { get; set; }
        public DbSet<Conclusao> Conclusao { get; set; }
        public DbSet<Resultado> Resultado { get; set; }
        public DbSet<Anexo> Anexo { get; set; }
        public DbSet<TipoAnexo> TipoAnexo { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<DiasPrazo> DiasPrazo { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UsuarioFuncionalidade>()
                .HasNoKey();

            //modelBuilder.Entity<Anexo>()
            //               .Property(o => o.DataAnexo)
            //               .HasDefaultValueSql("GETDATE()");



            //    modelBuilder.Entity<Ocorrencia>()
            //                    .Property(o => o.DataInicio)
            //                    .HasDefaultValueSql("GETDATE()");

            //    modelBuilder.Entity<Ocorrencia>()
            //                    .Property(o => o.DataFim)
            //                    .HasDefaultValueSql("GETDATE()");

            //    modelBuilder.Entity<Ocorrencia>()
            //                    .Property(o => o.DataConclusao)
            //                    .HasDefaultValueSql("GETDATE()");

            //    modelBuilder.Entity<Ocorrencia>()
            //       .HasOne<Responsavel>(a => a.Responsavel)
            //       .WithMany(b => b.Ocorrencias)
            //       .HasForeignKey(b => b.ResponsavelId)
            //       .IsRequired();

            //    modelBuilder.Entity<Ocorrencia>()
            //       .HasOne<Classificacao>(a => a.Classificacao)
            //       .WithMany(b => b.Ocorrencias)
            //       .HasForeignKey(b => b.ClassificacaoId)
            //       .IsRequired();

            //    modelBuilder.Entity<Ocorrencia>()
            //       .HasOne<Prioridade>(a => a.Prioridade)
            //       .WithMany(b => b.Ocorrencias)
            //       .HasForeignKey(b => b.ClassificacaoId)
            //       .IsRequired();

            //    modelBuilder.Entity<Ocorrencia>()
            //       .HasOne<AreaDemandante>(a => a.AreaDemandante)
            //       .WithMany(b => b.Ocorrencias)
            //       .HasForeignKey(b => b.AreaDemandanteId)
            //       .IsRequired();

            //    modelBuilder.Entity<Ocorrencia>()
            //      .HasOne<Seguimento>(a => a.Seguimento)
            //      .WithMany(b => b.Ocorrencias)
            //      .HasForeignKey(b => b.SeguimentoId)
            //      .IsRequired();

            //    modelBuilder.Entity<Ocorrencia>()
            //     .HasOne<Produto>(a => a.Produto)
            //     .WithMany(b => b.Ocorrencias)
            //     .HasForeignKey(b => b.ProdutoId)
            //     .IsRequired();

            //    modelBuilder.Entity<Ocorrencia>()
            //     .HasOne<Ambiente>(a => a.Ambiente)
            //     .WithMany(b => b.Ocorrencias)
            //     .HasForeignKey(b => b.AmbienteId)
            //     .IsRequired();

            //modelBuilder.Entity<Cenario>()
            //    .HasMany<Anexo>(a => a.Anexos)
            //    .WithOne(b => b.Cenario)
            //    .HasForeignKey(b => b.CenarioId)
            //    .OnDelete(DeleteBehavior.Cascade);

        }
    }
}

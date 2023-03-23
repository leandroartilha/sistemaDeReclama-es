﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NovoRad.Context;

namespace NovoRad.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220830144123_AddAmbiente")]
    partial class AddAmbiente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NovoRad.Migrations.Ambiente", b =>
                {
                    b.Property<int>("AmbienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(200)");

                    b.Property<byte>("Prazo")
                        .HasColumnType("tinyint");

                    b.HasKey("AmbienteId");

                    b.ToTable("Ambiente");
                });

            modelBuilder.Entity("NovoRad.Models.AreaDemandante", b =>
                {
                    b.Property<int>("AreaDemandanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(200)");

                    b.Property<byte>("Prazo")
                        .HasColumnType("tinyint");

                    b.HasKey("AreaDemandanteId");

                    b.ToTable("AreaDemandante");
                });

            modelBuilder.Entity("NovoRad.Models.Classificacao", b =>
                {
                    b.Property<int>("ClassificacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Prazo")
                        .HasColumnType("int");

                    b.HasKey("ClassificacaoId");

                    b.ToTable("Classificacao");
                });

            modelBuilder.Entity("NovoRad.Models.Ocorrencia", b =>
                {
                    b.Property<int>("OcorrenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmbienteId")
                        .HasColumnType("int");

                    b.Property<int>("AreaDemandanteId")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("ClassificacaoId")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoApuracao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrioridadeId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("ResponsavelId")
                        .HasColumnType("int");

                    b.Property<int>("SeguimentoId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UF")
                        .HasColumnType("varchar(2)");

                    b.HasKey("OcorrenciaId");

                    b.HasIndex("AmbienteId");

                    b.HasIndex("AreaDemandanteId");

                    b.HasIndex("ClassificacaoId");

                    b.HasIndex("PrioridadeId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("ResponsavelId");

                    b.HasIndex("SeguimentoId");

                    b.ToTable("Ocorrencia");
                });

            modelBuilder.Entity("NovoRad.Models.Prioridade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumeroPrioridade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prioridade");
                });

            modelBuilder.Entity("NovoRad.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeProduto")
                        .HasColumnType("varchar(40)");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("NovoRad.Models.Responsavel", b =>
                {
                    b.Property<int>("ResponsavelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeResponsavel")
                        .HasColumnType("varchar(100)");

                    b.HasKey("ResponsavelId");

                    b.ToTable("Responsavel");
                });

            modelBuilder.Entity("NovoRad.Models.Seguimento", b =>
                {
                    b.Property<int>("SeguimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeSeguimento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeguimentoId");

                    b.ToTable("Seguimento");
                });

            modelBuilder.Entity("NovoRad.Models.Ocorrencia", b =>
                {
                    b.HasOne("NovoRad.Migrations.Ambiente", "Ambiente")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("AmbienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NovoRad.Models.AreaDemandante", "AreaDemandante")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("AreaDemandanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NovoRad.Models.Classificacao", "Classificacao")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("ClassificacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NovoRad.Models.Prioridade", "Prioridade")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("PrioridadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NovoRad.Models.Produto", "Produto")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NovoRad.Models.Responsavel", "Responsavel")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NovoRad.Models.Seguimento", "Seguimento")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("SeguimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ambiente");

                    b.Navigation("AreaDemandante");

                    b.Navigation("Classificacao");

                    b.Navigation("Prioridade");

                    b.Navigation("Produto");

                    b.Navigation("Responsavel");

                    b.Navigation("Seguimento");
                });

            modelBuilder.Entity("NovoRad.Migrations.Ambiente", b =>
                {
                    b.Navigation("Ocorrencias");
                });

            modelBuilder.Entity("NovoRad.Models.AreaDemandante", b =>
                {
                    b.Navigation("Ocorrencias");
                });

            modelBuilder.Entity("NovoRad.Models.Classificacao", b =>
                {
                    b.Navigation("Ocorrencias");
                });

            modelBuilder.Entity("NovoRad.Models.Prioridade", b =>
                {
                    b.Navigation("Ocorrencias");
                });

            modelBuilder.Entity("NovoRad.Models.Produto", b =>
                {
                    b.Navigation("Ocorrencias");
                });

            modelBuilder.Entity("NovoRad.Models.Responsavel", b =>
                {
                    b.Navigation("Ocorrencias");
                });

            modelBuilder.Entity("NovoRad.Models.Seguimento", b =>
                {
                    b.Navigation("Ocorrencias");
                });
#pragma warning restore 612, 618
        }
    }
}

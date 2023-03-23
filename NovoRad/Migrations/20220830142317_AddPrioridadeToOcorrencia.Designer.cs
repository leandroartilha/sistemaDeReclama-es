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
    [Migration("20220830142317_AddPrioridadeToOcorrencia")]
    partial class AddPrioridadeToOcorrencia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Cidade")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("ClassificacaoId")
                        .HasColumnType("int");

                    b.Property<int>("PrioridadeId")
                        .HasColumnType("int");

                    b.Property<int>("ResponsavelId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UF")
                        .HasColumnType("varchar(2)");

                    b.HasKey("OcorrenciaId");

                    b.HasIndex("ClassificacaoId");

                    b.HasIndex("PrioridadeId");

                    b.HasIndex("ResponsavelId");

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

            modelBuilder.Entity("NovoRad.Models.Ocorrencia", b =>
                {
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

                    b.HasOne("NovoRad.Models.Responsavel", "Responsavel")
                        .WithMany("Ocorrencias")
                        .HasForeignKey("ResponsavelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classificacao");

                    b.Navigation("Prioridade");

                    b.Navigation("Responsavel");
                });

            modelBuilder.Entity("NovoRad.Models.Classificacao", b =>
                {
                    b.Navigation("Ocorrencias");
                });

            modelBuilder.Entity("NovoRad.Models.Prioridade", b =>
                {
                    b.Navigation("Ocorrencias");
                });

            modelBuilder.Entity("NovoRad.Models.Responsavel", b =>
                {
                    b.Navigation("Ocorrencias");
                });
#pragma warning restore 612, 618
        }
    }
}
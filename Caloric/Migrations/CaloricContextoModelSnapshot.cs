﻿// <auto-generated />
using Caloric.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Caloric.Migrations
{
    [DbContext(typeof(CaloricContexto))]
    partial class CaloricContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Caloric.Models.Alimentos", b =>
                {
                    b.Property<int>("AlimentosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Almoço")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CafeDaManha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CafeDaNoite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lanche")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlimentosId");

                    b.ToTable("Alimentos");
                });

            modelBuilder.Entity("Caloric.Models.CaracteristicasFisicas", b =>
                {
                    b.Property<int>("CaracteFisicasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<string>("Biotipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("CaracteFisicasId");

                    b.ToTable("CaracteristicasFisicas");
                });

            modelBuilder.Entity("Caloric.Models.Enderecos", b =>
                {
                    b.Property<int>("EnderecosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnderecosId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Caloric.Models.Exercicios", b =>
                {
                    b.Property<int>("ExerciciosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ExerciciosId");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("Caloric.Models.Nutrientes", b =>
                {
                    b.Property<int>("NutrientesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Acucar")
                        .HasColumnType("int");

                    b.Property<int>("Carboidratos")
                        .HasColumnType("int");

                    b.Property<int>("Gorduras")
                        .HasColumnType("int");

                    b.Property<int>("Proteinas")
                        .HasColumnType("int");

                    b.Property<int>("Sodio")
                        .HasColumnType("int");

                    b.HasKey("NutrientesId");

                    b.ToTable("Nutrientes");
                });

            modelBuilder.Entity("Caloric.Models.Pessoas", b =>
                {
                    b.Property<int>("PessoasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RG")
                        .HasColumnType("int");

                    b.Property<string>("SobreNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PessoasId");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("Caloric.Models.Quantidade", b =>
                {
                    b.Property<int>("QuantidadeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("QuantidadeId");

                    b.ToTable("Quantidades");
                });
#pragma warning restore 612, 618
        }
    }
}
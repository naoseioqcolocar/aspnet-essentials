﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AplicativoWeb.Migrations
{
    [DbContext(typeof(AppDbContest))]
    [Migration("20230414194530_CriandoBancoDeDados")]
    partial class CriandoBancoDeDados
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.3.23174.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AplicativoWeb.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TituloInterno")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("TituloMarketing")
                        .IsRequired()
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Curso", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

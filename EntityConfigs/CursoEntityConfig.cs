using AplicativoWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AplicativoWeb.EntityConfigs;


public class CursoEntityConfig : IEntityTypeConfiguration<Curso>{
    public void Configure(EntityTypeBuilder<Curso> builder){
        
        builder.ToTable("Curso");//Definindo o nome da tabela
        builder.HasKey(c=>c.Id); //Definindo a chave primária da tabela, c é uma variável (Método Lambda) 
        
        builder.Property(c=>c.TituloMarketing)
               .HasColumnType("nvarchar(80)")
               .IsRequired();

         builder.Property(c=>c.TituloInterno)
               .HasColumnType("nvarchar(80)")
               .IsRequired();

        builder.Property(c=>c.Descricao)
               .HasColumnType("text")
               .IsRequired();
    }
}
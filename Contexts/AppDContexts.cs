using AplicativoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using AplicativoWeb.EntityConfigs;
using Microsoft.EntityFrameworkCore;

public class AppDbContest:DbContext{

    public DbSet<Curso> Cursos => Set<Curso>(); //Representa a tabela
    protected override void OnConfiguring(DbContextOptionsBuilder builder){
        builder.UseSqlServer("Server=LAB-F08-15; Database=EscolaDotNet; User Id=sa; Password=senai@123; TrustServerCertificate=True");
    }

    protected override void OnModelCreating(ModelBuilder Builder){
        Builder.ApplyConfiguration(new CursoEntityConfig());
    } 
}
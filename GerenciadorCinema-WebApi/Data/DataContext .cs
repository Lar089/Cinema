using GerenciadorCinema_WebApi.Model.ModuleFilme;
using GerenciadorCinema_WebApi.Model.ModuleLogin;
using GerenciadorCinema_WebApi.Model.ModuleSala;
using GerenciadorCinema_WebApi.Model.ModuleSessao;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace SmartSchool.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
        public DbSet<Login> Login { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Sessao>()
                .HasKey(AD => new { AD.FilmeId, AD.SalaId });

            builder.Entity<Filme>()
                .HasData(new List<Filme>(){
                    new Filme(1, null, "filme 1", "A", new TimeSpan(1,10,0)),
                    new Filme(2, null, "filme 2", "B", new TimeSpan(1,20,0)),
                    new Filme(3, null, "filme 3", "C", new TimeSpan(1,30,0)),
                    new Filme(4, null, "filme 4", "D", new TimeSpan(1,40,0)),
                    new Filme(5, null, "filme 5", "E", new TimeSpan(1,50,0))
                });

            builder.Entity<Sala>()
                .HasData(new List<Sala>{
                    new Sala(1, "Sala 1", 40),
                    new Sala(2, "Sala 2", 50),
                    new Sala(3, "Sala 3", 60)
                });

            builder.Entity<Login>()
                .HasData(new List<Login>{
                    new Login(1, "Admin@algo.com", "senha")
                });

            builder.Entity<Sessao>()
                .HasData(new List<Sessao>(){
                    new Sessao(1, DateTime.Parse("09/12/2021"), new TimeSpan(1,10,0), new TimeSpan(1,30,0), 
                    30m, "2D", "legendado", 1, 2)
                });
        }
    }
}
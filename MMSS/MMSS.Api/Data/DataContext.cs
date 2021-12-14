using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MMSS.Api.Models;

namespace MMSS.Api.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Show> Shows { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<ShowType> ShowTypes { get; set; }
        public DbSet<ShowCategory> ShowsCategorys { get; set; }
        public DbSet<PlatformShow> PlatformsShows { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ShowCategory>()
                .HasKey(SC => new { SC.ShowId, SC.CategoryId });

            builder.Entity<PlatformShow>()
                .HasKey(PS => new { PS.PlatformId, PS.ShowId });


            builder.Entity<Show>()
                .HasData(new List<Show>(){
                    new Show() {
                        Id = 1,
                        Title = "The Big Bang Theory",
                        Year = 2007,
                        ShowTypeId = 2,
                        Briefing = "Os melhores amigos e companheiros de apartamento Leonard e Sheldon são físicos que trabalham no Instituto Tecnológico da Califórnia (Caltech) e são capazes de explicar a todo mundo mais do que gostariam de saber sobre física quântica, mas superar as situações sociais mais básicas, especialmente aquelas envolvendo mulheres, os deixa completamente perdidos. Que sorte quando a gostosa garçonete/atriz aspirante Penny se muda para o apartamento ao lado. Wolowitz e Koothrappali, também da Caltech, são vistos frequentemente passando o tempo com Leonard e Sheldon. Será que os mundos vão se colidir? Será que Einstein teorizava na floresta?",
                        CategoryId = 3,
                        PlatformId = 4
                    },
                    new Show() {
                        Id = 2,
                        Title = "Batman: O Cavaleiro das Trevas",
                        Year = 2008,
                        ShowTypeId = 1,
                        Briefing = "Com a ajuda de Jim Gordon e Harvey Dent, Batman tem mantido a ordem na cidade de Gotham. Mas um jovem e anárquico criminoso conhecido como Coringa ganha força e decide instaurar um verdadeiro caos na cidade. O justiceiro será testado psicologicamente e fisicamente como nunca fora antes em um confronto bastante pessoal. Cabe a Batman encontrar uma maneira de deter o sádico vilão antes que mais vidas sejam perdidas.",
                        CategoryId = 6,
                        PlatformId = 1
                    },
                    new Show() {
                        Id = 3,
                        Title = "O Código DaVinci",
                        Year = 2006,
                        ShowTypeId = 1,
                        Briefing = "Um assassinato no museu do Louvre em Paris e pistas enigmáticas em alguns dos quadros mais famosos de Leonardo DaVinci levam à descoberta de um mistério religioso. Por mais de dois mil anos, uma sociedade secreta guarda informações que, se descobertas, poderiam comprometer o cristianismo. Robert Langdon, um professor especialista em simbologia e história, se envolve na investigação.",
                        CategoryId = 5,
                        PlatformId = 3
                    },
                    new Show() {
                        Id = 4,
                        Title = "O Silêncio dos Inocentes",
                        Year = 1991,
                        ShowTypeId = 1,
                        Briefing = "Uma jovem e talentosa agente do FBI é aconselhada pelo Dr. Hannibal Lecter, um psiquiatra brilhante e também um psicopata violento e canibal, a fim de conseguir capturar outro assassino.",
                        CategoryId = 8,
                        PlatformId = 2
                    }
                });

            builder.Entity<Category>()
                .HasData(new List<Category>()
                {
                    new Category() {Id = 1,Name = "Drama"},
                    new Category() {Id = 2,Name = "Musical"},
                    new Category() {Id = 3,Name = "Comédia"},
                    new Category() {Id = 4,Name = "Terror"},
                    new Category() {Id = 5,Name = "Policial"},
                    new Category() {Id = 6,Name = "Ação"},
                    new Category() {Id = 7,Name = "SciFi"},
                    new Category() {Id = 8,Name = "Suspense"}
                });

            builder.Entity<Platform>()
                .HasData(new List<Platform>()
                {
                    new Platform() {Id = 1,Name = "Amazon"},
                    new Platform() {Id = 2,Name = "YouTube"},
                    new Platform() {Id = 3,Name = "Netflix"},
                    new Platform() {Id = 4,Name = "TV"},
                    new Platform() {Id = 5,Name = "Disney+"},
                });

            builder.Entity<ShowType>()
                .HasData(new List<ShowType>()
                {
                    new ShowType() {Id = 1, Name = "Filme"},
                    new ShowType() {Id = 2, Name = "Série"},
                    new ShowType() {Id = 3, Name = "Programa de TV"}
                });

        }

    }
}
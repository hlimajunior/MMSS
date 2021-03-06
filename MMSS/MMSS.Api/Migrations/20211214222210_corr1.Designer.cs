// <auto-generated />
using MMSS.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MMSS.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211214222210_corr1")]
    partial class corr1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("MMSS.Api.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Musical"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Comédia"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Terror"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Policial"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ação"
                        },
                        new
                        {
                            Id = 7,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Suspense"
                        });
                });

            modelBuilder.Entity("MMSS.Api.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Amazon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "YouTube"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Netflix"
                        },
                        new
                        {
                            Id = 4,
                            Name = "TV"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Disney+"
                        });
                });

            modelBuilder.Entity("MMSS.Api.Models.PlatformShow", b =>
                {
                    b.Property<int>("PlatformId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShowId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlatformId", "ShowId");

                    b.HasIndex("ShowId");

                    b.ToTable("PlatformsShows");
                });

            modelBuilder.Entity("MMSS.Api.Models.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Briefing")
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlatformId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ShowTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PlatformId");

                    b.HasIndex("ShowTypeId");

                    b.ToTable("Shows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Briefing = "Os melhores amigos e companheiros de apartamento Leonard e Sheldon são físicos que trabalham no Instituto Tecnológico da Califórnia (Caltech) e são capazes de explicar a todo mundo mais do que gostariam de saber sobre física quântica, mas superar as situações sociais mais básicas, especialmente aquelas envolvendo mulheres, os deixa completamente perdidos. Que sorte quando a gostosa garçonete/atriz aspirante Penny se muda para o apartamento ao lado. Wolowitz e Koothrappali, também da Caltech, são vistos frequentemente passando o tempo com Leonard e Sheldon. Será que os mundos vão se colidir? Será que Einstein teorizava na floresta?",
                            CategoryId = 3,
                            PlatformId = 4,
                            ShowTypeId = 2,
                            Title = "The Big Bang Theory",
                            Year = 2007
                        },
                        new
                        {
                            Id = 2,
                            Briefing = "Com a ajuda de Jim Gordon e Harvey Dent, Batman tem mantido a ordem na cidade de Gotham. Mas um jovem e anárquico criminoso conhecido como Coringa ganha força e decide instaurar um verdadeiro caos na cidade. O justiceiro será testado psicologicamente e fisicamente como nunca fora antes em um confronto bastante pessoal. Cabe a Batman encontrar uma maneira de deter o sádico vilão antes que mais vidas sejam perdidas.",
                            CategoryId = 6,
                            PlatformId = 1,
                            ShowTypeId = 1,
                            Title = "Batman: O Cavaleiro das Trevas",
                            Year = 2008
                        },
                        new
                        {
                            Id = 3,
                            Briefing = "Um assassinato no museu do Louvre em Paris e pistas enigmáticas em alguns dos quadros mais famosos de Leonardo DaVinci levam à descoberta de um mistério religioso. Por mais de dois mil anos, uma sociedade secreta guarda informações que, se descobertas, poderiam comprometer o cristianismo. Robert Langdon, um professor especialista em simbologia e história, se envolve na investigação.",
                            CategoryId = 5,
                            PlatformId = 3,
                            ShowTypeId = 1,
                            Title = "O Código DaVinci",
                            Year = 2006
                        },
                        new
                        {
                            Id = 4,
                            Briefing = "Uma jovem e talentosa agente do FBI é aconselhada pelo Dr. Hannibal Lecter, um psiquiatra brilhante e também um psicopata violento e canibal, a fim de conseguir capturar outro assassino.",
                            CategoryId = 8,
                            PlatformId = 2,
                            ShowTypeId = 1,
                            Title = "O Silêncio dos Inocentes",
                            Year = 1991
                        });
                });

            modelBuilder.Entity("MMSS.Api.Models.ShowCategory", b =>
                {
                    b.Property<int>("ShowId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ShowId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ShowsCategorys");
                });

            modelBuilder.Entity("MMSS.Api.Models.ShowType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ShowTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Filme"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Série"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Programa de TV"
                        });
                });

            modelBuilder.Entity("MMSS.Api.Models.PlatformShow", b =>
                {
                    b.HasOne("MMSS.Api.Models.Platform", "Platform")
                        .WithMany("PlatformsShows")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMSS.Api.Models.Show", "Show")
                        .WithMany()
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Platform");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("MMSS.Api.Models.Show", b =>
                {
                    b.HasOne("MMSS.Api.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMSS.Api.Models.Platform", "Platform")
                        .WithMany()
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMSS.Api.Models.ShowType", "ShowType")
                        .WithMany("Shows")
                        .HasForeignKey("ShowTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Platform");

                    b.Navigation("ShowType");
                });

            modelBuilder.Entity("MMSS.Api.Models.ShowCategory", b =>
                {
                    b.HasOne("MMSS.Api.Models.Category", "Category")
                        .WithMany("ShowsCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MMSS.Api.Models.Show", "Show")
                        .WithMany()
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("MMSS.Api.Models.Category", b =>
                {
                    b.Navigation("ShowsCategories");
                });

            modelBuilder.Entity("MMSS.Api.Models.Platform", b =>
                {
                    b.Navigation("PlatformsShows");
                });

            modelBuilder.Entity("MMSS.Api.Models.ShowType", b =>
                {
                    b.Navigation("Shows");
                });
#pragma warning restore 612, 618
        }
    }
}

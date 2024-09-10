﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TunaPianoAPI.Migrations
{
    [DbContext(typeof(TunaPianoDbContext))]
    partial class TunaPianoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GenreSong", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("integer");

                    b.Property<int>("SongsId")
                        .HasColumnType("integer");

                    b.HasKey("GenresId", "SongsId");

                    b.HasIndex("SongsId");

                    b.ToTable("SongGenre", (string)null);
                });

            modelBuilder.Entity("TunaPiano.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 37,
                            Bio = "An Australian music project led by multi-instrumentalist Kevin Parker, known for blending psychedelic rock with indie pop.",
                            Name = "Tame Impala"
                        },
                        new
                        {
                            Id = 2,
                            Age = 46,
                            Bio = "An American rock band from Illinois, known for pioneering the Midwest Emo genre.",
                            Name = "American Football"
                        },
                        new
                        {
                            Id = 3,
                            Age = 61,
                            Bio = "An Irish-English rock band formed in 1983, credited with popularizing the shoegaze genre.",
                            Name = "My Bloody Valentine"
                        },
                        new
                        {
                            Id = 4,
                            Age = 37,
                            Bio = "An American rapper, songwriter, and record producer known for his socially conscious lyrics and storytelling.",
                            Name = "Kendrick Lamar"
                        },
                        new
                        {
                            Id = 5,
                            Age = 37,
                            Bio = "A Canadian rapper, singer, and songwriter, known for blending rap and R&B in his music.",
                            Name = "Drake"
                        },
                        new
                        {
                            Id = 6,
                            Age = 34,
                            Bio = "An American singer and songwriter, known for her alternative R&B sound and introspective lyrics.",
                            Name = "SZA"
                        },
                        new
                        {
                            Id = 7,
                            Age = 34,
                            Bio = "A Japanese math rock band known for their complex rhythms and technical guitar work.",
                            Name = "Tricot"
                        });
                });

            modelBuilder.Entity("TunaPiano.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Indie"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Midwest Emo"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Shoegaze"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Hip Hop"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Rap"
                        },
                        new
                        {
                            Id = 6,
                            Description = "R&B"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Japanese Math Rock"
                        });
                });

            modelBuilder.Entity("TunaPiano.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ArtistId")
                        .HasColumnType("integer");

                    b.Property<int>("Length")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album = "Currents",
                            ArtistId = 1,
                            Length = 216,
                            Title = "The Less I Know The Better"
                        },
                        new
                        {
                            Id = 2,
                            Album = "American Football",
                            ArtistId = 2,
                            Length = 258,
                            Title = "Never Meant"
                        },
                        new
                        {
                            Id = 3,
                            Album = "Loveless",
                            ArtistId = 3,
                            Length = 276,
                            Title = "Only Shallow"
                        },
                        new
                        {
                            Id = 4,
                            Album = "DAMN.",
                            ArtistId = 4,
                            Length = 177,
                            Title = "HUMBLE."
                        },
                        new
                        {
                            Id = 5,
                            Album = "Views",
                            ArtistId = 5,
                            Length = 267,
                            Title = "Hotline Bling"
                        },
                        new
                        {
                            Id = 6,
                            Album = "Good Days - Single",
                            ArtistId = 6,
                            Length = 271,
                            Title = "Good Days"
                        },
                        new
                        {
                            Id = 7,
                            Album = "A N D",
                            ArtistId = 7,
                            Length = 223,
                            Title = "Melon Soda"
                        });
                });

            modelBuilder.Entity("GenreSong", b =>
                {
                    b.HasOne("TunaPiano.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TunaPiano.Models.Song", null)
                        .WithMany()
                        .HasForeignKey("SongsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TunaPiano.Models.Song", b =>
                {
                    b.HasOne("TunaPiano.Models.Artist", "Artist")
                        .WithMany("Songs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("TunaPiano.Models.Artist", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}

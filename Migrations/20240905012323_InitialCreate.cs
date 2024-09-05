using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TunaPianoAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    ArtistId = table.Column<int>(type: "integer", nullable: false),
                    Album = table.Column<string>(type: "text", nullable: false),
                    Length = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SongGenre",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "integer", nullable: false),
                    SongsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongGenre", x => new { x.GenresId, x.SongsId });
                    table.ForeignKey(
                        name: "FK_SongGenre_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SongGenre_Songs_SongsId",
                        column: x => x.SongsId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Age", "Bio", "Name" },
                values: new object[,]
                {
                    { 1, 37, "An Australian music project led by multi-instrumentalist Kevin Parker, known for blending psychedelic rock with indie pop.", "Tame Impala" },
                    { 2, 46, "An American rock band from Illinois, known for pioneering the Midwest Emo genre.", "American Football" },
                    { 3, 61, "An Irish-English rock band formed in 1983, credited with popularizing the shoegaze genre.", "My Bloody Valentine" },
                    { 4, 37, "An American rapper, songwriter, and record producer known for his socially conscious lyrics and storytelling.", "Kendrick Lamar" },
                    { 5, 37, "A Canadian rapper, singer, and songwriter, known for blending rap and R&B in his music.", "Drake" },
                    { 6, 34, "An American singer and songwriter, known for her alternative R&B sound and introspective lyrics.", "SZA" },
                    { 7, 34, "A Japanese math rock band known for their complex rhythms and technical guitar work.", "Tricot" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Indie" },
                    { 2, "Midwest Emo" },
                    { 3, "Shoegaze" },
                    { 4, "Hip Hop" },
                    { 5, "Rap" },
                    { 6, "R&B" },
                    { 7, "Japanese Math Rock" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Album", "ArtistId", "Length", "Title" },
                values: new object[,]
                {
                    { 1, "Currents", 1, 216, "The Less I Know The Better" },
                    { 2, "American Football", 2, 258, "Never Meant" },
                    { 3, "Loveless", 3, 276, "Only Shallow" },
                    { 4, "DAMN.", 4, 177, "HUMBLE." },
                    { 5, "Views", 5, 267, "Hotline Bling" },
                    { 6, "Good Days - Single", 6, 271, "Good Days" },
                    { 7, "A N D", 7, 223, "Melon Soda" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SongGenre_SongsId",
                table: "SongGenre",
                column: "SongsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "SongGenre");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoGameAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedVideoGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GameImageURL",
                table: "videoGames",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GameLinkDownloadURL",
                table: "videoGames",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "videoGames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GameImageURL", "GameLinkDownloadURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "videoGames",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GameImageURL", "GameLinkDownloadURL" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "videoGames",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GameImageURL", "GameLinkDownloadURL" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameImageURL",
                table: "videoGames");

            migrationBuilder.DropColumn(
                name: "GameLinkDownloadURL",
                table: "videoGames");
        }
    }
}

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoGameAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedMoreVideoGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GameBanerImageURL",
                table: "videoGames",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<List<string>>(
                name: "GameScreenShootImageURLs",
                table: "videoGames",
                type: "text[]",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "videoGames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "GameBanerImageURL", "GameScreenShootImageURLs" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "videoGames",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "GameBanerImageURL", "GameScreenShootImageURLs" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "videoGames",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GameBanerImageURL", "GameScreenShootImageURLs" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameBanerImageURL",
                table: "videoGames");

            migrationBuilder.DropColumn(
                name: "GameScreenShootImageURLs",
                table: "videoGames");
        }
    }
}

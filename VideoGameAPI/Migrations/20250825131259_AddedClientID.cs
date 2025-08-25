using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoGameAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedClientID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Client_Id",
                table: "videoGames",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "videoGames",
                keyColumn: "Id",
                keyValue: 1,
                column: "Client_Id",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "videoGames",
                keyColumn: "Id",
                keyValue: 2,
                column: "Client_Id",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "videoGames",
                keyColumn: "Id",
                keyValue: 3,
                column: "Client_Id",
                value: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Client_Id",
                table: "videoGames");
        }
    }
}

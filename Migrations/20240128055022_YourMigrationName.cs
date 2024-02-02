using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviePlatform.Migrations
{
    public partial class YourMigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 1,
                column: "ImageUrl",
                value: "/images/Titanic.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 50, 22, 149, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 50, 22, 149, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 50, 22, 149, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 50, 22, 149, DateTimeKind.Utc).AddTicks(3438));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 1,
                column: "ImageUrl",
                value: "C:\\Users\\ACER\\Pictures\\Titanic.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 47, 23, 128, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 47, 23, 128, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 47, 23, 128, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 47, 23, 128, DateTimeKind.Utc).AddTicks(1302));
        }
    }
}

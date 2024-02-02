using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviePlatform.Migrations
{
    public partial class LocalImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 1,
                column: "ImageUrl",
                value: "images/Titanic.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 1, 27, 10, 57, 13, 407, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 1, 27, 10, 57, 13, 407, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 1, 27, 10, 57, 13, 407, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 1, 27, 10, 57, 13, 407, DateTimeKind.Utc).AddTicks(333));
        }
    }
}

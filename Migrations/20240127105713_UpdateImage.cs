using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviePlatform.Migrations
{
    public partial class UpdateImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 2,
                column: "ImageUrl",
                value: "images/DoctorStrange2.jpg");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 2,
                column: "ImageUrl",
                value: "images/DoctorStrange.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 1, 27, 9, 25, 12, 926, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 1, 27, 9, 25, 12, 926, DateTimeKind.Utc).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 1, 27, 9, 25, 12, 926, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 1, 27, 9, 25, 12, 926, DateTimeKind.Utc).AddTicks(2246));
        }
    }
}

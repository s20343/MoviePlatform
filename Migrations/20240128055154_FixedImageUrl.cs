using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviePlatform.Migrations
{
    public partial class FixedImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 2,
                column: "ImageUrl",
                value: "/images/DoctorStrange2.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 3,
                column: "ImageUrl",
                value: "/images/Hachi.jpg");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 51, 54, 483, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 51, 54, 483, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 51, 54, 483, DateTimeKind.Utc).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "IdReview",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2024, 1, 28, 5, 51, 54, 483, DateTimeKind.Utc).AddTicks(4928));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 2,
                column: "ImageUrl",
                value: "images/DoctorStrange2.jpg");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "IdMovie",
                keyValue: 3,
                column: "ImageUrl",
                value: "images/Hachi.jpg");

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
    }
}

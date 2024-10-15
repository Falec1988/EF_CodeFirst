using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "DateOfBirth", "Height", "StudentName", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 178m, "Ivan Horvat", 75.5f },
                    { 2, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 183m, "Matija Kršić", 90.2f },
                    { 3, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 175m, "Zoran Stipić", 72.2f }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "GradeId", "GradeName", "Section", "StudentId" },
                values: new object[,]
                {
                    { 1, "A", "1", 1 },
                    { 2, "B", "1", 2 },
                    { 3, "C", "2", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grades",
                keyColumn: "GradeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);
        }
    }
}

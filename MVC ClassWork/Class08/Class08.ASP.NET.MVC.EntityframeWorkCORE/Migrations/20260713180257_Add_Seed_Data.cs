using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Class08.ASP.NET.MVC.EntityframeWorkCORE.Migrations
{
    /// <inheritdoc />
    public partial class Add_Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "IsActiveCourse", "Name", "NumberOfClasses" },
                values: new object[,]
                {
                    { 1, false, "C# basic", 40 },
                    { 2, false, "C# Advanced", 60 },
                    { 3, false, "Database development and design", 28 },
                    { 4, false, "ASP.NET Mvc", 40 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ActiveCourseId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(1999, 7, 13, 20, 2, 56, 497, DateTimeKind.Local).AddTicks(4252), "Bob", "Bobski" },
                    { 2, 4, new DateTime(1989, 7, 13, 20, 2, 56, 499, DateTimeKind.Local).AddTicks(3440), "Jill", "Jilski" },
                    { 3, 4, new DateTime(1981, 7, 13, 20, 2, 56, 499, DateTimeKind.Local).AddTicks(3471), "John", "Doe" },
                    { 4, 4, new DateTime(2009, 7, 13, 20, 2, 56, 499, DateTimeKind.Local).AddTicks(3474), "Jane", "Doe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RentWaveApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ExpandedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "AgeRestriction", "CreatedOn", "Genre", "IsAvailable", "Language", "Length", "Quantity", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 3, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true, 10, new TimeSpan(0, 2, 15, 0, 0), 2, new DateTime(2018, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shadows of Kolarov" },
                    { 4, 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, true, 1, new TimeSpan(0, 1, 38, 0, 0), 4, new DateTime(2022, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Silent Attic" },
                    { 5, 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, true, 4, new TimeSpan(0, 1, 55, 0, 0), 0, new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Midnight Ledger" },
                    { 6, 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, true, 3, new TimeSpan(0, 1, 42, 0, 0), 6, new DateTime(2017, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paper Hearts in Lyon" },
                    { 7, 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, true, 1, new TimeSpan(0, 2, 32, 0, 0), 3, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Realm of Ashenfall" },
                    { 8, 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, true, 1, new TimeSpan(0, 1, 20, 0, 0), 2, new DateTime(2016, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voices of the Reef" },
                    { 9, 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, true, 6, new TimeSpan(0, 1, 30, 0, 0), 5, new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaiju Kindergarten" },
                    { 10, 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, true, 2, new TimeSpan(0, 2, 8, 0, 0), 4, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steel and Sand" },
                    { 11, 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, true, 5, new TimeSpan(0, 1, 50, 0, 0), 3, new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Understudy" },
                    { 12, 0, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, true, 7, new TimeSpan(0, 1, 48, 0, 0), 5, new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comedy of Errors, Seoul" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "CardNumber", "CreatedOn", "FullName", "IsSubscriptionExpired", "SubscriptionId" },
                values: new object[,]
                {
                    { 3, 41, "5555-6666", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elena Dimova", false, 1 },
                    { 4, 23, "7777-8888", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stefan Kolev", true, 2 }
                });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "CreatedOn", "MovieId", "Name", "PartName" },
                values: new object[,]
                {
                    { 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Boris Nikolov", 1 },
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Irina Volkova", 4 },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Grace Whitmore", 1 },
                    { 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Klaus Berger", 2 },
                    { 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Camille Laurent", 1 },
                    { 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Owen Marsh", 1 },
                    { 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Haruto Sato", 7 },
                    { 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Diego Ramirez", 1 },
                    { 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Ji-ho Park", 1 }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "CreatedOn", "MovieId", "RentedOn", "ReturnedOn", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1 },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}

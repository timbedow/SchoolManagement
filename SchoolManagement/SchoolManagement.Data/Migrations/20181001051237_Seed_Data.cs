using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolManagement.Data.Migrations
{
    public partial class Seed_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "ImageUrl", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1942, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harrison", "https://www.randomlists.com/img/people/harrison_ford.jpg", "Ford" },
                    { 2, new DateTime(1983, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carrie", "https://www.randomlists.com/img/people/carrie_underwood.jpg", "Underwood" },
                    { 3, new DateTime(1972, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ben", "https://www.randomlists.com/img/people/ben_affleck.jpg", "Affleck" },
                    { 4, new DateTime(1963, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Johnny", "https://www.randomlists.com/img/people/johnny_depp.jpg", "Depp" },
                    { 5, new DateTime(1981, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Natalie", "https://www.randomlists.com/img/people/natalie_portman.jpg", "Portman" },
                    { 6, new DateTime(1966, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", "https://www.randomlists.com/img/people/adam_sandler.jpg", "Sandler" },
                    { 7, new DateTime(1975, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bradley", "https://www.randomlists.com/img/people/bradley_cooper.jpg", "Cooper" },
                    { 8, new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Keanu", "https://www.randomlists.com/img/people/keanu_reeves.jpg", "Depp" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}

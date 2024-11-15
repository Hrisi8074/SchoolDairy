using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolDairy.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedTableStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Classroom", "FirstName", "FormOfTraining", "LastName", "MiddleName", "Number", "ParentId", "Specialty", "TeacherId" },
                values: new object[,]
                {
                    { 1, "10", "Ivanka", "Day", "Pekova", "Zheleva", 10, 1, 2, 1 },
                    { 2, "8", "Lubo", "Day", "Lubomirov", "Lubomirov", 14, 2, 3, 2 },
                    { 3, "9", "Zlatan", "Day", "Hristov", "Tihomirov", 12, 3, 1, 3 }
                });
        }

        /// <inheritdoc />
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
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolDairy.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "EmailAddres", "FirstName", "Gender", "LastName", "PhoneNumber", "UserNameParent" },
                values: new object[,]
                {
                    { 1, "ivaptrova@abv.bg", "Ivelina", null, "Petrova", "+359123654789", null },
                    { 2, "ivanov@abv.bg", "Petar", null, "Ivanov", "+359987456321", null },
                    { 3, "hhistov@abv.bg", "Hristo", null, "Hristov", "+359456981234", null }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ClassTeacher", "EmailAddres", "FirstName", "LastName", "MiddleName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "10G", "bilova@321su.edu.mon", "Tina", "Boilova", "Boilova", "+35959874135" },
                    { 2, "11B", "tstoilov@321su.edu.mon", "Todor", "Stoilov", "Todorov", "+359563214855" },
                    { 3, "9A", "tpetrov@321su.edu.mon", "Tihomir", "Petrov", "Tihomirov", "+359913648235" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

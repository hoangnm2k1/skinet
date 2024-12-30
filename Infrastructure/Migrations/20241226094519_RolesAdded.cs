using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RolesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69f170cc-9e04-48a5-af6a-a51c37acd040");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eed3b36-3483-4855-ad0a-93c8021f91e3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31cd7185-71fa-45d7-8574-fdefc7b4719e", null, "Admin", "ADMIN" },
                    { "c9cdab47-aec3-47fa-9f21-818318e22abe", null, "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31cd7185-71fa-45d7-8574-fdefc7b4719e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9cdab47-aec3-47fa-9f21-818318e22abe");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69f170cc-9e04-48a5-af6a-a51c37acd040", null, "Admin", "ADMIN" },
                    { "9eed3b36-3483-4855-ad0a-93c8021f91e3", null, "Customer", "CUSTOMER" }
                });
        }
    }
}

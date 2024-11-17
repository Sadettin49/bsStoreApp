using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c8325f7a-04a0-4767-a132-8bccf209a45a", null, "Editor", "EDITOR" },
                    { "f213d54e-4ea3-47ea-9f0c-919e790ed87e", null, "User", "USER" },
                    { "f71201c3-e7ee-4ccf-a840-d414ce0793f4", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8325f7a-04a0-4767-a132-8bccf209a45a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f213d54e-4ea3-47ea-9f0c-919e790ed87e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f71201c3-e7ee-4ccf-a840-d414ce0793f4");
        }
    }
}

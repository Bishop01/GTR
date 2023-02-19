using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class TOKEN_TABLE_EXPIRE_COL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiresAt",
                table: "Tokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2b$10$IuIjr.ncq9UNBj3pUjG/2emWUFYVkdTFnOOaT/YPzaka8nqdDqMuq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2b$10$/JdDs.mhrCXtkXHHJqowaeJJCI/v2yJdyYOojcrCoWEI9VZ07lLYW");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiresAt",
                table: "Tokens");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2b$10$bNkWs23LShFEmvhaRf2o6OYGZAVbfH/5tGcHJT9KqirLITa/0n0ky");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2b$10$8eQVctAAboJ8d16vOsFoxOgaVTs0unRV8A4MGsrAhL2mERfW5nEpK");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class updateidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "8b71a503-aaba-43be-b2c7-957d4c6718a4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "fbadc973-4194-4beb-a6cb-b661a0bf775b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf2bd6b8-c05c-4816-9cb9-7c8470593c7c", "AQAAAAEAACcQAAAAEDeKjHWq6+9OI/gWH+pML2W7/sBW5MJmmncN1dBl1G/4FqrXze9YJOGTf24hhayaMQ==", "cc951a00-ffc5-4857-9b1f-d0abd043ac9d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998,
                column: "ConcurrencyStamp",
                value: "80649701-ae2c-40dc-8c4b-ace5e775a766");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "ab90af5b-cb4b-4911-abb3-af68b00cea3c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "890e1792-2f4e-42bf-9f67-78d023a851a2", "AQAAAAEAACcQAAAAEFcZY9kxN0PTqRDYyrq0T/IDf/re2h2R8Ts+NW3MASmaS3JwL4ICJT20FjXMNeWiQw==", "9c2bd3f9-badf-4be2-bf31-421d999d6162" });
        }
    }
}

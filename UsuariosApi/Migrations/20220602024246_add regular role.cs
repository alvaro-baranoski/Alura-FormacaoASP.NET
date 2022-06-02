using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class addregularrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "ab90af5b-cb4b-4911-abb3-af68b00cea3c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99998, "80649701-ae2c-40dc-8c4b-ace5e775a766", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "890e1792-2f4e-42bf-9f67-78d023a851a2", "AQAAAAEAACcQAAAAEFcZY9kxN0PTqRDYyrq0T/IDf/re2h2R8Ts+NW3MASmaS3JwL4ICJT20FjXMNeWiQw==", "9c2bd3f9-badf-4be2-bf31-421d999d6162" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99998);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "7a43d229-7ede-47b3-82f1-e801df32ebf6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f55b3feb-f906-4f13-8a3b-a8dcdcf553a0", "AQAAAAEAACcQAAAAEMSNKIcUWybycg9k7sGWZURM+T9FJZHbCeWCtk4S0yHYW5Ufm/YsfuYz4uVxPj/zxQ==", "65f81670-20d1-4d8a-98c5-ff3528483c7f" });
        }
    }
}

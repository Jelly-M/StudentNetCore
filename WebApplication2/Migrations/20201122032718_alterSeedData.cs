using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class alterSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "Email", "Gread", "Name" },
                values: new object[] { 2, "97202766@qq.com", 1, "张x三" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "Email", "Gread", "Name" },
                values: new object[] { 3, "97202766@qq.com", 1, "x三" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "Email", "Gread", "Name" },
                values: new object[] { 1, "97202766@qq.com", 1, "张三" });
        }
    }
}

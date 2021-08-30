using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventLogin.Migrations
{
    public partial class changes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3a581426-c157-4ee3-9ead-f625173c8afe"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("64251c78-b945-4b55-bcc7-47eecd20add8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6b19770c-8dcf-4e2c-913e-677875f0618f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("781f3e49-9407-4ae7-a3d8-715736372dce"));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Location", "MaxUsers", "Name" },
                values: new object[] { new Guid("0869f4bb-a84a-478d-a71a-63ba3349dfba"), new DateTime(2021, 8, 25, 8, 37, 14, 45, DateTimeKind.Local).AddTicks(8800), "Berlin", 20, "Volksfest" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Location", "MaxUsers", "Name" },
                values: new object[] { new Guid("031f34a9-ab3c-4152-8381-06275c0e3cba"), new DateTime(2021, 8, 25, 8, 37, 14, 61, DateTimeKind.Local).AddTicks(3200), "Dortmund", 30, "Blackroom" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DSize", "Email", "Name" },
                values: new object[] { new Guid("f0e9199e-490d-42e3-a2de-2d3f75fd57b4"), 2, "fickwurst@schnitzel.de", "Peter" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DSize", "Email", "Name" },
                values: new object[] { new Guid("41220f97-2a72-4c52-8078-61b3973eff5c"), 12, "schnitzel@fickwurst.de", "Jürgen" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("031f34a9-ab3c-4152-8381-06275c0e3cba"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0869f4bb-a84a-478d-a71a-63ba3349dfba"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("41220f97-2a72-4c52-8078-61b3973eff5c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f0e9199e-490d-42e3-a2de-2d3f75fd57b4"));

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Location", "MaxUsers", "Name" },
                values: new object[] { new Guid("3a581426-c157-4ee3-9ead-f625173c8afe"), new DateTime(2021, 8, 11, 16, 7, 45, 773, DateTimeKind.Local).AddTicks(5300), "Berlin", 20, "Volksfest" });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Location", "MaxUsers", "Name" },
                values: new object[] { new Guid("64251c78-b945-4b55-bcc7-47eecd20add8"), new DateTime(2021, 8, 11, 16, 7, 45, 789, DateTimeKind.Local).AddTicks(8360), "Dortmund", 30, "Blackroom" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DSize", "Email", "Name" },
                values: new object[] { new Guid("6b19770c-8dcf-4e2c-913e-677875f0618f"), 2, "fickwurst@schnitzel.de", "Peter" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "DSize", "Email", "Name" },
                values: new object[] { new Guid("781f3e49-9407-4ae7-a3d8-715736372dce"), 12, "schnitzel@fickwurst.de", "Jürgen" });
        }
    }
}

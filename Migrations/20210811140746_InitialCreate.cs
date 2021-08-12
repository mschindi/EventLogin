using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventLogin.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    MaxUsers = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    DSize = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventEntityUserEntity",
                columns: table => new
                {
                    EventsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UsersId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventEntityUserEntity", x => new { x.EventsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_EventEntityUserEntity_Event_EventsId",
                        column: x => x.EventsId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventEntityUserEntity_User_UsersId",
                        column: x => x.UsersId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_EventEntityUserEntity_UsersId",
                table: "EventEntityUserEntity",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventEntityUserEntity");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerApi.Migrations
{
    public partial class firstmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(nullable: true),
                    CDob = table.Column<DateTime>(nullable: false),
                    CPIN = table.Column<int>(maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CId);
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CId", "CDob", "CName", "CPIN" },
                values: new object[] { 1, new DateTime(2019, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "sam", 1234 });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CId", "CDob", "CName", "CPIN" },
                values: new object[] { 2, new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "sami", 4562 });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CId", "CDob", "CName", "CPIN" },
                values: new object[] { 3, new DateTime(2019, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "sameer", 7894 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}

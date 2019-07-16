using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Wow.Infra.Data.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    HolderAccountName = table.Column<string>(maxLength: 250, nullable: false),
                    AccountNumber = table.Column<string>(maxLength: 8, nullable: false),
                    ValueBalance = table.Column<double>(nullable: false),
                    ValueLimit = table.Column<double>(nullable: false),
                    Blocked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Guid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}

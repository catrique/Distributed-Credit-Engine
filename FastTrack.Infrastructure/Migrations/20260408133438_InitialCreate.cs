using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastTrack.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proposals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Document = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    RequestedAmount = table.Column<decimal>(type: "DECIMAL(18,2)", nullable: false),
                    Installments = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "DECIMAL(18,2)", maxLength: 30, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proposals", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proposals");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cardsAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "stud",
                columns: table => new
                {
                    StudID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stud", x => x.StudID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stud");
        }
    }
}

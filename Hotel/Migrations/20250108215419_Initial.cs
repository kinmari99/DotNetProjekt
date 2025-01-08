using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Newsletters",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IdNewsletter = table.Column<int>(type: "int", nullable: false),
                    IdUżytkownika = table.Column<int>(type: "int", nullable: false),
                    użytkownikId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletters", x => x.Email);
                    table.ForeignKey(
                        name: "FK_Newsletters_Users_użytkownikId",
                        column: x => x.użytkownikId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IdRezerwacja = table.Column<int>(type: "int", nullable: false),
                    IdUżytkownika = table.Column<int>(type: "int", nullable: false),
                    użytkownikId = table.Column<int>(type: "int", nullable: false),
                    IdPracownik = table.Column<int>(type: "int", nullable: false),
                    pracownikId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IDCard = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Building = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Apartment = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    PostalCode = table.Column<string>(type: "char(6)", maxLength: 6, nullable: false),
                    PostOffice = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "date", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    HowManyRooms = table.Column<int>(type: "int", nullable: false),
                    HowManyBeds = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Email);
                    table.ForeignKey(
                        name: "FK_Reservations_Users_użytkownikId",
                        column: x => x.użytkownikId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Workers_pracownikId",
                        column: x => x.pracownikId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Newsletters_użytkownikId",
                table: "Newsletters",
                column: "użytkownikId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_pracownikId",
                table: "Reservations",
                column: "pracownikId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_użytkownikId",
                table: "Reservations",
                column: "użytkownikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Newsletters");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}

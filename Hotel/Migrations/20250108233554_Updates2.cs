using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Updates2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdPracownik",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "IdUżytkownika",
                table: "Reservations");

            migrationBuilder.AddColumn<string>(
                name: "Haslo",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "powtorzHaslo",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Haslo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "powtorzHaslo",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "IdPracownik",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUżytkownika",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

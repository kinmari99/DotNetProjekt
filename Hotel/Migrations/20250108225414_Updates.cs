using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Newsletters_Users_użytkownikId",
                table: "Newsletters");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_użytkownikId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Workers_pracownikId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "IdNewsletter",
                table: "Newsletters");

            migrationBuilder.DropColumn(
                name: "IdUżytkownika",
                table: "Newsletters");

            migrationBuilder.AlterColumn<int>(
                name: "użytkownikId",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "pracownikId",
                table: "Reservations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "użytkownikId",
                table: "Newsletters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Newsletters_Users_użytkownikId",
                table: "Newsletters",
                column: "użytkownikId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_użytkownikId",
                table: "Reservations",
                column: "użytkownikId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Workers_pracownikId",
                table: "Reservations",
                column: "pracownikId",
                principalTable: "Workers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Newsletters_Users_użytkownikId",
                table: "Newsletters");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_użytkownikId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Workers_pracownikId",
                table: "Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "użytkownikId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pracownikId",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "użytkownikId",
                table: "Newsletters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdNewsletter",
                table: "Newsletters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUżytkownika",
                table: "Newsletters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Newsletters_Users_użytkownikId",
                table: "Newsletters",
                column: "użytkownikId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_użytkownikId",
                table: "Reservations",
                column: "użytkownikId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Workers_pracownikId",
                table: "Reservations",
                column: "pracownikId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

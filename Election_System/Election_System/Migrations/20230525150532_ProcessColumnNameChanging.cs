using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Election_System.Migrations
{
    /// <inheritdoc />
    public partial class ProcessColumnNameChanging : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_processes_administrations_AdministratonId",
                table: "processes");

            migrationBuilder.RenameColumn(
                name: "AdministratonId",
                table: "processes",
                newName: "AdministrationId");

            migrationBuilder.RenameIndex(
                name: "IX_processes_AdministratonId",
                table: "processes",
                newName: "IX_processes_AdministrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_processes_administrations_AdministrationId",
                table: "processes",
                column: "AdministrationId",
                principalTable: "administrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_processes_administrations_AdministrationId",
                table: "processes");

            migrationBuilder.RenameColumn(
                name: "AdministrationId",
                table: "processes",
                newName: "AdministratonId");

            migrationBuilder.RenameIndex(
                name: "IX_processes_AdministrationId",
                table: "processes",
                newName: "IX_processes_AdministratonId");

            migrationBuilder.AddForeignKey(
                name: "FK_processes_administrations_AdministratonId",
                table: "processes",
                column: "AdministratonId",
                principalTable: "administrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}

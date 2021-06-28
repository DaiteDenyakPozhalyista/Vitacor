using Microsoft.EntityFrameworkCore.Migrations;

namespace WindowsFormsApp1.Migrations
{
    public partial class ChangeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beasts_Vaccines_VaccineId",
                table: "Beasts");

            migrationBuilder.DropIndex(
                name: "IX_Beasts_VaccineId",
                table: "Beasts");

            migrationBuilder.DropColumn(
                name: "VaccineId",
                table: "Beasts");

            migrationBuilder.AddColumn<int>(
                name: "VaccinesId",
                table: "Beasts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beasts_VaccinesId",
                table: "Beasts",
                column: "VaccinesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beasts_Vaccines_VaccinesId",
                table: "Beasts",
                column: "VaccinesId",
                principalTable: "Vaccines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beasts_Vaccines_VaccinesId",
                table: "Beasts");

            migrationBuilder.DropIndex(
                name: "IX_Beasts_VaccinesId",
                table: "Beasts");

            migrationBuilder.DropColumn(
                name: "VaccinesId",
                table: "Beasts");

            migrationBuilder.AddColumn<int>(
                name: "VaccineId",
                table: "Beasts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beasts_VaccineId",
                table: "Beasts",
                column: "VaccineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beasts_Vaccines_VaccineId",
                table: "Beasts",
                column: "VaccineId",
                principalTable: "Vaccines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

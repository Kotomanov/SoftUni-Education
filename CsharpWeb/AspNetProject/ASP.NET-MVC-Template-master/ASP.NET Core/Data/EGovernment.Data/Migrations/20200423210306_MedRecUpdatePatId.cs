using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreTemplate.Data.Migrations
{
    public partial class MedRecUpdatePatId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "MedicalRecords",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "MedicalRecords",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}

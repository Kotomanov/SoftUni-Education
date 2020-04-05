using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreTemplate.Data.Migrations
{
    public partial class UpdatedModelsAndMappingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_MedicalRecords_MedicalRecordId",
                table: "Diagnoses");

            migrationBuilder.DropForeignKey(
                name: "FK_Entities_Visits_VisitId",
                table: "Entities");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Visits_VisitId",
                table: "Medicines");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Patients_PatientId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_PatientId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Patients_MedicalRecordId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_VisitId",
                table: "Medicines");

            migrationBuilder.DropIndex(
                name: "IX_Entities_VisitId",
                table: "Entities");

            migrationBuilder.DropIndex(
                name: "IX_Diagnoses_MedicalRecordId",
                table: "Diagnoses");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Visits");

            migrationBuilder.DropColumn(
                name: "VisitId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "VisitId",
                table: "Entities");

            migrationBuilder.DropColumn(
                name: "VisitsCount",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "MedicalRecordId",
                table: "Diagnoses");

            migrationBuilder.DropColumn(
                name: "PatientsCount",
                table: "Diagnoses");

            migrationBuilder.AlterColumn<int>(
                name: "MedicalRecordId",
                table: "Visits",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EGN",
                table: "Patients",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "MedicalRecords",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "EGN",
                table: "Employees",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EGN",
                table: "Doctors",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "EntityVisit",
                columns: table => new
                {
                    VisitId = table.Column<int>(nullable: false),
                    EntityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityVisit", x => new { x.VisitId, x.EntityId });
                    table.ForeignKey(
                        name: "FK_EntityVisit_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntityVisit_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicineVisit",
                columns: table => new
                {
                    MedicineId = table.Column<int>(nullable: false),
                    VisitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineVisit", x => new { x.MedicineId, x.VisitId });
                    table.ForeignKey(
                        name: "FK_MedicineVisit_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicineVisit_Visits_VisitId",
                        column: x => x.VisitId,
                        principalTable: "Visits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecordDiagnose",
                columns: table => new
                {
                    MedicalRecordId = table.Column<int>(nullable: false),
                    DiagnoseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecordDiagnose", x => new { x.MedicalRecordId, x.DiagnoseId });
                    table.ForeignKey(
                        name: "FK_RecordDiagnose_Diagnoses_DiagnoseId",
                        column: x => x.DiagnoseId,
                        principalTable: "Diagnoses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RecordDiagnose_MedicalRecords_MedicalRecordId",
                        column: x => x.MedicalRecordId,
                        principalTable: "MedicalRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MedicalRecordId",
                table: "Patients",
                column: "MedicalRecordId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_AddressId",
                table: "Doctors",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityVisit_EntityId",
                table: "EntityVisit",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineVisit_VisitId",
                table: "MedicineVisit",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_RecordDiagnose_DiagnoseId",
                table: "RecordDiagnose",
                column: "DiagnoseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Addresses_AddressId",
                table: "Doctors",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Addresses_AddressId",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "EntityVisit");

            migrationBuilder.DropTable(
                name: "MedicineVisit");

            migrationBuilder.DropTable(
                name: "RecordDiagnose");

            migrationBuilder.DropIndex(
                name: "IX_Patients_MedicalRecordId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_AddressId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "MedicalRecords");

            migrationBuilder.AlterColumn<int>(
                name: "MedicalRecordId",
                table: "Visits",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "PatientId",
                table: "Visits",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "EGN",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AddColumn<int>(
                name: "VisitId",
                table: "Medicines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisitId",
                table: "Entities",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EGN",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "EGN",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisitsCount",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MedicalRecordId",
                table: "Diagnoses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatientsCount",
                table: "Diagnoses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Visits_PatientId",
                table: "Visits",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MedicalRecordId",
                table: "Patients",
                column: "MedicalRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_VisitId",
                table: "Medicines",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Entities_VisitId",
                table: "Entities",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnoses_MedicalRecordId",
                table: "Diagnoses",
                column: "MedicalRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_MedicalRecords_MedicalRecordId",
                table: "Diagnoses",
                column: "MedicalRecordId",
                principalTable: "MedicalRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Entities_Visits_VisitId",
                table: "Entities",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Visits_VisitId",
                table: "Medicines",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Patients_PatientId",
                table: "Visits",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
